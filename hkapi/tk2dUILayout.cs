using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020005B6 RID: 1462
[AddComponentMenu("2D Toolkit/UI/Core/tk2dUILayout")]
public class tk2dUILayout : MonoBehaviour
{
	// Token: 0x1700044F RID: 1103
	// (get) Token: 0x0600212C RID: 8492 RVA: 0x000A63EE File Offset: 0x000A45EE
	public int ItemCount
	{
		get
		{
			return this.layoutItems.Count;
		}
	}

	// Token: 0x1400005D RID: 93
	// (add) Token: 0x0600212D RID: 8493 RVA: 0x000A63FC File Offset: 0x000A45FC
	// (remove) Token: 0x0600212E RID: 8494 RVA: 0x000A6434 File Offset: 0x000A4634
	public event Action<Vector3, Vector3> OnReshape;

	// Token: 0x0600212F RID: 8495 RVA: 0x000A646C File Offset: 0x000A466C
	private void Reset()
	{
		if (base.GetComponent<Collider>() != null)
		{
			BoxCollider boxCollider = base.GetComponent<Collider>() as BoxCollider;
			if (boxCollider != null)
			{
				Bounds bounds = boxCollider.bounds;
				Matrix4x4 worldToLocalMatrix = base.transform.worldToLocalMatrix;
				Vector3 position = base.transform.position;
				this.Reshape(worldToLocalMatrix.MultiplyPoint(bounds.min) - this.bMin, worldToLocalMatrix.MultiplyPoint(bounds.max) - this.bMax, true);
				Vector3 b = worldToLocalMatrix.MultiplyVector(base.transform.position - position);
				Transform transform = base.transform;
				for (int i = 0; i < transform.childCount; i++)
				{
					Transform child = transform.GetChild(i);
					Vector3 localPosition = child.localPosition - b;
					child.localPosition = localPosition;
				}
				boxCollider.center -= b;
				this.autoResizeCollider = true;
			}
		}
	}

	// Token: 0x06002130 RID: 8496 RVA: 0x000A656C File Offset: 0x000A476C
	public virtual void Reshape(Vector3 dMin, Vector3 dMax, bool updateChildren)
	{
		foreach (tk2dUILayoutItem tk2dUILayoutItem in this.layoutItems)
		{
			tk2dUILayoutItem.oldPos = tk2dUILayoutItem.gameObj.transform.position;
		}
		this.bMin += dMin;
		this.bMax += dMax;
		Vector3 vector = new Vector3(this.bMin.x, this.bMax.y);
		base.transform.position += base.transform.localToWorldMatrix.MultiplyVector(vector);
		this.bMin -= vector;
		this.bMax -= vector;
		if (this.autoResizeCollider)
		{
			BoxCollider component = base.GetComponent<BoxCollider>();
			if (component != null)
			{
				component.center += (dMin + dMax) / 2f - vector;
				component.size += dMax - dMin;
			}
		}
		foreach (tk2dUILayoutItem tk2dUILayoutItem2 in this.layoutItems)
		{
			Vector3 a = base.transform.worldToLocalMatrix.MultiplyVector(tk2dUILayoutItem2.gameObj.transform.position - tk2dUILayoutItem2.oldPos);
			Vector3 vector2 = -a;
			Vector3 vector3 = -a;
			if (updateChildren)
			{
				vector2.x += (tk2dUILayoutItem2.snapLeft ? dMin.x : (tk2dUILayoutItem2.snapRight ? dMax.x : 0f));
				vector2.y += (tk2dUILayoutItem2.snapBottom ? dMin.y : (tk2dUILayoutItem2.snapTop ? dMax.y : 0f));
				vector3.x += (tk2dUILayoutItem2.snapRight ? dMax.x : (tk2dUILayoutItem2.snapLeft ? dMin.x : 0f));
				vector3.y += (tk2dUILayoutItem2.snapTop ? dMax.y : (tk2dUILayoutItem2.snapBottom ? dMin.y : 0f));
			}
			if (tk2dUILayoutItem2.sprite != null || tk2dUILayoutItem2.UIMask != null || tk2dUILayoutItem2.layout != null)
			{
				Matrix4x4 matrix4x = base.transform.localToWorldMatrix * tk2dUILayoutItem2.gameObj.transform.worldToLocalMatrix;
				vector2 = matrix4x.MultiplyVector(vector2);
				vector3 = matrix4x.MultiplyVector(vector3);
			}
			if (tk2dUILayoutItem2.sprite != null)
			{
				tk2dUILayoutItem2.sprite.ReshapeBounds(vector2, vector3);
			}
			else if (tk2dUILayoutItem2.UIMask != null)
			{
				tk2dUILayoutItem2.UIMask.ReshapeBounds(vector2, vector3);
			}
			else if (tk2dUILayoutItem2.layout != null)
			{
				tk2dUILayoutItem2.layout.Reshape(vector2, vector3, true);
			}
			else
			{
				Vector3 b = vector2;
				if (tk2dUILayoutItem2.snapLeft && tk2dUILayoutItem2.snapRight)
				{
					b.x = 0.5f * (vector2.x + vector3.x);
				}
				if (tk2dUILayoutItem2.snapTop && tk2dUILayoutItem2.snapBottom)
				{
					b.y = 0.5f * (vector2.y + vector3.y);
				}
				tk2dUILayoutItem2.gameObj.transform.position += b;
			}
		}
		if (this.OnReshape != null)
		{
			this.OnReshape(dMin, dMax);
		}
	}

	// Token: 0x06002131 RID: 8497 RVA: 0x000A6980 File Offset: 0x000A4B80
	public void SetBounds(Vector3 pMin, Vector3 pMax)
	{
		Matrix4x4 worldToLocalMatrix = base.transform.worldToLocalMatrix;
		this.Reshape(worldToLocalMatrix.MultiplyPoint(pMin) - this.bMin, worldToLocalMatrix.MultiplyPoint(pMax) - this.bMax, true);
	}

	// Token: 0x06002132 RID: 8498 RVA: 0x000A69C8 File Offset: 0x000A4BC8
	public Vector3 GetMinBounds()
	{
		return base.transform.localToWorldMatrix.MultiplyPoint(this.bMin);
	}

	// Token: 0x06002133 RID: 8499 RVA: 0x000A69F0 File Offset: 0x000A4BF0
	public Vector3 GetMaxBounds()
	{
		return base.transform.localToWorldMatrix.MultiplyPoint(this.bMax);
	}

	// Token: 0x06002134 RID: 8500 RVA: 0x000A6A16 File Offset: 0x000A4C16
	public void Refresh()
	{
		this.Reshape(Vector3.zero, Vector3.zero, true);
	}

	// Token: 0x06002135 RID: 8501 RVA: 0x000A6A2C File Offset: 0x000A4C2C
	public tk2dUILayout()
	{
		this.bMin = new Vector3(0f, -1f, 0f);
		this.bMax = new Vector3(1f, 0f, 0f);
		this.layoutItems = new List<tk2dUILayoutItem>();
		base..ctor();
	}

	// Token: 0x040026A6 RID: 9894
	public Vector3 bMin;

	// Token: 0x040026A7 RID: 9895
	public Vector3 bMax;

	// Token: 0x040026A8 RID: 9896
	public List<tk2dUILayoutItem> layoutItems;

	// Token: 0x040026A9 RID: 9897
	public bool autoResizeCollider;
}
