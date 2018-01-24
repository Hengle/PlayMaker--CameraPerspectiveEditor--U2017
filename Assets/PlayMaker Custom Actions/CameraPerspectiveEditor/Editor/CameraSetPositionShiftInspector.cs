﻿// (c) Copyright HutongGames, LLC 2010-2018. All rights reserved.

using UnityEngine;
using UnityEditor;

using HutongGames.PlayMaker.Actions;
using HutongGames.PlayMakerEditor;

[CustomActionEditor(typeof(CameraSetPositionShift))]
public class CameraSetPositionShiftInspector : CustomActionEditor
{

	public override bool OnGUI()
	{
		EditField("camera");
		EditField("positionShift");
		EditField("positionShift_x");
		EditField("positionShift_y");

		EditField("everyFrame");

		return GUI.changed;
	}

}
