using System;
using UnityEngine;

// Token: 0x0200013B RID: 315
public class KeepWorldPosition : MonoBehaviour
{
	// Token: 0x0600075A RID: 1882 RVA: 0x0002A2D0 File Offset: 0x000284D0
	private void Update()
	{
		if (this.keepX)
		{
			base.transform.position = new Vector3(this.xPosition, base.transform.position.y, base.transform.position.z);
		}
		if (this.keepY)
		{
			base.transform.position = new Vector3(base.transform.position.x, this.yPosition, base.transform.position.z);
		}
	}

	// Token: 0x04000831 RID: 2097
	public bool keepX;

	// Token: 0x04000832 RID: 2098
	public float xPosition;

	// Token: 0x04000833 RID: 2099
	public bool keepY;

	// Token: 0x04000834 RID: 2100
	public float yPosition;
}
