using System;
using UnityEngine;

namespace Modding.Menu
{
	/// <summary>
	/// A layout that does absolutely nothing.
	/// </summary>
	// Token: 0x02000DB7 RID: 3511
	public struct NullContentLayout : IContentLayout
	{
		/// <inheritdoc />
		// Token: 0x060048B1 RID: 18609 RVA: 0x00003603 File Offset: 0x00001803
		public void ModifyNext(RectTransform rt)
		{
		}
	}
}
