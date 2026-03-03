using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D0D RID: 3341
	[ActionCategory(ActionCategory.Trigonometry)]
	[Tooltip("Get the cosine. You can use degrees, simply check on the DegToRad conversion")]
	public class GetCosine : FsmStateAction
	{
		// Token: 0x0600454E RID: 17742 RVA: 0x00178D2F File Offset: 0x00176F2F
		public override void Reset()
		{
			this.angle = null;
			this.DegToRad = true;
			this.everyFrame = false;
			this.result = null;
		}

		// Token: 0x0600454F RID: 17743 RVA: 0x00178D52 File Offset: 0x00176F52
		public override void OnEnter()
		{
			this.DoCosine();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004550 RID: 17744 RVA: 0x00178D68 File Offset: 0x00176F68
		public override void OnUpdate()
		{
			this.DoCosine();
		}

		// Token: 0x06004551 RID: 17745 RVA: 0x00178D70 File Offset: 0x00176F70
		private void DoCosine()
		{
			float num = this.angle.Value;
			if (this.DegToRad.Value)
			{
				num *= 0.017453292f;
			}
			this.result.Value = Mathf.Cos(num);
		}

		// Token: 0x040049B9 RID: 18873
		[RequiredField]
		[Tooltip("The angle. Note: You can use degrees, simply check DegtoRad if the angle is expressed in degrees.")]
		public FsmFloat angle;

		// Token: 0x040049BA RID: 18874
		[Tooltip("Check on if the angle is expressed in degrees.")]
		public FsmBool DegToRad;

		// Token: 0x040049BB RID: 18875
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The angle cosinus")]
		public FsmFloat result;

		// Token: 0x040049BC RID: 18876
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;
	}
}
