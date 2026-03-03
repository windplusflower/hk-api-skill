using System;
using UnityEngine.UI;

namespace Modding.Menu.Config
{
	/// <summary>
	/// Configuration options for creating a horizontal option.
	/// </summary>
	// Token: 0x02000DCC RID: 3532
	public struct HorizontalOptionConfig
	{
		/// <summary>
		/// The list of options to display.
		/// </summary>
		// Token: 0x04004CDF RID: 19679
		public string[] Options;

		/// <summary>
		/// The displayed name of the option.
		/// </summary>
		// Token: 0x04004CE0 RID: 19680
		public string Label;

		/// <summary>
		/// The action to run when the menu setting is changed.
		/// </summary>
		// Token: 0x04004CE1 RID: 19681
		public MenuSetting.ApplySetting ApplySetting;

		/// <summary>
		/// The action to run when loading the saved setting.
		/// </summary>
		// Token: 0x04004CE2 RID: 19682
		public MenuSetting.RefreshSetting RefreshSetting;

		/// <summary>
		/// The action to run when pressing the menu cancel key while selecting this item.
		/// </summary>
		// Token: 0x04004CE3 RID: 19683
		public Action<MenuSelectable> CancelAction;

		/// <summary>
		/// The styling of the menu option.
		/// </summary>
		// Token: 0x04004CE4 RID: 19684
		public HorizontalOptionStyle? Style;

		/// <summary>
		/// The description of the option that gets displayed underneath.
		/// </summary>
		// Token: 0x04004CE5 RID: 19685
		public DescriptionInfo? Description;
	}
}
