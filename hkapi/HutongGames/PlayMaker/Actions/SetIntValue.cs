using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CC3 RID: 3267
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("Sets the value of an Integer Variable.")]
	public class SetIntValue : FsmStateAction
	{
		// Token: 0x06004409 RID: 17417 RVA: 0x00174C78 File Offset: 0x00172E78
		public override void Reset()
		{
			this.intVariable = null;
			this.intValue = null;
			this.everyFrame = false;
		}

		// Token: 0x0600440A RID: 17418 RVA: 0x00174C8F File Offset: 0x00172E8F
		public override void OnEnter()
		{
			this.intVariable.Value = this.intValue.Value;
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600440B RID: 17419 RVA: 0x00174CB5 File Offset: 0x00172EB5
		public override void OnUpdate()
		{
			this.intVariable.Value = this.intValue.Value;
		}

		// Token: 0x04004869 RID: 18537
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmInt intVariable;

		// Token: 0x0400486A RID: 18538
		[RequiredField]
		public FsmInt intValue;

		// Token: 0x0400486B RID: 18539
		public bool everyFrame;
	}
}
