using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B11 RID: 2833
	[ActionCategory(ActionCategory.Array)]
	[Tooltip("Add values to an array.")]
	public class ArrayAddRange : FsmStateAction
	{
		// Token: 0x06003CCB RID: 15563 RVA: 0x0015ED8B File Offset: 0x0015CF8B
		public override void Reset()
		{
			this.array = null;
			this.variables = new FsmVar[2];
		}

		// Token: 0x06003CCC RID: 15564 RVA: 0x0015EDA0 File Offset: 0x0015CFA0
		public override void OnEnter()
		{
			this.DoAddRange();
			base.Finish();
		}

		// Token: 0x06003CCD RID: 15565 RVA: 0x0015EDB0 File Offset: 0x0015CFB0
		private void DoAddRange()
		{
			int num = this.variables.Length;
			if (num > 0)
			{
				this.array.Resize(this.array.Length + num);
				foreach (FsmVar fsmVar in this.variables)
				{
					fsmVar.UpdateValue();
					this.array.Set(this.array.Length - num, fsmVar.GetValue());
					num--;
				}
			}
		}

		// Token: 0x040040D0 RID: 16592
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Array Variable to use.")]
		public FsmArray array;

		// Token: 0x040040D1 RID: 16593
		[RequiredField]
		[MatchElementType("array")]
		[Tooltip("The variables to add.")]
		public FsmVar[] variables;
	}
}
