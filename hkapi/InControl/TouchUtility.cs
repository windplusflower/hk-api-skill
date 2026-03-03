using System;
using UnityEngine;

namespace InControl
{
	// Token: 0x0200071F RID: 1823
	public static class TouchUtility
	{
		// Token: 0x06002D44 RID: 11588 RVA: 0x000F30F0 File Offset: 0x000F12F0
		public static Vector2 AnchorToViewPoint(TouchControlAnchor touchControlAnchor)
		{
			switch (touchControlAnchor)
			{
			case TouchControlAnchor.TopLeft:
				return new Vector2(0f, 1f);
			case TouchControlAnchor.CenterLeft:
				return new Vector2(0f, 0.5f);
			case TouchControlAnchor.BottomLeft:
				return new Vector2(0f, 0f);
			case TouchControlAnchor.TopCenter:
				return new Vector2(0.5f, 1f);
			case TouchControlAnchor.Center:
				return new Vector2(0.5f, 0.5f);
			case TouchControlAnchor.BottomCenter:
				return new Vector2(0.5f, 0f);
			case TouchControlAnchor.TopRight:
				return new Vector2(1f, 1f);
			case TouchControlAnchor.CenterRight:
				return new Vector2(1f, 0.5f);
			case TouchControlAnchor.BottomRight:
				return new Vector2(1f, 0f);
			default:
				return Vector2.zero;
			}
		}

		// Token: 0x06002D45 RID: 11589 RVA: 0x000F31C1 File Offset: 0x000F13C1
		public static Vector2 RoundVector(Vector2 vector)
		{
			return new Vector2(Mathf.Round(vector.x), Mathf.Round(vector.y));
		}
	}
}
