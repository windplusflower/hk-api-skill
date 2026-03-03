using System;
using UnityEngine;

// Token: 0x0200015F RID: 351
public class CorpseBitEnd : MonoBehaviour
{
	// Token: 0x0600082A RID: 2090 RVA: 0x0002DA58 File Offset: 0x0002BC58
	private void Update()
	{
		if (this.timer <= 0f && !this.stopped)
		{
			Rigidbody2D component = base.GetComponent<Rigidbody2D>();
			if (component)
			{
				component.isKinematic = true;
			}
			component.velocity = new Vector2(0f, 0f);
			component.angularVelocity = 0f;
			base.GetComponent<ObjectBounce>().StopBounce();
			base.GetComponent<PolygonCollider2D>().enabled = false;
			this.stopped = true;
			return;
		}
		this.timer -= Time.deltaTime;
	}

	// Token: 0x04000924 RID: 2340
	public float timer;

	// Token: 0x04000925 RID: 2341
	private bool stopped;
}
