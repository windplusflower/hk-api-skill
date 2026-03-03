using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B17 RID: 2839
	[ActionCategory(ActionCategory.Array)]
	[Tooltip("Get a value at an index. Index must be between 0 and the number of items -1. First item is index 0.")]
	public class ArrayGet : FsmStateAction
	{
		// Token: 0x06003CEA RID: 15594 RVA: 0x0015F25C File Offset: 0x0015D45C
		public override void Reset()
		{
			this.array = null;
			this.index = null;
			this.everyFrame = false;
			this.storeValue = null;
			this.indexOutOfRange = null;
		}

		// Token: 0x06003CEB RID: 15595 RVA: 0x0015F281 File Offset: 0x0015D481
		public override void OnEnter()
		{
			this.DoGetValue();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003CEC RID: 15596 RVA: 0x0015F297 File Offset: 0x0015D497
		public override void OnUpdate()
		{
			this.DoGetValue();
		}

		// Token: 0x06003CED RID: 15597 RVA: 0x0015F2A0 File Offset: 0x0015D4A0
		private void DoGetValue()
		{
			if (this.array.IsNone || this.storeValue.IsNone)
			{
				return;
			}
			if (this.index.Value >= 0 && this.index.Value < this.array.Length)
			{
				this.storeValue.SetValue(this.array.Get(this.index.Value));
				return;
			}
			base.Fsm.Event(this.indexOutOfRange);
		}

		// Token: 0x040040E8 RID: 16616
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Array Variable to use.")]
		public FsmArray array;

		// Token: 0x040040E9 RID: 16617
		[Tooltip("The index into the array.")]
		public FsmInt index;

		// Token: 0x040040EA RID: 16618
		[RequiredField]
		[MatchElementType("array")]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the value in a variable.")]
		public FsmVar storeValue;

		// Token: 0x040040EB RID: 16619
		[Tooltip("Repeat every frame while the state is active.")]
		public bool everyFrame;

		// Token: 0x040040EC RID: 16620
		[ActionSection("Events")]
		[Tooltip("The event to trigger if the index is out of range")]
		public FsmEvent indexOutOfRange;
	}
}
