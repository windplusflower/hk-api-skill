using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000934 RID: 2356
	[ActionCategory("ArrayMaker/HashTable")]
	[Tooltip("Count the number of items ( key/value pairs) in a PlayMaker HashTable Proxy component (PlayMakerHashTableProxy).")]
	public class HashTableCount : HashTableActions
	{
		// Token: 0x060033FC RID: 13308 RVA: 0x0013787A File Offset: 0x00135A7A
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
			this.count = null;
		}

		// Token: 0x060033FD RID: 13309 RVA: 0x00137891 File Offset: 0x00135A91
		public override void OnEnter()
		{
			if (base.SetUpHashTableProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				this.doHashTableCount();
			}
			base.Finish();
		}

		// Token: 0x060033FE RID: 13310 RVA: 0x001378C3 File Offset: 0x00135AC3
		public void doHashTableCount()
		{
			if (!base.isProxyValid())
			{
				return;
			}
			this.count.Value = this.proxy.hashTable.Count;
		}

		// Token: 0x04003588 RID: 13704
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker HashTable Proxy component")]
		[CheckForComponent(typeof(PlayMakerHashTableProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003589 RID: 13705
		[Tooltip("Author defined Reference of the PlayMaker HashTable Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;

		// Token: 0x0400358A RID: 13706
		[ActionSection("Result")]
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The number of items in that hashTable")]
		public FsmInt count;
	}
}
