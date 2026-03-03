using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A2E RID: 2606
	[ActionCategory("System")]
	[Tooltip("Tell the Garbage Collector to run.")]
	public class RunGarbageCollector : FsmStateAction
	{
		// Token: 0x06003898 RID: 14488 RVA: 0x0014B493 File Offset: 0x00149693
		public override void Reset()
		{
			this.finishEvent = null;
		}

		// Token: 0x06003899 RID: 14489 RVA: 0x0014B49C File Offset: 0x0014969C
		public override void OnEnter()
		{
			GC.Collect();
			base.Finish();
			if (this.finishEvent != null)
			{
				base.Fsm.Event(this.finishEvent);
			}
		}

		// Token: 0x04003B41 RID: 15169
		public FsmEvent finishEvent;
	}
}
