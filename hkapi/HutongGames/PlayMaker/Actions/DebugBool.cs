using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B5E RID: 2910
	[ActionCategory(ActionCategory.Debug)]
	[Tooltip("Logs the value of a Bool Variable in the PlayMaker Log Window.")]
	public class DebugBool : BaseLogAction
	{
		// Token: 0x06003E18 RID: 15896 RVA: 0x00163595 File Offset: 0x00161795
		public override void Reset()
		{
			this.logLevel = LogLevel.Info;
			this.boolVariable = null;
			base.Reset();
		}

		// Token: 0x06003E19 RID: 15897 RVA: 0x001635AC File Offset: 0x001617AC
		public override void OnEnter()
		{
			string text = "None";
			if (!this.boolVariable.IsNone)
			{
				text = this.boolVariable.Name + ": " + this.boolVariable.Value.ToString();
			}
			ActionHelpers.DebugLog(base.Fsm, this.logLevel, text, this.sendToUnityLog);
			base.Finish();
		}

		// Token: 0x04004235 RID: 16949
		[Tooltip("Info, Warning, or Error.")]
		public LogLevel logLevel;

		// Token: 0x04004236 RID: 16950
		[UIHint(UIHint.Variable)]
		[Tooltip("The Bool variable to debug.")]
		public FsmBool boolVariable;
	}
}
