using System;
using UnityEngine;

namespace Modding.Menu.Config
{
	/// <summary>
	/// The styling options for the menu title.
	/// </summary>
	// Token: 0x02000DD8 RID: 3544
	public struct MenuTitleStyle
	{
		// Token: 0x06004944 RID: 18756 RVA: 0x0018CEB4 File Offset: 0x0018B0B4
		// Note: this type is marked as 'beforefieldinit'.
		static MenuTitleStyle()
		{
			MenuTitleStyle.vanillaStyle = new MenuTitleStyle
			{
				Pos = new AnchoredPosition
				{
					ChildAnchor = new Vector2(0.5f, 0.5f),
					ParentAnchor = new Vector2(0.5f, 0.5f),
					Offset = new Vector2(0f, 544f)
				},
				TextSize = 75
			};
		}

		/// <summary>
		/// The style preset of a standard menu title in the vanilla game.
		/// </summary>
		// Token: 0x04004D0F RID: 19727
		public static readonly MenuTitleStyle vanillaStyle;

		/// <summary>
		/// The position of the title.
		/// </summary>
		// Token: 0x04004D10 RID: 19728
		public AnchoredPosition Pos;

		/// <summary>
		/// The text size of the title.
		/// </summary>
		// Token: 0x04004D11 RID: 19729
		public int TextSize;
	}
}
