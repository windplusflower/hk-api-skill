using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B76 RID: 2934
	[ActionCategory(ActionCategory.Debug)]
	[Tooltip("Draws a state label for this FSM in the Game View. The label is drawn on the game object that owns the FSM. Use this to override the global setting in the PlayMaker Debug menu.")]
	public class DrawStateLabel : FsmStateAction
	{
		// Token: 0x06003E62 RID: 15970 RVA: 0x00164008 File Offset: 0x00162208
		public override void Reset()
		{
			this.showLabel = true;
		}

		// Token: 0x06003E63 RID: 15971 RVA: 0x00164016 File Offset: 0x00162216
		public override void OnEnter()
		{
			base.Fsm.ShowStateLabel = this.showLabel.Value;
			base.Finish();
		}

		// Token: 0x0400426E RID: 17006
		[RequiredField]
		[Tooltip("Set to True to show State labels, or Fals to hide them.")]
		public FsmBool showLabel;
	}
}
