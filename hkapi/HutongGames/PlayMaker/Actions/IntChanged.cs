using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C2C RID: 3116
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Tests if the value of an integer variable changed. Use this to send an event on change, or store a bool that can be used in other operations.")]
	public class IntChanged : FsmStateAction
	{
		// Token: 0x0600414C RID: 16716 RVA: 0x0016C2CA File Offset: 0x0016A4CA
		public override void Reset()
		{
			this.intVariable = null;
			this.changedEvent = null;
			this.storeResult = null;
		}

		// Token: 0x0600414D RID: 16717 RVA: 0x0016C2E1 File Offset: 0x0016A4E1
		public override void OnEnter()
		{
			if (this.intVariable.IsNone)
			{
				base.Finish();
				return;
			}
			this.previousValue = this.intVariable.Value;
		}

		// Token: 0x0600414E RID: 16718 RVA: 0x0016C308 File Offset: 0x0016A508
		public override void OnUpdate()
		{
			this.storeResult.Value = false;
			if (this.intVariable.Value != this.previousValue)
			{
				this.previousValue = this.intVariable.Value;
				this.storeResult.Value = true;
				base.Fsm.Event(this.changedEvent);
			}
		}

		// Token: 0x0400458C RID: 17804
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmInt intVariable;

		// Token: 0x0400458D RID: 17805
		public FsmEvent changedEvent;

		// Token: 0x0400458E RID: 17806
		[UIHint(UIHint.Variable)]
		public FsmBool storeResult;

		// Token: 0x0400458F RID: 17807
		private int previousValue;
	}
}
