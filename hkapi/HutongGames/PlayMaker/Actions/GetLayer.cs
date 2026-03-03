using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BF6 RID: 3062
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Gets a Game Object's Layer and stores it in an Int Variable.")]
	public class GetLayer : FsmStateAction
	{
		// Token: 0x06004060 RID: 16480 RVA: 0x0016A155 File Offset: 0x00168355
		public override void Reset()
		{
			this.gameObject = null;
			this.storeResult = null;
			this.everyFrame = false;
		}

		// Token: 0x06004061 RID: 16481 RVA: 0x0016A16C File Offset: 0x0016836C
		public override void OnEnter()
		{
			this.DoGetLayer();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004062 RID: 16482 RVA: 0x0016A182 File Offset: 0x00168382
		public override void OnUpdate()
		{
			this.DoGetLayer();
		}

		// Token: 0x06004063 RID: 16483 RVA: 0x0016A18A File Offset: 0x0016838A
		private void DoGetLayer()
		{
			if (this.gameObject.Value == null)
			{
				return;
			}
			this.storeResult.Value = this.gameObject.Value.layer;
		}

		// Token: 0x040044C1 RID: 17601
		[RequiredField]
		public FsmGameObject gameObject;

		// Token: 0x040044C2 RID: 17602
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmInt storeResult;

		// Token: 0x040044C3 RID: 17603
		public bool everyFrame;
	}
}
