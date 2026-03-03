using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A36 RID: 2614
	[ActionCategory(ActionCategory.StateMachine)]
	[Tooltip("Sends a Random Event picked from an array of Events. Optionally set the relative weight of each event. Use ints to keep events from being fired x times in a row.")]
	public class SendRandomEventV2 : FsmStateAction
	{
		// Token: 0x060038B3 RID: 14515 RVA: 0x0014BC34 File Offset: 0x00149E34
		public override void Reset()
		{
			this.events = new FsmEvent[3];
			this.weights = new FsmFloat[]
			{
				1f,
				1f,
				1f
			};
		}

		// Token: 0x060038B4 RID: 14516 RVA: 0x0014BC80 File Offset: 0x00149E80
		public override void OnEnter()
		{
			bool flag = false;
			while (!flag)
			{
				int randomWeightedIndex = ActionHelpers.GetRandomWeightedIndex(this.weights);
				if (randomWeightedIndex != -1 && this.trackingInts[randomWeightedIndex].Value < this.eventMax[randomWeightedIndex].Value)
				{
					int value = ++this.trackingInts[randomWeightedIndex].Value;
					for (int i = 0; i < this.trackingInts.Length; i++)
					{
						this.trackingInts[i].Value = 0;
					}
					this.trackingInts[randomWeightedIndex].Value = value;
					flag = true;
					base.Fsm.Event(this.events[randomWeightedIndex]);
				}
			}
			base.Finish();
		}

		// Token: 0x04003B5E RID: 15198
		[CompoundArray("Events", "Event", "Weight")]
		public FsmEvent[] events;

		// Token: 0x04003B5F RID: 15199
		[HasFloatSlider(0f, 1f)]
		public FsmFloat[] weights;

		// Token: 0x04003B60 RID: 15200
		[UIHint(UIHint.Variable)]
		public FsmInt[] trackingInts;

		// Token: 0x04003B61 RID: 15201
		public FsmInt[] eventMax;

		// Token: 0x04003B62 RID: 15202
		private DelayedEvent delayedEvent;
	}
}
