//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:18:41 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct uinptr
        {
            // Value of the uinptr struct
            private readonly _Plink m_value;

            public uinptr(_Plink value) => m_value = value;

            // Enable implicit conversions between _Plink and uinptr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator uinptr(_Plink value) => new uinptr(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator _Plink(uinptr value) => value.m_value;
            
            // Enable comparisons between nil and uinptr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(uinptr value, NilType nil) => value.Equals(default(uinptr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(uinptr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, uinptr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, uinptr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator uinptr(NilType nil) => default(uinptr);
        }
    }
}