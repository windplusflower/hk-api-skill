using System;
using UnityEngine.UI;

namespace Modding.Menu
{
	/// <summary>
	/// A navigation graph that does nothing.
	/// </summary>
	// Token: 0x02000DC2 RID: 3522
	public struct NullNavigationGraph : INavigationGraph
	{
		/// <summary>
		/// Do nothing with the passed in selectable.
		/// </summary>
		/// <param name="selectable"></param>
		// Token: 0x06004909 RID: 18697 RVA: 0x00003603 File Offset: 0x00001803
		public void AddNavigationNode(Selectable selectable)
		{
		}

		/// <inheritdoc />
		// Token: 0x0600490A RID: 18698 RVA: 0x000086D3 File Offset: 0x000068D3
		public Selectable BuildNavigation()
		{
			return null;
		}
	}
}
