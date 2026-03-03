using System;
using JetBrains.Annotations;

namespace Modding
{
	/// <summary>
	///     Logging Utility
	/// </summary>
	// Token: 0x02000D5F RID: 3423
	[PublicAPI]
	public interface ILogger
	{
		/// <summary>
		///     Log at the info level.  Includes the Mod's name in the output.
		/// </summary>
		/// <param name="message">Message to log</param>
		// Token: 0x0600469B RID: 18075
		void Log(string message);

		/// <summary>
		///     Log at the info level.  Includes the Mod's name in the output.
		/// </summary>
		/// <param name="message">Message to log</param>
		// Token: 0x0600469C RID: 18076
		void Log(object message);

		/// <summary>
		///     Log at the debug level.  Includes the Mod's name in the output.
		/// </summary>
		/// <param name="message">Message to log</param>
		// Token: 0x0600469D RID: 18077
		void LogDebug(string message);

		/// <summary>
		///     Log at the debug level.  Includes the Mod's name in the output.
		/// </summary>
		/// <param name="message">Message to log</param>
		// Token: 0x0600469E RID: 18078
		void LogDebug(object message);

		/// <summary>
		///     Log at the error level.  Includes the Mod's name in the output.
		/// </summary>
		/// <param name="message">Message to log</param>
		// Token: 0x0600469F RID: 18079
		void LogError(string message);

		/// <summary>
		///     Log at the error level.  Includes the Mod's name in the output.
		/// </summary>
		/// <param name="message">Message to log</param>
		// Token: 0x060046A0 RID: 18080
		void LogError(object message);

		/// <summary>
		///     Log at the fine level.  Includes the Mod's name in the output.
		/// </summary>
		/// <param name="message">Message to log</param>
		// Token: 0x060046A1 RID: 18081
		void LogFine(string message);

		/// <summary>
		///     Log at the fine level.  Includes the Mod's name in the output.
		/// </summary>
		/// <param name="message">Message to log</param>
		// Token: 0x060046A2 RID: 18082
		void LogFine(object message);

		/// <summary>
		///     Log at the warn level.  Includes the Mod's name in the output.
		/// </summary>
		/// <param name="message">Message to log</param>
		// Token: 0x060046A3 RID: 18083
		void LogWarn(string message);

		/// <summary>
		///     Log at the warn level.  Includes the Mod's name in the output.
		/// </summary>
		/// <param name="message">Message to log</param>
		// Token: 0x060046A4 RID: 18084
		void LogWarn(object message);
	}
}
