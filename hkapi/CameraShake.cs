using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000127 RID: 295
public class CameraShake : MonoBehaviour
{
	// Token: 0x060006D7 RID: 1751 RVA: 0x00027633 File Offset: 0x00025833
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
	private void Init()
	{
		CameraShake.cameraShakes = new List<CameraShake>();
	}

	// Token: 0x060006D8 RID: 1752 RVA: 0x0002763F File Offset: 0x0002583F
	protected void Awake()
	{
		this.cameraShakeFSM = PlayMakerFSM.FindFsmOnGameObject(base.gameObject, "CameraShake");
	}

	// Token: 0x060006D9 RID: 1753 RVA: 0x00027657 File Offset: 0x00025857
	protected void OnEnable()
	{
		CameraShake.cameraShakes.Add(this);
	}

	// Token: 0x060006DA RID: 1754 RVA: 0x00027664 File Offset: 0x00025864
	protected void OnDisable()
	{
		CameraShake.cameraShakes.Remove(this);
	}

	// Token: 0x060006DB RID: 1755 RVA: 0x00027672 File Offset: 0x00025872
	public void ShakeSingle(CameraShakeCues cue)
	{
		if (this.cameraShakeFSM != null)
		{
			this.cameraShakeFSM.SendEvent(cue.ToString());
		}
	}

	// Token: 0x060006DC RID: 1756 RVA: 0x0002769C File Offset: 0x0002589C
	public static void Shake(CameraShakeCues cue)
	{
		for (int i = 0; i < CameraShake.cameraShakes.Count; i++)
		{
			CameraShake cameraShake = CameraShake.cameraShakes[i];
			if (cameraShake != null)
			{
				cameraShake.ShakeSingle(cue);
			}
		}
	}

	// Token: 0x04000761 RID: 1889
	private static List<CameraShake> cameraShakes;

	// Token: 0x04000762 RID: 1890
	private PlayMakerFSM cameraShakeFSM;
}
