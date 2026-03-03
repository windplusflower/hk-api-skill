using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B66 RID: 2918
	[ActionCategory(ActionCategory.Debug)]
	[Tooltip("Sends a log message to the PlayMaker Log Window.")]
	public class DebugLog : BaseLogAction
	{
		// Token: 0x06003E2D RID: 15917 RVA: 0x00163963 File Offset: 0x00161B63
		public override void Reset()
		{
			this.logLevel = LogLevel.Info;
			this.text = "";
			base.Reset();
		}

		// Token: 0x06003E2E RID: 15918 RVA: 0x00163982 File Offset: 0x00161B82
		public override void OnEnter()
		{
			if (!string.IsNullOrEmpty(this.text.Value))
			{
				ActionHelpers.DebugLog(base.Fsm, this.logLevel, this.text.Value, this.sendToUnityLog);
			}
			base.Finish();
		}

		// Token: 0x0400424B RID: 16971
		[Tooltip("Info, Warning, or Error.")]
		public LogLevel logLevel;

		// Token: 0x0400424C RID: 16972
		[Tooltip("Text to send to the log.")]
		public FsmString text;
	}
}
