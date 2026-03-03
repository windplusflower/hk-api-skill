using System;
using UnityEngine;

// Token: 0x020005B2 RID: 1458
[AddComponentMenu("2D Toolkit/UI/Core/tk2dUICamera")]
public class tk2dUICamera : MonoBehaviour
{
	// Token: 0x17000449 RID: 1097
	// (get) Token: 0x060020F4 RID: 8436 RVA: 0x000A57EE File Offset: 0x000A39EE
	public tk2dUICamera.tk2dRaycastType RaycastType
	{
		get
		{
			return this.raycastType;
		}
	}

	// Token: 0x060020F5 RID: 8437 RVA: 0x000A57F6 File Offset: 0x000A39F6
	public void AssignRaycastLayerMask(LayerMask mask)
	{
		this.raycastLayerMask = mask;
	}

	// Token: 0x1700044A RID: 1098
	// (get) Token: 0x060020F6 RID: 8438 RVA: 0x000A57FF File Offset: 0x000A39FF
	public LayerMask FilteredMask
	{
		get
		{
			return this.raycastLayerMask & base.GetComponent<Camera>().cullingMask;
		}
	}

	// Token: 0x1700044B RID: 1099
	// (get) Token: 0x060020F7 RID: 8439 RVA: 0x000A581D File Offset: 0x000A3A1D
	public Camera HostCamera
	{
		get
		{
			return base.GetComponent<Camera>();
		}
	}

	// Token: 0x060020F8 RID: 8440 RVA: 0x000A5828 File Offset: 0x000A3A28
	private void OnEnable()
	{
		if (base.GetComponent<Camera>() == null)
		{
			Debug.LogError("tk2dUICamera should only be attached to a camera.");
			base.enabled = false;
			return;
		}
		if (!base.GetComponent<Camera>().orthographic && this.raycastType == tk2dUICamera.tk2dRaycastType.Physics2D)
		{
			Debug.LogError("tk2dUICamera - Physics2D raycast only works with orthographic cameras.");
			base.enabled = false;
			return;
		}
		tk2dUIManager.RegisterCamera(this);
	}

	// Token: 0x060020F9 RID: 8441 RVA: 0x000A5883 File Offset: 0x000A3A83
	private void OnDisable()
	{
		tk2dUIManager.UnregisterCamera(this);
	}

	// Token: 0x060020FA RID: 8442 RVA: 0x000A588B File Offset: 0x000A3A8B
	public tk2dUICamera()
	{
		this.raycastLayerMask = -1;
		base..ctor();
	}

	// Token: 0x04002679 RID: 9849
	[SerializeField]
	private LayerMask raycastLayerMask;

	// Token: 0x0400267A RID: 9850
	[SerializeField]
	private tk2dUICamera.tk2dRaycastType raycastType;

	// Token: 0x020005B3 RID: 1459
	public enum tk2dRaycastType
	{
		// Token: 0x0400267C RID: 9852
		Physics3D,
		// Token: 0x0400267D RID: 9853
		Physics2D
	}
}
