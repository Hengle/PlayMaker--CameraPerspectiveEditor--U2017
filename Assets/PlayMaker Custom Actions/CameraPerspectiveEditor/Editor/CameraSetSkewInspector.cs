﻿// (c) Copyright HutongGames, LLC 2010-2018. All rights reserved.

using UnityEngine;
using UnityEditor;

using HutongGames.PlayMaker.Actions;
using HutongGames.PlayMakerEditor;

[CustomActionEditor(typeof(CameraSetSkew))]
public class CameraSetSkewInspector : CustomActionEditor
{

	public override bool OnGUI()
	{
		EditField("camera");
		EditField("skew");
		EditField("skew_x");
		EditField("skew_y");

		EditField("everyFrame");

		return GUI.changed;
	}

}
