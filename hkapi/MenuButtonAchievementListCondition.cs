using System;

// Token: 0x02000483 RID: 1155
public class MenuButtonAchievementListCondition : MenuButtonListCondition
{
	// Token: 0x06001A05 RID: 6661 RVA: 0x0007D698 File Offset: 0x0007B898
	public override bool IsFulfilled()
	{
		return !Platform.Current.HasNativeAchievementsDialog;
	}
}
