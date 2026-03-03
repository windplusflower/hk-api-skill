using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using JetBrains.Annotations;
using UnityEngine;

namespace Modding
{
	/// <summary>
	///     Shared logger for mods to use.
	/// </summary>
	// Token: 0x02000D6A RID: 3434
	[PublicAPI]
	public static class Logger
	{
		// Token: 0x060046C8 RID: 18120 RVA: 0x00180B38 File Offset: 0x0017ED38
		internal static void InitializeFileStream()
		{
			Debug.Log("Creating Mod Logger");
			Logger._logLevel = LogLevel.Debug;
			Directory.CreateDirectory(Logger.OldLogDir);
			string path = Path.Combine(Application.persistentDataPath, "ModLog.txt");
			Logger.BackupLog(path, Logger.OldLogDir);
			FileStream stream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
			object locker = Logger.Locker;
			lock (locker)
			{
				Logger.Writer = new StreamWriter(stream, Encoding.UTF8)
				{
					AutoFlush = true
				};
			}
			File.SetCreationTimeUtc(path, DateTime.UtcNow);
		}

		// Token: 0x060046C9 RID: 18121 RVA: 0x00180BD4 File Offset: 0x0017EDD4
		private static void BackupLog(string path, string dir)
		{
			if (!File.Exists(path))
			{
				return;
			}
			string str = File.GetCreationTimeUtc(path).ToString("MM dd yyyy (HH mm ss)", CultureInfo.InvariantCulture);
			File.Move(path, Path.Combine(dir, "ModLog " + str + ".txt"));
		}

		// Token: 0x060046CA RID: 18122 RVA: 0x00180C20 File Offset: 0x0017EE20
		internal static void ClearOldModlogs()
		{
			string path = Path.Combine(Application.persistentDataPath, "Old ModLogs");
			Logger.APILogger.Log(string.Format("Deleting modlogs older than {0} days ago", ModHooks.GlobalSettings.ModlogMaxAge));
			DateTime limit = DateTime.UtcNow.AddDays((double)(-(double)ModHooks.GlobalSettings.ModlogMaxAge));
			IEnumerable<string> files = Directory.GetFiles(path);
			Func<string, bool> <>9__0;
			Func<string, bool> predicate;
			if ((predicate = <>9__0) == null)
			{
				predicate = (<>9__0 = ((string f) => File.GetCreationTimeUtc(f) < limit));
			}
			foreach (string path2 in files.Where(predicate))
			{
				File.Delete(path2);
			}
		}

		// Token: 0x060046CB RID: 18123 RVA: 0x00180CE4 File Offset: 0x0017EEE4
		internal static void SetLogLevel(LogLevel level)
		{
			Logger._logLevel = level;
		}

		// Token: 0x060046CC RID: 18124 RVA: 0x00180CEC File Offset: 0x0017EEEC
		internal static void SetUseShortLogLevel(bool value)
		{
			Logger._shortLoggingLevel = value;
		}

		// Token: 0x060046CD RID: 18125 RVA: 0x00180CF4 File Offset: 0x0017EEF4
		internal static void SetIncludeTimestampt(bool value)
		{
			Logger._includeTimestamps = value;
		}

		/// <summary>
		///     Checks to ensure that the logger level is currently high enough for this message, if it is, write it.
		/// </summary>
		/// <param name="message">Message to log</param>
		/// <param name="level">Level of Log</param>
		// Token: 0x060046CE RID: 18126 RVA: 0x00180CFC File Offset: 0x0017EEFC
		public static void Log(string message, LogLevel level)
		{
			if (Logger._logLevel > level)
			{
				return;
			}
			string str = "[" + DateTime.Now.ToUniversalTime().ToString("HH:mm:ss") + "]:";
			string text = Logger._shortLoggingLevel ? ("[" + LogLevelExt.ToShortString(level).ToUpper() + "]:") : ("[" + level.ToString().ToUpper() + "]:");
			Logger.WriteToFile(Logger.ExpandLines(Logger._includeTimestamps ? (str + text) : text, message), level);
		}

		/// <summary>
		/// Returns a copy of <paramref name="message" /> with the string <paramref name="prefixText" /> prepended to each line.
		/// </summary>
		/// <param name="prefixText">The prefix text.</param>
		/// <param name="message">The message.</param>
		// Token: 0x060046CF RID: 18127 RVA: 0x00180DA0 File Offset: 0x0017EFA0
		private static string ExpandLines(string prefixText, string message)
		{
			string[] value = message.Split(new string[]
			{
				"\r\n",
				"\n"
			}, StringSplitOptions.None);
			return prefixText + string.Join(Environment.NewLine + prefixText, value) + Environment.NewLine;
		}

		/// <summary>
		///     Checks to ensure that the logger level is currently high enough for this message, if it is, write it.
		/// </summary>
		/// <param name="message">Message to log</param>
		/// <param name="level">Level of Log</param>
		// Token: 0x060046D0 RID: 18128 RVA: 0x00180DE7 File Offset: 0x0017EFE7
		public static void Log(object message, LogLevel level)
		{
			Logger.Log(message.ToString(), level);
		}

		/// <summary>
		///     Finest/Lowest level of logging.  Usually reserved for developmental testing.
		/// </summary>
		/// <param name="message">Message to log</param>
		// Token: 0x060046D1 RID: 18129 RVA: 0x00180DF5 File Offset: 0x0017EFF5
		public static void LogFine(string message)
		{
			Logger.Log(message, LogLevel.Fine);
		}

		/// <summary>
		///     Finest/Lowest level of logging.  Usually reserved for developmental testing.
		/// </summary>
		/// <param name="message">Message to log</param>
		// Token: 0x060046D2 RID: 18130 RVA: 0x00180DFE File Offset: 0x0017EFFE
		public static void LogFine(object message)
		{
			Logger.Log(message.ToString(), LogLevel.Fine);
		}

		/// <summary>
		///     Log at the debug level.  Usually reserved for diagnostics.
		/// </summary>
		/// <param name="message">Message to log</param>
		// Token: 0x060046D3 RID: 18131 RVA: 0x00180E0C File Offset: 0x0017F00C
		public static void LogDebug(string message)
		{
			Logger.Log(message, LogLevel.Debug);
		}

		/// <summary>
		///     Log at the debug level.  Usually reserved for diagnostics.
		/// </summary>
		/// <param name="message">Message to log</param>
		// Token: 0x060046D4 RID: 18132 RVA: 0x00180E15 File Offset: 0x0017F015
		public static void LogDebug(object message)
		{
			Logger.Log(message, LogLevel.Debug);
		}

		/// <summary>
		///     Log at the info level.
		/// </summary>
		/// <param name="message">Message to log</param>
		// Token: 0x060046D5 RID: 18133 RVA: 0x00180E1E File Offset: 0x0017F01E
		public static void Log(string message)
		{
			Logger.Log(message, LogLevel.Info);
		}

		/// <summary>
		///     Log at the info level.
		/// </summary>
		/// <param name="message">Message to log</param>
		// Token: 0x060046D6 RID: 18134 RVA: 0x00180E27 File Offset: 0x0017F027
		public static void Log(object message)
		{
			Logger.Log(message, LogLevel.Info);
		}

		/// <summary>
		///     Log at the warning level.
		/// </summary>
		/// <param name="message">Message to log</param>
		// Token: 0x060046D7 RID: 18135 RVA: 0x00180E30 File Offset: 0x0017F030
		public static void LogWarn(string message)
		{
			Logger.Log(message, LogLevel.Warn);
		}

		/// <summary>
		///     Log at the warning level.
		/// </summary>
		/// <param name="message">Message to log</param>
		// Token: 0x060046D8 RID: 18136 RVA: 0x00180E39 File Offset: 0x0017F039
		public static void LogWarn(object message)
		{
			Logger.Log(message, LogLevel.Warn);
		}

		/// <summary>
		///     Log at the error level.
		/// </summary>
		/// <param name="message">Message to log</param>
		// Token: 0x060046D9 RID: 18137 RVA: 0x00180E42 File Offset: 0x0017F042
		public static void LogError(string message)
		{
			Logger.Log(message, LogLevel.Error);
		}

		/// <summary>
		///     Log at the error level.
		/// </summary>
		/// <param name="message">Message to log</param>
		// Token: 0x060046DA RID: 18138 RVA: 0x00180E4B File Offset: 0x0017F04B
		public static void LogError(object message)
		{
			Logger.Log(message, LogLevel.Error);
		}

		/// <summary>
		///     Locks file to write, writes to file, releases lock.
		/// </summary>
		/// <param name="text">Text to write</param>
		/// <param name="level">Level of Log</param>
		// Token: 0x060046DB RID: 18139 RVA: 0x00180E54 File Offset: 0x0017F054
		private static void WriteToFile(string text, LogLevel level)
		{
			object locker = Logger.Locker;
			lock (locker)
			{
				ModHooks.LogConsole(text, level);
				StreamWriter writer = Logger.Writer;
				if (writer != null)
				{
					writer.Write(text);
				}
			}
		}

		// Token: 0x060046DC RID: 18140 RVA: 0x00180EA8 File Offset: 0x0017F0A8
		// Note: this type is marked as 'beforefieldinit'.
		static Logger()
		{
			Logger.Locker = new object();
			Logger.OldLogDir = Path.Combine(Application.persistentDataPath, "Old ModLogs");
			Logger.APILogger = new SimpleLogger("API");
		}

		// Token: 0x04004B7E RID: 19326
		private static readonly object Locker;

		// Token: 0x04004B7F RID: 19327
		private static StreamWriter Writer;

		// Token: 0x04004B80 RID: 19328
		private static LogLevel _logLevel;

		// Token: 0x04004B81 RID: 19329
		private static bool _shortLoggingLevel;

		// Token: 0x04004B82 RID: 19330
		private static bool _includeTimestamps;

		// Token: 0x04004B83 RID: 19331
		private static string OldLogDir;

		// Token: 0x04004B84 RID: 19332
		internal static readonly SimpleLogger APILogger;
	}
}
