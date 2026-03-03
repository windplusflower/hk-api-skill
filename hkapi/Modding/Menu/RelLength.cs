using System;

namespace Modding.Menu
{
	/// <summary>
	/// A struct to define a scalar length relative to a parent.
	/// </summary>
	// Token: 0x02000DBD RID: 3517
	public struct RelLength
	{
		/// <summary>
		/// Creates a new <c>ParentRelLength</c> from a length delta and a normalized parent-relative length.
		/// </summary>
		/// <param name="lengthDelta">The pixels to be added to the size from the scaled parent-relative length.</param>
		/// <param name="parentRelLength">The normalized parent-relative length.</param>
		// Token: 0x060048DD RID: 18653 RVA: 0x0018B9A2 File Offset: 0x00189BA2
		public RelLength(float lengthDelta, float parentRelLength)
		{
			this.Delta = lengthDelta;
			this.Relative = parentRelLength;
		}

		/// <summary>
		/// Creates a new absolute <c>ParentRelLength</c> from a length in pixels.
		/// </summary>
		/// <param name="length">The length in pixels.</param>
		// Token: 0x060048DE RID: 18654 RVA: 0x0018B9B2 File Offset: 0x00189BB2
		public RelLength(float length)
		{
			this = new RelLength(length, 0f);
		}

		/// <summary>
		/// Negates the <c>RelLenght</c>.
		/// </summary>
		// Token: 0x060048DF RID: 18655 RVA: 0x0018B9C0 File Offset: 0x00189BC0
		public static RelLength operator -(RelLength self)
		{
			return new RelLength(-self.Delta, -self.Relative);
		}

		/// <summary>
		/// Adds two <c>RelLength</c>s together.
		/// </summary>
		// Token: 0x060048E0 RID: 18656 RVA: 0x0018B9D5 File Offset: 0x00189BD5
		public static RelLength operator +(RelLength lhs, RelLength rhs)
		{
			return new RelLength(lhs.Delta + rhs.Delta, lhs.Relative + rhs.Relative);
		}

		/// <summary>
		/// Subtracts one <c>RelVector2</c> from another.
		/// </summary>
		// Token: 0x060048E1 RID: 18657 RVA: 0x0018B9F6 File Offset: 0x00189BF6
		public static RelLength operator -(RelLength lhs, RelLength rhs)
		{
			return new RelLength(lhs.Delta - rhs.Delta, lhs.Relative - rhs.Relative);
		}

		/// <summary>
		/// Scales both dimensions of a <c>RelVector2</c> up by a constant factor.
		/// </summary>
		// Token: 0x060048E2 RID: 18658 RVA: 0x0018BA17 File Offset: 0x00189C17
		public static RelLength operator *(RelLength lhs, float rhs)
		{
			return new RelLength(lhs.Delta * rhs, lhs.Relative * rhs);
		}

		/// <summary>
		/// Scales both dimensions of a <c>RelVector2</c> up by a constant factor.
		/// </summary>
		// Token: 0x060048E3 RID: 18659 RVA: 0x0018BA2E File Offset: 0x00189C2E
		public static RelLength operator *(float lhs, RelLength rhs)
		{
			return rhs * lhs;
		}

		/// <summary>
		/// Scales both dimensions of a <c>RelVector2</c> down by a constant factor.
		/// </summary>
		// Token: 0x060048E4 RID: 18660 RVA: 0x0018BA37 File Offset: 0x00189C37
		public static RelLength operator /(RelLength lhs, float rhs)
		{
			return new RelLength(lhs.Delta / rhs, lhs.Relative / rhs);
		}

		/// <summary>
		/// The length in pixels to increase the parent-relative length.
		/// </summary>
		// Token: 0x04004CB1 RID: 19633
		public float Delta;

		/// <summary>
		/// The normalized parent-relative length.
		/// </summary>
		// Token: 0x04004CB2 RID: 19634
		public float Relative;
	}
}
