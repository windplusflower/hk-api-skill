using System;

namespace HutongGames.PlayMaker.Ecosystem.Utils
{
	// Token: 0x020008C6 RID: 2246
	[Serializable]
	public class PlayMakerEvent
	{
		// Token: 0x0600321C RID: 12828 RVA: 0x0000310E File Offset: 0x0000130E
		public PlayMakerEvent()
		{
		}

		// Token: 0x0600321D RID: 12829 RVA: 0x001309F8 File Offset: 0x0012EBF8
		public PlayMakerEvent(string defaultEventName)
		{
			this.defaultEventName = defaultEventName;
			this.eventName = defaultEventName;
		}

		// Token: 0x0600321E RID: 12830 RVA: 0x00130A10 File Offset: 0x0012EC10
		public bool SendEvent(PlayMakerFSM fromFsm, PlayMakerEventTarget eventTarget)
		{
			if (eventTarget.eventTarget == ProxyEventTarget.BroadCastAll)
			{
				PlayMakerFSM.BroadcastEvent(this.eventName);
			}
			else if (eventTarget.eventTarget == ProxyEventTarget.Owner || eventTarget.eventTarget == ProxyEventTarget.GameObject)
			{
				PlayMakerUtils.SendEventToGameObject(fromFsm, eventTarget.gameObject, this.eventName, eventTarget.includeChildren);
			}
			else if (eventTarget.eventTarget == ProxyEventTarget.FsmComponent)
			{
				eventTarget.fsmComponent.SendEvent(this.eventName);
			}
			return true;
		}

		// Token: 0x04003359 RID: 13145
		public string eventName;

		// Token: 0x0400335A RID: 13146
		public bool allowLocalEvents;

		// Token: 0x0400335B RID: 13147
		public string defaultEventName;
	}
}
