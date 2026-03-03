using System;

namespace Modding.Menu.Config
{
	/// <summary>
	/// The styling options of a keybind menu item.
	/// </summary>
	// Token: 0x02000DD2 RID: 3538
	public struct KeybindStyle
	{
		// Token: 0x06004940 RID: 18752 RVA: 0x0018CE48 File Offset: 0x0018B048
		// Note: this type is marked as 'beforefieldinit'.
		static KeybindStyle()
		{
			KeybindStyle.VanillaStyle = new KeybindStyle
			{
				LabelTextSize = 37
			};
		}

		/// <summary>
		/// The style preset of a keybind in the vanilla game.
		/// </summary>
		// Token: 0x04004CF7 RID: 19703
		public static readonly KeybindStyle VanillaStyle;

		/// <summary>
		/// The text size of the label text.
		/// </summary>
		// Token: 0x04004CF8 RID: 19704
		public int LabelTextSize;
	}
}
