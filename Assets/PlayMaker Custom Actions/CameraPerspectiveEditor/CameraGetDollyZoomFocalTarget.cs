// (c) Copyright HutongGames, LLC 2010-2018. All rights reserved.

using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Gets the Dolly Zoom Focal Target of a Camera.")]
	public class CameraGetDollyZoomFocalTarget : CameraPerspectiveEditorActionBase
	{

		[Tooltip("The Dolly Zoom focalTarget value.")]
		[UIHint(UIHint.Variable)]
		public FsmGameObject focalTarget;


		public override void Reset()
		{
			base.Reset ();

			focalTarget = null;

		}

		public override void ExecuteAction ()
		{
			base.ExecuteAction ();

			if (this.cachedComponent == null) 
			{
				return;
			}

			if (this.cachedComponent.dollyZoomFocalTarget == null) {
				focalTarget.Value = null;
			} else {
				focalTarget.Value = this.cachedComponent.dollyZoomFocalTarget.gameObject;
			}

		}
	}
}