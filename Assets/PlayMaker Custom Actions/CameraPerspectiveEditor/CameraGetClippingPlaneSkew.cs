// (c) Copyright HutongGames, LLC 2010-2018. All rights reserved.

using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Gets the Clipping Plane skew of a Camera.")]
	public class CameraGetClippingPlaneSkew : CameraPerspectiveEditorActionBase
	{

		[Tooltip("The Clipping Plane skew Values.")]
		[UIHint(UIHint.Variable)]
		public FsmVector2 skew;

		[Tooltip("The Clipping Plane skew x value.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat skew_x;

		[Tooltip("The Clipping Plane skew y value.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat skew_y;

		private Vector2 _value;

		public override void Reset()
		{
			base.Reset ();

			skew = null;
			skew_x = null;
			skew_y = null;

		}

		public override void ExecuteAction ()
		{
			base.ExecuteAction ();

			if (this.cachedComponent == null) 
			{
				return;
			}

			_value = this.cachedComponent.clippingPlaneSkew;

			if (!skew.IsNone) {
				skew.Value = _value;
			}

			if (!skew_x.IsNone) {
				skew_x.Value = _value.x;
			}

			if (!skew_y.IsNone) {
				skew_y.Value = _value.y;
			}

		}
	}
}