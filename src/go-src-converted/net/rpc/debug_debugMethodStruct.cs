//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:36:32 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using template = go.html.template_package;
using http = go.net.http_package;
using sort = go.sort_package;
using go;

namespace go {
namespace net
{
    public static partial class rpc_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct debugMethod
        {
            // Constructors
            public debugMethod(NilType _)
            {
                this.Type = default;
                this.Name = default;
            }

            public debugMethod(ref ptr<methodType> Type = default, @string Name = default)
            {
                this.Type = Type;
                this.Name = Name;
            }

            // Enable comparisons between nil and debugMethod struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(debugMethod value, NilType nil) => value.Equals(default(debugMethod));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(debugMethod value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, debugMethod value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, debugMethod value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator debugMethod(NilType nil) => default(debugMethod);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static debugMethod debugMethod_cast(dynamic value)
        {
            return new debugMethod(ref value.Type, value.Name);
        }
    }
}}