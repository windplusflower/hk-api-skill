using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B68 RID: 2920
	[ActionCategory(ActionCategory.Debug)]
	[Tooltip("Logs the value of a Vector2 Variable in the PlayMaker Log Window.")]
	public class DebugVector2 : FsmStateAction
	{
		// Token: 0x06003E33 RID: 15923 RVA: 0x00163A3A File Offset: 0x00161C3A
		public override void Reset()
		{
			this.logLevel = LogLevel.Info;
			this.vector2Variable = null;
		}

		// Token: 0x06003E34 RID: 15924 RVA: 0x00163A4C File Offset: 0x00161C4C
		public override void OnEnter()
		{
			string text = "None";
			if (!this.vector2Variable.IsNone)
			{
				text = this.vector2Variable.Name + ": " + this.vector2Variable.Value.ToString();
			}
			ActionHelpers.DebugLog(base.Fsm, this.logLevel, text, false);
			base.Finish();
		}

		// Token: 0x0400424F RID: 16975
		[Tooltip("Info, Warning, or Error.")]
		public LogLevel logLevel;

		// Token: 0x04004250 RID: 16976
		[UIHint(UIHint.Variable)]
		[Tooltip("Prints the value of a Vector2 variable in the PlayMaker log window.")]
		public FsmVector2 vector2Variable;
	}
}
