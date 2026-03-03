using System;
using UnityEngine;

// Token: 0x020004EE RID: 1262
[RequireComponent(typeof(Collider2D))]
public class RegionDebugger : MonoBehaviour
{
	// Token: 0x06001BDB RID: 7131 RVA: 0x00084892 File Offset: 0x00082A92
	private void Start()
	{
		Debug.LogErrorFormat(this, "Region debugger is exists in scene! These should be removed before release.", Array.Empty<object>());
	}
}
