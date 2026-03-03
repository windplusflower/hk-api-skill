using System;
using UnityEngine;

// Token: 0x0200020C RID: 524
public class TitleLogo : MonoBehaviour
{
	// Token: 0x06000B57 RID: 2903 RVA: 0x0003C3C0 File Offset: 0x0003A5C0
	public void AnimationFinished()
	{
		this.startManager.SwitchToMenuScene();
	}

	// Token: 0x04000C54 RID: 3156
	public StartManager startManager;
}
