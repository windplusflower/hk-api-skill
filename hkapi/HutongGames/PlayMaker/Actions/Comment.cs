using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B47 RID: 2887
	[ActionCategory(ActionCategory.Debug)]
	[Tooltip("Adds a text area to the action list. NOTE: Doesn't do anything, just for notes...")]
	public class Comment : FsmStateAction
	{
		// Token: 0x06003DB2 RID: 15794 RVA: 0x001624E6 File Offset: 0x001606E6
		public override void Reset()
		{
			this.comment = "";
		}

		// Token: 0x06003DB3 RID: 15795 RVA: 0x0013ACE9 File Offset: 0x00138EE9
		public override void OnEnter()
		{
			base.Finish();
		}

		// Token: 0x040041CC RID: 16844
		[UIHint(UIHint.Comment)]
		public string comment;
	}
}
