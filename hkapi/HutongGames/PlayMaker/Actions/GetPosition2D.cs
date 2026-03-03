using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009DE RID: 2526
	[ActionCategory(ActionCategory.Transform)]
	[Tooltip("Gets the 2D Position of a Game Object and stores it in a Vector2 Variable or each Axis in a Float Variable")]
	public class GetPosition2D : FsmStateAction
	{
		// Token: 0x06003725 RID: 14117 RVA: 0x001449C2 File Offset: 0x00142BC2
		public override void Reset()
		{
			this.gameObject = null;
			this.vector = null;
			this.x = null;
			this.y = null;
			this.space = Space.World;
			this.everyFrame = false;
		}

		// Token: 0x06003726 RID: 14118 RVA: 0x001449EE File Offset: 0x00142BEE
		public override void OnEnter()
		{
			this.DoGetPosition();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003727 RID: 14119 RVA: 0x00144A04 File Offset: 0x00142C04
		public override void OnUpdate()
		{
			this.DoGetPosition();
		}

		// Token: 0x06003728 RID: 14120 RVA: 0x00144A0C File Offset: 0x00142C0C
		private void DoGetPosition()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			Vector3 vector = (this.space == Space.World) ? ownerDefaultTarget.transform.position : ownerDefaultTarget.transform.localPosition;
			this.vector.Value = vector;
			this.x.Value = vector.x;
			this.y.Value = vector.y;
		}

		// Token: 0x0400393D RID: 14653
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400393E RID: 14654
		[UIHint(UIHint.Variable)]
		public FsmVector2 vector;

		// Token: 0x0400393F RID: 14655
		[UIHint(UIHint.Variable)]
		public FsmFloat x;

		// Token: 0x04003940 RID: 14656
		[UIHint(UIHint.Variable)]
		public FsmFloat y;

		// Token: 0x04003941 RID: 14657
		public Space space;

		// Token: 0x04003942 RID: 14658
		public bool everyFrame;
	}
}
