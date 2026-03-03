using System;
using System.Collections.Generic;
using UnityEngine;

namespace Modding.Menu
{
	/// <summary>
	/// A layout based on an enumerator to get successive <c>RectPosition</c>s.
	/// </summary>
	// Token: 0x02000DB9 RID: 3513
	public class EnumeratorLayout : IContentLayout
	{
		/// <summary>
		/// Creates a layout from an <c>IEnumerable</c>.
		/// </summary>
		/// <param name="src">The emumerable object.</param>
		// Token: 0x060048BF RID: 18623 RVA: 0x0018B5D2 File Offset: 0x001897D2
		public EnumeratorLayout(IEnumerable<AnchoredPosition> src)
		{
			this.generator = src.GetEnumerator();
		}

		/// <summary>
		/// Creates a layout from an <c>IEnumerator</c>.
		/// </summary>
		/// <param name="generator">The enumerator.</param>
		// Token: 0x060048C0 RID: 18624 RVA: 0x0018B5E6 File Offset: 0x001897E6
		public EnumeratorLayout(IEnumerator<AnchoredPosition> generator)
		{
			this.generator = generator;
		}

		/// <summary>
		/// Modifies a <c>RectTransform</c> to place it based on the next item of the enumerator.
		/// </summary>
		/// <param name="rt">The <c>RectTransform</c> to modify.</param>
		// Token: 0x060048C1 RID: 18625 RVA: 0x0018B5F8 File Offset: 0x001897F8
		public void ModifyNext(RectTransform rt)
		{
			if (this.generator.MoveNext())
			{
				AnchoredPosition anchoredPosition = this.generator.Current;
				anchoredPosition.Reposition(rt);
			}
		}

		// Token: 0x04004CAA RID: 19626
		private IEnumerator<AnchoredPosition> generator;
	}
}
