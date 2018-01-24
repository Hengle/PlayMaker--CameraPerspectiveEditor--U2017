// (c) Copyright HutongGames, LLC 2010-2018. All rights reserved.

using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Gets the Lens Shift of a Camera.")]
	public class CameraGetLensShift : CameraPerspectiveEditorActionBase
	{

		[Tooltip("The LensShift Values. Leave to none for no effect")]
		[UIHint(UIHint.Variable)]
		public FsmVector2 lensShift;

		[Tooltip("The LensShift x value. Leave to none for no effect")]
		[UIHint(UIHint.Variable)]
		public FsmFloat lensShift_x;

		[Tooltip("The LensShift y value. Leave to none for no effect")]
		[UIHint(UIHint.Variable)]
		public FsmFloat lensShift_y;

		[Tooltip("If True, Keep the LensShift effect proportional")]
		[UIHint(UIHint.Variable)]
		public FsmBool proportionalToAspect;

		private Vector2 _value;

		public override void Reset()
		{
			base.Reset ();

			lensShift = null;
			lensShift_x = null;
			lensShift_y = null;

			proportionalToAspect = null;

		}
			
		public override void ExecuteAction ()
		{
			base.ExecuteAction ();

			if (this.cachedComponent == null) 
			{
				return;
			}

			if (!proportionalToAspect.IsNone) {
				proportionalToAspect.Value = this.cachedComponent.lensShiftProportionalToAspect;
			}

			_value = this.cachedComponent.lensShift;

			if (!lensShift.IsNone) {
				lensShift.Value = _value;
			}

			if (!lensShift_x.IsNone) {
				lensShift_x.Value = _value.x;
			}

			if (!lensShift_y.IsNone) {
				lensShift_y.Value = _value.y;
			}

		}

	}
}