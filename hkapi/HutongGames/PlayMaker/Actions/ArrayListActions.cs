using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200095A RID: 2394
	public abstract class ArrayListActions : CollectionsActions
	{
		// Token: 0x0600349A RID: 13466 RVA: 0x00139FF5 File Offset: 0x001381F5
		protected bool SetUpArrayListProxyPointer(GameObject aProxyGO, string nameReference)
		{
			if (aProxyGO == null)
			{
				return false;
			}
			this.proxy = base.GetArrayListProxyPointer(aProxyGO, nameReference, false);
			return this.proxy != null;
		}

		// Token: 0x0600349B RID: 13467 RVA: 0x0013A01D File Offset: 0x0013821D
		protected bool SetUpArrayListProxyPointer(PlayMakerArrayListProxy aProxy, string nameReference)
		{
			if (aProxy == null)
			{
				return false;
			}
			this.proxy = base.GetArrayListProxyPointer(aProxy.gameObject, nameReference, false);
			return this.proxy != null;
		}

		// Token: 0x0600349C RID: 13468 RVA: 0x0013A04A File Offset: 0x0013824A
		public bool isProxyValid()
		{
			if (this.proxy == null)
			{
				base.LogError("ArrayList proxy is null");
				return false;
			}
			if (this.proxy.arrayList == null)
			{
				base.LogError("ArrayList undefined");
				return false;
			}
			return true;
		}

		// Token: 0x04003654 RID: 13908
		internal PlayMakerArrayListProxy proxy;
	}
}
