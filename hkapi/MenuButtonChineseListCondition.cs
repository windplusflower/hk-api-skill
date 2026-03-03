using System;
using UnityEngine;

// Token: 0x02000484 RID: 1156
public class MenuButtonChineseListCondition : MenuButtonListCondition
{
	// Token: 0x06001A07 RID: 6663 RVA: 0x0007D6AF File Offset: 0x0007B8AF
	public override bool IsFulfilled()
	{
		return false == this.isChineseBuildDesired;
	}

	// Token: 0x04001F6B RID: 8043
	[SerializeField]
	private bool isChineseBuildDesired;
}
