using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B97 RID: 2967
	[ActionCategory(ActionCategory.StateMachine)]
	[Tooltip("Forward an event received by this FSM to another target.")]
	public class ForwardEvent : FsmStateAction
	{
		// Token: 0x06003EF7 RID: 16119 RVA: 0x00165A26 File Offset: 0x00163C26
		public override void Reset()
		{
			this.forwardTo = new FsmEventTarget
			{
				target = FsmEventTarget.EventTarget.FSMComponent
			};
			this.eventsToForward = null;
			this.eatEvents = true;
		}

		// Token: 0x06003EF8 RID: 16120 RVA: 0x00165A48 File Offset: 0x00163C48
		public override bool Event(FsmEvent fsmEvent)
		{
			if (this.eventsToForward != null)
			{
				FsmEvent[] array = this.eventsToForward;
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i] == fsmEvent)
					{
						base.Fsm.Event(this.forwardTo, fsmEvent);
						return this.eatEvents;
					}
				}
			}
			return false;
		}

		// Token: 0x04004307 RID: 17159
		[Tooltip("Forward to this target.")]
		public FsmEventTarget forwardTo;

		// Token: 0x04004308 RID: 17160
		[Tooltip("The events to forward.")]
		public FsmEvent[] eventsToForward;

		// Token: 0x04004309 RID: 17161
		[Tooltip("Should this action eat the events or pass them on.")]
		public bool eatEvents;
	}
}
