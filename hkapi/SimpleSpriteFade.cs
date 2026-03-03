using System;
using UnityEngine;

// Token: 0x020000A2 RID: 162
public class SimpleSpriteFade : MonoBehaviour
{
	// Token: 0x06000378 RID: 888 RVA: 0x000127C0 File Offset: 0x000109C0
	private void Awake()
	{
		this.spriteRenderer = base.GetComponent<SpriteRenderer>();
		this.normalColor = this.spriteRenderer.color;
	}

	// Token: 0x06000379 RID: 889 RVA: 0x000127DF File Offset: 0x000109DF
	private void OnEnable()
	{
		this.spriteRenderer.color = this.normalColor;
		if (this.fadeInOnStart)
		{
			this.FadeIn();
		}
	}

	// Token: 0x0600037A RID: 890 RVA: 0x00012800 File Offset: 0x00010A00
	private void Update()
	{
		if (this.fadingIn || this.fadingOut)
		{
			if (this.fadingIn)
			{
				this.currentLerpTime += Time.deltaTime;
				if (this.currentLerpTime > this.fadeDuration)
				{
					this.currentLerpTime = this.fadeDuration;
					this.fadingIn = false;
					if (this.recycleOnFadeIn)
					{
						base.gameObject.Recycle();
					}
					if (this.deactivateOnFadeIn)
					{
						base.gameObject.SetActive(false);
					}
				}
			}
			else if (this.fadingOut)
			{
				this.currentLerpTime -= Time.deltaTime;
				if (this.currentLerpTime < 0f)
				{
					this.currentLerpTime = 0f;
					this.fadingOut = false;
				}
			}
			float t = this.currentLerpTime / this.fadeDuration;
			this.spriteRenderer.color = Color.Lerp(this.normalColor, this.fadeInColor, t);
		}
	}

	// Token: 0x0600037B RID: 891 RVA: 0x000128EB File Offset: 0x00010AEB
	public void FadeIn()
	{
		this.fadingIn = true;
		this.currentLerpTime = 0f;
	}

	// Token: 0x0600037C RID: 892 RVA: 0x000128FF File Offset: 0x00010AFF
	public void FadeOut()
	{
		this.fadingOut = true;
		this.currentLerpTime = this.fadeDuration;
	}

	// Token: 0x040002DE RID: 734
	public Color fadeInColor;

	// Token: 0x040002DF RID: 735
	private SpriteRenderer spriteRenderer;

	// Token: 0x040002E0 RID: 736
	private Color normalColor;

	// Token: 0x040002E1 RID: 737
	public float fadeDuration;

	// Token: 0x040002E2 RID: 738
	private bool fadingIn;

	// Token: 0x040002E3 RID: 739
	private bool fadingOut;

	// Token: 0x040002E4 RID: 740
	private float currentLerpTime;

	// Token: 0x040002E5 RID: 741
	public bool fadeInOnStart;

	// Token: 0x040002E6 RID: 742
	public bool deactivateOnFadeIn;

	// Token: 0x040002E7 RID: 743
	public bool recycleOnFadeIn;
}
