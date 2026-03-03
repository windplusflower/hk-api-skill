using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CA0 RID: 3232
	[ActionCategory(ActionCategory.StateMachine)]
	[Tooltip("Sets Event Data before sending an event. Get the Event Data, along with sender information, using Get Event Info action.")]
	public class SetEventData : FsmStateAction
	{
		// Token: 0x06004370 RID: 17264 RVA: 0x00172FE4 File Offset: 0x001711E4
		public override void Reset()
		{
			this.setGameObjectData = new FsmGameObject
			{
				UseVariable = true
			};
			this.setIntData = new FsmInt
			{
				UseVariable = true
			};
			this.setFloatData = new FsmFloat
			{
				UseVariable = true
			};
			this.setStringData = new FsmString
			{
				UseVariable = true
			};
			this.setBoolData = new FsmBool
			{
				UseVariable = true
			};
			this.setVector2Data = new FsmVector2
			{
				UseVariable = true
			};
			this.setVector3Data = new FsmVector3
			{
				UseVariable = true
			};
			this.setRectData = new FsmRect
			{
				UseVariable = true
			};
			this.setQuaternionData = new FsmQuaternion
			{
				UseVariable = true
			};
			this.setColorData = new FsmColor
			{
				UseVariable = true
			};
			this.setMaterialData = new FsmMaterial
			{
				UseVariable = true
			};
			this.setTextureData = new FsmTexture
			{
				UseVariable = true
			};
			this.setObjectData = new FsmObject
			{
				UseVariable = true
			};
		}

		// Token: 0x06004371 RID: 17265 RVA: 0x001730DC File Offset: 0x001712DC
		public override void OnEnter()
		{
			Fsm.EventData.BoolData = this.setBoolData.Value;
			Fsm.EventData.IntData = this.setIntData.Value;
			Fsm.EventData.FloatData = this.setFloatData.Value;
			Fsm.EventData.Vector2Data = this.setVector2Data.Value;
			Fsm.EventData.Vector3Data = this.setVector3Data.Value;
			Fsm.EventData.StringData = this.setStringData.Value;
			Fsm.EventData.GameObjectData = this.setGameObjectData.Value;
			Fsm.EventData.RectData = this.setRectData.Value;
			Fsm.EventData.QuaternionData = this.setQuaternionData.Value;
			Fsm.EventData.ColorData = this.setColorData.Value;
			Fsm.EventData.MaterialData = this.setMaterialData.Value;
			Fsm.EventData.TextureData = this.setTextureData.Value;
			Fsm.EventData.ObjectData = this.setObjectData.Value;
			base.Finish();
		}

		// Token: 0x040047AF RID: 18351
		public FsmGameObject setGameObjectData;

		// Token: 0x040047B0 RID: 18352
		public FsmInt setIntData;

		// Token: 0x040047B1 RID: 18353
		public FsmFloat setFloatData;

		// Token: 0x040047B2 RID: 18354
		public FsmString setStringData;

		// Token: 0x040047B3 RID: 18355
		public FsmBool setBoolData;

		// Token: 0x040047B4 RID: 18356
		public FsmVector2 setVector2Data;

		// Token: 0x040047B5 RID: 18357
		public FsmVector3 setVector3Data;

		// Token: 0x040047B6 RID: 18358
		public FsmRect setRectData;

		// Token: 0x040047B7 RID: 18359
		public FsmQuaternion setQuaternionData;

		// Token: 0x040047B8 RID: 18360
		public FsmColor setColorData;

		// Token: 0x040047B9 RID: 18361
		public FsmMaterial setMaterialData;

		// Token: 0x040047BA RID: 18362
		public FsmTexture setTextureData;

		// Token: 0x040047BB RID: 18363
		public FsmObject setObjectData;
	}
}
