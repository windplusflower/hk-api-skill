using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B0E RID: 2830
	[ActionCategory(ActionCategory.Application)]
	[Tooltip("Quits the player application.")]
	public class ApplicationQuit : FsmStateAction
	{
		// Token: 0x06003CC1 RID: 15553 RVA: 0x00003603 File Offset: 0x00001803
		public override void Reset()
		{
		}

		// Token: 0x06003CC2 RID: 15554 RVA: 0x0015ECDA File Offset: 0x0015CEDA
		public override void OnEnter()
		{
			Application.Quit();
			base.Finish();
		}
	}
}
