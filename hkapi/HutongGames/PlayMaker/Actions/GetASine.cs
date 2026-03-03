using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D07 RID: 3335
	[ActionCategory(ActionCategory.Trigonometry)]
	[Tooltip("Get the Arc sine. You can get the result in degrees, simply check on the RadToDeg conversion")]
	public class GetASine : FsmStateAction
	{
		// Token: 0x06004535 RID: 17717 RVA: 0x001789F3 File Offset: 0x00176BF3
		public override void Reset()
		{
			this.angle = null;
			this.RadToDeg = true;
			this.everyFrame = false;
			this.Value = null;
		}

		// Token: 0x06004536 RID: 17718 RVA: 0x00178A16 File Offset: 0x00176C16
		public override void OnEnter()
		{
			this.DoASine();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004537 RID: 17719 RVA: 0x00178A2C File Offset: 0x00176C2C
		public override void OnUpdate()
		{
			this.DoASine();
		}

		// Token: 0x06004538 RID: 17720 RVA: 0x00178A34 File Offset: 0x00176C34
		private void DoASine()
		{
			float num = Mathf.Asin(this.Value.Value);
			if (this.RadToDeg.Value)
			{
				num *= 57.29578f;
			}
			this.angle.Value = num;
		}

		// Token: 0x0400499E RID: 18846
		[RequiredField]
		[Tooltip("The value of the sine")]
		public FsmFloat Value;

		// Token: 0x0400499F RID: 18847
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The resulting angle. Note:If you want degrees, simply check RadToDeg")]
		public FsmFloat angle;

		// Token: 0x040049A0 RID: 18848
		[Tooltip("Check on if you want the angle expressed in degrees.")]
		public FsmBool RadToDeg;

		// Token: 0x040049A1 RID: 18849
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;
	}
}
