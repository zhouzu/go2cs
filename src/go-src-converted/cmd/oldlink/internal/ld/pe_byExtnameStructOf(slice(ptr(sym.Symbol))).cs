//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:52:33 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace oldlink {
namespace @internal
{
    public static partial class ld_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct byExtname
        {
            // Value of the byExtname struct
            private readonly slice<ptr<sym.Symbol>> m_value;

            public byExtname(slice<ptr<sym.Symbol>> value) => m_value = value;

            // Enable implicit conversions between slice<ptr<sym.Symbol>> and byExtname struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byExtname(slice<ptr<sym.Symbol>> value) => new byExtname(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<ptr<sym.Symbol>>(byExtname value) => value.m_value;
            
            // Enable comparisons between nil and byExtname struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(byExtname value, NilType nil) => value.Equals(default(byExtname));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(byExtname value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, byExtname value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, byExtname value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byExtname(NilType nil) => default(byExtname);
        }
    }
}}}}
