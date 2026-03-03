using System;
using HutongGames.PlayMaker;

// Token: 0x020002C5 RID: 709
public class CheckSendEventLimit : FsmStateAction
{
	// Token: 0x06000EF9 RID: 3833 RVA: 0x00049CD1 File Offset: 0x00047ED1
	public override void Reset()
	{
		this.gameObject = new FsmGameObject();
		this.target = new FsmEventTarget();
		this.trueEvent = null;
		this.falseEvent = null;
	}

	// Token: 0x06000EFA RID: 3834 RVA: 0x00049CF8 File Offset: 0x00047EF8
	public override void OnEnter()
	{
		if (this.gameObject.Value)
		{
			LimitSendEvents component = base.Owner.gameObject.GetComponent<LimitSendEvents>();
			if (component && !component.Add(this.gameObject.Value))
			{
				base.Fsm.Event(this.target, this.falseEvent);
			}
			else
			{
				base.Fsm.Event(this.target, this.trueEvent);
			}
		}
		base.Finish();
	}

	// Token: 0x04000FB5 RID: 4021
	public FsmGameObject gameObject;

	// Token: 0x04000FB6 RID: 4022
	public FsmEventTarget target;

	// Token: 0x04000FB7 RID: 4023
	public FsmEvent trueEvent;

	// Token: 0x04000FB8 RID: 4024
	public FsmEvent falseEvent;
}
