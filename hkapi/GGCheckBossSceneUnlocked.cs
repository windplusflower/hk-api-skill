using System;
using HutongGames.PlayMaker;

// Token: 0x02000225 RID: 549
[ActionCategory("Hollow Knight")]
public class GGCheckBossSceneUnlocked : FSMUtility.CheckFsmStateAction
{
	// Token: 0x06000BAB RID: 2987 RVA: 0x0003D3C4 File Offset: 0x0003B5C4
	public override void Reset()
	{
		base.Reset();
		this.bossScene = null;
	}

	// Token: 0x1700012B RID: 299
	// (get) Token: 0x06000BAC RID: 2988 RVA: 0x0003D3D3 File Offset: 0x0003B5D3
	public override bool IsTrue
	{
		get
		{
			return !this.bossScene.IsNone && ((BossScene)this.bossScene.Value).IsUnlocked(this.checkSource);
		}
	}

	// Token: 0x04000CAC RID: 3244
	[ObjectType(typeof(BossScene))]
	public FsmObject bossScene;

	// Token: 0x04000CAD RID: 3245
	public BossSceneCheckSource checkSource;
}
