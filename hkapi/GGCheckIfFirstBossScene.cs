using System;
using HutongGames.PlayMaker;

// Token: 0x0200023F RID: 575
[ActionCategory("Hollow Knight/GG")]
public class GGCheckIfFirstBossScene : FSMUtility.CheckFsmStateAction
{
	// Token: 0x1700014F RID: 335
	// (get) Token: 0x06000C3F RID: 3135 RVA: 0x0003ED0B File Offset: 0x0003CF0B
	public override bool IsTrue
	{
		get
		{
			return BossSequenceController.BossIndex < 1;
		}
	}
}
