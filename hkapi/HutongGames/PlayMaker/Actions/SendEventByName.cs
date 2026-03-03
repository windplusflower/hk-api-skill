using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C87 RID: 3207
	[ActionCategory(ActionCategory.StateMachine)]
	[Tooltip("Sends an Event by name after an optional delay. NOTE: Use this over Send Event if you store events as string variables.")]
	public class SendEventByName : FsmStateAction
	{
		// Token: 0x06004306 RID: 17158 RVA: 0x00171C82 File Offset: 0x0016FE82
		public override void Reset()
		{
			this.eventTarget = null;
			this.sendEvent = null;
			this.delay = null;
			this.everyFrame = false;
		}

		// Token: 0x06004307 RID: 17159 RVA: 0x00171CA0 File Offset: 0x0016FEA0
		public override void OnEnter()
		{
			if (this.delay.Value < 0.001f)
			{
				base.Fsm.Event(this.eventTarget, this.sendEvent.Value);
				if (!this.everyFrame)
				{
					base.Finish();
					return;
				}
			}
			else
			{
				this.delayedEvent = base.Fsm.DelayedEvent(this.eventTarget, FsmEvent.GetFsmEvent(this.sendEvent.Value), this.delay.Value);
			}
		}

		// Token: 0x06004308 RID: 17160 RVA: 0x00171D1C File Offset: 0x0016FF1C
		public override void OnUpdate()
		{
			if (!this.everyFrame)
			{
				if (DelayedEvent.WasSent(this.delayedEvent))
				{
					base.Finish();
					return;
				}
			}
			else
			{
				base.Fsm.Event(this.eventTarget, this.sendEvent.Value);
			}
		}

		// Token: 0x04004752 RID: 18258
		[Tooltip("Where to send the event.")]
		public FsmEventTarget eventTarget;

		// Token: 0x04004753 RID: 18259
		[RequiredField]
		[Tooltip("The event to send. NOTE: Events must be marked Global to send between FSMs.")]
		public FsmString sendEvent;

		// Token: 0x04004754 RID: 18260
		[HasFloatSlider(0f, 10f)]
		[Tooltip("Optional delay in seconds.")]
		public FsmFloat delay;

		// Token: 0x04004755 RID: 18261
		[Tooltip("Repeat every frame. Rarely needed, but can be useful when sending events to other FSMs.")]
		public bool everyFrame;

		// Token: 0x04004756 RID: 18262
		private DelayedEvent delayedEvent;
	}
}
