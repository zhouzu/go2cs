//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:39:51 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using objabi = go.cmd.@internal.objabi_package;
using loader = go.cmd.link.@internal.loader_package;
using sym = go.cmd.link.@internal.sym_package;
using binary = go.encoding.binary_package;
using ioutil = go.io.ioutil_package;
using bits = go.math.bits_package;
using filepath = go.path.filepath_package;
using sort = go.sort_package;
using strings = go.strings_package;
using go;

namespace go {
namespace cmd {
namespace link {
namespace @internal
{
    public static partial class ld_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct XcoffAuxFcn64
        {
            // Constructors
            public XcoffAuxFcn64(NilType _)
            {
                this.Xlnnoptr = default;
                this.Xfsize = default;
                this.Xendndx = default;
                this.Xpad = default;
                this.Xauxtype = default;
            }

            public XcoffAuxFcn64(ulong Xlnnoptr = default, uint Xfsize = default, uint Xendndx = default, byte Xpad = default, byte Xauxtype = default)
            {
                this.Xlnnoptr = Xlnnoptr;
                this.Xfsize = Xfsize;
                this.Xendndx = Xendndx;
                this.Xpad = Xpad;
                this.Xauxtype = Xauxtype;
            }

            // Enable comparisons between nil and XcoffAuxFcn64 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(XcoffAuxFcn64 value, NilType nil) => value.Equals(default(XcoffAuxFcn64));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(XcoffAuxFcn64 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, XcoffAuxFcn64 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, XcoffAuxFcn64 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator XcoffAuxFcn64(NilType nil) => default(XcoffAuxFcn64);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static XcoffAuxFcn64 XcoffAuxFcn64_cast(dynamic value)
        {
            return new XcoffAuxFcn64(value.Xlnnoptr, value.Xfsize, value.Xendndx, value.Xpad, value.Xauxtype);
        }
    }
}}}}