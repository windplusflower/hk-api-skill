using System;
using UnityEngine;

// Token: 0x02000407 RID: 1031
public class SetZRandom : MonoBehaviour
{
	// Token: 0x06001762 RID: 5986 RVA: 0x0006E888 File Offset: 0x0006CA88
	private void OnEnable()
	{
		Vector3 position = new Vector3(base.transform.position.x, base.transform.position.y, UnityEngine.Random.Range(this.zMin, this.zMax));
		base.transform.position = position;
	}

	// Token: 0x04001C24 RID: 7204
	public float zMin;

	// Token: 0x04001C25 RID: 7205
	public float zMax;
}
