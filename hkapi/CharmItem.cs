using System;
using UnityEngine;

// Token: 0x02000440 RID: 1088
public class CharmItem : MonoBehaviour
{
	// Token: 0x0600187F RID: 6271 RVA: 0x00073081 File Offset: 0x00071281
	public int GetListNumber()
	{
		return this.listNumber;
	}

	// Token: 0x06001880 RID: 6272 RVA: 0x00073089 File Offset: 0x00071289
	public void SetListNumber(int newNumber)
	{
		this.listNumber = newNumber;
	}

	// Token: 0x04001D5D RID: 7517
	public int listNumber;
}
