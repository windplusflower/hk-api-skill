using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

namespace Modding
{
	/// <summary>
	///     Utility with helpful functions for drawing canvas elements on screen.
	/// </summary>
	// Token: 0x02000D56 RID: 3414
	[PublicAPI]
	public static class CanvasUtil
	{
		/// <summary>
		///     Access to the TrajanBold Font
		/// </summary>
		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x06004663 RID: 18019 RVA: 0x0017F813 File Offset: 0x0017DA13
		public static Font TrajanBold
		{
			get
			{
				if (!CanvasUtil._trajanBold)
				{
					CanvasUtil.CreateFonts();
				}
				return CanvasUtil._trajanBold;
			}
		}

		/// <summary>
		///     Access to the TrajanNormal Font
		/// </summary>
		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x06004664 RID: 18020 RVA: 0x0017F82B File Offset: 0x0017DA2B
		public static Font TrajanNormal
		{
			get
			{
				if (!CanvasUtil._trajanNormal)
				{
					CanvasUtil.CreateFonts();
				}
				return CanvasUtil._trajanNormal;
			}
		}

		/// <summary>
		///     Fetches the Trajan fonts to be cached and used.
		/// </summary>
		// Token: 0x06004665 RID: 18021 RVA: 0x0017F844 File Offset: 0x0017DA44
		private static void CreateFonts()
		{
			foreach (Font font in Resources.FindObjectsOfTypeAll<Font>())
			{
				if (font != null && font.name == "TrajanPro-Bold")
				{
					CanvasUtil._trajanBold = font;
				}
				if (font != null && font.name == "TrajanPro-Regular")
				{
					CanvasUtil._trajanNormal = font;
				}
			}
		}

		/// <summary>
		///     Fetches the cached font if it exists.
		/// </summary>
		/// <param name="fontName"></param>
		/// <returns>Font if found, null if not.</returns>
		// Token: 0x06004666 RID: 18022 RVA: 0x0017F8AC File Offset: 0x0017DAAC
		public static Font GetFont(string fontName)
		{
			if (CanvasUtil.Fonts.ContainsKey(fontName))
			{
				return CanvasUtil.Fonts[fontName];
			}
			foreach (Font font in Resources.FindObjectsOfTypeAll<Font>())
			{
				if (font != null && font.name == fontName)
				{
					CanvasUtil.Fonts.Add(fontName, font);
					break;
				}
			}
			if (!CanvasUtil.Fonts.ContainsKey(fontName))
			{
				return null;
			}
			return CanvasUtil.Fonts[fontName];
		}

		/// <summary>
		///     Creates a 1px * 1px sprite of a single color.
		/// </summary>
		/// <param name="data">Optional value to control the single null sprite</param>
		/// <returns></returns>
		// Token: 0x06004667 RID: 18023 RVA: 0x0017F92C File Offset: 0x0017DB2C
		public static Sprite NullSprite(byte[] data = null)
		{
			Texture2D texture2D = new Texture2D(1, 1);
			if (data == null)
			{
				data = new byte[4];
			}
			texture2D.LoadRawTextureData(data);
			texture2D.Apply();
			return Sprite.Create(texture2D, new Rect(0f, 0f, 1f, 1f), Vector2.zero);
		}

		/// <summary>
		///     Creates a sprite from a sub-section of the given texture.
		/// </summary>
		/// <param name="data">Sprite texture data</param>
		/// <param name="x">X location of the sprite within the texture.</param>
		/// <param name="y">Y Locaiton of the sprite within the texture.</param>
		/// <param name="width">Width of sprite</param>
		/// <param name="height">Height of sprite</param>
		/// <returns></returns>
		// Token: 0x06004668 RID: 18024 RVA: 0x0017F97D File Offset: 0x0017DB7D
		public static Sprite CreateSprite(byte[] data, int x, int y, int width, int height)
		{
			Texture2D texture2D = new Texture2D(1, 1);
			texture2D.LoadImage(data);
			texture2D.anisoLevel = 0;
			return Sprite.Create(texture2D, new Rect((float)x, (float)y, (float)width, (float)height), Vector2.zero);
		}

		/// <summary>
		///     Creates a base panel for other panels to use.
		/// </summary>
		/// <param name="parent">Parent Game Object under which this panel will be held</param>
		/// <param name="rd">Rectangle data for this panel</param>
		/// <returns></returns>
		// Token: 0x06004669 RID: 18025 RVA: 0x0017F9B0 File Offset: 0x0017DBB0
		public static GameObject CreateBasePanel(GameObject parent, CanvasUtil.RectData rd)
		{
			GameObject gameObject = new GameObject();
			if (parent != null)
			{
				gameObject.transform.SetParent(parent.transform);
				gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
			}
			gameObject.AddComponent<CanvasRenderer>();
			CanvasUtil.AddRectTransform(gameObject, rd);
			return gameObject;
		}

		/// <summary>
		///     Transforms the RectData into a RectTransform for the GameObject.
		/// </summary>
		/// <param name="go">GameObject to which this rectdata should be put into.</param>
		/// <param name="rd">Rectangle Data</param>
		// Token: 0x0600466A RID: 18026 RVA: 0x0017FA0C File Offset: 0x0017DC0C
		public static void AddRectTransform(GameObject go, CanvasUtil.RectData rd)
		{
			RectTransform rectTransform = go.AddComponent<RectTransform>();
			rectTransform.anchorMax = rd.AnchorMax;
			rectTransform.anchorMin = rd.AnchorMin;
			rectTransform.pivot = rd.AnchorPivot;
			rectTransform.sizeDelta = rd.RectSizeDelta;
			rectTransform.anchoredPosition = rd.AnchorPosition;
		}

		/// <summary>
		///     Creates a Canvas Element that is scaled to the parent's size.
		/// </summary>
		/// <param name="renderMode">Render Mode to Use</param>
		/// <param name="referencePixelsPerUnit"></param>
		/// <returns></returns>
		// Token: 0x0600466B RID: 18027 RVA: 0x0017FA5A File Offset: 0x0017DC5A
		public static GameObject CreateCanvas(RenderMode renderMode, int referencePixelsPerUnit)
		{
			GameObject gameObject = CanvasUtil.CreateCanvas(renderMode);
			gameObject.GetComponent<CanvasScaler>().referencePixelsPerUnit = (float)referencePixelsPerUnit;
			return gameObject;
		}

		/// <summary>
		///     Creates a Canvas Element.
		/// </summary>
		/// <param name="renderMode">RenderMode to Use</param>
		/// <param name="size">Size of the Canvas</param>
		/// <returns></returns>
		// Token: 0x0600466C RID: 18028 RVA: 0x0017FA6F File Offset: 0x0017DC6F
		public static GameObject CreateCanvas(RenderMode renderMode, Vector2 size)
		{
			GameObject gameObject = CanvasUtil.CreateCanvas(renderMode);
			gameObject.GetComponent<CanvasScaler>().referenceResolution = size;
			return gameObject;
		}

		// Token: 0x0600466D RID: 18029 RVA: 0x0017FA83 File Offset: 0x0017DC83
		private static GameObject CreateCanvas(RenderMode renderMode)
		{
			GameObject gameObject = new GameObject();
			gameObject.AddComponent<Canvas>().renderMode = renderMode;
			gameObject.AddComponent<CanvasScaler>().uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
			gameObject.AddComponent<GraphicRaycaster>();
			gameObject.AddComponent<CanvasGroup>();
			return gameObject;
		}

		/// <summary>
		///     Creates a Text Object
		/// </summary>
		/// <param name="parent">The GameObject that this text will be put into.</param>
		/// <param name="text">The text that will be shown with this object</param>
		/// <param name="fontSize">The text's font size.</param>
		/// <param name="textAnchor">The location within the rectData where the text anchor should be.</param>
		/// <param name="rectData">Rectangle Data to describe the Text Panel.</param>
		/// <param name="font">The Font to use</param>
		/// <returns></returns>
		// Token: 0x0600466E RID: 18030 RVA: 0x0017FAB0 File Offset: 0x0017DCB0
		public static GameObject CreateTextPanel(GameObject parent, string text, int fontSize, TextAnchor textAnchor, CanvasUtil.RectData rectData, Font font)
		{
			GameObject gameObject = CanvasUtil.CreateBasePanel(parent, rectData);
			Text text2 = gameObject.AddComponent<Text>();
			text2.font = font;
			text2.text = text;
			text2.supportRichText = true;
			text2.fontSize = fontSize;
			text2.alignment = textAnchor;
			return gameObject;
		}

		/// <summary>
		///     Creates a Text Object
		/// </summary>
		/// <param name="parent">The GameObject that this text will be put into.</param>
		/// <param name="text">The text that will be shown with this object</param>
		/// <param name="fontSize">The text's font size.</param>
		/// <param name="textAnchor">The location within the rectData where the text anchor should be.</param>
		/// <param name="rectData">Rectangle Data to describe the Text Panel.</param>
		/// <param name="bold">If True, TrajanBold will be the font used, else TrajanNormal</param>
		/// <returns></returns>
		// Token: 0x0600466F RID: 18031 RVA: 0x0017FAE3 File Offset: 0x0017DCE3
		public static GameObject CreateTextPanel(GameObject parent, string text, int fontSize, TextAnchor textAnchor, CanvasUtil.RectData rectData, bool bold = true)
		{
			return CanvasUtil.CreateTextPanel(parent, text, fontSize, textAnchor, rectData, bold ? CanvasUtil.TrajanBold : CanvasUtil.TrajanNormal);
		}

		/// <summary>
		///     Creates an Image Panel
		/// </summary>
		/// <param name="parent">The Parent GameObject for this image.</param>
		/// <param name="sprite">The Image/Sprite to use</param>
		/// <param name="rectData">The rectangle description for this sprite to inhabit</param>
		/// <returns></returns>
		// Token: 0x06004670 RID: 18032 RVA: 0x0017FB00 File Offset: 0x0017DD00
		public static GameObject CreateImagePanel(GameObject parent, Sprite sprite, CanvasUtil.RectData rectData)
		{
			GameObject gameObject = CanvasUtil.CreateBasePanel(parent, rectData);
			Image image = gameObject.AddComponent<Image>();
			image.sprite = sprite;
			image.preserveAspect = true;
			image.useSpriteMesh = true;
			return gameObject;
		}

		/// <summary>
		///     Creates a Button
		/// </summary>
		/// <param name="parent">The Parent GameObject for this Button</param>
		/// <param name="action">Action to take when butotn is clicked</param>
		/// <param name="id">Id passed to the action</param>
		/// <param name="spr">Sprite to use for the button</param>
		/// <param name="text">Text for the button</param>
		/// <param name="fontSize">Size of the Text</param>
		/// <param name="textAnchor">Where to Anchor the text within the button</param>
		/// <param name="rectData">The rectangle description for this button</param>
		/// <param name="bold">If Set, uses Trajan-Bold, else Trajan for the font</param>
		/// <param name="extraSprites">
		///     Size 3 array of other sprite states for the button.  0 = Highlighted Sprite, 1 = Pressed
		///     Sprited, 2 = Disabled Sprite
		/// </param>
		/// <returns></returns>
		// Token: 0x06004671 RID: 18033 RVA: 0x0017FB24 File Offset: 0x0017DD24
		public static GameObject CreateButton(GameObject parent, Action<int> action, int id, Sprite spr, string text, int fontSize, TextAnchor textAnchor, CanvasUtil.RectData rectData, bool bold = true, params Sprite[] extraSprites)
		{
			GameObject gameObject = CanvasUtil.CreateBasePanel(parent, rectData);
			CanvasUtil.CreateTextPanel(gameObject, text, fontSize, textAnchor, rectData, bold);
			Image image = gameObject.AddComponent<Image>();
			image.sprite = spr;
			Button button = gameObject.AddComponent<Button>();
			button.targetGraphic = image;
			button.onClick.AddListener(delegate()
			{
				action(id);
			});
			if (extraSprites.Length == 3)
			{
				button.transition = Selectable.Transition.SpriteSwap;
				button.targetGraphic = image;
				SpriteState spriteState = new SpriteState
				{
					highlightedSprite = extraSprites[0],
					pressedSprite = extraSprites[1],
					disabledSprite = extraSprites[2]
				};
				button.spriteState = spriteState;
				return gameObject;
			}
			button.transition = Selectable.Transition.None;
			return gameObject;
		}

		/// <summary>
		///     Creates a checkbox
		/// </summary>
		/// <param name="parent">The Parent GameObject for this Checkbox</param>
		/// <param name="action">Action to take when butotn is clicked</param>
		/// <param name="boxBgSprite">Sprite to use for the background of the box</param>
		/// <param name="boxFgSprite">Sprite to use for the foreground of the box</param>
		/// <param name="text">Text for the Checkbox</param>
		/// <param name="fontSize">Size of the Text</param>
		/// <param name="textAnchor">Where to Anchor the text within the checkbox</param>
		/// <param name="rectData">The rectangle description for this checkbox</param>
		/// <param name="bold">If Set, uses Trajan-Bold, else Trajan for the font</param>
		/// <param name="isOn">Determines if the initial state of the checkbox is checked or not</param>
		/// <returns></returns>
		// Token: 0x06004672 RID: 18034 RVA: 0x0017FBE4 File Offset: 0x0017DDE4
		public static GameObject CreateToggle(GameObject parent, Action<bool> action, Sprite boxBgSprite, Sprite boxFgSprite, string text, int fontSize, TextAnchor textAnchor, CanvasUtil.RectData rectData, bool bold = true, bool isOn = false)
		{
			GameObject gameObject = CanvasUtil.CreateBasePanel(parent, rectData);
			GameObject gameObject2 = CanvasUtil.CreateImagePanel(gameObject, boxBgSprite, rectData);
			GameObject gameObject3 = CanvasUtil.CreateImagePanel(gameObject2, boxFgSprite, rectData);
			Toggle toggle = gameObject.AddComponent<Toggle>();
			toggle.isOn = isOn;
			toggle.targetGraphic = gameObject2.GetComponent<Image>();
			toggle.graphic = gameObject3.GetComponent<Image>();
			toggle.transition = Selectable.Transition.ColorTint;
			ColorBlock colors = new ColorBlock
			{
				normalColor = new Color(1f, 1f, 1f, 1f),
				highlightedColor = new Color(1f, 1f, 1f, 1f),
				pressedColor = new Color(0.8f, 0.8f, 0.8f, 1f),
				disabledColor = new Color(0.8f, 0.8f, 0.8f, 0.5f),
				fadeDuration = 0.1f
			};
			toggle.colors = colors;
			toggle.onValueChanged.AddListener(delegate(bool b)
			{
				action(b);
			});
			ToggleGroup component = parent.GetComponent<ToggleGroup>();
			if (component != null)
			{
				toggle.group = component;
			}
			return gameObject;
		}

		/// <summary>
		///     Allows for a radio button style group of toggles where only 1 can be toggled at once.
		/// </summary>
		/// <returns></returns>
		// Token: 0x06004673 RID: 18035 RVA: 0x0017FD1C File Offset: 0x0017DF1C
		public static GameObject CreateToggleGroup()
		{
			GameObject gameObject = new GameObject();
			CanvasUtil.AddRectTransform(gameObject, new CanvasUtil.RectData(new Vector2(0f, 0f), new Vector2(0f, 0f), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f)));
			gameObject.AddComponent<ToggleGroup>();
			return gameObject;
		}

		/// <summary>
		///     Hides everything in this object and children objects that goes outside this objects rect
		/// </summary>
		/// <param name="parent">Parent Object for this Panel</param>
		/// <param name="rectData">Describes the panel's rectangle</param>
		/// <returns></returns>
		// Token: 0x06004674 RID: 18036 RVA: 0x0017FD8B File Offset: 0x0017DF8B
		public static GameObject CreateRectMask2DPanel(GameObject parent, CanvasUtil.RectData rectData)
		{
			GameObject gameObject = CanvasUtil.CreateBasePanel(parent, rectData);
			gameObject.AddComponent<RectMask2D>();
			return gameObject;
		}

		/// <summary>
		///     Fades the Canvas Group In When it is &lt; 1f
		/// </summary>
		/// <param name="cg"></param>
		/// <returns></returns>
		// Token: 0x06004675 RID: 18037 RVA: 0x0017FD9B File Offset: 0x0017DF9B
		public static IEnumerator FadeInCanvasGroup(CanvasGroup cg)
		{
			CanvasUtil.<FadeInCanvasGroup>d__23 <FadeInCanvasGroup>d__ = new CanvasUtil.<FadeInCanvasGroup>d__23(0);
			<FadeInCanvasGroup>d__.cg = cg;
			return <FadeInCanvasGroup>d__;
		}

		/// <summary>
		///     Fades the Canvas Group Out When it is &gt; .05f
		/// </summary>
		/// <param name="cg"></param>
		/// <returns></returns>
		// Token: 0x06004676 RID: 18038 RVA: 0x0017FDAA File Offset: 0x0017DFAA
		public static IEnumerator FadeOutCanvasGroup(CanvasGroup cg)
		{
			CanvasUtil.<FadeOutCanvasGroup>d__24 <FadeOutCanvasGroup>d__ = new CanvasUtil.<FadeOutCanvasGroup>d__24(0);
			<FadeOutCanvasGroup>d__.cg = cg;
			return <FadeOutCanvasGroup>d__;
		}

		// Token: 0x06004677 RID: 18039 RVA: 0x0017FDB9 File Offset: 0x0017DFB9
		// Note: this type is marked as 'beforefieldinit'.
		static CanvasUtil()
		{
			CanvasUtil.Fonts = new Dictionary<string, Font>();
		}

		// Token: 0x04004B44 RID: 19268
		private static Font _trajanBold;

		// Token: 0x04004B45 RID: 19269
		private static Font _trajanNormal;

		// Token: 0x04004B46 RID: 19270
		private static readonly Dictionary<string, Font> Fonts;

		/// <summary>
		///     Rectangle Helper Class
		/// </summary>
		// Token: 0x02000D57 RID: 3415
		public class RectData
		{
			/// <inheritdoc />
			/// <summary>
			///     Describes a Rectangle's relative size, shape, and relative position to it's parent.
			/// </summary>
			/// <param name="sizeDelta">
			///     sizeDelta is size of the difference of the anchors multiplied by screen size so
			///     the sizeDelta width is actually = ((anchorMax.x-anchorMin.x)*screenWidth) + sizeDelta.x
			///     so assuming a streched horizontally rectTransform on a 1920 screen, this would be
			///     ((1-0)*1920)+sizeDelta.x
			///     1920 + sizeDelta.x
			///     so if you wanted a 100pixel wide box in the center of the screen you'd do -1820, height as 1920+-1820 = 100
			///     and if you wanted a fullscreen wide box, its just 0 because 1920+0 = 1920
			///     the same applies for height
			/// </param>
			/// <param name="anchorPosition">Relative Offset Postion where Element is anchored as compared to Min / Max</param>
			// Token: 0x06004678 RID: 18040 RVA: 0x0017FDC5 File Offset: 0x0017DFC5
			public RectData(Vector2 sizeDelta, Vector2 anchorPosition) : this(sizeDelta, anchorPosition, new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f))
			{
			}

			/// <inheritdoc />
			/// <summary>
			///     Describes a Rectangle's relative size, shape, and relative position to it's parent.
			/// </summary>
			/// <param name="sizeDelta">
			///     sizeDelta is size of the difference of the anchors multiplied by screen size so
			///     the sizeDelta width is actually = ((anchorMax.x-anchorMin.x)*screenWidth) + sizeDelta.x
			///     so assuming a streched horizontally rectTransform on a 1920 screen, this would be
			///     ((1-0)*1920)+sizeDelta.x
			///     1920 + sizeDelta.x
			///     so if you wanted a 100pixel wide box in the center of the screen you'd do -1820, height as 1920+-1820 = 100
			///     and if you wanted a fullscreen wide box, its just 0 because 1920+0 = 1920
			///     the same applies for height
			/// </param>
			/// <param name="anchorPosition">Relative Offset Postion where Element is anchored as compared to Min / Max</param>
			/// <param name="min">
			///     Describes 1 corner of the rectangle
			///     0,0 = bottom left
			///     0,1 = top left
			///     1,0 = bottom right
			///     1,1 = top right
			/// </param>
			/// <param name="max">
			///     Describes 1 corner of the rectangle
			///     0,0 = bottom left
			///     0,1 = top left
			///     1,0 = bottom right
			///     1,1 = top right
			/// </param>
			// Token: 0x06004679 RID: 18041 RVA: 0x0017FDFC File Offset: 0x0017DFFC
			public RectData(Vector2 sizeDelta, Vector2 anchorPosition, Vector2 min, Vector2 max) : this(sizeDelta, anchorPosition, min, max, new Vector2(0.5f, 0.5f))
			{
			}

			/// <summary>
			///     Describes a Rectangle's relative size, shape, and relative position to it's parent.
			/// </summary>
			/// <param name="sizeDelta">
			///     sizeDelta is size of the difference of the anchors multiplied by screen size so
			///     the sizeDelta width is actually = ((anchorMax.x-anchorMin.x)*screenWidth) + sizeDelta.x
			///     so assuming a streched horizontally rectTransform on a 1920 screen, this would be
			///     ((1-0)*1920)+sizeDelta.x
			///     1920 + sizeDelta.x
			///     so if you wanted a 100pixel wide box in the center of the screen you'd do -1820, height as 1920+-1820 = 100
			///     and if you wanted a fullscreen wide box, its just 0 because 1920+0 = 1920
			///     the same applies for height
			/// </param>
			/// <param name="anchorPosition">Relative Offset Postion where Element is anchored as compared to Min / Max</param>
			/// <param name="min">
			///     Describes 1 corner of the rectangle
			///     0,0 = bottom left
			///     0,1 = top left
			///     1,0 = bottom right
			///     1,1 = top right
			/// </param>
			/// <param name="max">
			///     Describes 1 corner of the rectangle
			///     0,0 = bottom left
			///     0,1 = top left
			///     1,0 = bottom right
			///     1,1 = top right
			/// </param>
			/// <param name="pivot">Controls the location to use to rotate the rectangle if necessary.</param>
			// Token: 0x0600467A RID: 18042 RVA: 0x0017FE18 File Offset: 0x0017E018
			public RectData(Vector2 sizeDelta, Vector2 anchorPosition, Vector2 min, Vector2 max, Vector2 pivot)
			{
				this.RectSizeDelta = sizeDelta;
				this.AnchorPosition = anchorPosition;
				this.AnchorMin = min;
				this.AnchorMax = max;
				this.AnchorPivot = pivot;
			}

			/// <summary>
			///     Describes on of the X,Y Positions of the Element
			/// </summary>
			// Token: 0x04004B47 RID: 19271
			public Vector2 AnchorMax;

			/// <summary>
			///     Describes on of the X,Y Positions of the Element
			/// </summary>
			// Token: 0x04004B48 RID: 19272
			public Vector2 AnchorMin;

			/// <summary>
			/// </summary>
			// Token: 0x04004B49 RID: 19273
			public Vector2 AnchorPivot;

			/// <summary>
			///     Relative Offset Postion where Element is anchored as compared to Min / Max
			/// </summary>
			// Token: 0x04004B4A RID: 19274
			public Vector2 AnchorPosition;

			/// <summary>
			///     Difference in size of the rectangle as compared to it's parent.
			/// </summary>
			// Token: 0x04004B4B RID: 19275
			public Vector2 RectSizeDelta;
		}
	}
}
