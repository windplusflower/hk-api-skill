using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000998 RID: 2456
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("Flips the value of a Bool Variable.")]
	public class BoolFlipEveryFrame : FsmStateAction
	{
		// Token: 0x060035D4 RID: 13780 RVA: 0x0013DA93 File Offset: 0x0013BC93
		public override void Reset()
		{
			this.boolVariable = null;
			this.everyFrame = false;
		}

		// Token: 0x060035D5 RID: 13781 RVA: 0x0013DAA3 File Offset: 0x0013BCA3
		public override void OnEnter()
		{
			this.DoFlip();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060035D6 RID: 13782 RVA: 0x0013DAB9 File Offset: 0x0013BCB9
		public override void OnUpdate()
		{
			this.DoFlip();
		}

		// Token: 0x060035D7 RID: 13783 RVA: 0x0013DAC1 File Offset: 0x0013BCC1
		private void DoFlip()
		{
			this.boolVariable.Value = !this.boolVariable.Value;
		}

		// Token: 0x0400376F RID: 14191
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Bool variable to flip.")]
		public FsmBool boolVariable;

		// Token: 0x04003770 RID: 14192
		public bool everyFrame;
	}
}
