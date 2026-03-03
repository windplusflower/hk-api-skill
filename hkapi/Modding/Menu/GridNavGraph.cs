using System;
using System.Collections.Generic;
using UnityEngine.UI;

namespace Modding.Menu
{
	/// <summary>
	/// A navigation graph that connects selectables in a grid.
	/// </summary>
	// Token: 0x02000DC5 RID: 3525
	public class GridNavGraph : INavigationGraph
	{
		/// <summary>
		/// The number of columns in the current row.
		/// </summary>
		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x0600490E RID: 18702 RVA: 0x0018C3AB File Offset: 0x0018A5AB
		// (set) Token: 0x0600490F RID: 18703 RVA: 0x0018C3B3 File Offset: 0x0018A5B3
		public int Columns { get; private set; }

		/// <summary>
		/// Creates a new grid navigation graph.
		/// </summary>
		/// <param name="columns">The number of columns in the grid.</param>
		// Token: 0x06004910 RID: 18704 RVA: 0x0018C3BC File Offset: 0x0018A5BC
		public GridNavGraph(int columns)
		{
			this.Columns = columns;
			this.grid = new List<List<Selectable>>
			{
				new List<Selectable>()
			};
		}

		/// <summary>
		/// Starts a new row and changes the number of columns in the subsequent grid rows.
		/// </summary>
		/// <param name="columns">The new number of columns.</param>
		// Token: 0x06004911 RID: 18705 RVA: 0x0018C3E1 File Offset: 0x0018A5E1
		public void ChangeColumns(int columns)
		{
			this.Columns = columns;
			this.grid.Add(new List<Selectable>());
		}

		/// <inheritdoc />
		// Token: 0x06004912 RID: 18706 RVA: 0x0018C3FC File Offset: 0x0018A5FC
		public void AddNavigationNode(Selectable selectable)
		{
			List<Selectable> list = this.grid[this.grid.Count - 1];
			if (list == null || list.Count >= this.Columns)
			{
				list = new List<Selectable>();
				this.grid.Add(list);
			}
			list.Add(selectable);
		}

		/// <inheritdoc />
		// Token: 0x06004913 RID: 18707 RVA: 0x0018C44C File Offset: 0x0018A64C
		public Selectable BuildNavigation()
		{
			for (int i = 0; i < this.grid.Count; i++)
			{
				List<Selectable> wrapped = GridNavGraph.GetWrapped<List<Selectable>>(this.grid, i - 1);
				List<Selectable> list = this.grid[i];
				List<Selectable> wrapped2 = GridNavGraph.GetWrapped<List<Selectable>>(this.grid, i + 1);
				Selectable selectable = (wrapped.Count != list.Count) ? wrapped[0] : null;
				Selectable selectable2 = (wrapped2.Count != list.Count) ? wrapped2[0] : null;
				for (int j = 0; j < list.Count; j++)
				{
					list[j].navigation = new Navigation
					{
						mode = Navigation.Mode.Explicit,
						selectOnUp = (selectable ?? wrapped[j]),
						selectOnDown = (selectable2 ?? wrapped2[j]),
						selectOnLeft = GridNavGraph.GetWrapped<Selectable>(list, j - 1),
						selectOnRight = GridNavGraph.GetWrapped<Selectable>(list, j + 1)
					};
				}
			}
			List<Selectable> list2 = this.grid[0];
			if (list2 == null)
			{
				return null;
			}
			return list2[0];
		}

		// Token: 0x06004914 RID: 18708 RVA: 0x0018C56F File Offset: 0x0018A76F
		private static T GetWrapped<T>(List<T> list, int index)
		{
			if (index == -1)
			{
				return list[list.Count - 1];
			}
			if (index == list.Count)
			{
				return list[0];
			}
			return list[index];
		}

		// Token: 0x04004CC8 RID: 19656
		private List<List<Selectable>> grid;
	}
}
