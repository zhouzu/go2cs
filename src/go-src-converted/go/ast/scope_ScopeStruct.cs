//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:48:35 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using token = go.go.token_package;
using go;

namespace go {
namespace go
{
    public static partial class ast_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Scope
        {
            // Constructors
            public Scope(NilType _)
            {
                this.Outer = default;
                this.Objects = default;
            }

            public Scope(ref ptr<Scope> Outer = default, map<@string, ref Object> Objects = default)
            {
                this.Outer = Outer;
                this.Objects = Objects;
            }

            // Enable comparisons between nil and Scope struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Scope value, NilType nil) => value.Equals(default(Scope));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Scope value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Scope value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Scope value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Scope(NilType nil) => default(Scope);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Scope Scope_cast(dynamic value)
        {
            return new Scope(ref value.Outer, value.Objects);
        }
    }
}}