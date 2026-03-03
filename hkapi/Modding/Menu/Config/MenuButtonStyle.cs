using System;

namespace Modding.Menu.Config
{
	/// <summary>
	/// The styling options for a menu button.
	/// </summary>
	// Token: 0x02000DD4 RID: 3540
	public struct MenuButtonStyle
	{
		// Token: 0x06004941 RID: 18753 RVA: 0x0018CE6C File Offset: 0x0018B06C
		// Note: this type is marked as 'beforefieldinit'.
		static MenuButtonStyle()
		{
			MenuButtonStyle.VanillaStyle = new MenuButtonStyle
			{
				Height = new RelLength(60f),
				TextSize = 45
			};
		}

		/// <summary>
		/// The style preset of a menu button in the vanilla game.
		/// </summary>
		// Token: 0x04004CFF RID: 19711
		public static readonly MenuButtonStyle VanillaStyle;

		/// <summary>
		/// The size of the menu button.
		/// </summary>
		// Token: 0x04004D00 RID: 19712
		public RelLength Height;

		/// <summary>
		/// The size of the text on the button.
		/// </summary>
		// Token: 0x04004D01 RID: 19713
		public int TextSize;
	}
}
