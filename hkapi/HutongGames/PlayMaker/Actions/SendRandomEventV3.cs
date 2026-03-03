using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A37 RID: 2615
	[ActionCategory(ActionCategory.StateMachine)]
	[Tooltip("Sends a Random Event picked from an array of Events. Optionally set the relative weight of each event. Use ints to keep events from being fired x times in a row.")]
	public class SendRandomEventV3 : FsmStateAction
	{
		// Token: 0x060038B6 RID: 14518 RVA: 0x0014BD34 File Offset: 0x00149F34
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

		// Token: 0x060038B7 RID: 14519 RVA: 0x0014BD80 File Offset: 0x00149F80
		public override void OnEnter()
		{
			bool flag = false;
			bool flag2 = false;
			int num = 0;
			while (!flag)
			{
				int randomWeightedIndex = ActionHelpers.GetRandomWeightedIndex(this.weights);
				if (randomWeightedIndex != -1)
				{
					for (int i = 0; i < this.trackingIntsMissed.Length; i++)
					{
						if (this.trackingIntsMissed[i].Value >= this.missedMax[i].Value)
						{
							flag2 = true;
							num = i;
						}
					}
					if (flag2)
					{
						flag = true;
						for (int j = 0; j < this.trackingInts.Length; j++)
						{
							this.trackingInts[j].Value = 0;
							this.trackingIntsMissed[j].Value++;
						}
						this.trackingIntsMissed[num].Value = 0;
						this.trackingInts[num].Value = 1;
						base.Fsm.Event(this.events[num]);
					}
					else if (this.trackingInts[randomWeightedIndex].Value < this.eventMax[randomWeightedIndex].Value)
					{
						int value = ++this.trackingInts[randomWeightedIndex].Value;
						for (int k = 0; k < this.trackingInts.Length; k++)
						{
							this.trackingInts[k].Value = 0;
							this.trackingIntsMissed[k].Value++;
						}
						this.trackingInts[randomWeightedIndex].Value = value;
						this.trackingIntsMissed[randomWeightedIndex].Value = 0;
						flag = true;
						base.Fsm.Event(this.events[randomWeightedIndex]);
					}
				}
				this.loops++;
				if (this.loops > 100)
				{
					base.Fsm.Event(this.events[0]);
					flag = true;
					base.Finish();
				}
			}
			base.Finish();
		}

		// Token: 0x04003B63 RID: 15203
		[CompoundArray("Events", "Event", "Weight")]
		public FsmEvent[] events;

		// Token: 0x04003B64 RID: 15204
		[HasFloatSlider(0f, 1f)]
		public FsmFloat[] weights;

		// Token: 0x04003B65 RID: 15205
		[UIHint(UIHint.Variable)]
		public FsmInt[] trackingInts;

		// Token: 0x04003B66 RID: 15206
		public FsmInt[] eventMax;

		// Token: 0x04003B67 RID: 15207
		[UIHint(UIHint.Variable)]
		public FsmInt[] trackingIntsMissed;

		// Token: 0x04003B68 RID: 15208
		public FsmInt[] missedMax;

		// Token: 0x04003B69 RID: 15209
		private int loops;

		// Token: 0x04003B6A RID: 15210
		private DelayedEvent delayedEvent;
	}
}
