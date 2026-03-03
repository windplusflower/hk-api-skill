using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C76 RID: 3190
	[ActionCategory(ActionCategory.Input)]
	[Tooltip("Resets all Input. After ResetInputAxes all axes return to 0 and all buttons return to 0 for one frame")]
	public class ResetInputAxes : FsmStateAction
	{
		// Token: 0x060042A8 RID: 17064 RVA: 0x00003603 File Offset: 0x00001803
		public override void Reset()
		{
		}

		// Token: 0x060042A9 RID: 17065 RVA: 0x00170B66 File Offset: 0x0016ED66
		public override void OnEnter()
		{
			Input.ResetInputAxes();
			base.Finish();
		}
	}
}
