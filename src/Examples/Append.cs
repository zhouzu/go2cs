// package main -- go2cs converted at 2018 May 23 21:06:30 UTC
// Original source: D:\Projects\go2cs\src\Examples\Append.go

using fmt = go.fmt_package;

using static goutil.BuiltInFunctions;
using goutil;
using System;

namespace go
{
    private static partial class main_package
    {
        private static void Main() => func((defer, panic, recover) =>
        {
            vars[]intprintSlice(s)s=append(s,0)printSlice(s)s=append(s,1)printSlice(s)s=append(s,2,3,4)printSlice(s)
        });

        private static void printSlice(Slice<long> s) => func((defer, panic, recover) =>
        {
            fmt.Printf("len=%d cap=%d %v\n",len(s),cap(s),s)
        });
    }
}