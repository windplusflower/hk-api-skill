using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B61 RID: 2913
	[ActionCategory(ActionCategory.Debug)]
	[Tooltip("Logs the value of an Enum Variable in the PlayMaker Log Window.")]
	public class DebugEnum : BaseLogAction
	{
		// Token: 0x06003E1E RID: 15902 RVA: 0x00163727 File Offset: 0x00161927
		public override void Reset()
		{
			this.logLevel = LogLevel.Info;
			this.enumVariable = null;
			base.Reset();
		}

		// Token: 0x06003E1F RID: 15903 RVA: 0x00163740 File Offset: 0x00161940
		public override void OnEnter()
		{
			string text = "None";
			if (!this.enumVariable.IsNone)
			{
				string name = this.enumVariable.Name;
				string str = ": ";
				Enum value = this.enumVariable.Value;
				text = name + str + ((value != null) ? value.ToString() : null);
			}
			ActionHelpers.DebugLog(base.Fsm, this.logLevel, text, this.sendToUnityLog);
			base.Finish();
		}

		// Token: 0x04004241 RID: 16961
		[Tooltip("Info, Warning, or Error.")]
		public LogLevel logLevel;

		// Token: 0x04004242 RID: 16962
		[UIHint(UIHint.Variable)]
		[Tooltip("The Enum Variable to debug.")]
		public FsmEnum enumVariable;
	}
}
