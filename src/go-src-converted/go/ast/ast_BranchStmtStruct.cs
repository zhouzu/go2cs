//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:46:42 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using token = go.go.token_package;
using strings = go.strings_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using go;

namespace go {
namespace go
{
    public static partial class ast_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct BranchStmt
        {
            // Constructors
            public BranchStmt(NilType _)
            {
                this.TokPos = default;
                this.Tok = default;
                this.Label = default;
            }

            public BranchStmt(token.Pos TokPos = default, token.Token Tok = default, ref ptr<Ident> Label = default)
            {
                this.TokPos = TokPos;
                this.Tok = Tok;
                this.Label = Label;
            }

            // Enable comparisons between nil and BranchStmt struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(BranchStmt value, NilType nil) => value.Equals(default(BranchStmt));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(BranchStmt value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, BranchStmt value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, BranchStmt value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator BranchStmt(NilType nil) => default(BranchStmt);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static BranchStmt BranchStmt_cast(dynamic value)
        {
            return new BranchStmt(value.TokPos, value.Tok, ref value.Label);
        }
    }
}}