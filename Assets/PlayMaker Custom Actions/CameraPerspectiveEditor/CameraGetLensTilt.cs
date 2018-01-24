// (c) Copyright HutongGames, LLC 2010-2018. All rights reserved.

using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Gets the Lens Tilt of a Camera.")]
	public class CameraGetLensTilt : CameraPerspectiveEditorActionBase
	{

		[Tooltip("The LensTilt Values.")]
		[UIHint(UIHint.Variable)]
		public FsmVector2 lensTilt;

		[Tooltip("The LensTilt x value.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat lensTilt_x;

		[Tooltip("The LensTilt y value.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat lensTilt_y;

		private Vector2 _value;

		public override void Reset()
		{
			base.Reset ();

			lensTilt = null;
			lensTilt_x = null;
			lensTilt_y = null;

		}

		public override void ExecuteAction ()
		{
			base.ExecuteAction ();

			if (this.cachedComponent == null) 
			{
				return;
			}

			_value = this.cachedComponent.lensTilt;

			if (!lensTilt.IsNone) {
				lensTilt.Value = _value;
			}

			if (!lensTilt_x.IsNone) {
				lensTilt_x.Value =_value.x;
			}

			if (!lensTilt_y.IsNone) {
				lensTilt_y.Value = _value.y;
			}

		}
	}
}