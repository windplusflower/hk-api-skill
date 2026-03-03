using System;

namespace Modding
{
	/// <inheritdoc />
	/// <summary>
	///     Base class that allows other classes to have context specific logging
	/// </summary>
	// Token: 0x02000D69 RID: 3433
	public abstract class Loggable : ILogger
	{
		/// <summary>
		///     Basic setup for Loggable.
		/// </summary>
		// Token: 0x060046BB RID: 18107 RVA: 0x00180A3F File Offset: 0x0017EC3F
		protected Loggable()
		{
			this.ClassName = base.GetType().Name;
		}

		/// <inheritdoc />
		/// <summary>
		///     Log at the fine/detailed level.  Includes the Mod's name in the output.
		/// </summary>
		/// <param name="message">Message to log</param>
		// Token: 0x060046BC RID: 18108 RVA: 0x00180A58 File Offset: 0x0017EC58
		public void LogFine(string message)
		{
			Logger.LogFine(this.FormatLogMessage(message));
		}

		/// <inheritdoc />
		/// <summary>
		///     Log at the fine/detailed level.  Includes the Mod's name in the output.
		/// </summary>
		/// <param name="message">Message to log</param>
		// Token: 0x060046BD RID: 18109 RVA: 0x00180A66 File Offset: 0x0017EC66
		public void LogFine(object message)
		{
			Logger.LogFine(this.FormatLogMessage(message));
		}

		/// <inheritdoc />
		/// <summary>
		///     Log at the debug level.  Includes the Mod's name in the output.
		/// </summary>
		/// <param name="message">Message to log</param>
		// Token: 0x060046BE RID: 18110 RVA: 0x00180A74 File Offset: 0x0017EC74
		public void LogDebug(string message)
		{
			Logger.LogDebug(this.FormatLogMessage(message));
		}

		/// <inheritdoc />
		/// <summary>
		///     Log at the debug level.  Includes the Mod's name in the output.
		/// </summary>
		/// <param name="message">Message to log</param>
		// Token: 0x060046BF RID: 18111 RVA: 0x00180A82 File Offset: 0x0017EC82
		public void LogDebug(object message)
		{
			Logger.LogDebug(this.FormatLogMessage(message));
		}

		/// <inheritdoc />
		/// <summary>
		///     Log at the info level.  Includes the Mod's name in the output.
		/// </summary>
		/// <param name="message">Message to log</param>
		// Token: 0x060046C0 RID: 18112 RVA: 0x00180A90 File Offset: 0x0017EC90
		public void Log(string message)
		{
			Logger.Log(this.FormatLogMessage(message));
		}

		/// <inheritdoc />
		/// <summary>
		///     Log at the info level.  Includes the Mod's name in the output.
		/// </summary>
		/// <param name="message">Message to log</param>
		// Token: 0x060046C1 RID: 18113 RVA: 0x00180A9E File Offset: 0x0017EC9E
		public void Log(object message)
		{
			Logger.Log(this.FormatLogMessage(message));
		}

		/// <inheritdoc />
		/// <summary>
		///     Log at the warn level.  Includes the Mod's name in the output.
		/// </summary>
		/// <param name="message">Message to log</param>
		// Token: 0x060046C2 RID: 18114 RVA: 0x00180AAC File Offset: 0x0017ECAC
		public void LogWarn(string message)
		{
			Logger.LogWarn(this.FormatLogMessage(message));
		}

		/// <inheritdoc />
		/// <summary>
		///     Log at the warn level.  Includes the Mod's name in the output.
		/// </summary>
		/// <param name="message">Message to log</param>
		// Token: 0x060046C3 RID: 18115 RVA: 0x00180ABA File Offset: 0x0017ECBA
		public void LogWarn(object message)
		{
			Logger.LogWarn(this.FormatLogMessage(message));
		}

		/// <inheritdoc />
		/// <summary>
		///     Log at the error level.  Includes the Mod's name in the output.
		/// </summary>
		/// <param name="message">Message to log</param>
		// Token: 0x060046C4 RID: 18116 RVA: 0x00180AC8 File Offset: 0x0017ECC8
		public void LogError(string message)
		{
			Logger.LogError(this.FormatLogMessage(message));
		}

		/// <inheritdoc />
		/// <summary>
		///     Log at the error level.  Includes the Mod's name in the output.
		/// </summary>
		/// <param name="message">Message to log</param>
		// Token: 0x060046C5 RID: 18117 RVA: 0x00180AD6 File Offset: 0x0017ECD6
		public void LogError(object message)
		{
			Logger.LogError(this.FormatLogMessage(message));
		}

		/// <summary>
		///     Formats a log message as "[TypeName] - Message"
		/// </summary>
		/// <param name="message">Message to be formatted.</param>
		/// <returns>Formatted Message</returns>
		// Token: 0x060046C6 RID: 18118 RVA: 0x00180AE4 File Offset: 0x0017ECE4
		private string FormatLogMessage(string message)
		{
			return ("[" + this.ClassName + "] - " + message).Replace("\n", "\n[" + this.ClassName + "] - ");
		}

		/// <summary>
		///     Formats a log message as "[TypeName] - Message"
		/// </summary>
		/// <param name="message">Message to be formatted.</param>
		/// <returns>Formatted Message</returns>
		// Token: 0x060046C7 RID: 18119 RVA: 0x00180B1B File Offset: 0x0017ED1B
		private string FormatLogMessage(object message)
		{
			return this.FormatLogMessage(((message != null) ? message.ToString() : null) ?? "null");
		}

		// Token: 0x04004B7D RID: 19325
		internal string ClassName;
	}
}
