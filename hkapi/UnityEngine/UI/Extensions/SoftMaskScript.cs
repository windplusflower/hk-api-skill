using System;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x020006A5 RID: 1701
	[ExecuteInEditMode]
	[AddComponentMenu("UI/Effects/Extensions/SoftMaskScript")]
	public class SoftMaskScript : MonoBehaviour
	{
		// Token: 0x06002872 RID: 10354 RVA: 0x000E35D8 File Offset: 0x000E17D8
		private void Start()
		{
			if (this.MaskArea == null)
			{
				this.MaskArea = base.GetComponent<RectTransform>();
			}
			Text component = base.GetComponent<Text>();
			if (component != null)
			{
				this.mat = new Material(Shader.Find("UI Extensions/SoftMaskShader"));
				component.material = this.mat;
				this.cachedCanvas = component.canvas;
				this.cachedCanvasTransform = this.cachedCanvas.transform;
				if (base.transform.parent.GetComponent<Mask>() == null)
				{
					base.transform.parent.gameObject.AddComponent<Mask>();
				}
				base.transform.parent.GetComponent<Mask>().enabled = false;
				return;
			}
			Graphic component2 = base.GetComponent<Graphic>();
			if (component2 != null)
			{
				this.mat = new Material(Shader.Find("UI Extensions/SoftMaskShader"));
				component2.material = this.mat;
				this.cachedCanvas = component2.canvas;
				this.cachedCanvasTransform = this.cachedCanvas.transform;
			}
		}

		// Token: 0x06002873 RID: 10355 RVA: 0x000E36E3 File Offset: 0x000E18E3
		private void Update()
		{
			if (this.cachedCanvas != null)
			{
				this.SetMask();
			}
		}

		// Token: 0x06002874 RID: 10356 RVA: 0x000E36FC File Offset: 0x000E18FC
		private void SetMask()
		{
			Rect canvasRect = this.GetCanvasRect();
			Vector2 size = canvasRect.size;
			this.maskScale.Set(1f / size.x, 1f / size.y);
			this.maskOffset = -canvasRect.min;
			this.maskOffset.Scale(this.maskScale);
			this.mat.SetTextureOffset("_AlphaMask", this.maskOffset);
			this.mat.SetTextureScale("_AlphaMask", this.maskScale);
			this.mat.SetTexture("_AlphaMask", this.AlphaMask);
			this.mat.SetFloat("_HardBlend", (float)(this.HardBlend ? 1 : 0));
			this.mat.SetInt("_FlipAlphaMask", this.FlipAlphaMask ? 1 : 0);
			this.mat.SetFloat("_CutOff", this.CutOff);
		}

		// Token: 0x06002875 RID: 10357 RVA: 0x000E37F0 File Offset: 0x000E19F0
		public Rect GetCanvasRect()
		{
			if (this.cachedCanvas == null)
			{
				return default(Rect);
			}
			this.MaskArea.GetWorldCorners(this.m_WorldCorners);
			for (int i = 0; i < 4; i++)
			{
				this.m_CanvasCorners[i] = this.cachedCanvasTransform.InverseTransformPoint(this.m_WorldCorners[i]);
			}
			return new Rect(this.m_CanvasCorners[0].x, this.m_CanvasCorners[0].y, this.m_CanvasCorners[2].x - this.m_CanvasCorners[0].x, this.m_CanvasCorners[2].y - this.m_CanvasCorners[0].y);
		}

		// Token: 0x06002876 RID: 10358 RVA: 0x000E38C2 File Offset: 0x000E1AC2
		public SoftMaskScript()
		{
			this.m_WorldCorners = new Vector3[4];
			this.m_CanvasCorners = new Vector3[4];
			this.maskOffset = Vector2.zero;
			this.maskScale = Vector2.one;
			base..ctor();
		}

		// Token: 0x04002D82 RID: 11650
		private Material mat;

		// Token: 0x04002D83 RID: 11651
		private Canvas cachedCanvas;

		// Token: 0x04002D84 RID: 11652
		private Transform cachedCanvasTransform;

		// Token: 0x04002D85 RID: 11653
		private readonly Vector3[] m_WorldCorners;

		// Token: 0x04002D86 RID: 11654
		private readonly Vector3[] m_CanvasCorners;

		// Token: 0x04002D87 RID: 11655
		[Tooltip("The area that is to be used as the container.")]
		public RectTransform MaskArea;

		// Token: 0x04002D88 RID: 11656
		[Tooltip("Texture to be used to do the soft alpha")]
		public Texture AlphaMask;

		// Token: 0x04002D89 RID: 11657
		[Tooltip("At what point to apply the alpha min range 0-1")]
		[Range(0f, 1f)]
		public float CutOff;

		// Token: 0x04002D8A RID: 11658
		[Tooltip("Implement a hard blend based on the Cutoff")]
		public bool HardBlend;

		// Token: 0x04002D8B RID: 11659
		[Tooltip("Flip the masks alpha value")]
		public bool FlipAlphaMask;

		// Token: 0x04002D8C RID: 11660
		private Vector2 maskOffset;

		// Token: 0x04002D8D RID: 11661
		private Vector2 maskScale;
	}
}
