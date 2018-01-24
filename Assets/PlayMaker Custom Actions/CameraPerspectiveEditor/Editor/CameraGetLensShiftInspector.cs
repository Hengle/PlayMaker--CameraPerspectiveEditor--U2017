// (c) Copyright HutongGames, LLC 2010-2018. All rights reserved.

using UnityEngine;
using UnityEditor;

using HutongGames.PlayMaker.Actions;
using HutongGames.PlayMakerEditor;

[CustomActionEditor(typeof(CameraGetLensShift))]
public class CameraGetLesnShiftInspector : CustomActionEditor
{

	public override bool OnGUI()
	{
		EditField("camera");
		EditField("lensShift");
		EditField("lensShift_x");
		EditField("lensShift_y");

		EditField("everyFrame");

		return GUI.changed;
	}

}
