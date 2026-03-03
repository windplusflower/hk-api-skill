using System;
using System.Collections.Generic;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B15 RID: 2837
	[ActionCategory(ActionCategory.Array)]
	[Tooltip("Delete the item at an index. Index must be between 0 and the number of items -1. First item is index 0.")]
	public class ArrayDeleteAt : FsmStateAction
	{
		// Token: 0x06003CDA RID: 15578 RVA: 0x0015F012 File Offset: 0x0015D212
		public override void Reset()
		{
			this.array = null;
			this.index = null;
			this.indexOutOfRangeEvent = null;
		}

		// Token: 0x06003CDB RID: 15579 RVA: 0x0015F029 File Offset: 0x0015D229
		public override void OnEnter()
		{
			this.DoDeleteAt();
			base.Finish();
		}

		// Token: 0x06003CDC RID: 15580 RVA: 0x0015F038 File Offset: 0x0015D238
		private void DoDeleteAt()
		{
			if (this.index.Value >= 0 && this.index.Value < this.array.Length)
			{
				List<object> list = new List<object>(this.array.Values);
				list.RemoveAt(this.index.Value);
				this.array.Values = list.ToArray();
				return;
			}
			base.Fsm.Event(this.indexOutOfRangeEvent);
		}

		// Token: 0x040040E0 RID: 16608
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Array Variable to use.")]
		public FsmArray array;

		// Token: 0x040040E1 RID: 16609
		[Tooltip("The index into the array.")]
		public FsmInt index;

		// Token: 0x040040E2 RID: 16610
		[ActionSection("Result")]
		[Tooltip("The event to trigger if the index is out of range")]
		public FsmEvent indexOutOfRangeEvent;
	}
}
