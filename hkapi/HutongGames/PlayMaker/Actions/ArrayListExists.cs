using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000913 RID: 2323
	[ActionCategory("ArrayMaker/ArrayList")]
	[Tooltip("Check if an ArrayList Proxy component exists.")]
	public class ArrayListExists : ArrayListActions
	{
		// Token: 0x06003376 RID: 13174 RVA: 0x001358FB File Offset: 0x00133AFB
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
			this.doesExists = null;
			this.doesExistsEvent = null;
			this.doesNotExistsEvent = null;
		}

		// Token: 0x06003377 RID: 13175 RVA: 0x00135920 File Offset: 0x00133B20
		public override void OnEnter()
		{
			bool flag = base.GetArrayListProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value, true) != null;
			this.doesExists.Value = flag;
			if (flag)
			{
				base.Fsm.Event(this.doesExistsEvent);
			}
			else
			{
				base.Fsm.Event(this.doesNotExistsEvent);
			}
			base.Finish();
		}

		// Token: 0x040034DF RID: 13535
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker ArrayList Proxy component")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040034E0 RID: 13536
		[Tooltip("Author defined Reference of the PlayMaker ArrayList Proxy component (necessary if several component coexists on the same GameObject)")]
		[UIHint(UIHint.FsmString)]
		public FsmString reference;

		// Token: 0x040034E1 RID: 13537
		[ActionSection("Result")]
		[Tooltip("Store in a bool wether it exists or not")]
		[UIHint(UIHint.Variable)]
		public FsmBool doesExists;

		// Token: 0x040034E2 RID: 13538
		[Tooltip("Event sent if this arrayList exists ")]
		[UIHint(UIHint.FsmEvent)]
		public FsmEvent doesExistsEvent;

		// Token: 0x040034E3 RID: 13539
		[Tooltip("Event sent if this arrayList does not exists")]
		[UIHint(UIHint.FsmEvent)]
		public FsmEvent doesNotExistsEvent;
	}
}
