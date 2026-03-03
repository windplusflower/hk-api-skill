using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200093F RID: 2367
	[ActionCategory("ArrayMaker/HashTable")]
	[Tooltip("Set an key/value pair to a PlayMaker HashTable Proxy component (PlayMakerHashTableProxy)")]
	public class HashTableSet : HashTableActions
	{
		// Token: 0x06003427 RID: 13351 RVA: 0x001381D9 File Offset: 0x001363D9
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
			this.key = null;
			this.variable = null;
		}

		// Token: 0x06003428 RID: 13352 RVA: 0x001381F7 File Offset: 0x001363F7
		public override void OnEnter()
		{
			if (base.SetUpHashTableProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				this.SetHashTable();
			}
			base.Finish();
		}

		// Token: 0x06003429 RID: 13353 RVA: 0x00138229 File Offset: 0x00136429
		public void SetHashTable()
		{
			if (!base.isProxyValid())
			{
				return;
			}
			this.proxy.hashTable[this.key.Value] = PlayMakerUtils.GetValueFromFsmVar(base.Fsm, this.variable);
		}

		// Token: 0x040035C0 RID: 13760
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker HashTable Proxy component")]
		[CheckForComponent(typeof(PlayMakerHashTableProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040035C1 RID: 13761
		[Tooltip("Author defined Reference of the PlayMaker HashTable Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;

		// Token: 0x040035C2 RID: 13762
		[RequiredField]
		[UIHint(UIHint.FsmString)]
		[Tooltip("The Key value for that hash set")]
		public FsmString key;

		// Token: 0x040035C3 RID: 13763
		[ActionSection("Result")]
		[Tooltip("The variable to set.")]
		public FsmVar variable;
	}
}
