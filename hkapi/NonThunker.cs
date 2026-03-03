using System;
using UnityEngine;

// Token: 0x020003DC RID: 988
public class NonThunker : MonoBehaviour
{
	// Token: 0x06001690 RID: 5776 RVA: 0x0006AEDB File Offset: 0x000690DB
	public void SetActive(bool active)
	{
		this.active = active;
	}

	// Token: 0x06001691 RID: 5777 RVA: 0x0006AEE4 File Offset: 0x000690E4
	public NonThunker()
	{
		this.active = true;
		base..ctor();
	}

	// Token: 0x04001B2F RID: 6959
	public bool active;
}
