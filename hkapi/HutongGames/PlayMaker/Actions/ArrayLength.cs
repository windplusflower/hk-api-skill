using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B1A RID: 2842
	[ActionCategory(ActionCategory.Array)]
	[Tooltip("Gets the number of items in an Array.")]
	public class ArrayLength : FsmStateAction
	{
		// Token: 0x06003CF8 RID: 15608 RVA: 0x0015F533 File Offset: 0x0015D733
		public override void Reset()
		{
			this.array = null;
			this.length = null;
			this.everyFrame = false;
		}

		// Token: 0x06003CF9 RID: 15609 RVA: 0x0015F54A File Offset: 0x0015D74A
		public override void OnEnter()
		{
			this.length.Value = this.array.Length;
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003CFA RID: 15610 RVA: 0x0015F570 File Offset: 0x0015D770
		public override void OnUpdate()
		{
			this.length.Value = this.array.Length;
		}

		// Token: 0x040040F8 RID: 16632
		[UIHint(UIHint.Variable)]
		[Tooltip("The Array Variable.")]
		public FsmArray array;

		// Token: 0x040040F9 RID: 16633
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the length in an Int Variable.")]
		public FsmInt length;

		// Token: 0x040040FA RID: 16634
		[Tooltip("Repeat every frame. Useful if the array is changing and you're waiting for a particular length.")]
		public bool everyFrame;
	}
}
