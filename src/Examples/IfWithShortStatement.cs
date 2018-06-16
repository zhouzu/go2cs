// package main -- go2cs converted at 2018 June 16 17:46:02 UTC
// Original source: C:\Projects\go2cs\src\Examples\IfWithShortStatement.go

using fmt = go.fmt_package;
using math = go.math_package;

using static go.BuiltInFunctions;

namespace go
{
    public static partial class main_package
    {
        private static double pow(double x, double n, double lim) => func((defer, panic, recover) =>
        {
            ifv:=math.Pow(x,n);v<lim{returnv}returnlim
        });

        private static double Main() => func((defer, panic, recover) =>
        {
            fmt.Println(pow(3,2,10),pow(3,3,20),)
        });
    }
}
