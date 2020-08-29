//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:33:44 UTC
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
using context = go.context_package;
using tls = go.crypto.tls_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using log = go.log_package;
using net = go.net_package;
using textproto = go.net.textproto_package;
using url = go.net.url_package;
using os = go.os_package;
using path = go.path_package;
using runtime = go.runtime_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;
using time = go.time_package;
using httplex = go.golang_org.x.net.lex.httplex_package;
using go;

namespace go {
namespace net
{
    public static partial class http_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct timeoutWriter
        {
            // Constructors
            public timeoutWriter(NilType _)
            {
                this.w = default;
                this.h = default;
                this.wbuf = default;
                this.mu = default;
                this.timedOut = default;
                this.wroteHeader = default;
                this.code = default;
            }

            public timeoutWriter(ResponseWriter w = default, Header h = default, bytes.Buffer wbuf = default, sync.Mutex mu = default, bool timedOut = default, bool wroteHeader = default, long code = default)
            {
                this.w = w;
                this.h = h;
                this.wbuf = wbuf;
                this.mu = mu;
                this.timedOut = timedOut;
                this.wroteHeader = wroteHeader;
                this.code = code;
            }

            // Enable comparisons between nil and timeoutWriter struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(timeoutWriter value, NilType nil) => value.Equals(default(timeoutWriter));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(timeoutWriter value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, timeoutWriter value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, timeoutWriter value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator timeoutWriter(NilType nil) => default(timeoutWriter);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static timeoutWriter timeoutWriter_cast(dynamic value)
        {
            return new timeoutWriter(value.w, value.h, value.wbuf, value.mu, value.timedOut, value.wroteHeader, value.code);
        }
    }
}}