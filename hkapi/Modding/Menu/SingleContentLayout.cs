using System;
using UnityEngine;

namespace Modding.Menu
{
	/// <summary>
	/// A layout that places every object in the same position.
	/// </summary>
	// Token: 0x02000DBA RID: 3514
	public class SingleContentLayout : IContentLayout
	{
		/// <summary>
		/// The position to place the object in.
		/// </summary>
		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x060048C2 RID: 18626 RVA: 0x0018B626 File Offset: 0x00189826
		// (set) Token: 0x060048C3 RID: 18627 RVA: 0x0018B62E File Offset: 0x0018982E
		public AnchoredPosition Position { get; set; }

		/// <summary>
		/// Creates a layout with the position anchoring the same spot on the child and parent together.
		/// </summary>
		/// <param name="anchor">The point to anchor the child to the parent.</param>
		// Token: 0x060048C4 RID: 18628 RVA: 0x0018B638 File Offset: 0x00189838
		public SingleContentLayout(Vector2 anchor) : this(new AnchoredPosition(anchor, anchor, default(Vector2)))
		{
		}

		/// <summary>
		/// Creates a layout from a <c>RectPosition</c>.
		/// </summary>
		/// <param name="pos">The position to place the objects in.</param>
		// Token: 0x060048C5 RID: 18629 RVA: 0x0018B65B File Offset: 0x0018985B
		public SingleContentLayout(AnchoredPosition pos)
		{
			this.Position = pos;
		}

		/// <summary>
		/// Modifies a <c>RectTransform</c> to place it in the specified location.
		/// </summary>
		/// <param name="rt">The <c>RectTransform</c> to modify.</param>
		// Token: 0x060048C6 RID: 18630 RVA: 0x0018B66C File Offset: 0x0018986C
		public void ModifyNext(RectTransform rt)
		{
			this.Position.Reposition(rt);
		}
	}
}
