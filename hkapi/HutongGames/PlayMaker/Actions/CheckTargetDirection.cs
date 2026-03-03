using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009A7 RID: 2471
	[ActionCategory("Enemy AI")]
	[Tooltip("Check whether target is left/right/up/down relative to object")]
	public class CheckTargetDirection : FsmStateAction
	{
		// Token: 0x06003621 RID: 13857 RVA: 0x0013F8BC File Offset: 0x0013DABC
		public override void Reset()
		{
			this.gameObject = null;
			this.target = null;
			this.everyFrame = false;
		}

		// Token: 0x06003622 RID: 13858 RVA: 0x0013F8D3 File Offset: 0x0013DAD3
		public override void OnEnter()
		{
			this.self = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			this.DoCheckDirection();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003623 RID: 13859 RVA: 0x0013F905 File Offset: 0x0013DB05
		public override void OnUpdate()
		{
			this.DoCheckDirection();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003624 RID: 13860 RVA: 0x0013F91C File Offset: 0x0013DB1C
		private void DoCheckDirection()
		{
			float num = this.self.Value.transform.position.x;
			float num2 = this.self.Value.transform.position.y;
			float num3 = this.target.Value.transform.position.x;
			float num4 = this.target.Value.transform.position.y;
			if (num < num3)
			{
				base.Fsm.Event(this.rightEvent);
				this.rightBool.Value = true;
			}
			else
			{
				this.rightBool.Value = false;
			}
			if (num > num3)
			{
				base.Fsm.Event(this.leftEvent);
				this.leftBool.Value = true;
			}
			else
			{
				this.leftBool.Value = false;
			}
			if (num2 < num4)
			{
				base.Fsm.Event(this.aboveEvent);
				this.aboveBool.Value = true;
			}
			else
			{
				this.aboveBool.Value = false;
			}
			if (num2 > num4)
			{
				base.Fsm.Event(this.belowEvent);
				this.belowBool.Value = true;
				return;
			}
			this.belowBool.Value = false;
		}

		// Token: 0x040037F4 RID: 14324
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x040037F5 RID: 14325
		[RequiredField]
		public FsmGameObject target;

		// Token: 0x040037F6 RID: 14326
		public FsmEvent aboveEvent;

		// Token: 0x040037F7 RID: 14327
		public FsmEvent belowEvent;

		// Token: 0x040037F8 RID: 14328
		public FsmEvent rightEvent;

		// Token: 0x040037F9 RID: 14329
		public FsmEvent leftEvent;

		// Token: 0x040037FA RID: 14330
		[UIHint(UIHint.Variable)]
		public FsmBool aboveBool;

		// Token: 0x040037FB RID: 14331
		[UIHint(UIHint.Variable)]
		public FsmBool belowBool;

		// Token: 0x040037FC RID: 14332
		[UIHint(UIHint.Variable)]
		public FsmBool rightBool;

		// Token: 0x040037FD RID: 14333
		[UIHint(UIHint.Variable)]
		public FsmBool leftBool;

		// Token: 0x040037FE RID: 14334
		private FsmGameObject self;

		// Token: 0x040037FF RID: 14335
		private FsmFloat x;

		// Token: 0x04003800 RID: 14336
		private FsmFloat y;

		// Token: 0x04003801 RID: 14337
		public bool everyFrame;
	}
}
