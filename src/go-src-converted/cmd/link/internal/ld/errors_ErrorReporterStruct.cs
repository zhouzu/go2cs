//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:38:42 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using obj = go.cmd.@internal.obj_package;
using loader = go.cmd.link.@internal.loader_package;
using sym = go.cmd.link.@internal.sym_package;
using sync = go.sync_package;
using go;

namespace go {
namespace cmd {
namespace link {
namespace @internal
{
    public static partial class ld_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(loader.ErrorReporter))]
        public partial struct ErrorReporter
        {
            // ErrorReporter structure promotion - sourced from value copy
            private readonly ptr<ErrorReporter> m_ErrorReporterRef;

            private ref ErrorReporter ErrorReporter_val => ref m_ErrorReporterRef.Value;

            public ref ptr<Loader> ldr => ref m_ErrorReporterRef.Value.ldr;

            public ref Action AfterErrorAction => ref m_ErrorReporterRef.Value.AfterErrorAction;

            // Constructors
            public ErrorReporter(NilType _)
            {
                this.m_ErrorReporterRef = new ptr<loader.ErrorReporter>(new loader.ErrorReporter(nil));
                this.unresOnce = default;
                this.unresSyms = default;
                this.unresSyms2 = default;
                this.unresMutex = default;
                this.lookup = default;
                this.SymName = default;
            }

            public ErrorReporter(loader.ErrorReporter ErrorReporter = default, sync.Once unresOnce = default, map<unresolvedSymKey, bool> unresSyms = default, map<unresolvedSymKey2, bool> unresSyms2 = default, sync.Mutex unresMutex = default, lookupFn lookup = default, symNameFn SymName = default)
            {
                this.m_ErrorReporterRef = new ptr<loader.ErrorReporter>(ErrorReporter);
                this.unresOnce = unresOnce;
                this.unresSyms = unresSyms;
                this.unresSyms2 = unresSyms2;
                this.unresMutex = unresMutex;
                this.lookup = lookup;
                this.SymName = SymName;
            }

            // Enable comparisons between nil and ErrorReporter struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ErrorReporter value, NilType nil) => value.Equals(default(ErrorReporter));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ErrorReporter value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ErrorReporter value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ErrorReporter value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ErrorReporter(NilType nil) => default(ErrorReporter);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static ErrorReporter ErrorReporter_cast(dynamic value)
        {
            return new ErrorReporter(value.ErrorReporter, value.unresOnce, value.unresSyms, value.unresSyms2, value.unresMutex, value.lookup, value.SymName);
        }
    }
}}}}