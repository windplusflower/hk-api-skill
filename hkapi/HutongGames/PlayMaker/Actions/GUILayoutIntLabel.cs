using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BB6 RID: 2998
	[ActionCategory(ActionCategory.GUILayout)]
	[Tooltip("GUILayout Label for an Int Variable.")]
	public class GUILayoutIntLabel : GUILayoutAction
	{
		// Token: 0x06003F56 RID: 16214 RVA: 0x00166E51 File Offset: 0x00165051
		public override void Reset()
		{
			base.Reset();
			this.prefix = "";
			this.style = "";
			this.intVariable = null;
		}

		// Token: 0x06003F57 RID: 16215 RVA: 0x00166E80 File Offset: 0x00165080
		public override void OnGUI()
		{
			if (string.IsNullOrEmpty(this.style.Value))
			{
				GUILayout.Label(new GUIContent(this.prefix.Value + this.intVariable.Value.ToString()), base.LayoutOptions);
				return;
			}
			GUILayout.Label(new GUIContent(this.prefix.Value + this.intVariable.Value.ToString()), this.style.Value, base.LayoutOptions);
		}

		// Token: 0x04004375 RID: 17269
		[Tooltip("Text to put before the int variable.")]
		public FsmString prefix;

		// Token: 0x04004376 RID: 17270
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Int variable to display.")]
		public FsmInt intVariable;

		// Token: 0x04004377 RID: 17271
		[Tooltip("Optional GUIStyle in the active GUISKin.")]
		public FsmString style;
	}
}
