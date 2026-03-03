using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000940 RID: 2368
	[ActionCategory("ArrayMaker/HashTable")]
	[Tooltip("Set key/value pairs to a PlayMaker HashTable Proxy component (PlayMakerHashTableProxy)")]
	public class HashTableSetMany : HashTableActions
	{
		// Token: 0x0600342B RID: 13355 RVA: 0x00138260 File Offset: 0x00136460
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
			this.keys = null;
			this.variables = null;
		}

		// Token: 0x0600342C RID: 13356 RVA: 0x0013827E File Offset: 0x0013647E
		public override void OnEnter()
		{
			if (base.SetUpHashTableProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				this.SetHashTable();
			}
			base.Finish();
		}

		// Token: 0x0600342D RID: 13357 RVA: 0x001382B0 File Offset: 0x001364B0
		public void SetHashTable()
		{
			if (!base.isProxyValid())
			{
				return;
			}
			for (int i = 0; i < this.keys.Length; i++)
			{
				this.proxy.hashTable[this.keys[i].Value] = PlayMakerUtils.GetValueFromFsmVar(base.Fsm, this.variables[i]);
			}
		}

		// Token: 0x040035C4 RID: 13764
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker HashTable Proxy component")]
		[CheckForComponent(typeof(PlayMakerHashTableProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040035C5 RID: 13765
		[Tooltip("Author defined Reference of the PlayMaker HashTable Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;

		// Token: 0x040035C6 RID: 13766
		[ActionSection("Data")]
		[CompoundArray("Count", "Key", "Value")]
		[RequiredField]
		[UIHint(UIHint.FsmString)]
		[Tooltip("The Key values for that hash set")]
		public FsmString[] keys;

		// Token: 0x040035C7 RID: 13767
		[Tooltip("The variable to set.")]
		public FsmVar[] variables;
	}
}
