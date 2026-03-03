using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D1C RID: 3356
	[ActionCategory(ActionCategory.Vector3)]
	[Tooltip("Normalizes a Vector3 Variable.")]
	public class Vector3Normalize : FsmStateAction
	{
		// Token: 0x06004590 RID: 17808 RVA: 0x00179767 File Offset: 0x00177967
		public override void Reset()
		{
			this.vector3Variable = null;
			this.everyFrame = false;
		}

		// Token: 0x06004591 RID: 17809 RVA: 0x00179778 File Offset: 0x00177978
		public override void OnEnter()
		{
			this.vector3Variable.Value = this.vector3Variable.Value.normalized;
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004592 RID: 17810 RVA: 0x001797B4 File Offset: 0x001779B4
		public override void OnUpdate()
		{
			this.vector3Variable.Value = this.vector3Variable.Value.normalized;
		}

		// Token: 0x040049F1 RID: 18929
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmVector3 vector3Variable;

		// Token: 0x040049F2 RID: 18930
		public bool everyFrame;
	}
}
