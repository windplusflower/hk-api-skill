using System;
using UnityEngine;

// Token: 0x020001D0 RID: 464
public struct Sweep
{
	// Token: 0x06000A3B RID: 2619 RVA: 0x00037FC4 File Offset: 0x000361C4
	public Sweep(Collider2D collider, int cardinalDirection, int rayCount, float skinThickness = 0.1f)
	{
		this.CardinalDirection = cardinalDirection;
		this.Direction = new Vector2((float)DirectionUtils.GetX(cardinalDirection), (float)DirectionUtils.GetY(cardinalDirection));
		this.ColliderOffset = collider.offset.MultiplyElements(collider.transform.localScale);
		this.ColliderExtents = collider.bounds.extents;
		this.RayCount = rayCount;
		this.SkinThickness = skinThickness;
	}

	// Token: 0x06000A3C RID: 2620 RVA: 0x0003803C File Offset: 0x0003623C
	public bool Check(Vector2 offset, float distance, int layerMask)
	{
		float num;
		return this.Check(offset, distance, layerMask, out num);
	}

	// Token: 0x06000A3D RID: 2621 RVA: 0x00038054 File Offset: 0x00036254
	public bool Check(Vector2 offset, float distance, int layerMask, out float clippedDistance)
	{
		if (distance <= 0f)
		{
			clippedDistance = 0f;
			return false;
		}
		Vector2 a = this.ColliderOffset + Vector2.Scale(this.ColliderExtents, this.Direction);
		Vector2 a2 = Vector2.Scale(this.ColliderExtents, new Vector2(Mathf.Abs(this.Direction.y), Mathf.Abs(this.Direction.x)));
		float num = distance;
		for (int i = 0; i < this.RayCount; i++)
		{
			float d = 2f * ((float)i / (float)(this.RayCount - 1)) - 1f;
			Vector2 b = a + a2 * d + this.Direction * -this.SkinThickness;
			Vector2 vector = offset + b;
			RaycastHit2D hit = Physics2D.Raycast(vector, this.Direction, num + this.SkinThickness, layerMask);
			float num2 = hit.distance - this.SkinThickness;
			if (hit && num2 < num)
			{
				num = num2;
				Debug.DrawLine(vector, vector + this.Direction * hit.distance, Color.red);
			}
			else
			{
				Debug.DrawLine(vector, vector + this.Direction * (distance + this.SkinThickness), Color.green);
			}
		}
		clippedDistance = num;
		return distance - num > Mathf.Epsilon;
	}

	// Token: 0x04000B51 RID: 2897
	public int CardinalDirection;

	// Token: 0x04000B52 RID: 2898
	public Vector2 Direction;

	// Token: 0x04000B53 RID: 2899
	public Vector2 ColliderOffset;

	// Token: 0x04000B54 RID: 2900
	public Vector2 ColliderExtents;

	// Token: 0x04000B55 RID: 2901
	public float SkinThickness;

	// Token: 0x04000B56 RID: 2902
	public int RayCount;

	// Token: 0x04000B57 RID: 2903
	private const float DefaultSkinThickness = 0.1f;

	// Token: 0x04000B58 RID: 2904
	public const int DefaultRayCount = 3;
}
