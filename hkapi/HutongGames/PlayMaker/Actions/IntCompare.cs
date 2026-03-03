using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C2E RID: 3118
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Sends Events based on the comparison of 2 Integers.")]
	public class IntCompare : FsmStateAction
	{
		// Token: 0x06004155 RID: 16725 RVA: 0x0016C3D1 File Offset: 0x0016A5D1
		public override void Reset()
		{
			this.integer1 = 0;
			this.integer2 = 0;
			this.equal = null;
			this.lessThan = null;
			this.greaterThan = null;
			this.everyFrame = false;
		}

		// Token: 0x06004156 RID: 16726 RVA: 0x0016C407 File Offset: 0x0016A607
		public override void OnEnter()
		{
			this.DoIntCompare();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004157 RID: 16727 RVA: 0x0016C41D File Offset: 0x0016A61D
		public override void OnUpdate()
		{
			this.DoIntCompare();
		}

		// Token: 0x06004158 RID: 16728 RVA: 0x0016C428 File Offset: 0x0016A628
		private void DoIntCompare()
		{
			if (this.integer1.Value == this.integer2.Value)
			{
				base.Fsm.Event(this.equal);
				return;
			}
			if (this.integer1.Value < this.integer2.Value)
			{
				base.Fsm.Event(this.lessThan);
				return;
			}
			if (this.integer1.Value > this.integer2.Value)
			{
				base.Fsm.Event(this.greaterThan);
			}
		}

		// Token: 0x06004159 RID: 16729 RVA: 0x0016C4B2 File Offset: 0x0016A6B2
		public override string ErrorCheck()
		{
			if (FsmEvent.IsNullOrEmpty(this.equal) && FsmEvent.IsNullOrEmpty(this.lessThan) && FsmEvent.IsNullOrEmpty(this.greaterThan))
			{
				return "Action sends no events!";
			}
			return "";
		}

		// Token: 0x04004594 RID: 17812
		[RequiredField]
		public FsmInt integer1;

		// Token: 0x04004595 RID: 17813
		[RequiredField]
		public FsmInt integer2;

		// Token: 0x04004596 RID: 17814
		[Tooltip("Event sent if Int 1 equals Int 2")]
		public FsmEvent equal;

		// Token: 0x04004597 RID: 17815
		[Tooltip("Event sent if Int 1 is less than Int 2")]
		public FsmEvent lessThan;

		// Token: 0x04004598 RID: 17816
		[Tooltip("Event sent if Int 1 is greater than Int 2")]
		public FsmEvent greaterThan;

		// Token: 0x04004599 RID: 17817
		public bool everyFrame;
	}
}
