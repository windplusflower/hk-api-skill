using System;
using UnityEngine;

// Token: 0x020004B0 RID: 1200
public class RemoteDisableChild : MonoBehaviour
{
	// Token: 0x06001A9B RID: 6811 RVA: 0x0007F662 File Offset: 0x0007D862
	public void RemoteDisableObject()
	{
		this.child.SetActive(false);
	}

	// Token: 0x06001A9C RID: 6812 RVA: 0x0007F670 File Offset: 0x0007D870
	public void RemoteEnableObject()
	{
		this.child.SetActive(true);
	}

	// Token: 0x04001FF4 RID: 8180
	public GameObject child;
}
