// (c) Copyright HutongGames, LLC 2010-2018. All rights reserved.

using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets the skew of a Camera.")]
	public class CameraSetSkew : CameraPerspectiveEditorActionBase
	{

		[Tooltip("The skew Values. Leave to none for no effect")]
		public FsmVector2 skew;

		[Tooltip("The skew x value. Leave to none for no effect")]
		public FsmFloat skew_x;

		[Tooltip("The skew y value. Leave to none for no effect")]
		public FsmFloat skew_y;

		private Vector2 _value;

		public override void Reset()
		{
			base.Reset ();

			skew = new FsmVector2 (){ UseVariable = true };
			skew_x = new FsmFloat (){ UseVariable = true };
			skew_y = new FsmFloat (){ UseVariable = true };

		}

		public override void ExecuteAction ()
		{
			base.ExecuteAction ();

			if (this.cachedComponent == null) 
			{
				return;
			}

			_value = this.cachedComponent.skew;

			if (!skew.IsNone) {
				_value = skew.Value;
			}

			if (!skew_x.IsNone) {
				_value.x = skew_x.Value;
			}

			if (!skew_y.IsNone) {
				_value.y = skew_y.Value;
			}
			this.cachedComponent.skew = _value;

		}
	}
}