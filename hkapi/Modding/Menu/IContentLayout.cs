using System;
using UnityEngine;

namespace Modding.Menu
{
	/// <summary>
	/// An interface to place successive <c>RectTransform</c>s.
	/// </summary>
	// Token: 0x02000DB6 RID: 3510
	public interface IContentLayout
	{
		/// <summary>
		/// Modifies a <c>RectTransform</c>.
		/// </summary>
		/// <param name="rt">The <c>RectTransform</c> to modify.</param>
		// Token: 0x060048B0 RID: 18608
		void ModifyNext(RectTransform rt);
	}
}
