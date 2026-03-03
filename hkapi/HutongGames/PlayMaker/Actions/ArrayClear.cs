using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B12 RID: 2834
	[ActionCategory(ActionCategory.Array)]
	[Tooltip("Sets all items in an Array to their default value: 0, empty string, false, or null depending on their type. Optionally defines a reset value to use.")]
	public class ArrayClear : FsmStateAction
	{
		// Token: 0x06003CCF RID: 15567 RVA: 0x0015EE23 File Offset: 0x0015D023
		public override void Reset()
		{
			this.array = null;
			this.resetValue = new FsmVar
			{
				useVariable = true
			};
		}

		// Token: 0x06003CD0 RID: 15568 RVA: 0x0015EE40 File Offset: 0x0015D040
		public override void OnEnter()
		{
			int length = this.array.Length;
			this.array.Reset();
			this.array.Resize(length);
			if (!this.resetValue.IsNone)
			{
				this.resetValue.UpdateValue();
				object value = this.resetValue.GetValue();
				for (int i = 0; i < length; i++)
				{
					this.array.Set(i, value);
				}
			}
			base.Finish();
		}

		// Token: 0x040040D2 RID: 16594
		[UIHint(UIHint.Variable)]
		[Tooltip("The Array Variable to clear.")]
		public FsmArray array;

		// Token: 0x040040D3 RID: 16595
		[MatchElementType("array")]
		[Tooltip("Optional reset value. Leave as None for default value.")]
		public FsmVar resetValue;
	}
}
