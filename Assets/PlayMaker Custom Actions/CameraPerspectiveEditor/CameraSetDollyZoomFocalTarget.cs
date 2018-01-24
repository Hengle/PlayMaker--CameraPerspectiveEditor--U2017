// (c) Copyright HutongGames, LLC 2010-2018. All rights reserved.

using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets the Dolly Zoom Focal Target of a Camera.")]
	public class CameraSetDollyZoomFocalTarget : CameraPerspectiveEditorActionBase
	{

		[Tooltip("The Dolly Zoom focalTarget value.")]
		public FsmOwnerDefault focalTarget;


		public override void Reset()
		{
			base.Reset ();

			focalTarget = new FsmOwnerDefault ();

		}

		public override void ExecuteAction ()
		{
			base.ExecuteAction ();

			if (this.cachedComponent == null) 
			{
				return;
			}

			var go = Fsm.GetOwnerDefaultTarget(focalTarget);

			if (go != null) {
				this.cachedComponent.dollyZoomFocalTarget = go.transform;
			}else{
				this.cachedComponent.dollyZoomFocalTarget = null;
			}

		}
	}
}