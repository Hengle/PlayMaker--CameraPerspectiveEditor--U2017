// (c) Copyright HutongGames, LLC 2010-2018. All rights reserved.

using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets the shift position of a Camera.")]
	public class CameraSetPositionShift : CameraPerspectiveEditorActionBase
	{

		[Tooltip("The positionShift Values. Leave to none for no effect")]
		public FsmVector2 positionShift;

		[Tooltip("The positionShift x value. Leave to none for no effect")]
		public FsmFloat positionShift_x;

		[Tooltip("The positionShift y value. Leave to none for no effect")]
		public FsmFloat positionShift_y;

		private Vector2 _value;

		public override void Reset()
		{
			base.Reset ();

			positionShift = new FsmVector2 (){ UseVariable = true };
			positionShift_x = new FsmFloat (){ UseVariable = true };
			positionShift_y = new FsmFloat (){ UseVariable = true };

		}

		public override void ExecuteAction ()
		{
			base.ExecuteAction ();

			if (this.cachedComponent == null) 
			{
				return;
			}

			_value = this.cachedComponent.positionShift;

			if (!positionShift.IsNone) {
				_value = positionShift.Value;
			}

			if (!positionShift_x.IsNone) {
				_value.x = positionShift_x.Value;
			}

			if (!positionShift_y.IsNone) {
				_value.y = positionShift_y.Value;
			}
			this.cachedComponent.positionShift = _value;

		}
	}
}