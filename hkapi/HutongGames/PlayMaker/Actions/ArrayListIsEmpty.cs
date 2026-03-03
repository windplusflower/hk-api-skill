using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200091A RID: 2330
	[ActionCategory("ArrayMaker/ArrayList")]
	[Tooltip("Check if an ArrayList Proxy component is empty.")]
	public class ArrayListIsEmpty : ArrayListActions
	{
		// Token: 0x06003393 RID: 13203 RVA: 0x001362E0 File Offset: 0x001344E0
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
			this.isEmpty = null;
			this.isNotEmptyEvent = null;
			this.isEmptyEvent = null;
		}

		// Token: 0x06003394 RID: 13204 RVA: 0x00136308 File Offset: 0x00134508
		public override void OnEnter()
		{
			bool flag = base.GetArrayListProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value, true).arrayList.Count == 0;
			this.isEmpty.Value = flag;
			if (flag)
			{
				base.Fsm.Event(this.isEmptyEvent);
			}
			else
			{
				base.Fsm.Event(this.isNotEmptyEvent);
			}
			base.Finish();
		}

		// Token: 0x04003513 RID: 13587
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker ArrayList Proxy component")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003514 RID: 13588
		[Tooltip("Author defined Reference of the PlayMaker ArrayList Proxy component (necessary if several component coexists on the same GameObject)")]
		[UIHint(UIHint.FsmString)]
		public FsmString reference;

		// Token: 0x04003515 RID: 13589
		[ActionSection("Result")]
		[Tooltip("Store in a bool wether it is empty or not")]
		[UIHint(UIHint.Variable)]
		public FsmBool isEmpty;

		// Token: 0x04003516 RID: 13590
		[Tooltip("Event sent if this arrayList is empty ")]
		[UIHint(UIHint.FsmEvent)]
		public FsmEvent isEmptyEvent;

		// Token: 0x04003517 RID: 13591
		[Tooltip("Event sent if this arrayList is not empty")]
		[UIHint(UIHint.FsmEvent)]
		public FsmEvent isNotEmptyEvent;
	}
}
