using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C88 RID: 3208
	[ActionCategory(ActionCategory.StateMachine)]
	[Tooltip("Sends an Event by name after an optional delay. NOTE: Use this over Send Event if you store events as string variables.")]
	public class SendEventByNameV2 : FsmStateAction
	{
		// Token: 0x0600430A RID: 17162 RVA: 0x00171D56 File Offset: 0x0016FF56
		public override void Reset()
		{
			this.eventTarget = null;
			this.sendEvent = null;
			this.delay = null;
			this.everyFrame = false;
		}

		// Token: 0x0600430B RID: 17163 RVA: 0x00171D74 File Offset: 0x0016FF74
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

		// Token: 0x0600430C RID: 17164 RVA: 0x00171DF0 File Offset: 0x0016FFF0
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

		// Token: 0x04004757 RID: 18263
		[Tooltip("Where to send the event.")]
		public FsmEventTarget eventTarget;

		// Token: 0x04004758 RID: 18264
		[RequiredField]
		[Tooltip("The event to send. NOTE: Events must be marked Global to send between FSMs.")]
		public FsmString sendEvent;

		// Token: 0x04004759 RID: 18265
		[HasFloatSlider(0f, 10f)]
		[Tooltip("Optional delay in seconds.")]
		public FsmFloat delay;

		// Token: 0x0400475A RID: 18266
		[Tooltip("Repeat every frame. Rarely needed.")]
		public bool everyFrame;

		// Token: 0x0400475B RID: 18267
		private DelayedEvent delayedEvent;
	}
}
