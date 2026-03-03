using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C0D RID: 3085
	[ActionCategory(ActionCategory.Rect)]
	[Tooltip("Get the individual fields of a Rect Variable and store them in Float Variables.")]
	public class GetRectFields : FsmStateAction
	{
		// Token: 0x060040C2 RID: 16578 RVA: 0x0016AE67 File Offset: 0x00169067
		public override void Reset()
		{
			this.rectVariable = null;
			this.storeX = null;
			this.storeY = null;
			this.storeWidth = null;
			this.storeHeight = null;
			this.everyFrame = false;
		}

		// Token: 0x060040C3 RID: 16579 RVA: 0x0016AE93 File Offset: 0x00169093
		public override void OnEnter()
		{
			this.DoGetRectFields();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060040C4 RID: 16580 RVA: 0x0016AEA9 File Offset: 0x001690A9
		public override void OnUpdate()
		{
			this.DoGetRectFields();
		}

		// Token: 0x060040C5 RID: 16581 RVA: 0x0016AEB4 File Offset: 0x001690B4
		private void DoGetRectFields()
		{
			if (this.rectVariable.IsNone)
			{
				return;
			}
			this.storeX.Value = this.rectVariable.Value.x;
			this.storeY.Value = this.rectVariable.Value.y;
			this.storeWidth.Value = this.rectVariable.Value.width;
			this.storeHeight.Value = this.rectVariable.Value.height;
		}

		// Token: 0x0400450B RID: 17675
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmRect rectVariable;

		// Token: 0x0400450C RID: 17676
		[UIHint(UIHint.Variable)]
		public FsmFloat storeX;

		// Token: 0x0400450D RID: 17677
		[UIHint(UIHint.Variable)]
		public FsmFloat storeY;

		// Token: 0x0400450E RID: 17678
		[UIHint(UIHint.Variable)]
		public FsmFloat storeWidth;

		// Token: 0x0400450F RID: 17679
		[UIHint(UIHint.Variable)]
		public FsmFloat storeHeight;

		// Token: 0x04004510 RID: 17680
		public bool everyFrame;
	}
}
