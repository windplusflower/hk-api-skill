using System;

namespace InControl
{
	// Token: 0x020006CD RID: 1741
	public class PlayerTwoAxisAction : TwoAxisInputControl
	{
		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x060029A4 RID: 10660 RVA: 0x000E73F1 File Offset: 0x000E55F1
		// (set) Token: 0x060029A5 RID: 10661 RVA: 0x000E73F9 File Offset: 0x000E55F9
		public bool InvertXAxis { get; set; }

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x060029A6 RID: 10662 RVA: 0x000E7402 File Offset: 0x000E5602
		// (set) Token: 0x060029A7 RID: 10663 RVA: 0x000E740A File Offset: 0x000E560A
		public bool InvertYAxis { get; set; }

		// Token: 0x14000067 RID: 103
		// (add) Token: 0x060029A8 RID: 10664 RVA: 0x000E7414 File Offset: 0x000E5614
		// (remove) Token: 0x060029A9 RID: 10665 RVA: 0x000E744C File Offset: 0x000E564C
		public event Action<BindingSourceType> OnLastInputTypeChanged;

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x060029AA RID: 10666 RVA: 0x000E7481 File Offset: 0x000E5681
		// (set) Token: 0x060029AB RID: 10667 RVA: 0x000E7489 File Offset: 0x000E5689
		public object UserData { get; set; }

		// Token: 0x060029AC RID: 10668 RVA: 0x000E7492 File Offset: 0x000E5692
		internal PlayerTwoAxisAction(PlayerAction negativeXAction, PlayerAction positiveXAction, PlayerAction negativeYAction, PlayerAction positiveYAction)
		{
			this.negativeXAction = negativeXAction;
			this.positiveXAction = positiveXAction;
			this.negativeYAction = negativeYAction;
			this.positiveYAction = positiveYAction;
			this.InvertXAxis = false;
			this.InvertYAxis = false;
			this.Raw = true;
		}

		// Token: 0x060029AD RID: 10669 RVA: 0x000E74CC File Offset: 0x000E56CC
		internal void Update(ulong updateTick, float deltaTime)
		{
			this.ProcessActionUpdate(this.negativeXAction);
			this.ProcessActionUpdate(this.positiveXAction);
			this.ProcessActionUpdate(this.negativeYAction);
			this.ProcessActionUpdate(this.positiveYAction);
			float x = Utility.ValueFromSides(this.negativeXAction, this.positiveXAction, this.InvertXAxis);
			float y = Utility.ValueFromSides(this.negativeYAction, this.positiveYAction, InputManager.InvertYAxis || this.InvertYAxis);
			base.UpdateWithAxes(x, y, updateTick, deltaTime);
		}

		// Token: 0x060029AE RID: 10670 RVA: 0x000E7564 File Offset: 0x000E5764
		private void ProcessActionUpdate(PlayerAction action)
		{
			BindingSourceType lastInputType = this.LastInputType;
			if (action.UpdateTick > base.UpdateTick)
			{
				base.UpdateTick = action.UpdateTick;
				lastInputType = action.LastInputType;
			}
			if (this.LastInputType != lastInputType)
			{
				this.LastInputType = lastInputType;
				if (this.OnLastInputTypeChanged != null)
				{
					this.OnLastInputTypeChanged(lastInputType);
				}
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x060029AF RID: 10671 RVA: 0x0000D576 File Offset: 0x0000B776
		// (set) Token: 0x060029B0 RID: 10672 RVA: 0x00003603 File Offset: 0x00001803
		[Obsolete("Please set this property on device controls directly. It does nothing here.")]
		public new float LowerDeadZone
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x060029B1 RID: 10673 RVA: 0x0000D576 File Offset: 0x0000B776
		// (set) Token: 0x060029B2 RID: 10674 RVA: 0x00003603 File Offset: 0x00001803
		[Obsolete("Please set this property on device controls directly. It does nothing here.")]
		public new float UpperDeadZone
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x04002FAA RID: 12202
		private PlayerAction negativeXAction;

		// Token: 0x04002FAB RID: 12203
		private PlayerAction positiveXAction;

		// Token: 0x04002FAC RID: 12204
		private PlayerAction negativeYAction;

		// Token: 0x04002FAD RID: 12205
		private PlayerAction positiveYAction;

		// Token: 0x04002FB0 RID: 12208
		public BindingSourceType LastInputType;
	}
}
