// (c) Copyright HutongGames, LLC 2010-2018. All rights reserved.

using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Gets the shift position of a Camera.")]
	public class CameraGetPositionShift : CameraPerspectiveEditorActionBase
	{

		[Tooltip("The positionShift Values.")]
		[UIHint(UIHint.Variable)]
		public FsmVector2 positionShift;

		[Tooltip("The positionShift x value.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat positionShift_x;

		[Tooltip("The positionShift y value.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat positionShift_y;

		private Vector2 _value;

		public override void Reset()
		{
			base.Reset ();

			positionShift = null;
			positionShift_x = null;
			positionShift_y = null;

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
				positionShift.Value = _value;
			}

			if (!positionShift_x.IsNone) {
				positionShift_x.Value = _value.x;
			}

			if (!positionShift_y.IsNone) {
				positionShift_y.Value = _value.y;
			}

		}
	}
}