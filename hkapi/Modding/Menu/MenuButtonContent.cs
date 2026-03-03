using System;
using GlobalEnums;
using Modding.Menu.Config;
using UnityEngine;
using UnityEngine.UI;

namespace Modding.Menu
{
	/// <summary>
	/// A helper class for creating menu buttons.
	/// </summary>
	// Token: 0x02000DB0 RID: 3504
	public static class MenuButtonContent
	{
		/// <summary>
		/// Creates a menu button.
		/// </summary>
		/// <param name="content">The <c>ContentArea</c> to put the button in.</param>
		/// <param name="name">The name of the button game object.</param>
		/// <param name="config">The configuration options for the menu button.</param>
		/// <returns></returns>
		// Token: 0x0600489A RID: 18586 RVA: 0x0018A4B8 File Offset: 0x001886B8
		public static ContentArea AddMenuButton(this ContentArea content, string name, MenuButtonConfig config)
		{
			MenuButton menuButton;
			return content.AddMenuButton(name, config, out menuButton);
		}

		/// <summary>
		/// Creates a menu button.
		/// </summary>
		/// <param name="content">The <c>ContentArea</c> to put the button in.</param>
		/// <param name="name">The name of the button game object.</param>
		/// <param name="config">The configuration options for the menu button.</param>
		/// <param name="button">The <c>MenuButton</c> component on the created menu button.</param>
		/// <returns></returns>
		// Token: 0x0600489B RID: 18587 RVA: 0x0018A4D0 File Offset: 0x001886D0
		public static ContentArea AddMenuButton(this ContentArea content, string name, MenuButtonConfig config, out MenuButton button)
		{
			MenuButtonStyle menuButtonStyle = config.Style ?? MenuButtonStyle.VanillaStyle;
			GameObject gameObject = new GameObject(name ?? "");
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			gameObject.transform.SetParent(content.ContentObject.transform, false);
			gameObject.AddComponent<CanvasRenderer>();
			RectTransform rt = gameObject.AddComponent<RectTransform>();
			new RelVector2(new RelLength(0f, 1f), menuButtonStyle.Height).GetBaseTransformData().Apply(rt);
			content.Layout.ModifyNext(rt);
			MenuButton menuButton = (MenuButton)gameObject.AddComponent<MenuButton>();
			menuButton.buttonType = MenuButton.MenuButtonType.CustomSubmit;
			menuButton.submitAction = config.SubmitAction;
			menuButton.cancelAction = CancelAction.GoToExtrasMenu;
			menuButton.proceed = config.Proceed;
			((MenuSelectable)menuButton).customCancelAction = config.CancelAction;
			content.NavGraph.AddNavigationNode(menuButton);
			GameObject gameObject2 = new GameObject("Label");
			UnityEngine.Object.DontDestroyOnLoad(gameObject2);
			gameObject2.transform.SetParent(gameObject.transform, false);
			gameObject2.AddComponent<CanvasRenderer>();
			RectTransform rectTransform = gameObject2.AddComponent<RectTransform>();
			rectTransform.sizeDelta = new Vector2(0f, 0f);
			rectTransform.pivot = new Vector2(0.5f, 0.5f);
			rectTransform.anchorMin = new Vector2(0f, 0f);
			rectTransform.anchorMax = new Vector2(1f, 1f);
			rectTransform.anchoredPosition = new Vector2(0f, 0f);
			Text text = gameObject2.AddComponent<Text>();
			text.font = MenuResources.TrajanBold;
			text.fontSize = menuButtonStyle.TextSize;
			text.resizeTextMaxSize = menuButtonStyle.TextSize;
			text.alignment = TextAnchor.MiddleCenter;
			text.text = config.Label;
			text.supportRichText = true;
			text.verticalOverflow = VerticalWrapMode.Overflow;
			text.horizontalOverflow = HorizontalWrapMode.Overflow;
			gameObject2.AddComponent<FixVerticalAlign>();
			gameObject2.AddComponent<ContentSizeFitter>().horizontalFit = ContentSizeFitter.FitMode.PreferredSize;
			GameObject gameObject3 = new GameObject("CursorLeft");
			UnityEngine.Object.DontDestroyOnLoad(gameObject3);
			gameObject3.transform.SetParent(gameObject2.transform, false);
			gameObject3.AddComponent<CanvasRenderer>();
			RectTransform rectTransform2 = gameObject3.AddComponent<RectTransform>();
			rectTransform2.sizeDelta = new Vector2(164f, 119f);
			rectTransform2.pivot = new Vector2(0.5f, 0.5f);
			rectTransform2.anchorMin = new Vector2(0f, 0.5f);
			rectTransform2.anchorMax = new Vector2(0f, 0.5f);
			rectTransform2.anchoredPosition = new Vector2(-65f, 0f);
			rectTransform2.localScale = new Vector3(0.4f, 0.4f, 0.4f);
			Animator animator = gameObject3.AddComponent<Animator>();
			animator.runtimeAnimatorController = MenuResources.MenuCursorAnimator;
			animator.updateMode = AnimatorUpdateMode.UnscaledTime;
			animator.applyRootMotion = false;
			gameObject3.AddComponent<Image>();
			menuButton.leftCursor = animator;
			GameObject gameObject4 = new GameObject("CursorRight");
			UnityEngine.Object.DontDestroyOnLoad(gameObject4);
			gameObject4.transform.SetParent(gameObject2.transform, false);
			gameObject4.AddComponent<CanvasRenderer>();
			RectTransform rectTransform3 = gameObject4.AddComponent<RectTransform>();
			rectTransform3.sizeDelta = new Vector2(164f, 119f);
			rectTransform3.pivot = new Vector2(0.5f, 0.5f);
			rectTransform3.anchorMin = new Vector2(1f, 0.5f);
			rectTransform3.anchorMax = new Vector2(1f, 0.5f);
			rectTransform3.anchoredPosition = new Vector2(65f, 0f);
			rectTransform3.localScale = new Vector3(-0.4f, 0.4f, 0.4f);
			Animator animator2 = gameObject4.AddComponent<Animator>();
			animator2.runtimeAnimatorController = MenuResources.MenuCursorAnimator;
			animator2.updateMode = AnimatorUpdateMode.UnscaledTime;
			animator2.applyRootMotion = false;
			gameObject4.AddComponent<Image>();
			menuButton.rightCursor = animator2;
			GameObject gameObject5 = new GameObject("FlashEffect");
			UnityEngine.Object.DontDestroyOnLoad(gameObject5);
			gameObject5.transform.SetParent(gameObject2.transform, false);
			gameObject5.AddComponent<CanvasRenderer>();
			RectTransform rectTransform4 = gameObject5.AddComponent<RectTransform>();
			rectTransform4.sizeDelta = new Vector2(0f, 0f);
			rectTransform4.anchorMin = new Vector2(0f, 0f);
			rectTransform4.anchorMax = new Vector2(1f, 1f);
			rectTransform4.anchoredPosition = new Vector2(0f, 0f);
			rectTransform4.pivot = new Vector2(0.5f, 0.5f);
			gameObject5.AddComponent<Image>();
			Animator animator3 = gameObject5.AddComponent<Animator>();
			animator3.runtimeAnimatorController = MenuResources.MenuButtonFlashAnimator;
			animator3.updateMode = AnimatorUpdateMode.UnscaledTime;
			animator3.applyRootMotion = false;
			menuButton.flashEffect = animator3;
			DescriptionInfo? description = config.Description;
			if (description != null)
			{
				DescriptionInfo valueOrDefault = description.GetValueOrDefault();
				DescriptionStyle descriptionStyle = valueOrDefault.Style ?? DescriptionStyle.MenuButtonSingleLineVanillaStyle;
				GameObject gameObject6 = new GameObject("Description");
				UnityEngine.Object.DontDestroyOnLoad(gameObject6);
				gameObject6.transform.SetParent(gameObject.transform, false);
				gameObject6.AddComponent<CanvasRenderer>();
				RectTransform rt2 = gameObject6.AddComponent<RectTransform>();
				RectTransformData.FromSizeAndPos(descriptionStyle.Size, new AnchoredPosition(new Vector2(0.5f, 0f), new Vector2(0.5f, 1f), default(Vector2))).Apply(rt2);
				Animator animator4 = gameObject6.AddComponent<Animator>();
				animator4.runtimeAnimatorController = MenuResources.TextHideShowAnimator;
				animator4.updateMode = AnimatorUpdateMode.UnscaledTime;
				animator4.applyRootMotion = false;
				Text text2 = gameObject6.AddComponent<Text>();
				text2.font = MenuResources.Perpetua;
				text2.fontSize = descriptionStyle.TextSize;
				text2.resizeTextMaxSize = descriptionStyle.TextSize;
				text2.alignment = descriptionStyle.TextAnchor;
				text2.text = valueOrDefault.Text;
				text2.supportRichText = true;
				text2.verticalOverflow = VerticalWrapMode.Overflow;
				text2.horizontalOverflow = HorizontalWrapMode.Wrap;
				menuButton.descriptionText = animator4;
			}
			button = menuButton;
			return content;
		}
	}
}
