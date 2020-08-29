//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:34:38 UTC
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
using strconv = go.strconv_package;
using strings = go.strings_package;
using go;

namespace go {
namespace text {
namespace template
{
    public static partial class parse_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct NumberNode
        {
            // Constructors
            public NumberNode(NilType _)
            {
                this.NodeType = default;
                this.Pos = default;
                this.tr = default;
                this.IsInt = default;
                this.IsUint = default;
                this.IsFloat = default;
                this.IsComplex = default;
                this.Int64 = default;
                this.Uint64 = default;
                this.Float64 = default;
                this.Complex128 = default;
                this.Text = default;
            }

            public NumberNode(NodeType NodeType = default, Pos Pos = default, ref ptr<Tree> tr = default, bool IsInt = default, bool IsUint = default, bool IsFloat = default, bool IsComplex = default, long Int64 = default, ulong Uint64 = default, double Float64 = default, System.Numerics.Complex128 Complex128 = default, @string Text = default)
            {
                this.NodeType = NodeType;
                this.Pos = Pos;
                this.tr = tr;
                this.IsInt = IsInt;
                this.IsUint = IsUint;
                this.IsFloat = IsFloat;
                this.IsComplex = IsComplex;
                this.Int64 = Int64;
                this.Uint64 = Uint64;
                this.Float64 = Float64;
                this.Complex128 = Complex128;
                this.Text = Text;
            }

            // Enable comparisons between nil and NumberNode struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NumberNode value, NilType nil) => value.Equals(default(NumberNode));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NumberNode value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, NumberNode value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, NumberNode value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator NumberNode(NilType nil) => default(NumberNode);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static NumberNode NumberNode_cast(dynamic value)
        {
            return new NumberNode(value.NodeType, value.Pos, ref value.tr, value.IsInt, value.IsUint, value.IsFloat, value.IsComplex, value.Int64, value.Uint64, value.Float64, value.Complex128, value.Text);
        }
    }
}}}