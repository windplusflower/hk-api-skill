using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B10 RID: 2832
	[ActionCategory(ActionCategory.Array)]
	[Tooltip("Add an item to the end of an Array.")]
	public class ArrayAdd : FsmStateAction
	{
		// Token: 0x06003CC7 RID: 15559 RVA: 0x0015ED17 File Offset: 0x0015CF17
		public override void Reset()
		{
			this.array = null;
			this.value = null;
		}

		// Token: 0x06003CC8 RID: 15560 RVA: 0x0015ED27 File Offset: 0x0015CF27
		public override void OnEnter()
		{
			this.DoAddValue();
			base.Finish();
		}

		// Token: 0x06003CC9 RID: 15561 RVA: 0x0015ED38 File Offset: 0x0015CF38
		private void DoAddValue()
		{
			this.array.Resize(this.array.Length + 1);
			this.value.UpdateValue();
			this.array.Set(this.array.Length - 1, this.value.GetValue());
		}

		// Token: 0x040040CE RID: 16590
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Array Variable to use.")]
		public FsmArray array;

		// Token: 0x040040CF RID: 16591
		[RequiredField]
		[MatchElementType("array")]
		[Tooltip("Item to add.")]
		public FsmVar value;
	}
}
