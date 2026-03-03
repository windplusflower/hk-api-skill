using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B0F RID: 2831
	[ActionCategory(ActionCategory.Application)]
	[Tooltip("Sets if the Application should play in the background. Useful for servers or testing network games on one machine.")]
	public class ApplicationRunInBackground : FsmStateAction
	{
		// Token: 0x06003CC4 RID: 15556 RVA: 0x0015ECE7 File Offset: 0x0015CEE7
		public override void Reset()
		{
			this.runInBackground = true;
		}

		// Token: 0x06003CC5 RID: 15557 RVA: 0x0015ECF5 File Offset: 0x0015CEF5
		public override void OnEnter()
		{
			Debug.LogError("PlayMaker runInBackground erroneously being set.");
			Application.runInBackground = this.runInBackground.Value;
			base.Finish();
		}

		// Token: 0x040040CD RID: 16589
		public FsmBool runInBackground;
	}
}
