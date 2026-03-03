using System;
using GlobalEnums;
using Modding.Menu.Components;
using Modding.Menu.Config;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Modding.Menu
{
	/// <summary>
	/// A helper class for creating scrollbars and their associated content panes.
	/// </summary>
	// Token: 0x02000DB1 RID: 3505
	public static class ScrollPaneContent
	{
		/// <summary>
		/// Creates a scrollable window.<br />
		/// The scrolling content will be the same width as the parent.
		/// </summary>
		/// <param name="content">The <c>ContentArea</c> to put the scrollable window in.</param>
		/// <param name="config">The configuration options for the scrollbar.</param>
		/// <param name="contentHeight">The height of the scroll window.</param>
		/// <param name="layout">The layout to apply to the added content.</param>
		/// <param name="action">The action that will get called to add the content.</param>
		/// <returns></returns>
		// Token: 0x0600489C RID: 18588 RVA: 0x0018AA94 File Offset: 0x00188C94
		public static ContentArea AddScrollPaneContent(this ContentArea content, ScrollbarConfig config, RelLength contentHeight, IContentLayout layout, Action<ContentArea> action)
		{
			GameObject gameObject;
			Scrollbar scrollbar;
			return content.AddScrollPaneContent(config, contentHeight, layout, action, out gameObject, out scrollbar);
		}

		/// <summary>
		/// Creates a scrollable window.<br />
		/// The scrolling content will be the same width as the parent.
		/// </summary>
		/// <param name="content">The <c>ContentArea</c> to put the scrollable window in.</param>
		/// <param name="config">The configuration options for the scrollbar.</param>
		/// <param name="contentHeight">The height of the scroll window.</param>
		/// <param name="layout">The layout to apply to the added content.</param>
		/// <param name="action">The action that will get called to add the content.</param>
		/// <param name="scrollContent">The created scrollable window game object.</param>
		/// <param name="scroll">The <c>Scrollbar</c> component on the created scrollbar.</param>
		/// <returns></returns>
		// Token: 0x0600489D RID: 18589 RVA: 0x0018AAB0 File Offset: 0x00188CB0
		public static ContentArea AddScrollPaneContent(this ContentArea content, ScrollbarConfig config, RelLength contentHeight, IContentLayout layout, Action<ContentArea> action, out GameObject scrollContent, out Scrollbar scroll)
		{
			GameObject gameObject = new GameObject("ScrollMask");
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			gameObject.transform.SetParent(content.ContentObject.transform, false);
			RectTransform scrollMaskRt = gameObject.AddComponent<RectTransform>();
			scrollMaskRt.sizeDelta = new Vector2(0f, 0f);
			scrollMaskRt.pivot = new Vector2(0.5f, 0.5f);
			scrollMaskRt.anchorMin = new Vector2(0f, 0f);
			scrollMaskRt.anchorMax = new Vector2(1f, 1f);
			scrollMaskRt.anchoredPosition = new Vector2(0f, 0f);
			gameObject.AddComponent<CanvasRenderer>();
			gameObject.AddComponent<Mask>().showMaskGraphic = false;
			gameObject.AddComponent<Image>().raycastTarget = true;
			GameObject gameObject2 = new GameObject("ScrollingPane");
			UnityEngine.Object.DontDestroyOnLoad(gameObject2);
			gameObject2.transform.SetParent(gameObject.transform, false);
			RectTransform scrollPaneRt = gameObject2.AddComponent<RectTransform>();
			RectTransformData.FromSizeAndPos(new RelVector2(new RelLength(0f, 1f), contentHeight), new AnchoredPosition(new Vector2(0.5f, 1f), new Vector2(0.5f, 1f), default(Vector2))).Apply(scrollPaneRt);
			content.AddScrollbar(config, out scroll);
			ScrollRect scrollRect = gameObject.AddComponent<ScrollRect>();
			scrollRect.viewport = scrollMaskRt;
			scrollRect.content = scrollPaneRt;
			scrollRect.scrollSensitivity = 20f;
			scrollRect.horizontal = false;
			scrollRect.movementType = ScrollRect.MovementType.Clamped;
			scrollRect.verticalScrollbar = scroll;
			scrollRect.verticalScrollbarVisibility = ScrollRect.ScrollbarVisibility.AutoHideAndExpandViewport;
			gameObject2.AddComponent<CanvasRenderer>();
			GameObject obj = gameObject2;
			ScrollPaneContent.ScrollMovingNavGraph scrollMovingNavGraph = default(ScrollPaneContent.ScrollMovingNavGraph);
			scrollMovingNavGraph.Inner = content.NavGraph;
			scrollMovingNavGraph.Scrollbar = scroll;
			scrollMovingNavGraph.ScrollPaneTransform = scrollPaneRt;
			Func<RectTransform, ValueTuple<float, float>> selectionPadding;
			if ((selectionPadding = config.SelectionPadding) == null && (selectionPadding = ScrollPaneContent.<>c.<>9__1_1) == null)
			{
				selectionPadding = (ScrollPaneContent.<>c.<>9__1_1 = ((RectTransform _) => new ValueTuple<float, float>(-120f, 120f)));
			}
			scrollMovingNavGraph.SelectionPadding = selectionPadding;
			action(new ContentArea(obj, layout, scrollMovingNavGraph));
			scroll.onValueChanged = ScrollPaneContent.CreateScrollEvent(delegate(float f)
			{
				scrollPaneRt.anchoredPosition = new Vector2(0f, Mathf.Max(0f, (scrollPaneRt.sizeDelta.y - scrollMaskRt.rect.height) * f));
			});
			scrollContent = gameObject;
			return content;
		}

		/// <summary>
		/// Creates a scrollbar.
		/// </summary>
		/// <param name="content">The <c>ContentArea</c> to put the scrollbar in.</param>
		/// <param name="config">The configuration options for the scrollbar.</param>
		/// <param name="scroll">The <c>Scrollbar</c> component on the created scrollbar.</param>
		/// <returns></returns>
		// Token: 0x0600489E RID: 18590 RVA: 0x0018AD04 File Offset: 0x00188F04
		public static ContentArea AddScrollbar(this ContentArea content, ScrollbarConfig config, out Scrollbar scroll)
		{
			GameObject gameObject = new GameObject("Scrollbar");
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			gameObject.transform.SetParent(content.ContentObject.transform, false);
			RectTransform rectTransform = gameObject.AddComponent<RectTransform>();
			rectTransform.sizeDelta = new Vector2(38f, 906f);
			config.Position.Reposition(rectTransform);
			gameObject.AddComponent<CanvasRenderer>();
			Scrollbar scrollbar = gameObject.AddComponent<Scrollbar>();
			scrollbar.direction = Scrollbar.Direction.BottomToTop;
			scrollbar.numberOfSteps = 0;
			scrollbar.navigation = config.Navigation;
			scrollbar.size = 0.1f;
			MenuPreventDeselect menuPreventDeselect = gameObject.AddComponent<MenuPreventDeselect>();
			menuPreventDeselect.cancelAction = CancelAction.GoToExtrasMenu;
			((MenuPreventDeselect)menuPreventDeselect).customCancelAction = config.CancelAction;
			GameObject gameObject2 = new GameObject("Sliding Area");
			UnityEngine.Object.DontDestroyOnLoad(gameObject2);
			gameObject2.transform.SetParent(gameObject.transform, false);
			RectTransform rectTransform2 = gameObject2.AddComponent<RectTransform>();
			rectTransform2.sizeDelta = new Vector2(-20f, -20f);
			rectTransform2.pivot = new Vector2(0.5f, 0f);
			rectTransform2.anchorMin = new Vector2(0f, 0f);
			rectTransform2.anchorMax = new Vector2(1f, 1f);
			rectTransform2.anchoredPosition = new Vector2(0f, 0f);
			GameObject gameObject3 = new GameObject("Handle");
			UnityEngine.Object.DontDestroyOnLoad(gameObject3);
			gameObject3.transform.SetParent(gameObject2.transform, false);
			RectTransform rectTransform3 = gameObject3.AddComponent<RectTransform>();
			rectTransform3.sizeDelta = new Vector2(76f, 0f);
			rectTransform3.pivot = new Vector2(0.5f, 0.5f);
			rectTransform3.anchorMin = new Vector2(0f, 0f);
			rectTransform3.anchorMax = new Vector2(1f, 1f);
			rectTransform3.anchoredPosition = new Vector2(-1f, 0f);
			gameObject3.AddComponent<CanvasRenderer>();
			scrollbar.handleRect = rectTransform3;
			GameObject gameObject4 = new GameObject("TopFleur");
			UnityEngine.Object.DontDestroyOnLoad(gameObject4);
			gameObject4.transform.SetParent(gameObject3.transform, false);
			RectTransform rectTransform4 = gameObject4.AddComponent<RectTransform>();
			rectTransform4.sizeDelta = new Vector2(37.8f, 68.5f);
			rectTransform4.pivot = new Vector2(0.5f, 0.8f);
			rectTransform4.anchorMin = new Vector2(0.5f, 1f);
			rectTransform4.anchorMax = new Vector2(0.5f, 1f);
			rectTransform4.anchoredPosition = new Vector2(0.8f, 0f);
			rectTransform4.localScale = new Vector3(2f, 2f, 1f);
			gameObject4.AddComponent<CanvasRenderer>();
			gameObject4.AddComponent<Image>().sprite = MenuResources.ScrollbarHandleSprite;
			gameObject4.AddComponent<ScrollBarHandle>().scrollBar = scrollbar;
			GameObject gameObject5 = new GameObject("Background");
			UnityEngine.Object.DontDestroyOnLoad(gameObject5);
			gameObject5.transform.SetParent(gameObject.transform, false);
			RectTransform rectTransform5 = gameObject5.AddComponent<RectTransform>();
			rectTransform5.sizeDelta = new Vector2(5f, 906f);
			rectTransform5.pivot = new Vector2(0.5f, 0.5f);
			rectTransform5.anchorMin = new Vector2(0.5f, 0.5f);
			rectTransform5.anchorMax = new Vector2(0.5f, 0.5f);
			rectTransform5.anchoredPosition = new Vector2(0f, 0f);
			gameObject5.AddComponent<CanvasRenderer>();
			gameObject5.AddComponent<Image>().sprite = MenuResources.ScrollbarBackgroundSprite;
			scroll = scrollbar;
			return content;
		}

		// Token: 0x0600489F RID: 18591 RVA: 0x0018B068 File Offset: 0x00189268
		private static Scrollbar.ScrollEvent CreateScrollEvent(Action<float> action)
		{
			Scrollbar.ScrollEvent scrollEvent = new Scrollbar.ScrollEvent();
			scrollEvent.AddListener(new UnityAction<float>(action.Invoke));
			return scrollEvent;
		}

		// Token: 0x02000DB2 RID: 3506
		private struct ScrollMovingNavGraph : INavigationGraph
		{
			// Token: 0x1700075C RID: 1884
			// (get) Token: 0x060048A0 RID: 18592 RVA: 0x0018B081 File Offset: 0x00189281
			// (set) Token: 0x060048A1 RID: 18593 RVA: 0x0018B089 File Offset: 0x00189289
			public Func<RectTransform, ValueTuple<float, float>> SelectionPadding { readonly get; set; }

			// Token: 0x060048A2 RID: 18594 RVA: 0x0018B094 File Offset: 0x00189294
			public void AddNavigationNode(Selectable selectable)
			{
				ScrollPaneSelector scrollPaneSelector = selectable.gameObject.GetComponent<ScrollPaneSelector>();
				if (scrollPaneSelector == null)
				{
					scrollPaneSelector = selectable.gameObject.AddComponent<ScrollPaneSelector>();
				}
				scrollPaneSelector.Scrollbar = this.Scrollbar;
				scrollPaneSelector.PaneRect = this.ScrollPaneTransform;
				scrollPaneSelector.MaskRect = (RectTransform)this.ScrollPaneTransform.parent;
				scrollPaneSelector.SelectionPadding = this.SelectionPadding;
				this.Inner.AddNavigationNode(selectable);
			}

			// Token: 0x060048A3 RID: 18595 RVA: 0x0018B108 File Offset: 0x00189308
			public Selectable BuildNavigation()
			{
				return this.Inner.BuildNavigation();
			}

			// Token: 0x04004C9E RID: 19614
			public INavigationGraph Inner;

			// Token: 0x04004C9F RID: 19615
			public RectTransform ScrollPaneTransform;

			// Token: 0x04004CA0 RID: 19616
			public Scrollbar Scrollbar;
		}
	}
}
