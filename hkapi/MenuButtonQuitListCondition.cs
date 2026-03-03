using System;

// Token: 0x02000492 RID: 1170
public class MenuButtonQuitListCondition : MenuButtonListCondition
{
	// Token: 0x06001A35 RID: 6709 RVA: 0x0007DDD0 File Offset: 0x0007BFD0
	public override bool IsFulfilled()
	{
		return Platform.Current.WillDisplayQuitButton;
	}
}
