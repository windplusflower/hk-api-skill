using System;
using HutongGames.PlayMaker;

// Token: 0x0200023E RID: 574
[ActionCategory("Hollow Knight/GG")]
public class GGCheckIfBossSequenceCompleted : FsmStateAction
{
	// Token: 0x06000C3C RID: 3132 RVA: 0x0003ECC8 File Offset: 0x0003CEC8
	public override void Reset()
	{
		this.completedEvent = null;
		this.notCompletedEvent = null;
	}

	// Token: 0x06000C3D RID: 3133 RVA: 0x0003ECD8 File Offset: 0x0003CED8
	public override void OnEnter()
	{
		if (BossSequenceController.WasCompleted)
		{
			base.Fsm.Event(this.completedEvent);
		}
		else
		{
			base.Fsm.Event(this.notCompletedEvent);
		}
		base.Finish();
	}

	// Token: 0x04000D07 RID: 3335
	public FsmEvent completedEvent;

	// Token: 0x04000D08 RID: 3336
	public FsmEvent notCompletedEvent;
}
