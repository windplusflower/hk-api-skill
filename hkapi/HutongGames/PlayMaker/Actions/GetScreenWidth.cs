using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C12 RID: 3090
	[ActionCategory(ActionCategory.Application)]
	[Tooltip("Gets the Width of the Screen in pixels.")]
	public class GetScreenWidth : FsmStateAction
	{
		// Token: 0x060040D8 RID: 16600 RVA: 0x0016B1EF File Offset: 0x001693EF
		public override void Reset()
		{
			this.storeScreenWidth = null;
		}

		// Token: 0x060040D9 RID: 16601 RVA: 0x0016B1F8 File Offset: 0x001693F8
		public override void OnEnter()
		{
			this.storeScreenWidth.Value = (float)Screen.width;
			base.Finish();
		}

		// Token: 0x04004523 RID: 17699
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmFloat storeScreenWidth;
	}
}
