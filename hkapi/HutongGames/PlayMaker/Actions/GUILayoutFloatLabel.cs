using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BB3 RID: 2995
	[ActionCategory(ActionCategory.GUILayout)]
	[Tooltip("GUILayout Label for a Float Variable.")]
	public class GUILayoutFloatLabel : GUILayoutAction
	{
		// Token: 0x06003F4D RID: 16205 RVA: 0x00166BF5 File Offset: 0x00164DF5
		public override void Reset()
		{
			base.Reset();
			this.prefix = "";
			this.style = "";
			this.floatVariable = null;
		}

		// Token: 0x06003F4E RID: 16206 RVA: 0x00166C24 File Offset: 0x00164E24
		public override void OnGUI()
		{
			if (string.IsNullOrEmpty(this.style.Value))
			{
				GUILayout.Label(new GUIContent(this.prefix.Value + this.floatVariable.Value.ToString()), base.LayoutOptions);
				return;
			}
			GUILayout.Label(new GUIContent(this.prefix.Value + this.floatVariable.Value.ToString()), this.style.Value, base.LayoutOptions);
		}

		// Token: 0x0400436B RID: 17259
		[Tooltip("Text to put before the float variable.")]
		public FsmString prefix;

		// Token: 0x0400436C RID: 17260
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Float variable to display.")]
		public FsmFloat floatVariable;

		// Token: 0x0400436D RID: 17261
		[Tooltip("Optional GUIStyle in the active GUISKin.")]
		public FsmString style;
	}
}
