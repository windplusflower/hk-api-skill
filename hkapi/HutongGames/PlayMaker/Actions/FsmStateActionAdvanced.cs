using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A79 RID: 2681
	public abstract class FsmStateActionAdvanced : FsmStateAction
	{
		// Token: 0x060039D1 RID: 14801
		public abstract void OnActionUpdate();

		// Token: 0x060039D2 RID: 14802 RVA: 0x0015173B File Offset: 0x0014F93B
		public override void Reset()
		{
			this.everyFrame = false;
			this.updateType = FsmStateActionAdvanced.FrameUpdateSelector.OnUpdate;
		}

		// Token: 0x060039D3 RID: 14803 RVA: 0x00130B3B File Offset: 0x0012ED3B
		public override void OnPreprocess()
		{
			base.OnPreprocess();
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x060039D4 RID: 14804 RVA: 0x0015174B File Offset: 0x0014F94B
		public override void OnUpdate()
		{
			if (this.updateType == FsmStateActionAdvanced.FrameUpdateSelector.OnUpdate)
			{
				this.OnActionUpdate();
			}
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060039D5 RID: 14805 RVA: 0x00151769 File Offset: 0x0014F969
		public override void OnLateUpdate()
		{
			if (this.updateType == FsmStateActionAdvanced.FrameUpdateSelector.OnLateUpdate)
			{
				this.OnActionUpdate();
			}
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060039D6 RID: 14806 RVA: 0x00151788 File Offset: 0x0014F988
		public override void OnFixedUpdate()
		{
			if (this.updateType == FsmStateActionAdvanced.FrameUpdateSelector.OnFixedUpdate)
			{
				this.OnActionUpdate();
			}
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x04003CE7 RID: 15591
		[ActionSection("Update type")]
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		// Token: 0x04003CE8 RID: 15592
		public FsmStateActionAdvanced.FrameUpdateSelector updateType;

		// Token: 0x02000A7A RID: 2682
		public enum FrameUpdateSelector
		{
			// Token: 0x04003CEA RID: 15594
			OnUpdate,
			// Token: 0x04003CEB RID: 15595
			OnLateUpdate,
			// Token: 0x04003CEC RID: 15596
			OnFixedUpdate
		}
	}
}
