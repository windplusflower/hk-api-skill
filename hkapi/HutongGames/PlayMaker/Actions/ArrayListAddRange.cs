using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200090D RID: 2317
	[ActionCategory("ArrayMaker/ArrayList")]
	[Tooltip("Add several items to a PlayMaker Array List Proxy component")]
	public class ArrayListAddRange : ArrayListActions
	{
		// Token: 0x0600335E RID: 13150 RVA: 0x00135214 File Offset: 0x00133414
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
			this.variables = new FsmVar[2];
		}

		// Token: 0x0600335F RID: 13151 RVA: 0x00135230 File Offset: 0x00133430
		public override void OnEnter()
		{
			if (base.SetUpArrayListProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				this.DoArrayListAddRange();
			}
			base.Finish();
		}

		// Token: 0x06003360 RID: 13152 RVA: 0x00135264 File Offset: 0x00133464
		public void DoArrayListAddRange()
		{
			if (!base.isProxyValid())
			{
				return;
			}
			foreach (FsmVar fsmVar in this.variables)
			{
				this.proxy.Add(PlayMakerUtils.GetValueFromFsmVar(base.Fsm, fsmVar), fsmVar.Type.ToString(), true);
			}
		}

		// Token: 0x040034C7 RID: 13511
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker ArrayList Proxy component")]
		[CheckForComponent(typeof(PlayMakerArrayListProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040034C8 RID: 13512
		[Tooltip("Author defined Reference of the PlayMaker ArrayList Proxy component (necessary if several component coexists on the same GameObject)")]
		[UIHint(UIHint.FsmString)]
		public FsmString reference;

		// Token: 0x040034C9 RID: 13513
		[ActionSection("Data")]
		[RequiredField]
		[Tooltip("The variables to add.")]
		public FsmVar[] variables;
	}
}
