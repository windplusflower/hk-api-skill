using System;
using HutongGames.PlayMaker;

// Token: 0x02000245 RID: 581
[ActionCategory("Hollow Knight/GG")]
public class GGCheckBoundNail : FSMUtility.CheckFsmStateAction
{
	// Token: 0x17000154 RID: 340
	// (get) Token: 0x06000C4B RID: 3147 RVA: 0x0003EDC0 File Offset: 0x0003CFC0
	public override bool IsTrue
	{
		get
		{
			return BossSequenceController.BoundNail;
		}
	}
}
