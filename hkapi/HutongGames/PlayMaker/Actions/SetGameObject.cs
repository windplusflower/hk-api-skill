using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CBD RID: 3261
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Sets the value of a Game Object Variable.")]
	public class SetGameObject : FsmStateAction
	{
		// Token: 0x060043EF RID: 17391 RVA: 0x001749C0 File Offset: 0x00172BC0
		public override void Reset()
		{
			this.variable = null;
			this.gameObject = null;
			this.everyFrame = false;
		}

		// Token: 0x060043F0 RID: 17392 RVA: 0x001749D7 File Offset: 0x00172BD7
		public override void OnEnter()
		{
			this.variable.Value = this.gameObject.Value;
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060043F1 RID: 17393 RVA: 0x001749FD File Offset: 0x00172BFD
		public override void OnUpdate()
		{
			this.variable.Value = this.gameObject.Value;
		}

		// Token: 0x04004857 RID: 18519
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmGameObject variable;

		// Token: 0x04004858 RID: 18520
		public FsmGameObject gameObject;

		// Token: 0x04004859 RID: 18521
		public bool everyFrame;
	}
}
