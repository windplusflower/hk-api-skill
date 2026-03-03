using System;
using UnityEngine;

// Token: 0x020002C2 RID: 706
public class KeepWorldScalePositiveLate : MonoBehaviour
{
	// Token: 0x06000EF1 RID: 3825 RVA: 0x00049B44 File Offset: 0x00047D44
	private void LateUpdate()
	{
		if (base.transform.lossyScale.x < 0f)
		{
			base.transform.localScale = new Vector3(-base.transform.localScale.x, base.transform.localScale.y, base.transform.localScale.z);
		}
	}

	// Token: 0x04000FB0 RID: 4016
	public bool x;

	// Token: 0x04000FB1 RID: 4017
	public bool y;
}
