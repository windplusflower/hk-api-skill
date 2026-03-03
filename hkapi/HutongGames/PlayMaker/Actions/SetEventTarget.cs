using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CA1 RID: 3233
	[ActionCategory(ActionCategory.StateMachine)]
	[Tooltip("Sets the target FSM for all subsequent events sent by this state. The default 'Self' sends events to this FSM.")]
	public class SetEventTarget : FsmStateAction
	{
		// Token: 0x06004373 RID: 17267 RVA: 0x00003603 File Offset: 0x00001803
		public override void Reset()
		{
		}

		// Token: 0x06004374 RID: 17268 RVA: 0x00173200 File Offset: 0x00171400
		public override void OnEnter()
		{
			base.Fsm.EventTarget = this.eventTarget;
			base.Finish();
		}

		// Token: 0x040047BC RID: 18364
		public FsmEventTarget eventTarget;
	}
}
