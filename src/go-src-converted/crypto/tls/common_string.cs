// Code generated by "stringer -type=SignatureScheme,CurveID,ClientAuthType -output=common_string.go"; DO NOT EDIT.

// package tls -- go2cs converted at 2020 October 09 04:55:12 UTC
// import "crypto/tls" ==> using tls = go.crypto.tls_package
// Original source: C:\Go\src\crypto\tls\common_string.go
using strconv = go.strconv_package;
using static go.builtin;

namespace go {
namespace crypto
{
    public static partial class tls_package
    {
        private static void _()
        { 
            // An "invalid array index" compiler error signifies that the constant values have changed.
            // Re-run the stringer command to generate them again.
            var x = default;
            _ = x[PKCS1WithSHA256 - 1025L];
            _ = x[PKCS1WithSHA384 - 1281L];
            _ = x[PKCS1WithSHA512 - 1537L];
            _ = x[PSSWithSHA256 - 2052L];
            _ = x[PSSWithSHA384 - 2053L];
            _ = x[PSSWithSHA512 - 2054L];
            _ = x[ECDSAWithP256AndSHA256 - 1027L];
            _ = x[ECDSAWithP384AndSHA384 - 1283L];
            _ = x[ECDSAWithP521AndSHA512 - 1539L];
            _ = x[Ed25519 - 2055L];
            _ = x[PKCS1WithSHA1 - 513L];
            _ = x[ECDSAWithSHA1 - 515L];

        }

        private static readonly @string _SignatureScheme_name_0 = (@string)"PKCS1WithSHA1";
        private static readonly @string _SignatureScheme_name_1 = (@string)"ECDSAWithSHA1";
        private static readonly @string _SignatureScheme_name_2 = (@string)"PKCS1WithSHA256";
        private static readonly @string _SignatureScheme_name_3 = (@string)"ECDSAWithP256AndSHA256";
        private static readonly @string _SignatureScheme_name_4 = (@string)"PKCS1WithSHA384";
        private static readonly @string _SignatureScheme_name_5 = (@string)"ECDSAWithP384AndSHA384";
        private static readonly @string _SignatureScheme_name_6 = (@string)"PKCS1WithSHA512";
        private static readonly @string _SignatureScheme_name_7 = (@string)"ECDSAWithP521AndSHA512";
        private static readonly @string _SignatureScheme_name_8 = (@string)"PSSWithSHA256PSSWithSHA384PSSWithSHA512Ed25519";


        private static array<byte> _SignatureScheme_index_8 = new array<byte>(new byte[] { 0, 13, 26, 39, 46 });

        public static @string String(this SignatureScheme i)
        {

            if (i == 513L) 
                return _SignatureScheme_name_0;
            else if (i == 515L) 
                return _SignatureScheme_name_1;
            else if (i == 1025L) 
                return _SignatureScheme_name_2;
            else if (i == 1027L) 
                return _SignatureScheme_name_3;
            else if (i == 1281L) 
                return _SignatureScheme_name_4;
            else if (i == 1283L) 
                return _SignatureScheme_name_5;
            else if (i == 1537L) 
                return _SignatureScheme_name_6;
            else if (i == 1539L) 
                return _SignatureScheme_name_7;
            else if (2052L <= i && i <= 2055L) 
                i -= 2052L;
                return _SignatureScheme_name_8[_SignatureScheme_index_8[i].._SignatureScheme_index_8[i + 1L]];
            else 
                return "SignatureScheme(" + strconv.FormatInt(int64(i), 10L) + ")";
            
        }
        private static void _()
        { 
            // An "invalid array index" compiler error signifies that the constant values have changed.
            // Re-run the stringer command to generate them again.
            var x = default;
            _ = x[CurveP256 - 23L];
            _ = x[CurveP384 - 24L];
            _ = x[CurveP521 - 25L];
            _ = x[X25519 - 29L];

        }

        private static readonly @string _CurveID_name_0 = (@string)"CurveP256CurveP384CurveP521";
        private static readonly @string _CurveID_name_1 = (@string)"X25519";


        private static array<byte> _CurveID_index_0 = new array<byte>(new byte[] { 0, 9, 18, 27 });

        public static @string String(this CurveID i)
        {

            if (23L <= i && i <= 25L) 
                i -= 23L;
                return _CurveID_name_0[_CurveID_index_0[i].._CurveID_index_0[i + 1L]];
            else if (i == 29L) 
                return _CurveID_name_1;
            else 
                return "CurveID(" + strconv.FormatInt(int64(i), 10L) + ")";
            
        }
        private static void _()
        { 
            // An "invalid array index" compiler error signifies that the constant values have changed.
            // Re-run the stringer command to generate them again.
            var x = default;
            _ = x[NoClientCert - 0L];
            _ = x[RequestClientCert - 1L];
            _ = x[RequireAnyClientCert - 2L];
            _ = x[VerifyClientCertIfGiven - 3L];
            _ = x[RequireAndVerifyClientCert - 4L];

        }

        private static readonly @string _ClientAuthType_name = (@string)"NoClientCertRequestClientCertRequireAnyClientCertVerifyClientCertIfGivenRequireAndVerifyClientCert";



        private static array<byte> _ClientAuthType_index = new array<byte>(new byte[] { 0, 12, 29, 49, 72, 98 });

        public static @string String(this ClientAuthType i)
        {
            if (i < 0L || i >= ClientAuthType(len(_ClientAuthType_index) - 1L))
            {
                return "ClientAuthType(" + strconv.FormatInt(int64(i), 10L) + ")";
            }

            return _ClientAuthType_name[_ClientAuthType_index[i].._ClientAuthType_index[i + 1L]];

        }
    }
}}
