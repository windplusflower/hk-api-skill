using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000935 RID: 2357
	[ActionCategory("ArrayMaker/HashTable")]
	[Tooltip("Edit a key from a PlayMaker HashTable Proxy component (PlayMakerHashTableProxy)")]
	public class HashTableEditKey : HashTableActions
	{
		// Token: 0x06003400 RID: 13312 RVA: 0x001378E9 File Offset: 0x00135AE9
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
			this.key = null;
			this.newKey = null;
			this.keyNotFoundEvent = null;
			this.newKeyExistsAlreadyEvent = null;
		}

		// Token: 0x06003401 RID: 13313 RVA: 0x00137915 File Offset: 0x00135B15
		public override void OnEnter()
		{
			if (base.SetUpHashTableProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				this.EditHashTableKey();
			}
			base.Finish();
		}

		// Token: 0x06003402 RID: 13314 RVA: 0x00137948 File Offset: 0x00135B48
		public void EditHashTableKey()
		{
			if (!base.isProxyValid())
			{
				return;
			}
			if (!this.proxy.hashTable.ContainsKey(this.key.Value))
			{
				base.Fsm.Event(this.keyNotFoundEvent);
				return;
			}
			if (this.proxy.hashTable.ContainsKey(this.newKey.Value))
			{
				base.Fsm.Event(this.newKeyExistsAlreadyEvent);
				return;
			}
			object value = this.proxy.hashTable[this.key.Value];
			this.proxy.hashTable[this.newKey.Value] = value;
			this.proxy.hashTable.Remove(this.key.Value);
		}

		// Token: 0x0400358B RID: 13707
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker HashTable Proxy component")]
		[CheckForComponent(typeof(PlayMakerHashTableProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400358C RID: 13708
		[Tooltip("Author defined Reference of the PlayMaker HashTable Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;

		// Token: 0x0400358D RID: 13709
		[RequiredField]
		[UIHint(UIHint.FsmString)]
		[Tooltip("The Key value to edit")]
		public FsmString key;

		// Token: 0x0400358E RID: 13710
		[RequiredField]
		[UIHint(UIHint.FsmString)]
		[Tooltip("The Key value to edit")]
		public FsmString newKey;

		// Token: 0x0400358F RID: 13711
		[ActionSection("Result")]
		[Tooltip("Event sent if this HashTable key does not exists")]
		[UIHint(UIHint.FsmEvent)]
		public FsmEvent keyNotFoundEvent;

		// Token: 0x04003590 RID: 13712
		[Tooltip("Event sent if this HashTable already contains the new key")]
		[UIHint(UIHint.FsmEvent)]
		public FsmEvent newKeyExistsAlreadyEvent;
	}
}
