using System;
using UnityEngine;

// Token: 0x020003A3 RID: 931
public class ConveyorMovement : MonoBehaviour
{
	// Token: 0x06001566 RID: 5478 RVA: 0x00066303 File Offset: 0x00064503
	public void OnEnable()
	{
		this.onConveyor = false;
	}

	// Token: 0x06001567 RID: 5479 RVA: 0x0006630C File Offset: 0x0006450C
	public void StartConveyorMove(float c_xSpeed, float c_ySpeed)
	{
		this.onConveyor = true;
		this.xSpeed = c_xSpeed;
		this.ySpeed = c_ySpeed;
	}

	// Token: 0x06001568 RID: 5480 RVA: 0x00066303 File Offset: 0x00064503
	public void StopConveyorMove()
	{
		this.onConveyor = false;
	}

	// Token: 0x06001569 RID: 5481 RVA: 0x00066324 File Offset: 0x00064524
	private void LateUpdate()
	{
		if (this.onConveyor && this.xSpeed != 0f)
		{
			base.transform.position = new Vector3(base.transform.position.x + this.xSpeed * Time.deltaTime, base.transform.position.y, base.transform.position.z);
		}
	}

	// Token: 0x040019B0 RID: 6576
	private float xSpeed;

	// Token: 0x040019B1 RID: 6577
	private float ySpeed;

	// Token: 0x040019B2 RID: 6578
	public bool onConveyor;
}
