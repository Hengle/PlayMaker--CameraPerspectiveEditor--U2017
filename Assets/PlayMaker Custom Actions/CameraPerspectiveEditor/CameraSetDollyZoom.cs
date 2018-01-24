// (c) Copyright HutongGames, LLC 2010-2018. All rights reserved.

using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets the Dolly Zoom of a Camera.")]
	public class CameraSetDollyZoom : CameraPerspectiveEditorActionBase
	{

		[Tooltip("The Dolly Zoom Value. Leave to none for no effect")]
		public FsmFloat dollyZoom;

		[Tooltip("The focal Distance value. Leave to none for no effect.")]
		public FsmFloat focalDistance;

		public override void Reset()
		{
			base.Reset ();

			dollyZoom = new FsmFloat (){ UseVariable = true };
			focalDistance = new FsmFloat (){ UseVariable = true };

		}

		public override void ExecuteAction ()
		{
			base.ExecuteAction ();

			if (this.cachedComponent == null) 
			{
				return;
			}

			if (!dollyZoom.IsNone) {
				this.cachedComponent.dollyZoom = dollyZoom.Value;
			}

			if (!focalDistance.IsNone) {
				this.cachedComponent.dollyZoomFocalDistance = focalDistance.Value;
			}
		}
	}
}