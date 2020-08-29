// Copyright 2017 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package sha256 -- go2cs converted at 2020 August 29 08:31:01 UTC
// import "crypto/sha256" ==> using sha256 = go.crypto.sha256_package
// Original source: C:\Go\src\crypto\sha256\sha256block_arm64.go
using cpu = go.@internal.cpu_package;
using static go.builtin;

namespace go {
namespace crypto
{
    public static partial class sha256_package
    {
        private static var k = _K;

        private static var hasSHA2 = cpu.ARM64.HasSHA2;

        //go:noescape
        private static void sha256block(slice<uint> h, slice<byte> p, slice<uint> k)
;

        private static void block(ref digest dig, slice<byte> p)
        {
            if (!hasSHA2)
            {>>MARKER:FUNCTION_sha256block_BLOCK_PREFIX<<
                blockGeneric(dig, p);
            }
            else
            {
                var h = dig.h[..];
                sha256block(h, p, k);
            }
        }
    }
}}