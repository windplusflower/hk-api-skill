using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D08 RID: 3336
	[ActionCategory(ActionCategory.Trigonometry)]
	[Tooltip("Get the Arc Tangent. You can get the result in degrees, simply check on the RadToDeg conversion")]
	public class GetAtan : FsmStateAction
	{
		// Token: 0x0600453A RID: 17722 RVA: 0x00178A73 File Offset: 0x00176C73
		public override void Reset()
		{
			this.Value = null;
			this.RadToDeg = true;
			this.everyFrame = false;
			this.angle = null;
		}

		// Token: 0x0600453B RID: 17723 RVA: 0x00178A96 File Offset: 0x00176C96
		public override void OnEnter()
		{
			this.DoATan();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600453C RID: 17724 RVA: 0x00178AAC File Offset: 0x00176CAC
		public override void OnUpdate()
		{
			this.DoATan();
		}

		// Token: 0x0600453D RID: 17725 RVA: 0x00178AB4 File Offset: 0x00176CB4
		private void DoATan()
		{
			float num = Mathf.Atan(this.Value.Value);
			if (this.RadToDeg.Value)
			{
				num *= 57.29578f;
			}
			this.angle.Value = num;
		}

		// Token: 0x040049A2 RID: 18850
		[RequiredField]
		[Tooltip("The value of the tan")]
		public FsmFloat Value;

		// Token: 0x040049A3 RID: 18851
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The resulting angle. Note:If you want degrees, simply check RadToDeg")]
		public FsmFloat angle;

		// Token: 0x040049A4 RID: 18852
		[Tooltip("Check on if you want the angle expressed in degrees.")]
		public FsmBool RadToDeg;

		// Token: 0x040049A5 RID: 18853
		public bool everyFrame;
	}
}
