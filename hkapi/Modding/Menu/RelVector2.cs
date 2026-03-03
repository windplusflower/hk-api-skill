using System;
using UnityEngine;

namespace Modding.Menu
{
	/// <summary>
	/// A struct to define size relative to a parent.
	/// </summary>
	// Token: 0x02000DBC RID: 3516
	public struct RelVector2
	{
		/// <summary>
		/// The x component of this vector.
		/// </summary>
		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x060048CE RID: 18638 RVA: 0x0018B7AB File Offset: 0x001899AB
		// (set) Token: 0x060048CF RID: 18639 RVA: 0x0018B7C8 File Offset: 0x001899C8
		public RelLength x
		{
			get
			{
				return new RelLength(this.Delta.x, this.Relative.x);
			}
			set
			{
				this.Delta.x = value.Delta;
				this.Relative.x = value.Relative;
			}
		}

		/// <summary>
		/// The y component of this vector.
		/// </summary>
		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x060048D0 RID: 18640 RVA: 0x0018B7EC File Offset: 0x001899EC
		// (set) Token: 0x060048D1 RID: 18641 RVA: 0x0018B809 File Offset: 0x00189A09
		public RelLength y
		{
			get
			{
				return new RelLength(this.Delta.y, this.Relative.y);
			}
			set
			{
				this.Delta.y = value.Delta;
				this.Relative.y = value.Relative;
			}
		}

		/// <summary>
		/// Creates a <c>RectSize</c> from two parent-relative lengths.
		/// </summary>
		/// <param name="x">The length on the <c>x</c> axis.</param>
		/// <param name="y">The length on the <c>y</c> axis.</param>
		/// <returns></returns>
		// Token: 0x060048D2 RID: 18642 RVA: 0x0018B82D File Offset: 0x00189A2D
		public RelVector2(RelLength x, RelLength y)
		{
			this.Delta = new Vector2(x.Delta, y.Delta);
			this.Relative = new Vector2(x.Relative, y.Relative);
		}

		/// <summary>
		/// Creates a <c>RectSize</c> from a size delta and a normalized parent-relative size.
		/// </summary>
		/// <param name="sizeDelta">The size delta in pixels.</param>
		/// <param name="parentRelSize">The normalized parent-relative size.</param>
		// Token: 0x060048D3 RID: 18643 RVA: 0x0018B85D File Offset: 0x00189A5D
		public RelVector2(Vector2 sizeDelta, Vector2 parentRelSize)
		{
			this.Delta = sizeDelta;
			this.Relative = parentRelSize;
		}

		/// <summary>
		/// Creates a <c>RectSize</c> from an absolute size in pixels.
		/// </summary>
		/// <param name="size">The size in pixels.</param>
		// Token: 0x060048D4 RID: 18644 RVA: 0x0018B870 File Offset: 0x00189A70
		public RelVector2(Vector2 size)
		{
			this = new RelVector2(size, default(Vector2));
		}

		/// <summary>
		/// Gets a <c>RectTransformData</c> with the correct sizing information.
		/// </summary>
		/// <returns></returns>
		// Token: 0x060048D5 RID: 18645 RVA: 0x0018B890 File Offset: 0x00189A90
		public RectTransformData GetBaseTransformData()
		{
			return new RectTransformData
			{
				sizeDelta = this.Delta,
				anchorMin = default(Vector2),
				anchorMax = this.Relative
			};
		}

		/// <summary>  
		/// Negates each element in a <c>RelVector2</c>.
		/// </summary>
		// Token: 0x060048D6 RID: 18646 RVA: 0x0018B8CD File Offset: 0x00189ACD
		public static RelVector2 operator -(RelVector2 self)
		{
			return new RelVector2(-self.Delta, -self.Relative);
		}

		/// <summary>
		/// Adds two <c>RelVector2</c>s together.
		/// </summary>
		// Token: 0x060048D7 RID: 18647 RVA: 0x0018B8EA File Offset: 0x00189AEA
		public static RelVector2 operator +(RelVector2 lhs, RelVector2 rhs)
		{
			return new RelVector2(lhs.Delta + rhs.Delta, lhs.Relative + rhs.Relative);
		}

		/// <summary>
		/// Subtracts one <c>RelVector2</c> from another.
		/// </summary>
		// Token: 0x060048D8 RID: 18648 RVA: 0x0018B913 File Offset: 0x00189B13
		public static RelVector2 operator -(RelVector2 lhs, RelVector2 rhs)
		{
			return new RelVector2(lhs.Delta - rhs.Delta, lhs.Relative - rhs.Relative);
		}

		/// <summary>
		/// Scales both dimensions of a <c>RelVector2</c> up by a constant factor.
		/// </summary>
		// Token: 0x060048D9 RID: 18649 RVA: 0x0018B93C File Offset: 0x00189B3C
		public static RelVector2 operator *(RelVector2 lhs, float rhs)
		{
			return new RelVector2(lhs.Delta * rhs, lhs.Relative * rhs);
		}

		/// <summary>
		/// Scales both dimensions of a <c>RelVector2</c> up by a constant factor.
		/// </summary>
		// Token: 0x060048DA RID: 18650 RVA: 0x0018B95B File Offset: 0x00189B5B
		public static RelVector2 operator *(float lhs, RelVector2 rhs)
		{
			return rhs * lhs;
		}

		/// <summary>
		/// Scales both dimensions of a <c>RelVector2</c> up by the respective factor in a <c>Vector2</c>.
		/// </summary>
		// Token: 0x060048DB RID: 18651 RVA: 0x0018B964 File Offset: 0x00189B64
		public static RelVector2 operator *(RelVector2 lhs, Vector2 rhs)
		{
			return new RelVector2(lhs.Delta * rhs, lhs.Relative * rhs);
		}

		/// <summary>
		/// Scales both dimensions of a <c>RelVector2</c> down by a constant factor.
		/// </summary>
		// Token: 0x060048DC RID: 18652 RVA: 0x0018B983 File Offset: 0x00189B83
		public static RelVector2 operator /(RelVector2 lhs, float rhs)
		{
			return new RelVector2(lhs.Delta / rhs, lhs.Relative / rhs);
		}

		/// <summary>
		/// The size in pixels to increase the parent-relative size of the rect.
		/// </summary>
		// Token: 0x04004CAF RID: 19631
		public Vector2 Delta;

		/// <summary>
		/// The normalized parent-relative size of the rect.
		/// </summary>
		// Token: 0x04004CB0 RID: 19632
		public Vector2 Relative;
	}
}
