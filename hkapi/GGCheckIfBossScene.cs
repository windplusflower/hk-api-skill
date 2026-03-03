using System;
using HutongGames.PlayMaker;

// Token: 0x0200022E RID: 558
[ActionCategory("Hollow Knight/GG")]
public class GGCheckIfBossScene : FsmStateAction
{
	// Token: 0x06000BE6 RID: 3046 RVA: 0x0003DBE8 File Offset: 0x0003BDE8
	public override void Reset()
	{
		this.bossSceneEvent = null;
		this.regularSceneEvent = null;
	}

	// Token: 0x06000BE7 RID: 3047 RVA: 0x0003DBF8 File Offset: 0x0003BDF8
	public override void OnEnter()
	{
		if (BossSceneController.IsBossScene)
		{
			base.Fsm.Event(this.bossSceneEvent);
		}
		else
		{
			base.Fsm.Event(this.regularSceneEvent);
		}
		base.Finish();
	}

	// Token: 0x04000CD5 RID: 3285
	public FsmEvent bossSceneEvent;

	// Token: 0x04000CD6 RID: 3286
	public FsmEvent regularSceneEvent;
}
