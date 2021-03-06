// Copyright 2018 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package main -- go2cs converted at 2020 October 09 05:00:52 UTC
// Original source: C:\Go\src\runtime\testdata\testprog\timeprof.go
using fmt = go.fmt_package;
using ioutil = go.io.ioutil_package;
using os = go.os_package;
using pprof = go.runtime.pprof_package;
using time = go.time_package;
using static go.builtin;

namespace go
{
    public static partial class main_package
    {
        private static void init()
        {
            register("TimeProf", TimeProf);
        }

        public static void TimeProf()
        {
            var (f, err) = ioutil.TempFile("", "timeprof");
            if (err != null)
            {
                fmt.Fprintln(os.Stderr, err);
                os.Exit(2L);
            }

            {
                var err__prev1 = err;

                var err = pprof.StartCPUProfile(f);

                if (err != null)
                {
                    fmt.Fprintln(os.Stderr, err);
                    os.Exit(2L);
                }

                err = err__prev1;

            }


            var t0 = time.Now(); 
            // We should get a profiling signal 100 times a second,
            // so running for 1/10 second should be sufficient.
            while (time.Since(t0) < time.Second / 10L)
            {
            }


            pprof.StopCPUProfile();

            var name = f.Name();
            {
                var err__prev1 = err;

                err = f.Close();

                if (err != null)
                {
                    fmt.Fprintln(os.Stderr, err);
                    os.Exit(2L);
                }

                err = err__prev1;

            }


            fmt.Println(name);

        }
    }
}
