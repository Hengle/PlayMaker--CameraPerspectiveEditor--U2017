// (c) Copyright HutongGames, LLC 2010-2018. All rights reserved.

using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets the Lens Shift of a Camera.")]
	public class CameraSetLensShift : CameraPerspectiveEditorActionBase
	{

		[Tooltip("The LensShift Values. Leave to none for no effect")]
		public FsmVector2 lensShift;

		[Tooltip("The LensShift x value. Leave to none for no effect")]
		public FsmFloat lensShift_x;

		[Tooltip("The LensShift y value. Leave to none for no effect")]
		public FsmFloat lensShift_y;

		[Tooltip("If True, Keep the LensShift effect proportional")]
		public FsmBool proportionalToAspect;

		private Vector2 _value;

		public override void Reset()
		{
			base.Reset ();

			lensShift = new FsmVector2 (){ UseVariable = true };
			lensShift_x = new FsmFloat (){ UseVariable = true };
			lensShift_y = new FsmFloat (){ UseVariable = true };

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
				this.cachedComponent.lensShiftProportionalToAspect = proportionalToAspect.Value;
			}

			_value = this.cachedComponent.lensShift;

			if (!lensShift.IsNone) {
				_value = lensShift.Value;
			}

			if (!lensShift_x.IsNone) {
				_value.x = lensShift_x.Value;
			}

			if (!lensShift_y.IsNone) {
				_value.y = lensShift_y.Value;
			}

			this.cachedComponent.lensShift = _value;
		}

	}
}