using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200093D RID: 2365
	[ActionCategory("ArrayMaker/HashTable")]
	[Tooltip("Remove an item by key ( key/value pairs) in a PlayMaker HashTable Proxy component (PlayMakerHashTableProxy).")]
	public class HashTableRemove : HashTableActions
	{
		// Token: 0x0600341F RID: 13343 RVA: 0x00138112 File Offset: 0x00136312
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
			this.key = null;
		}

		// Token: 0x06003420 RID: 13344 RVA: 0x00138129 File Offset: 0x00136329
		public override void OnEnter()
		{
			if (base.SetUpHashTableProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				this.doHashTableRemove();
			}
			base.Finish();
		}

		// Token: 0x06003421 RID: 13345 RVA: 0x0013815B File Offset: 0x0013635B
		public void doHashTableRemove()
		{
			if (!base.isProxyValid())
			{
				return;
			}
			this.proxy.hashTable.Remove(this.key.Value);
		}

		// Token: 0x040035BB RID: 13755
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker HashTable Proxy component")]
		[CheckForComponent(typeof(PlayMakerHashTableProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040035BC RID: 13756
		[Tooltip("Author defined Reference of the PlayMaker HashTable Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;

		// Token: 0x040035BD RID: 13757
		[RequiredField]
		[Tooltip("The item key in that hashTable")]
		public FsmString key;
	}
}
