using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B48 RID: 2888
	public class CompareNames : FsmStateAction
	{
		// Token: 0x06003DB5 RID: 15797 RVA: 0x001624F3 File Offset: 0x001606F3
		public override void Reset()
		{
			this.name = new FsmString();
			this.target = new FsmEventTarget();
			this.strings = new FsmArray();
			this.trueEvent = null;
			this.falseEvent = null;
		}

		// Token: 0x06003DB6 RID: 15798 RVA: 0x00162524 File Offset: 0x00160724
		public override void OnEnter()
		{
			if (!this.name.IsNone && this.name.Value != "")
			{
				foreach (string value in this.strings.stringValues)
				{
					if (this.name.Value.Contains(value))
					{
						base.Fsm.Event(this.target, this.trueEvent);
						base.Finish();
						return;
					}
				}
				base.Fsm.Event(this.target, this.falseEvent);
			}
			base.Finish();
		}

		// Token: 0x040041CD RID: 16845
		public FsmString name;

		// Token: 0x040041CE RID: 16846
		[ArrayEditor(VariableType.String, "", 0, 0, 65536)]
		public FsmArray strings;

		// Token: 0x040041CF RID: 16847
		public FsmEventTarget target;

		// Token: 0x040041D0 RID: 16848
		public FsmEvent trueEvent;

		// Token: 0x040041D1 RID: 16849
		public FsmEvent falseEvent;
	}
}
