using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CC2 RID: 3266
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("Sets the value of an integer variable using a float value.")]
	public class SetIntFromFloat : FsmStateAction
	{
		// Token: 0x06004405 RID: 17413 RVA: 0x00174C21 File Offset: 0x00172E21
		public override void Reset()
		{
			this.intVariable = null;
			this.floatValue = null;
			this.everyFrame = false;
		}

		// Token: 0x06004406 RID: 17414 RVA: 0x00174C38 File Offset: 0x00172E38
		public override void OnEnter()
		{
			this.intVariable.Value = (int)this.floatValue.Value;
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004407 RID: 17415 RVA: 0x00174C5F File Offset: 0x00172E5F
		public override void OnUpdate()
		{
			this.intVariable.Value = (int)this.floatValue.Value;
		}

		// Token: 0x04004866 RID: 18534
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmInt intVariable;

		// Token: 0x04004867 RID: 18535
		public FsmFloat floatValue;

		// Token: 0x04004868 RID: 18536
		public bool everyFrame;
	}
}
