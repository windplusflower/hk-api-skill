using System;
using UnityEngine;

namespace Modding.Menu
{
	/// <summary>
	/// A struct to define anchored positioning relative to a parent.
	/// </summary>
	// Token: 0x02000DBB RID: 3515
	public struct AnchoredPosition
	{
		/// <summary>
		/// Creates a new <c>RectPosition</c>.
		/// </summary>
		/// <param name="parentAnchor">The normalized point on the parent to anchor the child on.</param>
		/// <param name="childAnchor">The normalized point on the child to anchor to the parent.</param>
		/// <param name="offset">The offset from the parent anchor to the child anchor.</param>
		// Token: 0x060048C7 RID: 18631 RVA: 0x0018B688 File Offset: 0x00189888
		public AnchoredPosition(Vector2 parentAnchor, Vector2 childAnchor, Vector2 offset = default(Vector2))
		{
			this.ParentAnchor = parentAnchor;
			this.ChildAnchor = childAnchor;
			this.Offset = offset;
		}

		/// <summary>
		/// Translate a <c>RectTransform</c> based on the fields in this struct.
		/// </summary>
		/// <param name="rt">The <c>RectTransform</c> to modify.</param>
		// Token: 0x060048C8 RID: 18632 RVA: 0x0018B6A0 File Offset: 0x001898A0
		public void Reposition(RectTransform rt)
		{
			this.GetRepositioned(rt).Apply(rt);
		}

		/// <summary>
		/// Get a translated <c>RectTransformData</c> based on the fields in this struct.
		/// </summary>
		/// <param name="rt">The <c>RectTransformData</c> to translate.</param>
		/// <returns></returns>
		// Token: 0x060048C9 RID: 18633 RVA: 0x0018B6C4 File Offset: 0x001898C4
		public RectTransformData GetRepositioned(RectTransformData rt)
		{
			Vector2 b = this.ParentAnchor - AnchoredPosition.ParentPointFromChild(rt, this.ChildAnchor);
			rt.pivot = this.ChildAnchor;
			rt.anchorMin += b;
			rt.anchorMax += b;
			rt.anchoredPosition = this.Offset;
			return rt;
		}

		/// <summary>
		/// Creates a <c>RectPosition</c> from an anchor on a sibling rectangle.
		/// </summary>
		/// <param name="selfAnchor">The normalized point on a rect to anchor to the sibling.</param>
		/// <param name="sibling">The sibling rectangle to anchor to.</param>
		/// <param name="siblingAnchor">The normalized point on the sibling to anchor to.</param>
		/// <param name="offset">The offset in pixels of the <c>selfAnchor</c> to the sibling anchor point.</param>
		/// <returns></returns>
		// Token: 0x060048CA RID: 18634 RVA: 0x0018B734 File Offset: 0x00189934
		public static AnchoredPosition FromSiblingAnchor(Vector2 selfAnchor, RectTransformData sibling, Vector2 siblingAnchor, Vector2 offset)
		{
			return new AnchoredPosition(AnchoredPosition.ParentPointFromChild(sibling, siblingAnchor), selfAnchor, sibling.anchoredPosition + offset);
		}

		/// <summary>
		/// Gets a normalized point on the parent from a normalized point on the child.
		/// </summary>
		/// <param name="child">The child rectangle.</param>
		/// <param name="childPoint">A normalized point on the child.</param>
		/// <returns></returns>
		// Token: 0x060048CB RID: 18635 RVA: 0x0018B74F File Offset: 0x0018994F
		public static Vector2 ParentPointFromChild(RectTransformData child, Vector2 childPoint)
		{
			return child.anchorMin + (child.anchorMax - child.anchorMin) * childPoint;
		}

		/// <summary>
		/// Translates an anchored position by a relative vector.
		/// </summary>
		// Token: 0x060048CC RID: 18636 RVA: 0x0018B773 File Offset: 0x00189973
		public static AnchoredPosition operator +(AnchoredPosition lhs, RelVector2 rhs)
		{
			return new AnchoredPosition(lhs.ParentAnchor + rhs.Relative, lhs.ChildAnchor, lhs.Offset + rhs.Delta);
		}

		/// <summary>
		/// Translates an anchored position by a relative vector.
		/// </summary>
		// Token: 0x060048CD RID: 18637 RVA: 0x0018B7A2 File Offset: 0x001899A2
		public static AnchoredPosition operator +(RelVector2 lhs, AnchoredPosition rhs)
		{
			return rhs + lhs;
		}

		/// <summary>
		/// The normalized anchoring point on the parent rectangle that will get anchored to the child.
		/// </summary>
		/// <remarks>
		/// The lower left corner is (0, 0) and the upper right corner is (1, 1).
		/// </remarks>
		// Token: 0x04004CAC RID: 19628
		public Vector2 ParentAnchor;

		/// <summary>
		/// The normalized anchoring point on this rectangle that will get anchored to the parent.
		/// </summary>
		/// <remarks>
		/// The lower left corner is (0, 0) and the upper right corner is (1, 1).
		/// </remarks>
		// Token: 0x04004CAD RID: 19629
		public Vector2 ChildAnchor;

		/// <summary>
		/// The offset in pixels of the <c>childAnchor</c> from the <c>parentAnchor</c>.
		/// </summary>
		// Token: 0x04004CAE RID: 19630
		public Vector2 Offset;
	}
}
