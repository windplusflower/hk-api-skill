using System;
using GlobalEnums;
using Modding.Menu.Config;
using UnityEngine;
using UnityEngine.UI;

namespace Modding.Menu
{
	/// <summary>
	/// A helper class for creating horizontal menu options.
	/// </summary>
	// Token: 0x02000DAC RID: 3500
	public static class HorizontalOptionContent
	{
		/// <summary>
		/// Creates a horizontal option.
		/// </summary>
		/// <param name="content">The <c>ContentArea</c> to put the option in.</param>
		/// <param name="name">The name of the option game object.</param>
		/// <param name="config">The configuration options for the horizontal option.</param>
		/// <returns></returns>
		// Token: 0x06004891 RID: 18577 RVA: 0x0018930C File Offset: 0x0018750C
		public static ContentArea AddHorizontalOption(this ContentArea content, string name, HorizontalOptionConfig config)
		{
			MenuOptionHorizontal menuOptionHorizontal;
			return content.AddHorizontalOption(name, config, out menuOptionHorizontal);
		}

		/// <summary>
		/// Creates a horizontal option.
		/// </summary>
		/// <param name="content">The <c>ContentArea</c> to put the option in.</param>
		/// <param name="name">The name of the option game object.</param>
		/// <param name="config">The configuration options for the horizontal option.</param>
		/// <param name="horizontalOption">The <c>MenuOptionHorizontal</c> component on the created horizontal option.</param>
		/// <returns></returns>
		// Token: 0x06004892 RID: 18578 RVA: 0x00189324 File Offset: 0x00187524
		public static ContentArea AddHorizontalOption(this ContentArea content, string name, HorizontalOptionConfig config, out MenuOptionHorizontal horizontalOption)
		{
			HorizontalOptionStyle horizontalOptionStyle = config.Style ?? HorizontalOptionStyle.VanillaStyle;
			GameObject gameObject = new GameObject(name ?? "");
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			gameObject.transform.SetParent(content.ContentObject.transform, false);
			gameObject.AddComponent<CanvasRenderer>();
			RectTransform rt = gameObject.AddComponent<RectTransform>();
			horizontalOptionStyle.Size.GetBaseTransformData().Apply(rt);
			content.Layout.ModifyNext(rt);
			MenuOptionHorizontal menuOptionHorizontal = gameObject.AddComponent<MenuOptionHorizontal>();
			menuOptionHorizontal.optionList = config.Options;
			menuOptionHorizontal.applySettingOn = MenuOptionHorizontal.ApplyOnType.Scroll;
			menuOptionHorizontal.cancelAction = CancelAction.GoToExtrasMenu;
			((MenuSelectable)menuOptionHorizontal).customCancelAction = config.CancelAction;
			content.NavGraph.AddNavigationNode(menuOptionHorizontal);
			MenuSetting menuSetting = (MenuSetting)gameObject.AddComponent<MenuSetting>();
			menuSetting.settingType = MenuSetting.MenuSettingType.CustomSetting;
			menuSetting.customApplySetting = config.ApplySetting;
			menuSetting.customRefreshSetting = config.RefreshSetting;
			menuSetting.optionList = menuOptionHorizontal;
			menuOptionHorizontal.menuSetting = menuSetting;
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
			text.fontSize = horizontalOptionStyle.LabelTextSize;
			text.resizeTextMaxSize = horizontalOptionStyle.LabelTextSize;
			text.alignment = TextAnchor.MiddleLeft;
			text.text = config.Label;
			text.supportRichText = true;
			text.verticalOverflow = VerticalWrapMode.Overflow;
			text.horizontalOverflow = HorizontalWrapMode.Overflow;
			gameObject2.AddComponent<FixVerticalAlign>();
			GameObject gameObject3 = new GameObject("Text");
			UnityEngine.Object.DontDestroyOnLoad(gameObject3);
			gameObject3.transform.SetParent(gameObject.transform, false);
			gameObject3.AddComponent<CanvasRenderer>();
			RectTransform rectTransform2 = gameObject3.AddComponent<RectTransform>();
			rectTransform2.sizeDelta = new Vector2(0f, 0f);
			rectTransform2.pivot = new Vector2(0.5f, 0.5f);
			rectTransform2.anchorMin = new Vector2(0f, 0f);
			rectTransform2.anchorMax = new Vector2(1f, 1f);
			rectTransform2.anchoredPosition = new Vector2(0f, 0f);
			Text text2 = gameObject3.AddComponent<Text>();
			text2.font = MenuResources.TrajanRegular;
			text2.fontSize = horizontalOptionStyle.ValueTextSize;
			text2.resizeTextMaxSize = horizontalOptionStyle.ValueTextSize;
			text2.alignment = TextAnchor.MiddleRight;
			text2.text = config.Label;
			text2.supportRichText = true;
			text2.verticalOverflow = VerticalWrapMode.Overflow;
			text2.horizontalOverflow = HorizontalWrapMode.Overflow;
			gameObject3.AddComponent<FixVerticalAlign>();
			menuOptionHorizontal.optionText = text2;
			GameObject gameObject4 = new GameObject("CursorLeft");
			UnityEngine.Object.DontDestroyOnLoad(gameObject4);
			gameObject4.transform.SetParent(gameObject.transform, false);
			gameObject4.AddComponent<CanvasRenderer>();
			RectTransform rectTransform3 = gameObject4.AddComponent<RectTransform>();
			rectTransform3.sizeDelta = new Vector2(164f, 119f);
			rectTransform3.pivot = new Vector2(0.5f, 0.5f);
			rectTransform3.anchorMin = new Vector2(0f, 0.5f);
			rectTransform3.anchorMax = new Vector2(0f, 0.5f);
			rectTransform3.anchoredPosition = new Vector2(-70f, 0f);
			rectTransform3.localScale = new Vector3(0.4f, 0.4f, 0.4f);
			Animator animator = gameObject4.AddComponent<Animator>();
			animator.runtimeAnimatorController = MenuResources.MenuCursorAnimator;
			animator.updateMode = AnimatorUpdateMode.UnscaledTime;
			animator.applyRootMotion = false;
			gameObject4.AddComponent<Image>();
			menuOptionHorizontal.leftCursor = animator;
			GameObject gameObject5 = new GameObject("CursorRight");
			UnityEngine.Object.DontDestroyOnLoad(gameObject5);
			gameObject5.transform.SetParent(gameObject.transform, false);
			gameObject5.AddComponent<CanvasRenderer>();
			RectTransform rectTransform4 = gameObject5.AddComponent<RectTransform>();
			rectTransform4.sizeDelta = new Vector2(164f, 119f);
			rectTransform4.pivot = new Vector2(0.5f, 0.5f);
			rectTransform4.anchorMin = new Vector2(1f, 0.5f);
			rectTransform4.anchorMax = new Vector2(1f, 0.5f);
			rectTransform4.anchoredPosition = new Vector2(70f, 0f);
			rectTransform4.localScale = new Vector3(-0.4f, 0.4f, 0.4f);
			Animator animator2 = gameObject5.AddComponent<Animator>();
			animator2.runtimeAnimatorController = MenuResources.MenuCursorAnimator;
			animator2.updateMode = AnimatorUpdateMode.UnscaledTime;
			animator2.applyRootMotion = false;
			gameObject5.AddComponent<Image>();
			menuOptionHorizontal.rightCursor = animator2;
			DescriptionInfo? description = config.Description;
			if (description != null)
			{
				DescriptionInfo valueOrDefault = description.GetValueOrDefault();
				DescriptionStyle descriptionStyle = valueOrDefault.Style ?? DescriptionStyle.HorizOptionSingleLineVanillaStyle;
				GameObject gameObject6 = new GameObject("Description");
				UnityEngine.Object.DontDestroyOnLoad(gameObject6);
				gameObject6.transform.SetParent(gameObject.transform, false);
				gameObject6.AddComponent<CanvasRenderer>();
				RectTransform rt2 = gameObject6.AddComponent<RectTransform>();
				RectTransformData.FromSizeAndPos(descriptionStyle.Size, new AnchoredPosition(new Vector2(0f, 0f), new Vector2(0f, 1f), new Vector2(60f, 0f))).Apply(rt2);
				Animator animator3 = gameObject6.AddComponent<Animator>();
				animator3.runtimeAnimatorController = MenuResources.TextHideShowAnimator;
				animator3.updateMode = AnimatorUpdateMode.UnscaledTime;
				animator3.applyRootMotion = false;
				Text text3 = gameObject6.AddComponent<Text>();
				text3.font = MenuResources.Perpetua;
				text3.fontSize = descriptionStyle.TextSize;
				text3.resizeTextMaxSize = descriptionStyle.TextSize;
				text3.alignment = descriptionStyle.TextAnchor;
				text3.text = valueOrDefault.Text;
				text3.supportRichText = true;
				text3.verticalOverflow = VerticalWrapMode.Overflow;
				text3.horizontalOverflow = HorizontalWrapMode.Wrap;
				menuOptionHorizontal.descriptionText = animator3;
			}
			horizontalOption = menuOptionHorizontal;
			return content;
		}
	}
}
