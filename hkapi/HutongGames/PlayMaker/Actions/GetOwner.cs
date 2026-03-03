using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C03 RID: 3075
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Gets the Game Object that owns the FSM and stores it in a game object variable.")]
	public class GetOwner : FsmStateAction
	{
		// Token: 0x06004099 RID: 16537 RVA: 0x0016A8E5 File Offset: 0x00168AE5
		public override void Reset()
		{
			this.storeGameObject = null;
		}

		// Token: 0x0600409A RID: 16538 RVA: 0x0016A8EE File Offset: 0x00168AEE
		public override void OnEnter()
		{
			this.storeGameObject.Value = base.Owner;
			base.Finish();
		}

		// Token: 0x040044EE RID: 17646
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmGameObject storeGameObject;
	}
}
