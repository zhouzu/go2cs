//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:07:52 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using binary = go.encoding.binary_package;
using fmt = go.fmt_package;
using log = go.log_package;
using go;

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace arch {
namespace ppc64
{
    public static partial class ppc64asm_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct argField
        {
            // Constructors
            public argField(NilType _)
            {
                this.Type = default;
                this.Shift = default;
                this.BitFields = default;
            }

            public argField(ArgType Type = default, byte Shift = default, BitFields BitFields = default)
            {
                this.Type = Type;
                this.Shift = Shift;
                this.BitFields = BitFields;
            }

            // Enable comparisons between nil and argField struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(argField value, NilType nil) => value.Equals(default(argField));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(argField value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, argField value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, argField value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator argField(NilType nil) => default(argField);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static argField argField_cast(dynamic value)
        {
            return new argField(value.Type, value.Shift, value.BitFields);
        }
    }
}}}}}}}