using System;
using HutongGames.PlayMaker;

// Token: 0x0200022C RID: 556
[ActionCategory("Hollow Knight/GG")]
public class EndGGBossScene : FsmStateAction
{
	// Token: 0x06000BE1 RID: 3041 RVA: 0x0003DB21 File Offset: 0x0003BD21
	public override void OnEnter()
	{
		if (BossSceneController.Instance)
		{
			BossSceneController.Instance.EndBossScene();
		}
		base.Finish();
	}
}
