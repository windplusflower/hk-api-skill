using System;
using HutongGames.PlayMaker;

// Token: 0x02000310 RID: 784
[ActionCategory("Hollow Knight")]
public class CheckSceneName : FsmStateAction
{
	// Token: 0x06001131 RID: 4401 RVA: 0x00050E33 File Offset: 0x0004F033
	public override void Reset()
	{
		this.sceneName = null;
		this.equalEvent = null;
		this.notEqualEvent = null;
	}

	// Token: 0x06001132 RID: 4402 RVA: 0x00050E4C File Offset: 0x0004F04C
	public override void OnEnter()
	{
		if (GameManager.instance)
		{
			if (this.sceneName.Value == GameManager.instance.GetSceneNameString())
			{
				base.Fsm.Event(this.equalEvent);
			}
			else
			{
				base.Fsm.Event(this.notEqualEvent);
			}
		}
		base.Finish();
	}

	// Token: 0x040010EB RID: 4331
	[RequiredField]
	public FsmString sceneName;

	// Token: 0x040010EC RID: 4332
	public FsmEvent equalEvent;

	// Token: 0x040010ED RID: 4333
	public FsmEvent notEqualEvent;
}
