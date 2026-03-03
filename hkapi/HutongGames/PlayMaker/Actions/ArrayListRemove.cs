using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200091D RID: 2333
	[ActionCategory("ArrayMaker/ArrayList")]
	[Tooltip("Remove an element of a PlayMaker Array List Proxy component")]
	public class ArrayListRemove : ArrayListActions
	{
		// Token: 0x0600339E RID: 13214 RVA: 0x001366CB File Offset: 0x001348CB
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
			this.notFoundEvent = null;
			this.variable = null;
		}

		// Token: 0x0600339F RID: 13215 RVA: 0x001366E9 File Offset: 0x001348E9
		public override void OnEnter()
		{
			if (base.SetUpArrayListProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				this.DoRemoveFromArrayList();
			}
			base.Finish();
		}

		// Token: 0x060033A0 RID: 13216 RVA: 0x0013671C File Offset: 0x0013491C
		public void DoRemoveFromArrayList()
		{
			if (!base.isProxyValid())
			{
				return;
			}
			if (!this.proxy.Remove(PlayMakerUtils.GetValueFromFsmVar(base.Fsm, this.variable), this.variable.Type.ToString(), false))
			{
				base.Fsm.Event(this.notFoundEvent);
			}
		}

		// Token: 0x04003527 RID: 13607
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker ArrayList Proxy component")]
		[CheckForComponent(typeof(PlayMakerArrayListProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003528 RID: 13608
		[Tooltip("Author defined Reference of the PlayMaker ArrayList Proxy component (necessary if several component coexists on the same GameObject)")]
		[UIHint(UIHint.FsmString)]
		public FsmString reference;

		// Token: 0x04003529 RID: 13609
		[ActionSection("Data")]
		[Tooltip("The type of Variable to remove.")]
		public FsmVar variable;

		// Token: 0x0400352A RID: 13610
		[ActionSection("Result")]
		[Tooltip("Event sent if this arraList does not contains that element ( described below)")]
		[UIHint(UIHint.FsmEvent)]
		public FsmEvent notFoundEvent;
	}
}
