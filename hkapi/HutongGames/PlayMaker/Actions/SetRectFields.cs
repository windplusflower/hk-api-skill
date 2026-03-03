using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CDD RID: 3293
	[ActionCategory(ActionCategory.Rect)]
	[Tooltip("Sets the individual fields of a Rect Variable. To leave any field unchanged, set variable to 'None'.")]
	public class SetRectFields : FsmStateAction
	{
		// Token: 0x06004477 RID: 17527 RVA: 0x00175E14 File Offset: 0x00174014
		public override void Reset()
		{
			this.rectVariable = null;
			this.x = new FsmFloat
			{
				UseVariable = true
			};
			this.y = new FsmFloat
			{
				UseVariable = true
			};
			this.width = new FsmFloat
			{
				UseVariable = true
			};
			this.height = new FsmFloat
			{
				UseVariable = true
			};
			this.everyFrame = false;
		}

		// Token: 0x06004478 RID: 17528 RVA: 0x00175E77 File Offset: 0x00174077
		public override void OnEnter()
		{
			this.DoSetRectFields();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004479 RID: 17529 RVA: 0x00175E8D File Offset: 0x0017408D
		public override void OnUpdate()
		{
			this.DoSetRectFields();
		}

		// Token: 0x0600447A RID: 17530 RVA: 0x00175E98 File Offset: 0x00174098
		private void DoSetRectFields()
		{
			if (this.rectVariable.IsNone)
			{
				return;
			}
			Rect value = this.rectVariable.Value;
			if (!this.x.IsNone)
			{
				value.x = this.x.Value;
			}
			if (!this.y.IsNone)
			{
				value.y = this.y.Value;
			}
			if (!this.width.IsNone)
			{
				value.width = this.width.Value;
			}
			if (!this.height.IsNone)
			{
				value.height = this.height.Value;
			}
			this.rectVariable.Value = value;
		}

		// Token: 0x040048BE RID: 18622
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmRect rectVariable;

		// Token: 0x040048BF RID: 18623
		public FsmFloat x;

		// Token: 0x040048C0 RID: 18624
		public FsmFloat y;

		// Token: 0x040048C1 RID: 18625
		public FsmFloat width;

		// Token: 0x040048C2 RID: 18626
		public FsmFloat height;

		// Token: 0x040048C3 RID: 18627
		public bool everyFrame;
	}
}
