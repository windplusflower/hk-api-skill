using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CBC RID: 3260
	[ActionCategory(ActionCategory.GUI)]
	[Tooltip("Sets the GUISkin used by GUI elements.")]
	public class SetGUISkin : FsmStateAction
	{
		// Token: 0x060043EC RID: 17388 RVA: 0x00174972 File Offset: 0x00172B72
		public override void Reset()
		{
			this.skin = null;
			this.applyGlobally = true;
		}

		// Token: 0x060043ED RID: 17389 RVA: 0x00174987 File Offset: 0x00172B87
		public override void OnGUI()
		{
			if (this.skin != null)
			{
				GUI.skin = this.skin;
			}
			if (this.applyGlobally.Value)
			{
				PlayMakerGUI.GUISkin = this.skin;
				base.Finish();
			}
		}

		// Token: 0x04004855 RID: 18517
		[RequiredField]
		public GUISkin skin;

		// Token: 0x04004856 RID: 18518
		public FsmBool applyGlobally;
	}
}
