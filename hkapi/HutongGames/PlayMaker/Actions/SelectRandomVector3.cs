using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C85 RID: 3205
	[ActionCategory(ActionCategory.Vector3)]
	[Tooltip("Select a Random Vector3 from a Vector3 array.")]
	public class SelectRandomVector3 : FsmStateAction
	{
		// Token: 0x060042FE RID: 17150 RVA: 0x00171B0C File Offset: 0x0016FD0C
		public override void Reset()
		{
			this.vector3Array = new FsmVector3[3];
			this.weights = new FsmFloat[]
			{
				1f,
				1f,
				1f
			};
			this.storeVector3 = null;
		}

		// Token: 0x060042FF RID: 17151 RVA: 0x00171B5F File Offset: 0x0016FD5F
		public override void OnEnter()
		{
			this.DoSelectRandomColor();
			base.Finish();
		}

		// Token: 0x06004300 RID: 17152 RVA: 0x00171B70 File Offset: 0x0016FD70
		private void DoSelectRandomColor()
		{
			if (this.vector3Array == null)
			{
				return;
			}
			if (this.vector3Array.Length == 0)
			{
				return;
			}
			if (this.storeVector3 == null)
			{
				return;
			}
			int randomWeightedIndex = ActionHelpers.GetRandomWeightedIndex(this.weights);
			if (randomWeightedIndex != -1)
			{
				this.storeVector3.Value = this.vector3Array[randomWeightedIndex].Value;
			}
		}

		// Token: 0x0400474A RID: 18250
		[CompoundArray("Vectors", "Vector", "Weight")]
		public FsmVector3[] vector3Array;

		// Token: 0x0400474B RID: 18251
		[HasFloatSlider(0f, 1f)]
		public FsmFloat[] weights;

		// Token: 0x0400474C RID: 18252
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmVector3 storeVector3;
	}
}
