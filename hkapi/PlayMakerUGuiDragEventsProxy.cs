using System;
using HutongGames.PlayMaker.Actions;
using HutongGames.PlayMaker.Ecosystem.Utils;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000047 RID: 71
public class PlayMakerUGuiDragEventsProxy : MonoBehaviour, IDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler
{
	// Token: 0x06000185 RID: 389 RVA: 0x0000A938 File Offset: 0x00008B38
	public void OnBeginDrag(PointerEventData data)
	{
		if (this.debug)
		{
			Debug.Log("OnBeginDrag " + data.pointerId.ToString() + " on " + base.gameObject.name);
		}
		GetLastPointerDataInfo.lastPointeEventData = data;
		this.onBeginDragEvent.SendEvent(PlayMakerUGuiSceneProxy.fsm, this.eventTarget);
	}

	// Token: 0x06000186 RID: 390 RVA: 0x0000A998 File Offset: 0x00008B98
	public void OnDrag(PointerEventData data)
	{
		if (this.debug)
		{
			Debug.Log("OnDrag " + data.pointerId.ToString() + " on " + base.gameObject.name);
		}
		GetLastPointerDataInfo.lastPointeEventData = data;
		this.onDragEvent.SendEvent(PlayMakerUGuiSceneProxy.fsm, this.eventTarget);
	}

	// Token: 0x06000187 RID: 391 RVA: 0x0000A9F8 File Offset: 0x00008BF8
	public void OnEndDrag(PointerEventData data)
	{
		if (this.debug)
		{
			Debug.Log("OnEndDrag " + data.pointerId.ToString() + " on " + base.gameObject.name);
		}
		GetLastPointerDataInfo.lastPointeEventData = data;
		this.onEndDragEvent.SendEvent(PlayMakerUGuiSceneProxy.fsm, this.eventTarget);
	}

	// Token: 0x06000188 RID: 392 RVA: 0x0000AA58 File Offset: 0x00008C58
	public PlayMakerUGuiDragEventsProxy()
	{
		this.eventTarget = new PlayMakerEventTarget(true);
		this.onBeginDragEvent = new PlayMakerEvent("UGUI / ON BEGIN DRAG");
		this.onDragEvent = new PlayMakerEvent("UGUI / ON DRAG");
		this.onEndDragEvent = new PlayMakerEvent("UGUI / ON END DRAG");
		base..ctor();
	}

	// Token: 0x04000128 RID: 296
	public bool debug;

	// Token: 0x04000129 RID: 297
	public PlayMakerEventTarget eventTarget;

	// Token: 0x0400012A RID: 298
	[EventTargetVariable("eventTarget")]
	[ShowOptions]
	public PlayMakerEvent onBeginDragEvent;

	// Token: 0x0400012B RID: 299
	[EventTargetVariable("eventTarget")]
	[ShowOptions]
	public PlayMakerEvent onDragEvent;

	// Token: 0x0400012C RID: 300
	[EventTargetVariable("eventTarget")]
	[ShowOptions]
	public PlayMakerEvent onEndDragEvent;
}
