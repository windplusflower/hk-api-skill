using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D18 RID: 3352
	[ActionCategory(ActionCategory.Vector3)]
	[Tooltip("Reverses the direction of a Vector3 Variable. Same as multiplying by -1.")]
	public class Vector3Invert : FsmStateAction
	{
		// Token: 0x0600457F RID: 17791 RVA: 0x0017949F File Offset: 0x0017769F
		public override void Reset()
		{
			this.vector3Variable = null;
			this.everyFrame = false;
		}

		// Token: 0x06004580 RID: 17792 RVA: 0x001794AF File Offset: 0x001776AF
		public override void OnEnter()
		{
			this.vector3Variable.Value = this.vector3Variable.Value * -1f;
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004581 RID: 17793 RVA: 0x001794DF File Offset: 0x001776DF
		public override void OnUpdate()
		{
			this.vector3Variable.Value = this.vector3Variable.Value * -1f;
		}

		// Token: 0x040049E4 RID: 18916
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmVector3 vector3Variable;

		// Token: 0x040049E5 RID: 18917
		public bool everyFrame;
	}
}
