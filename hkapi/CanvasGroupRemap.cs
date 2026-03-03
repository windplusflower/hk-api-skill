using System;
using TMPro;
using UnityEngine;

// Token: 0x0200043C RID: 1084
[RequireComponent(typeof(CanvasGroup))]
public class CanvasGroupRemap : MonoBehaviour
{
	// Token: 0x0600186E RID: 6254 RVA: 0x00072B1A File Offset: 0x00070D1A
	private void Awake()
	{
		if (!this.group)
		{
			this.group = base.GetComponent<CanvasGroup>();
		}
		this.spriteRenderers = base.GetComponentsInChildren<SpriteRenderer>(true);
		this.textMeshes = base.GetComponentsInChildren<TextMeshPro>(true);
		this.Sync(0f);
	}

	// Token: 0x0600186F RID: 6255 RVA: 0x00072B5C File Offset: 0x00070D5C
	private void Update()
	{
		if (!this.skippedFirstUpdate)
		{
			this.skippedFirstUpdate = true;
			return;
		}
		if (this.group.alpha != this.alpha)
		{
			this.alpha = this.group.alpha;
			this.Sync(this.alpha);
		}
	}

	// Token: 0x06001870 RID: 6256 RVA: 0x00072BAC File Offset: 0x00070DAC
	private void Sync(float alpha)
	{
		foreach (SpriteRenderer spriteRenderer in this.spriteRenderers)
		{
			Color color = spriteRenderer.color;
			color.a = alpha;
			spriteRenderer.color = color;
		}
		foreach (TextMeshPro textMeshPro in this.textMeshes)
		{
			Color color2 = textMeshPro.color;
			color2.a = alpha;
			textMeshPro.color = color2;
		}
	}

	// Token: 0x04001D3E RID: 7486
	private SpriteRenderer[] spriteRenderers;

	// Token: 0x04001D3F RID: 7487
	private TextMeshPro[] textMeshes;

	// Token: 0x04001D40 RID: 7488
	public CanvasGroup group;

	// Token: 0x04001D41 RID: 7489
	private float alpha;

	// Token: 0x04001D42 RID: 7490
	private bool skippedFirstUpdate;
}
