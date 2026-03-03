using System;
using GlobalEnums;
using UnityEngine;

namespace Modding
{
	/// <inheritdoc />
	/// <summary>
	///     Class to draw the version information for the mods on the main menu.
	/// </summary>
	// Token: 0x02000D87 RID: 3463
	public class ModVersionDraw : MonoBehaviour
	{
		/// <summary>
		///     Run When GameObject is first active.
		/// </summary>
		// Token: 0x060047EF RID: 18415 RVA: 0x0018640B File Offset: 0x0018460B
		private void Start()
		{
			ModVersionDraw.style.normal.textColor = Color.white;
			ModVersionDraw.style.alignment = TextAnchor.UpperLeft;
			ModVersionDraw.style.padding = new RectOffset(5, 5, 5, 5);
		}

		/// <summary>
		///     Run When Gui is shown.
		/// </summary>
		// Token: 0x060047F0 RID: 18416 RVA: 0x00186440 File Offset: 0x00184640
		public void OnGUI()
		{
			if (UIManager.instance == null)
			{
				return;
			}
			bool flag = this.drawString != null;
			if (flag)
			{
				UIState uiState = UIManager.instance.uiState;
				bool flag2 = uiState == UIState.MAIN_MENU_HOME || uiState == UIState.PAUSED;
				flag = flag2;
			}
			if (flag)
			{
				GUI.Label(new Rect(0f, 0f, (float)Screen.width, (float)Screen.height), this.drawString, ModVersionDraw.style);
			}
		}

		// Token: 0x060047F2 RID: 18418 RVA: 0x001864B1 File Offset: 0x001846B1
		// Note: this type is marked as 'beforefieldinit'.
		static ModVersionDraw()
		{
			ModVersionDraw.style = new GUIStyle(GUIStyle.none);
		}

		// Token: 0x04004C13 RID: 19475
		private static GUIStyle style;

		/// <summary>
		///     String to Draw
		/// </summary>
		// Token: 0x04004C14 RID: 19476
		public string drawString;
	}
}
