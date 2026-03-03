using System;
using UnityEngine;

// Token: 0x020001EA RID: 490
public class FaceAngleSimple : MonoBehaviour
{
	// Token: 0x06000AA6 RID: 2726 RVA: 0x0003968D File Offset: 0x0003788D
	private void OnEnable()
	{
		this.rb2d = base.GetComponent<Rigidbody2D>();
		this.DoAngle();
	}

	// Token: 0x06000AA7 RID: 2727 RVA: 0x000396A1 File Offset: 0x000378A1
	private void Update()
	{
		if (this.everyFrame)
		{
			this.DoAngle();
		}
	}

	// Token: 0x06000AA8 RID: 2728 RVA: 0x000396B4 File Offset: 0x000378B4
	private void DoAngle()
	{
		Vector2 velocity = this.rb2d.velocity;
		float z = Mathf.Atan2(velocity.y, velocity.x) * 57.295776f + this.angleOffset;
		base.transform.localEulerAngles = new Vector3(0f, 0f, z);
	}

	// Token: 0x04000BBB RID: 3003
	public float angleOffset;

	// Token: 0x04000BBC RID: 3004
	public bool everyFrame;

	// Token: 0x04000BBD RID: 3005
	private Rigidbody2D rb2d;
}
