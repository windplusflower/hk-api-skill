using System;
using UnityEngine;

// Token: 0x020000A1 RID: 161
public class SimpleFadeOut : MonoBehaviour
{
	// Token: 0x06000373 RID: 883 RVA: 0x000126C4 File Offset: 0x000108C4
	private void Awake()
	{
		this.spriteRenderer = base.GetComponent<SpriteRenderer>();
		this.startColor = this.spriteRenderer.color;
		this.fadeColor = new Color(this.startColor.r, this.startColor.g, this.startColor.b, 0f);
	}

	// Token: 0x06000374 RID: 884 RVA: 0x0001271F File Offset: 0x0001091F
	private void OnEnable()
	{
		this.currentLerpTime = 0f;
	}

	// Token: 0x06000375 RID: 885 RVA: 0x0001272C File Offset: 0x0001092C
	private void Update()
	{
		if (!this.waitForCall)
		{
			this.currentLerpTime += Time.deltaTime;
			if (this.currentLerpTime > this.fadeDuration)
			{
				this.currentLerpTime = this.fadeDuration;
				base.gameObject.SetActive(false);
			}
			float t = this.currentLerpTime / this.fadeDuration;
			this.spriteRenderer.color = Color.Lerp(this.startColor, this.fadeColor, t);
		}
	}

	// Token: 0x06000376 RID: 886 RVA: 0x000127A4 File Offset: 0x000109A4
	public void FadeOut()
	{
		this.waitForCall = false;
	}

	// Token: 0x06000377 RID: 887 RVA: 0x000127AD File Offset: 0x000109AD
	public SimpleFadeOut()
	{
		this.fadeDuration = 1f;
		base..ctor();
	}

	// Token: 0x040002D8 RID: 728
	private SpriteRenderer spriteRenderer;

	// Token: 0x040002D9 RID: 729
	public float fadeDuration;

	// Token: 0x040002DA RID: 730
	public bool waitForCall;

	// Token: 0x040002DB RID: 731
	private Color startColor;

	// Token: 0x040002DC RID: 732
	private Color fadeColor;

	// Token: 0x040002DD RID: 733
	private float currentLerpTime;
}
