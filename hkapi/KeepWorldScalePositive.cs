using System;
using UnityEngine;

// Token: 0x020002C1 RID: 705
public class KeepWorldScalePositive : MonoBehaviour
{
	// Token: 0x06000EEF RID: 3823 RVA: 0x00049ADC File Offset: 0x00047CDC
	private void Update()
	{
		if (base.transform.lossyScale.x < 0f)
		{
			base.transform.localScale = new Vector3(-base.transform.localScale.x, base.transform.localScale.y, base.transform.localScale.z);
		}
	}

	// Token: 0x04000FAE RID: 4014
	public bool x;

	// Token: 0x04000FAF RID: 4015
	public bool y;
}
