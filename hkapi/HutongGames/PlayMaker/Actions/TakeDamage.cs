using System;
using Modding;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A6E RID: 2670
	public class TakeDamage : FsmStateAction
	{
		// Token: 0x06003993 RID: 14739 RVA: 0x0014FCC8 File Offset: 0x0014DEC8
		public override void Reset()
		{
			base.Reset();
			this.Target = new FsmGameObject
			{
				UseVariable = true
			};
			this.AttackType = new FsmInt
			{
				UseVariable = true
			};
			this.CircleDirection = new FsmBool
			{
				UseVariable = true
			};
			this.DamageDealt = new FsmInt
			{
				UseVariable = true
			};
			this.Direction = new FsmFloat
			{
				UseVariable = true
			};
			this.IgnoreInvulnerable = new FsmBool
			{
				UseVariable = true
			};
			this.MagnitudeMultiplier = new FsmFloat
			{
				UseVariable = true
			};
			this.MoveAngle = new FsmFloat
			{
				UseVariable = true
			};
			this.MoveDirection = new FsmBool
			{
				UseVariable = true
			};
			this.Multiplier = new FsmFloat
			{
				UseVariable = true
			};
			this.SpecialType = new FsmInt
			{
				UseVariable = true
			};
		}

		// Token: 0x06003994 RID: 14740 RVA: 0x0014FDA4 File Offset: 0x0014DFA4
		public override void OnEnter()
		{
			HitInstance hitInstance = new HitInstance
			{
				Source = base.Owner,
				AttackType = (AttackTypes)this.AttackType.Value,
				CircleDirection = this.CircleDirection.Value,
				DamageDealt = this.DamageDealt.Value,
				Direction = this.Direction.Value,
				IgnoreInvulnerable = this.IgnoreInvulnerable.Value,
				MagnitudeMultiplier = this.MagnitudeMultiplier.Value,
				MoveAngle = this.MoveAngle.Value,
				MoveDirection = this.MoveDirection.Value,
				Multiplier = ((!this.Multiplier.IsNone) ? this.Multiplier.Value : 1f),
				SpecialType = (SpecialTypes)this.SpecialType.Value,
				IsExtraDamage = false
			};
			hitInstance = ModHooks.OnHitInstanceBeforeHit(base.Fsm, hitInstance);
			HitTaker.Hit(this.Target.Value, hitInstance, 3);
			base.Finish();
		}

		// Token: 0x04003C8C RID: 15500
		public FsmGameObject Target;

		// Token: 0x04003C8D RID: 15501
		public FsmInt AttackType;

		// Token: 0x04003C8E RID: 15502
		public FsmBool CircleDirection;

		// Token: 0x04003C8F RID: 15503
		public FsmInt DamageDealt;

		// Token: 0x04003C90 RID: 15504
		public FsmFloat Direction;

		// Token: 0x04003C91 RID: 15505
		public FsmBool IgnoreInvulnerable;

		// Token: 0x04003C92 RID: 15506
		public FsmFloat MagnitudeMultiplier;

		// Token: 0x04003C93 RID: 15507
		public FsmFloat MoveAngle;

		// Token: 0x04003C94 RID: 15508
		public FsmBool MoveDirection;

		// Token: 0x04003C95 RID: 15509
		public FsmFloat Multiplier;

		// Token: 0x04003C96 RID: 15510
		public FsmInt SpecialType;
	}
}
