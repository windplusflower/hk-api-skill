using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Modding
{
	/// <summary>
	///     Class to hold GlobalSettings for the Modding API
	/// </summary>
	// Token: 0x02000D74 RID: 3444
	[PublicAPI]
	public class ModHooksGlobalSettings
	{
		// Token: 0x060047A8 RID: 18344 RVA: 0x001848FE File Offset: 0x00182AFE
		public ModHooksGlobalSettings()
		{
			this.ModEnabledSettings = new Dictionary<string, bool>();
			this.LoggingLevel = LogLevel.Info;
			this.ConsoleSettings = new InGameConsoleSettings();
			this.PreloadBatchSize = 5;
			this.PreloadMode = PreloadMode.RepackAssets;
			this.ModlogMaxAge = 7;
			base..ctor();
		}

		// Token: 0x04004BDD RID: 19421
		[JsonProperty]
		internal Dictionary<string, bool> ModEnabledSettings;

		/// <summary>
		///     Logging Level to use.
		/// </summary>
		// Token: 0x04004BDE RID: 19422
		public LogLevel LoggingLevel;

		/// <summary>
		///     Determines if the logs should have a short log level instead of the full name.
		/// </summary>
		// Token: 0x04004BDF RID: 19423
		public bool ShortLoggingLevel;

		/// <summary>
		///     Determines if the logs should have a timestamp attached to each line of logging.
		/// </summary>
		// Token: 0x04004BE0 RID: 19424
		public bool IncludeTimestamps;

		/// <summary>
		///     All settings related to the the in game console
		/// </summary>
		// Token: 0x04004BE1 RID: 19425
		public InGameConsoleSettings ConsoleSettings;

		/// <summary>
		///     Determines if Debug Console (Which displays Messages from Logger) should be shown.
		/// </summary>
		// Token: 0x04004BE2 RID: 19426
		public bool ShowDebugLogInGame;

		/// <summary>
		///     Determines for the preloading how many different scenes should be loaded at once.
		/// </summary>
		// Token: 0x04004BE3 RID: 19427
		public int PreloadBatchSize;

		/// <summary>
		///     Determines the strategy used for preloading game objects.
		/// </summary>
		// Token: 0x04004BE4 RID: 19428
		[JsonConverter(typeof(StringEnumConverter))]
		public PreloadMode PreloadMode;

		/// <summary>
		///     Maximum number of days to preserve modlogs for.
		/// </summary>
		// Token: 0x04004BE5 RID: 19429
		public int ModlogMaxAge;
	}
}
