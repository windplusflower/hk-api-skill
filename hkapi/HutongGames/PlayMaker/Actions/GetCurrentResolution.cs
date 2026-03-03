using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000955 RID: 2389
	[ActionCategory(ActionCategory.Application)]
	[Tooltip("Get the current resolution")]
	public class GetCurrentResolution : FsmStateAction
	{
		// Token: 0x06003490 RID: 13456 RVA: 0x00139B9D File Offset: 0x00137D9D
		public override void Reset()
		{
			this.width = null;
			this.height = null;
			this.refreshRate = null;
			this.currentResolution = null;
		}

		// Token: 0x06003491 RID: 13457 RVA: 0x00139BBC File Offset: 0x00137DBC
		public override void OnEnter()
		{
			this.width.Value = (float)Screen.currentResolution.width;
			this.height.Value = (float)Screen.currentResolution.height;
			this.refreshRate.Value = (float)Screen.currentResolution.refreshRate;
			this.currentResolution.Value = new Vector3((float)Screen.currentResolution.width, (float)Screen.currentResolution.height, (float)Screen.currentResolution.refreshRate);
			base.Finish();
		}

		// Token: 0x0400363A RID: 13882
		[Tooltip("The current resolution width")]
		[UIHint(UIHint.Variable)]
		public FsmFloat width;

		// Token: 0x0400363B RID: 13883
		[Tooltip("The current resolution height")]
		[UIHint(UIHint.Variable)]
		public FsmFloat height;

		// Token: 0x0400363C RID: 13884
		[Tooltip("The current resolution refrehs rate")]
		[UIHint(UIHint.Variable)]
		public FsmFloat refreshRate;

		// Token: 0x0400363D RID: 13885
		[Tooltip("The current resolution ( width, height, refreshRate )")]
		[UIHint(UIHint.Variable)]
		public FsmVector3 currentResolution;
	}
}
