using System;
using UnityEngine;

// Token: 0x02000089 RID: 137
public class SetAngleToVelocity : MonoBehaviour
{
	// Token: 0x060002E2 RID: 738 RVA: 0x0000FA9C File Offset: 0x0000DC9C
	private void Update()
	{
		Vector2 velocity = this.rb.velocity;
		float z = Mathf.Atan2(velocity.y, velocity.x) * 57.295776f + this.angleOffset;
		base.transform.localEulerAngles = new Vector3(0f, 0f, z);
	}

	// Token: 0x04000264 RID: 612
	public Rigidbody2D rb;

	// Token: 0x04000265 RID: 613
	public float angleOffset;
}
