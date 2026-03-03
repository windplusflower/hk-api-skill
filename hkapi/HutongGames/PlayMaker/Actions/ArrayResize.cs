using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B1B RID: 2843
	[ActionCategory(ActionCategory.Array)]
	[Tooltip("Resize an array.")]
	public class ArrayResize : FsmStateAction
	{
		// Token: 0x06003CFC RID: 15612 RVA: 0x0015F588 File Offset: 0x0015D788
		public override void OnEnter()
		{
			if (this.newSize.Value >= 0)
			{
				this.array.Resize(this.newSize.Value);
			}
			else
			{
				base.LogError("Size out of range: " + this.newSize.Value.ToString());
				base.Fsm.Event(this.sizeOutOfRangeEvent);
			}
			base.Finish();
		}

		// Token: 0x040040FB RID: 16635
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Array Variable to resize")]
		public FsmArray array;

		// Token: 0x040040FC RID: 16636
		[Tooltip("The new size of the array.")]
		public FsmInt newSize;

		// Token: 0x040040FD RID: 16637
		[Tooltip("The event to trigger if the new size is out of range")]
		public FsmEvent sizeOutOfRangeEvent;
	}
}
