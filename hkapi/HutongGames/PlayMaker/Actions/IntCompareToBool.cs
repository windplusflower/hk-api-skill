using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009E7 RID: 2535
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Compares two ints and sets a bool value depending on result")]
	public class IntCompareToBool : FsmStateAction
	{
		// Token: 0x06003756 RID: 14166 RVA: 0x001465CE File Offset: 0x001447CE
		public override void Reset()
		{
			this.integer1 = 0;
			this.integer2 = 0;
			this.equalBool = null;
			this.lessThanBool = null;
			this.greaterThanBool = null;
			this.everyFrame = false;
		}

		// Token: 0x06003757 RID: 14167 RVA: 0x00146604 File Offset: 0x00144804
		public override void OnEnter()
		{
			this.DoIntCompare();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003758 RID: 14168 RVA: 0x0014661A File Offset: 0x0014481A
		public override void OnUpdate()
		{
			this.DoIntCompare();
		}

		// Token: 0x06003759 RID: 14169 RVA: 0x00146624 File Offset: 0x00144824
		private void DoIntCompare()
		{
			if (!this.equalBool.IsNone)
			{
				if (this.integer1.Value == this.integer2.Value)
				{
					this.equalBool.Value = true;
				}
				else
				{
					this.equalBool.Value = false;
				}
			}
			if (!this.lessThanBool.IsNone)
			{
				if (this.integer1.Value < this.integer2.Value)
				{
					this.lessThanBool.Value = true;
				}
				else
				{
					this.lessThanBool.Value = false;
				}
			}
			if (!this.greaterThanBool.IsNone)
			{
				if (this.integer1.Value > this.integer2.Value)
				{
					this.greaterThanBool.Value = true;
					return;
				}
				this.greaterThanBool.Value = false;
			}
		}

		// Token: 0x04003994 RID: 14740
		[RequiredField]
		public FsmInt integer1;

		// Token: 0x04003995 RID: 14741
		[RequiredField]
		public FsmInt integer2;

		// Token: 0x04003996 RID: 14742
		[Tooltip("Bool set if Int 1 equals Int 2")]
		[UIHint(UIHint.Variable)]
		public FsmBool equalBool;

		// Token: 0x04003997 RID: 14743
		[Tooltip("Bool set if Int 1 is less than Int 2")]
		[UIHint(UIHint.Variable)]
		public FsmBool lessThanBool;

		// Token: 0x04003998 RID: 14744
		[Tooltip("Bool set if Int 1 is greater than Int 2")]
		[UIHint(UIHint.Variable)]
		public FsmBool greaterThanBool;

		// Token: 0x04003999 RID: 14745
		public bool everyFrame;
	}
}
