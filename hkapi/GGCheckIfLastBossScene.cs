using System;
using HutongGames.PlayMaker;

// Token: 0x02000240 RID: 576
[ActionCategory("Hollow Knight/GG")]
public class GGCheckIfLastBossScene : FSMUtility.CheckFsmStateAction
{
	// Token: 0x17000150 RID: 336
	// (get) Token: 0x06000C41 RID: 3137 RVA: 0x0003ED15 File Offset: 0x0003CF15
	public override bool IsTrue
	{
		get
		{
			return BossSequenceController.BossIndex >= BossSequenceController.BossCount;
		}
	}
}
