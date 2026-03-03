using System;
using UnityEngine;

// Token: 0x0200039D RID: 925
public class BreakablePoleTopLand : MonoBehaviour
{
	// Token: 0x0600155B RID: 5467 RVA: 0x00065F48 File Offset: 0x00064148
	private void OnCollisionEnter2D(Collision2D collision)
	{
		Collider2D otherCollider = collision.otherCollider;
		if (collision.gameObject.layer != 8)
		{
			return;
		}
		Vector2 point = collision.GetSafeContact().Point;
		if (point.y > otherCollider.bounds.center.y)
		{
			return;
		}
		float z = base.transform.eulerAngles.z;
		if (z >= this.angleMin && z <= this.angleMax)
		{
			GameObject[] array = this.effects;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Spawn(point);
			}
			Rigidbody2D component = base.GetComponent<Rigidbody2D>();
			if (component)
			{
				component.isKinematic = true;
				component.simulated = false;
				component.velocity = Vector2.zero;
				component.angularVelocity = 0f;
			}
		}
	}

	// Token: 0x0600155C RID: 5468 RVA: 0x0006601B File Offset: 0x0006421B
	public BreakablePoleTopLand()
	{
		this.angleMin = 165f;
		this.angleMax = 195f;
		base..ctor();
	}

	// Token: 0x040019A4 RID: 6564
	public float angleMin;

	// Token: 0x040019A5 RID: 6565
	public float angleMax;

	// Token: 0x040019A6 RID: 6566
	[Space]
	public GameObject[] effects;
}
