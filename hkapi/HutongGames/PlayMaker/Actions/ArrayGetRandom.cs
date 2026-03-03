using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B19 RID: 2841
	[ActionCategory(ActionCategory.Array)]
	[Tooltip("Get a Random item from an Array.")]
	public class ArrayGetRandom : FsmStateAction
	{
		// Token: 0x06003CF3 RID: 15603 RVA: 0x0015F4C7 File Offset: 0x0015D6C7
		public override void Reset()
		{
			this.array = null;
			this.storeValue = null;
			this.everyFrame = false;
		}

		// Token: 0x06003CF4 RID: 15604 RVA: 0x0015F4DE File Offset: 0x0015D6DE
		public override void OnEnter()
		{
			this.DoGetRandomValue();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003CF5 RID: 15605 RVA: 0x0015F4F4 File Offset: 0x0015D6F4
		public override void OnUpdate()
		{
			this.DoGetRandomValue();
		}

		// Token: 0x06003CF6 RID: 15606 RVA: 0x0015F4FC File Offset: 0x0015D6FC
		private void DoGetRandomValue()
		{
			if (this.storeValue.IsNone)
			{
				return;
			}
			this.storeValue.SetValue(this.array.Get(UnityEngine.Random.Range(0, this.array.Length)));
		}

		// Token: 0x040040F5 RID: 16629
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Array to use.")]
		public FsmArray array;

		// Token: 0x040040F6 RID: 16630
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the value in a variable.")]
		[MatchElementType("array")]
		public FsmVar storeValue;

		// Token: 0x040040F7 RID: 16631
		[Tooltip("Repeat every frame while the state is active.")]
		public bool everyFrame;
	}
}
