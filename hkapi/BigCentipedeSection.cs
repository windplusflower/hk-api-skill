using System;
using UnityEngine;

// Token: 0x02000153 RID: 339
public class BigCentipedeSection : MonoBehaviour
{
	// Token: 0x060007E5 RID: 2021 RVA: 0x0002C586 File Offset: 0x0002A786
	protected void Awake()
	{
		this.parent = base.GetComponentInParent<BigCentipede>();
		this.meshRenderer = base.GetComponent<MeshRenderer>();
	}

	// Token: 0x060007E6 RID: 2022 RVA: 0x0002C5A0 File Offset: 0x0002A7A0
	protected void Update()
	{
		Vector2 lhs = base.transform.position;
		if (!this.hasLeft)
		{
			if (Vector2.Dot(lhs, this.parent.Direction) > Vector2.Dot(this.parent.ExitPoint, this.parent.Direction))
			{
				this.meshRenderer.enabled = false;
				this.hasLeft = true;
				return;
			}
		}
		else if (Vector2.Dot(lhs, this.parent.Direction) > Vector2.Dot(this.parent.EntryPoint, this.parent.Direction) - 1.75f && Vector2.Dot(lhs, this.parent.Direction) < Vector2.Dot(this.parent.ExitPoint, this.parent.Direction))
		{
			this.meshRenderer.enabled = true;
			this.hasLeft = false;
		}
	}

	// Token: 0x040008BF RID: 2239
	private BigCentipede parent;

	// Token: 0x040008C0 RID: 2240
	private MeshRenderer meshRenderer;

	// Token: 0x040008C1 RID: 2241
	private Collider2D bodyCollider;

	// Token: 0x040008C2 RID: 2242
	private bool hasLeft;
}
