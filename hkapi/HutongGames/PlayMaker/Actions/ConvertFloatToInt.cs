using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B53 RID: 2899
	[ActionCategory(ActionCategory.Convert)]
	[Tooltip("Converts a Float value to an Integer value.")]
	public class ConvertFloatToInt : FsmStateAction
	{
		// Token: 0x06003DEA RID: 15850 RVA: 0x00162DBB File Offset: 0x00160FBB
		public override void Reset()
		{
			this.floatVariable = null;
			this.intVariable = null;
			this.rounding = ConvertFloatToInt.FloatRounding.Nearest;
			this.everyFrame = false;
		}

		// Token: 0x06003DEB RID: 15851 RVA: 0x00162DD9 File Offset: 0x00160FD9
		public override void OnEnter()
		{
			this.DoConvertFloatToInt();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003DEC RID: 15852 RVA: 0x00162DEF File Offset: 0x00160FEF
		public override void OnUpdate()
		{
			this.DoConvertFloatToInt();
		}

		// Token: 0x06003DED RID: 15853 RVA: 0x00162DF8 File Offset: 0x00160FF8
		private void DoConvertFloatToInt()
		{
			switch (this.rounding)
			{
			case ConvertFloatToInt.FloatRounding.RoundDown:
				this.intVariable.Value = Mathf.FloorToInt(this.floatVariable.Value);
				return;
			case ConvertFloatToInt.FloatRounding.RoundUp:
				this.intVariable.Value = Mathf.CeilToInt(this.floatVariable.Value);
				return;
			case ConvertFloatToInt.FloatRounding.Nearest:
				this.intVariable.Value = Mathf.RoundToInt(this.floatVariable.Value);
				return;
			default:
				return;
			}
		}

		// Token: 0x04004208 RID: 16904
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Float variable to convert to an integer.")]
		public FsmFloat floatVariable;

		// Token: 0x04004209 RID: 16905
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in an Integer variable.")]
		public FsmInt intVariable;

		// Token: 0x0400420A RID: 16906
		public ConvertFloatToInt.FloatRounding rounding;

		// Token: 0x0400420B RID: 16907
		public bool everyFrame;

		// Token: 0x02000B54 RID: 2900
		public enum FloatRounding
		{
			// Token: 0x0400420D RID: 16909
			RoundDown,
			// Token: 0x0400420E RID: 16910
			RoundUp,
			// Token: 0x0400420F RID: 16911
			Nearest
		}
	}
}
