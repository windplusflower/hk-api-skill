using System;
using HutongGames.PlayMaker;

// Token: 0x0200030B RID: 779
[ActionCategory("Hollow Knight")]
public class WaitForFinishedEnteringScene : FsmStateAction
{
	// Token: 0x06001123 RID: 4387 RVA: 0x00050C9D File Offset: 0x0004EE9D
	public override void Reset()
	{
		this.sendEvent = null;
	}

	// Token: 0x06001124 RID: 4388 RVA: 0x00050CA8 File Offset: 0x0004EEA8
	public override void OnEnter()
	{
		if (!GameManager.instance)
		{
			base.Finish();
			return;
		}
		if (!GameManager.instance.HasFinishedEnteringScene)
		{
			GameManager.EnterSceneEvent temp = null;
			temp = delegate()
			{
				this.Fsm.Event(this.sendEvent);
				GameManager.instance.OnFinishedEnteringScene -= temp;
				this.Finish();
			};
			GameManager.instance.OnFinishedEnteringScene += temp;
			return;
		}
		base.Fsm.Event(this.sendEvent);
	}

	// Token: 0x040010E3 RID: 4323
	[RequiredField]
	public FsmEvent sendEvent;
}
