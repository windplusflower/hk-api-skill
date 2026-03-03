using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using UnityEngine;

namespace Modding
{
	/// <summary>
	///     Settins related to the in-game console
	/// </summary>
	// Token: 0x02000D66 RID: 3430
	public class InGameConsoleSettings
	{
		// Token: 0x060046B2 RID: 18098 RVA: 0x001807A4 File Offset: 0x0017E9A4
		public InGameConsoleSettings()
		{
			this.FineColor = "grey";
			this.InfoColor = "white";
			this.DebugColor = "white";
			this.WarningColor = "yellow";
			this.ErrorColor = "red";
			this.DefaultColor = "white";
			this.ToggleHotkey = KeyCode.F10;
			this.MaxMessageCount = 24;
			this.Font = "";
			this.FontSize = 12;
			base..ctor();
		}

		/// <summary>
		///     Wheter to use colors in the log console.
		/// </summary>
		// Token: 0x04004B71 RID: 19313
		public bool UseLogColors;

		/// <summary>
		///     The color to use for Fine logging when UseLogColors is enabled
		/// </summary>
		// Token: 0x04004B72 RID: 19314
		public string FineColor;

		/// <summary>
		///     The color to use for Info logging when UseLogColors is enabled
		/// </summary>
		// Token: 0x04004B73 RID: 19315
		public string InfoColor;

		/// <summary>
		///     The color to use for Debug logging when UseLogColors is enabled
		/// </summary>
		// Token: 0x04004B74 RID: 19316
		public string DebugColor;

		/// <summary>
		///     The color to use for Warning logging when UseLogColors is enabled
		/// </summary>
		// Token: 0x04004B75 RID: 19317
		public string WarningColor;

		/// <summary>
		///     The color to use for Error logging when UseLogColors is enabled
		/// </summary>
		// Token: 0x04004B76 RID: 19318
		public string ErrorColor;

		/// <summary>
		///     The color to use when UseLogColors is disabled
		/// </summary>
		// Token: 0x04004B77 RID: 19319
		public string DefaultColor;

		/// <summary>
		///     Determines the key used for toggling console
		/// </summary>
		// Token: 0x04004B78 RID: 19320
		[JsonConverter(typeof(StringEnumConverter))]
		public KeyCode ToggleHotkey;

		/// <summary>
		///     Determines the maximum messages to be diaplayed in console
		/// </summary>
		// Token: 0x04004B79 RID: 19321
		public int MaxMessageCount;

		/// <summary>
		///     Determines the system font to use for console
		/// </summary>
		// Token: 0x04004B7A RID: 19322
		public string Font;

		/// <summary>
		///     Determines the font size to use for console
		/// </summary>
		// Token: 0x04004B7B RID: 19323
		public int FontSize;
	}
}
