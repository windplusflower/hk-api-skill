using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C84 RID: 3204
	[ActionCategory(ActionCategory.String)]
	[Tooltip("Select a Random String from an array of Strings.")]
	public class SelectRandomString : FsmStateAction
	{
		// Token: 0x060042FA RID: 17146 RVA: 0x00171A54 File Offset: 0x0016FC54
		public override void Reset()
		{
			this.strings = new FsmString[3];
			this.weights = new FsmFloat[]
			{
				1f,
				1f,
				1f
			};
			this.storeString = null;
		}

		// Token: 0x060042FB RID: 17147 RVA: 0x00171AA7 File Offset: 0x0016FCA7
		public override void OnEnter()
		{
			this.DoSelectRandomString();
			base.Finish();
		}

		// Token: 0x060042FC RID: 17148 RVA: 0x00171AB8 File Offset: 0x0016FCB8
		private void DoSelectRandomString()
		{
			if (this.strings == null)
			{
				return;
			}
			if (this.strings.Length == 0)
			{
				return;
			}
			if (this.storeString == null)
			{
				return;
			}
			int randomWeightedIndex = ActionHelpers.GetRandomWeightedIndex(this.weights);
			if (randomWeightedIndex != -1)
			{
				this.storeString.Value = this.strings[randomWeightedIndex].Value;
			}
		}

		// Token: 0x04004747 RID: 18247
		[CompoundArray("Strings", "String", "Weight")]
		public FsmString[] strings;

		// Token: 0x04004748 RID: 18248
		[HasFloatSlider(0f, 1f)]
		public FsmFloat[] weights;

		// Token: 0x04004749 RID: 18249
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmString storeString;
	}
}
