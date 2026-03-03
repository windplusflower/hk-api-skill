using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009C6 RID: 2502
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("Adds a value to a Float Variable.")]
	public class FloatAddV2 : FsmStateAction
	{
		// Token: 0x060036BC RID: 14012 RVA: 0x00143755 File Offset: 0x00141955
		public override void Reset()
		{
			this.floatVariable = null;
			this.add = null;
			this.everyFrame = false;
			this.perSecond = false;
			this.fixedUpdate = false;
			this.activeBool = false;
		}

		// Token: 0x060036BD RID: 14013 RVA: 0x00143786 File Offset: 0x00141986
		public override void Awake()
		{
			if (this.fixedUpdate)
			{
				base.Fsm.HandleFixedUpdate = true;
			}
		}

		// Token: 0x060036BE RID: 14014 RVA: 0x00070581 File Offset: 0x0006E781
		public override void OnPreprocess()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x060036BF RID: 14015 RVA: 0x0014379C File Offset: 0x0014199C
		public override void OnEnter()
		{
			this.DoFloatAdd();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060036C0 RID: 14016 RVA: 0x001437B2 File Offset: 0x001419B2
		public override void OnUpdate()
		{
			if (!this.fixedUpdate)
			{
				this.DoFloatAdd();
			}
		}

		// Token: 0x060036C1 RID: 14017 RVA: 0x001437C2 File Offset: 0x001419C2
		public override void OnFixedUpdate()
		{
			if (this.fixedUpdate)
			{
				this.DoFloatAdd();
			}
		}

		// Token: 0x060036C2 RID: 14018 RVA: 0x001437D4 File Offset: 0x001419D4
		private void DoFloatAdd()
		{
			if (this.activeBool.IsNone || this.activeBool.Value)
			{
				if (!this.perSecond)
				{
					this.floatVariable.Value += this.add.Value;
					return;
				}
				this.floatVariable.Value += this.add.Value * Time.deltaTime;
			}
		}

		// Token: 0x040038DA RID: 14554
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Float variable to add to.")]
		public FsmFloat floatVariable;

		// Token: 0x040038DB RID: 14555
		[RequiredField]
		[Tooltip("Amount to add.")]
		public FsmFloat add;

		// Token: 0x040038DC RID: 14556
		[Tooltip("Repeat every frame while the state is active.")]
		public bool everyFrame;

		// Token: 0x040038DD RID: 14557
		[Tooltip("Used with Every Frame. Adds the value over one second to make the operation frame rate independent.")]
		public bool perSecond;

		// Token: 0x040038DE RID: 14558
		public bool fixedUpdate;

		// Token: 0x040038DF RID: 14559
		[UIHint(UIHint.Variable)]
		public FsmBool activeBool;
	}
}
