using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000941 RID: 2369
	[ActionCategory("ArrayMaker/HashTable")]
	[Tooltip("Takes a PlayMaker HashTable Proxy component snapshot, use action HashTableRevertToSnapShot was used. A Snapshot is taken by default at the beginning for the prefill data")]
	public class HashTableTakeSnapShot : HashTableActions
	{
		// Token: 0x0600342F RID: 13359 RVA: 0x00138309 File Offset: 0x00136509
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
		}

		// Token: 0x06003430 RID: 13360 RVA: 0x00138319 File Offset: 0x00136519
		public override void OnEnter()
		{
			if (base.SetUpHashTableProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				this.DoHashTableTakeSnapShot();
			}
			base.Finish();
		}

		// Token: 0x06003431 RID: 13361 RVA: 0x0013834B File Offset: 0x0013654B
		public void DoHashTableTakeSnapShot()
		{
			if (!base.isProxyValid())
			{
				return;
			}
			this.proxy.TakeSnapShot();
		}

		// Token: 0x040035C8 RID: 13768
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker HashTable Proxy component")]
		[CheckForComponent(typeof(PlayMakerHashTableProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040035C9 RID: 13769
		[Tooltip("Author defined Reference of the PlayMaker HashTable Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;
	}
}
