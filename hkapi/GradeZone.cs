using System;
using UnityEngine;

// Token: 0x02000132 RID: 306
[RequireComponent(typeof(PolygonCollider2D))]
public class GradeZone : MonoBehaviour
{
	// Token: 0x06000720 RID: 1824 RVA: 0x00028C3C File Offset: 0x00026E3C
	private void Start()
	{
		Debug.LogError("GrazeZone has been deprecated, please remove this object: " + base.name);
	}
}
