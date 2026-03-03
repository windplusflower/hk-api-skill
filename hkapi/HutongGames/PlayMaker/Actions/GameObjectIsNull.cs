using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BC7 RID: 3015
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Tests if a GameObject Variable has a null value. E.g., If the FindGameObject action failed to find an object.")]
	public class GameObjectIsNull : FsmStateAction
	{
		// Token: 0x06003F95 RID: 16277 RVA: 0x00167BF7 File Offset: 0x00165DF7
		public override void Reset()
		{
			this.gameObject = null;
			this.isNull = null;
			this.isNotNull = null;
			this.storeResult = null;
			this.everyFrame = false;
		}

		// Token: 0x06003F96 RID: 16278 RVA: 0x00167C1C File Offset: 0x00165E1C
		public override void OnEnter()
		{
			this.DoIsGameObjectNull();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003F97 RID: 16279 RVA: 0x00167C32 File Offset: 0x00165E32
		public override void OnUpdate()
		{
			this.DoIsGameObjectNull();
		}

		// Token: 0x06003F98 RID: 16280 RVA: 0x00167C3C File Offset: 0x00165E3C
		private void DoIsGameObjectNull()
		{
			bool flag = this.gameObject.Value == null;
			if (this.storeResult != null)
			{
				this.storeResult.Value = flag;
			}
			base.Fsm.Event(flag ? this.isNull : this.isNotNull);
		}

		// Token: 0x040043C1 RID: 17345
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The GameObject variable to test.")]
		public FsmGameObject gameObject;

		// Token: 0x040043C2 RID: 17346
		[Tooltip("Event to send if the GamObject is null.")]
		public FsmEvent isNull;

		// Token: 0x040043C3 RID: 17347
		[Tooltip("Event to send if the GamObject is NOT null.")]
		public FsmEvent isNotNull;

		// Token: 0x040043C4 RID: 17348
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in a bool variable.")]
		public FsmBool storeResult;

		// Token: 0x040043C5 RID: 17349
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;
	}
}
