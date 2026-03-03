using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C8D RID: 3213
	[ActionCategory(ActionCategory.StateMachine)]
	[Tooltip("Sends a Random Event picked from an array of Events. Optionally set the relative weight of each event.")]
	public class SendRandomEvent : FsmStateAction
	{
		// Token: 0x06004319 RID: 17177 RVA: 0x001724A4 File Offset: 0x001706A4
		public override void Reset()
		{
			this.events = new FsmEvent[3];
			this.weights = new FsmFloat[]
			{
				1f,
				1f,
				1f
			};
			this.delay = null;
		}

		// Token: 0x0600431A RID: 17178 RVA: 0x001724F8 File Offset: 0x001706F8
		public override void OnEnter()
		{
			if (this.events.Length != 0)
			{
				int randomWeightedIndex = ActionHelpers.GetRandomWeightedIndex(this.weights);
				if (randomWeightedIndex != -1)
				{
					if (this.delay.Value < 0.001f)
					{
						base.Fsm.Event(this.events[randomWeightedIndex]);
						base.Finish();
						return;
					}
					this.delayedEvent = base.Fsm.DelayedEvent(this.events[randomWeightedIndex], this.delay.Value);
					return;
				}
			}
			base.Finish();
		}

		// Token: 0x0600431B RID: 17179 RVA: 0x00172575 File Offset: 0x00170775
		public override void OnUpdate()
		{
			if (DelayedEvent.WasSent(this.delayedEvent))
			{
				base.Finish();
			}
		}

		// Token: 0x04004771 RID: 18289
		[CompoundArray("Events", "Event", "Weight")]
		public FsmEvent[] events;

		// Token: 0x04004772 RID: 18290
		[HasFloatSlider(0f, 1f)]
		public FsmFloat[] weights;

		// Token: 0x04004773 RID: 18291
		public FsmFloat delay;

		// Token: 0x04004774 RID: 18292
		private DelayedEvent delayedEvent;
	}
}
