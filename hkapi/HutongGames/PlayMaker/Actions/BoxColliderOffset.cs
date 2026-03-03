using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200099C RID: 2460
	[ActionCategory("Physics 2d")]
	[Tooltip("Get the offset of the BoxCollider 2D as a Vector2")]
	public class BoxColliderOffset : FsmStateAction
	{
		// Token: 0x060035E8 RID: 13800 RVA: 0x0013DD1E File Offset: 0x0013BF1E
		public override void Reset()
		{
			this.gameObject1 = null;
			this.offsetX = null;
			this.offsetY = null;
			this.everyFrame = false;
		}

		// Token: 0x060035E9 RID: 13801 RVA: 0x0013DD3C File Offset: 0x0013BF3C
		public void GetOffset()
		{
			Vector2 offset = base.Fsm.GetOwnerDefaultTarget(this.gameObject1).GetComponent<BoxCollider2D>().offset;
			if (this.offsetVector2 != null)
			{
				this.offsetVector2.Value = offset;
			}
			if (this.offsetX != null)
			{
				this.offsetX.Value = offset.x;
			}
			if (this.offsetY != null)
			{
				this.offsetY.Value = offset.y;
			}
		}

		// Token: 0x060035EA RID: 13802 RVA: 0x0013DDAB File Offset: 0x0013BFAB
		public override void OnEnter()
		{
			this.GetOffset();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060035EB RID: 13803 RVA: 0x0013DDC1 File Offset: 0x0013BFC1
		public override void OnUpdate()
		{
			this.GetOffset();
		}

		// Token: 0x04003780 RID: 14208
		[RequiredField]
		public FsmOwnerDefault gameObject1;

		// Token: 0x04003781 RID: 14209
		[Tooltip("Vector2 where the offset of the BoxCollider2D is stored")]
		[UIHint(UIHint.Variable)]
		public FsmVector2 offsetVector2;

		// Token: 0x04003782 RID: 14210
		[UIHint(UIHint.Variable)]
		public FsmFloat offsetX;

		// Token: 0x04003783 RID: 14211
		[UIHint(UIHint.Variable)]
		public FsmFloat offsetY;

		// Token: 0x04003784 RID: 14212
		public bool everyFrame;
	}
}
