using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000922 RID: 2338
	[ActionCategory("ArrayMaker/ArrayList")]
	[Tooltip("Revert a PlayMaker ArrayList Proxy component to the prefill data, either defined at runtime or when the action ArrayListTakeSnapShot was used. ")]
	public class ArrayListRevertToSnapShot : ArrayListActions
	{
		// Token: 0x060033B2 RID: 13234 RVA: 0x001369F2 File Offset: 0x00134BF2
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
		}

		// Token: 0x060033B3 RID: 13235 RVA: 0x00136A02 File Offset: 0x00134C02
		public override void OnEnter()
		{
			if (base.SetUpArrayListProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				this.DoArrayListRevertToSnapShot();
			}
			base.Finish();
		}

		// Token: 0x060033B4 RID: 13236 RVA: 0x00136A34 File Offset: 0x00134C34
		public void DoArrayListRevertToSnapShot()
		{
			if (!base.isProxyValid())
			{
				return;
			}
			this.proxy.RevertToSnapShot();
		}

		// Token: 0x04003539 RID: 13625
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker ArrayList Proxy component")]
		[CheckForComponent(typeof(PlayMakerArrayListProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400353A RID: 13626
		[Tooltip("Author defined Reference of the PlayMaker ArrayList Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;
	}
}
