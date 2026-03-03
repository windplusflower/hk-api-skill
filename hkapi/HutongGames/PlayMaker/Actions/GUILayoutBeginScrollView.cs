using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BA6 RID: 2982
	[ActionCategory(ActionCategory.GUILayout)]
	[Tooltip("Begins a ScrollView. Use GUILayoutEndScrollView at the end of the block.")]
	public class GUILayoutBeginScrollView : GUILayoutAction
	{
		// Token: 0x06003F27 RID: 16167 RVA: 0x001665E2 File Offset: 0x001647E2
		public override void Reset()
		{
			base.Reset();
			this.scrollPosition = null;
			this.horizontalScrollbar = null;
			this.verticalScrollbar = null;
			this.useCustomStyle = null;
			this.horizontalStyle = null;
			this.verticalStyle = null;
			this.backgroundStyle = null;
		}

		// Token: 0x06003F28 RID: 16168 RVA: 0x0016661C File Offset: 0x0016481C
		public override void OnGUI()
		{
			if (this.useCustomStyle.Value)
			{
				this.scrollPosition.Value = GUILayout.BeginScrollView(this.scrollPosition.Value, this.horizontalScrollbar.Value, this.verticalScrollbar.Value, this.horizontalStyle.Value, this.verticalStyle.Value, this.backgroundStyle.Value, base.LayoutOptions);
				return;
			}
			this.scrollPosition.Value = GUILayout.BeginScrollView(this.scrollPosition.Value, this.horizontalScrollbar.Value, this.verticalScrollbar.Value, base.LayoutOptions);
		}

		// Token: 0x04004347 RID: 17223
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Assign a Vector2 variable to store the scroll position of this view.")]
		public FsmVector2 scrollPosition;

		// Token: 0x04004348 RID: 17224
		[Tooltip("Always show the horizontal scrollbars.")]
		public FsmBool horizontalScrollbar;

		// Token: 0x04004349 RID: 17225
		[Tooltip("Always show the vertical scrollbars.")]
		public FsmBool verticalScrollbar;

		// Token: 0x0400434A RID: 17226
		[Tooltip("Define custom styles below. NOTE: You have to define all the styles if you check this option.")]
		public FsmBool useCustomStyle;

		// Token: 0x0400434B RID: 17227
		[Tooltip("Named style in the active GUISkin for the horizontal scrollbars.")]
		public FsmString horizontalStyle;

		// Token: 0x0400434C RID: 17228
		[Tooltip("Named style in the active GUISkin for the vertical scrollbars.")]
		public FsmString verticalStyle;

		// Token: 0x0400434D RID: 17229
		[Tooltip("Named style in the active GUISkin for the background.")]
		public FsmString backgroundStyle;
	}
}
