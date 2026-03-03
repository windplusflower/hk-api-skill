using System;
using HKMenu;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020004CA RID: 1226
public class VideoMenuOptions : MonoBehaviour, IMenuOptionLayout
{
	// Token: 0x06001B43 RID: 6979 RVA: 0x00083058 File Offset: 0x00081258
	public void ConfigureNavigation()
	{
		if (GameManager.instance.gameConfig.enableTFRSetting)
		{
			this.frameCapOption.transform.parent.gameObject.SetActive(true);
			Navigation navigation = this.vsyncOption.navigation;
			navigation.selectOnDown = this.frameCapOption;
			this.vsyncOption.navigation = navigation;
			Navigation navigation2 = this.screenScaleOption.navigation;
			navigation2.selectOnUp = this.frameCapOption;
			this.screenScaleOption.navigation = navigation2;
		}
	}

	// Token: 0x040020BA RID: 8378
	public MenuScreen videoMenuScreen;

	// Token: 0x040020BB RID: 8379
	public MenuSelectable vsyncOption;

	// Token: 0x040020BC RID: 8380
	public MenuSelectable frameCapOption;

	// Token: 0x040020BD RID: 8381
	public MenuSelectable screenScaleOption;

	// Token: 0x040020BE RID: 8382
	public MenuSelectable resetButton;

	// Token: 0x040020BF RID: 8383
	public MenuSelectable applyButton;
}
