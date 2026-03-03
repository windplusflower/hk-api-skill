using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020000EC RID: 236
public class CollisionEnterEvent : MonoBehaviour
{
	// Token: 0x14000006 RID: 6
	// (add) Token: 0x060004FB RID: 1275 RVA: 0x0001A4B8 File Offset: 0x000186B8
	// (remove) Token: 0x060004FC RID: 1276 RVA: 0x0001A4F0 File Offset: 0x000186F0
	public event CollisionEnterEvent.CollisionEvent OnCollisionEntered;

	// Token: 0x14000007 RID: 7
	// (add) Token: 0x060004FD RID: 1277 RVA: 0x0001A528 File Offset: 0x00018728
	// (remove) Token: 0x060004FE RID: 1278 RVA: 0x0001A560 File Offset: 0x00018760
	public event CollisionEnterEvent.DirectionalCollisionEvent OnCollisionEnteredDirectional;

	// Token: 0x060004FF RID: 1279 RVA: 0x0001A595 File Offset: 0x00018795
	private void Awake()
	{
		this.col2d = base.GetComponent<Collider2D>();
	}

	// Token: 0x06000500 RID: 1280 RVA: 0x0001A5A3 File Offset: 0x000187A3
	private void OnCollisionEnter2D(Collision2D collision)
	{
		this.HandleCollision(collision);
	}

	// Token: 0x06000501 RID: 1281 RVA: 0x0001A5AC File Offset: 0x000187AC
	private void OnCollisionStay2D(Collision2D collision)
	{
		if (this.doCollisionStay)
		{
			this.HandleCollision(collision);
		}
	}

	// Token: 0x06000502 RID: 1282 RVA: 0x0001A5BD File Offset: 0x000187BD
	private void HandleCollision(Collision2D collision)
	{
		if (this.OnCollisionEntered != null)
		{
			this.OnCollisionEntered(collision, base.gameObject);
		}
		if (this.checkDirection)
		{
			this.CheckTouching(this.otherLayer, collision);
		}
	}

	// Token: 0x06000503 RID: 1283 RVA: 0x0001A5F4 File Offset: 0x000187F4
	private void CheckTouching(LayerMask layer, Collision2D collision)
	{
		this.topRays = new List<Vector2>();
		this.topRays.Add(new Vector2(this.col2d.bounds.min.x, this.col2d.bounds.max.y));
		this.topRays.Add(new Vector2(this.col2d.bounds.center.x, this.col2d.bounds.max.y));
		this.topRays.Add(this.col2d.bounds.max);
		this.rightRays = new List<Vector2>();
		this.rightRays.Add(this.col2d.bounds.max);
		this.rightRays.Add(new Vector2(this.col2d.bounds.max.x, this.col2d.bounds.center.y));
		this.rightRays.Add(new Vector2(this.col2d.bounds.max.x, this.col2d.bounds.min.y));
		this.bottomRays = new List<Vector2>();
		this.bottomRays.Add(new Vector2(this.col2d.bounds.max.x, this.col2d.bounds.min.y));
		this.bottomRays.Add(new Vector2(this.col2d.bounds.center.x, this.col2d.bounds.min.y));
		this.bottomRays.Add(this.col2d.bounds.min);
		this.leftRays = new List<Vector2>();
		this.leftRays.Add(this.col2d.bounds.min);
		this.leftRays.Add(new Vector2(this.col2d.bounds.min.x, this.col2d.bounds.center.y));
		this.leftRays.Add(new Vector2(this.col2d.bounds.min.x, this.col2d.bounds.max.y));
		foreach (Vector2 v in this.topRays)
		{
			RaycastHit2D raycastHit2D = Physics2D.Raycast(v, Vector2.up, 0.08f, 1 << layer);
			if (raycastHit2D.collider != null && (!this.ignoreTriggers || !raycastHit2D.collider.isTrigger))
			{
				if (this.OnCollisionEnteredDirectional != null)
				{
					this.OnCollisionEnteredDirectional(CollisionEnterEvent.Direction.Top, collision);
					break;
				}
				break;
			}
		}
		foreach (Vector2 v2 in this.rightRays)
		{
			RaycastHit2D raycastHit2D2 = Physics2D.Raycast(v2, Vector2.right, 0.08f, 1 << layer);
			if (raycastHit2D2.collider != null && (!this.ignoreTriggers || !raycastHit2D2.collider.isTrigger))
			{
				if (this.OnCollisionEnteredDirectional != null)
				{
					this.OnCollisionEnteredDirectional(CollisionEnterEvent.Direction.Right, collision);
					break;
				}
				break;
			}
		}
		foreach (Vector2 v3 in this.bottomRays)
		{
			RaycastHit2D raycastHit2D3 = Physics2D.Raycast(v3, -Vector2.up, 0.08f, 1 << layer);
			if (raycastHit2D3.collider != null && (!this.ignoreTriggers || !raycastHit2D3.collider.isTrigger))
			{
				if (this.OnCollisionEnteredDirectional != null)
				{
					this.OnCollisionEnteredDirectional(CollisionEnterEvent.Direction.Bottom, collision);
					break;
				}
				break;
			}
		}
		foreach (Vector2 v4 in this.leftRays)
		{
			RaycastHit2D raycastHit2D4 = Physics2D.Raycast(v4, -Vector2.right, 0.08f, 1 << layer);
			if (raycastHit2D4.collider != null && (!this.ignoreTriggers || !raycastHit2D4.collider.isTrigger))
			{
				if (this.OnCollisionEnteredDirectional != null)
				{
					this.OnCollisionEnteredDirectional(CollisionEnterEvent.Direction.Left, collision);
					break;
				}
				break;
			}
		}
	}

	// Token: 0x06000504 RID: 1284 RVA: 0x0001AB44 File Offset: 0x00018D44
	public CollisionEnterEvent()
	{
		this.otherLayer = 9;
		base..ctor();
	}

	// Token: 0x040004CC RID: 1228
	public bool checkDirection;

	// Token: 0x040004CD RID: 1229
	public bool ignoreTriggers;

	// Token: 0x040004CE RID: 1230
	public int otherLayer;

	// Token: 0x040004CF RID: 1231
	[HideInInspector]
	public bool doCollisionStay;

	// Token: 0x040004D0 RID: 1232
	private Collider2D col2d;

	// Token: 0x040004D1 RID: 1233
	private const float RAYCAST_LENGTH = 0.08f;

	// Token: 0x040004D2 RID: 1234
	private List<Vector2> topRays;

	// Token: 0x040004D3 RID: 1235
	private List<Vector2> rightRays;

	// Token: 0x040004D4 RID: 1236
	private List<Vector2> bottomRays;

	// Token: 0x040004D5 RID: 1237
	private List<Vector2> leftRays;

	// Token: 0x020000ED RID: 237
	// (Invoke) Token: 0x06000506 RID: 1286
	public delegate void CollisionEvent(Collision2D collision, GameObject sender);

	// Token: 0x020000EE RID: 238
	public enum Direction
	{
		// Token: 0x040004D7 RID: 1239
		Left,
		// Token: 0x040004D8 RID: 1240
		Right,
		// Token: 0x040004D9 RID: 1241
		Top,
		// Token: 0x040004DA RID: 1242
		Bottom
	}

	// Token: 0x020000EF RID: 239
	// (Invoke) Token: 0x0600050A RID: 1290
	public delegate void DirectionalCollisionEvent(CollisionEnterEvent.Direction direction, Collision2D collision);
}
