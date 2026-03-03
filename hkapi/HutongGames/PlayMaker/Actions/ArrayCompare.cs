using System;
using System.Linq;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B13 RID: 2835
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Tests if 2 Array Variables have the same values.")]
	public class ArrayCompare : FsmStateAction
	{
		// Token: 0x06003CD2 RID: 15570 RVA: 0x0015EEB3 File Offset: 0x0015D0B3
		public override void Reset()
		{
			this.array1 = null;
			this.array2 = null;
			this.SequenceEqual = null;
			this.SequenceNotEqual = null;
		}

		// Token: 0x06003CD3 RID: 15571 RVA: 0x0015EED1 File Offset: 0x0015D0D1
		public override void OnEnter()
		{
			this.DoSequenceEqual();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003CD4 RID: 15572 RVA: 0x0015EEE8 File Offset: 0x0015D0E8
		private void DoSequenceEqual()
		{
			if (this.array1.Values == null || this.array2.Values == null)
			{
				return;
			}
			this.storeResult.Value = this.array1.Values.SequenceEqual(this.array2.Values);
			base.Fsm.Event(this.storeResult.Value ? this.SequenceEqual : this.SequenceNotEqual);
		}

		// Token: 0x040040D4 RID: 16596
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The first Array Variable to test.")]
		public FsmArray array1;

		// Token: 0x040040D5 RID: 16597
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The second Array Variable to test.")]
		public FsmArray array2;

		// Token: 0x040040D6 RID: 16598
		[Tooltip("Event to send if the 2 arrays have the same values.")]
		public FsmEvent SequenceEqual;

		// Token: 0x040040D7 RID: 16599
		[Tooltip("Event to send if the 2 arrays have different values.")]
		public FsmEvent SequenceNotEqual;

		// Token: 0x040040D8 RID: 16600
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in a Bool variable.")]
		public FsmBool storeResult;

		// Token: 0x040040D9 RID: 16601
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;
	}
}
