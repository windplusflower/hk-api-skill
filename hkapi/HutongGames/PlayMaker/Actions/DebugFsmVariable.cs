using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B63 RID: 2915
	[ActionCategory(ActionCategory.Debug)]
	[Tooltip("Print the value of any FSM Variable in the PlayMaker Log Window.")]
	public class DebugFsmVariable : BaseLogAction
	{
		// Token: 0x06003E24 RID: 15908 RVA: 0x0016382B File Offset: 0x00161A2B
		public override void Reset()
		{
			this.logLevel = LogLevel.Info;
			this.variable = null;
			base.Reset();
		}

		// Token: 0x06003E25 RID: 15909 RVA: 0x00163841 File Offset: 0x00161A41
		public override void OnEnter()
		{
			ActionHelpers.DebugLog(base.Fsm, this.logLevel, this.variable.DebugString(), this.sendToUnityLog);
			base.Finish();
		}

		// Token: 0x04004245 RID: 16965
		[Tooltip("Info, Warning, or Error.")]
		public LogLevel logLevel;

		// Token: 0x04004246 RID: 16966
		[HideTypeFilter]
		[UIHint(UIHint.Variable)]
		[Tooltip("The variable to debug.")]
		public FsmVar variable;
	}
}
