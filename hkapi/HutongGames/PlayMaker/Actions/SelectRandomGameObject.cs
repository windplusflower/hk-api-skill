using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C83 RID: 3203
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Selects a Random Game Object from an array of Game Objects.")]
	public class SelectRandomGameObject : FsmStateAction
	{
		// Token: 0x060042F6 RID: 17142 RVA: 0x0017199C File Offset: 0x0016FB9C
		public override void Reset()
		{
			this.gameObjects = new FsmGameObject[3];
			this.weights = new FsmFloat[]
			{
				1f,
				1f,
				1f
			};
			this.storeGameObject = null;
		}

		// Token: 0x060042F7 RID: 17143 RVA: 0x001719EF File Offset: 0x0016FBEF
		public override void OnEnter()
		{
			this.DoSelectRandomGameObject();
			base.Finish();
		}

		// Token: 0x060042F8 RID: 17144 RVA: 0x00171A00 File Offset: 0x0016FC00
		private void DoSelectRandomGameObject()
		{
			if (this.gameObjects == null)
			{
				return;
			}
			if (this.gameObjects.Length == 0)
			{
				return;
			}
			if (this.storeGameObject == null)
			{
				return;
			}
			int randomWeightedIndex = ActionHelpers.GetRandomWeightedIndex(this.weights);
			if (randomWeightedIndex != -1)
			{
				this.storeGameObject.Value = this.gameObjects[randomWeightedIndex].Value;
			}
		}

		// Token: 0x04004744 RID: 18244
		[CompoundArray("Game Objects", "Game Object", "Weight")]
		public FsmGameObject[] gameObjects;

		// Token: 0x04004745 RID: 18245
		[HasFloatSlider(0f, 1f)]
		public FsmFloat[] weights;

		// Token: 0x04004746 RID: 18246
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmGameObject storeGameObject;
	}
}
