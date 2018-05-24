// package main -- go2cs converted at 2018 May 23 21:06:31 UTC
// Original source: D:\Projects\go2cs\src\Examples\DeferPanicRecover.go

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
            f()fmt.Println("Returned normally from f.")
        });

        private static void f() => func((defer, panic, recover) =>
        {
            ifr:=recover();r!=nil{fmt.Println("Recovered in f",r)}
            deferfunc(){ifr:=recover();r!=nil{fmt.Println("Recovered in f",r)}}()fmt.Println("Calling g.")g(0)fmt.Println("Returned normally from g.")
        });

        private static void g(long i) => func((defer, panic, recover) =>
        {
            ifi>3{fmt.Println("Panicking!")panic(fmt.Sprintf("%v",i))}deferfmt.Println("Defer in g",i)fmt.Println("Printing in g",i)g(i+1)
        });
    }
}