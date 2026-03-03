using System;
using UnityEngine;

namespace Modding.Menu
{
	/// <summary>
	/// A class used for adding menu items to a canvas in a specific layout.
	/// </summary>
	// Token: 0x02000DC0 RID: 3520
	public class ContentArea
	{
		/// <summary>
		/// The game object to place the new content in.
		/// </summary>
		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x060048FF RID: 18687 RVA: 0x0018C0CB File Offset: 0x0018A2CB
		// (set) Token: 0x06004900 RID: 18688 RVA: 0x0018C0D3 File Offset: 0x0018A2D3
		public GameObject ContentObject { get; protected set; }

		/// <summary>
		/// The layout to apply to the content being added.
		/// </summary>
		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x06004901 RID: 18689 RVA: 0x0018C0DC File Offset: 0x0018A2DC
		// (set) Token: 0x06004902 RID: 18690 RVA: 0x0018C0E4 File Offset: 0x0018A2E4
		public IContentLayout Layout { get; set; }

		/// <summary>
		/// The navigation graph builder to place selectables in.
		/// </summary>
		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06004903 RID: 18691 RVA: 0x0018C0ED File Offset: 0x0018A2ED
		// (set) Token: 0x06004904 RID: 18692 RVA: 0x0018C0F5 File Offset: 0x0018A2F5
		public INavigationGraph NavGraph { get; set; }

		/// <summary>
		/// Creates a new <c>ContentArea</c>.
		/// </summary>
		/// <param name="obj">The object to place the added content in.</param>
		/// <param name="layout">The layout to apply to the content being added.</param>
		/// <param name="navGraph">The navigation graph to place the selectables in.</param>
		// Token: 0x06004905 RID: 18693 RVA: 0x0018C0FE File Offset: 0x0018A2FE
		public ContentArea(GameObject obj, IContentLayout layout, INavigationGraph navGraph)
		{
			this.ContentObject = obj;
			this.Layout = layout;
			this.NavGraph = navGraph;
		}

		/// <summary>
		/// Creates a new <c>ContentArea</c> with no navigation graph.
		/// </summary>
		/// <param name="obj">The object to place the added content in.</param>
		/// <param name="layout">The layout to apply to the content being added.</param>
		// Token: 0x06004906 RID: 18694 RVA: 0x0018C11C File Offset: 0x0018A31C
		public ContentArea(GameObject obj, IContentLayout layout) : this(obj, layout, default(NullNavigationGraph))
		{
		}
	}
}
