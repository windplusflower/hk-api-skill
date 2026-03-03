using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009AD RID: 2477
	[ActionCategory(ActionCategory.Debug)]
	[Tooltip("Sends a log message to the Console Log Window.")]
	public class DebugLogConsole : BaseLogAction
	{
		// Token: 0x06003639 RID: 13881 RVA: 0x0013FF78 File Offset: 0x0013E178
		public override void Reset()
		{
			this.logLevel = LogLevel.Info;
			this.text = "";
			base.Reset();
		}

		// Token: 0x0600363A RID: 13882 RVA: 0x0013FF98 File Offset: 0x0013E198
		public override void OnEnter()
		{
			if (!string.IsNullOrEmpty(this.text.Value))
			{
				if (this.logLevel == LogLevel.Info)
				{
					Debug.Log(this.text.Value);
				}
				else if (this.logLevel == LogLevel.Warning)
				{
					Debug.LogWarning(this.text.Value);
				}
				else if (this.logLevel == LogLevel.Error)
				{
					Debug.LogError(this.text.Value);
				}
			}
			base.Finish();
		}

		// Token: 0x04003819 RID: 14361
		[Tooltip("Info, Warning, or Error.")]
		public LogLevel logLevel;

		// Token: 0x0400381A RID: 14362
		[Tooltip("Text to send to the log.")]
		public FsmString text;
	}
}
