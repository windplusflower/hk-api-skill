using System;
using UnityEngine;

// Token: 0x020003EA RID: 1002
[RequireComponent(typeof(Collider2D))]
public class SnapToGround : MonoBehaviour
{
	// Token: 0x060016D2 RID: 5842 RVA: 0x0006C114 File Offset: 0x0006A314
	private void Awake()
	{
		this.col = base.GetComponent<Collider2D>();
	}

	// Token: 0x060016D3 RID: 5843 RVA: 0x0006C124 File Offset: 0x0006A324
	private void OnEnable()
	{
		float y = this.col.bounds.min.y;
		float num = base.transform.position.y - y;
		RaycastHit2D raycastHit2D = Physics2D.Raycast(base.transform.position, Vector2.down, 10f, 256);
		if (raycastHit2D.collider != null)
		{
			base.transform.SetPositionY(raycastHit2D.point.y + num);
		}
	}

	// Token: 0x04001B81 RID: 7041
	private Collider2D col;
}
