using System;
using UnityEngine.UI;

namespace Modding.Menu.Config
{
	/// <summary>
	/// Configuration options for creating a menu button.
	/// </summary>
	// Token: 0x02000DD3 RID: 3539
	public struct MenuButtonConfig
	{
		/// <summary>
		/// The text to render on the button.
		/// </summary>
		// Token: 0x04004CF9 RID: 19705
		public string Label;

		/// <summary>
		/// The action to run when the button is pressed.
		/// </summary>
		// Token: 0x04004CFA RID: 19706
		public Action<MenuButton> SubmitAction;

		/// <summary>
		/// Whether the button when activated proceeds to a new menu.
		/// </summary>
		// Token: 0x04004CFB RID: 19707
		public bool Proceed;

		/// <summary>
		/// The action to run when pressing the menu cancel key while selecting this item.
		/// </summary>
		// Token: 0x04004CFC RID: 19708
		public Action<MenuSelectable> CancelAction;

		/// <summary>
		/// The styling of the menu button.
		/// </summary>
		// Token: 0x04004CFD RID: 19709
		public MenuButtonStyle? Style;

		/// <summary>
		/// The description of the option that gets displayed underneath.
		/// </summary>
		// Token: 0x04004CFE RID: 19710
		public DescriptionInfo? Description;
	}
}
