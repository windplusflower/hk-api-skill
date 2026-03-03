using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D06 RID: 3334
	[ActionCategory(ActionCategory.Trigonometry)]
	[Tooltip("Get the Arc Cosine. You can get the result in degrees, simply check on the RadToDeg conversion")]
	public class GetACosine : FsmStateAction
	{
		// Token: 0x06004530 RID: 17712 RVA: 0x00178973 File Offset: 0x00176B73
		public override void Reset()
		{
			this.angle = null;
			this.RadToDeg = true;
			this.everyFrame = false;
			this.Value = null;
		}

		// Token: 0x06004531 RID: 17713 RVA: 0x00178996 File Offset: 0x00176B96
		public override void OnEnter()
		{
			this.DoACosine();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004532 RID: 17714 RVA: 0x001789AC File Offset: 0x00176BAC
		public override void OnUpdate()
		{
			this.DoACosine();
		}

		// Token: 0x06004533 RID: 17715 RVA: 0x001789B4 File Offset: 0x00176BB4
		private void DoACosine()
		{
			float num = Mathf.Acos(this.Value.Value);
			if (this.RadToDeg.Value)
			{
				num *= 57.29578f;
			}
			this.angle.Value = num;
		}

		// Token: 0x0400499A RID: 18842
		[RequiredField]
		[Tooltip("The value of the cosine")]
		public FsmFloat Value;

		// Token: 0x0400499B RID: 18843
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The resulting angle. Note:If you want degrees, simply check RadToDeg")]
		public FsmFloat angle;

		// Token: 0x0400499C RID: 18844
		[Tooltip("Check on if you want the angle expressed in degrees.")]
		public FsmBool RadToDeg;

		// Token: 0x0400499D RID: 18845
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;
	}
}
