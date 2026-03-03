using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000936 RID: 2358
	[ActionCategory("ArrayMaker/HashTable")]
	[Tooltip("Check if an HashTable Proxy component exists.")]
	public class HashTableExists : ArrayListActions
	{
		// Token: 0x06003404 RID: 13316 RVA: 0x00137A0F File Offset: 0x00135C0F
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
			this.doesExists = null;
			this.doesExistsEvent = null;
			this.doesNotExistsEvent = null;
		}

		// Token: 0x06003405 RID: 13317 RVA: 0x00137A34 File Offset: 0x00135C34
		public override void OnEnter()
		{
			bool flag = base.GetHashTableProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value, true) != null;
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

		// Token: 0x04003591 RID: 13713
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker HashTable Proxy component")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003592 RID: 13714
		[Tooltip("Author defined Reference of the PlayMaker HashTable Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;

		// Token: 0x04003593 RID: 13715
		[ActionSection("Result")]
		[Tooltip("Store in a bool wether it exists or not")]
		[UIHint(UIHint.Variable)]
		public FsmBool doesExists;

		// Token: 0x04003594 RID: 13716
		[Tooltip("Event sent if this HashTable exists ")]
		[UIHint(UIHint.FsmEvent)]
		public FsmEvent doesExistsEvent;

		// Token: 0x04003595 RID: 13717
		[Tooltip("Event sent if this HashTable does not exists")]
		[UIHint(UIHint.FsmEvent)]
		public FsmEvent doesNotExistsEvent;
	}
}
