using System;
using UnityEngine;

// Token: 0x0200014E RID: 334
[RequireComponent(typeof(Collider2D))]
public class AlertRange : MonoBehaviour
{
	// Token: 0x170000CD RID: 205
	// (get) Token: 0x060007C7 RID: 1991 RVA: 0x0002BF0E File Offset: 0x0002A10E
	public bool IsHeroInRange
	{
		get
		{
			return this.isHeroInRange;
		}
	}

	// Token: 0x060007C8 RID: 1992 RVA: 0x0002BF16 File Offset: 0x0002A116
	protected void Awake()
	{
		this.colliders = base.GetComponents<Collider2D>();
	}

	// Token: 0x060007C9 RID: 1993 RVA: 0x0002BF24 File Offset: 0x0002A124
	protected void OnTriggerEnter2D(Collider2D other)
	{
		this.isHeroInRange = true;
	}

	// Token: 0x060007CA RID: 1994 RVA: 0x0002BF2D File Offset: 0x0002A12D
	protected void OnTriggerExit2D(Collider2D other)
	{
		if (this.colliders.Length <= 1 || !this.StillInColliders())
		{
			this.isHeroInRange = false;
		}
	}

	// Token: 0x060007CB RID: 1995 RVA: 0x0002BF4C File Offset: 0x0002A14C
	private bool StillInColliders()
	{
		bool flag = false;
		foreach (Collider2D collider2D in this.colliders)
		{
			if (collider2D is CircleCollider2D)
			{
				CircleCollider2D circleCollider2D = (CircleCollider2D)collider2D;
				flag = (Physics2D.OverlapCircle(base.transform.TransformPoint(circleCollider2D.offset), circleCollider2D.radius * Mathf.Max(base.transform.localScale.x, base.transform.localScale.y), 512) != null);
			}
			else if (collider2D is BoxCollider2D)
			{
				BoxCollider2D boxCollider2D = (BoxCollider2D)collider2D;
				flag = (Physics2D.OverlapBox(base.transform.TransformPoint(boxCollider2D.offset), new Vector2(boxCollider2D.size.x * base.transform.localScale.x, boxCollider2D.size.y * base.transform.localScale.y), base.transform.eulerAngles.z, 512) != null);
			}
			if (flag)
			{
				break;
			}
		}
		return flag;
	}

	// Token: 0x060007CC RID: 1996 RVA: 0x0002C07C File Offset: 0x0002A27C
	public static AlertRange Find(GameObject root, string childName)
	{
		if (root == null)
		{
			return null;
		}
		bool flag = !string.IsNullOrEmpty(childName);
		Transform transform = root.transform;
		for (int i = 0; i < transform.childCount; i++)
		{
			Transform child = transform.GetChild(i);
			AlertRange component = child.GetComponent<AlertRange>();
			if (!(component == null) && (!flag || !(child.gameObject.name != childName)))
			{
				return component;
			}
		}
		return null;
	}

	// Token: 0x040008A3 RID: 2211
	private bool isHeroInRange;

	// Token: 0x040008A4 RID: 2212
	private Collider2D[] colliders;
}
