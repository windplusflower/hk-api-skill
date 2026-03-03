using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B18 RID: 2840
	[ActionCategory(ActionCategory.Array)]
	[Tooltip("Each time this action is called it gets the next item from a Array. \nThis lets you quickly loop through all the items of an array to perform actions on them.")]
	public class ArrayGetNext : FsmStateAction
	{
		// Token: 0x06003CEF RID: 15599 RVA: 0x0015F321 File Offset: 0x0015D521
		public override void Reset()
		{
			this.array = null;
			this.startIndex = null;
			this.endIndex = null;
			this.currentIndex = null;
			this.loopEvent = null;
			this.finishedEvent = null;
			this.result = null;
		}

		// Token: 0x06003CF0 RID: 15600 RVA: 0x0015F354 File Offset: 0x0015D554
		public override void OnEnter()
		{
			if (this.nextItemIndex == 0 && this.startIndex.Value > 0)
			{
				this.nextItemIndex = this.startIndex.Value;
			}
			this.DoGetNextItem();
			base.Finish();
		}

		// Token: 0x06003CF1 RID: 15601 RVA: 0x0015F38C File Offset: 0x0015D58C
		private void DoGetNextItem()
		{
			if (this.nextItemIndex >= this.array.Length)
			{
				this.nextItemIndex = 0;
				this.currentIndex.Value = this.array.Length - 1;
				base.Fsm.Event(this.finishedEvent);
				return;
			}
			this.result.SetValue(this.array.Get(this.nextItemIndex));
			if (this.nextItemIndex >= this.array.Length)
			{
				this.nextItemIndex = 0;
				this.currentIndex.Value = this.array.Length - 1;
				base.Fsm.Event(this.finishedEvent);
				return;
			}
			if (this.endIndex.Value > 0 && this.nextItemIndex >= this.endIndex.Value)
			{
				this.nextItemIndex = 0;
				this.currentIndex.Value = this.endIndex.Value;
				base.Fsm.Event(this.finishedEvent);
				return;
			}
			this.nextItemIndex++;
			this.currentIndex.Value = this.nextItemIndex - 1;
			if (this.loopEvent != null)
			{
				base.Fsm.Event(this.loopEvent);
			}
		}

		// Token: 0x040040ED RID: 16621
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Array Variable to use.")]
		public FsmArray array;

		// Token: 0x040040EE RID: 16622
		[Tooltip("From where to start iteration, leave as 0 to start from the beginning")]
		public FsmInt startIndex;

		// Token: 0x040040EF RID: 16623
		[Tooltip("When to end iteration, leave as 0 to iterate until the end")]
		public FsmInt endIndex;

		// Token: 0x040040F0 RID: 16624
		[Tooltip("Event to send to get the next item.")]
		public FsmEvent loopEvent;

		// Token: 0x040040F1 RID: 16625
		[Tooltip("Event to send when there are no more items.")]
		public FsmEvent finishedEvent;

		// Token: 0x040040F2 RID: 16626
		[ActionSection("Result")]
		[MatchElementType("array")]
		public FsmVar result;

		// Token: 0x040040F3 RID: 16627
		[UIHint(UIHint.Variable)]
		public FsmInt currentIndex;

		// Token: 0x040040F4 RID: 16628
		private int nextItemIndex;
	}
}
