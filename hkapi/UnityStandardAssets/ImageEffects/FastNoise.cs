using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x020006A9 RID: 1705
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Noise/Fast Noise")]
	public class FastNoise : PostEffectsBase
	{
		// Token: 0x0600287A RID: 10362 RVA: 0x000E38F8 File Offset: 0x000E1AF8
		protected void OnDisable()
		{
			if (this.softnessTexture != null)
			{
				UnityEngine.Object.Destroy(this.softnessTexture);
				this.softnessTexture = null;
			}
		}

		// Token: 0x0600287B RID: 10363 RVA: 0x000E391A File Offset: 0x000E1B1A
		public override bool CheckResources()
		{
			base.CheckSupport(false);
			this.noiseMaterial = base.CheckShaderAndCreateMaterial(this.noiseShader, this.noiseMaterial);
			if (!this.isSupported)
			{
				base.ReportAutoDisable();
			}
			return this.isSupported;
		}

		// Token: 0x0600287C RID: 10364 RVA: 0x000E3950 File Offset: 0x000E1B50
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (Application.isEditor && !Application.isPlaying)
			{
				return;
			}
			if (!this.CheckResources() || null == this.noiseTexture)
			{
				Graphics.Blit(source, destination);
				if (null == this.noiseTexture)
				{
					Debug.LogWarning("FastNoise effect failing as noise texture is not assigned. please assign.", base.transform);
				}
				return;
			}
			this.softness = Mathf.Clamp(this.softness, 0f, 0.99f);
			if (this.noiseTexture)
			{
				this.noiseTexture.wrapMode = TextureWrapMode.Repeat;
				this.noiseTexture.filterMode = this.filterMode;
			}
			this.noiseMaterial.SetTexture("_NoiseTex", this.noiseTexture);
			this.noiseMaterial.SetVector("_NoisePerChannel", this.monochrome ? Vector3.one : this.intensities);
			this.noiseMaterial.SetVector("_NoiseTilingPerChannel", Vector3.one * this.monochromeTiling);
			this.noiseMaterial.SetVector("_MidGrey", new Vector3(this.midGrey, 1f / (1f - this.midGrey), -1f / this.midGrey));
			this.noiseMaterial.SetVector("_NoiseAmount", new Vector3(this.generalIntensity, this.blackIntensity, this.whiteIntensity) * this.intensityMultiplier);
			if (this.softness > Mathf.Epsilon)
			{
				int num = (int)((float)source.width * (1f - this.softness));
				int num2 = (int)((float)source.height * (1f - this.softness));
				if (this.softnessTexture != null && (this.softnessTexture.width != num || this.softnessTexture.height != num2))
				{
					UnityEngine.Object.Destroy(this.softnessTexture);
					this.softnessTexture = null;
				}
				if (this.softnessTexture == null)
				{
					this.softnessTexture = new RenderTexture(num, num2, 0);
				}
				FastNoise.DrawNoiseQuadGrid(source, this.softnessTexture, this.noiseMaterial, this.noiseTexture, 2, (int)this.frameRateMultiplier);
				this.noiseMaterial.SetTexture("_NoiseTex", this.softnessTexture);
				Graphics.Blit(source, destination, this.noiseMaterial, 1);
			}
			else
			{
				FastNoise.DrawNoiseQuadGrid(source, destination, this.noiseMaterial, this.noiseTexture, 0, (int)this.frameRateMultiplier);
			}
			this.frameCount += 1;
		}

		// Token: 0x0600287D RID: 10365 RVA: 0x000E3BCC File Offset: 0x000E1DCC
		private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, int passNr, int frameMultiple)
		{
			if (Time.frameCount % frameMultiple != 0)
			{
				return;
			}
			RenderTexture.active = dest;
			float num = (float)noise.width * 1f;
			float num2 = 1f * (float)source.width / FastNoise.TILE_AMOUNT;
			fxMaterial.SetTexture("_MainTex", source);
			GL.PushMatrix();
			GL.LoadOrtho();
			float num3 = 1f * (float)source.width / (1f * (float)source.height);
			float num4 = 1f / num2;
			float num5 = num4 * num3;
			float num6 = num / ((float)noise.width * 1f);
			fxMaterial.SetPass(passNr);
			GL.Begin(7);
			for (float num7 = 0f; num7 < 1f; num7 += num4)
			{
				for (float num8 = 0f; num8 < 1f; num8 += num5)
				{
					float num9 = UnityEngine.Random.Range(0f, 1f);
					float num10 = UnityEngine.Random.Range(0f, 1f);
					num9 = Mathf.Floor(num9 * num) / num;
					num10 = Mathf.Floor(num10 * num) / num;
					float num11 = 1f / num;
					GL.MultiTexCoord2(0, num9, num10);
					GL.MultiTexCoord2(1, 0f, 0f);
					GL.Vertex3(num7, num8, 0.1f);
					GL.MultiTexCoord2(0, num9 + num6 * num11, num10);
					GL.MultiTexCoord2(1, 1f, 0f);
					GL.Vertex3(num7 + num4, num8, 0.1f);
					GL.MultiTexCoord2(0, num9 + num6 * num11, num10 + num6 * num11);
					GL.MultiTexCoord2(1, 1f, 1f);
					GL.Vertex3(num7 + num4, num8 + num5, 0.1f);
					GL.MultiTexCoord2(0, num9, num10 + num6 * num11);
					GL.MultiTexCoord2(1, 0f, 1f);
					GL.Vertex3(num7, num8 + num5, 0.1f);
				}
			}
			GL.End();
			GL.PopMatrix();
		}

		// Token: 0x0600287E RID: 10366 RVA: 0x000E3DBC File Offset: 0x000E1FBC
		public FastNoise()
		{
			this.monochrome = true;
			this.frameRateMultiplier = FastNoise.FrameMultiple.Always;
			this.intensityMultiplier = 0.25f;
			this.generalIntensity = 0.5f;
			this.blackIntensity = 1f;
			this.whiteIntensity = 1f;
			this.midGrey = 0.2f;
			this.filterMode = FilterMode.Bilinear;
			this.intensities = new Vector3(1f, 1f, 1f);
			this.softness = 0.052f;
			this.monochromeTiling = 64f;
			base..ctor();
		}

		// Token: 0x0600287F RID: 10367 RVA: 0x000E3E4B File Offset: 0x000E204B
		// Note: this type is marked as 'beforefieldinit'.
		static FastNoise()
		{
			FastNoise.TILE_AMOUNT = 64f;
		}

		// Token: 0x04002D8E RID: 11662
		private bool monochrome;

		// Token: 0x04002D8F RID: 11663
		[Header("Update Rate")]
		public FastNoise.FrameMultiple frameRateMultiplier;

		// Token: 0x04002D90 RID: 11664
		[Header("Intensity")]
		public float intensityMultiplier;

		// Token: 0x04002D91 RID: 11665
		public float generalIntensity;

		// Token: 0x04002D92 RID: 11666
		public float blackIntensity;

		// Token: 0x04002D93 RID: 11667
		public float whiteIntensity;

		// Token: 0x04002D94 RID: 11668
		[Range(0f, 1f)]
		public float midGrey;

		// Token: 0x04002D95 RID: 11669
		[Header("Noise Shape")]
		public Texture2D noiseTexture;

		// Token: 0x04002D96 RID: 11670
		public FilterMode filterMode;

		// Token: 0x04002D97 RID: 11671
		[Range(0f, 0.99f)]
		private Vector3 intensities;

		// Token: 0x04002D98 RID: 11672
		[Range(0f, 0.99f)]
		public float softness;

		// Token: 0x04002D99 RID: 11673
		[Header("Advanced")]
		public float monochromeTiling;

		// Token: 0x04002D9A RID: 11674
		public Shader noiseShader;

		// Token: 0x04002D9B RID: 11675
		private Material noiseMaterial;

		// Token: 0x04002D9C RID: 11676
		private static float TILE_AMOUNT;

		// Token: 0x04002D9D RID: 11677
		private byte frameCount;

		// Token: 0x04002D9E RID: 11678
		private RenderTexture softnessTexture;

		// Token: 0x020006AA RID: 1706
		public enum FrameMultiple
		{
			// Token: 0x04002DA0 RID: 11680
			Always = 1,
			// Token: 0x04002DA1 RID: 11681
			Half,
			// Token: 0x04002DA2 RID: 11682
			Third,
			// Token: 0x04002DA3 RID: 11683
			Quarter,
			// Token: 0x04002DA4 RID: 11684
			Fifth,
			// Token: 0x04002DA5 RID: 11685
			Sixth,
			// Token: 0x04002DA6 RID: 11686
			Eighth = 8,
			// Token: 0x04002DA7 RID: 11687
			Tenth = 10
		}
	}
}
