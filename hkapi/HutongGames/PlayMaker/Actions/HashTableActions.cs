using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200095D RID: 2397
	public abstract class HashTableActions : CollectionsActions
	{
		// Token: 0x060034A1 RID: 13473 RVA: 0x0013A23B File Offset: 0x0013843B
		protected bool SetUpHashTableProxyPointer(GameObject aProxyGO, string nameReference)
		{
			if (aProxyGO == null)
			{
				return false;
			}
			this.proxy = base.GetHashTableProxyPointer(aProxyGO, nameReference, false);
			return this.proxy != null;
		}

		// Token: 0x060034A2 RID: 13474 RVA: 0x0013A263 File Offset: 0x00138463
		protected bool SetUpHashTableProxyPointer(PlayMakerHashTableProxy aProxy, string nameReference)
		{
			if (aProxy == null)
			{
				return false;
			}
			this.proxy = base.GetHashTableProxyPointer(aProxy.gameObject, nameReference, false);
			return this.proxy != null;
		}

		// Token: 0x060034A3 RID: 13475 RVA: 0x0013A290 File Offset: 0x00138490
		protected bool isProxyValid()
		{
			if (this.proxy == null)
			{
				Debug.LogError("HashTable proxy is null");
				return false;
			}
			if (this.proxy.hashTable == null)
			{
				Debug.LogError("HashTable undefined");
				return false;
			}
			return true;
		}

		// Token: 0x04003663 RID: 13923
		internal PlayMakerHashTableProxy proxy;
	}
}
