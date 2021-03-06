//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:03:29 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using ast = go.go.ast_package;
using constant = go.go.constant_package;
using token = go.go.token_package;
using types = go.go.types_package;
using sync = go.sync_package;
using typeutil = go.golang.org.x.tools.go.types.typeutil_package;
using go;

#nullable enable
#pragma warning disable CS0660, CS0661

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go
{
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface Value
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Value As<T>(in T target) => (Value<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Value As<T>(ptr<T> target_ptr) => (Value<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Value? As(object target) =>
                typeof(Value<>).CreateInterfaceHandler<Value>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class Value<T> : Value
        {
            private T m_target = default!;
            private readonly ptr<T>? m_target_ptr;
            private readonly bool m_target_is_ptr;

            public ref T Target
            {
                get
                {
                    if (m_target_is_ptr && !(m_target_ptr is null))
                        return ref m_target_ptr.val;

                    return ref m_target;
                }
            }

            public Value(in T target) => m_target = target;

            public Value(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate token.Pos NameByPtr(ptr<T> value);
            private delegate token.Pos NameByVal(T value);

            private static readonly NameByPtr? s_NameByPtr;
            private static readonly NameByVal? s_NameByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public token.Pos Name()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_NameByPtr is null || !m_target_is_ptr)
                    return s_NameByVal!(target);

                return s_NameByPtr(m_target_ptr);
            }

            private delegate token.Pos StringByPtr(ptr<T> value);
            private delegate token.Pos StringByVal(T value);

            private static readonly StringByPtr? s_StringByPtr;
            private static readonly StringByVal? s_StringByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public token.Pos String()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_StringByPtr is null || !m_target_is_ptr)
                    return s_StringByVal!(target);

                return s_StringByPtr(m_target_ptr);
            }

            private delegate token.Pos TypeByPtr(ptr<T> value);
            private delegate token.Pos TypeByVal(T value);

            private static readonly TypeByPtr? s_TypeByPtr;
            private static readonly TypeByVal? s_TypeByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public token.Pos Type()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_TypeByPtr is null || !m_target_is_ptr)
                    return s_TypeByVal!(target);

                return s_TypeByPtr(m_target_ptr);
            }

            private delegate token.Pos ParentByPtr(ptr<T> value);
            private delegate token.Pos ParentByVal(T value);

            private static readonly ParentByPtr? s_ParentByPtr;
            private static readonly ParentByVal? s_ParentByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public token.Pos Parent()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_ParentByPtr is null || !m_target_is_ptr)
                    return s_ParentByVal!(target);

                return s_ParentByPtr(m_target_ptr);
            }

            private delegate token.Pos ReferrersByPtr(ptr<T> value);
            private delegate token.Pos ReferrersByVal(T value);

            private static readonly ReferrersByPtr? s_ReferrersByPtr;
            private static readonly ReferrersByVal? s_ReferrersByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public token.Pos Referrers()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_ReferrersByPtr is null || !m_target_is_ptr)
                    return s_ReferrersByVal!(target);

                return s_ReferrersByPtr(m_target_ptr);
            }

            private delegate token.Pos PosByPtr(ptr<T> value);
            private delegate token.Pos PosByVal(T value);

            private static readonly PosByPtr? s_PosByPtr;
            private static readonly PosByVal? s_PosByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public token.Pos Pos()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_PosByPtr is null || !m_target_is_ptr)
                    return s_PosByVal!(target);

                return s_PosByPtr(m_target_ptr);
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format;

            [DebuggerStepperBoundary]
            static Value()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Name");

                if (!(extensionMethod is null))
                    s_NameByPtr = extensionMethod.CreateStaticDelegate(typeof(NameByPtr)) as NameByPtr;

                extensionMethod = targetType.GetExtensionMethod("Name");

                if (!(extensionMethod is null))
                    s_NameByVal = extensionMethod.CreateStaticDelegate(typeof(NameByVal)) as NameByVal;

                if (s_NameByPtr is null && s_NameByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Value.Name method", new Exception("Name"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("String");

                if (!(extensionMethod is null))
                    s_StringByPtr = extensionMethod.CreateStaticDelegate(typeof(StringByPtr)) as StringByPtr;

                extensionMethod = targetType.GetExtensionMethod("String");

                if (!(extensionMethod is null))
                    s_StringByVal = extensionMethod.CreateStaticDelegate(typeof(StringByVal)) as StringByVal;

                if (s_StringByPtr is null && s_StringByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Value.String method", new Exception("String"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Type");

                if (!(extensionMethod is null))
                    s_TypeByPtr = extensionMethod.CreateStaticDelegate(typeof(TypeByPtr)) as TypeByPtr;

                extensionMethod = targetType.GetExtensionMethod("Type");

                if (!(extensionMethod is null))
                    s_TypeByVal = extensionMethod.CreateStaticDelegate(typeof(TypeByVal)) as TypeByVal;

                if (s_TypeByPtr is null && s_TypeByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Value.Type method", new Exception("Type"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Parent");

                if (!(extensionMethod is null))
                    s_ParentByPtr = extensionMethod.CreateStaticDelegate(typeof(ParentByPtr)) as ParentByPtr;

                extensionMethod = targetType.GetExtensionMethod("Parent");

                if (!(extensionMethod is null))
                    s_ParentByVal = extensionMethod.CreateStaticDelegate(typeof(ParentByVal)) as ParentByVal;

                if (s_ParentByPtr is null && s_ParentByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Value.Parent method", new Exception("Parent"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Referrers");

                if (!(extensionMethod is null))
                    s_ReferrersByPtr = extensionMethod.CreateStaticDelegate(typeof(ReferrersByPtr)) as ReferrersByPtr;

                extensionMethod = targetType.GetExtensionMethod("Referrers");

                if (!(extensionMethod is null))
                    s_ReferrersByVal = extensionMethod.CreateStaticDelegate(typeof(ReferrersByVal)) as ReferrersByVal;

                if (s_ReferrersByPtr is null && s_ReferrersByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Value.Referrers method", new Exception("Referrers"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Pos");

                if (!(extensionMethod is null))
                    s_PosByPtr = extensionMethod.CreateStaticDelegate(typeof(PosByPtr)) as PosByPtr;

                extensionMethod = targetType.GetExtensionMethod("Pos");

                if (!(extensionMethod is null))
                    s_PosByVal = extensionMethod.CreateStaticDelegate(typeof(PosByVal)) as PosByVal;

                if (s_PosByPtr is null && s_PosByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Value.Pos method", new Exception("Pos"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Value<T>(in ptr<T> target_ptr) => new Value<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Value<T>(in T target) => new Value<T>(target);

            // Enable comparisons between nil and Value<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Value<T> value, NilType nil) => Activator.CreateInstance<Value<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Value<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Value<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Value<T> value) => value != nil;
        }
    }
}}}}}

namespace go
{
    public static class ssa_ValueExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.golang.org.x.tools.go.ssa_package.Value target)
        {
            try
            {
                return ((go.golang.org.x.tools.go.ssa_package.Value<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.golang.org.x.tools.go.ssa_package.Value target, out T result)
        {
            try
            {
                result = target._<T>();
                return true;
            }
            catch (PanicException)
            {
                result = default!;
                return false;
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static object? _(this go.golang.org.x.tools.go.ssa_package.Value target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.golang.org.x.tools.go.ssa_package.Value<>).GetExplicitGenericConversionOperator(type));

                if (conversionOperator is null)
                    throw new PanicException($"interface conversion: failed to create converter for {GetGoTypeName(target.GetType())} to {GetGoTypeName(type)}");

                dynamic? result = conversionOperator.Invoke(null, new object[] { target });
                return result?.Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(type)}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _(this go.golang.org.x.tools.go.ssa_package.Value target, Type type, out object? result)
        {
            try
            {
                result = target._(type);
                return true;
            }
            catch (PanicException)
            {
                result = type.IsValueType ? Activator.CreateInstance(type) : null;
                return false;
            }
        }
    }
}