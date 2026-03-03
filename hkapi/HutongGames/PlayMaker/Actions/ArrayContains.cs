using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B14 RID: 2836
	[ActionCategory(ActionCategory.Array)]
	[Tooltip("Check if an Array contains a value. Optionally get its index.")]
	public class ArrayContains : FsmStateAction
	{
		// Token: 0x06003CD6 RID: 15574 RVA: 0x0015EF5C File Offset: 0x0015D15C
		public override void Reset()
		{
			this.array = null;
			this.value = null;
			this.index = null;
			this.isContained = null;
			this.isContainedEvent = null;
			this.isNotContainedEvent = null;
		}

		// Token: 0x06003CD7 RID: 15575 RVA: 0x0015EF88 File Offset: 0x0015D188
		public override void OnEnter()
		{
			this.DoCheckContainsValue();
			base.Finish();
		}

		// Token: 0x06003CD8 RID: 15576 RVA: 0x0015EF98 File Offset: 0x0015D198
		private void DoCheckContainsValue()
		{
			this.value.UpdateValue();
			int num = Array.IndexOf<object>(this.array.Values, this.value.GetValue());
			bool flag = num != -1;
			this.isContained.Value = flag;
			this.index.Value = num;
			if (flag)
			{
				base.Fsm.Event(this.isContainedEvent);
				return;
			}
			base.Fsm.Event(this.isNotContainedEvent);
		}

		// Token: 0x040040DA RID: 16602
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Array Variable to use.")]
		public FsmArray array;

		// Token: 0x040040DB RID: 16603
		[RequiredField]
		[MatchElementType("array")]
		[Tooltip("The value to check against in the array.")]
		public FsmVar value;

		// Token: 0x040040DC RID: 16604
		[ActionSection("Result")]
		[Tooltip("The index of the value in the array.")]
		[UIHint(UIHint.Variable)]
		public FsmInt index;

		// Token: 0x040040DD RID: 16605
		[Tooltip("Store in a bool whether it contains that element or not (described below)")]
		[UIHint(UIHint.Variable)]
		public FsmBool isContained;

		// Token: 0x040040DE RID: 16606
		[Tooltip("Event sent if the array contains that element (described below)")]
		public FsmEvent isContainedEvent;

		// Token: 0x040040DF RID: 16607
		[Tooltip("Event sent if the array does not contains that element (described below)")]
		public FsmEvent isNotContainedEvent;
	}
}
