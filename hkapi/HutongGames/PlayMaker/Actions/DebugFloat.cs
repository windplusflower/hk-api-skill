using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B62 RID: 2914
	[ActionCategory(ActionCategory.Debug)]
	[Tooltip("Logs the value of a Float Variable in the PlayMaker Log Window.")]
	public class DebugFloat : BaseLogAction
	{
		// Token: 0x06003E21 RID: 15905 RVA: 0x001637AB File Offset: 0x001619AB
		public override void Reset()
		{
			this.logLevel = LogLevel.Info;
			this.floatVariable = null;
			base.Reset();
		}

		// Token: 0x06003E22 RID: 15906 RVA: 0x001637C4 File Offset: 0x001619C4
		public override void OnEnter()
		{
			string text = "None";
			if (!this.floatVariable.IsNone)
			{
				text = this.floatVariable.Name + ": " + this.floatVariable.Value.ToString();
			}
			ActionHelpers.DebugLog(base.Fsm, this.logLevel, text, this.sendToUnityLog);
			base.Finish();
		}

		// Token: 0x04004243 RID: 16963
		[Tooltip("Info, Warning, or Error.")]
		public LogLevel logLevel;

		// Token: 0x04004244 RID: 16964
		[UIHint(UIHint.Variable)]
		[Tooltip("The Float variable to debug.")]
		public FsmFloat floatVariable;
	}
}
