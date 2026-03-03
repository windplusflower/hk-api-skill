using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B5D RID: 2909
	[ActionCategory(ActionCategory.Camera)]
	[Tooltip("Activates a Camera in the scene.")]
	public class CutToCamera : FsmStateAction
	{
		// Token: 0x06003E13 RID: 15891 RVA: 0x001634E1 File Offset: 0x001616E1
		public override void Reset()
		{
			this.camera = null;
			this.makeMainCamera = true;
			this.cutBackOnExit = false;
		}

		// Token: 0x06003E14 RID: 15892 RVA: 0x001634F8 File Offset: 0x001616F8
		public override void OnEnter()
		{
			if (this.camera == null)
			{
				base.LogError("Missing camera!");
				return;
			}
			this.oldCamera = Camera.main;
			CutToCamera.SwitchCamera(Camera.main, this.camera);
			if (this.makeMainCamera)
			{
				this.camera.tag = "MainCamera";
			}
			base.Finish();
		}

		// Token: 0x06003E15 RID: 15893 RVA: 0x00163558 File Offset: 0x00161758
		public override void OnExit()
		{
			if (this.cutBackOnExit)
			{
				CutToCamera.SwitchCamera(this.camera, this.oldCamera);
			}
		}

		// Token: 0x06003E16 RID: 15894 RVA: 0x00163573 File Offset: 0x00161773
		private static void SwitchCamera(Camera camera1, Camera camera2)
		{
			if (camera1 != null)
			{
				camera1.enabled = false;
			}
			if (camera2 != null)
			{
				camera2.enabled = true;
			}
		}

		// Token: 0x04004231 RID: 16945
		[RequiredField]
		[Tooltip("The Camera to activate.")]
		public Camera camera;

		// Token: 0x04004232 RID: 16946
		[Tooltip("Makes the camera the new MainCamera. The old MainCamera will be untagged.")]
		public bool makeMainCamera;

		// Token: 0x04004233 RID: 16947
		[Tooltip("Cut back to the original MainCamera when exiting this state.")]
		public bool cutBackOnExit;

		// Token: 0x04004234 RID: 16948
		private Camera oldCamera;
	}
}
