//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:49:49 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using context = go.context_package;
using fmt = go.fmt_package;
using sort = go.sort_package;
using strings = go.strings_package;
using go;

#nullable enable

namespace go {
namespace runtime
{
    public static partial class pprof_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct labelContextKey
        {
            // Constructors
            public labelContextKey(NilType _)
            {
            }
            // Enable comparisons between nil and labelContextKey struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(labelContextKey value, NilType nil) => value.Equals(default(labelContextKey));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(labelContextKey value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, labelContextKey value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, labelContextKey value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator labelContextKey(NilType nil) => default(labelContextKey);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static labelContextKey labelContextKey_cast(dynamic value)
        {
            return new labelContextKey();
        }
    }
}}