using System;
using UnityEngine;

// Token: 0x020002A0 RID: 672
[ExecuteInEditMode]
public class RadialLayoutUI : MonoBehaviour
{
	// Token: 0x06000E0F RID: 3599 RVA: 0x000451F5 File Offset: 0x000433F5
	private void Update()
	{
		if (this.HasValueChanged())
		{
			this.UpdateUI();
		}
	}

	// Token: 0x06000E10 RID: 3600 RVA: 0x00045205 File Offset: 0x00043405
	private void OnTransformChildrenChanged()
	{
		this.hasValueChanged = true;
	}

	// Token: 0x06000E11 RID: 3601 RVA: 0x00045210 File Offset: 0x00043410
	public bool HasValueChanged()
	{
		if (this.hasValueChanged)
		{
			this.hasValueChanged = false;
			return true;
		}
		if (this.scale != this.oldScale || this.radius != this.oldRadius || this.elementOffset != this.oldElementOffset || this.splitX != this.oldSplitX || this.splitY != this.oldSplitY || this.counterClockwise != this.oldCounterClockwise)
		{
			this.oldScale = this.scale;
			this.oldRadius = this.radius;
			this.oldElementOffset = this.elementOffset;
			this.oldSplitX = this.splitX;
			this.oldSplitY = this.splitY;
			this.oldCounterClockwise = this.counterClockwise;
			return true;
		}
		return false;
	}

	// Token: 0x06000E12 RID: 3602 RVA: 0x000452D0 File Offset: 0x000434D0
	public void UpdateUI()
	{
		float num = this.radius * this.scale;
		float num2 = this.splitX * this.scale;
		float num3 = this.splitY * this.scale;
		int childCount = base.transform.childCount;
		float num4 = this.elementOffset ? (360f / (float)childCount / 2f) : 0f;
		for (int i = 0; i < childCount; i++)
		{
			Transform child = base.transform.GetChild(i);
			float num5 = (float)(i + 1) / (float)childCount * 360f - num4;
			if (this.counterClockwise)
			{
				num5 = 360f - num5;
			}
			num5 *= 0.017453292f;
			Vector3 vector = new Vector3(num * Mathf.Sin(num5), num * Mathf.Cos(num5), 0f);
			vector.x += ((vector.x > 0f) ? num2 : (-num2));
			vector.y += ((vector.y > 0f) ? num3 : (-num3));
			child.localPosition = vector;
		}
	}

	// Token: 0x06000E13 RID: 3603 RVA: 0x000453E5 File Offset: 0x000435E5
	public RadialLayoutUI()
	{
		this.scale = 1f;
		this.radius = 1f;
		this.elementOffset = true;
		base..ctor();
	}

	// Token: 0x04000EE6 RID: 3814
	public float scale;

	// Token: 0x04000EE7 RID: 3815
	private float oldScale;

	// Token: 0x04000EE8 RID: 3816
	public float radius;

	// Token: 0x04000EE9 RID: 3817
	private float oldRadius;

	// Token: 0x04000EEA RID: 3818
	public bool elementOffset;

	// Token: 0x04000EEB RID: 3819
	private bool oldElementOffset;

	// Token: 0x04000EEC RID: 3820
	public float splitX;

	// Token: 0x04000EED RID: 3821
	private float oldSplitX;

	// Token: 0x04000EEE RID: 3822
	public float splitY;

	// Token: 0x04000EEF RID: 3823
	private float oldSplitY;

	// Token: 0x04000EF0 RID: 3824
	public bool counterClockwise;

	// Token: 0x04000EF1 RID: 3825
	private bool oldCounterClockwise;

	// Token: 0x04000EF2 RID: 3826
	private bool hasValueChanged;
}
