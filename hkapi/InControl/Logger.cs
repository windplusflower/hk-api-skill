using System;

namespace InControl
{
	// Token: 0x020006E4 RID: 1764
	public class Logger
	{
		// Token: 0x14000068 RID: 104
		// (add) Token: 0x06002A84 RID: 10884 RVA: 0x000E9190 File Offset: 0x000E7390
		// (remove) Token: 0x06002A85 RID: 10885 RVA: 0x000E91C4 File Offset: 0x000E73C4
		public static event Action<LogMessage> OnLogMessage;

		// Token: 0x06002A86 RID: 10886 RVA: 0x000E91F8 File Offset: 0x000E73F8
		public static void LogInfo(string text)
		{
			if (Logger.OnLogMessage != null)
			{
				LogMessage obj = new LogMessage
				{
					text = text,
					type = LogMessageType.Info
				};
				Logger.OnLogMessage(obj);
			}
		}

		// Token: 0x06002A87 RID: 10887 RVA: 0x000E9234 File Offset: 0x000E7434
		public static void LogWarning(string text)
		{
			if (Logger.OnLogMessage != null)
			{
				LogMessage obj = new LogMessage
				{
					text = text,
					type = LogMessageType.Warning
				};
				Logger.OnLogMessage(obj);
			}
		}

		// Token: 0x06002A88 RID: 10888 RVA: 0x000E9270 File Offset: 0x000E7470
		public static void LogError(string text)
		{
			if (Logger.OnLogMessage != null)
			{
				LogMessage obj = new LogMessage
				{
					text = text,
					type = LogMessageType.Error
				};
				Logger.OnLogMessage(obj);
			}
		}
	}
}
