// Copyright 2009 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

//go:generate go run mkbuiltin.go

// package gc -- go2cs converted at 2020 August 29 09:27:25 UTC
// import "cmd/compile/internal/gc" ==> using gc = go.cmd.compile.@internal.gc_package
// Original source: C:\Go\src\cmd\compile\internal\gc\main.go
using bufio = go.bufio_package;
using bytes = go.bytes_package;
using ssa = go.cmd.compile.@internal.ssa_package;
using types = go.cmd.compile.@internal.types_package;
using dwarf = go.cmd.@internal.dwarf_package;
using obj = go.cmd.@internal.obj_package;
using objabi = go.cmd.@internal.objabi_package;
using src = go.cmd.@internal.src_package;
using sys = go.cmd.@internal.sys_package;
using flag = go.flag_package;
using fmt = go.fmt_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using log = go.log_package;
using os = go.os_package;
using path = go.path_package;
using runtime = go.runtime_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using static go.builtin;
using System;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class gc_package
    {
        private static bool imported_unsafe = default;

        private static @string buildid = default;

        public static long Debug_append = default;        public static bool Debug_asm = default;        public static long Debug_closure = default;        public static long Debug_compilelater = default;        private static long debug_dclstack = default;        public static long Debug_panic = default;        public static long Debug_slice = default;        public static bool Debug_vlog = default;        public static long Debug_wb = default;        public static long Debug_eagerwb = default;        public static @string Debug_pctab = default;        public static long Debug_locationlist = default;        public static long Debug_typecheckinl = default;        public static long Debug_gendwarfinl = default;        public static long Debug_softfloat = default;

        // Debug arguments.
        // These can be specified with the -d flag, as in "-d nil"
        // to set the debug_checknil variable.
        // Multiple options can be comma-separated.
        // Each option accepts an optional argument, as in "gcprog=2"


        private static readonly @string debugHelpHeader = "usage: -d arg[,arg]* and arg is <key>[=<value>]\n\n<key> is one of:\n\n";



        private static readonly @string debugHelpFooter = "\n<value> is key-specific.\n\nKey \"pctab\" supports values:\n\t\"pctospadj\", \"pctofile\"," +
    " \"pctoline\", \"pctoinline\", \"pctopcdata\"\n";



        private static void usage()
        {
            fmt.Printf("usage: compile [options] file.go...\n");
            objabi.Flagprint(1L);
            Exit(2L);
        }

        private static void hidePanic()
        {
            if (Debug_panic == 0L && nsavederrors + nerrors > 0L)
            { 
                // If we've already complained about things
                // in the program, don't bother complaining
                // about a panic too; let the user clean up
                // the code and try again.
                {
                    var err = recover();

                    if (err != null)
                    {
                        errorexit();
                    }

                }
            }
        }

        // supportsDynlink reports whether or not the code generator for the given
        // architecture supports the -shared and -dynlink flags.
        private static bool supportsDynlink(ref sys.Arch arch)
        {
            return arch.InFamily(sys.AMD64, sys.ARM, sys.ARM64, sys.I386, sys.PPC64, sys.S390X);
        }

        // timing data for compiler phases
        private static Timings timings = default;
        private static @string benchfile = default;

        private static ref nowritebarrierrecChecker nowritebarrierrecCheck = default;

        // Main parses flags and Go source files specified in the command-line
        // arguments, type-checks the parsed Go package, compiles functions to machine
        // code, and finally writes the compiled package definition to disk.
        public static void Main(Action<ref Arch> archInit) => func((defer, panic, _) =>
        {
            timings.Start("fe", "init");

            defer(hidePanic());

            archInit(ref thearch);

            Ctxt = obj.Linknew(thearch.LinkArch);
            Ctxt.DiagFunc = yyerror;
            Ctxt.DiagFlush = flusherrors;
            Ctxt.Bso = bufio.NewWriter(os.Stdout);

            localpkg = types.NewPkg("", "");
            localpkg.Prefix = "\"\""; 

            // pseudo-package, for scoping
            builtinpkg = types.NewPkg("go.builtin", ""); // TODO(gri) name this package go.builtin?
            builtinpkg.Prefix = "go.builtin"; // not go%2ebuiltin

            // pseudo-package, accessed by import "unsafe"
            unsafepkg = types.NewPkg("unsafe", "unsafe"); 

            // Pseudo-package that contains the compiler's builtin
            // declarations for package runtime. These are declared in a
            // separate package to avoid conflicts with package runtime's
            // actual declarations, which may differ intentionally but
            // insignificantly.
            Runtimepkg = types.NewPkg("go.runtime", "runtime");
            Runtimepkg.Prefix = "runtime"; 

            // pseudo-packages used in symbol tables
            itabpkg = types.NewPkg("go.itab", "go.itab");
            itabpkg.Prefix = "go.itab"; // not go%2eitab

            itablinkpkg = types.NewPkg("go.itablink", "go.itablink");
            itablinkpkg.Prefix = "go.itablink"; // not go%2eitablink

            trackpkg = types.NewPkg("go.track", "go.track");
            trackpkg.Prefix = "go.track"; // not go%2etrack

            // pseudo-package used for map zero values
            mappkg = types.NewPkg("go.map", "go.map");
            mappkg.Prefix = "go.map";

            Nacl = objabi.GOOS == "nacl";

            flag.BoolVar(ref compiling_runtime, "+", false, "compiling runtime");
            flag.BoolVar(ref compiling_std, "std", false, "compiling standard library");
            objabi.Flagcount("%", "debug non-static initializers", ref Debug['%']);
            objabi.Flagcount("B", "disable bounds checking", ref Debug['B']);
            objabi.Flagcount("C", "disable printing of columns in error messages", ref Debug['C']); // TODO(gri) remove eventually
            flag.StringVar(ref localimport, "D", "", "set relative `path` for local imports");
            objabi.Flagcount("E", "debug symbol export", ref Debug['E']);
            objabi.Flagfn1("I", "add `directory` to import search path", addidir);
            objabi.Flagcount("K", "debug missing line numbers", ref Debug['K']);
            objabi.Flagcount("L", "show full file names in error messages", ref Debug['L']);
            objabi.Flagcount("N", "disable optimizations", ref Debug['N']);
            flag.BoolVar(ref Debug_asm, "S", false, "print assembly listing");
            objabi.AddVersionFlag(); // -V
            objabi.Flagcount("W", "debug parse tree after type checking", ref Debug['W']);
            flag.StringVar(ref asmhdr, "asmhdr", "", "write assembly header to `file`");
            flag.StringVar(ref buildid, "buildid", "", "record `id` as the build id in the export metadata");
            flag.IntVar(ref nBackendWorkers, "c", 1L, "concurrency during compilation, 1 means no concurrency");
            flag.BoolVar(ref pure_go, "complete", false, "compiling complete package (no C or assembly)");
            flag.StringVar(ref debugstr, "d", "", "print debug information about items in `list`; try -d help");
            flag.BoolVar(ref flagDWARF, "dwarf", true, "generate DWARF symbols");
            flag.BoolVar(ref Ctxt.Flag_locationlists, "dwarflocationlists", false, "add location lists to DWARF in optimized mode");
            flag.IntVar(ref genDwarfInline, "gendwarfinl", 2L, "generate DWARF inline info records");
            objabi.Flagcount("e", "no limit on number of errors reported", ref Debug['e']);
            objabi.Flagcount("f", "debug stack frames", ref Debug['f']);
            objabi.Flagcount("h", "halt on error", ref Debug['h']);
            objabi.Flagcount("i", "debug line number stack", ref Debug['i']);
            objabi.Flagfn1("importmap", "add `definition` of the form source=actual to import map", addImportMap);
            objabi.Flagfn1("importcfg", "read import configuration from `file`", readImportCfg);
            flag.StringVar(ref flag_installsuffix, "installsuffix", "", "set pkg directory `suffix`");
            objabi.Flagcount("j", "debug runtime-initialized variables", ref Debug['j']);
            objabi.Flagcount("l", "disable inlining", ref Debug['l']);
            flag.StringVar(ref linkobj, "linkobj", "", "write linker-specific object to `file`");
            objabi.Flagcount("live", "debug liveness analysis", ref debuglive);
            objabi.Flagcount("m", "print optimization decisions", ref Debug['m']);
            flag.BoolVar(ref flag_msan, "msan", false, "build code compatible with C/C++ memory sanitizer");
            flag.BoolVar(ref dolinkobj, "dolinkobj", true, "generate linker-specific objects; if false, some invalid code may compile");
            flag.BoolVar(ref nolocalimports, "nolocalimports", false, "reject local (relative) imports");
            flag.StringVar(ref outfile, "o", "", "write output to `file`");
            flag.StringVar(ref myimportpath, "p", "", "set expected package import `path`");
            flag.BoolVar(ref writearchive, "pack", false, "write package file instead of object file");
            objabi.Flagcount("r", "debug generated wrappers", ref Debug['r']);
            flag.BoolVar(ref flag_race, "race", false, "enable race detector");
            objabi.Flagcount("s", "warn about composite literals that can be simplified", ref Debug['s']);
            flag.StringVar(ref pathPrefix, "trimpath", "", "remove `prefix` from recorded source file paths");
            flag.BoolVar(ref safemode, "u", false, "reject unsafe code");
            flag.BoolVar(ref Debug_vlog, "v", false, "increase debug verbosity");
            objabi.Flagcount("w", "debug type checking", ref Debug['w']);
            flag.BoolVar(ref use_writebarrier, "wb", true, "enable write barrier");
            bool flag_shared = default;
            bool flag_dynlink = default;
            if (supportsDynlink(thearch.LinkArch.Arch))
            {
                flag.BoolVar(ref flag_shared, "shared", false, "generate code that can be linked into a shared library");
                flag.BoolVar(ref flag_dynlink, "dynlink", false, "support references to Go symbols defined in other shared libraries");
            }
            flag.StringVar(ref cpuprofile, "cpuprofile", "", "write cpu profile to `file`");
            flag.StringVar(ref memprofile, "memprofile", "", "write memory profile to `file`");
            flag.Int64Var(ref memprofilerate, "memprofilerate", 0L, "set runtime.MemProfileRate to `rate`");
            @string goversion = default;
            flag.StringVar(ref goversion, "goversion", "", "required version of the runtime");
            flag.StringVar(ref traceprofile, "traceprofile", "", "write an execution trace to `file`");
            flag.StringVar(ref blockprofile, "blockprofile", "", "write block profile to `file`");
            flag.StringVar(ref mutexprofile, "mutexprofile", "", "write mutex profile to `file`");
            flag.StringVar(ref benchfile, "bench", "", "append benchmark times to `file`");
            objabi.Flagparse(usage); 

            // Record flags that affect the build result. (And don't
            // record flags that don't, since that would cause spurious
            // changes in the binary.)
            recordFlags("B", "N", "l", "msan", "race", "shared", "dynlink", "dwarflocationlists");

            Ctxt.Flag_shared = flag_dynlink || flag_shared;
            Ctxt.Flag_dynlink = flag_dynlink;
            Ctxt.Flag_optimize = Debug['N'] == 0L;

            Ctxt.Debugasm = Debug_asm;
            Ctxt.Debugvlog = Debug_vlog;
            if (flagDWARF)
            {
                Ctxt.DebugInfo = debuginfo;
                Ctxt.GenAbstractFunc = genAbstractFunc;
                Ctxt.DwFixups = obj.NewDwarfFixupTable(Ctxt);
            }
            else
            { 
                // turn off inline generation if no dwarf at all
                genDwarfInline = 0L;
            }
            if (flag.NArg() < 1L && debugstr != "help" && debugstr != "ssa/help")
            {
                usage();
            }
            if (goversion != "" && goversion != runtime.Version())
            {
                fmt.Printf("compile: version %q does not match go tool version %q\n", runtime.Version(), goversion);
                Exit(2L);
            }
            thearch.LinkArch.Init(Ctxt);

            if (outfile == "")
            {
                var p = flag.Arg(0L);
                {
                    var i__prev2 = i;

                    var i = strings.LastIndex(p, "/");

                    if (i >= 0L)
                    {
                        p = p[i + 1L..];
                    }

                    i = i__prev2;

                }
                if (runtime.GOOS == "windows")
                {
                    {
                        var i__prev3 = i;

                        i = strings.LastIndex(p, "\\");

                        if (i >= 0L)
                        {
                            p = p[i + 1L..];
                        }

                        i = i__prev3;

                    }
                }
                {
                    var i__prev2 = i;

                    i = strings.LastIndex(p, ".");

                    if (i >= 0L)
                    {
                        p = p[..i];
                    }

                    i = i__prev2;

                }
                @string suffix = ".o";
                if (writearchive)
                {
                    suffix = ".a";
                }
                outfile = p + suffix;
            }
            startProfile();

            if (flag_race)
            {
                racepkg = types.NewPkg("runtime/race", "race");
            }
            if (flag_msan)
            {
                msanpkg = types.NewPkg("runtime/msan", "msan");
            }
            if (flag_race && flag_msan)
            {
                log.Fatal("cannot use both -race and -msan");
            }
            else if (flag_race || flag_msan)
            {
                instrumenting = true;
            }
            if (compiling_runtime && Debug['N'] != 0L)
            {
                log.Fatal("cannot disable optimizations while compiling runtime");
            }
            if (nBackendWorkers < 1L)
            {
                log.Fatalf("-c must be at least 1, got %d", nBackendWorkers);
            }
            if (nBackendWorkers > 1L && !concurrentBackendAllowed())
            {
                log.Fatalf("cannot use concurrent backend compilation with provided flags; invoked as %v", os.Args);
            }
            if (Ctxt.Flag_locationlists && len(Ctxt.Arch.DWARFRegisters) == 0L)
            {
                log.Fatalf("location lists requested but register mapping not available on %v", Ctxt.Arch.Name);
            } 

            // parse -d argument
            if (debugstr != "")
            {
Split:
                foreach (var (_, name) in strings.Split(debugstr, ","))
                {
                    if (name == "")
                    {
                        continue;
                    } 
                    // display help about the -d option itself and quit
                    if (name == "help")
                    {
                        fmt.Printf(debugHelpHeader);
                        var maxLen = len("ssa/help");
                        {
                            var t__prev2 = t;

                            foreach (var (_, __t) in debugtab)
                            {
                                t = __t;
                                if (len(t.name) > maxLen)
                                {
                                    maxLen = len(t.name);
                                }
                            }

                            t = t__prev2;
                        }

                        {
                            var t__prev2 = t;

                            foreach (var (_, __t) in debugtab)
                            {
                                t = __t;
                                fmt.Printf("\t%-*s\t%s\n", maxLen, t.name, t.help);
                            } 
                            // ssa options have their own help

                            t = t__prev2;
                        }

                        fmt.Printf("\t%-*s\t%s\n", maxLen, "ssa/help", "print help about SSA debugging");
                        fmt.Printf(debugHelpFooter);
                        os.Exit(0L);
                    }
                    long val = 1L;
                    @string valstring = "";
                    var haveInt = true;
                    {
                        var i__prev2 = i;

                        i = strings.IndexAny(name, "=:");

                        if (i >= 0L)
                        {
                            error err = default;
                            name = name[..i];
                            valstring = name[i + 1L..];
                            val, err = strconv.Atoi(valstring);
                            if (err != null)
                            {
                                val = 1L;
                                haveInt = false;
                            }
                        }

                        i = i__prev2;

                    }
                    {
                        var t__prev2 = t;

                        foreach (var (_, __t) in debugtab)
                        {
                            t = __t;
                            if (t.name != name)
                            {
                                continue;
                            }
                            switch (t.val.type())
                            {
                                case 
                                    break;
                                case ref @string vp:
                                    vp.Value = valstring;
                                    break;
                                case ref long vp:
                                    if (!haveInt)
                                    {
                                        log.Fatalf("invalid debug value %v", name);
                                    }
                                    vp.Value = val;
                                    break;
                                default:
                                {
                                    var vp = t.val.type();
                                    panic("bad debugtab type");
                                    break;
                                }
                            }
                            _continueSplit = true;
                            break;
                        } 
                        // special case for ssa for now

                        t = t__prev2;
                    }

                    if (strings.HasPrefix(name, "ssa/"))
                    { 
                        // expect form ssa/phase/flag
                        // e.g. -d=ssa/generic_cse/time
                        // _ in phase name also matches space
                        var phase = name[4L..];
                        @string flag = "debug"; // default flag is debug
                        {
                            var i__prev3 = i;

                            i = strings.Index(phase, "/");

                            if (i >= 0L)
                            {
                                flag = phase[i + 1L..];
                                phase = phase[..i];
                            }

                            i = i__prev3;

                        }
                        err = ssa.PhaseOption(phase, flag, val, valstring);
                        if (err != "")
                        {
                            log.Fatalf(err);
                        }
                        _continueSplit = true;
                        break;
                    }
                    log.Fatalf("unknown debug key -d %s\n", name);
                }
            } 

            // set via a -d flag
            Ctxt.Debugpcln = Debug_pctab;
            if (flagDWARF)
            {
                dwarf.EnableLogging(Debug_gendwarfinl != 0L);
            }
            if (Debug_softfloat != 0L)
            {
                thearch.SoftFloat = true;
            } 

            // enable inlining.  for now:
            //    default: inlining on.  (debug['l'] == 1)
            //    -l: inlining off  (debug['l'] == 0)
            //    -l=2, -l=3: inlining on again, with extra debugging (debug['l'] > 1)
            if (Debug['l'] <= 1L)
            {
                Debug['l'] = 1L - Debug['l'];
            } 

            // The buffered write barrier is only implemented on amd64
            // right now.
            if (objabi.GOARCH != "amd64")
            {
                Debug_eagerwb = 1L;
            }
            trackScopes = flagDWARF && ((Debug['l'] == 0L && Debug['N'] != 0L) || Ctxt.Flag_locationlists);

            Widthptr = thearch.LinkArch.PtrSize;
            Widthreg = thearch.LinkArch.RegSize; 

            // initialize types package
            // (we need to do this to break dependencies that otherwise
            // would lead to import cycles)
            types.Widthptr = Widthptr;
            types.Dowidth = dowidth;
            types.Fatalf = Fatalf;
            types.Sconv = (s, flag, mode) =>
            {
                return sconv(s, FmtFlag(flag), fmtMode(mode));
            }
;
            types.Tconv = (t, flag, mode, depth) =>
            {
                return tconv(t, FmtFlag(flag), fmtMode(mode), depth);
            }
;
            types.FormatSym = (sym, s, verb, mode) =>
            {
                symFormat(sym, s, verb, fmtMode(mode));
            }
;
            types.FormatType = (t, s, verb, mode) =>
            {
                typeFormat(t, s, verb, fmtMode(mode));
            }
;
            types.TypeLinkSym = t =>
            {
                return typenamesym(t).Linksym();
            }
;
            types.FmtLeft = int(FmtLeft);
            types.FmtUnsigned = int(FmtUnsigned);
            types.FErr = FErr;
            types.Ctxt = Ctxt;

            initUniverse();

            dclcontext = PEXTERN;
            nerrors = 0L;

            autogeneratedPos = makePos(src.NewFileBase("<autogenerated>", "<autogenerated>"), 1L, 0L);

            timings.Start("fe", "loadsys");
            loadsys();

            timings.Start("fe", "parse");
            var lines = parseFiles(flag.Args());
            timings.Stop();
            timings.AddEvent(int64(lines), "lines");

            finishUniverse();

            typecheckok = true;
            if (Debug['f'] != 0L)
            {
                frame(1L);
            } 

            // Process top-level declarations in phases.

            // Phase 1: const, type, and names and types of funcs.
            //   This will gather all the information about types
            //   and methods but doesn't depend on any of it.
            //   We also defer type alias declarations until phase 2
            //   to avoid cycles like #18640.
            defercheckwidth(); 

            // Don't use range--typecheck can add closures to xtop.
            timings.Start("fe", "typecheck", "top1");
            {
                var i__prev1 = i;

                for (i = 0L; i < len(xtop); i++)
                {
                    var n = xtop[i];
                    {
                        var op__prev1 = op;

                        var op = n.Op;

                        if (op != ODCL && op != OAS && op != OAS2 && (op != ODCLTYPE || !n.Left.Name.Param.Alias))
                        {
                            xtop[i] = typecheck(n, Etop);
                        }

                        op = op__prev1;

                    }
                } 

                // Phase 2: Variable assignments.
                //   To check interface assignments, depends on phase 1.

                // Don't use range--typecheck can add closures to xtop.


                i = i__prev1;
            } 

            // Phase 2: Variable assignments.
            //   To check interface assignments, depends on phase 1.

            // Don't use range--typecheck can add closures to xtop.
            timings.Start("fe", "typecheck", "top2");
            {
                var i__prev1 = i;

                for (i = 0L; i < len(xtop); i++)
                {
                    n = xtop[i];
                    {
                        var op__prev1 = op;

                        op = n.Op;

                        if (op == ODCL || op == OAS || op == OAS2 || op == ODCLTYPE && n.Left.Name.Param.Alias)
                        {
                            xtop[i] = typecheck(n, Etop);
                        }

                        op = op__prev1;

                    }
                }


                i = i__prev1;
            }
            resumecheckwidth(); 

            // Phase 3: Type check function bodies.
            // Don't use range--typecheck can add closures to xtop.
            timings.Start("fe", "typecheck", "func");
            long fcount = default;
            {
                var i__prev1 = i;

                for (i = 0L; i < len(xtop); i++)
                {
                    n = xtop[i];
                    {
                        var op__prev1 = op;

                        op = n.Op;

                        if (op == ODCLFUNC || op == OCLOSURE)
                        {
                            Curfn = n;
                            decldepth = 1L;
                            saveerrors();
                            typecheckslice(Curfn.Nbody.Slice(), Etop);
                            checkreturn(Curfn);
                            if (nerrors != 0L)
                            {
                                Curfn.Nbody.Set(null); // type errors; do not compile
                            } 
                            // Now that we've checked whether n terminates,
                            // we can eliminate some obviously dead code.
                            deadcode(Curfn);
                            fcount++;
                        }

                        op = op__prev1;

                    }
                } 
                // With all types ckecked, it's now safe to verify map keys.


                i = i__prev1;
            } 
            // With all types ckecked, it's now safe to verify map keys.
            checkMapKeys();
            timings.AddEvent(fcount, "funcs"); 

            // Phase 4: Decide how to capture closed variables.
            // This needs to run before escape analysis,
            // because variables captured by value do not escape.
            timings.Start("fe", "capturevars");
            {
                var n__prev1 = n;

                foreach (var (_, __n) in xtop)
                {
                    n = __n;
                    if (n.Op == ODCLFUNC && n.Func.Closure != null)
                    {
                        Curfn = n;
                        capturevars(n);
                    }
                }

                n = n__prev1;
            }

            capturevarscomplete = true;

            Curfn = null;

            if (nsavederrors + nerrors != 0L)
            {
                errorexit();
            } 

            // Phase 5: Inlining
            timings.Start("fe", "inlining");
            if (Debug_typecheckinl != 0L)
            { 
                // Typecheck imported function bodies if debug['l'] > 1,
                // otherwise lazily when used or re-exported.
                {
                    var n__prev1 = n;

                    foreach (var (_, __n) in importlist)
                    {
                        n = __n;
                        if (n.Func.Inl.Len() != 0L)
                        {
                            saveerrors();
                            typecheckinl(n);
                        }
                    }

                    n = n__prev1;
                }

                if (nsavederrors + nerrors != 0L)
                {
                    errorexit();
                }
            }
            if (Debug['l'] != 0L)
            { 
                // Find functions that can be inlined and clone them before walk expands them.
                visitBottomUp(xtop, (list, recursive) =>
                {
                    {
                        var n__prev1 = n;

                        foreach (var (_, __n) in list)
                        {
                            n = __n;
                            if (!recursive)
                            {
                                caninl(n);
                            }
                            else
                            {
                                if (Debug['m'] > 1L)
                                {
                                    fmt.Printf("%v: cannot inline %v: recursive\n", n.Line(), n.Func.Nname);
                                }
                            }
                            inlcalls(n);
                        }

                        n = n__prev1;
                    }

                });
            } 

            // Phase 6: Escape analysis.
            // Required for moving heap allocations onto stack,
            // which in turn is required by the closure implementation,
            // which stores the addresses of stack variables into the closure.
            // If the closure does not escape, it needs to be on the stack
            // or else the stack copier will not update it.
            // Large values are also moved off stack in escape analysis;
            // because large values may contain pointers, it must happen early.
            timings.Start("fe", "escapes");
            escapes(xtop);

            if (dolinkobj)
            { 
                // Collect information for go:nowritebarrierrec
                // checking. This must happen before transformclosure.
                // We'll do the final check after write barriers are
                // inserted.
                if (compiling_runtime)
                {
                    nowritebarrierrecCheck = newNowritebarrierrecChecker();
                } 

                // Phase 7: Transform closure bodies to properly reference captured variables.
                // This needs to happen before walk, because closures must be transformed
                // before walk reaches a call of a closure.
                timings.Start("fe", "xclosures");
                {
                    var n__prev1 = n;

                    foreach (var (_, __n) in xtop)
                    {
                        n = __n;
                        if (n.Op == ODCLFUNC && n.Func.Closure != null)
                        {
                            Curfn = n;
                            transformclosure(n);
                        }
                    } 

                    // Prepare for SSA compilation.
                    // This must be before peekitabs, because peekitabs
                    // can trigger function compilation.

                    n = n__prev1;
                }

                initssaconfig(); 

                // Just before compilation, compile itabs found on
                // the right side of OCONVIFACE so that methods
                // can be de-virtualized during compilation.
                Curfn = null;
                peekitabs(); 

                // Phase 8: Compile top level functions.
                // Don't use range--walk can add functions to xtop.
                timings.Start("be", "compilefuncs");
                fcount = 0L;
                {
                    var i__prev1 = i;

                    for (i = 0L; i < len(xtop); i++)
                    {
                        n = xtop[i];
                        if (n.Op == ODCLFUNC)
                        {
                            funccompile(n);
                            fcount++;
                        }
                    }


                    i = i__prev1;
                }
                timings.AddEvent(fcount, "funcs");

                if (nsavederrors + nerrors == 0L)
                {
                    fninit(xtop);
                }
                compileFunctions(); 

                // We autogenerate and compile some small functions
                // such as method wrappers and equality/hash routines
                // while exporting code.
                // Disable concurrent compilation from here on,
                // at least until this convoluted structure has been unwound.
                nBackendWorkers = 1L;

                if (nowritebarrierrecCheck != null)
                { 
                    // Write barriers are now known. Check the
                    // call graph.
                    nowritebarrierrecCheck.check();
                    nowritebarrierrecCheck = null;
                } 

                // Finalize DWARF inline routine DIEs, then explicitly turn off
                // DWARF inlining gen so as to avoid problems with generated
                // method wrappers.
                if (Ctxt.DwFixups != null)
                {
                    Ctxt.DwFixups.Finalize(myimportpath, Debug_gendwarfinl != 0L);
                    Ctxt.DwFixups = null;
                    genDwarfInline = 0L;
                } 

                // Check whether any of the functions we have compiled have gigantic stack frames.
                obj.SortSlice(largeStackFrames, (i, j) =>
                {
                    return largeStackFrames[i].Before(largeStackFrames[j]);
                });
                foreach (var (_, largePos) in largeStackFrames)
                {
                    yyerrorl(largePos, "stack frame too large (>1GB)");
                }
            } 

            // Phase 9: Check external declarations.
            timings.Start("be", "externaldcls");
            {
                var i__prev1 = i;
                var n__prev1 = n;

                foreach (var (__i, __n) in externdcl)
                {
                    i = __i;
                    n = __n;
                    if (n.Op == ONAME)
                    {
                        externdcl[i] = typecheck(externdcl[i], Erv);
                    }
                }

                i = i__prev1;
                n = n__prev1;
            }

            if (nerrors + nsavederrors != 0L)
            {
                errorexit();
            } 

            // Write object data to disk.
            timings.Start("be", "dumpobj");
            dumpobj();
            if (asmhdr != "")
            {
                dumpasmhdr();
            }
            if (len(compilequeue) != 0L)
            {
                Fatalf("%d uncompiled functions", len(compilequeue));
            }
            if (nerrors + nsavederrors != 0L)
            {
                errorexit();
            }
            flusherrors();
            timings.Stop();

            if (benchfile != "")
            {
                {
                    error err__prev2 = err;

                    err = writebench(benchfile);

                    if (err != null)
                    {
                        log.Fatalf("cannot write benchmark data: %v", err);
                    }

                    err = err__prev2;

                }
            }
        });

        private static error writebench(@string filename) => func((_, panic, __) =>
        {
            var (f, err) = os.OpenFile(filename, os.O_WRONLY | os.O_CREATE | os.O_APPEND, 0666L);
            if (err != null)
            {
                return error.As(err);
            }
            bytes.Buffer buf = default;
            fmt.Fprintln(ref buf, "commit:", objabi.Version);
            fmt.Fprintln(ref buf, "goos:", runtime.GOOS);
            fmt.Fprintln(ref buf, "goarch:", runtime.GOARCH);
            timings.Write(ref buf, "BenchmarkCompile:" + myimportpath + ":");

            var (n, err) = f.Write(buf.Bytes());
            if (err != null)
            {
                return error.As(err);
            }
            if (n != buf.Len())
            {
                panic("bad writer");
            }
            return error.As(f.Close());
        });

        private static map importMap = /* TODO: Fix this in ScannerBase_Expression::ExitCompositeLit */ new map<@string, @string>{};        private static map<@string, @string> packageFile = default;

        private static void addImportMap(@string s)
        {
            if (strings.Count(s, "=") != 1L)
            {
                log.Fatal("-importmap argument must be of the form source=actual");
            }
            var i = strings.Index(s, "=");
            var source = s[..i];
            var actual = s[i + 1L..];
            if (source == "" || actual == "")
            {
                log.Fatal("-importmap argument must be of the form source=actual; source and actual must be non-empty");
            }
            importMap[source] = actual;
        }

        private static void readImportCfg(@string file)
        {
            packageFile = /* TODO: Fix this in ScannerBase_Expression::ExitCompositeLit */ new map<@string, @string>{};
            var (data, err) = ioutil.ReadFile(file);
            if (err != null)
            {
                log.Fatalf("-importcfg: %v", err);
            }
            foreach (var (lineNum, line) in strings.Split(string(data), "\n"))
            {
                lineNum++; // 1-based
                line = strings.TrimSpace(line);
                if (line == "" || strings.HasPrefix(line, "#"))
                {
                    continue;
                }
                @string verb = default;                @string args = default;

                {
                    var i__prev1 = i;

                    var i = strings.Index(line, " ");

                    if (i < 0L)
                    {
                        verb = line;
                    }
                    else
                    {
                        verb = line[..i];
                        args = strings.TrimSpace(line[i + 1L..]);
                    }

                    i = i__prev1;

                }
                @string before = default;                @string after = default;

                {
                    var i__prev1 = i;

                    i = strings.Index(args, "=");

                    if (i >= 0L)
                    {
                        before = args[..i];
                        after = args[i + 1L..];
                    }

                    i = i__prev1;

                }
                switch (verb)
                {
                    case "importmap": 
                        if (before == "" || after == "")
                        {
                            log.Fatalf("%s:%d: invalid importmap: syntax is \"importmap old=new\"", file, lineNum);
                        }
                        importMap[before] = after;
                        break;
                    case "packagefile": 
                        if (before == "" || after == "")
                        {
                            log.Fatalf("%s:%d: invalid packagefile: syntax is \"packagefile path=filename\"", file, lineNum);
                        }
                        packageFile[before] = after;
                        break;
                    default: 
                        log.Fatalf("%s:%d: unknown directive %q", file, lineNum, verb);
                        break;
                }
            }
        }

        private static void saveerrors()
        {
            nsavederrors += nerrors;
            nerrors = 0L;
        }

        private static long arsize(ref bufio.Reader b, @string name)
        {
            array<byte> buf = new array<byte>(ArhdrSize);
            {
                var (_, err) = io.ReadFull(b, buf[..]);

                if (err != null)
                {
                    return -1L;
                }

            }
            var aname = strings.Trim(string(buf[0L..16L]), " ");
            if (!strings.HasPrefix(aname, name))
            {
                return -1L;
            }
            var asize = strings.Trim(string(buf[48L..58L]), " ");
            var (i, _) = strconv.Atoi(asize);
            return i;
        }

        private static slice<@string> idirs = default;

        private static void addidir(@string dir)
        {
            if (dir != "")
            {
                idirs = append(idirs, dir);
            }
        }

        private static bool isDriveLetter(byte b)
        {
            return 'a' <= b && b <= 'z' || 'A' <= b && b <= 'Z';
        }

        // is this path a local name? begins with ./ or ../ or /
        private static bool islocalname(@string name)
        {
            return strings.HasPrefix(name, "/") || runtime.GOOS == "windows" && len(name) >= 3L && isDriveLetter(name[0L]) && name[1L] == ':' && name[2L] == '/' || strings.HasPrefix(name, "./") || name == "." || strings.HasPrefix(name, "../") || name == "..";
        }

        private static (@string, bool) findpkg(@string name)
        {
            if (islocalname(name))
            {
                if (safemode || nolocalimports)
                {
                    return ("", false);
                }
                if (packageFile != null)
                {
                    file, ok = packageFile[name];
                    return (file, ok);
                } 

                // try .a before .6.  important for building libraries:
                // if there is an array.6 in the array.a library,
                // want to find all of array.a, not just array.6.
                file = fmt.Sprintf("%s.a", name);
                {
                    var (_, err) = os.Stat(file);

                    if (err == null)
                    {
                        return (file, true);
                    }

                }
                file = fmt.Sprintf("%s.o", name);
                {
                    (_, err) = os.Stat(file);

                    if (err == null)
                    {
                        return (file, true);
                    }

                }
                return ("", false);
            } 

            // local imports should be canonicalized already.
            // don't want to see "encoding/../encoding/base64"
            // as different from "encoding/base64".
            {
                var q = path.Clean(name);

                if (q != name)
                {
                    yyerror("non-canonical import path %q (should be %q)", name, q);
                    return ("", false);
                }

            }

            if (packageFile != null)
            {
                file, ok = packageFile[name];
                return (file, ok);
            }
            foreach (var (_, dir) in idirs)
            {
                file = fmt.Sprintf("%s/%s.a", dir, name);
                {
                    (_, err) = os.Stat(file);

                    if (err == null)
                    {
                        return (file, true);
                    }

                }
                file = fmt.Sprintf("%s/%s.o", dir, name);
                {
                    (_, err) = os.Stat(file);

                    if (err == null)
                    {
                        return (file, true);
                    }

                }
            }
            if (objabi.GOROOT != "")
            {
                @string suffix = "";
                @string suffixsep = "";
                if (flag_installsuffix != "")
                {
                    suffixsep = "_";
                    suffix = flag_installsuffix;
                }
                else if (flag_race)
                {
                    suffixsep = "_";
                    suffix = "race";
                }
                else if (flag_msan)
                {
                    suffixsep = "_";
                    suffix = "msan";
                }
                file = fmt.Sprintf("%s/pkg/%s_%s%s%s/%s.a", objabi.GOROOT, objabi.GOOS, objabi.GOARCH, suffixsep, suffix, name);
                {
                    (_, err) = os.Stat(file);

                    if (err == null)
                    {
                        return (file, true);
                    }

                }
                file = fmt.Sprintf("%s/pkg/%s_%s%s%s/%s.o", objabi.GOROOT, objabi.GOOS, objabi.GOARCH, suffixsep, suffix, name);
                {
                    (_, err) = os.Stat(file);

                    if (err == null)
                    {
                        return (file, true);
                    }

                }
            }
            return ("", false);
        }

        // loadsys loads the definitions for the low-level runtime functions,
        // so that the compiler can generate calls to them,
        // but does not make them visible to user code.
        private static void loadsys()
        {
            types.Block = 1L;

            inimport = true;
            typecheckok = true;
            defercheckwidth();

            var typs = runtimeTypes();
            foreach (var (_, d) in runtimeDecls)
            {
                var sym = Runtimepkg.Lookup(d.name);
                var typ = typs[d.typ];

                if (d.tag == funcTag) 
                    importsym(Runtimepkg, sym, ONAME);
                    var n = newfuncname(sym);
                    n.Type = typ;
                    declare(n, PFUNC);
                else if (d.tag == varTag) 
                    importvar(lineno, Runtimepkg, sym, typ);
                else 
                    Fatalf("unhandled declaration tag %v", d.tag);
                            }
            typecheckok = false;
            resumecheckwidth();
            inimport = false;
        }

        private static ref types.Pkg importfile(ref Val _f) => func(_f, (ref Val f, Defer defer, Panic _, Recover __) =>
        {
            @string (path_, ok) = f.U._<@string>();
            if (!ok)
            {
                yyerror("import path must be a string");
                return null;
            }
            if (len(path_) == 0L)
            {
                yyerror("import path is empty");
                return null;
            }
            if (isbadimport(path_, false))
            {
                return null;
            } 

            // The package name main is no longer reserved,
            // but we reserve the import path "main" to identify
            // the main package, just as we reserve the import
            // path "math" to identify the standard math package.
            if (path_ == "main")
            {
                yyerror("cannot import \"main\"");
                errorexit();
            }
            if (myimportpath != "" && path_ == myimportpath)
            {
                yyerror("import %q while compiling that package (import cycle)", path_);
                errorexit();
            }
            {
                var (mapped, ok) = importMap[path_];

                if (ok)
                {
                    path_ = mapped;
                }

            }

            if (path_ == "unsafe")
            {
                if (safemode)
                {
                    yyerror("cannot import package unsafe");
                    errorexit();
                }
                imported_unsafe = true;
                return unsafepkg;
            }
            if (islocalname(path_))
            {
                if (path_[0L] == '/')
                {
                    yyerror("import path cannot be absolute path");
                    return null;
                }
                var prefix = Ctxt.Pathname;
                if (localimport != "")
                {
                    prefix = localimport;
                }
                path_ = path.Join(prefix, path_);

                if (isbadimport(path_, true))
                {
                    return null;
                }
            }
            var (file, found) = findpkg(path_);
            if (!found)
            {
                yyerror("can't find import: %q", path_);
                errorexit();
            }
            var importpkg = types.NewPkg(path_, "");
            if (importpkg.Imported)
            {
                return importpkg;
            }
            importpkg.Imported = true;

            var (impf, err) = os.Open(file);
            if (err != null)
            {
                yyerror("can't open import: %q: %v", path_, err);
                errorexit();
            }
            defer(impf.Close());
            var imp = bufio.NewReader(impf); 

            // check object header
            var (p, err) = imp.ReadString('\n');
            if (err != null)
            {
                yyerror("import %s: reading input: %v", file, err);
                errorexit();
            }
            if (len(p) > 0L)
            {
                p = p[..len(p) - 1L];
            }
            if (p == "!<arch>")
            { // package archive
                // package export block should be first
                var sz = arsize(imp, "__.PKGDEF");
                if (sz <= 0L)
                {
                    yyerror("import %s: not a package file", file);
                    errorexit();
                }
                p, err = imp.ReadString('\n');
                if (err != null)
                {
                    yyerror("import %s: reading input: %v", file, err);
                    errorexit();
                }
                if (len(p) > 0L)
                {
                    p = p[..len(p) - 1L];
                }
            }
            if (p != "empty archive")
            {
                if (!strings.HasPrefix(p, "go object "))
                {
                    yyerror("import %s: not a go object file: %s", file, p);
                    errorexit();
                }
                var q = fmt.Sprintf("%s %s %s %s", objabi.GOOS, objabi.GOARCH, objabi.Version, objabi.Expstring());
                if (p[10L..] != q)
                {
                    yyerror("import %s: object is [%s] expected [%s]", file, p[10L..], q);
                    errorexit();
                }
            } 

            // process header lines
            var safe = false;
            while (true)
            {
                p, err = imp.ReadString('\n');
                if (err != null)
                {
                    yyerror("import %s: reading input: %v", file, err);
                    errorexit();
                }
                if (p == "\n")
                {
                    break; // header ends with blank line
                }
                if (strings.HasPrefix(p, "safe"))
                {
                    safe = true;
                    break; // ok to ignore rest
                }
            }

            if (safemode && !safe)
            {
                yyerror("cannot import unsafe package %q", importpkg.Path);
            } 

            // assume files move (get installed) so don't record the full path
            if (packageFile != null)
            { 
                // If using a packageFile map, assume path_ can be recorded directly.
                Ctxt.AddImport(path_);
            }
            else
            { 
                // For file "/Users/foo/go/pkg/darwin_amd64/math.a" record "math.a".
                Ctxt.AddImport(file[len(file) - len(path_) - len(".a")..]);
            } 

            // In the importfile, if we find:
            // $$\n  (textual format): not supported anymore
            // $$B\n (binary format) : import directly, then feed the lexer a dummy statement

            // look for $$
            byte c = default;
            while (true)
            {
                c, err = imp.ReadByte();
                if (err != null)
                {
                    break;
                }
                if (c == '$')
                {
                    c, err = imp.ReadByte();
                    if (c == '$' || err != null)
                    {
                        break;
                    }
                }
            } 

            // get character after $$
 

            // get character after $$
            if (err == null)
            {
                c, _ = imp.ReadByte();
            }
            switch (c)
            {
                case '\n': 
                    yyerror("cannot import %s: old export format no longer supported (recompile library)", path_);
                    return null;
                    break;
                case 'B': 
                    if (Debug_export != 0L)
                    {
                        fmt.Printf("importing %s (%s)\n", path_, file);
                    }
                    imp.ReadByte(); // skip \n after $$B
                    Import(importpkg, imp);
                    break;
                default: 
                    yyerror("no import in %q", path_);
                    errorexit();
                    break;
            }

            return importpkg;
        });

        private static void pkgnotused(src.XPos lineno, @string path, @string name)
        { 
            // If the package was imported with a name other than the final
            // import path element, show it explicitly in the error message.
            // Note that this handles both renamed imports and imports of
            // packages containing unconventional package declarations.
            // Note that this uses / always, even on Windows, because Go import
            // paths always use forward slashes.
            var elem = path;
            {
                var i = strings.LastIndex(elem, "/");

                if (i >= 0L)
                {
                    elem = elem[i + 1L..];
                }

            }
            if (name == "" || elem == name)
            {
                yyerrorl(lineno, "imported and not used: %q", path);
            }
            else
            {
                yyerrorl(lineno, "imported and not used: %q as %s", path, name);
            }
        }

        private static void mkpackage(@string pkgname)
        {
            if (localpkg.Name == "")
            {
                if (pkgname == "_")
                {
                    yyerror("invalid package name _");
                }
                localpkg.Name = pkgname;
            }
            else
            {
                if (pkgname != localpkg.Name)
                {
                    yyerror("package %s; expected %s", pkgname, localpkg.Name);
                }
            }
        }

        private static void clearImports()
        {
            private partial struct importedPkg
            {
                public src.XPos pos;
                public @string path;
                public @string name;
            }
            slice<importedPkg> unused = default;

            foreach (var (_, s) in localpkg.Syms)
            {
                var n = asNode(s.Def);
                if (n == null)
                {
                    continue;
                }
                if (n.Op == OPACK)
                { 
                    // throw away top-level package name left over
                    // from previous file.
                    // leave s->block set to cause redeclaration
                    // errors if a conflicting top-level name is
                    // introduced by a different file.
                    if (!n.Name.Used() && nsyntaxerrors == 0L)
                    {
                        unused = append(unused, new importedPkg(n.Pos,n.Name.Pkg.Path,s.Name));
                    }
                    s.Def = null;
                    continue;
                }
                if (IsAlias(s))
                { 
                    // throw away top-level name left over
                    // from previous import . "x"
                    if (n.Name != null && n.Name.Pack != null && !n.Name.Pack.Name.Used() && nsyntaxerrors == 0L)
                    {
                        unused = append(unused, new importedPkg(n.Name.Pack.Pos,n.Name.Pack.Name.Pkg.Path,""));
                        n.Name.Pack.Name.SetUsed(true);
                    }
                    s.Def = null;
                    continue;
                }
            }
            obj.SortSlice(unused, (i, j) => unused[i].pos.Before(unused[j].pos));
            foreach (var (_, pkg) in unused)
            {
                pkgnotused(pkg.pos, pkg.path, pkg.name);
            }
        }

        public static bool IsAlias(ref types.Sym sym)
        {
            return sym.Def != null && asNode(sym.Def).Sym != sym;
        }

        // By default, assume any debug flags are incompatible with concurrent compilation.
        // A few are safe and potentially in common use for normal compiles, though; mark them as such here.
        private static array<bool> concurrentFlagOK = new array<bool>(InitKeyedValues<bool>(256, ('B', true), ('C', true), ('e', true), ('I', true), ('N', true), ('l', true), ('w', true), ('W', true)));

        private static bool concurrentBackendAllowed()
        {
            foreach (var (i, x) in Debug)
            {
                if (x != 0L && !concurrentFlagOK[i])
                {
                    return false;
                }
            } 
            // Debug_asm by itself is ok, because all printing occurs
            // while writing the object file, and that is non-concurrent.
            // Adding Debug_vlog, however, causes Debug_asm to also print
            // while flushing the plist, which happens concurrently.
            if (Debug_vlog || debugstr != "" || debuglive > 0L)
            {
                return false;
            } 
            // TODO: Test and delete these conditions.
            if (objabi.Fieldtrack_enabled != 0L || objabi.Preemptibleloops_enabled != 0L || objabi.Clobberdead_enabled != 0L)
            {
                return false;
            } 
            // TODO: fix races and enable the following flags
            if (Ctxt.Flag_shared || Ctxt.Flag_dynlink || flag_race)
            {
                return false;
            }
            return true;
        }

        // recordFlags records the specified command-line flags to be placed
        // in the DWARF info.
        private static void recordFlags(params @string[] flags)
        {
            flags = flags.Clone();

            if (myimportpath == "")
            { 
                // We can't record the flags if we don't know what the
                // package name is.
                return;
            }
            public partial interface BoolFlag
            {
                bool IsBoolFlag();
            }
            public partial interface CountFlag
            {
                bool IsCountFlag();
            }
            bytes.Buffer cmd = default;
            foreach (var (_, name) in flags)
            {
                var f = flag.Lookup(name);
                if (f == null)
                {
                    continue;
                }
                flag.Getter getter = f.Value._<flag.Getter>();
                if (getter.String() == f.DefValue)
                { 
                    // Flag has default value, so omit it.
                    continue;
                }
                {
                    BoolFlag (bf, ok) = f.Value._<BoolFlag>();

                    if (ok && bf.IsBoolFlag())
                    {
                        bool (val, ok) = getter.Get()._<bool>();
                        if (ok && val)
                        {
                            fmt.Fprintf(ref cmd, " -%s", f.Name);
                            continue;
                        }
                    }

                }
                {
                    CountFlag (cf, ok) = f.Value._<CountFlag>();

                    if (ok && cf.IsCountFlag())
                    {
                        (val, ok) = getter.Get()._<long>();
                        if (ok && val == 1L)
                        {
                            fmt.Fprintf(ref cmd, " -%s", f.Name);
                            continue;
                        }
                    }

                }
                fmt.Fprintf(ref cmd, " -%s=%v", f.Name, getter.Get());
            }
            if (cmd.Len() == 0L)
            {
                return;
            }
            var s = Ctxt.Lookup(dwarf.CUInfoPrefix + "producer." + myimportpath);
            s.Type = objabi.SDWARFINFO; 
            // Sometimes (for example when building tests) we can link
            // together two package main archives. So allow dups.
            s.Set(obj.AttrDuplicateOK, true);
            Ctxt.Data = append(Ctxt.Data, s);
            s.P = cmd.Bytes()[1L..];
        }
    }
}}}}