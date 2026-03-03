using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x02000427 RID: 1063
[ActionCategory("Hollow Knight")]
public class TriggerEnterEventSubscribe : FsmStateAction
{
	// Token: 0x060017F9 RID: 6137 RVA: 0x00070DA3 File Offset: 0x0006EFA3
	public override void Reset()
	{
		this.triggerEnteredEvent = null;
		this.triggerExitedEvent = null;
		this.triggerStayedEvent = null;
	}

	// Token: 0x060017FA RID: 6138 RVA: 0x00070DBC File Offset: 0x0006EFBC
	public override void OnEnter()
	{
		if (!this.trigger.IsNone)
		{
			TriggerEnterEvent triggerEnterEvent = (TriggerEnterEvent)this.trigger.Value;
			triggerEnterEvent.OnTriggerEntered += this.SendEnteredEvent;
			triggerEnterEvent.OnTriggerExited += this.SendExitedEvent;
			triggerEnterEvent.OnTriggerStayed += this.SendStayedEvent;
		}
		base.Finish();
	}

	// Token: 0x060017FB RID: 6139 RVA: 0x00070E24 File Offset: 0x0006F024
	public override void OnExit()
	{
		if (!this.trigger.IsNone)
		{
			TriggerEnterEvent triggerEnterEvent = (TriggerEnterEvent)this.trigger.Value;
			triggerEnterEvent.OnTriggerEntered -= this.SendEnteredEvent;
			triggerEnterEvent.OnTriggerExited -= this.SendExitedEvent;
			triggerEnterEvent.OnTriggerStayed -= this.SendStayedEvent;
		}
	}

	// Token: 0x060017FC RID: 6140 RVA: 0x00070E83 File Offset: 0x0006F083
	private void SendEnteredEvent(Collider2D collider, GameObject sender)
	{
		base.Fsm.Event(this.triggerEnteredEvent);
	}

	// Token: 0x060017FD RID: 6141 RVA: 0x00070E96 File Offset: 0x0006F096
	private void SendExitedEvent(Collider2D collider, GameObject sender)
	{
		base.Fsm.Event(this.triggerExitedEvent);
	}

	// Token: 0x060017FE RID: 6142 RVA: 0x00070EA9 File Offset: 0x0006F0A9
	private void SendStayedEvent(Collider2D collider, GameObject sender)
	{
		base.Fsm.Event(this.triggerStayedEvent);
	}

	// Token: 0x04001CC1 RID: 7361
	[ObjectType(typeof(TriggerEnterEvent))]
	public FsmObject trigger;

	// Token: 0x04001CC2 RID: 7362
	public FsmEvent triggerEnteredEvent;

	// Token: 0x04001CC3 RID: 7363
	public FsmEvent triggerExitedEvent;

	// Token: 0x04001CC4 RID: 7364
	public FsmEvent triggerStayedEvent;
}
