using System;
using HutongGames.PlayMaker;

// Token: 0x02000243 RID: 579
[ActionCategory("Hollow Knight/GG")]
public class GGCheckBoundHeart : FSMUtility.CheckFsmStateAction
{
	// Token: 0x06000C48 RID: 3144 RVA: 0x0003ED53 File Offset: 0x0003CF53
	public override void Reset()
	{
		this.healthNumber = null;
		this.checkSource = GGCheckBoundHeart.CheckSource.Regular;
		base.Reset();
	}

	// Token: 0x17000153 RID: 339
	// (get) Token: 0x06000C49 RID: 3145 RVA: 0x0003ED6C File Offset: 0x0003CF6C
	public override bool IsTrue
	{
		get
		{
			int num = -1;
			GGCheckBoundHeart.CheckSource checkSource = this.checkSource;
			if (checkSource != GGCheckBoundHeart.CheckSource.Regular)
			{
				if (checkSource == GGCheckBoundHeart.CheckSource.Joni)
				{
					num = (int)((float)this.healthNumber.Value * 0.71428573f) + 1;
				}
			}
			else
			{
				num = this.healthNumber.Value;
			}
			return BossSequenceController.BoundShell && num > BossSequenceController.BoundMaxHealth;
		}
	}

	// Token: 0x04000D0A RID: 3338
	public FsmInt healthNumber;

	// Token: 0x04000D0B RID: 3339
	public GGCheckBoundHeart.CheckSource checkSource;

	// Token: 0x02000244 RID: 580
	public enum CheckSource
	{
		// Token: 0x04000D0D RID: 3341
		Regular,
		// Token: 0x04000D0E RID: 3342
		Joni
	}
}
