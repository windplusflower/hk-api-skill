using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C6B RID: 3179
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("Sets a Float Variable to a random value between Min/Max.")]
	public class RandomFloat : FsmStateAction
	{
		// Token: 0x0600427C RID: 17020 RVA: 0x0016FF97 File Offset: 0x0016E197
		public override void Reset()
		{
			this.min = 0f;
			this.max = 1f;
			this.storeResult = null;
		}

		// Token: 0x0600427D RID: 17021 RVA: 0x0016FFC0 File Offset: 0x0016E1C0
		public override void OnEnter()
		{
			this.storeResult.Value = UnityEngine.Random.Range(this.min.Value, this.max.Value);
			base.Finish();
		}

		// Token: 0x040046C0 RID: 18112
		[RequiredField]
		public FsmFloat min;

		// Token: 0x040046C1 RID: 18113
		[RequiredField]
		public FsmFloat max;

		// Token: 0x040046C2 RID: 18114
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmFloat storeResult;
	}
}
