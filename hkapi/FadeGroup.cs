using System;
using TMPro;
using UnityEngine;

// Token: 0x02000454 RID: 1108
public class FadeGroup : MonoBehaviour
{
	// Token: 0x060018DF RID: 6367 RVA: 0x0007440F File Offset: 0x0007260F
	private void OnEnable()
	{
		if (this.disableRenderersOnEnable)
		{
			this.DisableRenderers();
		}
	}

	// Token: 0x060018E0 RID: 6368 RVA: 0x00074420 File Offset: 0x00072620
	private void Update()
	{
		if (this.state != 0)
		{
			float t = 0f;
			if (this.state == 1)
			{
				this.timer += Time.deltaTime;
				if (this.timer > this.fadeInTime)
				{
					this.timer = this.fadeInTime;
					this.state = 0;
					for (int i = 0; i < this.spriteRenderers.Length; i++)
					{
						if (this.spriteRenderers[i] != null)
						{
							Color color = this.spriteRenderers[i].color;
							color.a = this.fullAlpha;
							this.spriteRenderers[i].color = color;
						}
					}
					for (int j = 0; j < this.texts.Length; j++)
					{
						if (this.texts[j] != null)
						{
							Color color2 = this.texts[j].color;
							color2.a = this.fullAlpha;
							this.texts[j].color = color2;
						}
					}
				}
				t = this.timer / this.fadeInTime;
			}
			else if (this.state == 2)
			{
				this.timer -= Time.deltaTime;
				if (this.timer < 0f)
				{
					this.timer = 0f;
					this.state = 0;
					if (this.downAlpha > 0f)
					{
						for (int k = 0; k < this.spriteRenderers.Length; k++)
						{
							if (this.spriteRenderers[k] != null)
							{
								Color color3 = this.spriteRenderers[k].color;
								color3.a = this.downAlpha;
								this.spriteRenderers[k].color = color3;
							}
						}
						for (int l = 0; l < this.texts.Length; l++)
						{
							if (this.texts[l] != null)
							{
								Color color4 = this.texts[l].color;
								color4.a = this.downAlpha;
								this.texts[l].color = color4;
							}
						}
					}
					else
					{
						this.DisableRenderers();
					}
				}
				t = this.timer / this.fadeOutTime;
			}
			if (this.state != 0)
			{
				this.currentAlpha = Mathf.Lerp(this.downAlpha, this.fullAlpha, t);
				for (int m = 0; m < this.spriteRenderers.Length; m++)
				{
					if (this.spriteRenderers[m] != null)
					{
						Color color5 = this.spriteRenderers[m].color;
						color5.a = this.currentAlpha;
						this.spriteRenderers[m].color = color5;
					}
				}
				for (int n = 0; n < this.texts.Length; n++)
				{
					if (this.texts[n] != null)
					{
						Color color6 = this.texts[n].color;
						color6.a = this.currentAlpha;
						this.texts[n].color = color6;
					}
				}
			}
		}
	}

	// Token: 0x060018E1 RID: 6369 RVA: 0x0007470C File Offset: 0x0007290C
	public void FadeUp()
	{
		this.timer = 0f;
		this.state = 1;
		for (int i = 0; i < this.spriteRenderers.Length; i++)
		{
			if (this.spriteRenderers[i] != null)
			{
				Color color = this.spriteRenderers[i].color;
				color.a = 0f;
				this.spriteRenderers[i].color = color;
				this.spriteRenderers[i].enabled = true;
			}
		}
		for (int j = 0; j < this.texts.Length; j++)
		{
			if (this.texts[j] != null)
			{
				Color color2 = this.texts[j].color;
				color2.a = 0f;
				this.texts[j].color = color2;
				this.texts[j].gameObject.GetComponent<MeshRenderer>().SetActiveWithChildren(true);
			}
		}
		for (int k = 0; k < this.animators.Length; k++)
		{
			if (this.animators[k] != null)
			{
				this.animators[k].AnimateUp();
			}
		}
	}

	// Token: 0x060018E2 RID: 6370 RVA: 0x00074820 File Offset: 0x00072A20
	public void FadeDown()
	{
		this.timer = this.fadeOutTime;
		this.state = 2;
		for (int i = 0; i < this.animators.Length; i++)
		{
			if (this.animators[i] != null)
			{
				this.animators[i].AnimateDown();
			}
		}
	}

	// Token: 0x060018E3 RID: 6371 RVA: 0x00074870 File Offset: 0x00072A70
	public void FadeDownFast()
	{
		this.timer = this.fadeOutTimeFast;
		this.state = 2;
		for (int i = 0; i < this.animators.Length; i++)
		{
			if (this.animators[i] != null)
			{
				this.animators[i].AnimateDown();
			}
		}
	}

	// Token: 0x060018E4 RID: 6372 RVA: 0x000748C0 File Offset: 0x00072AC0
	private void DisableRenderers()
	{
		for (int i = 0; i < this.spriteRenderers.Length; i++)
		{
			if (this.spriteRenderers[i] != null)
			{
				this.spriteRenderers[i].enabled = false;
			}
		}
		for (int j = 0; j < this.texts.Length; j++)
		{
			if (this.texts[j] != null)
			{
				Color color = this.texts[j].color;
				color.a = 0f;
				this.texts[j].color = color;
				this.texts[j].gameObject.GetComponent<MeshRenderer>().SetActiveWithChildren(false);
			}
		}
	}

	// Token: 0x060018E5 RID: 6373 RVA: 0x00074964 File Offset: 0x00072B64
	public FadeGroup()
	{
		this.fadeInTime = 0.2f;
		this.fadeOutTime = 0.2f;
		this.fadeOutTimeFast = 0.2f;
		this.fullAlpha = 1f;
		this.fadeOutColour = new Color(1f, 1f, 1f, 0f);
		this.fadeInColour = new Color(1f, 1f, 1f, 1f);
		base..ctor();
	}

	// Token: 0x04001DCD RID: 7629
	public SpriteRenderer[] spriteRenderers;

	// Token: 0x04001DCE RID: 7630
	public TextMeshPro[] texts;

	// Token: 0x04001DCF RID: 7631
	public InvAnimateUpAndDown[] animators;

	// Token: 0x04001DD0 RID: 7632
	public float fadeInTime;

	// Token: 0x04001DD1 RID: 7633
	public float fadeOutTime;

	// Token: 0x04001DD2 RID: 7634
	public float fadeOutTimeFast;

	// Token: 0x04001DD3 RID: 7635
	public float fullAlpha;

	// Token: 0x04001DD4 RID: 7636
	public float downAlpha;

	// Token: 0x04001DD5 RID: 7637
	public bool activateTexts;

	// Token: 0x04001DD6 RID: 7638
	private int state;

	// Token: 0x04001DD7 RID: 7639
	private float timer;

	// Token: 0x04001DD8 RID: 7640
	private Color currentColour;

	// Token: 0x04001DD9 RID: 7641
	private Color fadeOutColour;

	// Token: 0x04001DDA RID: 7642
	private Color fadeInColour;

	// Token: 0x04001DDB RID: 7643
	private float currentAlpha;

	// Token: 0x04001DDC RID: 7644
	public bool disableRenderersOnEnable;
}
