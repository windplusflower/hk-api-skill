using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B77 RID: 2935
	[ActionCategory(ActionCategory.GUI)]
	[Tooltip("Draws a GUI Texture. NOTE: Uses OnGUI so you need a PlayMakerGUI component in the scene.")]
	public class DrawTexture : FsmStateAction
	{
		// Token: 0x06003E65 RID: 15973 RVA: 0x00164034 File Offset: 0x00162234
		public override void Reset()
		{
			this.texture = null;
			this.screenRect = null;
			this.left = 0f;
			this.top = 0f;
			this.width = 1f;
			this.height = 1f;
			this.scaleMode = ScaleMode.StretchToFill;
			this.alphaBlend = true;
			this.imageAspect = 0f;
			this.normalized = true;
		}

		// Token: 0x06003E66 RID: 15974 RVA: 0x001640C0 File Offset: 0x001622C0
		public override void OnGUI()
		{
			if (this.texture.Value == null)
			{
				return;
			}
			this.rect = ((!this.screenRect.IsNone) ? this.screenRect.Value : default(Rect));
			if (!this.left.IsNone)
			{
				this.rect.x = this.left.Value;
			}
			if (!this.top.IsNone)
			{
				this.rect.y = this.top.Value;
			}
			if (!this.width.IsNone)
			{
				this.rect.width = this.width.Value;
			}
			if (!this.height.IsNone)
			{
				this.rect.height = this.height.Value;
			}
			if (this.normalized.Value)
			{
				this.rect.x = this.rect.x * (float)Screen.width;
				this.rect.width = this.rect.width * (float)Screen.width;
				this.rect.y = this.rect.y * (float)Screen.height;
				this.rect.height = this.rect.height * (float)Screen.height;
			}
			GUI.DrawTexture(this.rect, this.texture.Value, this.scaleMode, this.alphaBlend.Value, this.imageAspect.Value);
		}

		// Token: 0x0400426F RID: 17007
		[RequiredField]
		[Tooltip("Texture to draw.")]
		public FsmTexture texture;

		// Token: 0x04004270 RID: 17008
		[UIHint(UIHint.Variable)]
		[Tooltip("Rectangle on the screen to draw the texture within. Alternatively, set or override individual properties below.")]
		[Title("Position")]
		public FsmRect screenRect;

		// Token: 0x04004271 RID: 17009
		[Tooltip("Left screen coordinate.")]
		public FsmFloat left;

		// Token: 0x04004272 RID: 17010
		[Tooltip("Top screen coordinate.")]
		public FsmFloat top;

		// Token: 0x04004273 RID: 17011
		[Tooltip("Width of texture on screen.")]
		public FsmFloat width;

		// Token: 0x04004274 RID: 17012
		[Tooltip("Height of texture on screen.")]
		public FsmFloat height;

		// Token: 0x04004275 RID: 17013
		[Tooltip("How to scale the image when the aspect ratio of it doesn't fit the aspect ratio to be drawn within.")]
		public ScaleMode scaleMode;

		// Token: 0x04004276 RID: 17014
		[Tooltip("Whether to alpha blend the image on to the display (the default). If false, the picture is drawn on to the display.")]
		public FsmBool alphaBlend;

		// Token: 0x04004277 RID: 17015
		[Tooltip("Aspect ratio to use for the source image. If 0 (the default), the aspect ratio from the image is used. Pass in w/h for the desired aspect ratio. This allows the aspect ratio of the source image to be adjusted without changing the pixel width and height.")]
		public FsmFloat imageAspect;

		// Token: 0x04004278 RID: 17016
		[Tooltip("Use normalized screen coordinates (0-1)")]
		public FsmBool normalized;

		// Token: 0x04004279 RID: 17017
		private Rect rect;
	}
}
