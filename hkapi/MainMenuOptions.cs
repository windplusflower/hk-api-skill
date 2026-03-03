using System;
using UnityEngine.UI;

// Token: 0x02000476 RID: 1142
public class MainMenuOptions : PreselectOption
{
	// Token: 0x060019A3 RID: 6563 RVA: 0x0007A1B0 File Offset: 0x000783B0
	public void ConfigureNavigation()
	{
		if (Platform.Current.HasNativeAchievementsDialog && GameManager.instance.gameConfig.hideExtrasMenu)
		{
			this.achievementsButton.gameObject.SetActive(false);
			this.extrasButton.gameObject.SetActive(false);
			Navigation navigation = this.optionsButton.navigation;
			Navigation navigation2 = this.quitButton.navigation;
			navigation.selectOnDown = this.quitButton;
			navigation2.selectOnUp = this.optionsButton;
			this.optionsButton.navigation = navigation;
			this.quitButton.navigation = navigation2;
			return;
		}
		if (Platform.Current.HasNativeAchievementsDialog)
		{
			this.achievementsButton.gameObject.SetActive(false);
			Navigation navigation3 = this.optionsButton.navigation;
			Navigation navigation4 = this.extrasButton.navigation;
			navigation3.selectOnDown = this.extrasButton;
			navigation4.selectOnUp = this.optionsButton;
			this.optionsButton.navigation = navigation3;
			this.extrasButton.navigation = navigation4;
			return;
		}
		if (GameManager.instance.gameConfig.hideExtrasMenu)
		{
			this.extrasButton.gameObject.SetActive(false);
			Navigation navigation5 = this.achievementsButton.navigation;
			Navigation navigation6 = this.quitButton.navigation;
			navigation5.selectOnDown = this.quitButton;
			navigation6.selectOnUp = this.achievementsButton;
			this.achievementsButton.navigation = navigation5;
			this.quitButton.navigation = navigation6;
		}
	}

	// Token: 0x04001ED0 RID: 7888
	public MenuButton startButton;

	// Token: 0x04001ED1 RID: 7889
	public MenuButton optionsButton;

	// Token: 0x04001ED2 RID: 7890
	public MenuButton achievementsButton;

	// Token: 0x04001ED3 RID: 7891
	public MenuButton extrasButton;

	// Token: 0x04001ED4 RID: 7892
	public MenuButton quitButton;
}
