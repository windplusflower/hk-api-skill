using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CD4 RID: 3284
	[ActionCategory(ActionCategory.GUI)]
	[Tooltip("Controls the appearance of Mouse Cursor.")]
	public class SetMouseCursor : FsmStateAction
	{
		// Token: 0x06004452 RID: 17490 RVA: 0x0017572D File Offset: 0x0017392D
		public override void Reset()
		{
			this.cursorTexture = null;
			this.hideCursor = false;
			this.lockCursor = false;
		}

		// Token: 0x06004453 RID: 17491 RVA: 0x0017574E File Offset: 0x0017394E
		public override void OnEnter()
		{
			PlayMakerGUI.LockCursor = this.lockCursor.Value;
			PlayMakerGUI.HideCursor = this.hideCursor.Value;
			PlayMakerGUI.MouseCursor = this.cursorTexture.Value;
			base.Finish();
		}

		// Token: 0x0400489C RID: 18588
		public FsmTexture cursorTexture;

		// Token: 0x0400489D RID: 18589
		public FsmBool hideCursor;

		// Token: 0x0400489E RID: 18590
		public FsmBool lockCursor;
	}
}
