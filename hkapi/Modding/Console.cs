using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

namespace Modding
{
	// Token: 0x02000D5C RID: 3420
	internal class Console : MonoBehaviour
	{
		// Token: 0x0600468B RID: 18059 RVA: 0x001800D4 File Offset: 0x0017E2D4
		[PublicAPI]
		public void Start()
		{
			this.LoadSettings();
			if (Console._font == null)
			{
				Console._font = Font.CreateDynamicFontFromOSFont(Console.OSFonts, this._fontSize);
			}
			if (Console._font == null)
			{
				Console._font = (Resources.GetBuiltinResource(typeof(Font), "Arial.ttf") as Font);
			}
			UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
			if (Console._overlayCanvas != null)
			{
				return;
			}
			Console._overlayCanvas = CanvasUtil.CreateCanvas(RenderMode.ScreenSpaceOverlay, new Vector2(1920f, 1080f));
			Console._overlayCanvas.name = "ModdingApiConsoleLog";
			CanvasGroup component = Console._overlayCanvas.GetComponent<CanvasGroup>();
			component.interactable = false;
			component.blocksRaycasts = false;
			UnityEngine.Object.DontDestroyOnLoad(Console._overlayCanvas);
			GameObject overlayCanvas = Console._overlayCanvas;
			byte[] array = new byte[4];
			array[0] = 128;
			Console._textPanel = CanvasUtil.CreateTextPanel(CanvasUtil.CreateImagePanel(overlayCanvas, CanvasUtil.NullSprite(array), new CanvasUtil.RectData(new Vector2(500f, 800f), Vector2.zero, Vector2.zero, Vector2.zero, Vector2.zero)), string.Join(string.Empty, this._messages.ToArray()), this._fontSize, TextAnchor.LowerLeft, new CanvasUtil.RectData(new Vector2(-5f, -5f), Vector2.zero, Vector2.zero, Vector2.one), Console._font);
			Console._textPanel.GetComponent<Text>().horizontalOverflow = HorizontalWrapMode.Wrap;
		}

		// Token: 0x0600468C RID: 18060 RVA: 0x0018023C File Offset: 0x0017E43C
		private void LoadSettings()
		{
			InGameConsoleSettings consoleSettings = ModHooks.GlobalSettings.ConsoleSettings;
			this._toggleKey = consoleSettings.ToggleHotkey;
			if (this._toggleKey == KeyCode.Escape)
			{
				Logger.APILogger.LogError("Esc cannot be used as hotkey for console togging");
				this._toggleKey = (consoleSettings.ToggleHotkey = KeyCode.F10);
			}
			this._maxMessageCount = consoleSettings.MaxMessageCount;
			if (this._maxMessageCount <= 0)
			{
				Logger.APILogger.LogError(string.Format("Specified max console message count {0} is invalid", this._maxMessageCount));
				this._maxMessageCount = (consoleSettings.MaxMessageCount = 24);
			}
			this._fontSize = consoleSettings.FontSize;
			if (this._fontSize <= 0)
			{
				Logger.APILogger.LogError(string.Format("Specified console font size {0} is invalid", this._fontSize));
				this._fontSize = (consoleSettings.FontSize = 12);
			}
			string font = consoleSettings.Font;
			if (string.IsNullOrEmpty(font))
			{
				return;
			}
			Console._font = Font.CreateDynamicFontFromOSFont(font, this._fontSize);
			if (Console._font == null)
			{
				Logger.APILogger.LogError("Specified font " + font + " not found.");
			}
		}

		// Token: 0x0600468D RID: 18061 RVA: 0x00180360 File Offset: 0x0017E560
		[PublicAPI]
		public void Update()
		{
			if (!Input.GetKeyDown(this._toggleKey))
			{
				return;
			}
			base.StartCoroutine(this._enabled ? CanvasUtil.FadeOutCanvasGroup(Console._overlayCanvas.GetComponent<CanvasGroup>()) : CanvasUtil.FadeInCanvasGroup(Console._overlayCanvas.GetComponent<CanvasGroup>()));
			this._enabled = !this._enabled;
		}

		// Token: 0x0600468E RID: 18062 RVA: 0x001803BC File Offset: 0x0017E5BC
		public void AddText(string message, LogLevel level)
		{
			IEnumerable<string> enumerable = Console.Chunks(message, 80);
			string text = "<color=" + ModHooks.GlobalSettings.ConsoleSettings.DefaultColor + ">";
			if (ModHooks.GlobalSettings.ConsoleSettings.UseLogColors)
			{
				string text2;
				switch (level)
				{
				case LogLevel.Fine:
					text2 = "<color=" + ModHooks.GlobalSettings.ConsoleSettings.FineColor + ">";
					break;
				case LogLevel.Debug:
					text2 = "<color=" + ModHooks.GlobalSettings.ConsoleSettings.DebugColor + ">";
					break;
				case LogLevel.Info:
					text2 = "<color=" + ModHooks.GlobalSettings.ConsoleSettings.InfoColor + ">";
					break;
				case LogLevel.Warn:
					text2 = "<color=" + ModHooks.GlobalSettings.ConsoleSettings.WarningColor + ">";
					break;
				case LogLevel.Error:
					text2 = "<color=" + ModHooks.GlobalSettings.ConsoleSettings.ErrorColor + ">";
					break;
				default:
					text2 = text;
					break;
				}
				text = text2;
			}
			using (IEnumerator<string> enumerator = enumerable.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					string str = enumerator.Current;
					this._messages.Add(text + str + "</color>");
				}
				goto IL_150;
			}
			IL_144:
			this._messages.RemoveAt(0);
			IL_150:
			if (this._messages.Count <= this._maxMessageCount)
			{
				if (Console._textPanel != null)
				{
					Console._textPanel.GetComponent<Text>().text = string.Join(string.Empty, this._messages.ToArray());
				}
				return;
			}
			goto IL_144;
		}

		// Token: 0x0600468F RID: 18063 RVA: 0x00180570 File Offset: 0x0017E770
		private static IEnumerable<string> Chunks(string str, int maxChunkSize)
		{
			Console.<Chunks>d__14 <Chunks>d__ = new Console.<Chunks>d__14(-2);
			<Chunks>d__.<>3__str = str;
			<Chunks>d__.<>3__maxChunkSize = maxChunkSize;
			return <Chunks>d__;
		}

		// Token: 0x06004690 RID: 18064 RVA: 0x00180587 File Offset: 0x0017E787
		public Console()
		{
			this._enabled = true;
			this._messages = new List<string>(25);
			this._toggleKey = KeyCode.F10;
			this._maxMessageCount = 25;
			this._fontSize = 12;
			base..ctor();
		}

		// Token: 0x06004691 RID: 18065 RVA: 0x001805BE File Offset: 0x0017E7BE
		// Note: this type is marked as 'beforefieldinit'.
		static Console()
		{
			Console.OSFonts = new string[]
			{
				"Consolas",
				"Menlo",
				"Courier New",
				"DejaVu Mono"
			};
		}

		// Token: 0x04004B57 RID: 19287
		private static GameObject _overlayCanvas;

		// Token: 0x04004B58 RID: 19288
		private static GameObject _textPanel;

		// Token: 0x04004B59 RID: 19289
		private static Font _font;

		// Token: 0x04004B5A RID: 19290
		private bool _enabled;

		// Token: 0x04004B5B RID: 19291
		private readonly List<string> _messages;

		// Token: 0x04004B5C RID: 19292
		private KeyCode _toggleKey;

		// Token: 0x04004B5D RID: 19293
		private int _maxMessageCount;

		// Token: 0x04004B5E RID: 19294
		private int _fontSize;

		// Token: 0x04004B5F RID: 19295
		private const int MSG_LENGTH = 80;

		// Token: 0x04004B60 RID: 19296
		private static readonly string[] OSFonts;
	}
}
