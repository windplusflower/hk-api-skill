using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D19 RID: 3353
	[ActionCategory(ActionCategory.Vector3)]
	[Tooltip("Linearly interpolates between 2 vectors.")]
	public class Vector3Lerp : FsmStateAction
	{
		// Token: 0x06004583 RID: 17795 RVA: 0x00179501 File Offset: 0x00177701
		public override void Reset()
		{
			this.fromVector = new FsmVector3
			{
				UseVariable = true
			};
			this.toVector = new FsmVector3
			{
				UseVariable = true
			};
			this.storeResult = null;
			this.everyFrame = true;
		}

		// Token: 0x06004584 RID: 17796 RVA: 0x00179535 File Offset: 0x00177735
		public override void OnEnter()
		{
			this.DoVector3Lerp();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004585 RID: 17797 RVA: 0x0017954B File Offset: 0x0017774B
		public override void OnUpdate()
		{
			this.DoVector3Lerp();
		}

		// Token: 0x06004586 RID: 17798 RVA: 0x00179553 File Offset: 0x00177753
		private void DoVector3Lerp()
		{
			this.storeResult.Value = Vector3.Lerp(this.fromVector.Value, this.toVector.Value, this.amount.Value);
		}

		// Token: 0x040049E6 RID: 18918
		[RequiredField]
		[Tooltip("First Vector.")]
		public FsmVector3 fromVector;

		// Token: 0x040049E7 RID: 18919
		[RequiredField]
		[Tooltip("Second Vector.")]
		public FsmVector3 toVector;

		// Token: 0x040049E8 RID: 18920
		[RequiredField]
		[Tooltip("Interpolate between From Vector and ToVector by this amount. Value is clamped to 0-1 range. 0 = From Vector; 1 = To Vector; 0.5 = half way between.")]
		public FsmFloat amount;

		// Token: 0x040049E9 RID: 18921
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in this vector variable.")]
		public FsmVector3 storeResult;

		// Token: 0x040049EA RID: 18922
		[Tooltip("Repeat every frame. Useful if any of the values are changing.")]
		public bool everyFrame;
	}
}
