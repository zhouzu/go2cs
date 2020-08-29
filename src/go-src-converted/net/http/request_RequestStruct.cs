//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:33:29 UTC
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
using base64 = go.encoding.base64_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using mime = go.mime_package;
using multipart = go.mime.multipart_package;
using net = go.net_package;
using httptrace = go.net.http.httptrace_package;
using textproto = go.net.textproto_package;
using url = go.net.url_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using idna = go.golang_org.x.net.idna_package;
using go;

namespace go {
namespace net
{
    public static partial class http_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Request
        {
            // Constructors
            public Request(NilType _)
            {
                this.Method = default;
                this.URL = default;
                this.Proto = default;
                this.ProtoMajor = default;
                this.ProtoMinor = default;
                this.Header = default;
                this.Body = default;
                this.GetBody = default;
                this.ContentLength = default;
                this.TransferEncoding = default;
                this.Close = default;
                this.Host = default;
                this.Form = default;
                this.PostForm = default;
                this.MultipartForm = default;
                this.Trailer = default;
                this.RemoteAddr = default;
                this.RequestURI = default;
                this.TLS = default;
                this.Cancel = default;
                this.Response = default;
                this.ctx = default;
            }

            public Request(@string Method = default, ref ptr<url.URL> URL = default, @string Proto = default, long ProtoMajor = default, long ProtoMinor = default, Header Header = default, io.ReadCloser Body = default, Func<(io.ReadCloser, error)> GetBody = default, long ContentLength = default, slice<@string> TransferEncoding = default, bool Close = default, @string Host = default, url.Values Form = default, url.Values PostForm = default, ref ptr<multipart.Form> MultipartForm = default, Header Trailer = default, @string RemoteAddr = default, @string RequestURI = default, ref ptr<tls.ConnectionState> TLS = default, channel<object> Cancel = default, ref ptr<Response> Response = default, context.Context ctx = default)
            {
                this.Method = Method;
                this.URL = URL;
                this.Proto = Proto;
                this.ProtoMajor = ProtoMajor;
                this.ProtoMinor = ProtoMinor;
                this.Header = Header;
                this.Body = Body;
                this.GetBody = GetBody;
                this.ContentLength = ContentLength;
                this.TransferEncoding = TransferEncoding;
                this.Close = Close;
                this.Host = Host;
                this.Form = Form;
                this.PostForm = PostForm;
                this.MultipartForm = MultipartForm;
                this.Trailer = Trailer;
                this.RemoteAddr = RemoteAddr;
                this.RequestURI = RequestURI;
                this.TLS = TLS;
                this.Cancel = Cancel;
                this.Response = Response;
                this.ctx = ctx;
            }

            // Enable comparisons between nil and Request struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Request value, NilType nil) => value.Equals(default(Request));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Request value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Request value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Request value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Request(NilType nil) => default(Request);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Request Request_cast(dynamic value)
        {
            return new Request(value.Method, ref value.URL, value.Proto, value.ProtoMajor, value.ProtoMinor, value.Header, value.Body, value.GetBody, value.ContentLength, value.TransferEncoding, value.Close, value.Host, value.Form, value.PostForm, ref value.MultipartForm, value.Trailer, value.RemoteAddr, value.RequestURI, ref value.TLS, value.Cancel, ref value.Response, value.ctx);
        }
    }
}}