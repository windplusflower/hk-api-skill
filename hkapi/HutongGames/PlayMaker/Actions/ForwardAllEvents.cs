using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B96 RID: 2966
	[ActionCategory(ActionCategory.StateMachine)]
	[Tooltip("Forwards all event received by this FSM to another target. Optionally specify a list of events to ignore.")]
	public class ForwardAllEvents : FsmStateAction
	{
		// Token: 0x06003EF4 RID: 16116 RVA: 0x001659AC File Offset: 0x00163BAC
		public override void Reset()
		{
			this.forwardTo = new FsmEventTarget
			{
				target = FsmEventTarget.EventTarget.FSMComponent
			};
			this.exceptThese = new FsmEvent[]
			{
				FsmEvent.Finished
			};
			this.eatEvents = true;
		}

		// Token: 0x06003EF5 RID: 16117 RVA: 0x001659DC File Offset: 0x00163BDC
		public override bool Event(FsmEvent fsmEvent)
		{
			if (this.exceptThese != null)
			{
				FsmEvent[] array = this.exceptThese;
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i] == fsmEvent)
					{
						return false;
					}
				}
			}
			base.Fsm.Event(this.forwardTo, fsmEvent);
			return this.eatEvents;
		}

		// Token: 0x04004304 RID: 17156
		[Tooltip("Forward to this target.")]
		public FsmEventTarget forwardTo;

		// Token: 0x04004305 RID: 17157
		[Tooltip("Don't forward these events.")]
		public FsmEvent[] exceptThese;

		// Token: 0x04004306 RID: 17158
		[Tooltip("Should this action eat the events or pass them on.")]
		public bool eatEvents;
	}
}
