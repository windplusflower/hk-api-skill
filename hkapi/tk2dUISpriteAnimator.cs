using System;
using UnityEngine;

// Token: 0x020005BC RID: 1468
[AddComponentMenu("2D Toolkit/UI/Core/tk2dUISpriteAnimator")]
public class tk2dUISpriteAnimator : tk2dSpriteAnimator
{
	// Token: 0x0600216D RID: 8557 RVA: 0x000A8876 File Offset: 0x000A6A76
	public override void LateUpdate()
	{
		base.UpdateAnimation(tk2dUITime.deltaTime);
	}
}
