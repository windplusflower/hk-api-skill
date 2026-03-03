using System;
using UnityEngine;
using UnityEngine.UI;

namespace Modding.Menu.Config
{
	/// <summary>
	/// Configuration options for creating a scrollbar.
	/// </summary>
	// Token: 0x02000DD5 RID: 3541
	public struct ScrollbarConfig
	{
		/// <summary>
		/// A function to get padding for the selection scrolling. The returned tuple is `(bottom, top)`.
		/// </summary>
		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x06004942 RID: 18754 RVA: 0x0018CEA1 File Offset: 0x0018B0A1
		// (set) Token: 0x06004943 RID: 18755 RVA: 0x0018CEA9 File Offset: 0x0018B0A9
		public Func<RectTransform, ValueTuple<float, float>> SelectionPadding { readonly get; set; }

		/// <summary>
		/// The menu navigation to apply to the scrollbar.
		/// </summary>
		// Token: 0x04004D02 RID: 19714
		public Navigation Navigation;

		/// <summary>
		/// The anchored poisition to place the scrollbar.
		/// </summary>
		// Token: 0x04004D03 RID: 19715
		public AnchoredPosition Position;

		/// <summary>
		/// The action to run when pressing the menu cancel key while selecting this item.
		/// </summary>
		// Token: 0x04004D04 RID: 19716
		public Action<MenuPreventDeselect> CancelAction;
	}
}
