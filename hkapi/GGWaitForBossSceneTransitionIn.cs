using System;
using HutongGames.PlayMaker;

// Token: 0x02000230 RID: 560
[ActionCategory("Hollow Knight/GG")]
public class GGWaitForBossSceneTransitionIn : FsmStateAction
{
	// Token: 0x06000BEB RID: 3051 RVA: 0x0003DC4C File Offset: 0x0003BE4C
	public override void Reset()
	{
		this.finishEvent = null;
	}

	// Token: 0x06000BEC RID: 3052 RVA: 0x0003DC55 File Offset: 0x0003BE55
	public override void OnEnter()
	{
		this.DoCheck();
	}

	// Token: 0x06000BED RID: 3053 RVA: 0x0003DC55 File Offset: 0x0003BE55
	public override void OnUpdate()
	{
		this.DoCheck();
	}

	// Token: 0x06000BEE RID: 3054 RVA: 0x0003DC5D File Offset: 0x0003BE5D
	private void DoCheck()
	{
		if (BossSceneController.Instance)
		{
			if (BossSceneController.Instance.HasTransitionedIn)
			{
				base.Fsm.Event(this.finishEvent);
				return;
			}
		}
		else
		{
			base.Fsm.Event(this.finishEvent);
		}
	}

	// Token: 0x04000CD7 RID: 3287
	public FsmEvent finishEvent;
}
