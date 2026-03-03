using System;
using HutongGames.PlayMaker;

// Token: 0x02000312 RID: 786
[ActionCategory("Hollow Knight")]
public class WaitForSceneLoadFinish : FsmStateAction
{
	// Token: 0x06001136 RID: 4406 RVA: 0x00050EC9 File Offset: 0x0004F0C9
	public override void Reset()
	{
		this.sendEvent = null;
	}

	// Token: 0x06001137 RID: 4407 RVA: 0x00050ED4 File Offset: 0x0004F0D4
	public override void OnEnter()
	{
		if (GameManager.instance && GameManager.instance.IsInSceneTransition)
		{
			GameManager.SceneTransitionFinishEvent temp = null;
			temp = delegate()
			{
				this.Fsm.Event(this.sendEvent);
				GameManager.instance.OnFinishedSceneTransition -= temp;
				this.Finish();
			};
			GameManager.instance.OnFinishedSceneTransition += temp;
			return;
		}
		base.Finish();
	}

	// Token: 0x040010EE RID: 4334
	[RequiredField]
	public FsmEvent sendEvent;
}
