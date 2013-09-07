//////////////////////////////////////////////////////////////////////
//
// Copyright (c) 2012 Audiokinetic Inc. / All Rights Reserved
//
//////////////////////////////////////////////////////////////////////

using UnityEngine;
using System.Collections;

public class Control {

	public static bool IsGuiTextTouched(UnityEngine.GameObject controlObject)
	{
		bool isTextHit = false;
		
		if (Input.touchCount > 0) 
		{
			Touch touch = Input.GetTouch(0);
			isTextHit = controlObject.guiText.HitTest(touch.position);
		}

		return isTextHit;
	}
}
