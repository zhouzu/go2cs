//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 09:28:33 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using types = go.cmd.compile.@internal.types_package;
using fmt = go.fmt_package;
using go;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class gc_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct InitPlan
        {
            // Constructors
            public InitPlan(NilType _)
            {
                this.E = default;
            }

            public InitPlan(slice<InitEntry> E = default)
            {
                this.E = E;
            }

            // Enable comparisons between nil and InitPlan struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(InitPlan value, NilType nil) => value.Equals(default(InitPlan));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(InitPlan value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, InitPlan value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, InitPlan value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator InitPlan(NilType nil) => default(InitPlan);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static InitPlan InitPlan_cast(dynamic value)
        {
            return new InitPlan(value.E);
        }
    }
}}}}