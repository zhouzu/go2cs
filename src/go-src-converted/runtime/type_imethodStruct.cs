//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:21:30 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct imethod
        {
            // Constructors
            public imethod(NilType _)
            {
                this.name = default;
                this.ityp = default;
            }

            public imethod(nameOff name = default, typeOff ityp = default)
            {
                this.name = name;
                this.ityp = ityp;
            }

            // Enable comparisons between nil and imethod struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(imethod value, NilType nil) => value.Equals(default(imethod));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(imethod value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, imethod value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, imethod value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator imethod(NilType nil) => default(imethod);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static imethod imethod_cast(dynamic value)
        {
            return new imethod(value.name, value.ityp);
        }
    }
}