using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B8C RID: 2956
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Sends Events based on the comparison of 2 Floats.")]
	public class FloatCompare : FsmStateAction
	{
		// Token: 0x06003EC8 RID: 16072 RVA: 0x001652AC File Offset: 0x001634AC
		public override void Reset()
		{
			this.float1 = 0f;
			this.float2 = 0f;
			this.tolerance = 0f;
			this.equal = null;
			this.lessThan = null;
			this.greaterThan = null;
			this.everyFrame = false;
		}

		// Token: 0x06003EC9 RID: 16073 RVA: 0x00165305 File Offset: 0x00163505
		public override void OnEnter()
		{
			this.DoCompare();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003ECA RID: 16074 RVA: 0x0016531B File Offset: 0x0016351B
		public override void OnUpdate()
		{
			this.DoCompare();
		}

		// Token: 0x06003ECB RID: 16075 RVA: 0x00165324 File Offset: 0x00163524
		private void DoCompare()
		{
			if (Mathf.Abs(this.float1.Value - this.float2.Value) <= this.tolerance.Value)
			{
				base.Fsm.Event(this.equal);
				return;
			}
			if (this.float1.Value < this.float2.Value)
			{
				base.Fsm.Event(this.lessThan);
				return;
			}
			if (this.float1.Value > this.float2.Value)
			{
				base.Fsm.Event(this.greaterThan);
			}
		}

		// Token: 0x06003ECC RID: 16076 RVA: 0x001653BF File Offset: 0x001635BF
		public override string ErrorCheck()
		{
			if (FsmEvent.IsNullOrEmpty(this.equal) && FsmEvent.IsNullOrEmpty(this.lessThan) && FsmEvent.IsNullOrEmpty(this.greaterThan))
			{
				return "Action sends no events!";
			}
			return "";
		}

		// Token: 0x040042D1 RID: 17105
		[RequiredField]
		[Tooltip("The first float variable.")]
		public FsmFloat float1;

		// Token: 0x040042D2 RID: 17106
		[RequiredField]
		[Tooltip("The second float variable.")]
		public FsmFloat float2;

		// Token: 0x040042D3 RID: 17107
		[RequiredField]
		[Tooltip("Tolerance for the Equal test (almost equal).\nNOTE: Floats that look the same are often not exactly the same, so you often need to use a small tolerance.")]
		public FsmFloat tolerance;

		// Token: 0x040042D4 RID: 17108
		[Tooltip("Event sent if Float 1 equals Float 2 (within Tolerance)")]
		public FsmEvent equal;

		// Token: 0x040042D5 RID: 17109
		[Tooltip("Event sent if Float 1 is less than Float 2")]
		public FsmEvent lessThan;

		// Token: 0x040042D6 RID: 17110
		[Tooltip("Event sent if Float 1 is greater than Float 2")]
		public FsmEvent greaterThan;

		// Token: 0x040042D7 RID: 17111
		[Tooltip("Repeat every frame. Useful if the variables are changing and you're waiting for a particular result.")]
		public bool everyFrame;
	}
}
