using System;

// Token: 0x02000485 RID: 1157
public class MenuButtonControllerListCondition : MenuButtonListCondition
{
	// Token: 0x06001A09 RID: 6665 RVA: 0x0007D6BA File Offset: 0x0007B8BA
	public override bool IsFulfilled()
	{
		return Platform.Current.WillDisplayControllerSettings;
	}
}
