//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:24:06 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using syntax = go.regexp.syntax_package;
using sort = go.sort_package;
using unicode = go.unicode_package;

namespace go
{
    public static partial class regexp_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct queueOnePass
        {
            // Constructors
            public queueOnePass(NilType _)
            {
                this.sparse = default;
                this.dense = default;
                this.size = default;
                this.nextIndex = default;
            }

            public queueOnePass(slice<uint> sparse = default, slice<uint> dense = default, uint size = default, uint nextIndex = default)
            {
                this.sparse = sparse;
                this.dense = dense;
                this.size = size;
                this.nextIndex = nextIndex;
            }

            // Enable comparisons between nil and queueOnePass struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(queueOnePass value, NilType nil) => value.Equals(default(queueOnePass));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(queueOnePass value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, queueOnePass value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, queueOnePass value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator queueOnePass(NilType nil) => default(queueOnePass);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static queueOnePass queueOnePass_cast(dynamic value)
        {
            return new queueOnePass(value.sparse, value.dense, value.size, value.nextIndex);
        }
    }
}