using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BC3 RID: 3011
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Compares 2 Game Objects and sends Events based on the result.")]
	public class GameObjectCompare : FsmStateAction
	{
		// Token: 0x06003F82 RID: 16258 RVA: 0x00167932 File Offset: 0x00165B32
		public override void Reset()
		{
			this.gameObjectVariable = null;
			this.compareTo = null;
			this.equalEvent = null;
			this.notEqualEvent = null;
			this.storeResult = null;
			this.everyFrame = false;
		}

		// Token: 0x06003F83 RID: 16259 RVA: 0x0016795E File Offset: 0x00165B5E
		public override void OnEnter()
		{
			this.DoGameObjectCompare();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003F84 RID: 16260 RVA: 0x00167974 File Offset: 0x00165B74
		public override void OnUpdate()
		{
			this.DoGameObjectCompare();
		}

		// Token: 0x06003F85 RID: 16261 RVA: 0x0016797C File Offset: 0x00165B7C
		private void DoGameObjectCompare()
		{
			bool flag = base.Fsm.GetOwnerDefaultTarget(this.gameObjectVariable) == this.compareTo.Value;
			this.storeResult.Value = flag;
			if (flag && this.equalEvent != null)
			{
				base.Fsm.Event(this.equalEvent);
				return;
			}
			if (!flag && this.notEqualEvent != null)
			{
				base.Fsm.Event(this.notEqualEvent);
			}
		}

		// Token: 0x040043AB RID: 17323
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Title("Game Object")]
		[Tooltip("A Game Object variable to compare.")]
		public FsmOwnerDefault gameObjectVariable;

		// Token: 0x040043AC RID: 17324
		[RequiredField]
		[Tooltip("Compare the variable with this Game Object")]
		public FsmGameObject compareTo;

		// Token: 0x040043AD RID: 17325
		[Tooltip("Send this event if Game Objects are equal")]
		public FsmEvent equalEvent;

		// Token: 0x040043AE RID: 17326
		[Tooltip("Send this event if Game Objects are not equal")]
		public FsmEvent notEqualEvent;

		// Token: 0x040043AF RID: 17327
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result of the check in a Bool Variable. (True if equal, false if not equal).")]
		public FsmBool storeResult;

		// Token: 0x040043B0 RID: 17328
		[Tooltip("Repeat every frame. Useful if you're waiting for a true or false result.")]
		public bool everyFrame;
	}
}
