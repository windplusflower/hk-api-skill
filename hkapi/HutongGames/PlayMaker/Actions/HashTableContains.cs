using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000931 RID: 2353
	[ActionCategory("ArrayMaker/HashTable")]
	[Tooltip("Check if a key exists in a PlayMaker HashTable Proxy component (PlayMakerHashTablePRoxy)")]
	public class HashTableContains : HashTableActions
	{
		// Token: 0x060033F0 RID: 13296 RVA: 0x00137610 File Offset: 0x00135810
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
			this.key = null;
			this.containsKey = null;
			this.keyFoundEvent = null;
			this.keyNotFoundEvent = null;
		}

		// Token: 0x060033F1 RID: 13297 RVA: 0x0013763C File Offset: 0x0013583C
		public override void OnEnter()
		{
			if (base.SetUpHashTableProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				this.checkIfContainsKey();
			}
			base.Finish();
		}

		// Token: 0x060033F2 RID: 13298 RVA: 0x00137670 File Offset: 0x00135870
		public void checkIfContainsKey()
		{
			if (!base.isProxyValid())
			{
				return;
			}
			this.containsKey.Value = this.proxy.hashTable.Contains(this.key.Value);
			if (this.containsKey.Value)
			{
				base.Fsm.Event(this.keyFoundEvent);
				return;
			}
			base.Fsm.Event(this.keyNotFoundEvent);
		}

		// Token: 0x04003576 RID: 13686
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker HashTable Proxy component")]
		[CheckForComponent(typeof(PlayMakerHashTableProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003577 RID: 13687
		[Tooltip("Author defined Reference of the PlayMaker HashTable Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;

		// Token: 0x04003578 RID: 13688
		[RequiredField]
		[UIHint(UIHint.FsmString)]
		[Tooltip("The Key value to check for")]
		public FsmString key;

		// Token: 0x04003579 RID: 13689
		[UIHint(UIHint.FsmBool)]
		[Tooltip("Store the result of the test")]
		public FsmBool containsKey;

		// Token: 0x0400357A RID: 13690
		[ActionSection("Result")]
		[UIHint(UIHint.FsmEvent)]
		[Tooltip("The event to trigger when key is found")]
		public FsmEvent keyFoundEvent;

		// Token: 0x0400357B RID: 13691
		[UIHint(UIHint.FsmEvent)]
		[Tooltip("The event to trigger when key is not found")]
		public FsmEvent keyNotFoundEvent;
	}
}
