//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:54:53 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using io = go.io_package;
using reflect = go.reflect_package;
using @unsafe = go.@unsafe_package;
using go;

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace @internal {
namespace @event
{
    public static partial class label_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct filter
        {
            // Constructors
            public filter(NilType _)
            {
                this.keys = default;
                this.underlying = default;
            }

            public filter(slice<Key> keys = default, List underlying = default)
            {
                this.keys = keys;
                this.underlying = underlying;
            }

            // Enable comparisons between nil and filter struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(filter value, NilType nil) => value.Equals(default(filter));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(filter value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, filter value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, filter value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator filter(NilType nil) => default(filter);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static filter filter_cast(dynamic value)
        {
            return new filter(value.keys, value.underlying);
        }
    }
}}}}}}