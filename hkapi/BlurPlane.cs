using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000124 RID: 292
[RequireComponent(typeof(MeshRenderer))]
public class BlurPlane : MonoBehaviour
{
	// Token: 0x170000B9 RID: 185
	// (get) Token: 0x060006C0 RID: 1728 RVA: 0x00027412 File Offset: 0x00025612
	// (set) Token: 0x060006C1 RID: 1729 RVA: 0x0002741A File Offset: 0x0002561A
	public Material OriginalMaterial { get; private set; }

	// Token: 0x170000BA RID: 186
	// (get) Token: 0x060006C2 RID: 1730 RVA: 0x00027423 File Offset: 0x00025623
	public static int BlurPlaneCount
	{
		get
		{
			return BlurPlane.blurPlanes.Count;
		}
	}

	// Token: 0x060006C3 RID: 1731 RVA: 0x0002742F File Offset: 0x0002562F
	public static BlurPlane GetBlurPlane(int index)
	{
		return BlurPlane.blurPlanes[index];
	}

	// Token: 0x170000BB RID: 187
	// (get) Token: 0x060006C4 RID: 1732 RVA: 0x0002743C File Offset: 0x0002563C
	public static BlurPlane ClosestBlurPlane
	{
		get
		{
			if (BlurPlane.blurPlanes.Count <= 0)
			{
				return null;
			}
			return BlurPlane.blurPlanes[0];
		}
	}

	// Token: 0x1400000C RID: 12
	// (add) Token: 0x060006C5 RID: 1733 RVA: 0x00027458 File Offset: 0x00025658
	// (remove) Token: 0x060006C6 RID: 1734 RVA: 0x0002748C File Offset: 0x0002568C
	public static event BlurPlane.BlurPlanesChangedDelegate BlurPlanesChanged;

	// Token: 0x170000BC RID: 188
	// (get) Token: 0x060006C7 RID: 1735 RVA: 0x000274BF File Offset: 0x000256BF
	public float PlaneZ
	{
		get
		{
			return base.transform.position.z;
		}
	}

	// Token: 0x060006C8 RID: 1736 RVA: 0x000274D1 File Offset: 0x000256D1
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
	private static void Init()
	{
		BlurPlane.blurPlanes = new List<BlurPlane>();
	}

	// Token: 0x060006C9 RID: 1737 RVA: 0x000274DD File Offset: 0x000256DD
	protected void Awake()
	{
		this.meshRenderer = base.GetComponent<MeshRenderer>();
		this.OriginalMaterial = this.meshRenderer.sharedMaterial;
	}

	// Token: 0x060006CA RID: 1738 RVA: 0x000274FC File Offset: 0x000256FC
	protected void OnEnable()
	{
		int i;
		for (i = 0; i < BlurPlane.blurPlanes.Count; i++)
		{
			BlurPlane blurPlane = BlurPlane.blurPlanes[i];
			if (blurPlane.PlaneZ > blurPlane.PlaneZ)
			{
				break;
			}
		}
		BlurPlane.blurPlanes.Insert(i, this);
		BlurPlane.BlurPlanesChangedDelegate blurPlanesChanged = BlurPlane.BlurPlanesChanged;
		if (blurPlanesChanged == null)
		{
			return;
		}
		blurPlanesChanged();
	}

	// Token: 0x060006CB RID: 1739 RVA: 0x00027553 File Offset: 0x00025753
	protected void OnDisable()
	{
		BlurPlane.blurPlanes.Remove(this);
		BlurPlane.BlurPlanesChangedDelegate blurPlanesChanged = BlurPlane.BlurPlanesChanged;
		if (blurPlanesChanged == null)
		{
			return;
		}
		blurPlanesChanged();
	}

	// Token: 0x060006CC RID: 1740 RVA: 0x00027570 File Offset: 0x00025770
	public void SetPlaneVisibility(bool isVisible)
	{
		this.meshRenderer.enabled = isVisible;
	}

	// Token: 0x060006CD RID: 1741 RVA: 0x0002757E File Offset: 0x0002577E
	public void SetPlaneMaterial(Material material)
	{
		this.meshRenderer.sharedMaterial = ((material == null) ? this.OriginalMaterial : material);
	}

	// Token: 0x0400075B RID: 1883
	private MeshRenderer meshRenderer;

	// Token: 0x0400075D RID: 1885
	private static List<BlurPlane> blurPlanes;

	// Token: 0x02000125 RID: 293
	// (Invoke) Token: 0x060006D0 RID: 1744
	public delegate void BlurPlanesChangedDelegate();
}
