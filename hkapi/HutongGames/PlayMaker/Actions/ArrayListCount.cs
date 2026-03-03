using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000912 RID: 2322
	[ActionCategory("ArrayMaker/ArrayList")]
	[Tooltip("Count items from a PlayMaker ArrayList Proxy component")]
	public class ArrayListCount : ArrayListActions
	{
		// Token: 0x06003372 RID: 13170 RVA: 0x0013587D File Offset: 0x00133A7D
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
			this.count = null;
		}

		// Token: 0x06003373 RID: 13171 RVA: 0x00135894 File Offset: 0x00133A94
		public override void OnEnter()
		{
			if (base.SetUpArrayListProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				this.getArrayListCount();
			}
			base.Finish();
		}

		// Token: 0x06003374 RID: 13172 RVA: 0x001358C8 File Offset: 0x00133AC8
		public void getArrayListCount()
		{
			if (!base.isProxyValid())
			{
				return;
			}
			int value = this.proxy.arrayList.Count;
			this.count.Value = value;
		}

		// Token: 0x040034DC RID: 13532
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker ArrayList Proxy component")]
		[CheckForComponent(typeof(PlayMakerArrayListProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040034DD RID: 13533
		[Tooltip("Author defined Reference of the PlayMaker ArrayList Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;

		// Token: 0x040034DE RID: 13534
		[ActionSection("Result")]
		[UIHint(UIHint.FsmInt)]
		[Tooltip("Store the count value")]
		public FsmInt count;
	}
}
