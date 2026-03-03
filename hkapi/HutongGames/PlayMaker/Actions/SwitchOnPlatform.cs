using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A6D RID: 2669
	[ActionCategory("Hollow Knight")]
	[Tooltip("Change behaviour based on platform.")]
	public class SwitchOnPlatform : FsmStateAction
	{
		// Token: 0x06003990 RID: 14736 RVA: 0x0014FC05 File Offset: 0x0014DE05
		public override void Reset()
		{
			this.Standalone = null;
			this.Switch = null;
			this.PS4 = null;
			this.XB1 = null;
			this.Other = null;
		}

		// Token: 0x06003991 RID: 14737 RVA: 0x0014FC2C File Offset: 0x0014DE2C
		public override void OnEnter()
		{
			RuntimePlatform platform = Application.platform;
			if (platform <= RuntimePlatform.LinuxPlayer)
			{
				if (platform - RuntimePlatform.OSXPlayer <= 1 || platform == RuntimePlatform.LinuxPlayer)
				{
					base.Fsm.Event(this.Standalone);
					goto IL_86;
				}
			}
			else
			{
				if (platform == RuntimePlatform.PS4)
				{
					base.Fsm.Event(this.PS4);
					goto IL_86;
				}
				if (platform == RuntimePlatform.XboxOne)
				{
					base.Fsm.Event(this.XB1);
					goto IL_86;
				}
				if (platform == RuntimePlatform.Switch)
				{
					base.Fsm.Event(this.Switch);
					goto IL_86;
				}
			}
			base.Fsm.Event(this.Other);
			IL_86:
			base.Finish();
		}

		// Token: 0x04003C87 RID: 15495
		public FsmEvent Standalone;

		// Token: 0x04003C88 RID: 15496
		public FsmEvent Switch;

		// Token: 0x04003C89 RID: 15497
		public FsmEvent PS4;

		// Token: 0x04003C8A RID: 15498
		public FsmEvent XB1;

		// Token: 0x04003C8B RID: 15499
		public FsmEvent Other;
	}
}
