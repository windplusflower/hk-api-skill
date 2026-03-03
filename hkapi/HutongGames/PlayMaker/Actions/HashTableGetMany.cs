using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000939 RID: 2361
	[ActionCategory("ArrayMaker/HashTable")]
	[Tooltip("Gets items from a PlayMaker HashTable Proxy component")]
	public class HashTableGetMany : HashTableActions
	{
		// Token: 0x0600340F RID: 13327 RVA: 0x00137C80 File Offset: 0x00135E80
		public override void Reset()
		{
			this.gameObject = null;
			this.keys = null;
			this.results = null;
		}

		// Token: 0x06003410 RID: 13328 RVA: 0x00137C97 File Offset: 0x00135E97
		public override void OnEnter()
		{
			if (base.SetUpHashTableProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				this.Get();
			}
			base.Finish();
		}

		// Token: 0x06003411 RID: 13329 RVA: 0x00137CCC File Offset: 0x00135ECC
		public void Get()
		{
			if (!base.isProxyValid())
			{
				return;
			}
			for (int i = 0; i < this.keys.Length; i++)
			{
				if (this.proxy.hashTable.ContainsKey(this.keys[i].Value))
				{
					PlayMakerUtils.ApplyValueToFsmVar(base.Fsm, this.results[i], this.proxy.hashTable[this.keys[i].Value]);
				}
			}
		}

		// Token: 0x040035A2 RID: 13730
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker HashTable Proxy component")]
		[CheckForComponent(typeof(PlayMakerHashTableProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040035A3 RID: 13731
		[Tooltip("Author defined Reference of the PlayMaker HashTable Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;

		// Token: 0x040035A4 RID: 13732
		[ActionSection("Data")]
		[CompoundArray("Count", "Key", "Value")]
		[RequiredField]
		[UIHint(UIHint.FsmString)]
		[Tooltip("The Key value for that hash set")]
		public FsmString[] keys;

		// Token: 0x040035A5 RID: 13733
		[Tooltip("The value for that key")]
		[UIHint(UIHint.Variable)]
		public FsmVar[] results;
	}
}
