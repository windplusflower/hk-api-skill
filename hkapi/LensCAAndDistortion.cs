using System;
using UnityEngine;

// Token: 0x0200000D RID: 13
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
[AddComponentMenu("Image Effects/Lens CA And Distortion")]
public class LensCAAndDistortion : MonoBehaviour
{
	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000040 RID: 64 RVA: 0x000034C2 File Offset: 0x000016C2
	private Material material
	{
		get
		{
			if (this.curMaterial == null)
			{
				this.curMaterial = new Material(this.LensShader);
				this.curMaterial.hideFlags = HideFlags.HideAndDontSave;
			}
			return this.curMaterial;
		}
	}

	// Token: 0x06000041 RID: 65 RVA: 0x000034F6 File Offset: 0x000016F6
	private void Start()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000042 RID: 66 RVA: 0x00003508 File Offset: 0x00001708
	private void OnRenderImage(RenderTexture sourceTexture, RenderTexture destTexture)
	{
		if (this.LensShader != null)
		{
			this.material.SetFloat("_RedCyan", this.RedCyan * 10f);
			this.material.SetFloat("_GreenMagenta", this.GreenMagenta * 10f);
			this.material.SetFloat("_BlueYellow", this.BlueYellow * 10f);
			this.material.SetFloat("_Zoom", 0f - this.Zoom);
			this.material.SetFloat("_BarrelDistortion", this.BarrelDistortion);
			this.material.SetTexture("_BorderTex", this.TrimTexture);
			if (this.TrimExtents)
			{
				this.material.SetInt("_BorderOnOff", 1);
			}
			else
			{
				this.material.SetInt("_BorderOnOff", 0);
			}
			Graphics.Blit(sourceTexture, destTexture, this.material);
			return;
		}
		Graphics.Blit(sourceTexture, destTexture);
	}

	// Token: 0x06000043 RID: 67 RVA: 0x00003603 File Offset: 0x00001803
	private void Update()
	{
	}

	// Token: 0x06000044 RID: 68 RVA: 0x00003605 File Offset: 0x00001805
	private void OnDisable()
	{
		if (this.curMaterial)
		{
			UnityEngine.Object.DestroyImmediate(this.curMaterial);
		}
	}

	// Token: 0x04000026 RID: 38
	public Shader LensShader;

	// Token: 0x04000027 RID: 39
	[Range(-10f, 10f)]
	public float RedCyan;

	// Token: 0x04000028 RID: 40
	[Range(-10f, 10f)]
	public float GreenMagenta;

	// Token: 0x04000029 RID: 41
	[Range(-10f, 10f)]
	public float BlueYellow;

	// Token: 0x0400002A RID: 42
	public bool TrimExtents;

	// Token: 0x0400002B RID: 43
	public Texture2D TrimTexture;

	// Token: 0x0400002C RID: 44
	[Range(-1f, 1f)]
	public float Zoom;

	// Token: 0x0400002D RID: 45
	[Range(-5f, 5f)]
	public float BarrelDistortion;

	// Token: 0x0400002E RID: 46
	private Material curMaterial;
}
