using System;

namespace Modding
{
	/// <summary>
	///     Methods for the logging level enum
	/// </summary>
	// Token: 0x02000D6D RID: 3437
	public static class LogLevelExt
	{
		/// <summary>
		///     Converts the logging level enum into a short string.
		/// </summary>
		/// <param name="level">The logging level</param>
		/// <returns>A 1 character string of the value of the enum</returns>
		// Token: 0x060046DF RID: 18143 RVA: 0x00180EEC File Offset: 0x0017F0EC
		public static string ToShortString(LogLevel level)
		{
			string result;
			switch (level)
			{
			case LogLevel.Fine:
				result = "F";
				break;
			case LogLevel.Debug:
				result = "D";
				break;
			case LogLevel.Info:
				result = "I";
				break;
			case LogLevel.Warn:
				result = "W";
				break;
			case LogLevel.Error:
				result = "E";
				break;
			default:
				result = "";
				break;
			}
			return result;
		}
	}
}
