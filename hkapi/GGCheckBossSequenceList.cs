using System;
using HutongGames.PlayMaker;

// Token: 0x02000242 RID: 578
[ActionCategory("Hollow Knight/GG")]
public class GGCheckBossSequenceList : FSMUtility.CheckFsmStateAction
{
	// Token: 0x06000C45 RID: 3141 RVA: 0x0003ED2D File Offset: 0x0003CF2D
	public override void Reset()
	{
		this.tierList = null;
		base.Reset();
	}

	// Token: 0x17000152 RID: 338
	// (get) Token: 0x06000C46 RID: 3142 RVA: 0x0003ED3C File Offset: 0x0003CF3C
	public override bool IsTrue
	{
		get
		{
			return BossSequenceController.CheckIfSequence((BossSequence)this.tierList.Value);
		}
	}

	// Token: 0x04000D09 RID: 3337
	[ObjectType(typeof(BossSequence))]
	public FsmObject tierList;
}
