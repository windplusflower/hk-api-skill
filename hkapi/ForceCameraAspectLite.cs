using System;
using UnityEngine;

// Token: 0x020000E4 RID: 228
public class ForceCameraAspectLite : MonoBehaviour
{
	// Token: 0x060004C4 RID: 1220 RVA: 0x00018B3B File Offset: 0x00016D3B
	private void Start()
	{
		this.AutoScaleViewport();
	}

	// Token: 0x060004C5 RID: 1221 RVA: 0x00018B44 File Offset: 0x00016D44
	private void Update()
	{
		this.viewportChanged = false;
		if (this.lastX != Screen.width)
		{
			this.viewportChanged = true;
		}
		if (this.lastY != Screen.height)
		{
			this.viewportChanged = true;
		}
		if (this.viewportChanged)
		{
			this.AutoScaleViewport();
		}
		this.lastX = Screen.width;
		this.lastY = Screen.height;
	}

	// Token: 0x060004C6 RID: 1222 RVA: 0x00018BA4 File Offset: 0x00016DA4
	private void AutoScaleViewport()
	{
		float num = (float)Screen.width / (float)Screen.height / 1.7777778f;
		float num2 = 1f + this.scaleAdjust;
		Rect rect = this.sceneCamera.rect;
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
		this.sceneCamera.rect = rect;
	}

	// Token: 0x0400048E RID: 1166
	public Camera sceneCamera;

	// Token: 0x0400048F RID: 1167
	private bool viewportChanged;

	// Token: 0x04000490 RID: 1168
	private int lastX;

	// Token: 0x04000491 RID: 1169
	private int lastY;

	// Token: 0x04000492 RID: 1170
	private float scaleAdjust;
}
