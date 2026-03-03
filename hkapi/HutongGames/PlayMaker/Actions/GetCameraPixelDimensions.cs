using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009D0 RID: 2512
	[ActionCategory(ActionCategory.Camera)]
	[Tooltip("Sets the value of a Float Variable.")]
	public class GetCameraPixelDimensions : FsmStateAction
	{
		// Token: 0x060036F2 RID: 14066 RVA: 0x00143F7E File Offset: 0x0014217E
		public override void Reset()
		{
			this.cameraWidth = null;
			this.cameraHeight = null;
			this.everyFrame = false;
		}

		// Token: 0x060036F3 RID: 14067 RVA: 0x00143F95 File Offset: 0x00142195
		public override void OnEnter()
		{
			this.DoGetCamera();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060036F4 RID: 14068 RVA: 0x00143FAB File Offset: 0x001421AB
		public override void OnUpdate()
		{
			this.DoGetCamera();
		}

		// Token: 0x060036F5 RID: 14069 RVA: 0x00003603 File Offset: 0x00001803
		private void DoGetCamera()
		{
		}

		// Token: 0x0400390E RID: 14606
		[UIHint(UIHint.Variable)]
		public FsmFloat cameraWidth;

		// Token: 0x0400390F RID: 14607
		[UIHint(UIHint.Variable)]
		public FsmFloat cameraHeight;

		// Token: 0x04003910 RID: 14608
		public bool everyFrame;
	}
}
