using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000956 RID: 2390
	[ActionCategory(ActionCategory.Application)]
	[Tooltip("Set the resolution")]
	public class ScreenSetResolution : FsmStateAction
	{
		// Token: 0x06003493 RID: 13459 RVA: 0x00139C54 File Offset: 0x00137E54
		public override void Reset()
		{
			this.width = null;
			this.height = null;
			this.preferedRefreshRate = new FsmInt();
			this.preferedRefreshRate.UseVariable = true;
			this.orResolution = null;
			this.fullScreen = null;
		}

		// Token: 0x06003494 RID: 13460 RVA: 0x00139C8C File Offset: 0x00137E8C
		public override void OnEnter()
		{
			if (!this.orResolution.IsNone)
			{
				if (this.preferedRefreshRate.IsNone)
				{
					Screen.SetResolution((int)this.orResolution.Value.x, (int)this.orResolution.Value.y, this.fullScreen.Value);
				}
				else
				{
					Screen.SetResolution((int)this.orResolution.Value.x, (int)this.orResolution.Value.y, this.fullScreen.Value, (int)this.orResolution.Value.z);
				}
			}
			else if (this.preferedRefreshRate.IsNone)
			{
				Screen.SetResolution(this.width.Value, this.height.Value, this.fullScreen.Value);
			}
			else
			{
				Screen.SetResolution(this.width.Value, this.height.Value, this.fullScreen.Value, this.preferedRefreshRate.Value);
			}
			base.Finish();
		}

		// Token: 0x0400363E RID: 13886
		[Tooltip("Full Screen mode")]
		public FsmBool fullScreen;

		// Token: 0x0400363F RID: 13887
		[Tooltip("The resolution width")]
		public FsmInt width;

		// Token: 0x04003640 RID: 13888
		[Tooltip("The resolution height")]
		public FsmInt height;

		// Token: 0x04003641 RID: 13889
		[Tooltip("The current resolution refresh rate")]
		[UIHint(UIHint.Variable)]
		public FsmInt preferedRefreshRate;

		// Token: 0x04003642 RID: 13890
		[Tooltip("The current resolution ( width, height, refreshRate )")]
		[UIHint(UIHint.Variable)]
		public FsmVector3 orResolution;
	}
}
