using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009C7 RID: 2503
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("Divides one Float by another.")]
	public class FloatDivideV2 : FsmStateAction
	{
		// Token: 0x060036C4 RID: 14020 RVA: 0x00143844 File Offset: 0x00141A44
		public override void Reset()
		{
			this.floatVariable = null;
			this.divideBy = null;
			this.everyFrame = false;
			this.fixedUpdate = false;
		}

		// Token: 0x060036C5 RID: 14021 RVA: 0x00143862 File Offset: 0x00141A62
		public override void OnEnter()
		{
			this.floatVariable.Value /= this.divideBy.Value;
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060036C6 RID: 14022 RVA: 0x00070581 File Offset: 0x0006E781
		public override void OnPreprocess()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x060036C7 RID: 14023 RVA: 0x0014388F File Offset: 0x00141A8F
		public override void OnUpdate()
		{
			if (!this.fixedUpdate)
			{
				this.floatVariable.Value /= this.divideBy.Value;
			}
		}

		// Token: 0x060036C8 RID: 14024 RVA: 0x001438B6 File Offset: 0x00141AB6
		public override void OnFixedUpdate()
		{
			if (this.fixedUpdate)
			{
				this.floatVariable.Value /= this.divideBy.Value;
			}
		}

		// Token: 0x040038E0 RID: 14560
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The float variable to divide.")]
		public FsmFloat floatVariable;

		// Token: 0x040038E1 RID: 14561
		[RequiredField]
		[Tooltip("Divide the float variable by this value.")]
		public FsmFloat divideBy;

		// Token: 0x040038E2 RID: 14562
		[Tooltip("Repeate every frame. Useful if the variables are changing.")]
		public bool everyFrame;

		// Token: 0x040038E3 RID: 14563
		public bool fixedUpdate;
	}
}
