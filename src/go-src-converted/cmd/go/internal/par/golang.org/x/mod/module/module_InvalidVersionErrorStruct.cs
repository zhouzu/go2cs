//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:34:02 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using sort = go.sort_package;
using strings = go.strings_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using semver = go.golang.org.x.mod.semver_package;
using errors = go.golang.org.x.xerrors_package;
using go;

namespace go {
namespace golang.org {
namespace x {
namespace mod
{
    public static partial class module_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct InvalidVersionError
        {
            // Constructors
            public InvalidVersionError(NilType _)
            {
                this.Version = default;
                this.Pseudo = default;
                this.Err = default;
            }

            public InvalidVersionError(@string Version = default, bool Pseudo = default, error Err = default)
            {
                this.Version = Version;
                this.Pseudo = Pseudo;
                this.Err = Err;
            }

            // Enable comparisons between nil and InvalidVersionError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(InvalidVersionError value, NilType nil) => value.Equals(default(InvalidVersionError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(InvalidVersionError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, InvalidVersionError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, InvalidVersionError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator InvalidVersionError(NilType nil) => default(InvalidVersionError);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static InvalidVersionError InvalidVersionError_cast(dynamic value)
        {
            return new InvalidVersionError(value.Version, value.Pseudo, value.Err);
        }
    }
}}}}