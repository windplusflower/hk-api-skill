using System;
using HutongGames.PlayMaker;

// Token: 0x0200030F RID: 783
[ActionCategory("Hollow Knight")]
public class CheckCurrentMapZone : FsmStateAction
{
	// Token: 0x0600112E RID: 4398 RVA: 0x00050DBC File Offset: 0x0004EFBC
	public override void Reset()
	{
		this.mapZone = null;
		this.equalEvent = null;
		this.notEqualEvent = null;
	}

	// Token: 0x0600112F RID: 4399 RVA: 0x00050DD4 File Offset: 0x0004EFD4
	public override void OnEnter()
	{
		if (GameManager.instance)
		{
			if (this.mapZone.Value == GameManager.instance.GetCurrentMapZone())
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

	// Token: 0x040010E8 RID: 4328
	[RequiredField]
	public FsmString mapZone;

	// Token: 0x040010E9 RID: 4329
	public FsmEvent equalEvent;

	// Token: 0x040010EA RID: 4330
	public FsmEvent notEqualEvent;
}
