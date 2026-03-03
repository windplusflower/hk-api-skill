using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000077 RID: 119
[RequireComponent(typeof(Renderer))]
public class FlashMaterialGroup : MonoBehaviour
{
	// Token: 0x06000277 RID: 631 RVA: 0x0000DE71 File Offset: 0x0000C071
	private void Awake()
	{
		this.renderer = base.GetComponent<Renderer>();
	}

	// Token: 0x06000278 RID: 632 RVA: 0x0000DE80 File Offset: 0x0000C080
	private void Start()
	{
		Renderer[] componentsInChildren = base.GetComponentsInChildren<Renderer>();
		List<Renderer> list = new List<Renderer>();
		foreach (Renderer renderer in componentsInChildren)
		{
			if (renderer != this.renderer && renderer.sharedMaterial == this.renderer.sharedMaterial)
			{
				list.Add(renderer);
			}
		}
		this.material = new Material(this.renderer.sharedMaterial);
		this.renderer.sharedMaterial = this.material;
		foreach (Renderer renderer2 in list)
		{
			renderer2.material = this.material;
		}
	}

	// Token: 0x06000279 RID: 633 RVA: 0x0000DF48 File Offset: 0x0000C148
	private void Update()
	{
		if (this.material)
		{
			this.material.SetFloat("_FlashAmount", this.flashAmount);
		}
	}

	// Token: 0x0400020D RID: 525
	[Range(0f, 1f)]
	public float flashAmount;

	// Token: 0x0400020E RID: 526
	private Renderer renderer;

	// Token: 0x0400020F RID: 527
	private Material material;
}
