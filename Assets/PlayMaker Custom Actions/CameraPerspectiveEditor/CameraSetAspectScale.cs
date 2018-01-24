// (c) Copyright HutongGames, LLC 2010-2018. All rights reserved.

using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets the aspectScale of a Camera.")]
	public class CameraSetAspectScale : CameraPerspectiveEditorActionBase
	{

		[Tooltip("The aspectScale Values. Leave to none for no effect")]
		public FsmVector2 aspectScale;

		[Tooltip("The aspectScale x value. Leave to none for no effect")]
		public FsmFloat aspectScale_x;

		[Tooltip("The aspectScale y value. Leave to none for no effect")]
		public FsmFloat aspectScale_y;

		private Vector2 _value;

		public override void Reset()
		{
			base.Reset ();

			aspectScale = new FsmVector2 (){ UseVariable = true };
			aspectScale_x = new FsmFloat (){ UseVariable = true };
			aspectScale_y = new FsmFloat (){ UseVariable = true };

		}

		public override void ExecuteAction ()
		{
			base.ExecuteAction ();

			if (this.cachedComponent == null) 
			{
				return;
			}

			_value = this.cachedComponent.aspectScale;

			if (!aspectScale.IsNone) {
				_value = aspectScale.Value;
			}

			if (!aspectScale_x.IsNone) {
				_value.x = aspectScale_x.Value;
			}

			if (!aspectScale_y.IsNone) {
				_value.y = aspectScale_y.Value;
			}
			this.cachedComponent.aspectScale = _value;

		}
	}
}