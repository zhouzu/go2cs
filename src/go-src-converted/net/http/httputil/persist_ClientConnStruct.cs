//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:34:24 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bufio = go.bufio_package;
using errors = go.errors_package;
using io = go.io_package;
using net = go.net_package;
using http = go.net.http_package;
using textproto = go.net.textproto_package;
using sync = go.sync_package;
using go;

namespace go {
namespace net {
namespace http
{
    public static partial class httputil_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct ClientConn
        {
            // Constructors
            public ClientConn(NilType _)
            {
                this.mu = default;
                this.c = default;
                this.r = default;
                this.re = default;
                this.we = default;
                this.lastbody = default;
                this.nread = default;
                this.nwritten = default;
                this.pipereq = default;
                this.pipe = default;
                this.writeReq = default;
            }

            public ClientConn(sync.Mutex mu = default, net.Conn c = default, ref ptr<bufio.Reader> r = default, error re = default, error we = default, io.ReadCloser lastbody = default, long nread = default, long nwritten = default, map<ref http.Request, ulong> pipereq = default, textproto.Pipeline pipe = default, Func<ref http.Request, io.Writer, error> writeReq = default)
            {
                this.mu = mu;
                this.c = c;
                this.r = r;
                this.re = re;
                this.we = we;
                this.lastbody = lastbody;
                this.nread = nread;
                this.nwritten = nwritten;
                this.pipereq = pipereq;
                this.pipe = pipe;
                this.writeReq = writeReq;
            }

            // Enable comparisons between nil and ClientConn struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ClientConn value, NilType nil) => value.Equals(default(ClientConn));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ClientConn value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ClientConn value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ClientConn value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ClientConn(NilType nil) => default(ClientConn);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static ClientConn ClientConn_cast(dynamic value)
        {
            return new ClientConn(value.mu, value.c, ref value.r, value.re, value.we, value.lastbody, value.nread, value.nwritten, value.pipereq, value.pipe, value.writeReq);
        }
    }
}}}