using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B86 RID: 2950
	[ActionCategory(ActionCategory.Transform)]
	[Tooltip("Sets the Scale of a Game Object. To leave any axis unchanged, set variable to 'None'.")]
	public class FlipScale : FsmStateAction
	{
		// Token: 0x06003EAA RID: 16042 RVA: 0x00164F84 File Offset: 0x00163184
		public override void Reset()
		{
			this.flipHorizontally = false;
			this.flipVertically = false;
			this.everyFrame = false;
		}

		// Token: 0x06003EAB RID: 16043 RVA: 0x00164F9B File Offset: 0x0016319B
		public override void OnEnter()
		{
			this.DoFlipScale();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003EAC RID: 16044 RVA: 0x00164FB1 File Offset: 0x001631B1
		public override void OnUpdate()
		{
			if (!this.lateUpdate)
			{
				this.DoFlipScale();
			}
		}

		// Token: 0x06003EAD RID: 16045 RVA: 0x00164FC1 File Offset: 0x001631C1
		public override void OnLateUpdate()
		{
			if (this.lateUpdate)
			{
				this.DoFlipScale();
			}
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003EAE RID: 16046 RVA: 0x00164FE0 File Offset: 0x001631E0
		private void DoFlipScale()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			Vector3 localScale = ownerDefaultTarget.transform.localScale;
			if (this.flipHorizontally)
			{
				localScale.x = -localScale.x;
			}
			if (this.flipVertically)
			{
				localScale.y = -localScale.y;
			}
			ownerDefaultTarget.transform.localScale = localScale;
		}

		// Token: 0x040042BB RID: 17083
		[RequiredField]
		[Tooltip("The GameObject to scale.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040042BC RID: 17084
		public bool flipHorizontally;

		// Token: 0x040042BD RID: 17085
		public bool flipVertically;

		// Token: 0x040042BE RID: 17086
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		// Token: 0x040042BF RID: 17087
		[Tooltip("Perform in LateUpdate. This is useful if you want to override the position of objects that are animated or otherwise positioned in Update.")]
		public bool lateUpdate;
	}
}
