using System;
using UnityEngine;

// Token: 0x0200007B RID: 123
public class InvulnerablePulse : MonoBehaviour
{
	// Token: 0x060002A3 RID: 675 RVA: 0x0000EEF3 File Offset: 0x0000D0F3
	private void Start()
	{
		this.sprite = base.GetComponent<tk2dSprite>();
		this.normalColor = this.sprite.color;
		this.pulsing = false;
		this.currentLerpTime = 0f;
	}

	// Token: 0x060002A4 RID: 676 RVA: 0x0000EF24 File Offset: 0x0000D124
	private void Update()
	{
		if (this.pulsing)
		{
			if (!this.reverse)
			{
				this.currentLerpTime += Time.deltaTime;
				if (this.currentLerpTime > this.pulseDuration)
				{
					this.currentLerpTime = this.pulseDuration;
					this.reverse = true;
				}
			}
			else
			{
				this.currentLerpTime -= Time.deltaTime;
				if (this.currentLerpTime < 0f)
				{
					this.currentLerpTime = 0f;
					this.reverse = false;
				}
			}
			float t = this.currentLerpTime / this.pulseDuration;
			this.sprite.color = Color.Lerp(this.normalColor, this.invulColor, t);
		}
	}

	// Token: 0x060002A5 RID: 677 RVA: 0x0000EFD5 File Offset: 0x0000D1D5
	public void startInvulnerablePulse()
	{
		this.pulsing = true;
		this.currentLerpTime = 0f;
	}

	// Token: 0x060002A6 RID: 678 RVA: 0x0000EFE9 File Offset: 0x0000D1E9
	public void stopInvulnerablePulse()
	{
		this.pulsing = false;
		this.updateSpriteColor(this.normalColor);
		this.currentLerpTime = 0f;
	}

	// Token: 0x060002A7 RID: 679 RVA: 0x0000F009 File Offset: 0x0000D209
	public void updateSpriteColor(Color color)
	{
		this.sprite.color = color;
	}

	// Token: 0x0400022D RID: 557
	public Color invulColor;

	// Token: 0x0400022E RID: 558
	public float pulseDuration;

	// Token: 0x0400022F RID: 559
	private Color normalColor;

	// Token: 0x04000230 RID: 560
	private tk2dSprite sprite;

	// Token: 0x04000231 RID: 561
	private bool pulsing;

	// Token: 0x04000232 RID: 562
	private bool reverse;

	// Token: 0x04000233 RID: 563
	private float currentLerpTime;
}
