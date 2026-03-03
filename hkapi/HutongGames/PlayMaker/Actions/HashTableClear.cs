using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200092F RID: 2351
	[ActionCategory("ArrayMaker/HashTable")]
	[Tooltip("Remove all content of a PlayMaker hashtable Proxy component")]
	public class HashTableClear : HashTableActions
	{
		// Token: 0x060033E8 RID: 13288 RVA: 0x00137459 File Offset: 0x00135659
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
		}

		// Token: 0x060033E9 RID: 13289 RVA: 0x00137469 File Offset: 0x00135669
		public override void OnEnter()
		{
			if (base.SetUpHashTableProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				this.ClearHashTable();
			}
			base.Finish();
		}

		// Token: 0x060033EA RID: 13290 RVA: 0x0013749B File Offset: 0x0013569B
		public void ClearHashTable()
		{
			if (!base.isProxyValid())
			{
				return;
			}
			this.proxy.hashTable.Clear();
		}

		// Token: 0x0400356F RID: 13679
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker HashTable Proxy component")]
		[CheckForComponent(typeof(PlayMakerHashTableProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003570 RID: 13680
		[Tooltip("Author defined Reference of the PlayMaker HashTable Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;
	}
}
