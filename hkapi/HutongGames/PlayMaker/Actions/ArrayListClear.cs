using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200090E RID: 2318
	[ActionCategory("ArrayMaker/ArrayList")]
	[Tooltip("Removes all elements from a PlayMaker ArrayList Proxy component")]
	public class ArrayListClear : ArrayListActions
	{
		// Token: 0x06003362 RID: 13154 RVA: 0x001352BF File Offset: 0x001334BF
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
		}

		// Token: 0x06003363 RID: 13155 RVA: 0x001352CF File Offset: 0x001334CF
		public override void OnEnter()
		{
			if (base.SetUpArrayListProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				this.ClearArrayList();
			}
			base.Finish();
		}

		// Token: 0x06003364 RID: 13156 RVA: 0x00135301 File Offset: 0x00133501
		public void ClearArrayList()
		{
			if (!base.isProxyValid())
			{
				return;
			}
			this.proxy.arrayList.Clear();
		}

		// Token: 0x040034CA RID: 13514
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker ArrayList Proxy component")]
		[CheckForComponent(typeof(PlayMakerArrayListProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040034CB RID: 13515
		[Tooltip("Author defined Reference of the PlayMaker ArrayList Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;
	}
}
