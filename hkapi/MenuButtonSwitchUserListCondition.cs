using System;

// Token: 0x02000493 RID: 1171
public class MenuButtonSwitchUserListCondition : MenuButtonListCondition
{
	// Token: 0x06001A37 RID: 6711 RVA: 0x0007DDDC File Offset: 0x0007BFDC
	public override bool IsFulfilled()
	{
		return Platform.Current.CanReEngage;
	}
}
