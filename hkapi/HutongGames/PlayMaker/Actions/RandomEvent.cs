using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C6A RID: 3178
	[ActionCategory(ActionCategory.StateMachine)]
	[Tooltip("Sends a Random State Event after an optional delay. Use this to transition to a random state from the current state.")]
	public class RandomEvent : FsmStateAction
	{
		// Token: 0x06004277 RID: 17015 RVA: 0x0016FE69 File Offset: 0x0016E069
		public override void Reset()
		{
			this.delay = null;
		}

		// Token: 0x06004278 RID: 17016 RVA: 0x0016FE74 File Offset: 0x0016E074
		public override void OnEnter()
		{
			if (base.State.Transitions.Length == 0)
			{
				return;
			}
			if (this.lastEventIndex == -1)
			{
				this.lastEventIndex = UnityEngine.Random.Range(0, base.State.Transitions.Length);
			}
			if (this.delay.Value < 0.001f)
			{
				base.Fsm.Event(this.GetRandomEvent());
				base.Finish();
				return;
			}
			this.delayedEvent = base.Fsm.DelayedEvent(this.GetRandomEvent(), this.delay.Value);
		}

		// Token: 0x06004279 RID: 17017 RVA: 0x0016FEFE File Offset: 0x0016E0FE
		public override void OnUpdate()
		{
			if (DelayedEvent.WasSent(this.delayedEvent))
			{
				base.Finish();
			}
		}

		// Token: 0x0600427A RID: 17018 RVA: 0x0016FF14 File Offset: 0x0016E114
		private FsmEvent GetRandomEvent()
		{
			do
			{
				this.randomEventIndex = UnityEngine.Random.Range(0, base.State.Transitions.Length);
			}
			while (this.noRepeat.Value && base.State.Transitions.Length > 1 && this.randomEventIndex == this.lastEventIndex);
			this.lastEventIndex = this.randomEventIndex;
			return base.State.Transitions[this.randomEventIndex].FsmEvent;
		}

		// Token: 0x0600427B RID: 17019 RVA: 0x0016FF88 File Offset: 0x0016E188
		public RandomEvent()
		{
			this.lastEventIndex = -1;
			base..ctor();
		}

		// Token: 0x040046BB RID: 18107
		[HasFloatSlider(0f, 10f)]
		[Tooltip("Delay before sending the event.")]
		public FsmFloat delay;

		// Token: 0x040046BC RID: 18108
		[Tooltip("Don't repeat the same event twice in a row.")]
		public FsmBool noRepeat;

		// Token: 0x040046BD RID: 18109
		private DelayedEvent delayedEvent;

		// Token: 0x040046BE RID: 18110
		private int randomEventIndex;

		// Token: 0x040046BF RID: 18111
		private int lastEventIndex;
	}
}
