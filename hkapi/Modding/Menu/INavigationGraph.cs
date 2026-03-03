using System;
using UnityEngine.UI;

namespace Modding.Menu
{
	/// <summary>
	/// An interface that assembles <c>Selectable</c>s into a coherent navigation graph.
	/// </summary>
	// Token: 0x02000DC1 RID: 3521
	public interface INavigationGraph
	{
		/// <summary>
		/// Registers a <c>Selectable</c> into the current navigation graph.
		/// </summary>
		/// <param name="selectable">The selectable to add.</param>
		// Token: 0x06004907 RID: 18695
		void AddNavigationNode(Selectable selectable);

		/// <summary>
		/// Builds the currently registered navigation nodes into a complete graph
		/// and returns the selectable to start selected, or null if there are none.<br />
		/// If the navigation graph implementation sets it in place this method may not do anything.
		/// </summary>
		// Token: 0x06004908 RID: 18696
		Selectable BuildNavigation();
	}
}
