#if UNITY_ANDROID
using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;
using System;

public class JNI
{
	[DllImport ("AkSoundEnginePlugin")] public static extern int GetVersion();
//	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr DefineClass([MarshalAs(UnmanagedType.LPStr)] string name, IntPtr loader, const byte* buf, int bufLen);
	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr FindClass([MarshalAs(UnmanagedType.LPStr)] string name);
	[DllImport ("AkSoundEnginePlugin")] public static extern int FromReflectedMethod(IntPtr method);
	[DllImport ("AkSoundEnginePlugin")] public static extern int FromReflectedField(IntPtr field);
	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr ToReflectedMethod(IntPtr cls, int methodID, int isStatic);
	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr GetSuperclass(IntPtr clazz);
	[DllImport ("AkSoundEnginePlugin")] public static extern int IsAssignableFrom(IntPtr clazz1, IntPtr clazz2);
	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr ToReflectedField(IntPtr cls, int fieldID, int isStatic);
	[DllImport ("AkSoundEnginePlugin")] public static extern int Throw(IntPtr obj);
	[DllImport ("AkSoundEnginePlugin")] public static extern int ThrowNew(IntPtr clazz, [MarshalAs(UnmanagedType.LPStr)] string message);
	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr ExceptionOccurred();
	[DllImport ("AkSoundEnginePlugin")] public static extern void ExceptionDescribe();
	[DllImport ("AkSoundEnginePlugin")] public static extern void ExceptionClear();
	[DllImport ("AkSoundEnginePlugin")] public static extern void FatalError([MarshalAs(UnmanagedType.LPStr)] string msg);
	[DllImport ("AkSoundEnginePlugin")] public static extern int PushLocalFrame(int capacity);
	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr PopLocalFrame(IntPtr result);
	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr NewGlobalRef(IntPtr obj);
	[DllImport ("AkSoundEnginePlugin")] public static extern void DeleteGlobalRef(IntPtr globalRef);
	[DllImport ("AkSoundEnginePlugin")] public static extern void DeleteLocalRef(IntPtr localRef);
	[DllImport ("AkSoundEnginePlugin")] public static extern int IsSameObject(IntPtr ref1, IntPtr ref2);
	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr NewLocalRef(IntPtr reference);
	[DllImport ("AkSoundEnginePlugin")] public static extern int EnsureLocalCapacity(int capacity);
	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr AllocObject(IntPtr clazz);

	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr NewObject(IntPtr clazz, int methodID);
	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr NewObject(IntPtr clazz, int methodID, IntPtr a);
	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr NewObject(IntPtr clazz, int methodID, IntPtr a, IntPtr b);
	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr NewObject(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c);
	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr NewObject(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c, IntPtr d);
//	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr NewObject(IntPtr clazz, int methodID, ...);
//	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr NewObjectV(IntPtr clazz, int methodID, va_list args);
//	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr NewObjectA(IntPtr clazz, int methodID, jvalue* args);

	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr GetObjectClass(IntPtr obj);
	[DllImport ("AkSoundEnginePlugin")] public static extern int IsInstanceOf(IntPtr obj, IntPtr clazz);
	[DllImport ("AkSoundEnginePlugin")] public static extern int GetMethodID(IntPtr clazz, [MarshalAs(UnmanagedType.LPStr)] string name, [MarshalAs(UnmanagedType.LPStr)] string sig);
/*
define CALL_TYPE_METHOD(_jtype, _jname)                                    \
    _jtype Call##_jname##Method(IntPtr obj, int methodID, ...)       \
    {                                                                       \
        _jtype result;                                                      \
        va_list args;                                                       \
        va_start(args, methodID);                                           \
        result = functions->Call##_jname##MethodV(this, obj, methodID,      \
                    args);                                                  \
        va_end(args);                                                       \
        return result;                                                      \
    }
define CALL_TYPE_METHODV(_jtype, _jname)                                   \
    _jtype Call##_jname##MethodV(IntPtr obj, int methodID,           \
        va_list args)                                                       \
    { return functions->Call##_jname##MethodV(this, obj, methodID, args); }
define CALL_TYPE_METHODA(_jtype, _jname)                                   \
    _jtype Call##_jname##MethodA(IntPtr obj, int methodID,           \
        jvalue* args)                                                       \
    { return functions->Call##_jname##MethodA(this, obj, methodID, args); }

define CALL_TYPE(_jtype, _jname)                                           \
    CALL_TYPE_METHOD(_jtype, _jname)                                        \
    CALL_TYPE_METHODV(_jtype, _jname)                                       \
    CALL_TYPE_METHODA(_jtype, _jname)

    CALL_TYPE(IntPtr, Object)
    CALL_TYPE(int, Boolean)
    CALL_TYPE(byte, Byte)
    CALL_TYPE(char, Char)
    CALL_TYPE(short, Short)
    CALL_TYPE(int, Int)
    CALL_TYPE(long, Long)
    CALL_TYPE(float, Float)
    CALL_TYPE(double, Double)
*/
	[DllImport ("AkSoundEnginePlugin")] public static extern void CallVoidMethod(IntPtr clazz, int methodID);
	[DllImport ("AkSoundEnginePlugin")] public static extern void CallVoidMethod(IntPtr clazz, int methodID, IntPtr a);
	[DllImport ("AkSoundEnginePlugin")] public static extern void CallVoidMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b);
	[DllImport ("AkSoundEnginePlugin")] public static extern void CallVoidMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c);
	[DllImport ("AkSoundEnginePlugin")] public static extern void CallVoidMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c, IntPtr d);
	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr CallObjectMethod(IntPtr clazz, int methodID);
	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr CallObjectMethod(IntPtr clazz, int methodID, IntPtr a);
	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr CallObjectMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b);
	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr CallObjectMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c);
	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr CallObjectMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c, IntPtr d);
	[DllImport ("AkSoundEnginePlugin")] public static extern int CallBooleanMethod(IntPtr clazz, int methodID);
	[DllImport ("AkSoundEnginePlugin")] public static extern int CallBooleanMethod(IntPtr clazz, int methodID, IntPtr a);
	[DllImport ("AkSoundEnginePlugin")] public static extern int CallBooleanMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b);
	[DllImport ("AkSoundEnginePlugin")] public static extern int CallBooleanMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c);
	[DllImport ("AkSoundEnginePlugin")] public static extern int CallBooleanMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c, IntPtr d);
	[DllImport ("AkSoundEnginePlugin")] public static extern byte CallByteMethod(IntPtr clazz, int methodID);
	[DllImport ("AkSoundEnginePlugin")] public static extern byte CallByteMethod(IntPtr clazz, int methodID, IntPtr a);
	[DllImport ("AkSoundEnginePlugin")] public static extern byte CallByteMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b);
	[DllImport ("AkSoundEnginePlugin")] public static extern byte CallByteMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c);
	[DllImport ("AkSoundEnginePlugin")] public static extern byte CallByteMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c, IntPtr d);
	[DllImport ("AkSoundEnginePlugin")] public static extern char CallCharMethod(IntPtr clazz, int methodID);
	[DllImport ("AkSoundEnginePlugin")] public static extern char CallCharMethod(IntPtr clazz, int methodID, IntPtr a);
	[DllImport ("AkSoundEnginePlugin")] public static extern char CallCharMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b);
	[DllImport ("AkSoundEnginePlugin")] public static extern char CallCharMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c);
	[DllImport ("AkSoundEnginePlugin")] public static extern char CallCharMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c, IntPtr d);
	[DllImport ("AkSoundEnginePlugin")] public static extern short CallShortMethod(IntPtr clazz, int methodID);
	[DllImport ("AkSoundEnginePlugin")] public static extern short CallShortMethod(IntPtr clazz, int methodID, IntPtr a);
	[DllImport ("AkSoundEnginePlugin")] public static extern short CallShortMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b);
	[DllImport ("AkSoundEnginePlugin")] public static extern short CallShortMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c);
	[DllImport ("AkSoundEnginePlugin")] public static extern short CallShortMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c, IntPtr d);
	[DllImport ("AkSoundEnginePlugin")] public static extern int CallIntMethod(IntPtr clazz, int methodID);
	[DllImport ("AkSoundEnginePlugin")] public static extern int CallIntMethod(IntPtr clazz, int methodID, IntPtr a);
	[DllImport ("AkSoundEnginePlugin")] public static extern int CallIntMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b);
	[DllImport ("AkSoundEnginePlugin")] public static extern int CallIntMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c);
	[DllImport ("AkSoundEnginePlugin")] public static extern int CallIntMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c, IntPtr d);
	[DllImport ("AkSoundEnginePlugin")] public static extern long CallLongMethod(IntPtr clazz, int methodID);
	[DllImport ("AkSoundEnginePlugin")] public static extern long CallLongMethod(IntPtr clazz, int methodID, IntPtr a);
	[DllImport ("AkSoundEnginePlugin")] public static extern long CallLongMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b);
	[DllImport ("AkSoundEnginePlugin")] public static extern long CallLongMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c);
	[DllImport ("AkSoundEnginePlugin")] public static extern long CallLongMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c, IntPtr d);
	[DllImport ("AkSoundEnginePlugin")] public static extern float CallFloatMethod(IntPtr clazz, int methodID);
	[DllImport ("AkSoundEnginePlugin")] public static extern float CallFloatMethod(IntPtr clazz, int methodID, IntPtr a);
	[DllImport ("AkSoundEnginePlugin")] public static extern float CallFloatMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b);
	[DllImport ("AkSoundEnginePlugin")] public static extern float CallFloatMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c);
	[DllImport ("AkSoundEnginePlugin")] public static extern float CallFloatMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c, IntPtr d);
	[DllImport ("AkSoundEnginePlugin")] public static extern double CallDoubleMethod(IntPtr clazz, int methodID);
	[DllImport ("AkSoundEnginePlugin")] public static extern double CallDoubleMethod(IntPtr clazz, int methodID, IntPtr a);
	[DllImport ("AkSoundEnginePlugin")] public static extern double CallDoubleMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b);
	[DllImport ("AkSoundEnginePlugin")] public static extern double CallDoubleMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c);
	[DllImport ("AkSoundEnginePlugin")] public static extern double CallDoubleMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c, IntPtr d);
//	[DllImport ("AkSoundEnginePlugin")] public static extern void CallVoidMethod(IntPtr obj, int methodID, ...);
//	[DllImport ("AkSoundEnginePlugin")] public static extern void CallVoidMethodV(IntPtr obj, int methodID, va_list args);
//	[DllImport ("AkSoundEnginePlugin")] public static extern void CallVoidMethodA(IntPtr obj, int methodID, jvalue* args);
/*
define CALL_NONVIRT_TYPE_METHOD(_jtype, _jname)                            \
    _jtype CallNonvirtual##_jname##Method(IntPtr obj, IntPtr clazz,        \
        int methodID, ...)                                            \
    {                                                                       \
        _jtype result;                                                      \
        va_list args;                                                       \
        va_start(args, methodID);                                           \
        result = functions->CallNonvirtual##_jname##MethodV(this, obj,      \
                    clazz, methodID, args);                                 \
        va_end(args);                                                       \
        return result;                                                      \
    }
define CALL_NONVIRT_TYPE_METHODV(_jtype, _jname)                           \
    _jtype CallNonvirtual##_jname##MethodV(IntPtr obj, IntPtr clazz,       \
        int methodID, va_list args)                                   \
    { return functions->CallNonvirtual##_jname##MethodV(this, obj, clazz,   \
        methodID, args); }
define CALL_NONVIRT_TYPE_METHODA(_jtype, _jname)                           \
    _jtype CallNonvirtual##_jname##MethodA(IntPtr obj, IntPtr clazz,       \
        int methodID, jvalue* args)                                   \
    { return functions->CallNonvirtual##_jname##MethodA(this, obj, clazz,   \
        methodID, args); }

define CALL_NONVIRT_TYPE(_jtype, _jname)                                   \
    CALL_NONVIRT_TYPE_METHOD(_jtype, _jname)                                \
    CALL_NONVIRT_TYPE_METHODV(_jtype, _jname)                               \
    CALL_NONVIRT_TYPE_METHODA(_jtype, _jname)

    CALL_NONVIRT_TYPE(IntPtr, Object)
    CALL_NONVIRT_TYPE(int, Boolean)
    CALL_NONVIRT_TYPE(byte, Byte)
    CALL_NONVIRT_TYPE(char, Char)
    CALL_NONVIRT_TYPE(short, Short)
    CALL_NONVIRT_TYPE(int, Int)
    CALL_NONVIRT_TYPE(long, Long)
    CALL_NONVIRT_TYPE(float, Float)
    CALL_NONVIRT_TYPE(double, Double)
*/
	[DllImport ("AkSoundEnginePlugin")] public static extern void CallNonvirtualVoidMethod(IntPtr clazz, int methodID);
	[DllImport ("AkSoundEnginePlugin")] public static extern void CallNonvirtualVoidMethod(IntPtr clazz, int methodID, IntPtr a);
	[DllImport ("AkSoundEnginePlugin")] public static extern void CallNonvirtualVoidMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b);
	[DllImport ("AkSoundEnginePlugin")] public static extern void CallNonvirtualVoidMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c);
	[DllImport ("AkSoundEnginePlugin")] public static extern void CallNonvirtualVoidMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c, IntPtr d);
	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr CallNonvirtualObjectMethod(IntPtr clazz, int methodID);
	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr CallNonvirtualObjectMethod(IntPtr clazz, int methodID, IntPtr a);
	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr CallNonvirtualObjectMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b);
	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr CallNonvirtualObjectMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c);
	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr CallNonvirtualObjectMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c, IntPtr d);
	[DllImport ("AkSoundEnginePlugin")] public static extern int CallNonvirtualBooleanMethod(IntPtr clazz, int methodID);
	[DllImport ("AkSoundEnginePlugin")] public static extern int CallNonvirtualBooleanMethod(IntPtr clazz, int methodID, IntPtr a);
	[DllImport ("AkSoundEnginePlugin")] public static extern int CallNonvirtualBooleanMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b);
	[DllImport ("AkSoundEnginePlugin")] public static extern int CallNonvirtualBooleanMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c);
	[DllImport ("AkSoundEnginePlugin")] public static extern int CallNonvirtualBooleanMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c, IntPtr d);
	[DllImport ("AkSoundEnginePlugin")] public static extern byte CallNonvirtualByteMethod(IntPtr clazz, int methodID);
	[DllImport ("AkSoundEnginePlugin")] public static extern byte CallNonvirtualByteMethod(IntPtr clazz, int methodID, IntPtr a);
	[DllImport ("AkSoundEnginePlugin")] public static extern byte CallNonvirtualByteMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b);
	[DllImport ("AkSoundEnginePlugin")] public static extern byte CallNonvirtualByteMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c);
	[DllImport ("AkSoundEnginePlugin")] public static extern byte CallNonvirtualByteMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c, IntPtr d);
	[DllImport ("AkSoundEnginePlugin")] public static extern char CallNonvirtualCharMethod(IntPtr clazz, int methodID);
	[DllImport ("AkSoundEnginePlugin")] public static extern char CallNonvirtualCharMethod(IntPtr clazz, int methodID, IntPtr a);
	[DllImport ("AkSoundEnginePlugin")] public static extern char CallNonvirtualCharMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b);
	[DllImport ("AkSoundEnginePlugin")] public static extern char CallNonvirtualCharMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c);
	[DllImport ("AkSoundEnginePlugin")] public static extern char CallNonvirtualCharMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c, IntPtr d);
	[DllImport ("AkSoundEnginePlugin")] public static extern short CallNonvirtualShortMethod(IntPtr clazz, int methodID);
	[DllImport ("AkSoundEnginePlugin")] public static extern short CallNonvirtualShortMethod(IntPtr clazz, int methodID, IntPtr a);
	[DllImport ("AkSoundEnginePlugin")] public static extern short CallNonvirtualShortMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b);
	[DllImport ("AkSoundEnginePlugin")] public static extern short CallNonvirtualShortMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c);
	[DllImport ("AkSoundEnginePlugin")] public static extern short CallNonvirtualShortMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c, IntPtr d);
	[DllImport ("AkSoundEnginePlugin")] public static extern int CallNonvirtualIntMethod(IntPtr clazz, int methodID);
	[DllImport ("AkSoundEnginePlugin")] public static extern int CallNonvirtualIntMethod(IntPtr clazz, int methodID, IntPtr a);
	[DllImport ("AkSoundEnginePlugin")] public static extern int CallNonvirtualIntMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b);
	[DllImport ("AkSoundEnginePlugin")] public static extern int CallNonvirtualIntMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c);
	[DllImport ("AkSoundEnginePlugin")] public static extern int CallNonvirtualIntMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c, IntPtr d);
	[DllImport ("AkSoundEnginePlugin")] public static extern long CallNonvirtualLongMethod(IntPtr clazz, int methodID);
	[DllImport ("AkSoundEnginePlugin")] public static extern long CallNonvirtualLongMethod(IntPtr clazz, int methodID, IntPtr a);
	[DllImport ("AkSoundEnginePlugin")] public static extern long CallNonvirtualLongMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b);
	[DllImport ("AkSoundEnginePlugin")] public static extern long CallNonvirtualLongMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c);
	[DllImport ("AkSoundEnginePlugin")] public static extern long CallNonvirtualLongMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c, IntPtr d);
	[DllImport ("AkSoundEnginePlugin")] public static extern float CallNonvirtualFloatMethod(IntPtr clazz, int methodID);
	[DllImport ("AkSoundEnginePlugin")] public static extern float CallNonvirtualFloatMethod(IntPtr clazz, int methodID, IntPtr a);
	[DllImport ("AkSoundEnginePlugin")] public static extern float CallNonvirtualFloatMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b);
	[DllImport ("AkSoundEnginePlugin")] public static extern float CallNonvirtualFloatMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c);
	[DllImport ("AkSoundEnginePlugin")] public static extern float CallNonvirtualFloatMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c, IntPtr d);
	[DllImport ("AkSoundEnginePlugin")] public static extern double CallNonvirtualDoubleMethod(IntPtr clazz, int methodID);
	[DllImport ("AkSoundEnginePlugin")] public static extern double CallNonvirtualDoubleMethod(IntPtr clazz, int methodID, IntPtr a);
	[DllImport ("AkSoundEnginePlugin")] public static extern double CallNonvirtualDoubleMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b);
	[DllImport ("AkSoundEnginePlugin")] public static extern double CallNonvirtualDoubleMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c);
	[DllImport ("AkSoundEnginePlugin")] public static extern double CallNonvirtualDoubleMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c, IntPtr d);
//	[DllImport ("AkSoundEnginePlugin")] public static extern void CallNonvirtualVoidMethod(IntPtr obj, IntPtr clazz, int methodID, ...);
//	[DllImport ("AkSoundEnginePlugin")] public static extern void CallNonvirtualVoidMethodV(IntPtr obj, IntPtr clazz, int methodID, va_list args);
//	[DllImport ("AkSoundEnginePlugin")] public static extern void CallNonvirtualVoidMethodA(IntPtr obj, IntPtr clazz, int methodID, jvalue* args);

	[DllImport ("AkSoundEnginePlugin")] public static extern int GetFieldID(IntPtr clazz, [MarshalAs(UnmanagedType.LPStr)] string name, [MarshalAs(UnmanagedType.LPStr)] string sig);

	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr GetObjectField(IntPtr obj, int fieldID);
	[DllImport ("AkSoundEnginePlugin")] public static extern int GetBooleanField(IntPtr obj, int fieldID);
	[DllImport ("AkSoundEnginePlugin")] public static extern byte GetByteField(IntPtr obj, int fieldID);
	[DllImport ("AkSoundEnginePlugin")] public static extern char GetCharField(IntPtr obj, int fieldID);
	[DllImport ("AkSoundEnginePlugin")] public static extern short GetShortField(IntPtr obj, int fieldID);
	[DllImport ("AkSoundEnginePlugin")] public static extern int GetIntField(IntPtr obj, int fieldID);
	[DllImport ("AkSoundEnginePlugin")] public static extern long GetLongField(IntPtr obj, int fieldID);
	[DllImport ("AkSoundEnginePlugin")] public static extern float GetFloatField(IntPtr obj, int fieldID);
	[DllImport ("AkSoundEnginePlugin")] public static extern double GetDoubleField(IntPtr obj, int fieldID);

	[DllImport ("AkSoundEnginePlugin")] public static extern void SetObjectField(IntPtr obj, int fieldID, IntPtr value);
	[DllImport ("AkSoundEnginePlugin")] public static extern void SetBooleanField(IntPtr obj, int fieldID, int value);
	[DllImport ("AkSoundEnginePlugin")] public static extern void SetByteField(IntPtr obj, int fieldID, byte value);
	[DllImport ("AkSoundEnginePlugin")] public static extern void SetCharField(IntPtr obj, int fieldID, char value);
	[DllImport ("AkSoundEnginePlugin")] public static extern void SetShortField(IntPtr obj, int fieldID, short value);
	[DllImport ("AkSoundEnginePlugin")] public static extern void SetIntField(IntPtr obj, int fieldID, int value);
	[DllImport ("AkSoundEnginePlugin")] public static extern void SetLongField(IntPtr obj, int fieldID, long value);
	[DllImport ("AkSoundEnginePlugin")] public static extern void SetFloatField(IntPtr obj, int fieldID, float value);
	[DllImport ("AkSoundEnginePlugin")] public static extern void SetDoubleField(IntPtr obj, int fieldID, double value);

	[DllImport ("AkSoundEnginePlugin")] public static extern int GetStaticMethodID(IntPtr clazz, [MarshalAs(UnmanagedType.LPStr)] string name, [MarshalAs(UnmanagedType.LPStr)] string sig);
/*
define CALL_STATIC_TYPE_METHOD(_jtype, _jname)                             \
    _jtype CallStatic##_jname##Method(IntPtr clazz, int methodID,     \
        ...)                                                                \
    {                                                                       \
        _jtype result;                                                      \
        va_list args;                                                       \
        va_start(args, methodID);                                           \
        result = functions->CallStatic##_jname##MethodV(this, clazz,        \
                    methodID, args);                                        \
        va_end(args);                                                       \
        return result;                                                      \
    }
define CALL_STATIC_TYPE_METHODV(_jtype, _jname)                            \
    _jtype CallStatic##_jname##MethodV(IntPtr clazz, int methodID,    \
        va_list args)                                                       \
    { return functions->CallStatic##_jname##MethodV(this, clazz, methodID,  \
        args); }
define CALL_STATIC_TYPE_METHODA(_jtype, _jname)                            \
    _jtype CallStatic##_jname##MethodA(IntPtr clazz, int methodID,    \
        jvalue* args)                                                       \
    { return functions->CallStatic##_jname##MethodA(this, clazz, methodID,  \
        args); }

define CALL_STATIC_TYPE(_jtype, _jname)                                    \
    CALL_STATIC_TYPE_METHOD(_jtype, _jname)                                 \
    CALL_STATIC_TYPE_METHODV(_jtype, _jname)                                \
    CALL_STATIC_TYPE_METHODA(_jtype, _jname)

    CALL_STATIC_TYPE(IntPtr, Object)
    CALL_STATIC_TYPE(int, Boolean)
    CALL_STATIC_TYPE(byte, Byte)
    CALL_STATIC_TYPE(char, Char)
    CALL_STATIC_TYPE(short, Short)
    CALL_STATIC_TYPE(int, Int)
    CALL_STATIC_TYPE(long, Long)
    CALL_STATIC_TYPE(float, Float)
    CALL_STATIC_TYPE(double, Double)
*/
	[DllImport ("AkSoundEnginePlugin")] public static extern void CallStaticVoidMethod(IntPtr clazz, int methodID);
	[DllImport ("AkSoundEnginePlugin")] public static extern void CallStaticVoidMethod(IntPtr clazz, int methodID, IntPtr a);
	[DllImport ("AkSoundEnginePlugin")] public static extern void CallStaticVoidMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b);
	[DllImport ("AkSoundEnginePlugin")] public static extern void CallStaticVoidMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c);
	[DllImport ("AkSoundEnginePlugin")] public static extern void CallStaticVoidMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c, IntPtr d);
	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr CallStaticObjectMethod(IntPtr clazz, int methodID);
	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr CallStaticObjectMethod(IntPtr clazz, int methodID, IntPtr a);
	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr CallStaticObjectMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b);
	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr CallStaticObjectMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c);
	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr CallStaticObjectMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c, IntPtr d);
	[DllImport ("AkSoundEnginePlugin")] public static extern int CallStaticBooleanMethod(IntPtr clazz, int methodID);
	[DllImport ("AkSoundEnginePlugin")] public static extern int CallStaticBooleanMethod(IntPtr clazz, int methodID, IntPtr a);
	[DllImport ("AkSoundEnginePlugin")] public static extern int CallStaticBooleanMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b);
	[DllImport ("AkSoundEnginePlugin")] public static extern int CallStaticBooleanMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c);
	[DllImport ("AkSoundEnginePlugin")] public static extern int CallStaticBooleanMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c, IntPtr d);
	[DllImport ("AkSoundEnginePlugin")] public static extern byte CallStaticByteMethod(IntPtr clazz, int methodID);
	[DllImport ("AkSoundEnginePlugin")] public static extern byte CallStaticByteMethod(IntPtr clazz, int methodID, IntPtr a);
	[DllImport ("AkSoundEnginePlugin")] public static extern byte CallStaticByteMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b);
	[DllImport ("AkSoundEnginePlugin")] public static extern byte CallStaticByteMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c);
	[DllImport ("AkSoundEnginePlugin")] public static extern byte CallStaticByteMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c, IntPtr d);
	[DllImport ("AkSoundEnginePlugin")] public static extern char CallStaticCharMethod(IntPtr clazz, int methodID);
	[DllImport ("AkSoundEnginePlugin")] public static extern char CallStaticCharMethod(IntPtr clazz, int methodID, IntPtr a);
	[DllImport ("AkSoundEnginePlugin")] public static extern char CallStaticCharMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b);
	[DllImport ("AkSoundEnginePlugin")] public static extern char CallStaticCharMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c);
	[DllImport ("AkSoundEnginePlugin")] public static extern char CallStaticCharMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c, IntPtr d);
	[DllImport ("AkSoundEnginePlugin")] public static extern short CallStaticShortMethod(IntPtr clazz, int methodID);
	[DllImport ("AkSoundEnginePlugin")] public static extern short CallStaticShortMethod(IntPtr clazz, int methodID, IntPtr a);
	[DllImport ("AkSoundEnginePlugin")] public static extern short CallStaticShortMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b);
	[DllImport ("AkSoundEnginePlugin")] public static extern short CallStaticShortMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c);
	[DllImport ("AkSoundEnginePlugin")] public static extern short CallStaticShortMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c, IntPtr d);
	[DllImport ("AkSoundEnginePlugin")] public static extern int CallStaticIntMethod(IntPtr clazz, int methodID);
	[DllImport ("AkSoundEnginePlugin")] public static extern int CallStaticIntMethod(IntPtr clazz, int methodID, IntPtr a);
	[DllImport ("AkSoundEnginePlugin")] public static extern int CallStaticIntMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b);
	[DllImport ("AkSoundEnginePlugin")] public static extern int CallStaticIntMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c);
	[DllImport ("AkSoundEnginePlugin")] public static extern int CallStaticIntMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c, IntPtr d);
	[DllImport ("AkSoundEnginePlugin")] public static extern long CallStaticLongMethod(IntPtr clazz, int methodID);
	[DllImport ("AkSoundEnginePlugin")] public static extern long CallStaticLongMethod(IntPtr clazz, int methodID, IntPtr a);
	[DllImport ("AkSoundEnginePlugin")] public static extern long CallStaticLongMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b);
	[DllImport ("AkSoundEnginePlugin")] public static extern long CallStaticLongMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c);
	[DllImport ("AkSoundEnginePlugin")] public static extern long CallStaticLongMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c, IntPtr d);
	[DllImport ("AkSoundEnginePlugin")] public static extern float CallStaticFloatMethod(IntPtr clazz, int methodID);
	[DllImport ("AkSoundEnginePlugin")] public static extern float CallStaticFloatMethod(IntPtr clazz, int methodID, IntPtr a);
	[DllImport ("AkSoundEnginePlugin")] public static extern float CallStaticFloatMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b);
	[DllImport ("AkSoundEnginePlugin")] public static extern float CallStaticFloatMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c);
	[DllImport ("AkSoundEnginePlugin")] public static extern float CallStaticFloatMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c, IntPtr d);
	[DllImport ("AkSoundEnginePlugin")] public static extern double CallStaticDoubleMethod(IntPtr clazz, int methodID);
	[DllImport ("AkSoundEnginePlugin")] public static extern double CallStaticDoubleMethod(IntPtr clazz, int methodID, IntPtr a);
	[DllImport ("AkSoundEnginePlugin")] public static extern double CallStaticDoubleMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b);
	[DllImport ("AkSoundEnginePlugin")] public static extern double CallStaticDoubleMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c);
	[DllImport ("AkSoundEnginePlugin")] public static extern double CallStaticDoubleMethod(IntPtr clazz, int methodID, IntPtr a, IntPtr b, IntPtr c, IntPtr d);
//	[DllImport ("AkSoundEnginePlugin")] public static extern void CallStaticVoidMethod(IntPtr clazz, int methodID, ...);
//	[DllImport ("AkSoundEnginePlugin")] public static extern void CallStaticVoidMethodV(IntPtr clazz, int methodID, va_list args);
//	[DllImport ("AkSoundEnginePlugin")] public static extern void CallStaticVoidMethodA(IntPtr clazz, int methodID, jvalue* args);

	[DllImport ("AkSoundEnginePlugin")] public static extern int GetStaticFieldID(IntPtr clazz, [MarshalAs(UnmanagedType.LPStr)] string name, [MarshalAs(UnmanagedType.LPStr)] string sig);

	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr GetStaticObjectField(IntPtr clazz, int fieldID);
	[DllImport ("AkSoundEnginePlugin")] public static extern int GetStaticBooleanField(IntPtr clazz, int fieldID);
	[DllImport ("AkSoundEnginePlugin")] public static extern byte GetStaticByteField(IntPtr clazz, int fieldID);
	[DllImport ("AkSoundEnginePlugin")] public static extern char GetStaticCharField(IntPtr clazz, int fieldID);
	[DllImport ("AkSoundEnginePlugin")] public static extern short GetStaticShortField(IntPtr clazz, int fieldID);
	[DllImport ("AkSoundEnginePlugin")] public static extern int GetStaticIntField(IntPtr clazz, int fieldID);
	[DllImport ("AkSoundEnginePlugin")] public static extern long GetStaticLongField(IntPtr clazz, int fieldID);
	[DllImport ("AkSoundEnginePlugin")] public static extern float GetStaticFloatField(IntPtr clazz, int fieldID);
	[DllImport ("AkSoundEnginePlugin")] public static extern double GetStaticDoubleField(IntPtr clazz, int fieldID);

	[DllImport ("AkSoundEnginePlugin")] public static extern void SetStaticObjectField(IntPtr clazz, int fieldID, IntPtr value);
	[DllImport ("AkSoundEnginePlugin")] public static extern void SetStaticBooleanField(IntPtr clazz, int fieldID, int value);
	[DllImport ("AkSoundEnginePlugin")] public static extern void SetStaticByteField(IntPtr clazz, int fieldID, byte value);
	[DllImport ("AkSoundEnginePlugin")] public static extern void SetStaticCharField(IntPtr clazz, int fieldID, char value);
	[DllImport ("AkSoundEnginePlugin")] public static extern void SetStaticShortField(IntPtr clazz, int fieldID, short value);
	[DllImport ("AkSoundEnginePlugin")] public static extern void SetStaticIntField(IntPtr clazz, int fieldID, int value);
	[DllImport ("AkSoundEnginePlugin")] public static extern void SetStaticLongField(IntPtr clazz, int fieldID, long value);
	[DllImport ("AkSoundEnginePlugin")] public static extern void SetStaticFloatField(IntPtr clazz, int fieldID, float value);
	[DllImport ("AkSoundEnginePlugin")] public static extern void SetStaticDoubleField(IntPtr clazz, int fieldID, double value);

	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr NewString([MarshalAs(UnmanagedType.LPStr)] string unicodeChars, int len);

	[DllImport ("AkSoundEnginePlugin")] public static extern int GetStringLength(IntPtr IntPtr);
	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr GetStringChars(IntPtr jstring, int setToZero);
	[DllImport ("AkSoundEnginePlugin")] public static extern void ReleaseStringChars(IntPtr jstring, IntPtr chars);

	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr NewStringUTF([MarshalAs(UnmanagedType.LPStr)] string bytes);

	[DllImport ("AkSoundEnginePlugin")] public static extern int GetStringUTFLength(IntPtr jstring);
	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr GetStringUTFChars(IntPtr jstring, int setToZero);
	[DllImport ("AkSoundEnginePlugin")] public static extern void ReleaseStringUTFChars(IntPtr jstring, IntPtr utf);

	[DllImport ("AkSoundEnginePlugin")] public static extern int GetArrayLength(IntPtr array);

	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr NewObjectArray(int length, IntPtr elementClass, IntPtr initialElement);

	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr GetObjectArrayElement(IntPtr array, int index);

	[DllImport ("AkSoundEnginePlugin")] public static extern void SetObjectArrayElement(IntPtr array, int index, IntPtr value);

	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr NewBooleanArray(int length);
	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr NewByteArray(int length);
	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr NewCharArray(int length);
	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr NewShortArray(int length);
	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr NewIntArray(int length);
	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr NewLongArray(int length);
	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr NewFloatArray(int length);
	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr NewDoubleArray(int length);
/*
	[DllImport ("AkSoundEnginePlugin")] public static extern int* GetBooleanArrayElements(IntPtr array, int* isCopy);
	[DllImport ("AkSoundEnginePlugin")] public static extern byte* GetByteArrayElements(IntPtr array, int* isCopy);
	[DllImport ("AkSoundEnginePlugin")] public static extern char* GetCharArrayElements(IntPtr array, int* isCopy);
	[DllImport ("AkSoundEnginePlugin")] public static extern short* GetShortArrayElements(IntPtr array, int* isCopy);
	[DllImport ("AkSoundEnginePlugin")] public static extern int* GetIntArrayElements(IntPtr array, int* isCopy);
	[DllImport ("AkSoundEnginePlugin")] public static extern long* GetLongArrayElements(IntPtr array, int* isCopy);
	[DllImport ("AkSoundEnginePlugin")] public static extern float* GetFloatArrayElements(IntPtr array, int* isCopy);
	[DllImport ("AkSoundEnginePlugin")] public static extern double* GetDoubleArrayElements(IntPtr array, int* isCopy);

	[DllImport ("AkSoundEnginePlugin")] public static extern void ReleaseBooleanArrayElements(IntPtr array, int* elems, int mode);
	[DllImport ("AkSoundEnginePlugin")] public static extern void ReleaseByteArrayElements(IntPtr array, byte* elems, int mode);
	[DllImport ("AkSoundEnginePlugin")] public static extern void ReleaseCharArrayElements(IntPtr array, char* elems, int mode);
	[DllImport ("AkSoundEnginePlugin")] public static extern void ReleaseShortArrayElements(IntPtr array, short* elems, int mode);
	[DllImport ("AkSoundEnginePlugin")] public static extern void ReleaseIntArrayElements(IntPtr array, int* elems, int mode);
	[DllImport ("AkSoundEnginePlugin")] public static extern void ReleaseLongArrayElements(IntPtr array, long* elems, int mode);
	[DllImport ("AkSoundEnginePlugin")] public static extern void ReleaseFloatArrayElements(IntPtr array, float* elems, int mode);
	[DllImport ("AkSoundEnginePlugin")] public static extern void ReleaseDoubleArrayElements(IntPtr array, double* elems, int mode);

	[DllImport ("AkSoundEnginePlugin")] public static extern void GetBooleanArrayRegion(IntPtr array, int start, int len, int* buf);
	[DllImport ("AkSoundEnginePlugin")] public static extern void GetByteArrayRegion(IntPtr array, int start, int len, byte* buf);
	[DllImport ("AkSoundEnginePlugin")] public static extern void GetCharArrayRegion(IntPtr array, int start, int len, char* buf);
	[DllImport ("AkSoundEnginePlugin")] public static extern void GetShortArrayRegion(IntPtr array, int start, int len, short* buf);
	[DllImport ("AkSoundEnginePlugin")] public static extern void GetIntArrayRegion(IntPtr array, int start, int len, int* buf);
	[DllImport ("AkSoundEnginePlugin")] public static extern void GetLongArrayRegion(IntPtr array, int start, int len, long* buf);
	[DllImport ("AkSoundEnginePlugin")] public static extern void GetFloatArrayRegion(IntPtr array, int start, int len, float* buf);
	[DllImport ("AkSoundEnginePlugin")] public static extern void GetDoubleArrayRegion(IntPtr array, int start, int len, double* buf);

	[DllImport ("AkSoundEnginePlugin")] public static extern void SetBooleanArrayRegion(IntPtr array, int start, int len, int* buf);
	[DllImport ("AkSoundEnginePlugin")] public static extern void SetByteArrayRegion(IntPtr array, int start, int len, byte* buf);
	[DllImport ("AkSoundEnginePlugin")] public static extern void SetCharArrayRegion(IntPtr array, int start, int len, char* buf);
	[DllImport ("AkSoundEnginePlugin")] public static extern void SetShortArrayRegion(IntPtr array, int start, int len, short* buf);
	[DllImport ("AkSoundEnginePlugin")] public static extern void SetIntArrayRegion(IntPtr array, int start, int len, int* buf);
	[DllImport ("AkSoundEnginePlugin")] public static extern void SetLongArrayRegion(IntPtr array, int start, int len, long* buf);
	[DllImport ("AkSoundEnginePlugin")] public static extern void SetFloatArrayRegion(IntPtr array, int start, int len, float* buf);
	[DllImport ("AkSoundEnginePlugin")] public static extern void SetDoubleArrayRegion(IntPtr array, int start, int len, double* buf);
*/
//	[DllImport ("AkSoundEnginePlugin")] public static extern int RegisterNatives(IntPtr clazz, JNINativeMethod* methods, int nMethods);
//	[DllImport ("AkSoundEnginePlugin")] public static extern int UnregisterNatives(IntPtr clazz);

	[DllImport ("AkSoundEnginePlugin")] public static extern int MonitorEnter(IntPtr obj);
	[DllImport ("AkSoundEnginePlugin")] public static extern int MonitorExit(IntPtr obj);

	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr GetJavaVM();

//	[DllImport ("AkSoundEnginePlugin")] public static extern void GetStringRegion(IntPtr str, int start, int len, char* buf);
//	[DllImport ("AkSoundEnginePlugin")] public static extern void GetStringUTFRegion(IntPtr str, int start, int len, char* buf);

//	[DllImport ("AkSoundEnginePlugin")] public static extern void* GetPrimitiveArrayCritical(IntPtr array, int* isCopy);
//	[DllImport ("AkSoundEnginePlugin")] public static extern void ReleasePrimitiveArrayCritical(IntPtr array, void* carray, int mode);

	[DllImport ("AkSoundEnginePlugin")] public static extern string GetStringCritical(IntPtr IntPtr/*, int* isCopy*/);
//	[DllImport ("AkSoundEnginePlugin")] public static extern void ReleaseStringCritical(IntPtr IntPtr, [MarshalAs(UnmanagedType.LPStr)] string carray);

	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr NewWeakGlobalRef(IntPtr obj);
	[DllImport ("AkSoundEnginePlugin")] public static extern void DeleteWeakGlobalRef(IntPtr obj);

	[DllImport ("AkSoundEnginePlugin")] public static extern int ExceptionCheck();

//	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtr NewDirectByteBuffer(void* address, long capacity);

//	[DllImport ("AkSoundEnginePlugin")] public static extern void* GetDirectBufferAddress(IntPtr buf);
	[DllImport ("AkSoundEnginePlugin")] public static extern long GetDirectBufferCapacity(IntPtr buf);

    /* added in JNI 1.6 */
//	[DllImport ("AkSoundEnginePlugin")] public static extern IntPtrRefType GetObjectRefType(IntPtr obj);

}
#endif // #if UNITY_ANDROID