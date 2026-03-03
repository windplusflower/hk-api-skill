using System;

namespace Modding.Menu.Config
{
	/// <summary>
	/// Configuration options for creating a menu keybind option.
	/// </summary>
	// Token: 0x02000DD0 RID: 3536
	public struct KeybindConfig
	{
		/// <summary>
		/// The displayed text for the name of the keybind.
		/// </summary>
		// Token: 0x04004CF1 RID: 19697
		public string Label;

		/// <summary>
		/// The style of the keybind.
		/// </summary>
		// Token: 0x04004CF2 RID: 19698
		public KeybindStyle? Style;

		/// <summary>
		/// The action to run when pressing the menu cancel key while selecting this item.
		/// </summary>
		// Token: 0x04004CF3 RID: 19699
		public Action<MappableKey> CancelAction;
	}
}
