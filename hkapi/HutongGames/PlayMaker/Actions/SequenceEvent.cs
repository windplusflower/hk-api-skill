using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C8E RID: 3214
	[ActionCategory(ActionCategory.StateMachine)]
	[Tooltip("Sends the next event on the state each time the state is entered.")]
	public class SequenceEvent : FsmStateAction
	{
		// Token: 0x0600431D RID: 17181 RVA: 0x0017258A File Offset: 0x0017078A
		public override void Reset()
		{
			this.delay = null;
		}

		// Token: 0x0600431E RID: 17182 RVA: 0x00172594 File Offset: 0x00170794
		public override void OnEnter()
		{
			int num = base.State.Transitions.Length;
			if (num > 0)
			{
				FsmEvent fsmEvent = base.State.Transitions[this.eventIndex].FsmEvent;
				if (this.delay.Value < 0.001f)
				{
					base.Fsm.Event(fsmEvent);
					base.Finish();
				}
				else
				{
					this.delayedEvent = base.Fsm.DelayedEvent(fsmEvent, this.delay.Value);
				}
				this.eventIndex++;
				if (this.eventIndex == num)
				{
					this.eventIndex = 0;
				}
			}
		}

		// Token: 0x0600431F RID: 17183 RVA: 0x0017262F File Offset: 0x0017082F
		public override void OnUpdate()
		{
			if (DelayedEvent.WasSent(this.delayedEvent))
			{
				base.Finish();
			}
		}

		// Token: 0x04004775 RID: 18293
		[HasFloatSlider(0f, 10f)]
		public FsmFloat delay;

		// Token: 0x04004776 RID: 18294
		private DelayedEvent delayedEvent;

		// Token: 0x04004777 RID: 18295
		private int eventIndex;
	}
}
