using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C6C RID: 3180
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("Sets a Float Variable to a random choice of two floats.")]
	public class RandomFloatEither : FsmStateAction
	{
		// Token: 0x0600427F RID: 17023 RVA: 0x0016FFEE File Offset: 0x0016E1EE
		public override void Reset()
		{
			this.value1 = 0f;
			this.value2 = 1f;
			this.storeResult = null;
		}

		// Token: 0x06004280 RID: 17024 RVA: 0x00170018 File Offset: 0x0016E218
		public override void OnEnter()
		{
			if (UnityEngine.Random.Range(0, 100) < 50)
			{
				this.storeResult.Value = this.value1.Value;
			}
			else
			{
				this.storeResult.Value = this.value2.Value;
			}
			base.Finish();
		}

		// Token: 0x040046C3 RID: 18115
		[RequiredField]
		public FsmFloat value1;

		// Token: 0x040046C4 RID: 18116
		[RequiredField]
		public FsmFloat value2;

		// Token: 0x040046C5 RID: 18117
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmFloat storeResult;
	}
}
