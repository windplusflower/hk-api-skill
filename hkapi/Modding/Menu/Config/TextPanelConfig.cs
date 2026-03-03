using System;
using UnityEngine;

namespace Modding.Menu.Config
{
	/// <summary>
	/// Configuration options for creating a text panel.
	/// </summary>
	// Token: 0x02000DD6 RID: 3542
	public struct TextPanelConfig
	{
		/// <summary>
		/// The text to render.
		/// </summary>
		// Token: 0x04004D06 RID: 19718
		public string Text;

		/// <summary>
		/// The font size of the text.
		/// </summary>
		// Token: 0x04004D07 RID: 19719
		public int Size;

		/// <summary>
		/// The font to render.
		/// </summary>
		// Token: 0x04004D08 RID: 19720
		public TextPanelConfig.TextFont Font;

		/// <summary>
		/// The position where the text should be anchored to.
		/// </summary>
		// Token: 0x04004D09 RID: 19721
		public TextAnchor Anchor;

		/// <summary>
		/// The four main fonts that Hollow Knight uses in the menus.
		/// </summary>
		// Token: 0x02000DD7 RID: 3543
		public enum TextFont
		{
			/// <summary>
			/// The Trajan regular font.
			/// </summary>
			// Token: 0x04004D0B RID: 19723
			TrajanRegular,
			/// <summary>
			/// The Trajan bold font.
			/// </summary>
			// Token: 0x04004D0C RID: 19724
			TrajanBold,
			/// <summary>
			/// The perpetua font.
			/// </summary>
			// Token: 0x04004D0D RID: 19725
			Perpetua,
			/// <summary>
			/// The Noto Serif CJK SC regular font.
			/// </summary>
			// Token: 0x04004D0E RID: 19726
			NotoSerifCJKSCRegular
		}
	}
}
