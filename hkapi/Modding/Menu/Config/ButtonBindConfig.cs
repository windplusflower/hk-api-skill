using System;

namespace Modding.Menu.Config
{
	/// <summary>
	/// Configuration options for creating a menu buttonBind option.
	/// </summary>
	// Token: 0x02000DD1 RID: 3537
	public struct ButtonBindConfig
	{
		/// <summary>
		/// The displayed text for the name of the ButtonBind.
		/// </summary>
		// Token: 0x04004CF4 RID: 19700
		public string Label;

		/// <summary>
		/// The style of the ButtonBind.
		/// </summary>
		// Token: 0x04004CF5 RID: 19701
		public KeybindStyle? Style;

		/// <summary>
		/// The action to run when pressing the menu cancel key while selecting this item.
		/// </summary>
		// Token: 0x04004CF6 RID: 19702
		public Action<MappableControllerButton> CancelAction;
	}
}
