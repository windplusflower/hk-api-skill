using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D0F RID: 3343
	[ActionCategory(ActionCategory.Trigonometry)]
	[Tooltip("Get the Tangent. You can use degrees, simply check on the DegToRad conversion")]
	public class GetTan : FsmStateAction
	{
		// Token: 0x06004558 RID: 17752 RVA: 0x00178E2F File Offset: 0x0017702F
		public override void Reset()
		{
			this.angle = null;
			this.DegToRad = true;
			this.everyFrame = false;
			this.result = null;
		}

		// Token: 0x06004559 RID: 17753 RVA: 0x00178E52 File Offset: 0x00177052
		public override void OnEnter()
		{
			this.DoTan();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600455A RID: 17754 RVA: 0x00178E68 File Offset: 0x00177068
		public override void OnUpdate()
		{
			this.DoTan();
		}

		// Token: 0x0600455B RID: 17755 RVA: 0x00178E70 File Offset: 0x00177070
		private void DoTan()
		{
			float num = this.angle.Value;
			if (this.DegToRad.Value)
			{
				num *= 0.017453292f;
			}
			this.result.Value = Mathf.Tan(num);
		}

		// Token: 0x040049C1 RID: 18881
		[RequiredField]
		[Tooltip("The angle. Note: You can use degrees, simply check DegtoRad if the angle is expressed in degrees.")]
		public FsmFloat angle;

		// Token: 0x040049C2 RID: 18882
		[Tooltip("Check on if the angle is expressed in degrees.")]
		public FsmBool DegToRad;

		// Token: 0x040049C3 RID: 18883
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The angle tan")]
		public FsmFloat result;

		// Token: 0x040049C4 RID: 18884
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;
	}
}
