using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B93 RID: 2963
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("Subtracts a value from a Float Variable.")]
	public class FloatSubtract : FsmStateAction
	{
		// Token: 0x06003EE5 RID: 16101 RVA: 0x0016579A File Offset: 0x0016399A
		public override void Reset()
		{
			this.floatVariable = null;
			this.subtract = null;
			this.everyFrame = false;
			this.perSecond = false;
		}

		// Token: 0x06003EE6 RID: 16102 RVA: 0x001657B8 File Offset: 0x001639B8
		public override void OnEnter()
		{
			this.DoFloatSubtract();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003EE7 RID: 16103 RVA: 0x001657CE File Offset: 0x001639CE
		public override void OnUpdate()
		{
			this.DoFloatSubtract();
		}

		// Token: 0x06003EE8 RID: 16104 RVA: 0x001657D8 File Offset: 0x001639D8
		private void DoFloatSubtract()
		{
			if (!this.perSecond)
			{
				this.floatVariable.Value -= this.subtract.Value;
				return;
			}
			this.floatVariable.Value -= this.subtract.Value * Time.deltaTime;
		}

		// Token: 0x040042F7 RID: 17143
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The float variable to subtract from.")]
		public FsmFloat floatVariable;

		// Token: 0x040042F8 RID: 17144
		[RequiredField]
		[Tooltip("Value to subtract from the float variable.")]
		public FsmFloat subtract;

		// Token: 0x040042F9 RID: 17145
		[Tooltip("Repeat every frame while the state is active.")]
		public bool everyFrame;

		// Token: 0x040042FA RID: 17146
		[Tooltip("Used with Every Frame. Adds the value over one second to make the operation frame rate independent.")]
		public bool perSecond;
	}
}
