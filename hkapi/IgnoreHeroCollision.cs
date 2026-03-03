using System;
using UnityEngine;

// Token: 0x020003D3 RID: 979
[RequireComponent(typeof(Collider2D))]
public class IgnoreHeroCollision : MonoBehaviour
{
	// Token: 0x06001677 RID: 5751 RVA: 0x0006A538 File Offset: 0x00068738
	private void Start()
	{
		if (HeroController.instance)
		{
			if (HeroController.instance.isHeroInPosition)
			{
				this.Ignore();
				return;
			}
			HeroController.HeroInPosition temp = null;
			temp = delegate(bool <p0>)
			{
				this.Ignore();
				HeroController.instance.heroInPosition -= temp;
				temp = null;
			};
			HeroController.instance.heroInPosition += temp;
		}
	}

	// Token: 0x06001678 RID: 5752 RVA: 0x0006A59C File Offset: 0x0006879C
	private void Ignore()
	{
		Collider2D component = base.GetComponent<Collider2D>();
		foreach (Collider2D collider in HeroController.instance.GetComponents<Collider2D>())
		{
			Physics2D.IgnoreCollision(component, collider);
		}
	}

	// Token: 0x06001679 RID: 5753 RVA: 0x0006A5D4 File Offset: 0x000687D4
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Player")
		{
			Physics2D.IgnoreCollision(collision.collider, collision.otherCollider);
		}
	}
}
