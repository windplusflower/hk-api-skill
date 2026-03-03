using System;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000051 RID: 81
public class RealtimeReflections : MonoBehaviour
{
	// Token: 0x060001AF RID: 431 RVA: 0x0000B82A File Offset: 0x00009A2A
	private void OnEnable()
	{
		this.layerMask.value = -1;
	}

	// Token: 0x060001B0 RID: 432 RVA: 0x0000B838 File Offset: 0x00009A38
	private void Start()
	{
		foreach (ReflectionProbe reflectionProbe in this.reflectionProbes)
		{
			reflectionProbe.mode = ReflectionProbeMode.Realtime;
			reflectionProbe.boxProjection = true;
			reflectionProbe.resolution = this.cubemapSize;
			reflectionProbe.transform.parent = base.transform.parent;
			reflectionProbe.transform.localPosition = Vector3.zero;
		}
		if (this.materials.Length == 0)
		{
			return;
		}
		this.UpdateCubemap(63);
	}

	// Token: 0x060001B1 RID: 433 RVA: 0x0000B8B0 File Offset: 0x00009AB0
	private void LateUpdate()
	{
		if (this.materials.Length == 0)
		{
			return;
		}
		if (this.oneFacePerFrame)
		{
			int num = Time.frameCount % 6;
			int faceMask = 1 << num;
			this.UpdateCubemap(faceMask);
			return;
		}
		this.UpdateCubemap(63);
	}

	// Token: 0x060001B2 RID: 434 RVA: 0x0000B8F0 File Offset: 0x00009AF0
	private void UpdateCubemap(int faceMask)
	{
		if (!this.cam)
		{
			this.cam = new GameObject("CubemapCamera", new Type[]
			{
				typeof(Camera)
			})
			{
				hideFlags = HideFlags.HideAndDontSave,
				transform = 
				{
					position = base.transform.position,
					rotation = Quaternion.identity
				}
			}.GetComponent<Camera>();
			this.cam.cullingMask = this.layerMask;
			this.cam.nearClipPlane = this.nearClip;
			this.cam.farClipPlane = this.farClip;
			this.cam.enabled = false;
		}
		if (!this.renderTexture)
		{
			this.renderTexture = new RenderTexture(this.cubemapSize, this.cubemapSize, 16);
			this.renderTexture.isPowerOfTwo = true;
			this.renderTexture.isCubemap = true;
			this.renderTexture.hideFlags = HideFlags.HideAndDontSave;
			Renderer[] componentsInChildren = base.GetComponentsInChildren<Renderer>();
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				foreach (Material material in componentsInChildren[i].sharedMaterials)
				{
					if (material.HasProperty("_Cube"))
					{
						material.SetTexture("_Cube", this.renderTexture);
					}
				}
			}
			ReflectionProbe[] array = this.reflectionProbes;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].customBakedTexture = this.renderTexture;
			}
		}
		this.cam.transform.position = base.transform.position;
		this.cam.RenderToCubemap(this.renderTexture, faceMask);
	}

	// Token: 0x060001B3 RID: 435 RVA: 0x0000BAA1 File Offset: 0x00009CA1
	private void OnDisable()
	{
		UnityEngine.Object.DestroyImmediate(this.cam);
		UnityEngine.Object.DestroyImmediate(this.renderTexture);
	}

	// Token: 0x060001B4 RID: 436 RVA: 0x0000BAB9 File Offset: 0x00009CB9
	public RealtimeReflections()
	{
		this.cubemapSize = 128;
		this.nearClip = 0.01f;
		this.farClip = 500f;
		this.layerMask = -1;
		base..ctor();
	}

	// Token: 0x04000153 RID: 339
	public int cubemapSize;

	// Token: 0x04000154 RID: 340
	public float nearClip;

	// Token: 0x04000155 RID: 341
	public float farClip;

	// Token: 0x04000156 RID: 342
	public bool oneFacePerFrame;

	// Token: 0x04000157 RID: 343
	public Material[] materials;

	// Token: 0x04000158 RID: 344
	public ReflectionProbe[] reflectionProbes;

	// Token: 0x04000159 RID: 345
	public LayerMask layerMask;

	// Token: 0x0400015A RID: 346
	private Camera cam;

	// Token: 0x0400015B RID: 347
	private RenderTexture renderTexture;
}
