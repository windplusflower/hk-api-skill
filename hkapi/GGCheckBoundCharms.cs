using System;
using HutongGames.PlayMaker;

// Token: 0x02000246 RID: 582
[ActionCategory("Hollow Knight/GG")]
public class GGCheckBoundCharms : FSMUtility.CheckFsmStateAction
{
	// Token: 0x17000155 RID: 341
	// (get) Token: 0x06000C4D RID: 3149 RVA: 0x0003EDC7 File Offset: 0x0003CFC7
	public override bool IsTrue
	{
		get
		{
			return BossSequenceController.BoundCharms;
		}
	}
}
