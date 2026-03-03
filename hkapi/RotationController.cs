using System;
using UnityEngine;

// Token: 0x02000008 RID: 8
public class RotationController : MonoBehaviour
{
	// Token: 0x0600002D RID: 45 RVA: 0x00003118 File Offset: 0x00001318
	private void Update()
	{
		if (Input.GetAxis("Horizontal") != 0f)
		{
			Vector3 eulerAngles = base.transform.eulerAngles;
			eulerAngles.y += Input.GetAxis("Horizontal") * this.speed;
			base.transform.eulerAngles = eulerAngles;
		}
	}

	// Token: 0x0600002E RID: 46 RVA: 0x0000316A File Offset: 0x0000136A
	public RotationController()
	{
		this.speed = 1f;
		base..ctor();
	}

	// Token: 0x04000022 RID: 34
	public float speed;
}
