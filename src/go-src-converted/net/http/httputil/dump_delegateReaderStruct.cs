//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:34:21 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bufio = go.bufio_package;
using bytes = go.bytes_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using net = go.net_package;
using http = go.net.http_package;
using url = go.net.url_package;
using strings = go.strings_package;
using time = go.time_package;
using go;

namespace go {
namespace net {
namespace http
{
    public static partial class httputil_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct delegateReader
        {
            // Constructors
            public delegateReader(NilType _)
            {
                this.c = default;
                this.r = default;
            }

            public delegateReader(channel<io.Reader> c = default, io.Reader r = default)
            {
                this.c = c;
                this.r = r;
            }

            // Enable comparisons between nil and delegateReader struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(delegateReader value, NilType nil) => value.Equals(default(delegateReader));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(delegateReader value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, delegateReader value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, delegateReader value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator delegateReader(NilType nil) => default(delegateReader);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static delegateReader delegateReader_cast(dynamic value)
        {
            return new delegateReader(value.c, value.r);
        }
    }
}}}