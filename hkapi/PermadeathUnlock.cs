using System;
using UnityEngine;

// Token: 0x02000204 RID: 516
public class PermadeathUnlock : MonoBehaviour
{
	// Token: 0x06000B3E RID: 2878 RVA: 0x0003BB80 File Offset: 0x00039D80
	private void Start()
	{
		GameManager.instance.SetStatusRecordInt("RecPermadeathMode", 1);
		GameManager.instance.SaveStatusRecords();
	}
}
