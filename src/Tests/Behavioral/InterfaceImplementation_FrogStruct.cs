//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2018 July 12 03:35:10 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using static go.BuiltInFunctions;
using fmt = go.fmt_package;

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.1.0")]
        public partial struct Frog
        {
            // Constructors
            public Frog(NilType _)
            {
                this.Name = default;
                this.Color = default;
            }

            public Frog(GoString Name, GoString Color)
            {
                this.Name = Name;
                this.Color = Color;
            }

            // Enable comparisons between nil and Frog struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Frog value, NilType nil) => value.Equals(default(Frog));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Frog value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Frog value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Frog value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Frog(NilType nil) => default(Frog);
        }
    }
}