//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:22:43 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using cpu = go.@internal.cpu_package;
using atomic = go.runtime.@internal.atomic_package;
using sys = go.runtime.@internal.sys_package;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct gList
        {
            // Constructors
            public gList(NilType _)
            {
                this.head = default;
            }

            public gList(guintptr head = default)
            {
                this.head = head;
            }

            // Enable comparisons between nil and gList struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(gList value, NilType nil) => value.Equals(default(gList));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(gList value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, gList value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, gList value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator gList(NilType nil) => default(gList);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static gList gList_cast(dynamic value)
        {
            return new gList(value.head);
        }
    }
}