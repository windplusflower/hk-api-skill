using System;

namespace InControl
{
	// Token: 0x020006CC RID: 1740
	public class PlayerOneAxisAction : OneAxisInputControl
	{
		// Token: 0x14000066 RID: 102
		// (add) Token: 0x06002999 RID: 10649 RVA: 0x000E72B0 File Offset: 0x000E54B0
		// (remove) Token: 0x0600299A RID: 10650 RVA: 0x000E72E8 File Offset: 0x000E54E8
		public event Action<BindingSourceType> OnLastInputTypeChanged;

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x0600299B RID: 10651 RVA: 0x000E731D File Offset: 0x000E551D
		// (set) Token: 0x0600299C RID: 10652 RVA: 0x000E7325 File Offset: 0x000E5525
		public object UserData { get; set; }

		// Token: 0x0600299D RID: 10653 RVA: 0x000E732E File Offset: 0x000E552E
		internal PlayerOneAxisAction(PlayerAction negativeAction, PlayerAction positiveAction)
		{
			this.negativeAction = negativeAction;
			this.positiveAction = positiveAction;
			this.Raw = true;
		}

		// Token: 0x0600299E RID: 10654 RVA: 0x000E734C File Offset: 0x000E554C
		internal void Update(ulong updateTick, float deltaTime)
		{
			this.ProcessActionUpdate(this.negativeAction);
			this.ProcessActionUpdate(this.positiveAction);
			float value = Utility.ValueFromSides(this.negativeAction, this.positiveAction);
			base.CommitWithValue(value, updateTick, deltaTime);
		}

		// Token: 0x0600299F RID: 10655 RVA: 0x000E7398 File Offset: 0x000E5598
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

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x060029A0 RID: 10656 RVA: 0x0000D576 File Offset: 0x0000B776
		// (set) Token: 0x060029A1 RID: 10657 RVA: 0x00003603 File Offset: 0x00001803
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

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x060029A2 RID: 10658 RVA: 0x0000D576 File Offset: 0x0000B776
		// (set) Token: 0x060029A3 RID: 10659 RVA: 0x00003603 File Offset: 0x00001803
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

		// Token: 0x04002FA5 RID: 12197
		private PlayerAction negativeAction;

		// Token: 0x04002FA6 RID: 12198
		private PlayerAction positiveAction;

		// Token: 0x04002FA7 RID: 12199
		public BindingSourceType LastInputType;
	}
}
