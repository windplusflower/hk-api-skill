using System;
using HutongGames.PlayMaker;

// Token: 0x02000241 RID: 577
[ActionCategory("Hollow Knight/GG")]
public class GGCheckIfBossSequence : FSMUtility.CheckFsmStateAction
{
	// Token: 0x17000151 RID: 337
	// (get) Token: 0x06000C43 RID: 3139 RVA: 0x0003ED26 File Offset: 0x0003CF26
	public override bool IsTrue
	{
		get
		{
			return BossSequenceController.IsInSequence;
		}
	}
}
