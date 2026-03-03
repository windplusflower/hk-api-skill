using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C6D RID: 3181
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("Sets an Integer Variable to a random value between Min/Max.")]
	public class RandomInt : FsmStateAction
	{
		// Token: 0x06004282 RID: 17026 RVA: 0x00170065 File Offset: 0x0016E265
		public override void Reset()
		{
			this.min = 0;
			this.max = 100;
			this.storeResult = null;
			this.inclusiveMax = false;
		}

		// Token: 0x06004283 RID: 17027 RVA: 0x00170090 File Offset: 0x0016E290
		public override void OnEnter()
		{
			this.storeResult.Value = (this.inclusiveMax ? UnityEngine.Random.Range(this.min.Value, this.max.Value + 1) : UnityEngine.Random.Range(this.min.Value, this.max.Value));
			base.Finish();
		}

		// Token: 0x040046C6 RID: 18118
		[RequiredField]
		public FsmInt min;

		// Token: 0x040046C7 RID: 18119
		[RequiredField]
		public FsmInt max;

		// Token: 0x040046C8 RID: 18120
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmInt storeResult;

		// Token: 0x040046C9 RID: 18121
		[Tooltip("Should the Max value be included in the possible results?")]
		public bool inclusiveMax;
	}
}
