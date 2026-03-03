using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C82 RID: 3202
	[ActionCategory(ActionCategory.Color)]
	[Tooltip("Select a random Color from an array of Colors.")]
	public class SelectRandomColor : FsmStateAction
	{
		// Token: 0x060042F2 RID: 17138 RVA: 0x001718E4 File Offset: 0x0016FAE4
		public override void Reset()
		{
			this.colors = new FsmColor[3];
			this.weights = new FsmFloat[]
			{
				1f,
				1f,
				1f
			};
			this.storeColor = null;
		}

		// Token: 0x060042F3 RID: 17139 RVA: 0x00171937 File Offset: 0x0016FB37
		public override void OnEnter()
		{
			this.DoSelectRandomColor();
			base.Finish();
		}

		// Token: 0x060042F4 RID: 17140 RVA: 0x00171948 File Offset: 0x0016FB48
		private void DoSelectRandomColor()
		{
			if (this.colors == null)
			{
				return;
			}
			if (this.colors.Length == 0)
			{
				return;
			}
			if (this.storeColor == null)
			{
				return;
			}
			int randomWeightedIndex = ActionHelpers.GetRandomWeightedIndex(this.weights);
			if (randomWeightedIndex != -1)
			{
				this.storeColor.Value = this.colors[randomWeightedIndex].Value;
			}
		}

		// Token: 0x04004741 RID: 18241
		[CompoundArray("Colors", "Color", "Weight")]
		public FsmColor[] colors;

		// Token: 0x04004742 RID: 18242
		[HasFloatSlider(0f, 1f)]
		public FsmFloat[] weights;

		// Token: 0x04004743 RID: 18243
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmColor storeColor;
	}
}
