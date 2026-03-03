using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C2B RID: 3115
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("Adds a value to an Integer Variable.")]
	public class IntAdd : FsmStateAction
	{
		// Token: 0x06004148 RID: 16712 RVA: 0x0016C267 File Offset: 0x0016A467
		public override void Reset()
		{
			this.intVariable = null;
			this.add = null;
			this.everyFrame = false;
		}

		// Token: 0x06004149 RID: 16713 RVA: 0x0016C27E File Offset: 0x0016A47E
		public override void OnEnter()
		{
			this.intVariable.Value += this.add.Value;
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600414A RID: 16714 RVA: 0x0016C2AB File Offset: 0x0016A4AB
		public override void OnUpdate()
		{
			this.intVariable.Value += this.add.Value;
		}

		// Token: 0x04004589 RID: 17801
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmInt intVariable;

		// Token: 0x0400458A RID: 17802
		[RequiredField]
		public FsmInt add;

		// Token: 0x0400458B RID: 17803
		public bool everyFrame;
	}
}
