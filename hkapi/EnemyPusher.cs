using System;
using UnityEngine;

// Token: 0x020001E3 RID: 483
public class EnemyPusher : MonoBehaviour
{
	// Token: 0x06000A8A RID: 2698 RVA: 0x00039300 File Offset: 0x00037500
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.transform.root.gameObject.name != collision.otherCollider.transform.root.gameObject.name)
		{
			Physics2D.IgnoreCollision(collision.collider, collision.otherCollider);
		}
	}
}
