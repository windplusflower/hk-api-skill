using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BDD RID: 3037
	[ActionCategory(ActionCategory.StateMachine)]
	[Tooltip("Gets info on the last event that caused a state change. See also Set Event Data action.")]
	public class GetEventInfo : FsmStateAction
	{
		// Token: 0x06003FEF RID: 16367 RVA: 0x00168CD0 File Offset: 0x00166ED0
		public override void Reset()
		{
			this.sentByGameObject = null;
			this.fsmName = null;
			this.getBoolData = null;
			this.getIntData = null;
			this.getFloatData = null;
			this.getVector2Data = null;
			this.getVector3Data = null;
			this.getStringData = null;
			this.getGameObjectData = null;
			this.getRectData = null;
			this.getQuaternionData = null;
			this.getMaterialData = null;
			this.getTextureData = null;
			this.getColorData = null;
			this.getObjectData = null;
		}

		// Token: 0x06003FF0 RID: 16368 RVA: 0x00168D48 File Offset: 0x00166F48
		public override void OnEnter()
		{
			if (Fsm.EventData.SentByFsm != null)
			{
				this.sentByGameObject.Value = Fsm.EventData.SentByFsm.GameObject;
				this.fsmName.Value = Fsm.EventData.SentByFsm.Name;
			}
			else
			{
				this.sentByGameObject.Value = null;
				this.fsmName.Value = "";
			}
			this.getBoolData.Value = Fsm.EventData.BoolData;
			this.getIntData.Value = Fsm.EventData.IntData;
			this.getFloatData.Value = Fsm.EventData.FloatData;
			this.getVector2Data.Value = Fsm.EventData.Vector2Data;
			this.getVector3Data.Value = Fsm.EventData.Vector3Data;
			this.getStringData.Value = Fsm.EventData.StringData;
			this.getGameObjectData.Value = Fsm.EventData.GameObjectData;
			this.getRectData.Value = Fsm.EventData.RectData;
			this.getQuaternionData.Value = Fsm.EventData.QuaternionData;
			this.getMaterialData.Value = Fsm.EventData.MaterialData;
			this.getTextureData.Value = Fsm.EventData.TextureData;
			this.getColorData.Value = Fsm.EventData.ColorData;
			this.getObjectData.Value = Fsm.EventData.ObjectData;
			base.Finish();
		}

		// Token: 0x04004427 RID: 17447
		[UIHint(UIHint.Variable)]
		public FsmGameObject sentByGameObject;

		// Token: 0x04004428 RID: 17448
		[UIHint(UIHint.Variable)]
		public FsmString fsmName;

		// Token: 0x04004429 RID: 17449
		[UIHint(UIHint.Variable)]
		public FsmBool getBoolData;

		// Token: 0x0400442A RID: 17450
		[UIHint(UIHint.Variable)]
		public FsmInt getIntData;

		// Token: 0x0400442B RID: 17451
		[UIHint(UIHint.Variable)]
		public FsmFloat getFloatData;

		// Token: 0x0400442C RID: 17452
		[UIHint(UIHint.Variable)]
		public FsmVector2 getVector2Data;

		// Token: 0x0400442D RID: 17453
		[UIHint(UIHint.Variable)]
		public FsmVector3 getVector3Data;

		// Token: 0x0400442E RID: 17454
		[UIHint(UIHint.Variable)]
		public FsmString getStringData;

		// Token: 0x0400442F RID: 17455
		[UIHint(UIHint.Variable)]
		public FsmGameObject getGameObjectData;

		// Token: 0x04004430 RID: 17456
		[UIHint(UIHint.Variable)]
		public FsmRect getRectData;

		// Token: 0x04004431 RID: 17457
		[UIHint(UIHint.Variable)]
		public FsmQuaternion getQuaternionData;

		// Token: 0x04004432 RID: 17458
		[UIHint(UIHint.Variable)]
		public FsmMaterial getMaterialData;

		// Token: 0x04004433 RID: 17459
		[UIHint(UIHint.Variable)]
		public FsmTexture getTextureData;

		// Token: 0x04004434 RID: 17460
		[UIHint(UIHint.Variable)]
		public FsmColor getColorData;

		// Token: 0x04004435 RID: 17461
		[UIHint(UIHint.Variable)]
		public FsmObject getObjectData;
	}
}
