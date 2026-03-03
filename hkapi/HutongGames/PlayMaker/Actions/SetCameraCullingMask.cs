using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C9A RID: 3226
	[ActionCategory(ActionCategory.Camera)]
	[Tooltip("Sets the Culling Mask used by the Camera.")]
	public class SetCameraCullingMask : ComponentAction<Camera>
	{
		// Token: 0x06004352 RID: 17234 RVA: 0x00172C93 File Offset: 0x00170E93
		public override void Reset()
		{
			this.gameObject = null;
			this.cullingMask = new FsmInt[0];
			this.invertMask = false;
			this.everyFrame = false;
		}

		// Token: 0x06004353 RID: 17235 RVA: 0x00172CBB File Offset: 0x00170EBB
		public override void OnEnter()
		{
			this.DoSetCameraCullingMask();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004354 RID: 17236 RVA: 0x00172CD1 File Offset: 0x00170ED1
		public override void OnUpdate()
		{
			this.DoSetCameraCullingMask();
		}

		// Token: 0x06004355 RID: 17237 RVA: 0x00172CDC File Offset: 0x00170EDC
		private void DoSetCameraCullingMask()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (base.UpdateCache(ownerDefaultTarget))
			{
				base.camera.cullingMask = ActionHelpers.LayerArrayToLayerMask(this.cullingMask, this.invertMask.Value);
			}
		}

		// Token: 0x04004799 RID: 18329
		[RequiredField]
		[CheckForComponent(typeof(Camera))]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400479A RID: 18330
		[Tooltip("Cull these layers.")]
		[UIHint(UIHint.Layer)]
		public FsmInt[] cullingMask;

		// Token: 0x0400479B RID: 18331
		[Tooltip("Invert the mask, so you cull all layers except those defined above.")]
		public FsmBool invertMask;

		// Token: 0x0400479C RID: 18332
		public bool everyFrame;
	}
}
