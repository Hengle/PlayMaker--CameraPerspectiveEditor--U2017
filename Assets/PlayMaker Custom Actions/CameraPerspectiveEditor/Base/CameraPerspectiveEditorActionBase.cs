// (c) Copyright HutongGames, LLC 2010-2018. All rights reserved.

using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("Camera Perspective Editor")]
	public abstract class CameraPerspectiveEditorActionBase : ComponentAction<CameraPerspectiveEditor>
	{

		[CheckForComponent(typeof(CameraPerspectiveEditor))]
		[Tooltip("The GameObject with a CameraPerspectiveEditor Component. Will pick the Main Camera if not set")]
		public new FsmOwnerDefault camera;

		[Tooltip("If true, runs every update useful for animation")]
		public bool everyFrame;

		GameObject _camera;

		public override void Reset()
		{
			this.camera = new FsmOwnerDefault() { OwnerOption = OwnerDefaultOption.SpecifyGameObject};
			camera.GameObject = new FsmGameObject (){ UseVariable = true };

			everyFrame = false;
		}

		public override void OnEnter()
		{
			this.ExecuteAction();

			if (!everyFrame)
			{
				Finish();
			}
		}

		public override void OnUpdate()
		{
			this.ExecuteAction();
		}

		public virtual void ExecuteAction()
		{

			_camera = Fsm.GetOwnerDefaultTarget(camera);

			// get to the main camera is target is none
			if (this.camera.OwnerOption == OwnerDefaultOption.SpecifyGameObject && this.camera.GameObject.IsNone && _camera==null && this.cachedComponent == null && Camera.main!=null)
			{
				_camera = Camera.main.gameObject;
			}

			UpdateCache (_camera);
		}
	}
}