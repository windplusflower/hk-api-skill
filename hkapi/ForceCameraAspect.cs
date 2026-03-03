using System;
using UnityEngine;

// Token: 0x020000E3 RID: 227
public class ForceCameraAspect : MonoBehaviour
{
	// Token: 0x14000005 RID: 5
	// (add) Token: 0x060004BA RID: 1210 RVA: 0x00018908 File Offset: 0x00016B08
	// (remove) Token: 0x060004BB RID: 1211 RVA: 0x0001893C File Offset: 0x00016B3C
	public static event Action<float> ViewportAspectChanged;

	// Token: 0x1700008C RID: 140
	// (get) Token: 0x060004BC RID: 1212 RVA: 0x0001896F File Offset: 0x00016B6F
	// (set) Token: 0x060004BD RID: 1213 RVA: 0x00018976 File Offset: 0x00016B76
	public static float CurrentViewportAspect { get; private set; }

	// Token: 0x060004BE RID: 1214 RVA: 0x0001897E File Offset: 0x00016B7E
	private void Awake()
	{
		this.tk2dCam = base.GetComponent<tk2dCamera>();
		ForceCameraAspect.CurrentViewportAspect = 1.7777778f;
	}

	// Token: 0x060004BF RID: 1215 RVA: 0x00018996 File Offset: 0x00016B96
	private void Start()
	{
		this.hudCam = GameCameras.instance.hudCamera;
		this.AutoScaleViewport();
	}

	// Token: 0x060004C0 RID: 1216 RVA: 0x000189B0 File Offset: 0x00016BB0
	private void Update()
	{
		if (this.lastX == Screen.width && this.lastY == Screen.height)
		{
			return;
		}
		float num = this.AutoScaleViewport();
		this.lastX = Screen.width;
		this.lastY = Screen.height;
		if (ForceCameraAspect.ViewportAspectChanged != null)
		{
			ForceCameraAspect.ViewportAspectChanged(num);
		}
		ForceCameraAspect.CurrentViewportAspect = num;
	}

	// Token: 0x060004C1 RID: 1217 RVA: 0x00018A0D File Offset: 0x00016C0D
	public void SetOverscanViewport(float adjustment)
	{
		this.scaleAdjust = adjustment;
		this.AutoScaleViewport();
	}

	// Token: 0x060004C2 RID: 1218 RVA: 0x00018A20 File Offset: 0x00016C20
	private float AutoScaleViewport()
	{
		float num = (float)Screen.width / (float)Screen.height / 1.7777778f;
		float num2 = 1f + this.scaleAdjust;
		Rect rect = this.tk2dCam.CameraSettings.rect;
		if (num < 1f)
		{
			rect.width = 1f * num2;
			rect.height = num * num2;
			float x = (1f - rect.width) / 2f;
			rect.x = x;
			float y = (1f - rect.height) / 2f;
			rect.y = y;
		}
		else
		{
			float num3 = 1f / num;
			rect.width = num3 * num2;
			rect.height = 1f * num2;
			float x2 = (1f - rect.width) / 2f;
			rect.x = x2;
			float y2 = (1f - rect.height) / 2f;
			rect.y = y2;
		}
		this.tk2dCam.CameraSettings.rect = rect;
		this.hudCam.rect = rect;
		return 1.7777778f;
	}

	// Token: 0x04000488 RID: 1160
	private tk2dCamera tk2dCam;

	// Token: 0x04000489 RID: 1161
	private Camera hudCam;

	// Token: 0x0400048A RID: 1162
	private int lastX;

	// Token: 0x0400048B RID: 1163
	private int lastY;

	// Token: 0x0400048C RID: 1164
	private float scaleAdjust;
}
