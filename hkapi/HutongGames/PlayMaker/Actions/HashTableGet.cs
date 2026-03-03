using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000937 RID: 2359
	[ActionCategory("ArrayMaker/HashTable")]
	[Tooltip("Gets an item from a PlayMaker HashTable Proxy component")]
	public class HashTableGet : HashTableActions
	{
		// Token: 0x06003407 RID: 13319 RVA: 0x00137AA4 File Offset: 0x00135CA4
		public override void Reset()
		{
			this.gameObject = null;
			this.key = null;
			this.KeyFoundEvent = null;
			this.KeyNotFoundEvent = null;
			this.result = null;
		}

		// Token: 0x06003408 RID: 13320 RVA: 0x00137AC9 File Offset: 0x00135CC9
		public override void OnEnter()
		{
			if (base.SetUpHashTableProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				this.Get();
			}
			base.Finish();
		}

		// Token: 0x06003409 RID: 13321 RVA: 0x00137AFC File Offset: 0x00135CFC
		public void Get()
		{
			if (!base.isProxyValid())
			{
				return;
			}
			if (!this.proxy.hashTable.ContainsKey(this.key.Value))
			{
				base.Fsm.Event(this.KeyNotFoundEvent);
				return;
			}
			PlayMakerUtils.ApplyValueToFsmVar(base.Fsm, this.result, this.proxy.hashTable[this.key.Value]);
			base.Fsm.Event(this.KeyFoundEvent);
		}

		// Token: 0x04003596 RID: 13718
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker HashTable Proxy component")]
		[CheckForComponent(typeof(PlayMakerHashTableProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003597 RID: 13719
		[Tooltip("Author defined Reference of the PlayMaker HashTable Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;

		// Token: 0x04003598 RID: 13720
		[RequiredField]
		[UIHint(UIHint.FsmString)]
		[Tooltip("The Key value for that hash set")]
		public FsmString key;

		// Token: 0x04003599 RID: 13721
		[ActionSection("Result")]
		[UIHint(UIHint.Variable)]
		public FsmVar result;

		// Token: 0x0400359A RID: 13722
		[UIHint(UIHint.FsmEvent)]
		[Tooltip("The event to trigger when key is found")]
		public FsmEvent KeyFoundEvent;

		// Token: 0x0400359B RID: 13723
		[UIHint(UIHint.FsmEvent)]
		[Tooltip("The event to trigger when key is not found")]
		public FsmEvent KeyNotFoundEvent;
	}
}
