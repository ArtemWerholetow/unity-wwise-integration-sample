#if UNITY_ANDROID
using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

public class JavaVM
{
	[DllImport ("AkSoundEnginePlugin")] public static extern int DestroyJavaVM();
	[DllImport ("AkSoundEnginePlugin")] public static extern int AttachCurrentThread();
	[DllImport ("AkSoundEnginePlugin")] public static extern int DetachCurrentThread();
	[DllImport ("AkSoundEnginePlugin")] public static extern int GetEnv(int version);
	[DllImport ("AkSoundEnginePlugin")] public static extern int AttachCurrentThreadAsDaemon();
}
#endif // #if UNITY_ANDROID
