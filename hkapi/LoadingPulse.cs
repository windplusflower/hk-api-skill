using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000474 RID: 1140
public class LoadingPulse : MonoBehaviour
{
	// Token: 0x06001999 RID: 6553 RVA: 0x00079EFB File Offset: 0x000780FB
	private void Start()
	{
		this.sprite = base.GetComponent<Image>();
		this.normalColor = this.sprite.color;
		this.pulsing = true;
		this.currentLerpTime = 0f;
	}

	// Token: 0x0600199A RID: 6554 RVA: 0x00079F2C File Offset: 0x0007812C
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
			this.sprite.color = Color.Lerp(this.normalColor, this.pulseColor, t);
		}
	}

	// Token: 0x04001EBD RID: 7869
	public Color pulseColor;

	// Token: 0x04001EBE RID: 7870
	public float pulseDuration;

	// Token: 0x04001EBF RID: 7871
	private Image sprite;

	// Token: 0x04001EC0 RID: 7872
	private Color normalColor;

	// Token: 0x04001EC1 RID: 7873
	private bool pulsing;

	// Token: 0x04001EC2 RID: 7874
	private bool reverse;

	// Token: 0x04001EC3 RID: 7875
	private float currentLerpTime;
}
