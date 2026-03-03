using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C86 RID: 3206
	[ActionCategory(ActionCategory.StateMachine)]
	[ActionTarget(typeof(PlayMakerFSM), "eventTarget", false)]
	[ActionTarget(typeof(GameObject), "eventTarget", false)]
	[Tooltip("Sends an Event after an optional delay. NOTE: To send events between FSMs they must be marked as Global in the Events Browser.")]
	public class SendEvent : FsmStateAction
	{
		// Token: 0x06004302 RID: 17154 RVA: 0x00171BC1 File Offset: 0x0016FDC1
		public override void Reset()
		{
			this.eventTarget = null;
			this.sendEvent = null;
			this.delay = null;
			this.everyFrame = false;
		}

		// Token: 0x06004303 RID: 17155 RVA: 0x00171BE0 File Offset: 0x0016FDE0
		public override void OnEnter()
		{
			if (this.delay.Value < 0.001f)
			{
				base.Fsm.Event(this.eventTarget, this.sendEvent);
				if (!this.everyFrame)
				{
					base.Finish();
					return;
				}
			}
			else
			{
				this.delayedEvent = base.Fsm.DelayedEvent(this.eventTarget, this.sendEvent, this.delay.Value);
			}
		}

		// Token: 0x06004304 RID: 17156 RVA: 0x00171C4D File Offset: 0x0016FE4D
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
				base.Fsm.Event(this.eventTarget, this.sendEvent);
			}
		}

		// Token: 0x0400474D RID: 18253
		[Tooltip("Where to send the event.")]
		public FsmEventTarget eventTarget;

		// Token: 0x0400474E RID: 18254
		[RequiredField]
		[Tooltip("The event to send. NOTE: Events must be marked Global to send between FSMs.")]
		public FsmEvent sendEvent;

		// Token: 0x0400474F RID: 18255
		[HasFloatSlider(0f, 10f)]
		[Tooltip("Optional delay in seconds.")]
		public FsmFloat delay;

		// Token: 0x04004750 RID: 18256
		[Tooltip("Repeat every frame. Rarely needed, but can be useful when sending events to other FSMs.")]
		public bool everyFrame;

		// Token: 0x04004751 RID: 18257
		private DelayedEvent delayedEvent;
	}
}
