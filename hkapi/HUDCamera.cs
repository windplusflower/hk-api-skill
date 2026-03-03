using System;
using UnityEngine;

// Token: 0x020000E6 RID: 230
public class HUDCamera : MonoBehaviour
{
	// Token: 0x060004DB RID: 1243 RVA: 0x000192E4 File Offset: 0x000174E4
	private void OnEnable()
	{
		if (!this.gc)
		{
			this.gc = GameCameras.instance;
		}
		if (!this.ih)
		{
			this.ih = GameManager.instance.inputHandler;
		}
		if (this.ih.pauseAllowed)
		{
			this.shouldEnablePause = true;
			this.ih.PreventPause();
		}
		else
		{
			this.shouldEnablePause = false;
		}
		base.Invoke("MoveMenuToHUDCamera", 0.5f);
	}

	// Token: 0x060004DC RID: 1244 RVA: 0x0001935E File Offset: 0x0001755E
	private void MoveMenuToHUDCamera()
	{
		this.gc.MoveMenuToHUDCamera();
		if (this.shouldEnablePause)
		{
			this.ih.AllowPause();
			this.shouldEnablePause = false;
		}
	}

	// Token: 0x040004AB RID: 1195
	private GameCameras gc;

	// Token: 0x040004AC RID: 1196
	private InputHandler ih;

	// Token: 0x040004AD RID: 1197
	private bool shouldEnablePause;
}
