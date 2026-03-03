using System;

// Token: 0x02000489 RID: 1161
public class MenuButtonKeyboardListCondition : MenuButtonListCondition
{
	// Token: 0x06001A12 RID: 6674 RVA: 0x0007D78A File Offset: 0x0007B98A
	public override bool IsFulfilled()
	{
		return Platform.Current.WillDisplayKeyboardSettings;
	}
}
