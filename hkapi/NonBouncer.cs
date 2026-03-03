using System;
using UnityEngine;

// Token: 0x02000350 RID: 848
public class NonBouncer : MonoBehaviour
{
	// Token: 0x06001343 RID: 4931 RVA: 0x000578B9 File Offset: 0x00055AB9
	public void SetActive(bool set_active)
	{
		this.active = set_active;
	}

	// Token: 0x06001344 RID: 4932 RVA: 0x000578C2 File Offset: 0x00055AC2
	public NonBouncer()
	{
		this.active = true;
		base..ctor();
	}

	// Token: 0x04001277 RID: 4727
	public bool active;
}
