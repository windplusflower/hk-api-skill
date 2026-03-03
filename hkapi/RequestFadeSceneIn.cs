using System;
using System.Collections;
using GlobalEnums;
using UnityEngine;

// Token: 0x020000E7 RID: 231
public class RequestFadeSceneIn : MonoBehaviour
{
	// Token: 0x060004DE RID: 1246 RVA: 0x00019385 File Offset: 0x00017585
	private IEnumerator Start()
	{
		yield return new WaitForSeconds(this.waitBeforeFade);
		if (this.fadeInSpeed == CameraFadeInType.SLOW)
		{
			GameCameras.instance.cameraFadeFSM.Fsm.Event("FADE SCENE IN SLOWLY");
		}
		else if (this.fadeInSpeed == CameraFadeInType.NORMAL)
		{
			GameCameras.instance.cameraFadeFSM.Fsm.Event("FADE SCENE IN");
		}
		else if (this.fadeInSpeed == CameraFadeInType.INSTANT)
		{
			GameCameras.instance.cameraFadeFSM.Fsm.Event("FADE SCENE IN INSTANT");
		}
		yield break;
	}

	// Token: 0x040004AE RID: 1198
	public float waitBeforeFade;

	// Token: 0x040004AF RID: 1199
	public CameraFadeInType fadeInSpeed;
}
