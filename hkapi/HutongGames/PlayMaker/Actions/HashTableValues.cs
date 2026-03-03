using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000942 RID: 2370
	[ActionCategory("ArrayMaker/HashTable")]
	[Tooltip("Store all the values of a PlayMaker HashTable Proxy component (PlayMakerHashTableProxy) into a PlayMaker arrayList Proxy component (PlayMakerArrayListProxy).")]
	public class HashTableValues : HashTableActions
	{
		// Token: 0x06003433 RID: 13363 RVA: 0x00138361 File Offset: 0x00136561
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
			this.arrayListGameObject = null;
			this.arrayListReference = null;
		}

		// Token: 0x06003434 RID: 13364 RVA: 0x0013837F File Offset: 0x0013657F
		public override void OnEnter()
		{
			if (base.SetUpHashTableProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				this.doHashTableValues();
			}
			base.Finish();
		}

		// Token: 0x06003435 RID: 13365 RVA: 0x001383B4 File Offset: 0x001365B4
		public void doHashTableValues()
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
				arrayListProxyPointer.arrayList.AddRange(this.proxy.hashTable.Values);
			}
		}

		// Token: 0x040035CA RID: 13770
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker HashTable Proxy component")]
		[CheckForComponent(typeof(PlayMakerHashTableProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040035CB RID: 13771
		[Tooltip("Author defined Reference of the PlayMaker HashTable Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;

		// Token: 0x040035CC RID: 13772
		[ActionSection("Result")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker ArrayList Proxy component that will store the values")]
		[CheckForComponent(typeof(PlayMakerArrayListProxy))]
		public FsmOwnerDefault arrayListGameObject;

		// Token: 0x040035CD RID: 13773
		[Tooltip("Author defined Reference of the PlayMaker ArrayList Proxy component that will store the values ( necessary if several component coexists on the same GameObject")]
		public FsmString arrayListReference;
	}
}
