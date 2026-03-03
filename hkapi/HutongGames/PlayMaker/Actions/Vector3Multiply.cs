using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D1B RID: 3355
	[ActionCategory(ActionCategory.Vector3)]
	[Tooltip("Multiplies a Vector3 variable by a Float.")]
	public class Vector3Multiply : FsmStateAction
	{
		// Token: 0x0600458C RID: 17804 RVA: 0x001796E9 File Offset: 0x001778E9
		public override void Reset()
		{
			this.vector3Variable = null;
			this.multiplyBy = 1f;
			this.everyFrame = false;
		}

		// Token: 0x0600458D RID: 17805 RVA: 0x00179709 File Offset: 0x00177909
		public override void OnEnter()
		{
			this.vector3Variable.Value = this.vector3Variable.Value * this.multiplyBy.Value;
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600458E RID: 17806 RVA: 0x0017973F File Offset: 0x0017793F
		public override void OnUpdate()
		{
			this.vector3Variable.Value = this.vector3Variable.Value * this.multiplyBy.Value;
		}

		// Token: 0x040049EE RID: 18926
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmVector3 vector3Variable;

		// Token: 0x040049EF RID: 18927
		[RequiredField]
		public FsmFloat multiplyBy;

		// Token: 0x040049F0 RID: 18928
		public bool everyFrame;
	}
}
