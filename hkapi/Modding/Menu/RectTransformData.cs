using System;
using UnityEngine;

namespace Modding.Menu
{
	/// <summary>
	/// A struct to represent the data in a <c>RectTransform</c>.
	/// </summary>
	// Token: 0x02000DBE RID: 3518
	public struct RectTransformData
	{
		/// <summary>
		/// Creates a <c>RectTransformData</c> from an existing <c>RectTransform</c>.
		/// </summary>
		/// <param name="rt">The source <c>RectTransform</c>.</param>
		/// <returns></returns>
		// Token: 0x060048E5 RID: 18661 RVA: 0x0018BA4E File Offset: 0x00189C4E
		public RectTransformData(RectTransform rt)
		{
			this.sizeDelta = rt.sizeDelta;
			this.anchorMin = rt.anchorMin;
			this.anchorMax = rt.anchorMax;
			this.anchoredPosition = rt.anchoredPosition;
			this.pivot = rt.pivot;
		}

		/// <summary>
		/// Create a <c>RectTransformData</c> from a <c>RectSize</c> and <c>RectPosition</c>.
		/// </summary>
		/// <param name="size">The size parent-relative</param>
		/// <param name="pos">The anchored position</param>
		/// <returns></returns>
		// Token: 0x060048E6 RID: 18662 RVA: 0x0018BA8C File Offset: 0x00189C8C
		public static RectTransformData FromSizeAndPos(RelVector2 size, AnchoredPosition pos)
		{
			return pos.GetRepositioned(size.GetBaseTransformData());
		}

		/// <summary>
		/// Apply the data to an existing <c>RectTransform</c>.
		/// </summary>
		/// <param name="rt">The <c>RectTransform</c> to apply the data to.</param>
		// Token: 0x060048E7 RID: 18663 RVA: 0x0018BA9C File Offset: 0x00189C9C
		public void Apply(RectTransform rt)
		{
			rt.sizeDelta = this.sizeDelta;
			rt.anchorMin = this.anchorMin;
			rt.anchorMax = this.anchorMax;
			rt.anchoredPosition = this.anchoredPosition;
			rt.pivot = this.pivot;
		}

		/// <summary>
		/// Add a <c>RectTransform</c> to a game object based on the data in this struct.
		/// </summary>
		/// <param name="obj">The game object to add the <c>RectTransform</c> to</param>
		/// <returns></returns>
		// Token: 0x060048E8 RID: 18664 RVA: 0x0018BADC File Offset: 0x00189CDC
		public RectTransform AddRectTransform(GameObject obj)
		{
			RectTransform rectTransform = obj.AddComponent<RectTransform>();
			this.Apply(rectTransform);
			return rectTransform;
		}

		/// <summary>
		/// Convenience conversion to get the data from a <c>RectTransform</c>.
		/// </summary>
		// Token: 0x060048E9 RID: 18665 RVA: 0x0018BAF8 File Offset: 0x00189CF8
		public static implicit operator RectTransformData(RectTransform r)
		{
			return new RectTransformData(r);
		}

		/// <summary>
		/// Convert from the <c>RectData</c> struct that CanvasUtil uses.
		/// </summary>
		// Token: 0x060048EA RID: 18666 RVA: 0x0018BB00 File Offset: 0x00189D00
		public static implicit operator RectTransformData(CanvasUtil.RectData r)
		{
			return new RectTransformData
			{
				sizeDelta = r.RectSizeDelta,
				anchorMin = r.AnchorMin,
				anchorMax = r.AnchorMax,
				anchoredPosition = r.AnchorPosition,
				pivot = r.AnchorPivot
			};
		}

		/// <summary>
		/// Convert to the <c>RectData</c> struct that CanvasUtil uses.
		/// </summary>
		// Token: 0x060048EB RID: 18667 RVA: 0x0018BB57 File Offset: 0x00189D57
		public static implicit operator CanvasUtil.RectData(RectTransformData r)
		{
			return new CanvasUtil.RectData(r.sizeDelta, r.anchoredPosition, r.anchorMin, r.anchorMax, r.pivot);
		}

		/// <summary>
		/// See <c>RectTransform.sizeDelta</c> in the unity docs.
		/// </summary>
		// Token: 0x04004CB3 RID: 19635
		public Vector2 sizeDelta;

		/// <summary>
		/// See <c>RectTransform.anchorMin</c> in the unity docs.
		/// </summary>
		// Token: 0x04004CB4 RID: 19636
		public Vector2 anchorMin;

		/// <summary>
		/// See <c>RectTransform.anchorMax</c> in the unity docs.
		/// </summary>
		// Token: 0x04004CB5 RID: 19637
		public Vector2 anchorMax;

		/// <summary>
		/// See <c>RectTransform.anchoredPosition</c> in the unity docs.
		/// </summary>
		// Token: 0x04004CB6 RID: 19638
		public Vector2 anchoredPosition;

		/// <summary>
		/// See <c>RectTransform.pivot</c> in the unity docs.
		/// </summary>
		// Token: 0x04004CB7 RID: 19639
		public Vector2 pivot;
	}
}
