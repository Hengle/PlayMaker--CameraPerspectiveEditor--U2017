// (c) Copyright HutongGames, LLC 2010-2018. All rights reserved.

using UnityEngine;
using UnityEditor;

using HutongGames.PlayMaker.Actions;
using HutongGames.PlayMakerEditor;

[CustomActionEditor(typeof(CameraGetDollyZoom))]
public class CameraGetDollyZoomInspector : CustomActionEditor
{

	public override bool OnGUI()
	{
		EditField("camera");
		EditField("dollyZoom");
		EditField("focalDistance");

		EditField("everyFrame");

		return GUI.changed;
	}

}
