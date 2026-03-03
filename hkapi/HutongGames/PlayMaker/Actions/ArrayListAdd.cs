using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200090C RID: 2316
	[ActionCategory("ArrayMaker/ArrayList")]
	[Tooltip("Add an item to a PlayMaker Array List Proxy component")]
	public class ArrayListAdd : ArrayListActions
	{
		// Token: 0x0600335A RID: 13146 RVA: 0x00135177 File Offset: 0x00133377
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
			this.variable = null;
		}

		// Token: 0x0600335B RID: 13147 RVA: 0x0013518E File Offset: 0x0013338E
		public override void OnEnter()
		{
			if (base.SetUpArrayListProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				this.AddToArrayList();
			}
			base.Finish();
		}

		// Token: 0x0600335C RID: 13148 RVA: 0x001351C0 File Offset: 0x001333C0
		public void AddToArrayList()
		{
			if (!base.isProxyValid())
			{
				return;
			}
			this.proxy.Add(PlayMakerUtils.GetValueFromFsmVar(base.Fsm, this.variable), this.variable.Type.ToString(), false);
		}

		// Token: 0x040034C4 RID: 13508
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker ArrayList Proxy component")]
		[CheckForComponent(typeof(PlayMakerArrayListProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040034C5 RID: 13509
		[Tooltip("Author defined Reference of the PlayMaker ArrayList Proxy component (necessary if several component coexists on the same GameObject)")]
		[UIHint(UIHint.FsmString)]
		public FsmString reference;

		// Token: 0x040034C6 RID: 13510
		[ActionSection("Data")]
		[RequiredField]
		[Tooltip("The variable to add.")]
		public FsmVar variable;
	}
}
