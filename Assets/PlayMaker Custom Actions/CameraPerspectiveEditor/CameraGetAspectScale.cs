// (c) Copyright HutongGames, LLC 2010-2018. All rights reserved.

using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Gets the aspectScale of a Camera.")]
	public class CameraGetAspectScale : CameraPerspectiveEditorActionBase
	{

		[Tooltip("The aspectScale Values.")]
		[UIHint(UIHint.Variable)]
		public FsmVector2 aspectScale;

		[Tooltip("The aspectScale x value.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat aspectScale_x;

		[Tooltip("The aspectScale y value.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat aspectScale_y;

		private Vector2 _value;

		public override void Reset()
		{
			base.Reset ();

			aspectScale = null;
			aspectScale_x = null;
			aspectScale_y = null;

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
				aspectScale.Value = _value;
			}

			if (!aspectScale_x.IsNone) {
				aspectScale_x.Value = _value.x;
			}

			if (!aspectScale_y.IsNone) {
				aspectScale_y.Value = _value.y ;
			}
			
		}
	}
}