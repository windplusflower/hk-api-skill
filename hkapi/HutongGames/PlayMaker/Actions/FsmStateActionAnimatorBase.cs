using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B0B RID: 2827
	public abstract class FsmStateActionAnimatorBase : FsmStateAction
	{
		// Token: 0x06003CB7 RID: 15543
		public abstract void OnActionUpdate();

		// Token: 0x06003CB8 RID: 15544 RVA: 0x0015EC18 File Offset: 0x0015CE18
		public override void Reset()
		{
			this.everyFrame = false;
			this.everyFrameOption = FsmStateActionAnimatorBase.AnimatorFrameUpdateSelector.OnUpdate;
		}

		// Token: 0x06003CB9 RID: 15545 RVA: 0x0015EC28 File Offset: 0x0015CE28
		public override void OnPreprocess()
		{
			if (this.everyFrameOption == FsmStateActionAnimatorBase.AnimatorFrameUpdateSelector.OnAnimatorMove)
			{
				base.Fsm.HandleAnimatorMove = true;
			}
			if (this.everyFrameOption == FsmStateActionAnimatorBase.AnimatorFrameUpdateSelector.OnAnimatorIK)
			{
				base.Fsm.HandleAnimatorIK = true;
			}
		}

		// Token: 0x06003CBA RID: 15546 RVA: 0x0015EC54 File Offset: 0x0015CE54
		public override void OnUpdate()
		{
			if (this.everyFrameOption == FsmStateActionAnimatorBase.AnimatorFrameUpdateSelector.OnUpdate)
			{
				this.OnActionUpdate();
			}
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003CBB RID: 15547 RVA: 0x0015EC72 File Offset: 0x0015CE72
		public override void DoAnimatorMove()
		{
			if (this.everyFrameOption == FsmStateActionAnimatorBase.AnimatorFrameUpdateSelector.OnAnimatorMove)
			{
				this.OnActionUpdate();
			}
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003CBC RID: 15548 RVA: 0x0015EC91 File Offset: 0x0015CE91
		public override void DoAnimatorIK(int layerIndex)
		{
			this.IklayerIndex = layerIndex;
			if (this.everyFrameOption == FsmStateActionAnimatorBase.AnimatorFrameUpdateSelector.OnAnimatorIK)
			{
				this.OnActionUpdate();
			}
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x040040C5 RID: 16581
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		// Token: 0x040040C6 RID: 16582
		[Tooltip("Select when to perform the action, during OnUpdate, OnAnimatorMove, OnAnimatorIK")]
		public FsmStateActionAnimatorBase.AnimatorFrameUpdateSelector everyFrameOption;

		// Token: 0x040040C7 RID: 16583
		protected int IklayerIndex;

		// Token: 0x02000B0C RID: 2828
		public enum AnimatorFrameUpdateSelector
		{
			// Token: 0x040040C9 RID: 16585
			OnUpdate,
			// Token: 0x040040CA RID: 16586
			OnAnimatorMove,
			// Token: 0x040040CB RID: 16587
			OnAnimatorIK
		}
	}
}
