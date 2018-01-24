﻿// (c) Copyright HutongGames, LLC 2010-2018. All rights reserved.

using UnityEngine;
using UnityEditor;

using HutongGames.PlayMaker.Actions;
using HutongGames.PlayMakerEditor;

[CustomActionEditor(typeof(CameraGetDollyZoomFocalTarget))]
public class CameraGetDollyZoomFocalTargetInspector : CustomActionEditor
{

	public override bool OnGUI()
	{
		EditField("camera");
		EditField("focalTarget");

		EditField("everyFrame");

		return GUI.changed;
	}

}
