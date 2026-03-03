using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D0E RID: 3342
	[ActionCategory(ActionCategory.Trigonometry)]
	[Tooltip("Get the sine. You can use degrees, simply check on the DegToRad conversion")]
	public class GetSine : FsmStateAction
	{
		// Token: 0x06004553 RID: 17747 RVA: 0x00178DAF File Offset: 0x00176FAF
		public override void Reset()
		{
			this.angle = null;
			this.DegToRad = true;
			this.everyFrame = false;
			this.result = null;
		}

		// Token: 0x06004554 RID: 17748 RVA: 0x00178DD2 File Offset: 0x00176FD2
		public override void OnEnter()
		{
			this.DoSine();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004555 RID: 17749 RVA: 0x00178DE8 File Offset: 0x00176FE8
		public override void OnUpdate()
		{
			this.DoSine();
		}

		// Token: 0x06004556 RID: 17750 RVA: 0x00178DF0 File Offset: 0x00176FF0
		private void DoSine()
		{
			float num = this.angle.Value;
			if (this.DegToRad.Value)
			{
				num *= 0.017453292f;
			}
			this.result.Value = Mathf.Sin(num);
		}

		// Token: 0x040049BD RID: 18877
		[RequiredField]
		[Tooltip("The angle. Note: You can use degrees, simply check DegtoRad if the angle is expressed in degrees.")]
		public FsmFloat angle;

		// Token: 0x040049BE RID: 18878
		[Tooltip("Check on if the angle is expressed in degrees.")]
		public FsmBool DegToRad;

		// Token: 0x040049BF RID: 18879
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The angle tan")]
		public FsmFloat result;

		// Token: 0x040049C0 RID: 18880
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;
	}
}
