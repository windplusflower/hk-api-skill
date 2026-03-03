using System;
using GlobalEnums;
using HKMenu;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200045C RID: 1116
public class GameMenuOptions : MonoBehaviour, IMenuOptionLayout
{
	// Token: 0x06001923 RID: 6435 RVA: 0x00077D5C File Offset: 0x00075F5C
	private void OnEnable()
	{
		if (this.reconfigureOnEnable)
		{
			this.ConfigureNavigation();
		}
	}

	// Token: 0x06001924 RID: 6436 RVA: 0x00077D6C File Offset: 0x00075F6C
	public void ConfigureNavigation()
	{
		if (GameManager.instance.gameState != GameState.MAIN_MENU)
		{
			this.languageOption.interactable = false;
			this.languageOption.transform.parent.gameObject.SetActive(true);
			this.languageOptionDescription.SetActive(true);
			Navigation navigation = this.backerOption.navigation;
			Navigation navigation2 = this.applyButton.navigation;
			navigation.selectOnUp = this.applyButton;
			navigation2.selectOnDown = this.backerOption;
			this.backerOption.navigation = navigation;
			this.applyButton.navigation = navigation2;
			this.gameOptionsMenuScreen.defaultHighlight = this.backerOption;
		}
		else
		{
			this.languageOption.interactable = true;
			this.languageOption.transform.parent.gameObject.SetActive(true);
			this.languageOptionDescription.SetActive(false);
			this.gameOptionsMenuScreen.defaultHighlight = this.languageOption;
		}
		if (this.languageOption && this.languageOption is MenuLanguageSetting)
		{
			((MenuLanguageSetting)this.languageOption).UpdateAlpha();
		}
		if (Platform.Current.HasNativeAchievementsDialog)
		{
			this.nativeAchievementsOption.transform.parent.gameObject.SetActive(false);
		}
	}

	// Token: 0x04001E1F RID: 7711
	public MenuScreen gameOptionsMenuScreen;

	// Token: 0x04001E20 RID: 7712
	public MenuSelectable languageOption;

	// Token: 0x04001E21 RID: 7713
	public GameObject languageOptionDescription;

	// Token: 0x04001E22 RID: 7714
	public MenuSelectable backerOption;

	// Token: 0x04001E23 RID: 7715
	public MenuSelectable nativeAchievementsOption;

	// Token: 0x04001E24 RID: 7716
	public MenuSelectable resetButton;

	// Token: 0x04001E25 RID: 7717
	public MenuSelectable applyButton;

	// Token: 0x04001E26 RID: 7718
	public bool reconfigureOnEnable;
}
