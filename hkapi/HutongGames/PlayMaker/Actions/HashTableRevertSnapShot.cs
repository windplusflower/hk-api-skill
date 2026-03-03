using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200093E RID: 2366
	[ActionCategory("ArrayMaker/HashTable")]
	[Tooltip("Revert a PlayMaker HashTable Proxy component to the prefill data, either defined at runtime or when the action HashTableTakeSnapShot was used.")]
	public class HashTableRevertSnapShot : HashTableActions
	{
		// Token: 0x06003423 RID: 13347 RVA: 0x00138181 File Offset: 0x00136381
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
		}

		// Token: 0x06003424 RID: 13348 RVA: 0x00138191 File Offset: 0x00136391
		public override void OnEnter()
		{
			if (base.SetUpHashTableProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				this.DoHashTableRevertToSnapShot();
			}
			base.Finish();
		}

		// Token: 0x06003425 RID: 13349 RVA: 0x001381C3 File Offset: 0x001363C3
		public void DoHashTableRevertToSnapShot()
		{
			if (!base.isProxyValid())
			{
				return;
			}
			this.proxy.RevertToSnapShot();
		}

		// Token: 0x040035BE RID: 13758
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker HashTable Proxy component")]
		[CheckForComponent(typeof(PlayMakerHashTableProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040035BF RID: 13759
		[Tooltip("Author defined Reference of the PlayMaker HashTable Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;
	}
}
