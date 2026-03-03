using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C1D RID: 3101
	[ActionCategory(ActionCategory.Device)]
	[Tooltip("Gets the number of Touches.")]
	public class GetTouchCount : FsmStateAction
	{
		// Token: 0x06004105 RID: 16645 RVA: 0x0016B769 File Offset: 0x00169969
		public override void Reset()
		{
			this.storeCount = null;
			this.everyFrame = false;
		}

		// Token: 0x06004106 RID: 16646 RVA: 0x0016B779 File Offset: 0x00169979
		public override void OnEnter()
		{
			this.DoGetTouchCount();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004107 RID: 16647 RVA: 0x0016B78F File Offset: 0x0016998F
		public override void OnUpdate()
		{
			this.DoGetTouchCount();
		}

		// Token: 0x06004108 RID: 16648 RVA: 0x0016B797 File Offset: 0x00169997
		private void DoGetTouchCount()
		{
			this.storeCount.Value = Input.touchCount;
		}

		// Token: 0x0400454B RID: 17739
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmInt storeCount;

		// Token: 0x0400454C RID: 17740
		public bool everyFrame;
	}
}
