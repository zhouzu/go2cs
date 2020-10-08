//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:42:24 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using heap = go.container.heap_package;
using math = go.math_package;
using sort = go.sort_package;
using strings = go.strings_package;
using time = go.time_package;
using go;

namespace go {
namespace @internal
{
    public static partial class trace_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct mmuSeries
        {
            // Constructors
            public mmuSeries(NilType _)
            {
                this.util = default;
                this.sums = default;
                this.bands = default;
                this.bandDur = default;
            }

            public mmuSeries(slice<MutatorUtil> util = default, slice<totalUtil> sums = default, slice<mmuBand> bands = default, long bandDur = default)
            {
                this.util = util;
                this.sums = sums;
                this.bands = bands;
                this.bandDur = bandDur;
            }

            // Enable comparisons between nil and mmuSeries struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(mmuSeries value, NilType nil) => value.Equals(default(mmuSeries));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(mmuSeries value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, mmuSeries value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, mmuSeries value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator mmuSeries(NilType nil) => default(mmuSeries);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static mmuSeries mmuSeries_cast(dynamic value)
        {
            return new mmuSeries(value.util, value.sums, value.bands, value.bandDur);
        }
    }
}}