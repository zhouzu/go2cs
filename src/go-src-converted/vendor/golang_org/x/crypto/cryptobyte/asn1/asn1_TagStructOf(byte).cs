//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:11:22 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace vendor {
namespace golang_org {
namespace x {
namespace crypto {
namespace cryptobyte
{
    public static partial class asn1_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Tag
        {
            // Value of the Tag struct
            private readonly byte m_value;

            public Tag(byte value) => m_value = value;

            // Enable implicit conversions between byte and Tag struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tag(byte value) => new Tag(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byte(Tag value) => value.m_value;
            
            // Enable comparisons between nil and Tag struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Tag value, NilType nil) => value.Equals(default(Tag));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Tag value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Tag value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Tag value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tag(NilType nil) => default(Tag);
        }
    }
}}}}}}