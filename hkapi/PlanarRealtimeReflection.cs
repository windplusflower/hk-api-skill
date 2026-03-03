using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000050 RID: 80
[ExecuteInEditMode]
public class PlanarRealtimeReflection : MonoBehaviour
{
	// Token: 0x060001A5 RID: 421 RVA: 0x0000AE18 File Offset: 0x00009018
	public void OnWillRenderObject()
	{
		if (!base.enabled || !base.GetComponent<Renderer>() || !base.GetComponent<Renderer>().sharedMaterial || !base.GetComponent<Renderer>().enabled)
		{
			return;
		}
		Camera current = Camera.current;
		if (!current)
		{
			return;
		}
		if (this.m_NormalsFromMesh && base.GetComponent<MeshFilter>() != null)
		{
			this.m_calculatedNormal = base.transform.TransformDirection(base.GetComponent<MeshFilter>().sharedMesh.normals[0]);
		}
		if (this.m_BaseClipOffsetFromMesh && base.GetComponent<MeshFilter>() != null)
		{
			this.m_finalClipPlaneOffset = (base.transform.position - base.transform.TransformPoint(base.GetComponent<MeshFilter>().sharedMesh.vertices[0])).magnitude + this.m_clipPlaneOffset;
		}
		else if (this.m_BaseClipOffsetFromMeshInverted && base.GetComponent<MeshFilter>() != null)
		{
			this.m_finalClipPlaneOffset = -(base.transform.position - base.transform.TransformPoint(base.GetComponent<MeshFilter>().sharedMesh.vertices[0])).magnitude + this.m_clipPlaneOffset;
		}
		else
		{
			this.m_finalClipPlaneOffset = this.m_clipPlaneOffset;
		}
		if (PlanarRealtimeReflection.s_InsideRendering)
		{
			return;
		}
		PlanarRealtimeReflection.s_InsideRendering = true;
		Camera camera;
		this.CreateSurfaceObjects(current, out camera);
		Vector3 position = base.transform.position;
		Vector3 vector = (this.m_NormalsFromMesh && base.GetComponent<MeshFilter>() != null) ? this.m_calculatedNormal : base.transform.up;
		int pixelLightCount = QualitySettings.pixelLightCount;
		if (this.m_DisablePixelLights)
		{
			QualitySettings.pixelLightCount = 0;
		}
		this.UpdateCameraModes(current, camera);
		float w = -Vector3.Dot(vector, position) - this.m_finalClipPlaneOffset;
		Vector4 plane = new Vector4(vector.x, vector.y, vector.z, w);
		Matrix4x4 zero = Matrix4x4.zero;
		PlanarRealtimeReflection.CalculateReflectionMatrix(ref zero, plane);
		Vector3 position2 = current.transform.position;
		Vector3 position3 = zero.MultiplyPoint(position2);
		camera.worldToCameraMatrix = current.worldToCameraMatrix * zero;
		Vector4 clipPlane = this.CameraSpacePlane(camera, position, vector, 1f);
		Matrix4x4 projectionMatrix = current.projectionMatrix;
		PlanarRealtimeReflection.CalculateObliqueMatrix(ref projectionMatrix, clipPlane);
		camera.projectionMatrix = projectionMatrix;
		camera.cullingMask = (-17 & this.m_ReflectLayers.value);
		camera.targetTexture = this.m_ReflectionTexture;
		GL.SetRevertBackfacing(true);
		camera.transform.position = position3;
		Vector3 eulerAngles = current.transform.eulerAngles;
		camera.transform.eulerAngles = new Vector3(0f, eulerAngles.y, eulerAngles.z);
		camera.Render();
		camera.transform.position = position2;
		GL.SetRevertBackfacing(false);
		Material[] sharedMaterials = base.GetComponent<Renderer>().sharedMaterials;
		foreach (Material material in sharedMaterials)
		{
			if (material.HasProperty("_ReflectionTex"))
			{
				material.SetTexture("_ReflectionTex", this.m_ReflectionTexture);
			}
		}
		Matrix4x4 lhs = Matrix4x4.TRS(new Vector3(0.5f, 0.5f, 0.5f), Quaternion.identity, new Vector3(0.5f, 0.5f, 0.5f));
		Vector3 lossyScale = base.transform.lossyScale;
		Matrix4x4 matrix4x = base.transform.localToWorldMatrix * Matrix4x4.Scale(new Vector3(1f / lossyScale.x, 1f / lossyScale.y, 1f / lossyScale.z));
		matrix4x = lhs * current.projectionMatrix * current.worldToCameraMatrix * matrix4x;
		Material[] array = sharedMaterials;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].SetMatrix("_ProjMatrix", matrix4x);
		}
		if (this.m_DisablePixelLights)
		{
			QualitySettings.pixelLightCount = pixelLightCount;
		}
		PlanarRealtimeReflection.s_InsideRendering = false;
	}

	// Token: 0x060001A6 RID: 422 RVA: 0x0000B210 File Offset: 0x00009410
	private void OnDisable()
	{
		if (this.m_ReflectionTexture)
		{
			UnityEngine.Object.DestroyImmediate(this.m_ReflectionTexture);
			this.m_ReflectionTexture = null;
		}
		foreach (object obj in this.m_ReflectionCameras)
		{
			UnityEngine.Object.DestroyImmediate(((Camera)((DictionaryEntry)obj).Value).gameObject);
		}
		this.m_ReflectionCameras.Clear();
	}

	// Token: 0x060001A7 RID: 423 RVA: 0x0000B2A4 File Offset: 0x000094A4
	private void UpdateCameraModes(Camera src, Camera dest)
	{
		if (dest == null)
		{
			return;
		}
		dest.clearFlags = src.clearFlags;
		dest.backgroundColor = src.backgroundColor;
		if (src.clearFlags == CameraClearFlags.Skybox)
		{
			Skybox skybox = src.GetComponent(typeof(Skybox)) as Skybox;
			Skybox skybox2 = dest.GetComponent(typeof(Skybox)) as Skybox;
			if (!skybox || !skybox.material)
			{
				skybox2.enabled = false;
			}
			else
			{
				skybox2.enabled = true;
				skybox2.material = skybox.material;
			}
		}
		dest.farClipPlane = src.farClipPlane;
		dest.nearClipPlane = src.nearClipPlane;
		dest.orthographic = src.orthographic;
		dest.fieldOfView = src.fieldOfView;
		dest.aspect = src.aspect;
		dest.orthographicSize = src.orthographicSize;
	}

	// Token: 0x060001A8 RID: 424 RVA: 0x0000B384 File Offset: 0x00009584
	private void CreateSurfaceObjects(Camera currentCamera, out Camera reflectionCamera)
	{
		reflectionCamera = null;
		if (!this.m_ReflectionTexture || this.m_OldReflectionTextureSize != this.m_TextureResolution)
		{
			if (this.m_ReflectionTexture)
			{
				UnityEngine.Object.DestroyImmediate(this.m_ReflectionTexture);
			}
			this.m_ReflectionTexture = new RenderTexture(this.m_TextureResolution, this.m_TextureResolution, 16);
			this.m_ReflectionTexture.name = "__SurfaceReflection" + base.GetInstanceID().ToString();
			this.m_ReflectionTexture.isPowerOfTwo = true;
			this.m_ReflectionTexture.hideFlags = HideFlags.DontSave;
			this.m_OldReflectionTextureSize = this.m_TextureResolution;
		}
		reflectionCamera = (this.m_ReflectionCameras[currentCamera] as Camera);
		if (!reflectionCamera)
		{
			GameObject gameObject = new GameObject("Surface Refl Camera id" + base.GetInstanceID().ToString() + " for " + currentCamera.GetInstanceID().ToString(), new Type[]
			{
				typeof(Camera),
				typeof(Skybox)
			});
			reflectionCamera = gameObject.GetComponent<Camera>();
			reflectionCamera.enabled = false;
			reflectionCamera.transform.position = base.transform.position;
			reflectionCamera.transform.rotation = base.transform.rotation;
			reflectionCamera.gameObject.AddComponent<FlareLayer>();
			gameObject.hideFlags = HideFlags.HideAndDontSave;
			this.m_ReflectionCameras[currentCamera] = reflectionCamera;
		}
	}

	// Token: 0x060001A9 RID: 425 RVA: 0x0000B4F9 File Offset: 0x000096F9
	private static float sgn(float a)
	{
		if (a > 0f)
		{
			return 1f;
		}
		if (a < 0f)
		{
			return -1f;
		}
		return 0f;
	}

	// Token: 0x060001AA RID: 426 RVA: 0x0000B51C File Offset: 0x0000971C
	private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
	{
		Vector3 point = pos + normal * this.m_finalClipPlaneOffset;
		Matrix4x4 worldToCameraMatrix = cam.worldToCameraMatrix;
		Vector3 lhs = worldToCameraMatrix.MultiplyPoint(point);
		Vector3 vector = worldToCameraMatrix.MultiplyVector(normal).normalized * sideSign;
		return new Vector4(vector.x, vector.y, vector.z, -Vector3.Dot(lhs, vector));
	}

	// Token: 0x060001AB RID: 427 RVA: 0x0000B584 File Offset: 0x00009784
	private static void CalculateObliqueMatrix(ref Matrix4x4 projection, Vector4 clipPlane)
	{
		Vector4 b = projection.inverse * new Vector4(PlanarRealtimeReflection.sgn(clipPlane.x), PlanarRealtimeReflection.sgn(clipPlane.y), 1f, 1f);
		Vector4 vector = clipPlane * (2f / Vector4.Dot(clipPlane, b));
		projection[2] = vector.x - projection[3];
		projection[6] = vector.y - projection[7];
		projection[10] = vector.z - projection[11];
		projection[14] = vector.w - projection[15];
	}

	// Token: 0x060001AC RID: 428 RVA: 0x0000B630 File Offset: 0x00009830
	private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
	{
		reflectionMat.m00 = 1f - 2f * plane[0] * plane[0];
		reflectionMat.m01 = -2f * plane[0] * plane[1];
		reflectionMat.m02 = -2f * plane[0] * plane[2];
		reflectionMat.m03 = -2f * plane[3] * plane[0];
		reflectionMat.m10 = -2f * plane[1] * plane[0];
		reflectionMat.m11 = 1f - 2f * plane[1] * plane[1];
		reflectionMat.m12 = -2f * plane[1] * plane[2];
		reflectionMat.m13 = -2f * plane[3] * plane[1];
		reflectionMat.m20 = -2f * plane[2] * plane[0];
		reflectionMat.m21 = -2f * plane[2] * plane[1];
		reflectionMat.m22 = 1f - 2f * plane[2] * plane[2];
		reflectionMat.m23 = -2f * plane[3] * plane[2];
		reflectionMat.m30 = 0f;
		reflectionMat.m31 = 0f;
		reflectionMat.m32 = 0f;
		reflectionMat.m33 = 1f;
	}

	// Token: 0x060001AD RID: 429 RVA: 0x0000B7D8 File Offset: 0x000099D8
	public PlanarRealtimeReflection()
	{
		this.m_DisablePixelLights = true;
		this.m_TextureResolution = 1024;
		this.m_clipPlaneOffset = 0.07f;
		this.m_calculatedNormal = Vector3.zero;
		this.m_ReflectLayers = -1;
		this.m_ReflectionCameras = new Hashtable();
		base..ctor();
	}

	// Token: 0x04000146 RID: 326
	public bool m_DisablePixelLights;

	// Token: 0x04000147 RID: 327
	public int m_TextureResolution;

	// Token: 0x04000148 RID: 328
	public float m_clipPlaneOffset;

	// Token: 0x04000149 RID: 329
	private float m_finalClipPlaneOffset;

	// Token: 0x0400014A RID: 330
	public bool m_NormalsFromMesh;

	// Token: 0x0400014B RID: 331
	public bool m_BaseClipOffsetFromMesh;

	// Token: 0x0400014C RID: 332
	public bool m_BaseClipOffsetFromMeshInverted;

	// Token: 0x0400014D RID: 333
	private Vector3 m_calculatedNormal;

	// Token: 0x0400014E RID: 334
	public LayerMask m_ReflectLayers;

	// Token: 0x0400014F RID: 335
	private Hashtable m_ReflectionCameras;

	// Token: 0x04000150 RID: 336
	private RenderTexture m_ReflectionTexture;

	// Token: 0x04000151 RID: 337
	private int m_OldReflectionTextureSize;

	// Token: 0x04000152 RID: 338
	private static bool s_InsideRendering;
}
