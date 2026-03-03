using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C98 RID: 3224
	[ActionCategory(ActionCategory.Camera)]
	[Tooltip("Sets the Background Color used by the Camera.")]
	public class SetBackgroundColor : ComponentAction<Camera>
	{
		// Token: 0x06004349 RID: 17225 RVA: 0x00172BB7 File Offset: 0x00170DB7
		public override void Reset()
		{
			this.gameObject = null;
			this.backgroundColor = Color.black;
			this.everyFrame = false;
		}

		// Token: 0x0600434A RID: 17226 RVA: 0x00172BD7 File Offset: 0x00170DD7
		public override void OnEnter()
		{
			this.DoSetBackgroundColor();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600434B RID: 17227 RVA: 0x00172BED File Offset: 0x00170DED
		public override void OnUpdate()
		{
			this.DoSetBackgroundColor();
		}

		// Token: 0x0600434C RID: 17228 RVA: 0x00172BF8 File Offset: 0x00170DF8
		private void DoSetBackgroundColor()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (base.UpdateCache(ownerDefaultTarget))
			{
				base.camera.backgroundColor = this.backgroundColor.Value;
			}
		}

		// Token: 0x04004793 RID: 18323
		[RequiredField]
		[CheckForComponent(typeof(Camera))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004794 RID: 18324
		[RequiredField]
		public FsmColor backgroundColor;

		// Token: 0x04004795 RID: 18325
		public bool everyFrame;
	}
}
