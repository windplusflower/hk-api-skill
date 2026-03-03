using System;
using HutongGames.PlayMaker;

// Token: 0x02000247 RID: 583
[ActionCategory("Hollow Knight/GG")]
public class GGResetBossSequenceController : FsmStateAction
{
	// Token: 0x06000C4F RID: 3151 RVA: 0x0003EDCE File Offset: 0x0003CFCE
	public override void OnEnter()
	{
		BossSequenceController.Reset();
		base.Finish();
	}
}
