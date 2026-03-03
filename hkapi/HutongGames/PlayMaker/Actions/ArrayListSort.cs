using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000925 RID: 2341
	[ActionCategory("ArrayMaker/ArrayList")]
	[Tooltip("Sorts the sequence of elements in a PlayMaker ArrayList Proxy component")]
	public class ArrayListSort : ArrayListActions
	{
		// Token: 0x060033BF RID: 13247 RVA: 0x00136C5A File Offset: 0x00134E5A
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
		}

		// Token: 0x060033C0 RID: 13248 RVA: 0x00136C6A File Offset: 0x00134E6A
		public override void OnEnter()
		{
			if (base.SetUpArrayListProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				this.DoArrayListSort();
			}
			base.Finish();
		}

		// Token: 0x060033C1 RID: 13249 RVA: 0x00136C9C File Offset: 0x00134E9C
		public void DoArrayListSort()
		{
			if (!base.isProxyValid())
			{
				return;
			}
			this.proxy.arrayList.Sort();
		}

		// Token: 0x04003544 RID: 13636
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker ArrayList Proxy component")]
		[CheckForComponent(typeof(PlayMakerArrayListProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003545 RID: 13637
		[Tooltip("Author defined Reference of the PlayMaker ArrayList Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;
	}
}
