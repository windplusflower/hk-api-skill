using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020001E5 RID: 485
public class EventRegister : MonoBehaviour
{
	// Token: 0x14000011 RID: 17
	// (add) Token: 0x06000A8F RID: 2703 RVA: 0x000393E8 File Offset: 0x000375E8
	// (remove) Token: 0x06000A90 RID: 2704 RVA: 0x00039420 File Offset: 0x00037620
	public event EventRegister.RegisteredEvent OnReceivedEvent;

	// Token: 0x06000A91 RID: 2705 RVA: 0x00039455 File Offset: 0x00037655
	private void Awake()
	{
		EventRegister.SubscribeEvent(this);
	}

	// Token: 0x06000A92 RID: 2706 RVA: 0x0003945D File Offset: 0x0003765D
	private void OnDestroy()
	{
		EventRegister.UnsubscribeEvent(this);
	}

	// Token: 0x06000A93 RID: 2707 RVA: 0x00039465 File Offset: 0x00037665
	public void ReceiveEvent()
	{
		FSMUtility.SendEventToGameObject(base.gameObject, this.subscribedEvent, false);
		if (this.OnReceivedEvent != null)
		{
			this.OnReceivedEvent();
		}
	}

	// Token: 0x06000A94 RID: 2708 RVA: 0x0003948C File Offset: 0x0003768C
	public void SwitchEvent(string eventName)
	{
		EventRegister.UnsubscribeEvent(this);
		this.subscribedEvent = eventName;
		EventRegister.SubscribeEvent(this);
	}

	// Token: 0x06000A95 RID: 2709 RVA: 0x000394A4 File Offset: 0x000376A4
	public static void SendEvent(string eventName)
	{
		if (eventName == "")
		{
			return;
		}
		if (EventRegister.eventRegister.ContainsKey(eventName))
		{
			foreach (EventRegister eventRegister in EventRegister.eventRegister[eventName])
			{
				eventRegister.ReceiveEvent();
			}
		}
	}

	// Token: 0x06000A96 RID: 2710 RVA: 0x00039514 File Offset: 0x00037714
	public static void SubscribeEvent(EventRegister register)
	{
		string key = register.subscribedEvent;
		List<EventRegister> list;
		if (EventRegister.eventRegister.ContainsKey(key))
		{
			list = EventRegister.eventRegister[key];
		}
		else
		{
			list = new List<EventRegister>();
			EventRegister.eventRegister.Add(key, list);
		}
		list.Add(register);
	}

	// Token: 0x06000A97 RID: 2711 RVA: 0x00039560 File Offset: 0x00037760
	public static void UnsubscribeEvent(EventRegister register)
	{
		string key = register.subscribedEvent;
		if (EventRegister.eventRegister.ContainsKey(key))
		{
			List<EventRegister> list = EventRegister.eventRegister[key];
			if (list.Contains(register))
			{
				list.Remove(register);
			}
			if (list.Count <= 0)
			{
				EventRegister.eventRegister.Remove(key);
			}
		}
	}

	// Token: 0x06000A98 RID: 2712 RVA: 0x000395B3 File Offset: 0x000377B3
	public EventRegister()
	{
		this.subscribedEvent = "";
		base..ctor();
	}

	// Token: 0x06000A99 RID: 2713 RVA: 0x000395C6 File Offset: 0x000377C6
	// Note: this type is marked as 'beforefieldinit'.
	static EventRegister()
	{
		EventRegister.eventRegister = new Dictionary<string, List<EventRegister>>();
	}

	// Token: 0x04000BB4 RID: 2996
	public static Dictionary<string, List<EventRegister>> eventRegister;

	// Token: 0x04000BB6 RID: 2998
	[SerializeField]
	private string subscribedEvent;

	// Token: 0x020001E6 RID: 486
	// (Invoke) Token: 0x06000A9B RID: 2715
	public delegate void RegisteredEvent();
}
