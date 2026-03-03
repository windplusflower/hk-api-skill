using System;
using HutongGames.PlayMaker.Actions;
using HutongGames.PlayMaker.Ecosystem.Utils;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000049 RID: 73
public class PlayMakerUGuiPointerEventsProxy : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler, IPointerUpHandler
{
	// Token: 0x0600018B RID: 395 RVA: 0x0000AB2C File Offset: 0x00008D2C
	public void OnPointerClick(PointerEventData data)
	{
		if (this.debug)
		{
			Debug.Log("OnPointerClick " + data.pointerId.ToString() + " on " + base.gameObject.name);
		}
		GetLastPointerDataInfo.lastPointeEventData = data;
		this.onClickEvent.SendEvent(PlayMakerUGuiSceneProxy.fsm, this.eventTarget);
	}

	// Token: 0x0600018C RID: 396 RVA: 0x0000AB8C File Offset: 0x00008D8C
	public void OnPointerDown(PointerEventData data)
	{
		if (this.debug)
		{
			Debug.Log("OnPointerDown " + data.pointerId.ToString() + " on " + base.gameObject.name);
		}
		GetLastPointerDataInfo.lastPointeEventData = data;
		this.onDownEvent.SendEvent(PlayMakerUGuiSceneProxy.fsm, this.eventTarget);
	}

	// Token: 0x0600018D RID: 397 RVA: 0x0000ABEC File Offset: 0x00008DEC
	public void OnPointerEnter(PointerEventData data)
	{
		if (this.debug)
		{
			Debug.Log("OnPointerEnter " + data.pointerId.ToString() + " on " + base.gameObject.name);
		}
		GetLastPointerDataInfo.lastPointeEventData = data;
		this.onEnterEvent.SendEvent(PlayMakerUGuiSceneProxy.fsm, this.eventTarget);
	}

	// Token: 0x0600018E RID: 398 RVA: 0x0000AC4C File Offset: 0x00008E4C
	public void OnPointerExit(PointerEventData data)
	{
		if (this.debug)
		{
			Debug.Log("OnPointerExit " + data.pointerId.ToString() + " on " + base.gameObject.name);
		}
		GetLastPointerDataInfo.lastPointeEventData = data;
		this.onExitEvent.SendEvent(PlayMakerUGuiSceneProxy.fsm, this.eventTarget);
	}

	// Token: 0x0600018F RID: 399 RVA: 0x0000ACAC File Offset: 0x00008EAC
	public void OnPointerUp(PointerEventData data)
	{
		if (this.debug)
		{
			Debug.Log("OnPointerUp " + data.pointerId.ToString() + " on " + base.gameObject.name);
		}
		GetLastPointerDataInfo.lastPointeEventData = data;
		this.onUpEvent.SendEvent(PlayMakerUGuiSceneProxy.fsm, this.eventTarget);
	}

	// Token: 0x06000190 RID: 400 RVA: 0x0000AD0C File Offset: 0x00008F0C
	public PlayMakerUGuiPointerEventsProxy()
	{
		this.onClickEvent = new PlayMakerEvent("UGUI / ON POINTER CLICK");
		this.onDownEvent = new PlayMakerEvent("UGUI / ON POINTER DOWN");
		this.onEnterEvent = new PlayMakerEvent("UGUI / ON POINTER ENTER");
		this.onExitEvent = new PlayMakerEvent("UGUI / ON POINTER EXIT");
		this.onUpEvent = new PlayMakerEvent("UGUI / ON POINTER UP");
		base..ctor();
	}

	// Token: 0x04000130 RID: 304
	public bool debug;

	// Token: 0x04000131 RID: 305
	public PlayMakerEventTarget eventTarget;

	// Token: 0x04000132 RID: 306
	[EventTargetVariable("eventTarget")]
	[ShowOptions]
	public PlayMakerEvent onClickEvent;

	// Token: 0x04000133 RID: 307
	[EventTargetVariable("eventTarget")]
	[ShowOptions]
	public PlayMakerEvent onDownEvent;

	// Token: 0x04000134 RID: 308
	[EventTargetVariable("eventTarget")]
	[ShowOptions]
	public PlayMakerEvent onEnterEvent;

	// Token: 0x04000135 RID: 309
	[EventTargetVariable("eventTarget")]
	[ShowOptions]
	public PlayMakerEvent onExitEvent;

	// Token: 0x04000136 RID: 310
	[EventTargetVariable("eventTarget")]
	[ShowOptions]
	public PlayMakerEvent onUpEvent;
}
