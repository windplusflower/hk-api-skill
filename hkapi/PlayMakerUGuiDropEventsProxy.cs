using System;
using HutongGames.PlayMaker.Actions;
using HutongGames.PlayMaker.Ecosystem.Utils;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000048 RID: 72
public class PlayMakerUGuiDropEventsProxy : MonoBehaviour, IDropHandler, IEventSystemHandler
{
	// Token: 0x06000189 RID: 393 RVA: 0x0000AAA8 File Offset: 0x00008CA8
	public void OnDrop(PointerEventData data)
	{
		if (this.debug)
		{
			Debug.Log("OnDrop " + data.pointerId.ToString() + " on " + base.gameObject.name);
		}
		GetLastPointerDataInfo.lastPointeEventData = data;
		this.onDropEvent.SendEvent(PlayMakerUGuiSceneProxy.fsm, this.eventTarget);
	}

	// Token: 0x0600018A RID: 394 RVA: 0x0000AB07 File Offset: 0x00008D07
	public PlayMakerUGuiDropEventsProxy()
	{
		this.eventTarget = new PlayMakerEventTarget(true);
		this.onDropEvent = new PlayMakerEvent("UGUI / ON DROP");
		base..ctor();
	}

	// Token: 0x0400012D RID: 301
	public bool debug;

	// Token: 0x0400012E RID: 302
	public PlayMakerEventTarget eventTarget;

	// Token: 0x0400012F RID: 303
	[EventTargetVariable("eventTarget")]
	[ShowOptions]
	public PlayMakerEvent onDropEvent;
}
