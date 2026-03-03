using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000923 RID: 2339
	[ActionCategory("ArrayMaker/ArrayList")]
	[Tooltip("Set an item at a specified index to a PlayMaker array List component")]
	public class ArrayListSet : ArrayListActions
	{
		// Token: 0x060033B6 RID: 13238 RVA: 0x00136A4A File Offset: 0x00134C4A
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
			this.variable = null;
			this.everyFrame = false;
		}

		// Token: 0x060033B7 RID: 13239 RVA: 0x00136A68 File Offset: 0x00134C68
		public override void OnEnter()
		{
			if (base.SetUpArrayListProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				this.SetToArrayList();
			}
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060033B8 RID: 13240 RVA: 0x00136AA2 File Offset: 0x00134CA2
		public override void OnUpdate()
		{
			this.SetToArrayList();
		}

		// Token: 0x060033B9 RID: 13241 RVA: 0x00136AAC File Offset: 0x00134CAC
		public void SetToArrayList()
		{
			if (!base.isProxyValid())
			{
				return;
			}
			this.proxy.Set(this.atIndex.Value, PlayMakerUtils.GetValueFromFsmVar(base.Fsm, this.variable), this.variable.Type.ToString());
		}

		// Token: 0x0400353B RID: 13627
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker ArrayList Proxy component")]
		[CheckForComponent(typeof(PlayMakerArrayListProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400353C RID: 13628
		[Tooltip("Author defined Reference of the PlayMaker ArrayList Proxy component (necessary if several component coexists on the same GameObject)")]
		[UIHint(UIHint.FsmString)]
		public FsmString reference;

		// Token: 0x0400353D RID: 13629
		[Tooltip("The index of the Data in the ArrayList")]
		[UIHint(UIHint.FsmString)]
		public FsmInt atIndex;

		// Token: 0x0400353E RID: 13630
		public bool everyFrame;

		// Token: 0x0400353F RID: 13631
		[ActionSection("Data")]
		[Tooltip("The variable to add.")]
		public FsmVar variable;
	}
}
