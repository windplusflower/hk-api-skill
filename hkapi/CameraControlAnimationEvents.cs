using System;
using UnityEngine;

// Token: 0x02000059 RID: 89
public class CameraControlAnimationEvents : MonoBehaviour
{
	// Token: 0x060001D7 RID: 471 RVA: 0x0000C173 File Offset: 0x0000A373
	public void BigShake()
	{
		this.SendCameraEvent("BigShake");
	}

	// Token: 0x060001D8 RID: 472 RVA: 0x0000C180 File Offset: 0x0000A380
	public void SmallShake()
	{
		this.SendCameraEvent("SmallShake");
	}

	// Token: 0x060001D9 RID: 473 RVA: 0x0000C18D File Offset: 0x0000A38D
	public void AverageShake()
	{
		this.SendCameraEvent("AverageShake");
	}

	// Token: 0x060001DA RID: 474 RVA: 0x0000C19A File Offset: 0x0000A39A
	public void EnemyKillShake()
	{
		this.SendCameraEvent("EnemyKillShake");
	}

	// Token: 0x060001DB RID: 475 RVA: 0x0000C1A7 File Offset: 0x0000A3A7
	public void SmallRumble()
	{
		this.SetCameraBool("RumblingSmall", true);
	}

	// Token: 0x060001DC RID: 476 RVA: 0x0000C1B5 File Offset: 0x0000A3B5
	public void MedRumble()
	{
		this.SetCameraBool("RumblingMed", true);
	}

	// Token: 0x060001DD RID: 477 RVA: 0x0000C1C3 File Offset: 0x0000A3C3
	public void BigRumble()
	{
		this.SetCameraBool("RumblingBig", true);
	}

	// Token: 0x060001DE RID: 478 RVA: 0x0000C1D1 File Offset: 0x0000A3D1
	public void StopRumble()
	{
		this.SetCameraBool("RumblingSmall", false);
		this.SetCameraBool("RumblingMed", false);
		this.SetCameraBool("RumblingBig", false);
	}

	// Token: 0x060001DF RID: 479 RVA: 0x0000C1F7 File Offset: 0x0000A3F7
	private void SendCameraEvent(string eventName)
	{
		if (base.enabled)
		{
			GameCameras.instance.cameraShakeFSM.SendEvent(eventName);
		}
	}

	// Token: 0x060001E0 RID: 480 RVA: 0x0000C211 File Offset: 0x0000A411
	private void SetCameraBool(string boolName, bool value)
	{
		if (base.enabled)
		{
			GameCameras.instance.cameraShakeFSM.FsmVariables.FindFsmBool(boolName).Value = value;
		}
	}
}
