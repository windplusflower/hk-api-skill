using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C99 RID: 3225
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("Sets the value of a Bool Variable.")]
	public class SetBoolValue : FsmStateAction
	{
		// Token: 0x0600434E RID: 17230 RVA: 0x00172C3E File Offset: 0x00170E3E
		public override void Reset()
		{
			this.boolVariable = null;
			this.boolValue = null;
			this.everyFrame = false;
		}

		// Token: 0x0600434F RID: 17231 RVA: 0x00172C55 File Offset: 0x00170E55
		public override void OnEnter()
		{
			this.boolVariable.Value = this.boolValue.Value;
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004350 RID: 17232 RVA: 0x00172C7B File Offset: 0x00170E7B
		public override void OnUpdate()
		{
			this.boolVariable.Value = this.boolValue.Value;
		}

		// Token: 0x04004796 RID: 18326
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmBool boolVariable;

		// Token: 0x04004797 RID: 18327
		[RequiredField]
		public FsmBool boolValue;

		// Token: 0x04004798 RID: 18328
		public bool everyFrame;
	}
}
