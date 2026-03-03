using System;
using GlobalEnums;
using UnityEngine.UI;

namespace Modding.Patches
{
	// Token: 0x02000DA7 RID: 3495
	public static class MenuSelectableExt
	{
		// Token: 0x06004889 RID: 18569 RVA: 0x00189234 File Offset: 0x00187434
		public static void SetDynamicMenuCancel(this MenuSelectable ms, MenuScreen to)
		{
			ms.cancelAction = CancelAction.GoToExtrasMenu;
			(ms as MenuSelectable).customCancelAction = delegate(MenuSelectable self)
			{
				UIManager uimanager = (UIManager)UIManager.instance;
				uimanager.StartMenuAnimationCoroutine(uimanager.GoToDynamicMenu(to));
			};
		}
	}
}
