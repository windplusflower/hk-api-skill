using System;

// Token: 0x02000486 RID: 1158
public class MenuButtonGraphicsListCondition : MenuButtonListCondition
{
	// Token: 0x06001A0B RID: 6667 RVA: 0x0007D6C6 File Offset: 0x0007B8C6
	public override bool IsFulfilled()
	{
		return Platform.Current.WillDisplayGraphicsSettings;
	}
}
