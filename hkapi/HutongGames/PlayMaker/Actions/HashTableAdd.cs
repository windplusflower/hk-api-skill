using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200092D RID: 2349
	[ActionCategory("ArrayMaker/HashTable")]
	[Tooltip("Add an key/value pair to a PlayMaker HashTable Proxy component (PlayMakerHashTableProxy).")]
	public class HashTableAdd : HashTableActions
	{
		// Token: 0x060033E0 RID: 13280 RVA: 0x00137250 File Offset: 0x00135450
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
			this.key = null;
			this.variable = null;
			this.successEvent = null;
			this.keyExistsAlreadyEvent = null;
		}

		// Token: 0x060033E1 RID: 13281 RVA: 0x0013727C File Offset: 0x0013547C
		public override void OnEnter()
		{
			if (base.SetUpHashTableProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				if (this.proxy.hashTable.ContainsKey(this.key.Value))
				{
					base.Fsm.Event(this.keyExistsAlreadyEvent);
				}
				else
				{
					this.AddToHashTable();
					base.Fsm.Event(this.successEvent);
				}
			}
			base.Finish();
		}

		// Token: 0x060033E2 RID: 13282 RVA: 0x001372FA File Offset: 0x001354FA
		public void AddToHashTable()
		{
			if (!base.isProxyValid())
			{
				return;
			}
			this.proxy.hashTable.Add(this.key.Value, PlayMakerUtils.GetValueFromFsmVar(base.Fsm, this.variable));
		}

		// Token: 0x04003563 RID: 13667
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker HashTable Proxy component")]
		[CheckForComponent(typeof(PlayMakerHashTableProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003564 RID: 13668
		[Tooltip("Author defined Reference of the PlayMaker HashTable Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;

		// Token: 0x04003565 RID: 13669
		[ActionSection("Data")]
		[RequiredField]
		[UIHint(UIHint.FsmString)]
		[Tooltip("The Key value for that hash set")]
		public FsmString key;

		// Token: 0x04003566 RID: 13670
		[RequiredField]
		[Tooltip("The variable to add.")]
		public FsmVar variable;

		// Token: 0x04003567 RID: 13671
		[ActionSection("Result")]
		[UIHint(UIHint.FsmEvent)]
		[Tooltip("The event to trigger when element is added")]
		public FsmEvent successEvent;

		// Token: 0x04003568 RID: 13672
		[UIHint(UIHint.FsmEvent)]
		[Tooltip("The event to trigger when element exists already")]
		public FsmEvent keyExistsAlreadyEvent;
	}
}
