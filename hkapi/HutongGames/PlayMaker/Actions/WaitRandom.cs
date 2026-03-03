using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A75 RID: 2677
	[ActionCategory(ActionCategory.Time)]
	[Tooltip("Delays a State from finishing by the specified time. NOTE: Other actions continue, but FINISHED can't happen before Time.")]
	public class WaitRandom : FsmStateAction
	{
		// Token: 0x060039B6 RID: 14774 RVA: 0x00150F4D File Offset: 0x0014F14D
		public override void Reset()
		{
			this.timeMin = 0f;
			this.timeMax = 1f;
			this.finishEvent = null;
			this.realTime = false;
		}

		// Token: 0x060039B7 RID: 14775 RVA: 0x00150F80 File Offset: 0x0014F180
		public override void OnEnter()
		{
			this.time = UnityEngine.Random.Range(this.timeMin.Value, this.timeMax.Value);
			if (this.time <= 0f)
			{
				base.Fsm.Event(this.finishEvent);
				base.Finish();
				return;
			}
			this.startTime = FsmTime.RealtimeSinceStartup;
			this.timer = 0f;
		}

		// Token: 0x060039B8 RID: 14776 RVA: 0x00150FEC File Offset: 0x0014F1EC
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

		// Token: 0x04003CC3 RID: 15555
		[RequiredField]
		public FsmFloat timeMin;

		// Token: 0x04003CC4 RID: 15556
		public FsmFloat timeMax;

		// Token: 0x04003CC5 RID: 15557
		public FsmEvent finishEvent;

		// Token: 0x04003CC6 RID: 15558
		public bool realTime;

		// Token: 0x04003CC7 RID: 15559
		private float time;

		// Token: 0x04003CC8 RID: 15560
		private float startTime;

		// Token: 0x04003CC9 RID: 15561
		private float timer;
	}
}
