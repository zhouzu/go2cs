//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:51:13 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace @internal {
namespace syscall
{
    public static partial class windows_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct TokenType
        {
            // Value of the TokenType struct
            private readonly uint m_value;

            public TokenType(uint value) => m_value = value;

            // Enable implicit conversions between uint and TokenType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator TokenType(uint value) => new TokenType(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator uint(TokenType value) => value.m_value;
            
            // Enable comparisons between nil and TokenType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(TokenType value, NilType nil) => value.Equals(default(TokenType));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(TokenType value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, TokenType value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, TokenType value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator TokenType(NilType nil) => default(TokenType);
        }
    }
}}}
