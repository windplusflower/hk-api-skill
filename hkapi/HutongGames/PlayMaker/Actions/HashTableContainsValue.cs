using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000933 RID: 2355
	[ActionCategory("ArrayMaker/HashTable")]
	[Tooltip("Check if a value exists in a PlayMaker HashTable Proxy component (PlayMakerHashTablePRoxy)")]
	public class HashTableContainsValue : HashTableActions
	{
		// Token: 0x060033F8 RID: 13304 RVA: 0x001377A8 File Offset: 0x001359A8
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
			this.containsValue = null;
			this.valueFoundEvent = null;
			this.valueNotFoundEvent = null;
			this.variable = null;
		}

		// Token: 0x060033F9 RID: 13305 RVA: 0x001377D4 File Offset: 0x001359D4
		public override void OnEnter()
		{
			if (base.SetUpHashTableProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				this.doContainsValue();
			}
			base.Finish();
		}

		// Token: 0x060033FA RID: 13306 RVA: 0x00137808 File Offset: 0x00135A08
		public void doContainsValue()
		{
			if (!base.isProxyValid())
			{
				return;
			}
			this.containsValue.Value = this.proxy.hashTable.ContainsValue(PlayMakerUtils.GetValueFromFsmVar(base.Fsm, this.variable));
			if (this.containsValue.Value)
			{
				base.Fsm.Event(this.valueFoundEvent);
				return;
			}
			base.Fsm.Event(this.valueNotFoundEvent);
		}

		// Token: 0x04003582 RID: 13698
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker HashTable Proxy component")]
		[CheckForComponent(typeof(PlayMakerHashTableProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003583 RID: 13699
		[Tooltip("Author defined Reference of the PlayMaker HashTable Proxy component (necessary if several component coexists on the same GameObject)")]
		public FsmString reference;

		// Token: 0x04003584 RID: 13700
		[Tooltip("The variable to check for.")]
		public FsmVar variable;

		// Token: 0x04003585 RID: 13701
		[ActionSection("Result")]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result of the test")]
		public FsmBool containsValue;

		// Token: 0x04003586 RID: 13702
		[UIHint(UIHint.FsmEvent)]
		[Tooltip("The event to trigger when value is found")]
		public FsmEvent valueFoundEvent;

		// Token: 0x04003587 RID: 13703
		[UIHint(UIHint.FsmEvent)]
		[Tooltip("The event to trigger when value is not found")]
		public FsmEvent valueNotFoundEvent;
	}
}
