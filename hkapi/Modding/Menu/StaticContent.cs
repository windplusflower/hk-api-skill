using System;
using Modding.Menu.Config;
using UnityEngine;
using UnityEngine.UI;

namespace Modding.Menu
{
	/// <summary>
	/// A helper class for creating static content.
	/// </summary>
	// Token: 0x02000DB5 RID: 3509
	public static class StaticContent
	{
		/// <summary>
		/// Creates a sized static panel with no other properties.
		/// </summary>
		/// <param name="content">The <c>ContentArea</c> to put the panel in.</param>
		/// <param name="name">The name of the panel game object.</param>
		/// <param name="size">The size of the panel.</param>
		/// <param name="obj">The newly created panel.</param>
		/// <returns></returns>
		// Token: 0x060048A9 RID: 18601 RVA: 0x0018B178 File Offset: 0x00189378
		public static ContentArea AddStaticPanel(this ContentArea content, string name, RelVector2 size, out GameObject obj)
		{
			GameObject gameObject = new GameObject(name);
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			gameObject.transform.SetParent(content.ContentObject.transform, false);
			RectTransform rt = gameObject.AddComponent<RectTransform>();
			size.GetBaseTransformData().Apply(rt);
			content.Layout.ModifyNext(rt);
			gameObject.AddComponent<CanvasRenderer>();
			obj = gameObject;
			return content;
		}

		/// <summary>
		/// Creates a text panel.
		/// </summary>
		/// <param name="content">The <c>ContentArea</c> to put the text panel in.</param>
		/// <param name="name">The name of the text panel game object.</param>
		/// <param name="size">The size of the text panel.</param>
		/// <param name="config">The configuration options for the text panel.</param>
		/// <returns></returns>
		// Token: 0x060048AA RID: 18602 RVA: 0x0018B1D8 File Offset: 0x001893D8
		public static ContentArea AddTextPanel(this ContentArea content, string name, RelVector2 size, TextPanelConfig config)
		{
			Text text;
			return content.AddTextPanel(name, size, config, out text);
		}

		/// <summary>
		/// Creates a text panel.
		/// </summary>
		/// <param name="content">The <c>ContentArea</c> to put the text panel in.</param>
		/// <param name="name">The name of the text panel game object.</param>
		/// <param name="size">The size of the text panel.</param>
		/// <param name="config">The configuration options for the text panel.</param>
		/// <param name="text">The <c>Text</c> component on the created text panel.</param>
		/// <returns></returns>
		// Token: 0x060048AB RID: 18603 RVA: 0x0018B1F0 File Offset: 0x001893F0
		public static ContentArea AddTextPanel(this ContentArea content, string name, RelVector2 size, TextPanelConfig config, out Text text)
		{
			GameObject gameObject;
			content.AddStaticPanel(name, size, out gameObject);
			text = gameObject.AddComponent<Text>();
			text.text = config.Text;
			text.fontSize = config.Size;
			Text text2 = text;
			Font font;
			switch (config.Font)
			{
			case TextPanelConfig.TextFont.TrajanRegular:
				font = MenuResources.TrajanRegular;
				break;
			case TextPanelConfig.TextFont.TrajanBold:
				font = MenuResources.TrajanBold;
				break;
			case TextPanelConfig.TextFont.Perpetua:
				font = MenuResources.Perpetua;
				break;
			case TextPanelConfig.TextFont.NotoSerifCJKSCRegular:
				font = MenuResources.NotoSerifCJKSCRegular;
				break;
			default:
				font = MenuResources.TrajanRegular;
				break;
			}
			text2.font = font;
			text.supportRichText = true;
			text.alignment = config.Anchor;
			return content;
		}

		/// <summary>
		/// Creates an image panel.
		/// </summary>
		/// <param name="content">The <c>ContentArea</c> to put the text panel in.</param>
		/// <param name="name">The name of the image panel game object.</param>
		/// <param name="size">The size of the image panel.</param>
		/// <param name="image">The image to render.</param>
		/// <returns></returns>
		// Token: 0x060048AC RID: 18604 RVA: 0x0018B298 File Offset: 0x00189498
		public static ContentArea AddImagePanel(this ContentArea content, string name, RelVector2 size, Sprite image)
		{
			Image image2;
			return content.AddImagePanel(name, size, image, out image2);
		}

		/// <summary>
		/// Creates an image panel.
		/// </summary>
		/// <param name="content">The <c>ContentArea</c> to put the text panel in.</param>
		/// <param name="name">The name of the image panel game object.</param>
		/// <param name="size">The size of the image panel.</param>
		/// <param name="sprite">The image to render.</param>
		/// <param name="image">The <c>Image</c> component on the created image panel.</param>
		/// <returns></returns>
		// Token: 0x060048AD RID: 18605 RVA: 0x0018B2B0 File Offset: 0x001894B0
		public static ContentArea AddImagePanel(this ContentArea content, string name, RelVector2 size, Sprite sprite, out Image image)
		{
			GameObject gameObject;
			content.AddStaticPanel(name, size, out gameObject);
			image = gameObject.AddComponent<Image>();
			image.sprite = sprite;
			image.preserveAspect = true;
			return content;
		}

		/// <summary>
		/// Creates a single item wrapper.
		/// </summary>
		/// <remarks>
		/// This wrapper will have no size so all parent relative sizes will break.
		/// </remarks>
		/// <param name="content">The <c>ContentArea</c> to put the wrapper in.</param>
		/// <param name="name">The name of the wrapper game object.</param>
		/// <param name="action">The action that will get called to add the inner object.</param>
		/// <returns></returns>
		// Token: 0x060048AE RID: 18606 RVA: 0x0018B2E4 File Offset: 0x001894E4
		public static ContentArea AddWrappedItem(this ContentArea content, string name, Action<ContentArea> action)
		{
			GameObject gameObject;
			return content.AddWrappedItem(name, action, out gameObject);
		}

		/// <summary>
		/// Creates a single item wrapper.
		/// </summary>
		/// <remarks>
		/// This wrapper will have no size so all parent relative sizes will break.
		/// </remarks>
		/// <param name="content">The <c>ContentArea</c> to put the wrapper in.</param>
		/// <param name="name">The name of the wrapper game object.</param>
		/// <param name="action">The action that will get called to add the inner object.</param>
		/// <param name="wrapper">The newly created wrapper.</param>
		/// <returns></returns>
		// Token: 0x060048AF RID: 18607 RVA: 0x0018B2FC File Offset: 0x001894FC
		public static ContentArea AddWrappedItem(this ContentArea content, string name, Action<ContentArea> action, out GameObject wrapper)
		{
			wrapper = new GameObject(name);
			UnityEngine.Object.DontDestroyOnLoad(wrapper);
			wrapper.transform.SetParent(content.ContentObject.transform, false);
			RectTransform rectTransform = wrapper.AddComponent<RectTransform>();
			rectTransform.sizeDelta = new Vector2(0f, 0f);
			rectTransform.pivot = new Vector2(0.5f, 0.5f);
			rectTransform.anchorMin = new Vector2(0.5f, 0.5f);
			rectTransform.anchorMax = new Vector2(0.5f, 0.5f);
			content.Layout.ModifyNext(rectTransform);
			wrapper.AddComponent<CanvasRenderer>();
			action(new ContentArea(wrapper, new SingleContentLayout(new Vector2(0.5f, 0.5f)), content.NavGraph));
			return content;
		}
	}
}
