// (c) Copyright HutongGames, LLC 2010-2018. All rights reserved.

using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Gets the Dolly Zoom of a Camera.")]
	public class CameraGetDollyZoom : CameraPerspectiveEditorActionBase
	{

		[Tooltip("The Dolly Zoom Value.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat dollyZoom;

		[Tooltip("The focal Distance value. Only works if Focal Target is null")]
		[UIHint(UIHint.Variable)]
		public FsmFloat focalDistance;

		public override void Reset()
		{
			base.Reset ();

			dollyZoom = null;
			focalDistance = null;

		}

		public override void ExecuteAction ()
		{
			base.ExecuteAction ();

			if (this.cachedComponent == null) 
			{
				return;
			}

			if (!dollyZoom.IsNone) {
				dollyZoom.Value = this.cachedComponent.dollyZoom;
			}

			if (!focalDistance.IsNone) {
				focalDistance.Value = this.cachedComponent.dollyZoomFocalDistance;
			}
		}
	}
}