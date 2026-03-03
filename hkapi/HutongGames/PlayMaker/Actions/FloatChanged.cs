using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B8A RID: 2954
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Tests if the value of a Float variable changed. Use this to send an event on change, or store a bool that can be used in other operations.")]
	public class FloatChanged : FsmStateAction
	{
		// Token: 0x06003EBF RID: 16063 RVA: 0x0016519F File Offset: 0x0016339F
		public override void Reset()
		{
			this.floatVariable = null;
			this.changedEvent = null;
			this.storeResult = null;
		}

		// Token: 0x06003EC0 RID: 16064 RVA: 0x001651B6 File Offset: 0x001633B6
		public override void OnEnter()
		{
			if (this.floatVariable.IsNone)
			{
				base.Finish();
				return;
			}
			this.previousValue = this.floatVariable.Value;
		}

		// Token: 0x06003EC1 RID: 16065 RVA: 0x001651E0 File Offset: 0x001633E0
		public override void OnUpdate()
		{
			this.storeResult.Value = false;
			if (this.floatVariable.Value != this.previousValue)
			{
				this.previousValue = this.floatVariable.Value;
				this.storeResult.Value = true;
				base.Fsm.Event(this.changedEvent);
			}
		}

		// Token: 0x040042C9 RID: 17097
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Float variable to watch for a change.")]
		public FsmFloat floatVariable;

		// Token: 0x040042CA RID: 17098
		[Tooltip("Event to send if the float variable changes.")]
		public FsmEvent changedEvent;

		// Token: 0x040042CB RID: 17099
		[UIHint(UIHint.Variable)]
		[Tooltip("Set to True if the float variable changes.")]
		public FsmBool storeResult;

		// Token: 0x040042CC RID: 17100
		private float previousValue;
	}
}
