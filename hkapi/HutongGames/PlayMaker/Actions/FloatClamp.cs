using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B8B RID: 2955
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("Clamps the value of Float Variable to a Min/Max range.")]
	public class FloatClamp : FsmStateAction
	{
		// Token: 0x06003EC3 RID: 16067 RVA: 0x0016523A File Offset: 0x0016343A
		public override void Reset()
		{
			this.floatVariable = null;
			this.minValue = null;
			this.maxValue = null;
			this.everyFrame = false;
		}

		// Token: 0x06003EC4 RID: 16068 RVA: 0x00165258 File Offset: 0x00163458
		public override void OnEnter()
		{
			this.DoClamp();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003EC5 RID: 16069 RVA: 0x0016526E File Offset: 0x0016346E
		public override void OnUpdate()
		{
			this.DoClamp();
		}

		// Token: 0x06003EC6 RID: 16070 RVA: 0x00165276 File Offset: 0x00163476
		private void DoClamp()
		{
			this.floatVariable.Value = Mathf.Clamp(this.floatVariable.Value, this.minValue.Value, this.maxValue.Value);
		}

		// Token: 0x040042CD RID: 17101
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Float variable to clamp.")]
		public FsmFloat floatVariable;

		// Token: 0x040042CE RID: 17102
		[RequiredField]
		[Tooltip("The minimum value.")]
		public FsmFloat minValue;

		// Token: 0x040042CF RID: 17103
		[RequiredField]
		[Tooltip("The maximum value.")]
		public FsmFloat maxValue;

		// Token: 0x040042D0 RID: 17104
		[Tooltip("Repeate every frame. Useful if the float variable is changing.")]
		public bool everyFrame;
	}
}
