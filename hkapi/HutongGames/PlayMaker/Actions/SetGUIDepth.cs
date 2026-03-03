using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CBB RID: 3259
	[ActionCategory(ActionCategory.GUI)]
	[Tooltip("Sets the sorting depth of subsequent GUI elements.")]
	public class SetGUIDepth : FsmStateAction
	{
		// Token: 0x060043E8 RID: 17384 RVA: 0x00174944 File Offset: 0x00172B44
		public override void Reset()
		{
			this.depth = 0;
		}

		// Token: 0x060043E9 RID: 17385 RVA: 0x00174952 File Offset: 0x00172B52
		public override void OnPreprocess()
		{
			base.Fsm.HandleOnGUI = true;
		}

		// Token: 0x060043EA RID: 17386 RVA: 0x00174960 File Offset: 0x00172B60
		public override void OnGUI()
		{
			GUI.depth = this.depth.Value;
		}

		// Token: 0x04004854 RID: 18516
		[RequiredField]
		public FsmInt depth;
	}
}
