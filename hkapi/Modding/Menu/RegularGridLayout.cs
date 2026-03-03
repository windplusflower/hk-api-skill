using System;
using UnityEngine;

namespace Modding.Menu
{
	/// <summary>
	/// A layout to place items in a grid pattern.
	/// </summary>
	// Token: 0x02000DB8 RID: 3512
	public class RegularGridLayout : IContentLayout
	{
		/// <summary>
		/// The "size" of a cell in the grid.
		/// </summary>
		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x060048B2 RID: 18610 RVA: 0x0018B3C8 File Offset: 0x001895C8
		// (set) Token: 0x060048B3 RID: 18611 RVA: 0x0018B3D0 File Offset: 0x001895D0
		public RelVector2 ItemAdvance { get; set; }

		/// <summary>
		/// The starting position of the first cell.
		/// </summary>
		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x060048B4 RID: 18612 RVA: 0x0018B3D9 File Offset: 0x001895D9
		// (set) Token: 0x060048B5 RID: 18613 RVA: 0x0018B3E1 File Offset: 0x001895E1
		public AnchoredPosition Start { get; set; }

		/// <summary>
		/// The maximum number of columns to allow.
		/// </summary>
		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x060048B6 RID: 18614 RVA: 0x0018B3EA File Offset: 0x001895EA
		// (set) Token: 0x060048B7 RID: 18615 RVA: 0x0018B3F2 File Offset: 0x001895F2
		public int Columns { get; set; }

		/// <summary>
		/// The "index" of the next item to be placed.
		/// </summary>
		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x060048B8 RID: 18616 RVA: 0x0018B3FB File Offset: 0x001895FB
		// (set) Token: 0x060048B9 RID: 18617 RVA: 0x0018B403 File Offset: 0x00189603
		public int Index { get; set; }

		/// <summary>
		/// The position in grid cells of the next item.
		/// </summary>
		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x060048BA RID: 18618 RVA: 0x0018B40C File Offset: 0x0018960C
		public Vector2Int IndexPos
		{
			get
			{
				return new Vector2Int(this.Index % this.Columns, this.Index / this.Columns);
			}
		}

		/// <summary>
		/// Creates a new regular grid layout.
		/// </summary>
		/// <param name="start">The starting position of the first item in the grid.</param>
		/// <param name="itemAdvance">The "size" of a cell in the grid.</param>
		/// <param name="columns">The maximum number of columns to allow.</param>
		// Token: 0x060048BB RID: 18619 RVA: 0x0018B42D File Offset: 0x0018962D
		public RegularGridLayout(AnchoredPosition start, RelVector2 itemAdvance, int columns)
		{
			this.Start = start;
			this.ItemAdvance = itemAdvance;
			this.Columns = columns;
		}

		/// <summary>
		/// Creates a single column, top down vertical layout.
		/// </summary>
		/// <param name="itemHeight">The height of each item.</param>
		/// <param name="start">The starting position.</param>
		/// <returns></returns>
		// Token: 0x060048BC RID: 18620 RVA: 0x0018B44C File Offset: 0x0018964C
		public static RegularGridLayout CreateVerticalLayout(float itemHeight, Vector2 start = default(Vector2))
		{
			return new RegularGridLayout(new AnchoredPosition
			{
				ChildAnchor = new Vector2(0.5f, 1f),
				ParentAnchor = new Vector2(0.5f, 1f),
				Offset = start
			}, new RelVector2(new Vector2(0f, -itemHeight)), 1);
		}

		/// <summary>
		/// Modifies a <c>RectTransform</c> to place it in the next spot in the grid.
		/// </summary>
		/// <param name="rt">The <c>RectTransform</c> to modify.</param>
		// Token: 0x060048BD RID: 18621 RVA: 0x0018B4B0 File Offset: 0x001896B0
		public void ModifyNext(RectTransform rt)
		{
			(this.Start + this.ItemAdvance * this.IndexPos).Reposition(rt);
			this.Index++;
		}

		/// <summary>
		/// Changes the column width of the layout, continuing where the layout left off.<br />
		/// This method should generally only be called at the end of a row,
		/// because otherwise it may cause an overlap of the currently placed menu items
		/// and the new menu items in the same row.<br />
		/// Internally this method resets the actual index count so a copy of index should be saved before calling
		/// this method if needed.
		/// </summary>
		/// <param name="columns">The new number of columns.</param>
		/// <param name="originalAnchor">The normalized anchor on the original "width" to place the new grid.</param>
		/// <param name="newSize">The new size of the grid element, or null to not change.</param>
		/// <param name="newAnchor">The normalized anchor on the new "width" to place the anchor.</param>
		// Token: 0x060048BE RID: 18622 RVA: 0x0018B4F8 File Offset: 0x001896F8
		public void ChangeColumns(int columns, float originalAnchor = 0.5f, RelVector2? newSize = null, float newAnchor = 0.5f)
		{
			RelVector2 itemAdvance = newSize ?? this.ItemAdvance;
			RelLength y = this.ItemAdvance.y * (float)this.IndexPos.y;
			RelLength rhs = this.ItemAdvance.x * (float)this.Columns * originalAnchor - itemAdvance.x * (float)columns * newAnchor;
			RelLength x = this.Start.ChildAnchor.x * itemAdvance.x + rhs;
			this.Index = 0;
			this.Columns = columns;
			this.Start += new RelVector2(x, y);
			this.ItemAdvance = itemAdvance;
		}
	}
}
