using System;
using UnityEngine;

// Token: 0x0200011F RID: 287
public class DisableIfZPos : MonoBehaviour
{
	// Token: 0x060006B0 RID: 1712 RVA: 0x00026FF6 File Offset: 0x000251F6
	private void Start()
	{
		if (Mathf.Abs(base.transform.position.z - 0.004f) > this.limitZ)
		{
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x060006B1 RID: 1713 RVA: 0x00027027 File Offset: 0x00025227
	public DisableIfZPos()
	{
		this.limitZ = 1.8f;
		base..ctor();
	}

	// Token: 0x04000748 RID: 1864
	[Tooltip("If further than this distance from the hero on Z, will be disabled.")]
	public float limitZ;
}
