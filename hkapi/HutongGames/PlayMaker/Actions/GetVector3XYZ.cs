using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C22 RID: 3106
	[ActionCategory(ActionCategory.Vector3)]
	[Tooltip("Get the XYZ channels of a Vector3 Variable and store them in Float Variables.")]
	public class GetVector3XYZ : FsmStateAction
	{
		// Token: 0x0600411D RID: 16669 RVA: 0x0016BB8C File Offset: 0x00169D8C
		public override void Reset()
		{
			this.vector3Variable = null;
			this.storeX = null;
			this.storeY = null;
			this.storeZ = null;
			this.everyFrame = false;
		}

		// Token: 0x0600411E RID: 16670 RVA: 0x0016BBB1 File Offset: 0x00169DB1
		public override void OnEnter()
		{
			this.DoGetVector3XYZ();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600411F RID: 16671 RVA: 0x0016BBC7 File Offset: 0x00169DC7
		public override void OnUpdate()
		{
			this.DoGetVector3XYZ();
		}

		// Token: 0x06004120 RID: 16672 RVA: 0x0016BBD0 File Offset: 0x00169DD0
		private void DoGetVector3XYZ()
		{
			if (this.vector3Variable == null)
			{
				return;
			}
			if (this.storeX != null)
			{
				this.storeX.Value = this.vector3Variable.Value.x;
			}
			if (this.storeY != null)
			{
				this.storeY.Value = this.vector3Variable.Value.y;
			}
			if (this.storeZ != null)
			{
				this.storeZ.Value = this.vector3Variable.Value.z;
			}
		}

		// Token: 0x04004563 RID: 17763
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmVector3 vector3Variable;

		// Token: 0x04004564 RID: 17764
		[UIHint(UIHint.Variable)]
		public FsmFloat storeX;

		// Token: 0x04004565 RID: 17765
		[UIHint(UIHint.Variable)]
		public FsmFloat storeY;

		// Token: 0x04004566 RID: 17766
		[UIHint(UIHint.Variable)]
		public FsmFloat storeZ;

		// Token: 0x04004567 RID: 17767
		public bool everyFrame;
	}
}
