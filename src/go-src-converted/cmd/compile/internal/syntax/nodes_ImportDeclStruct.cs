//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 09:26:03 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using src = go.cmd.@internal.src_package;
using go;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class syntax_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(decl))]
        public partial struct ImportDecl
        {
            // decl structure promotion - sourced from value copy
            private readonly ptr<decl> m_declRef;

            private ref decl decl_val => ref m_declRef.Value;

            // Constructors
            public ImportDecl(NilType _)
            {
                this.LocalPkgName = default;
                this.Path = default;
                this.Group = default;
                this.m_declRef = new ptr<decl>(new decl(nil));
            }

            public ImportDecl(ref ptr<Name> LocalPkgName = default, ref ptr<BasicLit> Path = default, ref ptr<Group> Group = default, decl decl = default)
            {
                this.LocalPkgName = LocalPkgName;
                this.Path = Path;
                this.Group = Group;
                this.m_declRef = new ptr<decl>(decl);
            }

            // Enable comparisons between nil and ImportDecl struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ImportDecl value, NilType nil) => value.Equals(default(ImportDecl));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ImportDecl value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ImportDecl value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ImportDecl value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ImportDecl(NilType nil) => default(ImportDecl);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static ImportDecl ImportDecl_cast(dynamic value)
        {
            return new ImportDecl(ref value.LocalPkgName, ref value.Path, ref value.Group, value.decl);
        }
    }
}}}}