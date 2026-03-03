using System;
using GlobalEnums;
using InControl;
using Modding.Menu.Config;
using UnityEngine;
using UnityEngine.UI;

namespace Modding.Menu
{
	/// <summary>
	/// A helper class for creating keybind mapping buttons.
	/// </summary>
	// Token: 0x02000DAD RID: 3501
	public static class KeybindContent
	{
		/// <summary>
		/// Creates a keybind menu item.
		/// </summary>
		/// <param name="content">The <c>ContentArea</c> to put the keybind item in.</param>
		/// <param name="name">The name of the keybind game object.</param>
		/// <param name="action">The <c>PlayerAction</c> to associate with this keybind.</param>
		/// <param name="config">The configuration options for the keybind item.</param>
		/// <returns></returns>
		// Token: 0x06004893 RID: 18579 RVA: 0x00189924 File Offset: 0x00187B24
		public static ContentArea AddKeybind(this ContentArea content, string name, PlayerAction action, KeybindConfig config)
		{
			MappableKey mappableKey;
			return content.AddKeybind(name, action, config, out mappableKey);
		}

		/// <summary>
		/// Creates a keybind menu item.
		/// </summary>
		/// <param name="content">The <c>ContentArea</c> to put the keybind item in.</param>
		/// <param name="name">The name of the keybind game object.</param>
		/// <param name="action">The <c>PlayerAction</c> to associate with this keybind.</param>
		/// <param name="config">The configuration options for the keybind item.</param>
		/// <param name="mappableKey">The <c>MappablKey</c> component on the created keybind item.</param>
		/// <returns></returns>
		// Token: 0x06004894 RID: 18580 RVA: 0x0018993C File Offset: 0x00187B3C
		public static ContentArea AddKeybind(this ContentArea content, string name, PlayerAction action, KeybindConfig config, out MappableKey mappableKey)
		{
			KeybindStyle keybindStyle = config.Style ?? KeybindStyle.VanillaStyle;
			GameObject gameObject = new GameObject(name ?? "");
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			gameObject.transform.SetParent(content.ContentObject.transform, false);
			gameObject.AddComponent<CanvasRenderer>();
			RectTransform rt = gameObject.AddComponent<RectTransform>();
			new RelVector2(new Vector2(650f, 100f)).GetBaseTransformData().Apply(rt);
			content.Layout.ModifyNext(rt);
			MappableKey mapKey = (MappableKey)gameObject.AddComponent<MappableKey>();
			mapKey.InitCustomActions(action.Owner, action);
			MenuSelectable menuSelectable = (MenuSelectable)mapKey;
			menuSelectable.cancelAction = CancelAction.GoToExtrasMenu;
			menuSelectable.customCancelAction = delegate(MenuSelectable _)
			{
				mapKey.AbortRebind();
				Action<MappableKey> cancelAction = config.CancelAction;
				if (cancelAction == null)
				{
					return;
				}
				cancelAction(mapKey);
			};
			content.NavGraph.AddNavigationNode(mapKey);
			GameObject gameObject2 = new GameObject("Text");
			UnityEngine.Object.DontDestroyOnLoad(gameObject2);
			gameObject2.transform.SetParent(gameObject.transform, false);
			gameObject2.AddComponent<CanvasRenderer>();
			RectTransform rectTransform = gameObject2.AddComponent<RectTransform>();
			rectTransform.sizeDelta = new Vector2(0f, 0f);
			rectTransform.anchorMin = new Vector2(0f, 0f);
			rectTransform.anchorMax = new Vector2(1f, 1f);
			rectTransform.anchoredPosition = new Vector2(0f, 0f);
			rectTransform.pivot = new Vector2(0.5f, 0.5f);
			Text text = gameObject2.AddComponent<Text>();
			text.font = MenuResources.TrajanBold;
			text.fontSize = keybindStyle.LabelTextSize;
			text.resizeTextMaxSize = keybindStyle.LabelTextSize;
			text.alignment = TextAnchor.MiddleLeft;
			text.text = config.Label;
			text.supportRichText = true;
			text.verticalOverflow = VerticalWrapMode.Overflow;
			text.horizontalOverflow = HorizontalWrapMode.Overflow;
			gameObject2.AddComponent<FixVerticalAlign>();
			GameObject gameObject3 = new GameObject("CursorLeft");
			UnityEngine.Object.DontDestroyOnLoad(gameObject3);
			gameObject3.transform.SetParent(gameObject.transform, false);
			gameObject3.AddComponent<CanvasRenderer>();
			RectTransform rectTransform2 = gameObject3.AddComponent<RectTransform>();
			rectTransform2.sizeDelta = new Vector2(154f, 112f);
			rectTransform2.pivot = new Vector2(0.5f, 0.5f);
			rectTransform2.anchorMin = new Vector2(0f, 0.5f);
			rectTransform2.anchorMax = new Vector2(0f, 0.5f);
			rectTransform2.anchoredPosition = new Vector2(-52f, 0f);
			rectTransform2.localScale = new Vector3(0.4f, 0.4f, 0.4f);
			Animator animator = gameObject3.AddComponent<Animator>();
			animator.runtimeAnimatorController = MenuResources.MenuCursorAnimator;
			animator.updateMode = AnimatorUpdateMode.UnscaledTime;
			animator.applyRootMotion = false;
			gameObject3.AddComponent<Image>();
			mapKey.leftCursor = animator;
			GameObject gameObject4 = new GameObject("CursorRight");
			UnityEngine.Object.DontDestroyOnLoad(gameObject4);
			gameObject4.transform.SetParent(gameObject.transform, false);
			gameObject4.AddComponent<CanvasRenderer>();
			RectTransform rectTransform3 = gameObject4.AddComponent<RectTransform>();
			rectTransform3.sizeDelta = new Vector2(154f, 112f);
			rectTransform3.pivot = new Vector2(0.5f, 0.5f);
			rectTransform3.anchorMin = new Vector2(1f, 0.5f);
			rectTransform3.anchorMax = new Vector2(1f, 0.5f);
			rectTransform3.anchoredPosition = new Vector2(52f, 0f);
			rectTransform3.localScale = new Vector3(-0.4f, 0.4f, 0.4f);
			Animator animator2 = gameObject4.AddComponent<Animator>();
			animator2.runtimeAnimatorController = MenuResources.MenuCursorAnimator;
			animator2.updateMode = AnimatorUpdateMode.UnscaledTime;
			animator2.applyRootMotion = false;
			gameObject4.AddComponent<Image>();
			mapKey.rightCursor = animator2;
			GameObject gameObject5 = new GameObject("Keymap");
			UnityEngine.Object.DontDestroyOnLoad(gameObject5);
			gameObject5.transform.SetParent(gameObject.transform, false);
			gameObject5.AddComponent<CanvasRenderer>();
			RectTransform rectTransform4 = gameObject5.AddComponent<RectTransform>();
			rectTransform4.sizeDelta = new Vector2(145.8f, 82.4f);
			rectTransform4.anchorMin = new Vector2(1f, 0.5f);
			rectTransform4.anchorMax = new Vector2(1f, 0.5f);
			rectTransform4.anchoredPosition = new Vector2(0f, 0f);
			rectTransform4.pivot = new Vector2(1f, 0.5f);
			Image image = gameObject5.AddComponent<Image>();
			image.preserveAspect = true;
			mapKey.keymapSprite = image;
			GameObject gameObject6 = new GameObject("Text");
			UnityEngine.Object.DontDestroyOnLoad(gameObject6);
			gameObject6.transform.SetParent(gameObject5.transform, false);
			gameObject6.AddComponent<CanvasRenderer>();
			RectTransform rectTransform5 = gameObject6.AddComponent<RectTransform>();
			rectTransform5.sizeDelta = new Vector2(65f, 60f);
			rectTransform5.anchorMin = new Vector2(0.5f, 0.5f);
			rectTransform5.anchorMin = new Vector2(0.5f, 0.5f);
			rectTransform5.anchoredPosition = new Vector2(32f, 0f);
			rectTransform5.pivot = new Vector2(0.5f, 0.5f);
			Text text2 = gameObject6.AddComponent<Text>();
			text2.font = MenuResources.Perpetua;
			mapKey.keymapText = text2;
			gameObject6.AddComponent<FixVerticalAlign>().labelFixType = FixVerticalAlign.LabelFixType.KeyMap;
			mapKey.GetBinding();
			mapKey.ShowCurrentBinding();
			mappableKey = mapKey;
			return content;
		}

		/// <summary>
		/// Creates a buttonBind menu item.
		/// </summary>
		/// <param name="content">The <c>ContentArea</c> to put the buttonBind item in.</param>
		/// <param name="name">The name of the buttonBind game object.</param>
		/// <param name="action">The <c>PlayerAction</c> to associate with this buttonBind.</param>
		/// <param name="config">The configuration options for the buttonBind item.</param>
		/// <param name="mappableControllerButton">The <c>MappableControllerButton</c> component on the created buttonBind item.</param>
		/// <returns></returns>
		// Token: 0x06004895 RID: 18581 RVA: 0x00189EA4 File Offset: 0x001880A4
		public static ContentArea AddButtonBind(this ContentArea content, string name, PlayerAction action, ButtonBindConfig config, out MappableControllerButton mappableControllerButton)
		{
			KeybindStyle keybindStyle = config.Style ?? KeybindStyle.VanillaStyle;
			GameObject gameObject = new GameObject(name ?? "");
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			gameObject.transform.SetParent(content.ContentObject.transform, false);
			gameObject.AddComponent<CanvasRenderer>();
			RectTransform rt = gameObject.AddComponent<RectTransform>();
			new RelVector2(new Vector2(650f, 100f)).GetBaseTransformData().Apply(rt);
			content.Layout.ModifyNext(rt);
			MappableControllerButton mapButton = (MappableControllerButton)gameObject.AddComponent<MappableControllerButton>();
			mapButton.InitCustomActions(action.Owner, action);
			MenuSelectable menuSelectable = (MenuSelectable)mapButton;
			menuSelectable.cancelAction = CancelAction.GoToExtrasMenu;
			menuSelectable.customCancelAction = delegate(MenuSelectable _)
			{
				mapButton.AbortRebind();
				Action<MappableControllerButton> cancelAction = config.CancelAction;
				if (cancelAction == null)
				{
					return;
				}
				cancelAction(mapButton);
			};
			content.NavGraph.AddNavigationNode(mapButton);
			GameObject gameObject2 = new GameObject("Text");
			UnityEngine.Object.DontDestroyOnLoad(gameObject2);
			gameObject2.transform.SetParent(gameObject.transform, false);
			gameObject2.AddComponent<CanvasRenderer>();
			RectTransform rectTransform = gameObject2.AddComponent<RectTransform>();
			rectTransform.sizeDelta = new Vector2(0f, 0f);
			rectTransform.anchorMin = new Vector2(0f, 0f);
			rectTransform.anchorMax = new Vector2(1f, 1f);
			rectTransform.anchoredPosition = new Vector2(0f, 0f);
			rectTransform.pivot = new Vector2(0.5f, 0.5f);
			Text text = gameObject2.AddComponent<Text>();
			text.font = MenuResources.TrajanBold;
			text.fontSize = keybindStyle.LabelTextSize;
			text.resizeTextMaxSize = keybindStyle.LabelTextSize;
			text.alignment = TextAnchor.MiddleLeft;
			text.text = config.Label;
			text.supportRichText = true;
			text.verticalOverflow = VerticalWrapMode.Overflow;
			text.horizontalOverflow = HorizontalWrapMode.Overflow;
			gameObject2.AddComponent<FixVerticalAlign>();
			GameObject gameObject3 = new GameObject("CursorLeft");
			UnityEngine.Object.DontDestroyOnLoad(gameObject3);
			gameObject3.transform.SetParent(gameObject.transform, false);
			gameObject3.AddComponent<CanvasRenderer>();
			RectTransform rectTransform2 = gameObject3.AddComponent<RectTransform>();
			rectTransform2.sizeDelta = new Vector2(154f, 112f);
			rectTransform2.pivot = new Vector2(0.5f, 0.5f);
			rectTransform2.anchorMin = new Vector2(0f, 0.5f);
			rectTransform2.anchorMax = new Vector2(0f, 0.5f);
			rectTransform2.anchoredPosition = new Vector2(-52f, 0f);
			rectTransform2.localScale = new Vector3(0.4f, 0.4f, 0.4f);
			Animator animator = gameObject3.AddComponent<Animator>();
			animator.runtimeAnimatorController = MenuResources.MenuCursorAnimator;
			animator.updateMode = AnimatorUpdateMode.UnscaledTime;
			animator.applyRootMotion = false;
			gameObject3.AddComponent<Image>();
			mapButton.leftCursor = animator;
			GameObject gameObject4 = new GameObject("CursorRight");
			UnityEngine.Object.DontDestroyOnLoad(gameObject4);
			gameObject4.transform.SetParent(gameObject.transform, false);
			gameObject4.AddComponent<CanvasRenderer>();
			RectTransform rectTransform3 = gameObject4.AddComponent<RectTransform>();
			rectTransform3.sizeDelta = new Vector2(154f, 112f);
			rectTransform3.pivot = new Vector2(0.5f, 0.5f);
			rectTransform3.anchorMin = new Vector2(1f, 0.5f);
			rectTransform3.anchorMax = new Vector2(1f, 0.5f);
			rectTransform3.anchoredPosition = new Vector2(52f, 0f);
			rectTransform3.localScale = new Vector3(-0.4f, 0.4f, 0.4f);
			Animator animator2 = gameObject4.AddComponent<Animator>();
			animator2.runtimeAnimatorController = MenuResources.MenuCursorAnimator;
			animator2.updateMode = AnimatorUpdateMode.UnscaledTime;
			animator2.applyRootMotion = false;
			gameObject4.AddComponent<Image>();
			mapButton.rightCursor = animator2;
			GameObject gameObject5 = new GameObject("Keymap");
			UnityEngine.Object.DontDestroyOnLoad(gameObject5);
			gameObject5.transform.SetParent(gameObject.transform, false);
			gameObject5.AddComponent<CanvasRenderer>();
			RectTransform rectTransform4 = gameObject5.AddComponent<RectTransform>();
			rectTransform4.sizeDelta = new Vector2(145.8f, 82.4f);
			rectTransform4.anchorMin = new Vector2(1f, 0.5f);
			rectTransform4.anchorMax = new Vector2(1f, 0.5f);
			rectTransform4.anchoredPosition = new Vector2(0f, 0f);
			rectTransform4.pivot = new Vector2(1f, 0.5f);
			Image image = gameObject5.AddComponent<Image>();
			image.preserveAspect = true;
			mapButton.buttonmapSprite = image;
			GameObject gameObject6 = new GameObject("Text");
			UnityEngine.Object.DontDestroyOnLoad(gameObject6);
			gameObject6.transform.SetParent(gameObject5.transform, false);
			gameObject6.AddComponent<CanvasRenderer>();
			RectTransform rectTransform5 = gameObject6.AddComponent<RectTransform>();
			rectTransform5.sizeDelta = new Vector2(85f, 60f);
			rectTransform5.anchorMin = new Vector2(0f, 0.5f);
			rectTransform5.anchorMax = new Vector2(1f, 0.5f);
			rectTransform5.anchoredPosition = new Vector2(32f, 0f);
			rectTransform5.pivot = new Vector2(0.5f, 0.5f);
			Text text2 = gameObject6.AddComponent<Text>();
			text2.font = MenuResources.Perpetua;
			text2.fontSize = 35;
			mapButton.buttonmapText = text2;
			gameObject6.AddComponent<FixVerticalAlign>().labelFixType = FixVerticalAlign.LabelFixType.KeyMap;
			GameObject gameObject7 = new GameObject("throbber");
			UnityEngine.Object.DontDestroyOnLoad(gameObject7);
			gameObject7.transform.SetParent(gameObject5.transform, false);
			mapButton.listeningThrobber = gameObject7.AddComponent<Throbber>();
			ReflectionHelper.SetField<Throbber, Sprite[]>(mapButton.listeningThrobber, "sprites", new Sprite[0]);
			mapButton.GetBindingPublic();
			mapButton.ShowCurrentBinding();
			mappableControllerButton = mapButton;
			return content;
		}
	}
}
