using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B4E RID: 2894
	[ActionCategory(ActionCategory.Convert)]
	[Tooltip("Converts a Bool value to a Color.")]
	public class ConvertBoolToColor : FsmStateAction
	{
		// Token: 0x06003DD1 RID: 15825 RVA: 0x00162B41 File Offset: 0x00160D41
		public override void Reset()
		{
			this.boolVariable = null;
			this.colorVariable = null;
			this.falseColor = Color.black;
			this.trueColor = Color.white;
			this.everyFrame = false;
		}

		// Token: 0x06003DD2 RID: 15826 RVA: 0x00162B78 File Offset: 0x00160D78
		public override void OnEnter()
		{
			this.DoConvertBoolToColor();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003DD3 RID: 15827 RVA: 0x00162B8E File Offset: 0x00160D8E
		public override void OnUpdate()
		{
			this.DoConvertBoolToColor();
		}

		// Token: 0x06003DD4 RID: 15828 RVA: 0x00162B96 File Offset: 0x00160D96
		private void DoConvertBoolToColor()
		{
			this.colorVariable.Value = (this.boolVariable.Value ? this.trueColor.Value : this.falseColor.Value);
		}

		// Token: 0x040041F1 RID: 16881
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Bool variable to test.")]
		public FsmBool boolVariable;

		// Token: 0x040041F2 RID: 16882
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Color variable to set based on the bool variable value.")]
		public FsmColor colorVariable;

		// Token: 0x040041F3 RID: 16883
		[Tooltip("Color if Bool variable is false.")]
		public FsmColor falseColor;

		// Token: 0x040041F4 RID: 16884
		[Tooltip("Color if Bool variable is true.")]
		public FsmColor trueColor;

		// Token: 0x040041F5 RID: 16885
		[Tooltip("Repeat every frame. Useful if the Bool variable is changing.")]
		public bool everyFrame;
	}
}
