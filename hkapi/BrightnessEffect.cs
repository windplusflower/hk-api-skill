using System;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

// Token: 0x02000126 RID: 294
[ExecuteInEditMode]
[AddComponentMenu("Image Effects/Custom/Brightness Effect")]
public class BrightnessEffect : ImageEffectBase
{
	// Token: 0x060006D3 RID: 1747 RVA: 0x000275A0 File Offset: 0x000257A0
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		base.material.SetFloat("_Brightness", this._Brightness);
		base.material.SetFloat("_Contrast", this._Contrast);
		Graphics.Blit(source, destination, base.material);
		if (GameCameraTextureDisplay.Instance)
		{
			GameCameraTextureDisplay.Instance.UpdateDisplay(source, base.material);
		}
	}

	// Token: 0x060006D4 RID: 1748 RVA: 0x00027603 File Offset: 0x00025803
	public void SetBrightness(float value)
	{
		this._Brightness = value;
	}

	// Token: 0x060006D5 RID: 1749 RVA: 0x0002760C File Offset: 0x0002580C
	public void SetContrast(float value)
	{
		this._Contrast = value;
	}

	// Token: 0x060006D6 RID: 1750 RVA: 0x00027615 File Offset: 0x00025815
	public BrightnessEffect()
	{
		this._Brightness = 1f;
		this._Contrast = 1f;
		base..ctor();
	}

	// Token: 0x0400075F RID: 1887
	[Range(0f, 2f)]
	public float _Brightness;

	// Token: 0x04000760 RID: 1888
	[Range(0f, 2f)]
	public float _Contrast;
}
