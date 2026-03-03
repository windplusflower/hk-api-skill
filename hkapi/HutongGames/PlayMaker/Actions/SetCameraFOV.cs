using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C9B RID: 3227
	[ActionCategory(ActionCategory.Camera)]
	[Tooltip("Sets Field of View used by the Camera.")]
	public class SetCameraFOV : ComponentAction<Camera>
	{
		// Token: 0x06004357 RID: 17239 RVA: 0x00172D25 File Offset: 0x00170F25
		public override void Reset()
		{
			this.gameObject = null;
			this.fieldOfView = 50f;
			this.everyFrame = false;
		}

		// Token: 0x06004358 RID: 17240 RVA: 0x00172D45 File Offset: 0x00170F45
		public override void OnEnter()
		{
			this.DoSetCameraFOV();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004359 RID: 17241 RVA: 0x00172D5B File Offset: 0x00170F5B
		public override void OnUpdate()
		{
			this.DoSetCameraFOV();
		}

		// Token: 0x0600435A RID: 17242 RVA: 0x00172D64 File Offset: 0x00170F64
		private void DoSetCameraFOV()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (base.UpdateCache(ownerDefaultTarget))
			{
				base.camera.fieldOfView = this.fieldOfView.Value;
			}
		}

		// Token: 0x0400479D RID: 18333
		[RequiredField]
		[CheckForComponent(typeof(Camera))]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400479E RID: 18334
		[RequiredField]
		public FsmFloat fieldOfView;

		// Token: 0x0400479F RID: 18335
		public bool everyFrame;
	}
}
