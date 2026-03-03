using System;
using UnityEngine;

// Token: 0x0200013D RID: 317
[RequireComponent(typeof(GameCameras))]
public class LightBlurredBackground : MonoBehaviour
{
	// Token: 0x170000C6 RID: 198
	// (get) Token: 0x06000764 RID: 1892 RVA: 0x0002A51C File Offset: 0x0002871C
	// (set) Token: 0x06000765 RID: 1893 RVA: 0x0002A524 File Offset: 0x00028724
	public int RenderTextureHeight
	{
		get
		{
			return this.renderTextureHeight;
		}
		set
		{
			this.renderTextureHeight = value;
		}
	}

	// Token: 0x06000766 RID: 1894 RVA: 0x0002A52D File Offset: 0x0002872D
	protected void Awake()
	{
		this.gameCameras = base.GetComponent<GameCameras>();
		this.sceneCamera = this.gameCameras.tk2dCam.GetComponent<Camera>();
		this.passGroupCount = 2;
	}

	// Token: 0x06000767 RID: 1895 RVA: 0x0002A558 File Offset: 0x00028758
	protected void OnEnable()
	{
		this.distantFarClipPlane = this.sceneCamera.farClipPlane;
		GameObject gameObject = new GameObject("BlurCamera");
		gameObject.transform.SetParent(this.sceneCamera.transform);
		this.backgroundCamera = gameObject.AddComponent<Camera>();
		this.backgroundCamera.CopyFrom(this.sceneCamera);
		this.backgroundCamera.farClipPlane = this.distantFarClipPlane;
		this.backgroundCamera.cullingMask &= ~this.blurPlaneLayer.value;
		this.backgroundCamera.depth -= 5f;
		this.backgroundCamera.rect = new Rect(0f, 0f, 1f, 1f);
		this.lightBlur = gameObject.AddComponent<LightBlur>();
		this.lightBlur.PassGroupCount = this.passGroupCount;
		this.UpdateCameraClipPlanes();
		this.blitMaterialInstance = new Material(this.blitMaterial);
		this.blitMaterialInstance.EnableKeyword("BLUR_PLANE");
		this.OnCameraAspectChanged(ForceCameraAspect.CurrentViewportAspect);
		ForceCameraAspect.ViewportAspectChanged += this.OnCameraAspectChanged;
		this.OnBlurPlanesChanged();
		BlurPlane.BlurPlanesChanged += this.OnBlurPlanesChanged;
	}

	// Token: 0x06000768 RID: 1896 RVA: 0x0002A698 File Offset: 0x00028898
	private void OnCameraAspectChanged(float aspect)
	{
		if (aspect <= Mathf.Epsilon)
		{
			return;
		}
		int num = Mathf.RoundToInt((float)this.renderTextureHeight * aspect);
		if (num <= 0)
		{
			return;
		}
		if (this.renderTexture != null)
		{
			UnityEngine.Object.Destroy(this.renderTexture);
		}
		this.renderTexture = new RenderTexture(num, this.renderTextureHeight, 16, RenderTextureFormat.Default);
		this.backgroundCamera.targetTexture = this.renderTexture;
		this.blitMaterialInstance.mainTexture = this.renderTexture;
	}

	// Token: 0x06000769 RID: 1897 RVA: 0x0002A714 File Offset: 0x00028914
	protected void OnDisable()
	{
		ForceCameraAspect.ViewportAspectChanged -= this.OnCameraAspectChanged;
		BlurPlane.BlurPlanesChanged -= this.OnBlurPlanesChanged;
		for (int i = 0; i < BlurPlane.BlurPlaneCount; i++)
		{
			BlurPlane blurPlane = BlurPlane.GetBlurPlane(i);
			blurPlane.SetPlaneMaterial(null);
			blurPlane.SetPlaneVisibility(true);
		}
		UnityEngine.Object.Destroy(this.blitMaterialInstance);
		this.blitMaterialInstance = null;
		this.lightBlur = null;
		this.backgroundCamera.targetTexture = null;
		UnityEngine.Object.Destroy(this.renderTexture);
		this.renderTexture = null;
		this.sceneCamera.farClipPlane = this.distantFarClipPlane;
		UnityEngine.Object.DestroyObject(this.backgroundCamera.gameObject);
		this.backgroundCamera = null;
	}

	// Token: 0x170000C7 RID: 199
	// (get) Token: 0x0600076A RID: 1898 RVA: 0x0002A7C5 File Offset: 0x000289C5
	// (set) Token: 0x0600076B RID: 1899 RVA: 0x0002A7CD File Offset: 0x000289CD
	public int PassGroupCount
	{
		get
		{
			return this.passGroupCount;
		}
		set
		{
			this.passGroupCount = value;
			if (this.lightBlur != null)
			{
				this.lightBlur.PassGroupCount = this.passGroupCount;
			}
		}
	}

	// Token: 0x0600076C RID: 1900 RVA: 0x0002A7F8 File Offset: 0x000289F8
	private void OnBlurPlanesChanged()
	{
		for (int i = 0; i < BlurPlane.BlurPlaneCount; i++)
		{
			BlurPlane blurPlane = BlurPlane.GetBlurPlane(i);
			blurPlane.SetPlaneVisibility(true);
			blurPlane.SetPlaneMaterial(this.blitMaterialInstance);
			float @float = blurPlane.OriginalMaterial.GetFloat(LightBlurredBackground._vibrancyProp);
			this.blitMaterialInstance.SetFloat(LightBlurredBackground._blurPlaneVibranceProp, @float);
		}
		this.UpdateCameraClipPlanes();
	}

	// Token: 0x0600076D RID: 1901 RVA: 0x0002A855 File Offset: 0x00028A55
	protected void LateUpdate()
	{
		this.UpdateCameraClipPlanes();
	}

	// Token: 0x0600076E RID: 1902 RVA: 0x0002A860 File Offset: 0x00028A60
	private void UpdateCameraClipPlanes()
	{
		BlurPlane closestBlurPlane = BlurPlane.ClosestBlurPlane;
		if (closestBlurPlane != null)
		{
			this.sceneCamera.farClipPlane = closestBlurPlane.PlaneZ - this.sceneCamera.transform.GetPositionZ() + this.clipEpsilon;
			this.backgroundCamera.nearClipPlane = closestBlurPlane.PlaneZ - this.backgroundCamera.transform.GetPositionZ() + this.clipEpsilon;
			return;
		}
		this.sceneCamera.farClipPlane = this.distantFarClipPlane;
		this.backgroundCamera.nearClipPlane = this.distantFarClipPlane;
	}

	// Token: 0x06000770 RID: 1904 RVA: 0x0002A8F1 File Offset: 0x00028AF1
	// Note: this type is marked as 'beforefieldinit'.
	static LightBlurredBackground()
	{
		LightBlurredBackground._vibrancyProp = Shader.PropertyToID("_Vibrancy");
		LightBlurredBackground._blurPlaneVibranceProp = Shader.PropertyToID("_BlurPlaneVibrance");
	}

	// Token: 0x0400083D RID: 2109
	[SerializeField]
	private float distantFarClipPlane;

	// Token: 0x0400083E RID: 2110
	[SerializeField]
	private int renderTextureHeight;

	// Token: 0x0400083F RID: 2111
	[SerializeField]
	private Material blitMaterial;

	// Token: 0x04000840 RID: 2112
	[SerializeField]
	private float clipEpsilon;

	// Token: 0x04000841 RID: 2113
	[SerializeField]
	private LayerMask blurPlaneLayer;

	// Token: 0x04000842 RID: 2114
	private GameCameras gameCameras;

	// Token: 0x04000843 RID: 2115
	private Camera sceneCamera;

	// Token: 0x04000844 RID: 2116
	private Camera backgroundCamera;

	// Token: 0x04000845 RID: 2117
	private RenderTexture renderTexture;

	// Token: 0x04000846 RID: 2118
	private Material blurMaterialInstance;

	// Token: 0x04000847 RID: 2119
	private Material blitMaterialInstance;

	// Token: 0x04000848 RID: 2120
	private LightBlur lightBlur;

	// Token: 0x04000849 RID: 2121
	private int passGroupCount;

	// Token: 0x0400084A RID: 2122
	private static readonly int _vibrancyProp;

	// Token: 0x0400084B RID: 2123
	private static readonly int _blurPlaneVibranceProp;
}
