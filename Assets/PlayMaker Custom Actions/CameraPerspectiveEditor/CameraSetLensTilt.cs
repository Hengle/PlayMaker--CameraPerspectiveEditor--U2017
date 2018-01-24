// (c) Copyright HutongGames, LLC 2010-2018. All rights reserved.

using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets the Lens Tilt of a Camera.")]
	public class CameraSetLensTilt : CameraPerspectiveEditorActionBase
	{

		[Tooltip("The LensTilt Values. Leave to none for no effect")]
		public FsmVector2 lensTilt;

		[Tooltip("The LensTilt x value. Leave to none for no effect")]
		public FsmFloat lensTilt_x;

		[Tooltip("The LensTilt y value. Leave to none for no effect")]
		public FsmFloat lensTilt_y;

		private Vector2 _value;

		public override void Reset()
		{
			base.Reset ();

			lensTilt = new FsmVector2 (){ UseVariable = true };
			lensTilt_x = new FsmFloat (){ UseVariable = true };
			lensTilt_y = new FsmFloat (){ UseVariable = true };

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
				_value = lensTilt.Value;
			}

			if (!lensTilt_x.IsNone) {
				_value.x = lensTilt_x.Value;
			}

			if (!lensTilt_y.IsNone) {
				_value.y = lensTilt_y.Value;
			}
			this.cachedComponent.lensTilt = _value;

		}
	}
}