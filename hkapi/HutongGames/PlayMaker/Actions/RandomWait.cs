using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C6E RID: 3182
	[ActionCategory(ActionCategory.Time)]
	[Tooltip("Delays a State from finishing by a random time. NOTE: Other actions continue, but FINISHED can't happen before Time.")]
	public class RandomWait : FsmStateAction
	{
		// Token: 0x06004285 RID: 17029 RVA: 0x001700F0 File Offset: 0x0016E2F0
		public override void Reset()
		{
			this.min = 0f;
			this.max = 1f;
			this.finishEvent = null;
			this.realTime = false;
		}

		// Token: 0x06004286 RID: 17030 RVA: 0x00170120 File Offset: 0x0016E320
		public override void OnEnter()
		{
			this.time = UnityEngine.Random.Range(this.min.Value, this.max.Value);
			if (this.time <= 0f)
			{
				base.Fsm.Event(this.finishEvent);
				base.Finish();
				return;
			}
			this.startTime = FsmTime.RealtimeSinceStartup;
			this.timer = 0f;
		}

		// Token: 0x06004287 RID: 17031 RVA: 0x0017018C File Offset: 0x0016E38C
		public override void OnUpdate()
		{
			if (this.realTime)
			{
				this.timer = FsmTime.RealtimeSinceStartup - this.startTime;
			}
			else
			{
				this.timer += Time.deltaTime;
			}
			if (this.timer >= this.time)
			{
				base.Finish();
				if (this.finishEvent != null)
				{
					base.Fsm.Event(this.finishEvent);
				}
			}
		}

		// Token: 0x040046CA RID: 18122
		[RequiredField]
		[Tooltip("Minimum amount of time to wait.")]
		public FsmFloat min;

		// Token: 0x040046CB RID: 18123
		[RequiredField]
		[Tooltip("Maximum amount of time to wait.")]
		public FsmFloat max;

		// Token: 0x040046CC RID: 18124
		[Tooltip("Event to send when timer is finished.")]
		public FsmEvent finishEvent;

		// Token: 0x040046CD RID: 18125
		[Tooltip("Ignore time scale.")]
		public bool realTime;

		// Token: 0x040046CE RID: 18126
		private float startTime;

		// Token: 0x040046CF RID: 18127
		private float timer;

		// Token: 0x040046D0 RID: 18128
		private float time;
	}
}
