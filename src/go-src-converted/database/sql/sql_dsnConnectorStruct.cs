//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:11:00 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using context = go.context_package;
using driver = go.database.sql.driver_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using reflect = go.reflect_package;
using runtime = go.runtime_package;
using sort = go.sort_package;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;
using time = go.time_package;
using go;

namespace go {
namespace database
{
    public static partial class sql_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct dsnConnector
        {
            // Constructors
            public dsnConnector(NilType _)
            {
                this.dsn = default;
                this.driver = default;
            }

            public dsnConnector(@string dsn = default, driver.Driver driver = default)
            {
                this.dsn = dsn;
                this.driver = driver;
            }

            // Enable comparisons between nil and dsnConnector struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(dsnConnector value, NilType nil) => value.Equals(default(dsnConnector));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(dsnConnector value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, dsnConnector value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, dsnConnector value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator dsnConnector(NilType nil) => default(dsnConnector);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static dsnConnector dsnConnector_cast(dynamic value)
        {
            return new dsnConnector(value.dsn, value.driver);
        }
    }
}}