using System;
using UnityEngine.UI;

namespace Modding.Menu
{
	/// <summary>
	/// A navigation graph that chains selectables like a circular linked list.
	/// </summary>
	// Token: 0x02000DC3 RID: 3523
	public class ChainedNavGraph : INavigationGraph
	{
		/// <summary>
		/// Creates a new chained navigation graph.
		/// </summary>
		/// <param name="dir">The direction to place successive selectables.</param>
		// Token: 0x0600490B RID: 18699 RVA: 0x0018C13F File Offset: 0x0018A33F
		public ChainedNavGraph(ChainedNavGraph.ChainDir dir = ChainedNavGraph.ChainDir.Down)
		{
			this.dir = dir;
		}

		/// <inheritdoc />
		// Token: 0x0600490C RID: 18700 RVA: 0x0018C150 File Offset: 0x0018A350
		public void AddNavigationNode(Selectable selectable)
		{
			if (this.first == null)
			{
				this.first = selectable;
				this.last = selectable;
				this.first.navigation = new Navigation
				{
					mode = Navigation.Mode.Explicit
				};
				return;
			}
			switch (this.dir)
			{
			case ChainedNavGraph.ChainDir.Down:
			{
				selectable.navigation = new Navigation
				{
					selectOnDown = this.first,
					selectOnUp = this.last,
					mode = Navigation.Mode.Explicit
				};
				Navigation navigation = this.first.navigation;
				navigation.selectOnUp = selectable;
				this.first.navigation = navigation;
				Navigation navigation2 = this.last.navigation;
				navigation2.selectOnDown = selectable;
				this.last.navigation = navigation2;
				this.last = selectable;
				return;
			}
			case ChainedNavGraph.ChainDir.Up:
			{
				selectable.navigation = new Navigation
				{
					selectOnUp = this.first,
					selectOnDown = this.last,
					mode = Navigation.Mode.Explicit
				};
				Navigation navigation3 = this.first.navigation;
				navigation3.selectOnDown = selectable;
				this.first.navigation = navigation3;
				Navigation navigation4 = this.last.navigation;
				navigation4.selectOnUp = selectable;
				this.last.navigation = navigation4;
				this.last = selectable;
				return;
			}
			case ChainedNavGraph.ChainDir.Right:
			{
				selectable.navigation = new Navigation
				{
					selectOnRight = this.first,
					selectOnLeft = this.last,
					mode = Navigation.Mode.Explicit
				};
				Navigation navigation5 = this.first.navigation;
				navigation5.selectOnLeft = selectable;
				this.first.navigation = navigation5;
				Navigation navigation6 = this.last.navigation;
				navigation6.selectOnRight = selectable;
				this.last.navigation = navigation6;
				this.last = selectable;
				return;
			}
			case ChainedNavGraph.ChainDir.Left:
			{
				selectable.navigation = new Navigation
				{
					selectOnLeft = this.first,
					selectOnRight = this.last,
					mode = Navigation.Mode.Explicit
				};
				Navigation navigation7 = this.first.navigation;
				navigation7.selectOnRight = selectable;
				this.first.navigation = navigation7;
				Navigation navigation8 = this.last.navigation;
				navigation8.selectOnLeft = selectable;
				this.last.navigation = navigation8;
				this.last = selectable;
				return;
			}
			default:
				return;
			}
		}

		/// <inheritdoc />
		// Token: 0x0600490D RID: 18701 RVA: 0x0018C3A3 File Offset: 0x0018A5A3
		public Selectable BuildNavigation()
		{
			return this.first;
		}

		// Token: 0x04004CBF RID: 19647
		private Selectable first;

		// Token: 0x04004CC0 RID: 19648
		private Selectable last;

		// Token: 0x04004CC1 RID: 19649
		private ChainedNavGraph.ChainDir dir;

		/// <summary>
		/// The direction to chain selectables.
		/// </summary>
		// Token: 0x02000DC4 RID: 3524
		public enum ChainDir
		{
			/// <summary>
			/// Place successive selectables downwards.
			/// </summary>
			// Token: 0x04004CC3 RID: 19651
			Down,
			/// <summary>
			/// Place successive selectables upwards.
			/// </summary>
			// Token: 0x04004CC4 RID: 19652
			Up,
			/// <summary>
			/// Place successive selectables rightwards.
			/// </summary>
			// Token: 0x04004CC5 RID: 19653
			Right,
			/// <summary>
			/// Place successive selectables leftwards.
			/// </summary>
			// Token: 0x04004CC6 RID: 19654
			Left
		}
	}
}
