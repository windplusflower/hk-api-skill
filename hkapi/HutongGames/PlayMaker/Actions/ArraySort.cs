using System;
using System.Collections.Generic;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B1F RID: 2847
	[ActionCategory(ActionCategory.Array)]
	[Tooltip("Sort items in an Array.")]
	public class ArraySort : FsmStateAction
	{
		// Token: 0x06003D09 RID: 15625 RVA: 0x0015F7EE File Offset: 0x0015D9EE
		public override void Reset()
		{
			this.array = null;
		}

		// Token: 0x06003D0A RID: 15626 RVA: 0x0015F7F8 File Offset: 0x0015D9F8
		public override void OnEnter()
		{
			List<object> list = new List<object>(this.array.Values);
			list.Sort();
			this.array.Values = list.ToArray();
			base.Finish();
		}

		// Token: 0x04004107 RID: 16647
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Array to sort.")]
		public FsmArray array;
	}
}
