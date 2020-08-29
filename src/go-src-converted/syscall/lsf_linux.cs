// Copyright 2011 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// Linux socket filter

// package syscall -- go2cs converted at 2020 August 29 08:37:14 UTC
// import "syscall" ==> using syscall = go.syscall_package
// Original source: C:\Go\src\syscall\lsf_linux.go
using @unsafe = go.@unsafe_package;
using static go.builtin;

namespace go
{
    public static partial class syscall_package
    {
        // Deprecated: Use golang.org/x/net/bpf instead.
        public static ref SockFilter LsfStmt(long code, long k)
        {
            return ref new SockFilter(Code:uint16(code),K:uint32(k));
        }

        // Deprecated: Use golang.org/x/net/bpf instead.
        public static ref SockFilter LsfJump(long code, long k, long jt, long jf)
        {
            return ref new SockFilter(Code:uint16(code),Jt:uint8(jt),Jf:uint8(jf),K:uint32(k));
        }

        // Deprecated: Use golang.org/x/net/bpf instead.
        public static (long, error) LsfSocket(long ifindex, long proto)
        {
            SockaddrLinklayer lsall = default;
            var (s, e) = Socket(AF_PACKET, SOCK_RAW, proto);
            if (e != null)
            {
                return (0L, e);
            }
            ref array<byte> p = new ptr<ref array<byte>>(@unsafe.Pointer(ref lsall.Protocol));
            p[0L] = byte(proto >> (int)(8L));
            p[1L] = byte(proto);
            lsall.Ifindex = ifindex;
            e = Bind(s, ref lsall);
            if (e != null)
            {
                Close(s);
                return (0L, e);
            }
            return (s, null);
        }

        private partial struct iflags
        {
            public array<byte> name;
            public ushort flags;
        }

        // Deprecated: Use golang.org/x/net/bpf instead.
        public static error SetLsfPromisc(@string name, bool m) => func((defer, _, __) =>
        {
            var (s, e) = Socket(AF_INET, SOCK_DGRAM, 0L);
            if (e != null)
            {
                return error.As(e);
            }
            defer(Close(s));
            iflags ifl = default;
            copy(ifl.name[..], (slice<byte>)name);
            var (_, _, ep) = Syscall(SYS_IOCTL, uintptr(s), SIOCGIFFLAGS, uintptr(@unsafe.Pointer(ref ifl)));
            if (ep != 0L)
            {
                return error.As(Errno(ep));
            }
            if (m)
            {
                ifl.flags |= uint16(IFF_PROMISC);
            }
            else
            {
                ifl.flags &= uint16(IFF_PROMISC);
            }
            _, _, ep = Syscall(SYS_IOCTL, uintptr(s), SIOCSIFFLAGS, uintptr(@unsafe.Pointer(ref ifl)));
            if (ep != 0L)
            {
                return error.As(Errno(ep));
            }
            return error.As(null);
        });

        // Deprecated: Use golang.org/x/net/bpf instead.
        public static error AttachLsf(long fd, slice<SockFilter> i)
        {
            SockFprog p = default;
            p.Len = uint16(len(i));
            p.Filter = (SockFilter.Value)(@unsafe.Pointer(ref i[0L]));
            return error.As(setsockopt(fd, SOL_SOCKET, SO_ATTACH_FILTER, @unsafe.Pointer(ref p), @unsafe.Sizeof(p)));
        }

        // Deprecated: Use golang.org/x/net/bpf instead.
        public static error DetachLsf(long fd)
        {
            long dummy = default;
            return error.As(setsockopt(fd, SOL_SOCKET, SO_DETACH_FILTER, @unsafe.Pointer(ref dummy), @unsafe.Sizeof(dummy)));
        }
    }
}