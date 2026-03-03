using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000921 RID: 2337
	[ActionCategory("ArrayMaker/ArrayList")]
	[Tooltip("Reverses the sequence of elements in a PlayMaker ArrayList Proxy component")]
	public class ArrayListReverse : ArrayListActions
	{
		// Token: 0x060033AE RID: 13230 RVA: 0x00136995 File Offset: 0x00134B95
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
		}

		// Token: 0x060033AF RID: 13231 RVA: 0x001369A5 File Offset: 0x00134BA5
		public override void OnEnter()
		{
			if (base.SetUpArrayListProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				this.DoArrayListReverse();
			}
			base.Finish();
		}

		// Token: 0x060033B0 RID: 13232 RVA: 0x001369D7 File Offset: 0x00134BD7
		public void DoArrayListReverse()
		{
			if (!base.isProxyValid())
			{
				return;
			}
			this.proxy.arrayList.Reverse();
		}

		// Token: 0x04003537 RID: 13623
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker ArrayList Proxy component")]
		[CheckForComponent(typeof(PlayMakerArrayListProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003538 RID: 13624
		[Tooltip("Author defined Reference of the PlayMaker ArrayList Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;
	}
}
