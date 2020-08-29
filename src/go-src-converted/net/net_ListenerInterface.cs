//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:27:07 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using context = go.context_package;
using errors = go.errors_package;
using poll = go.@internal.poll_package;
using io = go.io_package;
using os = go.os_package;
using syscall = go.syscall_package;
using time = go.time_package;

#pragma warning disable CS0660, CS0661

namespace go
{
    public static partial class net_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface Listener
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Listener As<T>(in T target) => (Listener<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Listener As<T>(ptr<T> target_ptr) => (Listener<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Listener? As(object target) =>
                typeof(Listener<>).CreateInterfaceHandler<Listener>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class Listener<T> : Listener
        {
            private T m_target;
            private readonly ptr<T>? m_target_ptr;
            private readonly bool m_target_is_ptr;

            public ref T Target
            {
                get
                {
                    if (m_target_is_ptr && !(m_target_ptr is null))
                        return ref m_target_ptr.Value;

                    return ref m_target;
                }
            }

            public Listener(in T target) => m_target = target;

            public Listener(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate Addr AcceptByRef(ref T value);
            private delegate Addr AcceptByVal(T value);

            private static readonly AcceptByRef s_AcceptByRef;
            private static readonly AcceptByVal s_AcceptByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Addr Accept()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_AcceptByRef is null)
                    return s_AcceptByVal!(target);

                return s_AcceptByRef(ref target);
            }

            private delegate Addr CloseByRef(ref T value);
            private delegate Addr CloseByVal(T value);

            private static readonly CloseByRef s_CloseByRef;
            private static readonly CloseByVal s_CloseByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Addr Close()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_CloseByRef is null)
                    return s_CloseByVal!(target);

                return s_CloseByRef(ref target);
            }

            private delegate Addr AddrByRef(ref T value);
            private delegate Addr AddrByVal(T value);

            private static readonly AddrByRef s_AddrByRef;
            private static readonly AddrByVal s_AddrByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Addr Addr()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_AddrByRef is null)
                    return s_AddrByVal!(target);

                return s_AddrByRef(ref target);
            }
            
            public string ToString(string format, IFormatProvider formatProvider) => format;

            [DebuggerStepperBoundary]
            static Listener()
            {
                Type targetType = typeof(T);
                Type targetTypeByRef = targetType.MakeByRefType();
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByRef.GetExtensionMethod("Accept");

                if (!(extensionMethod is null))
                    s_AcceptByRef = extensionMethod.CreateStaticDelegate(typeof(AcceptByRef)) as AcceptByRef;

                if (s_AcceptByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("Accept");

                    if (!(extensionMethod is null))
                        s_AcceptByVal = extensionMethod.CreateStaticDelegate(typeof(AcceptByVal)) as AcceptByVal;
                }

                if (s_AcceptByRef is null && s_AcceptByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Listener.Accept method", new Exception("Accept"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("Close");

                if (!(extensionMethod is null))
                    s_CloseByRef = extensionMethod.CreateStaticDelegate(typeof(CloseByRef)) as CloseByRef;

                if (s_CloseByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("Close");

                    if (!(extensionMethod is null))
                        s_CloseByVal = extensionMethod.CreateStaticDelegate(typeof(CloseByVal)) as CloseByVal;
                }

                if (s_CloseByRef is null && s_CloseByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Listener.Close method", new Exception("Close"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("Addr");

                if (!(extensionMethod is null))
                    s_AddrByRef = extensionMethod.CreateStaticDelegate(typeof(AddrByRef)) as AddrByRef;

                if (s_AddrByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("Addr");

                    if (!(extensionMethod is null))
                        s_AddrByVal = extensionMethod.CreateStaticDelegate(typeof(AddrByVal)) as AddrByVal;
                }

                if (s_AddrByRef is null && s_AddrByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Listener.Addr method", new Exception("Addr"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Listener<T>(in ptr<T> target_ptr) => new Listener<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Listener<T>(in T target) => new Listener<T>(target);

            // Enable comparisons between nil and Listener<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Listener<T> value, NilType nil) => Activator.CreateInstance<Listener<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Listener<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Listener<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Listener<T> value) => value != nil;
        }
    }
}

namespace go
{
    public static class net_ListenerExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.net_package.Listener target)
        {
            try
            {
                return ((go.net_package.Listener<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.net_package.Listener target, out T result)
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
        public static object? _(this go.net_package.Listener target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.net_package.Listener<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.net_package.Listener target, Type type, out object? result)
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