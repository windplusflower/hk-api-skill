using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C21 RID: 3105
	[ActionCategory(ActionCategory.Vector2)]
	[Tooltip("Get the XYZ channels of a Vector3 Variable and storew them in Float Variables.")]
	public class GetVector2XY : FsmStateAction
	{
		// Token: 0x06004118 RID: 16664 RVA: 0x0016BAF2 File Offset: 0x00169CF2
		public override void Reset()
		{
			this.vector2Variable = null;
			this.storeX = null;
			this.storeY = null;
			this.everyFrame = false;
		}

		// Token: 0x06004119 RID: 16665 RVA: 0x0016BB10 File Offset: 0x00169D10
		public override void OnEnter()
		{
			this.DoGetVector2XY();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600411A RID: 16666 RVA: 0x0016BB26 File Offset: 0x00169D26
		public override void OnUpdate()
		{
			this.DoGetVector2XY();
		}

		// Token: 0x0600411B RID: 16667 RVA: 0x0016BB30 File Offset: 0x00169D30
		private void DoGetVector2XY()
		{
			if (this.vector2Variable == null)
			{
				return;
			}
			if (this.storeX != null)
			{
				this.storeX.Value = this.vector2Variable.Value.x;
			}
			if (this.storeY != null)
			{
				this.storeY.Value = this.vector2Variable.Value.y;
			}
		}

		// Token: 0x0400455F RID: 17759
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmVector2 vector2Variable;

		// Token: 0x04004560 RID: 17760
		[UIHint(UIHint.Variable)]
		public FsmFloat storeX;

		// Token: 0x04004561 RID: 17761
		[UIHint(UIHint.Variable)]
		public FsmFloat storeY;

		// Token: 0x04004562 RID: 17762
		public bool everyFrame;
	}
}
