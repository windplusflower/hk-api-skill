using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D22 RID: 3362
	[ActionCategory(ActionCategory.Time)]
	[Tooltip("Delays a State from finishing by the specified time. NOTE: Other actions continue, but FINISHED can't happen before Time.")]
	public class Wait : FsmStateAction
	{
		// Token: 0x060045A4 RID: 17828 RVA: 0x00179B89 File Offset: 0x00177D89
		public override void Reset()
		{
			this.time = 1f;
			this.finishEvent = null;
			this.realTime = false;
		}

		// Token: 0x060045A5 RID: 17829 RVA: 0x00179BAC File Offset: 0x00177DAC
		public override void OnEnter()
		{
			if (this.time.Value <= 0f)
			{
				base.Fsm.Event(this.finishEvent);
				base.Finish();
				return;
			}
			this.startTime = FsmTime.RealtimeSinceStartup;
			this.timer = 0f;
		}

		// Token: 0x060045A6 RID: 17830 RVA: 0x00179BFC File Offset: 0x00177DFC
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
			if (this.timer >= this.time.Value)
			{
				base.Finish();
				if (this.finishEvent != null)
				{
					base.Fsm.Event(this.finishEvent);
				}
			}
		}

		// Token: 0x04004A0F RID: 18959
		[RequiredField]
		public FsmFloat time;

		// Token: 0x04004A10 RID: 18960
		public FsmEvent finishEvent;

		// Token: 0x04004A11 RID: 18961
		public bool realTime;

		// Token: 0x04004A12 RID: 18962
		private float startTime;

		// Token: 0x04004A13 RID: 18963
		private float timer;
	}
}
