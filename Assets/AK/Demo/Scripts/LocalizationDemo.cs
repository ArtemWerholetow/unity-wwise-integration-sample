//////////////////////////////////////////////////////////////////////
//
// Copyright (c) 2012 Audiokinetic Inc. / All Rights Reserved
//
//////////////////////////////////////////////////////////////////////

using UnityEngine;
using System.Collections.Generic;
using System;


public class LocalizationDemo : MonoBehaviour {
	private const string m_BankName = "Human.bnk";

#if ! UNITY_METRO
	private AkLogger m_logger = new AkLogger(System.Reflection.MethodBase.GetCurrentMethod().ReflectedType.Name);
#else
	private AkLogger m_logger = new AkLogger("LocalizationDemo");
#endif // #if ! UNITY_METRO
	
	void Start() {
		if ( ! AkSoundEngine.IsInitialized() )
		{
			m_logger.Error("Error_EngineNotInit");
			return;
		}

		AkSoundEngine.SetCurrentLanguage("English(US)");
		uint bankID;
		AkSoundEngine.LoadBank(m_BankName, AkSoundEngine.AK_DEFAULT_POOL_ID, out bankID);
	}

	void OnDestroy()
	{
		IntPtr in_pInMemoryBankPtr = IntPtr.Zero;
		AkSoundEngine.UnloadBank(m_BankName, in_pInMemoryBankPtr);
	}

	void OnMouseDown() {
		bool isTextHit = gameObject.guiText.HitTest(Input.mousePosition);
		if (isTextHit)
		{
			PlayHello();
		}
	}

	private void PlayHello() {
		AkSoundEngine.PostEvent("Play_Hello", gameObject);
	}

	

}