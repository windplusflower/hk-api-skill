using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000927 RID: 2343
	[ActionCategory("ArrayMaker/ArrayList")]
	[Tooltip("Takes a PlayMaker ArrayList Proxy component snapshot, use action ArrayListRevertToSnapShot was used. A Snapshot is taken by default at the beginning for the prefill data")]
	public class ArrayListTakeSnapShot : ArrayListActions
	{
		// Token: 0x060033C7 RID: 13255 RVA: 0x00136DC4 File Offset: 0x00134FC4
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
		}

		// Token: 0x060033C8 RID: 13256 RVA: 0x00136DD4 File Offset: 0x00134FD4
		public override void OnEnter()
		{
			if (base.SetUpArrayListProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				this.DoArrayListTakeSnapShot();
			}
			base.Finish();
		}

		// Token: 0x060033C9 RID: 13257 RVA: 0x00136E06 File Offset: 0x00135006
		public void DoArrayListTakeSnapShot()
		{
			if (!base.isProxyValid())
			{
				return;
			}
			this.proxy.TakeSnapShot();
		}

		// Token: 0x0400354B RID: 13643
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker ArrayList Proxy component")]
		[CheckForComponent(typeof(PlayMakerArrayListProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400354C RID: 13644
		[Tooltip("Author defined Reference of the PlayMaker ArrayList Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;
	}
}
