using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BF5 RID: 3061
	[ActionCategory(ActionCategory.StateMachine)]
	[Tooltip("Gets the event that caused the transition to the current state, and stores it in a String Variable.")]
	public class GetLastEvent : FsmStateAction
	{
		// Token: 0x0600405D RID: 16477 RVA: 0x0016A115 File Offset: 0x00168315
		public override void Reset()
		{
			this.storeEvent = null;
		}

		// Token: 0x0600405E RID: 16478 RVA: 0x0016A11E File Offset: 0x0016831E
		public override void OnEnter()
		{
			this.storeEvent.Value = ((base.Fsm.LastTransition == null) ? "START" : base.Fsm.LastTransition.EventName);
			base.Finish();
		}

		// Token: 0x040044C0 RID: 17600
		[UIHint(UIHint.Variable)]
		public FsmString storeEvent;
	}
}
