using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C10 RID: 3088
	[ActionCategory(ActionCategory.Transform)]
	[Tooltip("Gets the Scale of a Game Object and stores it in a Vector3 Variable or each Axis in a Float Variable")]
	public class GetScale : FsmStateAction
	{
		// Token: 0x060040D0 RID: 16592 RVA: 0x0016B0F3 File Offset: 0x001692F3
		public override void Reset()
		{
			this.gameObject = null;
			this.vector = null;
			this.xScale = null;
			this.yScale = null;
			this.zScale = null;
			this.space = Space.World;
			this.everyFrame = false;
		}

		// Token: 0x060040D1 RID: 16593 RVA: 0x0016B126 File Offset: 0x00169326
		public override void OnEnter()
		{
			this.DoGetScale();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060040D2 RID: 16594 RVA: 0x0016B13C File Offset: 0x0016933C
		public override void OnUpdate()
		{
			this.DoGetScale();
		}

		// Token: 0x060040D3 RID: 16595 RVA: 0x0016B144 File Offset: 0x00169344
		private void DoGetScale()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			Vector3 vector = (this.space == Space.World) ? ownerDefaultTarget.transform.lossyScale : ownerDefaultTarget.transform.localScale;
			this.vector.Value = vector;
			this.xScale.Value = vector.x;
			this.yScale.Value = vector.y;
			this.zScale.Value = vector.z;
		}

		// Token: 0x0400451B RID: 17691
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400451C RID: 17692
		[UIHint(UIHint.Variable)]
		public FsmVector3 vector;

		// Token: 0x0400451D RID: 17693
		[UIHint(UIHint.Variable)]
		public FsmFloat xScale;

		// Token: 0x0400451E RID: 17694
		[UIHint(UIHint.Variable)]
		public FsmFloat yScale;

		// Token: 0x0400451F RID: 17695
		[UIHint(UIHint.Variable)]
		public FsmFloat zScale;

		// Token: 0x04004520 RID: 17696
		public Space space;

		// Token: 0x04004521 RID: 17697
		public bool everyFrame;
	}
}
