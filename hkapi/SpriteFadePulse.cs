using System;
using UnityEngine;

// Token: 0x020000A3 RID: 163
public class SpriteFadePulse : MonoBehaviour
{
	// Token: 0x0600037E RID: 894 RVA: 0x00012914 File Offset: 0x00010B14
	private void Awake()
	{
		this.spriteRenderer = base.GetComponent<SpriteRenderer>();
	}

	// Token: 0x0600037F RID: 895 RVA: 0x00012922 File Offset: 0x00010B22
	private void OnEnable()
	{
		this.FadeIn();
	}

	// Token: 0x06000380 RID: 896 RVA: 0x0001292C File Offset: 0x00010B2C
	private void Update()
	{
		float num = this.currentLerpTime / this.fadeDuration;
		this.currentAlpha = Mathf.Lerp(this.lowAlpha, this.highAlpha, num);
		Color color = this.spriteRenderer.color;
		color.a = num;
		this.spriteRenderer.color = color;
		if (this.state == 0)
		{
			this.currentLerpTime += Time.deltaTime;
			if (this.currentLerpTime > this.fadeDuration)
			{
				this.FadeOut();
				return;
			}
		}
		else
		{
			this.currentLerpTime -= Time.deltaTime;
			if (this.currentLerpTime < 0f)
			{
				this.FadeIn();
			}
		}
	}

	// Token: 0x06000381 RID: 897 RVA: 0x000129D3 File Offset: 0x00010BD3
	public void FadeIn()
	{
		this.state = 0;
		this.currentLerpTime = 0f;
	}

	// Token: 0x06000382 RID: 898 RVA: 0x000129E7 File Offset: 0x00010BE7
	public void FadeOut()
	{
		this.state = 1;
		this.currentLerpTime = this.fadeDuration;
	}

	// Token: 0x040002E8 RID: 744
	public float lowAlpha;

	// Token: 0x040002E9 RID: 745
	public float highAlpha;

	// Token: 0x040002EA RID: 746
	public float fadeDuration;

	// Token: 0x040002EB RID: 747
	private SpriteRenderer spriteRenderer;

	// Token: 0x040002EC RID: 748
	private int state;

	// Token: 0x040002ED RID: 749
	private float currentLerpTime;

	// Token: 0x040002EE RID: 750
	private float currentAlpha;
}
