using System;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

// Token: 0x0200013C RID: 316
public class LightBlur : PostEffectsBase
{
	// Token: 0x170000C4 RID: 196
	// (get) Token: 0x0600075C RID: 1884 RVA: 0x0002A359 File Offset: 0x00028559
	// (set) Token: 0x0600075D RID: 1885 RVA: 0x0002A361 File Offset: 0x00028561
	public int PassGroupCount
	{
		get
		{
			return this.passGroupCount;
		}
		set
		{
			this.passGroupCount = value;
		}
	}

	// Token: 0x170000C5 RID: 197
	// (get) Token: 0x0600075E RID: 1886 RVA: 0x0002A36A File Offset: 0x0002856A
	public int BlurPassCount
	{
		get
		{
			return this.passGroupCount * 2;
		}
	}

	// Token: 0x0600075F RID: 1887 RVA: 0x0002A374 File Offset: 0x00028574
	protected void Awake()
	{
		this.passGroupCount = 2;
	}

	// Token: 0x06000760 RID: 1888 RVA: 0x0002A37D File Offset: 0x0002857D
	protected void OnDestroy()
	{
		if (this.blurMaterial != null)
		{
			UnityEngine.Object.Destroy(this.blurMaterial);
		}
		this.blurMaterial = null;
	}

	// Token: 0x06000761 RID: 1889 RVA: 0x0002A3A0 File Offset: 0x000285A0
	public override bool CheckResources()
	{
		bool flag = true;
		if (this.blurInfoId == 0)
		{
			this.blurInfoId = Shader.PropertyToID("_BlurInfo");
		}
		if (this.blurShader == null)
		{
			this.blurShader = Shader.Find("Hollow Knight/Light Blur");
			if (this.blurShader == null)
			{
				Debug.LogErrorFormat(this, "Failed to find shader {0}", new object[]
				{
					"Hollow Knight/Light Blur"
				});
				flag = false;
			}
		}
		if (this.blurMaterial == null)
		{
			this.blurMaterial = base.CheckShaderAndCreateMaterial(this.blurShader, this.blurMaterial);
		}
		return base.CheckSupport() && flag;
	}

	// Token: 0x06000762 RID: 1890 RVA: 0x0002A43C File Offset: 0x0002863C
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		if (!this.CheckResources())
		{
			Debug.LogWarningFormat(this, "Light blur misconfigured or unsupported", Array.Empty<object>());
			base.enabled = false;
			Graphics.Blit(source, destination);
			return;
		}
		RenderTexture renderTexture = source;
		for (int i = 0; i < this.BlurPassCount; i++)
		{
			RenderTexture renderTexture2;
			if (i == this.BlurPassCount - 1)
			{
				renderTexture2 = destination;
			}
			else
			{
				renderTexture2 = RenderTexture.GetTemporary(source.width, source.height, 16, source.format);
			}
			this.blurMaterial.SetVector(this.blurInfoId, new Vector4(1f / (float)source.width, 1f / (float)source.height, 0f, 0f));
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(renderTexture, renderTexture2, this.blurMaterial, i % 2);
			if (renderTexture != source)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
			renderTexture = renderTexture2;
		}
	}

	// Token: 0x04000835 RID: 2101
	private const string BlurShaderName = "Hollow Knight/Light Blur";

	// Token: 0x04000836 RID: 2102
	private const int BlurMaterialPassCount = 2;

	// Token: 0x04000837 RID: 2103
	private int passGroupCount;

	// Token: 0x04000838 RID: 2104
	private const int BlurPassCountMax = 4;

	// Token: 0x04000839 RID: 2105
	private const string BlurInfoPropertyName = "_BlurInfo";

	// Token: 0x0400083A RID: 2106
	private int blurInfoId;

	// Token: 0x0400083B RID: 2107
	private Shader blurShader;

	// Token: 0x0400083C RID: 2108
	private Material blurMaterial;
}
