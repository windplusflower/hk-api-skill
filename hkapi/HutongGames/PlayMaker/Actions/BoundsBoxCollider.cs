using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200099B RID: 2459
	[ActionCategory("Physics 2d")]
	[Tooltip("Get the dimensions of the BoxCollider 2D")]
	public class BoundsBoxCollider : FsmStateAction
	{
		// Token: 0x060035E3 RID: 13795 RVA: 0x0013DC65 File Offset: 0x0013BE65
		public override void Reset()
		{
			this.gameObject1 = null;
			this.scaleX = null;
			this.scaleY = null;
			this.everyFrame = false;
		}

		// Token: 0x060035E4 RID: 13796 RVA: 0x0013DC84 File Offset: 0x0013BE84
		public void GetEm()
		{
			Vector2 vector = base.Fsm.GetOwnerDefaultTarget(this.gameObject1).GetComponent<BoxCollider2D>().bounds.size;
			if (this.scaleVector2 != null)
			{
				this.scaleVector2.Value = vector;
			}
			if (this.scaleX != null)
			{
				this.scaleX.Value = vector.x;
			}
			if (this.scaleY != null)
			{
				this.scaleY.Value = vector.y;
			}
		}

		// Token: 0x060035E5 RID: 13797 RVA: 0x0013DD00 File Offset: 0x0013BF00
		public override void OnEnter()
		{
			this.GetEm();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060035E6 RID: 13798 RVA: 0x0013DD16 File Offset: 0x0013BF16
		public override void OnUpdate()
		{
			this.GetEm();
		}

		// Token: 0x0400377B RID: 14203
		[RequiredField]
		public FsmOwnerDefault gameObject1;

		// Token: 0x0400377C RID: 14204
		[Tooltip("Store the dimensions of the BoxCollider2D")]
		[UIHint(UIHint.Variable)]
		public FsmVector2 scaleVector2;

		// Token: 0x0400377D RID: 14205
		[UIHint(UIHint.Variable)]
		public FsmFloat scaleX;

		// Token: 0x0400377E RID: 14206
		[UIHint(UIHint.Variable)]
		public FsmFloat scaleY;

		// Token: 0x0400377F RID: 14207
		public bool everyFrame;
	}
}
