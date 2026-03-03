using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200093C RID: 2364
	[ActionCategory("ArrayMaker/HashTable")]
	[Tooltip("Store all the keys of a PlayMaker HashTable Proxy component (PlayMakerHashTableProxy) into a PlayMaker arrayList Proxy component (PlayMakerArrayListProxy).")]
	public class HashTableKeys : HashTableActions
	{
		// Token: 0x0600341B RID: 13339 RVA: 0x00138057 File Offset: 0x00136257
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
			this.arrayListGameObject = null;
			this.arrayListReference = null;
		}

		// Token: 0x0600341C RID: 13340 RVA: 0x00138075 File Offset: 0x00136275
		public override void OnEnter()
		{
			if (base.SetUpHashTableProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				this.doHashTableKeys();
			}
			base.Finish();
		}

		// Token: 0x0600341D RID: 13341 RVA: 0x001380A8 File Offset: 0x001362A8
		public void doHashTableKeys()
		{
			if (!base.isProxyValid())
			{
				return;
			}
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.arrayListGameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			PlayMakerArrayListProxy arrayListProxyPointer = base.GetArrayListProxyPointer(ownerDefaultTarget, this.arrayListReference.Value, false);
			if (arrayListProxyPointer != null)
			{
				arrayListProxyPointer.arrayList.AddRange(this.proxy.hashTable.Keys);
			}
		}

		// Token: 0x040035B7 RID: 13751
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker HashTable Proxy component")]
		[CheckForComponent(typeof(PlayMakerHashTableProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040035B8 RID: 13752
		[Tooltip("Author defined Reference of the PlayMaker HashTable Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;

		// Token: 0x040035B9 RID: 13753
		[ActionSection("Result")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker ArrayList Proxy component that will store the keys")]
		[CheckForComponent(typeof(PlayMakerArrayListProxy))]
		public FsmOwnerDefault arrayListGameObject;

		// Token: 0x040035BA RID: 13754
		[Tooltip("Author defined Reference of the PlayMaker ArrayList Proxy component that will store the keys ( necessary if several component coexists on the same GameObject")]
		public FsmString arrayListReference;
	}
}
