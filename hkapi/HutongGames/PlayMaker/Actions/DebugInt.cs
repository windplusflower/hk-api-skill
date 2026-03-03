using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B65 RID: 2917
	[ActionCategory(ActionCategory.Debug)]
	[Tooltip("Logs the value of an Integer Variable in the PlayMaker Log Window.")]
	public class DebugInt : BaseLogAction
	{
		// Token: 0x06003E2A RID: 15914 RVA: 0x001638EA File Offset: 0x00161AEA
		public override void Reset()
		{
			this.logLevel = LogLevel.Info;
			this.intVariable = null;
		}

		// Token: 0x06003E2B RID: 15915 RVA: 0x001638FC File Offset: 0x00161AFC
		public override void OnEnter()
		{
			string text = "None";
			if (!this.intVariable.IsNone)
			{
				text = this.intVariable.Name + ": " + this.intVariable.Value.ToString();
			}
			ActionHelpers.DebugLog(base.Fsm, this.logLevel, text, this.sendToUnityLog);
			base.Finish();
		}

		// Token: 0x04004249 RID: 16969
		[Tooltip("Info, Warning, or Error.")]
		public LogLevel logLevel;

		// Token: 0x0400424A RID: 16970
		[UIHint(UIHint.Variable)]
		[Tooltip("The Int variable to debug.")]
		public FsmInt intVariable;
	}
}
