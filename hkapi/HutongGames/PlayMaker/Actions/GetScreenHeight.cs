using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C11 RID: 3089
	[ActionCategory(ActionCategory.Application)]
	[Tooltip("Gets the Height of the Screen in pixels.")]
	public class GetScreenHeight : FsmStateAction
	{
		// Token: 0x060040D5 RID: 16597 RVA: 0x0016B1CD File Offset: 0x001693CD
		public override void Reset()
		{
			this.storeScreenHeight = null;
		}

		// Token: 0x060040D6 RID: 16598 RVA: 0x0016B1D6 File Offset: 0x001693D6
		public override void OnEnter()
		{
			this.storeScreenHeight.Value = (float)Screen.height;
			base.Finish();
		}

		// Token: 0x04004522 RID: 17698
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmFloat storeScreenHeight;
	}
}
