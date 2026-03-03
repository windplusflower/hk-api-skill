using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B75 RID: 2933
	[ActionCategory(ActionCategory.GUI)]
	[Tooltip("Fills the screen with a Color. NOTE: Uses OnGUI so you need a PlayMakerGUI component in the scene.")]
	public class DrawFullscreenColor : FsmStateAction
	{
		// Token: 0x06003E5F RID: 15967 RVA: 0x00163FA9 File Offset: 0x001621A9
		public override void Reset()
		{
			this.color = Color.white;
		}

		// Token: 0x06003E60 RID: 15968 RVA: 0x00163FBC File Offset: 0x001621BC
		public override void OnGUI()
		{
			Color color = GUI.color;
			GUI.color = this.color.Value;
			GUI.DrawTexture(new Rect(0f, 0f, (float)Screen.width, (float)Screen.height), ActionHelpers.WhiteTexture);
			GUI.color = color;
		}

		// Token: 0x0400426D RID: 17005
		[RequiredField]
		[Tooltip("Color. NOTE: Uses OnGUI so you need a PlayMakerGUI component in the scene.")]
		public FsmColor color;
	}
}
