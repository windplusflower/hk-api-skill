using System;
using HutongGames.PlayMaker;

// Token: 0x02000248 RID: 584
[ActionCategory("Hollow Knight/GG")]
public class GGCheckIsBossRushMode : FSMUtility.CheckFsmStateAction
{
	// Token: 0x17000156 RID: 342
	// (get) Token: 0x06000C51 RID: 3153 RVA: 0x0003EDDB File Offset: 0x0003CFDB
	public override bool IsTrue
	{
		get
		{
			return GameManager.instance.playerData.GetBool("bossRushMode");
		}
	}
}
