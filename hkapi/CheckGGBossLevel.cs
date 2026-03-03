using System;
using HutongGames.PlayMaker;

// Token: 0x0200022D RID: 557
[ActionCategory("Hollow Knight/GG")]
public class CheckGGBossLevel : FsmStateAction
{
	// Token: 0x06000BE3 RID: 3043 RVA: 0x0003DB3F File Offset: 0x0003BD3F
	public override void Reset()
	{
		this.notGG = null;
		this.level1 = null;
		this.level2 = null;
		this.level3 = null;
	}

	// Token: 0x06000BE4 RID: 3044 RVA: 0x0003DB60 File Offset: 0x0003BD60
	public override void OnEnter()
	{
		if (BossSceneController.Instance)
		{
			switch (BossSceneController.Instance.BossLevel)
			{
			case 0:
				base.Fsm.Event(this.level1);
				break;
			case 1:
				base.Fsm.Event(this.level2);
				break;
			case 2:
				base.Fsm.Event(this.level3);
				break;
			}
		}
		else
		{
			base.Fsm.Event(this.notGG);
		}
		base.Finish();
	}

	// Token: 0x04000CD1 RID: 3281
	public FsmEvent notGG;

	// Token: 0x04000CD2 RID: 3282
	public FsmEvent level1;

	// Token: 0x04000CD3 RID: 3283
	public FsmEvent level2;

	// Token: 0x04000CD4 RID: 3284
	public FsmEvent level3;
}
