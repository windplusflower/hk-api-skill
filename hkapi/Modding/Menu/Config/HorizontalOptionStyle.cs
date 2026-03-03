using System;
using UnityEngine;

namespace Modding.Menu.Config
{
	/// <summary>
	/// The styling options for a horizontal option.
	/// </summary>
	// Token: 0x02000DCD RID: 3533
	public struct HorizontalOptionStyle
	{
		// Token: 0x0600493E RID: 18750 RVA: 0x0018CD58 File Offset: 0x0018AF58
		// Note: this type is marked as 'beforefieldinit'.
		static HorizontalOptionStyle()
		{
			HorizontalOptionStyle.VanillaStyle = new HorizontalOptionStyle
			{
				Size = new RelVector2
				{
					Relative = default(Vector2),
					Delta = new Vector2(1000f, 60f)
				},
				LabelTextSize = 46,
				ValueTextSize = 46
			};
		}

		/// <summary>
		/// The style preset of a horizontal option in the vanilla game.
		/// </summary>
		// Token: 0x04004CE6 RID: 19686
		public static readonly HorizontalOptionStyle VanillaStyle;

		/// <summary>
		/// The size of the main option.
		/// </summary>
		// Token: 0x04004CE7 RID: 19687
		public RelVector2 Size;

		/// <summary>
		/// The size of the text on the option label.
		/// </summary>
		// Token: 0x04004CE8 RID: 19688
		public int LabelTextSize;

		/// <summary>
		/// The size of the text on the option value.
		/// </summary>
		// Token: 0x04004CE9 RID: 19689
		public int ValueTextSize;
	}
}
