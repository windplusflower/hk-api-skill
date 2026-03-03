using System;
using UnityEngine;

// Token: 0x0200053B RID: 1339
[AddComponentMenu("2D Toolkit/Camera/tk2dCameraAnchor")]
[ExecuteInEditMode]
public class tk2dCameraAnchor : MonoBehaviour
{
	// Token: 0x170003A5 RID: 933
	// (get) Token: 0x06001D59 RID: 7513 RVA: 0x00091A80 File Offset: 0x0008FC80
	// (set) Token: 0x06001D5A RID: 7514 RVA: 0x00091AF3 File Offset: 0x0008FCF3
	public tk2dBaseSprite.Anchor AnchorPoint
	{
		get
		{
			if (this.anchor != -1)
			{
				if (this.anchor >= 0 && this.anchor <= 2)
				{
					this._anchorPoint = this.anchor + tk2dBaseSprite.Anchor.UpperLeft;
				}
				else if (this.anchor >= 6 && this.anchor <= 8)
				{
					this._anchorPoint = (tk2dBaseSprite.Anchor)(this.anchor - 6);
				}
				else
				{
					this._anchorPoint = (tk2dBaseSprite.Anchor)this.anchor;
				}
				this.anchor = -1;
			}
			return this._anchorPoint;
		}
		set
		{
			this._anchorPoint = value;
		}
	}

	// Token: 0x170003A6 RID: 934
	// (get) Token: 0x06001D5B RID: 7515 RVA: 0x00091AFC File Offset: 0x0008FCFC
	// (set) Token: 0x06001D5C RID: 7516 RVA: 0x00091B04 File Offset: 0x0008FD04
	public Vector2 AnchorOffsetPixels
	{
		get
		{
			return this.offset;
		}
		set
		{
			this.offset = value;
		}
	}

	// Token: 0x170003A7 RID: 935
	// (get) Token: 0x06001D5D RID: 7517 RVA: 0x00091B0D File Offset: 0x0008FD0D
	// (set) Token: 0x06001D5E RID: 7518 RVA: 0x00091B15 File Offset: 0x0008FD15
	public bool AnchorToNativeBounds
	{
		get
		{
			return this.anchorToNativeBounds;
		}
		set
		{
			this.anchorToNativeBounds = value;
		}
	}

	// Token: 0x170003A8 RID: 936
	// (get) Token: 0x06001D5F RID: 7519 RVA: 0x00091B1E File Offset: 0x0008FD1E
	// (set) Token: 0x06001D60 RID: 7520 RVA: 0x00091B4C File Offset: 0x0008FD4C
	public Camera AnchorCamera
	{
		get
		{
			if (this.tk2dCamera != null)
			{
				this._anchorCamera = this.tk2dCamera.GetComponent<Camera>();
				this.tk2dCamera = null;
			}
			return this._anchorCamera;
		}
		set
		{
			this._anchorCamera = value;
			this._anchorCameraCached = null;
		}
	}

	// Token: 0x170003A9 RID: 937
	// (get) Token: 0x06001D61 RID: 7521 RVA: 0x00091B5C File Offset: 0x0008FD5C
	private tk2dCamera AnchorTk2dCamera
	{
		get
		{
			if (this._anchorCameraCached != this._anchorCamera)
			{
				this._anchorTk2dCamera = this._anchorCamera.GetComponent<tk2dCamera>();
				this._anchorCameraCached = this._anchorCamera;
			}
			return this._anchorTk2dCamera;
		}
	}

	// Token: 0x170003AA RID: 938
	// (get) Token: 0x06001D62 RID: 7522 RVA: 0x00091B94 File Offset: 0x0008FD94
	private Transform myTransform
	{
		get
		{
			if (this._myTransform == null)
			{
				this._myTransform = base.transform;
			}
			return this._myTransform;
		}
	}

	// Token: 0x06001D63 RID: 7523 RVA: 0x00091BB6 File Offset: 0x0008FDB6
	private void Start()
	{
		this.UpdateTransform();
	}

	// Token: 0x06001D64 RID: 7524 RVA: 0x00091BC0 File Offset: 0x0008FDC0
	private void UpdateTransform()
	{
		if (this.AnchorCamera == null)
		{
			return;
		}
		float num = 1f;
		Vector3 localPosition = this.myTransform.localPosition;
		tk2dCamera tk2dCamera = (this.AnchorTk2dCamera != null && this.AnchorTk2dCamera.CameraSettings.projection != tk2dCameraSettings.ProjectionType.Perspective) ? this.AnchorTk2dCamera : null;
		Rect rect = default(Rect);
		if (tk2dCamera != null)
		{
			rect = (this.anchorToNativeBounds ? tk2dCamera.NativeScreenExtents : tk2dCamera.ScreenExtents);
			num = tk2dCamera.GetSizeAtDistance(1f);
		}
		else
		{
			rect.Set(0f, 0f, (float)this.AnchorCamera.pixelWidth, (float)this.AnchorCamera.pixelHeight);
		}
		float yMin = rect.yMin;
		float yMax = rect.yMax;
		float y = (yMin + yMax) * 0.5f;
		float xMin = rect.xMin;
		float xMax = rect.xMax;
		float x = (xMin + xMax) * 0.5f;
		Vector3 zero = Vector3.zero;
		switch (this.AnchorPoint)
		{
		case tk2dBaseSprite.Anchor.LowerLeft:
			zero = new Vector3(xMin, yMin, localPosition.z);
			break;
		case tk2dBaseSprite.Anchor.LowerCenter:
			zero = new Vector3(x, yMin, localPosition.z);
			break;
		case tk2dBaseSprite.Anchor.LowerRight:
			zero = new Vector3(xMax, yMin, localPosition.z);
			break;
		case tk2dBaseSprite.Anchor.MiddleLeft:
			zero = new Vector3(xMin, y, localPosition.z);
			break;
		case tk2dBaseSprite.Anchor.MiddleCenter:
			zero = new Vector3(x, y, localPosition.z);
			break;
		case tk2dBaseSprite.Anchor.MiddleRight:
			zero = new Vector3(xMax, y, localPosition.z);
			break;
		case tk2dBaseSprite.Anchor.UpperLeft:
			zero = new Vector3(xMin, yMax, localPosition.z);
			break;
		case tk2dBaseSprite.Anchor.UpperCenter:
			zero = new Vector3(x, yMax, localPosition.z);
			break;
		case tk2dBaseSprite.Anchor.UpperRight:
			zero = new Vector3(xMax, yMax, localPosition.z);
			break;
		}
		Vector3 vector = zero + new Vector3(num * this.offset.x, num * this.offset.y, 0f);
		if (tk2dCamera == null)
		{
			Vector3 vector2 = this.AnchorCamera.ScreenToWorldPoint(vector);
			if (this.myTransform.position != vector2)
			{
				this.myTransform.position = vector2;
				return;
			}
		}
		else if (this.myTransform.localPosition != vector)
		{
			this.myTransform.localPosition = vector;
		}
	}

	// Token: 0x06001D65 RID: 7525 RVA: 0x00091BB6 File Offset: 0x0008FDB6
	public void ForceUpdateTransform()
	{
		this.UpdateTransform();
	}

	// Token: 0x06001D66 RID: 7526 RVA: 0x00091BB6 File Offset: 0x0008FDB6
	private void LateUpdate()
	{
		this.UpdateTransform();
	}

	// Token: 0x06001D67 RID: 7527 RVA: 0x00091E2C File Offset: 0x0009002C
	public tk2dCameraAnchor()
	{
		this.anchor = -1;
		this._anchorPoint = tk2dBaseSprite.Anchor.UpperLeft;
		this.offset = Vector2.zero;
		base..ctor();
	}

	// Token: 0x040022CC RID: 8908
	[SerializeField]
	private int anchor;

	// Token: 0x040022CD RID: 8909
	[SerializeField]
	private tk2dBaseSprite.Anchor _anchorPoint;

	// Token: 0x040022CE RID: 8910
	[SerializeField]
	private bool anchorToNativeBounds;

	// Token: 0x040022CF RID: 8911
	[SerializeField]
	private Vector2 offset;

	// Token: 0x040022D0 RID: 8912
	[SerializeField]
	private tk2dCamera tk2dCamera;

	// Token: 0x040022D1 RID: 8913
	[SerializeField]
	private Camera _anchorCamera;

	// Token: 0x040022D2 RID: 8914
	private Camera _anchorCameraCached;

	// Token: 0x040022D3 RID: 8915
	private tk2dCamera _anchorTk2dCamera;

	// Token: 0x040022D4 RID: 8916
	private Transform _myTransform;
}
