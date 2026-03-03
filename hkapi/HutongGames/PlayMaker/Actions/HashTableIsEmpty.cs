using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200093B RID: 2363
	[ActionCategory("ArrayMaker/HashTable")]
	[Tooltip("Check if an HashTable Proxy component is empty.")]
	public class HashTableIsEmpty : ArrayListActions
	{
		// Token: 0x06003418 RID: 13336 RVA: 0x00137FB8 File Offset: 0x001361B8
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
			this.isEmpty = null;
			this.isEmptyEvent = null;
			this.isNotEmptyEvent = null;
		}

		// Token: 0x06003419 RID: 13337 RVA: 0x00137FE0 File Offset: 0x001361E0
		public override void OnEnter()
		{
			bool flag = base.GetHashTableProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value, true).hashTable.Count == 0;
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

		// Token: 0x040035B2 RID: 13746
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker HashTable Proxy component")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040035B3 RID: 13747
		[Tooltip("Author defined Reference of the PlayMaker HashTable Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;

		// Token: 0x040035B4 RID: 13748
		[ActionSection("Result")]
		[Tooltip("Store in a bool wether it is empty or not")]
		[UIHint(UIHint.Variable)]
		public FsmBool isEmpty;

		// Token: 0x040035B5 RID: 13749
		[Tooltip("Event sent if this HashTable is empty ")]
		[UIHint(UIHint.FsmEvent)]
		public FsmEvent isEmptyEvent;

		// Token: 0x040035B6 RID: 13750
		[Tooltip("Event sent if this HashTable is not empty")]
		[UIHint(UIHint.FsmEvent)]
		public FsmEvent isNotEmptyEvent;
	}
}
