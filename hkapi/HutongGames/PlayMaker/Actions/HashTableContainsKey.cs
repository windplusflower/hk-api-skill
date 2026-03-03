using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000932 RID: 2354
	[ActionCategory("ArrayMaker/HashTable")]
	[Tooltip("Check if a key exists in a PlayMaker HashTable Proxy component (PlayMakerHashTablePRoxy)")]
	public class HashTableContainsKey : HashTableActions
	{
		// Token: 0x060033F4 RID: 13300 RVA: 0x001376DC File Offset: 0x001358DC
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
			this.key = null;
			this.containsKey = null;
			this.keyFoundEvent = null;
			this.keyNotFoundEvent = null;
		}

		// Token: 0x060033F5 RID: 13301 RVA: 0x00137708 File Offset: 0x00135908
		public override void OnEnter()
		{
			if (base.SetUpHashTableProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				this.checkIfContainsKey();
			}
			base.Finish();
		}

		// Token: 0x060033F6 RID: 13302 RVA: 0x0013773C File Offset: 0x0013593C
		public void checkIfContainsKey()
		{
			if (!base.isProxyValid())
			{
				return;
			}
			this.containsKey.Value = this.proxy.hashTable.ContainsKey(this.key.Value);
			if (this.containsKey.Value)
			{
				base.Fsm.Event(this.keyFoundEvent);
				return;
			}
			base.Fsm.Event(this.keyNotFoundEvent);
		}

		// Token: 0x0400357C RID: 13692
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker HashTable Proxy component")]
		[CheckForComponent(typeof(PlayMakerHashTableProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400357D RID: 13693
		[Tooltip("Author defined Reference of the PlayMaker HashTable Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;

		// Token: 0x0400357E RID: 13694
		[RequiredField]
		[UIHint(UIHint.FsmString)]
		[Tooltip("The Key value to check for")]
		public FsmString key;

		// Token: 0x0400357F RID: 13695
		[UIHint(UIHint.FsmBool)]
		[Tooltip("Store the result of the test")]
		public FsmBool containsKey;

		// Token: 0x04003580 RID: 13696
		[ActionSection("Result")]
		[UIHint(UIHint.FsmEvent)]
		[Tooltip("The event to trigger when key is found")]
		public FsmEvent keyFoundEvent;

		// Token: 0x04003581 RID: 13697
		[UIHint(UIHint.FsmEvent)]
		[Tooltip("The event to trigger when key is not found")]
		public FsmEvent keyNotFoundEvent;
	}
}
