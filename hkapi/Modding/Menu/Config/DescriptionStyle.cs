using System;
using UnityEngine;

namespace Modding.Menu.Config
{
	/// <summary>
	/// The styling options of a horizontal option's description text
	/// </summary>
	// Token: 0x02000DCF RID: 3535
	public struct DescriptionStyle
	{
		// Token: 0x0600493F RID: 18751 RVA: 0x0018CDB8 File Offset: 0x0018AFB8
		// Note: this type is marked as 'beforefieldinit'.
		static DescriptionStyle()
		{
			DescriptionStyle.HorizOptionSingleLineVanillaStyle = new DescriptionStyle
			{
				TextSize = 38,
				TextAnchor = TextAnchor.UpperLeft,
				Size = new RelVector2(new RelLength(0f, 1f), new RelLength(40f))
			};
			DescriptionStyle.MenuButtonSingleLineVanillaStyle = new DescriptionStyle
			{
				TextSize = 38,
				TextAnchor = TextAnchor.UpperCenter,
				Size = new RelVector2(new RelLength(1000f), new RelLength(40f))
			};
		}

		/// <summary>
		/// The style preset of a single line description in the vanilla game.
		/// </summary>
		// Token: 0x04004CEC RID: 19692
		public static readonly DescriptionStyle HorizOptionSingleLineVanillaStyle;

		/// <summary>
		/// The style preset of a single line description in the vanilla game.
		/// </summary>
		// Token: 0x04004CED RID: 19693
		public static readonly DescriptionStyle MenuButtonSingleLineVanillaStyle;

		/// <summary>
		/// The size of the text on the description.
		/// </summary>
		// Token: 0x04004CEE RID: 19694
		public int TextSize;

		/// <summary>
		/// The position the text should be anchored in.
		/// </summary>
		// Token: 0x04004CEF RID: 19695
		public TextAnchor TextAnchor;

		/// <summary>
		/// The height of the description text.
		/// </summary>
		// Token: 0x04004CF0 RID: 19696
		public RelVector2 Size;
	}
}
