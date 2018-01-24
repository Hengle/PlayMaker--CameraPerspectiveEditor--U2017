// (c) Copyright HutongGames, LLC 2010-2018. All rights reserved.

using UnityEngine;
using UnityEditor;

using HutongGames.PlayMaker.Actions;
using HutongGames.PlayMakerEditor;

[CustomActionEditor(typeof(CameraSetAspectScale))]
public class CameraSetAspectScaleInspector : CustomActionEditor
{

	public override bool OnGUI()
	{
		EditField("camera");
		EditField("aspectScale");
		EditField("aspectScale_x");
		EditField("aspectScale_y");

		EditField("everyFrame");

		return GUI.changed;
	}

}
