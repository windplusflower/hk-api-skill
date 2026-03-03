using System;
using System.Collections.Generic;
using HutongGames.PlayMaker;

// Token: 0x0200029C RID: 668
[ActionCategory("Hollow Knight")]
public class ShowGodfinderIcon : FsmStateAction
{
	// Token: 0x06000E04 RID: 3588 RVA: 0x00045018 File Offset: 0x00043218
	public override void Reset()
	{
		this.delay = null;
	}

	// Token: 0x06000E05 RID: 3589 RVA: 0x00045024 File Offset: 0x00043224
	public override void OnEnter()
	{
		GodfinderIcon.ShowIcon(this.delay.Value, this.unlockBossScene.Value as BossScene);
		if (this.unlockBossScene.Value && !GameManager.instance.playerData.GetVariable<List<string>>("unlockedBossScenes").Contains(this.unlockBossScene.Value.name))
		{
			GameManager.instance.playerData.GetVariable<List<string>>("unlockedBossScenes").Add(this.unlockBossScene.Value.name);
		}
		base.Finish();
	}

	// Token: 0x04000EDB RID: 3803
	public FsmFloat delay;

	// Token: 0x04000EDC RID: 3804
	[ObjectType(typeof(BossScene))]
	public FsmObject unlockBossScene;
}
