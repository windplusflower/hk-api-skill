using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Modding.Menu.Components
{
	/// <summary>
	/// A component that scrolls a pane on select
	/// </summary>
	// Token: 0x02000DDB RID: 3547
	public class ScrollPaneSelector : MonoBehaviour, ISelectHandler, IEventSystemHandler
	{
		/// <summary>
		/// The pane that gets moved by the scrollbar.
		/// </summary>
		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06004950 RID: 18768 RVA: 0x0018D07C File Offset: 0x0018B27C
		// (set) Token: 0x06004951 RID: 18769 RVA: 0x0018D084 File Offset: 0x0018B284
		public RectTransform PaneRect { get; set; }

		/// <summary>
		/// The mask that is the visual size for the pane.
		/// </summary>
		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06004952 RID: 18770 RVA: 0x0018D08D File Offset: 0x0018B28D
		// (set) Token: 0x06004953 RID: 18771 RVA: 0x0018D095 File Offset: 0x0018B295
		public RectTransform MaskRect { get; set; }

		/// <summary>
		/// The scrollbar.
		/// </summary>
		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x06004954 RID: 18772 RVA: 0x0018D09E File Offset: 0x0018B29E
		// (set) Token: 0x06004955 RID: 18773 RVA: 0x0018D0A6 File Offset: 0x0018B2A6
		public Scrollbar Scrollbar { get; set; }

		/// <summary>
		/// A function to get padding for the selection scrolling. The returned tuple is `(bottom, top)`.
		/// </summary>
		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x06004956 RID: 18774 RVA: 0x0018D0AF File Offset: 0x0018B2AF
		// (set) Token: 0x06004957 RID: 18775 RVA: 0x0018D0B7 File Offset: 0x0018B2B7
		public Func<RectTransform, ValueTuple<float, float>> SelectionPadding { get; set; }

		/// <summary>
		/// Move the scrollbar to show the selected item.
		/// </summary>
		/// <param name="eventData">The event data.</param>
		// Token: 0x06004958 RID: 18776 RVA: 0x0018D0C0 File Offset: 0x0018B2C0
		public void OnSelect(BaseEventData eventData)
		{
			if (!(eventData is AxisEventData))
			{
				return;
			}
			RectTransform component = base.gameObject.GetComponent<RectTransform>();
			ValueTuple<float, float> valueTuple = this.SelectionPadding(component);
			float item = valueTuple.Item1;
			float item2 = valueTuple.Item2;
			Matrix4x4 matrix4x = this.MaskRect.worldToLocalMatrix * component.localToWorldMatrix;
			float num = matrix4x.MultiplyPoint(new Vector3(0f, component.rect.yMax, 0f)).y + item;
			matrix4x.MultiplyPoint(new Vector3(0f, component.rect.yMin, 0f));
			float num2 = this.PaneRect.anchoredPosition.y + (this.MaskRect.rect.yMax - num) * 2f;
			this.Scrollbar.value = (this.PaneRect.rect.height - this.MaskRect.rect.height) / num2;
		}
	}
}
