using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B1D RID: 2845
	[ActionCategory(ActionCategory.Array)]
	[Tooltip("Set the value at an index. Index must be between 0 and the number of items -1. First item is index 0.")]
	public class ArraySet : FsmStateAction
	{
		// Token: 0x06003D01 RID: 15617 RVA: 0x0015F63B File Offset: 0x0015D83B
		public override void Reset()
		{
			this.array = null;
			this.index = null;
			this.value = null;
			this.everyFrame = false;
			this.indexOutOfRange = null;
		}

		// Token: 0x06003D02 RID: 15618 RVA: 0x0015F660 File Offset: 0x0015D860
		public override void OnEnter()
		{
			this.DoGetValue();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003D03 RID: 15619 RVA: 0x0015F676 File Offset: 0x0015D876
		public override void OnUpdate()
		{
			this.DoGetValue();
		}

		// Token: 0x06003D04 RID: 15620 RVA: 0x0015F680 File Offset: 0x0015D880
		private void DoGetValue()
		{
			if (this.array.IsNone)
			{
				return;
			}
			if (this.index.Value >= 0 && this.index.Value < this.array.Length)
			{
				this.value.UpdateValue();
				this.array.Set(this.index.Value, this.value.GetValue());
				return;
			}
			base.Fsm.Event(this.indexOutOfRange);
		}

		// Token: 0x040040FF RID: 16639
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Array Variable to use.")]
		public FsmArray array;

		// Token: 0x04004100 RID: 16640
		[Tooltip("The index into the array.")]
		public FsmInt index;

		// Token: 0x04004101 RID: 16641
		[RequiredField]
		[MatchElementType("array")]
		[Tooltip("Set the value of the array at the specified index.")]
		public FsmVar value;

		// Token: 0x04004102 RID: 16642
		[Tooltip("Repeat every frame while the state is active.")]
		public bool everyFrame;

		// Token: 0x04004103 RID: 16643
		[ActionSection("Events")]
		[Tooltip("The event to trigger if the index is out of range")]
		public FsmEvent indexOutOfRange;
	}
}
