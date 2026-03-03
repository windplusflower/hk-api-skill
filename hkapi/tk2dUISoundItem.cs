using System;
using UnityEngine;

// Token: 0x020005A8 RID: 1448
[AddComponentMenu("2D Toolkit/UI/tk2dUISoundItem")]
public class tk2dUISoundItem : tk2dUIBaseItemControl
{
	// Token: 0x0600208A RID: 8330 RVA: 0x000A3F34 File Offset: 0x000A2134
	private void OnEnable()
	{
		if (this.uiItem)
		{
			if (this.downButtonSound != null)
			{
				this.uiItem.OnDown += this.PlayDownSound;
			}
			if (this.upButtonSound != null)
			{
				this.uiItem.OnUp += this.PlayUpSound;
			}
			if (this.clickButtonSound != null)
			{
				this.uiItem.OnClick += this.PlayClickSound;
			}
			if (this.releaseButtonSound != null)
			{
				this.uiItem.OnRelease += this.PlayReleaseSound;
			}
		}
	}

	// Token: 0x0600208B RID: 8331 RVA: 0x000A3FE8 File Offset: 0x000A21E8
	private void OnDisable()
	{
		if (this.uiItem)
		{
			if (this.downButtonSound != null)
			{
				this.uiItem.OnDown -= this.PlayDownSound;
			}
			if (this.upButtonSound != null)
			{
				this.uiItem.OnUp -= this.PlayUpSound;
			}
			if (this.clickButtonSound != null)
			{
				this.uiItem.OnClick -= this.PlayClickSound;
			}
			if (this.releaseButtonSound != null)
			{
				this.uiItem.OnRelease -= this.PlayReleaseSound;
			}
		}
	}

	// Token: 0x0600208C RID: 8332 RVA: 0x000A4099 File Offset: 0x000A2299
	private void PlayDownSound()
	{
		this.PlaySound(this.downButtonSound);
	}

	// Token: 0x0600208D RID: 8333 RVA: 0x000A40A7 File Offset: 0x000A22A7
	private void PlayUpSound()
	{
		this.PlaySound(this.upButtonSound);
	}

	// Token: 0x0600208E RID: 8334 RVA: 0x000A40B5 File Offset: 0x000A22B5
	private void PlayClickSound()
	{
		this.PlaySound(this.clickButtonSound);
	}

	// Token: 0x0600208F RID: 8335 RVA: 0x000A40C3 File Offset: 0x000A22C3
	private void PlayReleaseSound()
	{
		this.PlaySound(this.releaseButtonSound);
	}

	// Token: 0x06002090 RID: 8336 RVA: 0x000A40D1 File Offset: 0x000A22D1
	private void PlaySound(AudioClip source)
	{
		tk2dUIAudioManager.Instance.Play(source);
	}

	// Token: 0x04002639 RID: 9785
	public AudioClip downButtonSound;

	// Token: 0x0400263A RID: 9786
	public AudioClip upButtonSound;

	// Token: 0x0400263B RID: 9787
	public AudioClip clickButtonSound;

	// Token: 0x0400263C RID: 9788
	public AudioClip releaseButtonSound;
}
