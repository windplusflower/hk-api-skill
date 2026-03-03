using System;
using UnityEngine;

// Token: 0x0200055F RID: 1375
[AddComponentMenu("2D Toolkit/Deprecated/Extra/tk2dPixelPerfectHelper")]
public class tk2dPixelPerfectHelper : MonoBehaviour
{
	// Token: 0x170003E4 RID: 996
	// (get) Token: 0x06001E8A RID: 7818 RVA: 0x00097AE0 File Offset: 0x00095CE0
	public static tk2dPixelPerfectHelper inst
	{
		get
		{
			if (tk2dPixelPerfectHelper._inst == null)
			{
				tk2dPixelPerfectHelper._inst = (UnityEngine.Object.FindObjectOfType(typeof(tk2dPixelPerfectHelper)) as tk2dPixelPerfectHelper);
				if (tk2dPixelPerfectHelper._inst == null)
				{
					return null;
				}
				tk2dPixelPerfectHelper.inst.Setup();
			}
			return tk2dPixelPerfectHelper._inst;
		}
	}

	// Token: 0x06001E8B RID: 7819 RVA: 0x00097B31 File Offset: 0x00095D31
	private void Awake()
	{
		this.Setup();
		tk2dPixelPerfectHelper._inst = this;
	}

	// Token: 0x06001E8C RID: 7820 RVA: 0x00097B40 File Offset: 0x00095D40
	public virtual void Setup()
	{
		float num = (float)this.collectionTargetHeight / this.targetResolutionHeight;
		if (base.GetComponent<Camera>() != null)
		{
			this.cam = base.GetComponent<Camera>();
		}
		if (this.cam == null)
		{
			this.cam = Camera.main;
		}
		if (this.cam.orthographic)
		{
			this.scaleK = num * this.cam.orthographicSize / this.collectionOrthoSize;
			this.scaleD = 0f;
			return;
		}
		float num2 = num * Mathf.Tan(0.017453292f * this.cam.fieldOfView * 0.5f) / this.collectionOrthoSize;
		this.scaleK = num2 * -this.cam.transform.position.z;
		this.scaleD = num2;
	}

	// Token: 0x06001E8D RID: 7821 RVA: 0x00097C0D File Offset: 0x00095E0D
	public static float CalculateScaleForPerspectiveCamera(float fov, float zdist)
	{
		return Mathf.Abs(Mathf.Tan(0.017453292f * fov * 0.5f) * zdist);
	}

	// Token: 0x170003E5 RID: 997
	// (get) Token: 0x06001E8E RID: 7822 RVA: 0x00097C28 File Offset: 0x00095E28
	public bool CameraIsOrtho
	{
		get
		{
			return this.cam.orthographic;
		}
	}

	// Token: 0x06001E8F RID: 7823 RVA: 0x00097C35 File Offset: 0x00095E35
	public tk2dPixelPerfectHelper()
	{
		this.collectionTargetHeight = 640;
		this.collectionOrthoSize = 1f;
		this.targetResolutionHeight = 640f;
		base..ctor();
	}

	// Token: 0x040023D8 RID: 9176
	private static tk2dPixelPerfectHelper _inst;

	// Token: 0x040023D9 RID: 9177
	[NonSerialized]
	public Camera cam;

	// Token: 0x040023DA RID: 9178
	public int collectionTargetHeight;

	// Token: 0x040023DB RID: 9179
	public float collectionOrthoSize;

	// Token: 0x040023DC RID: 9180
	public float targetResolutionHeight;

	// Token: 0x040023DD RID: 9181
	[NonSerialized]
	public float scaleD;

	// Token: 0x040023DE RID: 9182
	[NonSerialized]
	public float scaleK;
}
