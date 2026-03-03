using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D21 RID: 3361
	[ActionCategory(ActionCategory.Vector3)]
	[Tooltip("Subtracts a Vector3 value from a Vector3 variable.")]
	public class Vector3Subtract : FsmStateAction
	{
		// Token: 0x060045A0 RID: 17824 RVA: 0x00179B09 File Offset: 0x00177D09
		public override void Reset()
		{
			this.vector3Variable = null;
			this.subtractVector = new FsmVector3
			{
				UseVariable = true
			};
			this.everyFrame = false;
		}

		// Token: 0x060045A1 RID: 17825 RVA: 0x00179B2B File Offset: 0x00177D2B
		public override void OnEnter()
		{
			this.vector3Variable.Value = this.vector3Variable.Value - this.subtractVector.Value;
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060045A2 RID: 17826 RVA: 0x00179B61 File Offset: 0x00177D61
		public override void OnUpdate()
		{
			this.vector3Variable.Value = this.vector3Variable.Value - this.subtractVector.Value;
		}

		// Token: 0x04004A0C RID: 18956
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmVector3 vector3Variable;

		// Token: 0x04004A0D RID: 18957
		[RequiredField]
		public FsmVector3 subtractVector;

		// Token: 0x04004A0E RID: 18958
		public bool everyFrame;
	}
}
