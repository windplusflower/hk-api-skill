using System;
using Modding.Menu.Components;
using Modding.Menu.Config;
using UnityEngine;
using UnityEngine.UI;

namespace Modding.Menu
{
	/// <summary>
	/// A builder style class for creating in-game menus.
	/// </summary>
	// Token: 0x02000DBF RID: 3519
	public class MenuBuilder
	{
		/// <summary>
		/// The root game object of the menu.
		/// </summary>
		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x060048EC RID: 18668 RVA: 0x0018BB7C File Offset: 0x00189D7C
		// (set) Token: 0x060048ED RID: 18669 RVA: 0x0018BB84 File Offset: 0x00189D84
		public GameObject MenuObject { get; set; }

		/// <summary>
		/// The <c>MenuScreen</c> component on <c>menuObject</c>.
		/// </summary>
		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x060048EE RID: 18670 RVA: 0x0018BB8D File Offset: 0x00189D8D
		// (set) Token: 0x060048EF RID: 18671 RVA: 0x0018BB95 File Offset: 0x00189D95
		public MenuScreen Screen { get; set; }

		/// <summary>
		/// The current default navigation graph that gets used for <c>AddContent</c> and <c>AddControls</c> calls.
		/// </summary>
		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x060048F0 RID: 18672 RVA: 0x0018BB9E File Offset: 0x00189D9E
		// (set) Token: 0x060048F1 RID: 18673 RVA: 0x0018BBA6 File Offset: 0x00189DA6
		public INavigationGraph DefaultNavGraph { get; private set; } = default(NullNavigationGraph);

		/// <summary>
		/// An event that gets called at the start of <c>Build</c>.
		/// </summary>
		// Token: 0x140000A9 RID: 169
		// (add) Token: 0x060048F2 RID: 18674 RVA: 0x0018BBB0 File Offset: 0x00189DB0
		// (remove) Token: 0x060048F3 RID: 18675 RVA: 0x0018BBE8 File Offset: 0x00189DE8
		public event Action<MenuBuilder> OnBuild;

		/// <summary>
		/// Creates a new <c>MenuBuilder</c> on the UIManager instance canvas.
		/// </summary>
		/// <param name="name">The name of the root menu.</param>
		// Token: 0x060048F4 RID: 18676 RVA: 0x0018BC1D File Offset: 0x00189E1D
		public MenuBuilder(string name) : this(UIManager.instance.UICanvas.gameObject, name)
		{
		}

		/// <summary>
		/// Creates a new <c>MenuBuilder</c> on a canvas.
		/// </summary>
		/// <param name="canvas">The canvas to make the root menu on.</param>
		/// <param name="name">The name of the root menu.</param>
		// Token: 0x060048F5 RID: 18677 RVA: 0x0018BC38 File Offset: 0x00189E38
		public MenuBuilder(GameObject canvas, string name)
		{
			this.MenuObject = new GameObject(name);
			UnityEngine.Object.DontDestroyOnLoad(this.MenuObject);
			this.MenuObject.transform.SetParent(canvas.transform, false);
			this.MenuObject.SetActive(false);
			this.Screen = this.MenuObject.AddComponent<MenuScreen>();
			this.MenuObject.AddComponent<CanvasRenderer>();
			RectTransform rectTransform = this.MenuObject.AddComponent<RectTransform>();
			rectTransform.sizeDelta = new Vector2(0f, 463f);
			rectTransform.pivot = new Vector2(0.5f, 0.5f);
			rectTransform.anchorMin = new Vector2(0f, 0f);
			rectTransform.anchorMax = new Vector2(1f, 1f);
			rectTransform.anchoredPosition = new Vector2(0f, 0f);
			rectTransform.localScale = new Vector3(0.7f, 0.7f, 1f);
			this.MenuObject.AddComponent<CanvasGroup>();
		}

		/// <summary>
		/// Builds the menu, calling any <c>OnBuild</c> events and returning the screen.
		/// </summary>
		/// <returns></returns>
		// Token: 0x060048F6 RID: 18678 RVA: 0x0018BD50 File Offset: 0x00189F50
		public MenuScreen Build()
		{
			Action<MenuBuilder> onBuild = this.OnBuild;
			if (onBuild != null)
			{
				onBuild(this);
			}
			INavigationGraph defaultNavGraph = this.DefaultNavGraph;
			Selectable selectable = (defaultNavGraph != null) ? defaultNavGraph.BuildNavigation() : null;
			if (selectable != null)
			{
				this.MenuObject.AddComponent<AutoSelector>().Start = selectable;
			}
			return this.Screen;
		}

		/// <summary>
		/// Adds "content" to the menu in a certain layout. <br />
		/// If <c>CreateContentPane</c> has not been called yet, this method will immeddiately return.
		/// </summary>
		/// <param name="layout">The layout of the added content</param>
		/// <param name="navgraph">The navigation graph to place the selectables in.</param>
		/// <param name="action">The action that will get called to add the content</param>
		/// <returns></returns>
		// Token: 0x060048F7 RID: 18679 RVA: 0x0018BD9C File Offset: 0x00189F9C
		public MenuBuilder AddContent(IContentLayout layout, INavigationGraph navgraph, Action<ContentArea> action)
		{
			if (this.Screen.content == null)
			{
				return this;
			}
			action(new ContentArea(this.Screen.content.gameObject, layout, navgraph));
			return this;
		}

		/// <summary>
		/// Adds "content" to the menu in a certain layout with the default navigation graph.<br />
		/// If <c>CreateContentPane</c> has not been called yet, this method will immeddiately return.
		/// </summary>
		/// <param name="layout">The layout of the added content</param>
		/// <param name="action">The action that will get called to add the content</param>
		/// <returns></returns>
		// Token: 0x060048F8 RID: 18680 RVA: 0x0018BDD1 File Offset: 0x00189FD1
		public MenuBuilder AddContent(IContentLayout layout, Action<ContentArea> action)
		{
			return this.AddContent(layout, this.DefaultNavGraph, action);
		}

		/// <summary>
		/// Adds "content" to the control pane in a certain layout.<br />
		/// If <c>CreateControlPane</c> has not been called yet, this method will immeddiately return.
		/// </summary>
		/// <param name="layout">The layout to apply to the added content.</param>
		/// <param name="navgraph">The navigation graph to place the selectables in.</param>
		/// <param name="action">The action that will get called to add the content.</param>
		/// <returns></returns>
		// Token: 0x060048F9 RID: 18681 RVA: 0x0018BDE1 File Offset: 0x00189FE1
		public MenuBuilder AddControls(IContentLayout layout, INavigationGraph navgraph, Action<ContentArea> action)
		{
			if (this.Screen.controls == null)
			{
				return this;
			}
			action(new ContentArea(this.Screen.controls.gameObject, layout, navgraph));
			return this;
		}

		/// <summary>
		/// Adds "content" to the control pane in a certain layout with the default navigation graph.<br />
		/// If <c>CreateControlPane</c> has not been called yet, this method will immeddiately return.
		/// </summary>
		/// <param name="layout">The layout to apply to the added content.</param>
		/// <param name="action">The action that will get called to add the content.</param>
		/// <returns></returns>
		// Token: 0x060048FA RID: 18682 RVA: 0x0018BE16 File Offset: 0x0018A016
		public MenuBuilder AddControls(IContentLayout layout, Action<ContentArea> action)
		{
			return this.AddControls(layout, this.DefaultNavGraph, action);
		}

		/// <summary>
		/// Adds a title and top fleur to the menu.
		/// </summary>
		/// <param name="title">The title to render on the menu.</param>
		/// <param name="style">The styling of the title.</param>
		/// <returns></returns>
		// Token: 0x060048FB RID: 18683 RVA: 0x0018BE28 File Offset: 0x0018A028
		public MenuBuilder CreateTitle(string title, MenuTitleStyle style)
		{
			GameObject gameObject = new GameObject("Title");
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			gameObject.transform.SetParent(this.MenuObject.transform, false);
			gameObject.AddComponent<CanvasRenderer>();
			RectTransform rectTransform = gameObject.AddComponent<RectTransform>();
			rectTransform.sizeDelta = new Vector2(0f, 107f);
			rectTransform.anchorMin = new Vector2(0f, 0.5f);
			rectTransform.anchorMax = new Vector2(1f, 0.5f);
			style.Pos.Reposition(rectTransform);
			this.Screen.title = gameObject.AddComponent<CanvasGroup>();
			gameObject.AddComponent<ZeroAlphaOnStart>();
			Text text = gameObject.AddComponent<Text>();
			text.font = MenuResources.TrajanBold;
			text.fontSize = style.TextSize;
			text.resizeTextMaxSize = style.TextSize;
			text.alignment = TextAnchor.MiddleCenter;
			text.text = title;
			text.supportRichText = true;
			text.verticalOverflow = VerticalWrapMode.Overflow;
			text.horizontalOverflow = HorizontalWrapMode.Overflow;
			GameObject gameObject2 = new GameObject("TopFleur");
			UnityEngine.Object.DontDestroyOnLoad(gameObject2);
			gameObject2.transform.SetParent(this.MenuObject.transform, false);
			gameObject2.AddComponent<CanvasRenderer>();
			RectTransform rectTransform2 = gameObject2.AddComponent<RectTransform>();
			rectTransform2.sizeDelta = new Vector2(1087f, 98f);
			AnchoredPosition.FromSiblingAnchor(new Vector2(0.5f, 0.5f), rectTransform, new Vector2(0.5f, 0.5f), new Vector2(0f, -102.5f)).Reposition(rectTransform2);
			Animator animator = gameObject2.AddComponent<Animator>();
			animator.runtimeAnimatorController = MenuResources.MenuTopFleurAnimator;
			animator.updateMode = AnimatorUpdateMode.UnscaledTime;
			animator.applyRootMotion = false;
			this.Screen.topFleur = animator;
			gameObject2.AddComponent<Image>();
			return this;
		}

		/// <summary>
		/// Creates the content canvas group to hold the majority of items in the menu.
		/// </summary>
		/// <param name="style">The rect describing the size and position of the content pane.</param>
		/// <returns></returns>
		// Token: 0x060048FC RID: 18684 RVA: 0x0018BFDC File Offset: 0x0018A1DC
		public MenuBuilder CreateContentPane(RectTransformData style)
		{
			GameObject gameObject = new GameObject("Content");
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			gameObject.transform.SetParent(this.MenuObject.transform, false);
			style.Apply(gameObject.AddComponent<RectTransform>());
			this.Screen.content = gameObject.AddComponent<CanvasGroup>();
			gameObject.AddComponent<CanvasRenderer>();
			gameObject.AddComponent<ZeroAlphaOnStart>();
			return this;
		}

		/// <summary>
		/// Creates the control canvas group to hold the buttons at the bottom of the menu.
		/// </summary>
		/// <param name="style">The rect describing the size and position of the control pane.</param>
		/// <returns></returns>
		// Token: 0x060048FD RID: 18685 RVA: 0x0018C040 File Offset: 0x0018A240
		public MenuBuilder CreateControlPane(RectTransformData style)
		{
			GameObject gameObject = new GameObject("Control");
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			gameObject.transform.SetParent(this.MenuObject.transform, false);
			style.Apply(gameObject.AddComponent<RectTransform>());
			this.Screen.controls = gameObject.AddComponent<CanvasGroup>();
			gameObject.AddComponent<CanvasRenderer>();
			gameObject.AddComponent<ZeroAlphaOnStart>();
			return this;
		}

		/// <summary>
		/// Sets the default navigation graph to use for <c>AddContent</c> and <c>AddControls</c> calls.
		/// </summary>
		/// <param name="navGraph">The default navigation graph to set.</param>
		/// <returns></returns>
		// Token: 0x060048FE RID: 18686 RVA: 0x0018C0A4 File Offset: 0x0018A2A4
		public MenuBuilder SetDefaultNavGraph(INavigationGraph navGraph)
		{
			this.DefaultNavGraph = (navGraph ?? default(NullNavigationGraph));
			return this;
		}
	}
}
