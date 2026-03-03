using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009C9 RID: 2505
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("Multiplies one Float by another.")]
	public class FloatMultiplyV2 : FsmStateAction
	{
		// Token: 0x060036CF RID: 14031 RVA: 0x001439B6 File Offset: 0x00141BB6
		public override void Reset()
		{
			this.floatVariable = null;
			this.multiplyBy = null;
			this.everyFrame = false;
			this.fixedUpdate = false;
		}

		// Token: 0x060036D0 RID: 14032 RVA: 0x00070581 File Offset: 0x0006E781
		public override void OnPreprocess()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x060036D1 RID: 14033 RVA: 0x001439D4 File Offset: 0x00141BD4
		public override void OnEnter()
		{
			this.floatVariable.Value *= this.multiplyBy.Value;
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060036D2 RID: 14034 RVA: 0x00143A01 File Offset: 0x00141C01
		public override void OnUpdate()
		{
			if (!this.fixedUpdate)
			{
				this.floatVariable.Value *= this.multiplyBy.Value;
			}
		}

		// Token: 0x060036D3 RID: 14035 RVA: 0x00143A28 File Offset: 0x00141C28
		public override void OnFixedUpdate()
		{
			if (this.fixedUpdate)
			{
				this.floatVariable.Value *= this.multiplyBy.Value;
			}
		}

		// Token: 0x040038EB RID: 14571
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The float variable to multiply.")]
		public FsmFloat floatVariable;

		// Token: 0x040038EC RID: 14572
		[RequiredField]
		[Tooltip("Multiply the float variable by this value.")]
		public FsmFloat multiplyBy;

		// Token: 0x040038ED RID: 14573
		[Tooltip("Repeat every frame. Useful if the variables are changing.")]
		public bool everyFrame;

		// Token: 0x040038EE RID: 14574
		public bool fixedUpdate;
	}
}
