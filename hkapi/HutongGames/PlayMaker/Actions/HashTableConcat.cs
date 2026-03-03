using System;
using System.Collections;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000930 RID: 2352
	[ActionCategory("ArrayMaker/HashTable")]
	[Tooltip("Concat joins two or more hashTable proxy components. if a target is specified, the method use the target store the concatenation, else the ")]
	public class HashTableConcat : HashTableActions
	{
		// Token: 0x060033EC RID: 13292 RVA: 0x001374B6 File Offset: 0x001356B6
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
			this.hashTableGameObjectTargets = null;
			this.referenceTargets = null;
			this.overwriteExistingKey = null;
		}

		// Token: 0x060033ED RID: 13293 RVA: 0x001374DB File Offset: 0x001356DB
		public override void OnEnter()
		{
			if (base.SetUpHashTableProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				this.DoHashTableConcat(this.proxy.hashTable);
			}
			base.Finish();
		}

		// Token: 0x060033EE RID: 13294 RVA: 0x00137518 File Offset: 0x00135718
		public void DoHashTableConcat(Hashtable source)
		{
			if (!base.isProxyValid())
			{
				return;
			}
			for (int i = 0; i < this.hashTableGameObjectTargets.Length; i++)
			{
				if (base.SetUpHashTableProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.hashTableGameObjectTargets[i]), this.referenceTargets[i].Value) && base.isProxyValid())
				{
					foreach (object key in this.proxy.hashTable.Keys)
					{
						if (source.ContainsKey(key))
						{
							if (this.overwriteExistingKey.Value)
							{
								source[key] = this.proxy.hashTable[key];
							}
						}
						else
						{
							source[key] = this.proxy.hashTable[key];
						}
					}
				}
			}
		}

		// Token: 0x04003571 RID: 13681
		[ActionSection("Storage")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker HashTable Proxy component")]
		[CheckForComponent(typeof(PlayMakerHashTableProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003572 RID: 13682
		[Tooltip("Author defined Reference of the PlayMaker HashTable Proxy component to store the concatenation ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;

		// Token: 0x04003573 RID: 13683
		[ActionSection("HashTables to concatenate")]
		[CompoundArray("HashTables", "HashTable GameObject", "Reference")]
		[RequiredField]
		[Tooltip("The GameObject with the PlayMaker HashTable Proxy component to copy to")]
		[ObjectType(typeof(PlayMakerHashTableProxy))]
		public FsmOwnerDefault[] hashTableGameObjectTargets;

		// Token: 0x04003574 RID: 13684
		[Tooltip("Author defined Reference of the PlayMaker ArrayList Proxy component to copy to ( necessary if several component coexists on the same GameObject")]
		public FsmString[] referenceTargets;

		// Token: 0x04003575 RID: 13685
		[Tooltip("Overwrite existing key with new values")]
		[UIHint(UIHint.FsmBool)]
		public FsmBool overwriteExistingKey;
	}
}
