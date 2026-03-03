using System;
using System.Collections.Generic;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B1C RID: 2844
	[ActionCategory(ActionCategory.Array)]
	[Tooltip("Reverse the order of items in an Array.")]
	public class ArrayReverse : FsmStateAction
	{
		// Token: 0x06003CFE RID: 15614 RVA: 0x0015F5F5 File Offset: 0x0015D7F5
		public override void Reset()
		{
			this.array = null;
		}

		// Token: 0x06003CFF RID: 15615 RVA: 0x0015F600 File Offset: 0x0015D800
		public override void OnEnter()
		{
			List<object> list = new List<object>(this.array.Values);
			list.Reverse();
			this.array.Values = list.ToArray();
			base.Finish();
		}

		// Token: 0x040040FE RID: 16638
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Array to reverse.")]
		public FsmArray array;
	}
}
