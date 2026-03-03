using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B36 RID: 2870
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Tests if any of the given Bool Variables are True.")]
	public class BoolAnyTrue : FsmStateAction
	{
		// Token: 0x06003D59 RID: 15705 RVA: 0x00160BCB File Offset: 0x0015EDCB
		public override void Reset()
		{
			this.boolVariables = null;
			this.sendEvent = null;
			this.storeResult = null;
			this.everyFrame = false;
		}

		// Token: 0x06003D5A RID: 15706 RVA: 0x00160BE9 File Offset: 0x0015EDE9
		public override void OnEnter()
		{
			this.DoAnyTrue();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003D5B RID: 15707 RVA: 0x00160BFF File Offset: 0x0015EDFF
		public override void OnUpdate()
		{
			this.DoAnyTrue();
		}

		// Token: 0x06003D5C RID: 15708 RVA: 0x00160C08 File Offset: 0x0015EE08
		private void DoAnyTrue()
		{
			if (this.boolVariables.Length == 0)
			{
				return;
			}
			this.storeResult.Value = false;
			for (int i = 0; i < this.boolVariables.Length; i++)
			{
				if (this.boolVariables[i].Value)
				{
					base.Fsm.Event(this.sendEvent);
					this.storeResult.Value = true;
					return;
				}
			}
		}

		// Token: 0x0400416B RID: 16747
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Bool variables to check.")]
		public FsmBool[] boolVariables;

		// Token: 0x0400416C RID: 16748
		[Tooltip("Event to send if any of the Bool variables are True.")]
		public FsmEvent sendEvent;

		// Token: 0x0400416D RID: 16749
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in a Bool variable.")]
		public FsmBool storeResult;

		// Token: 0x0400416E RID: 16750
		[Tooltip("Repeat every frame while the state is active.")]
		public bool everyFrame;
	}
}
