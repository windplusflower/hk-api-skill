using System;
using HutongGames.PlayMaker;

// Token: 0x02000309 RID: 777
[ActionCategory("Hollow Knight")]
public class WaitForBossLoad : FsmStateAction
{
	// Token: 0x0600111E RID: 4382 RVA: 0x00050BFC File Offset: 0x0004EDFC
	public override void Reset()
	{
		this.sendEvent = null;
	}

	// Token: 0x0600111F RID: 4383 RVA: 0x00050C08 File Offset: 0x0004EE08
	public override void OnEnter()
	{
		if (GameManager.instance && SceneAdditiveLoadConditional.ShouldLoadBoss)
		{
			GameManager.BossLoad temp = null;
			temp = delegate()
			{
				this.Fsm.Event(this.sendEvent);
				GameManager.instance.OnLoadedBoss -= temp;
				this.Finish();
			};
			GameManager.instance.OnLoadedBoss += temp;
			return;
		}
		base.Finish();
	}

	// Token: 0x040010E0 RID: 4320
	[RequiredField]
	public FsmEvent sendEvent;
}
