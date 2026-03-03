using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D0A RID: 3338
	[ActionCategory(ActionCategory.Trigonometry)]
	[Tooltip("Get the Arc Tangent 2 as in atan2(y,x) from a vector 2. You can get the result in degrees, simply check on the RadToDeg conversion")]
	public class GetAtan2FromVector2 : FsmStateAction
	{
		// Token: 0x06004544 RID: 17732 RVA: 0x00178B86 File Offset: 0x00176D86
		public override void Reset()
		{
			this.vector2 = null;
			this.RadToDeg = true;
			this.everyFrame = false;
			this.angle = null;
		}

		// Token: 0x06004545 RID: 17733 RVA: 0x00178BA9 File Offset: 0x00176DA9
		public override void OnEnter()
		{
			this.DoATan();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004546 RID: 17734 RVA: 0x00178BBF File Offset: 0x00176DBF
		public override void OnUpdate()
		{
			this.DoATan();
		}

		// Token: 0x06004547 RID: 17735 RVA: 0x00178BC8 File Offset: 0x00176DC8
		private void DoATan()
		{
			float num = Mathf.Atan2(this.vector2.Value.y, this.vector2.Value.x);
			if (this.RadToDeg.Value)
			{
				num *= 57.29578f;
			}
			this.angle.Value = num;
		}

		// Token: 0x040049AB RID: 18859
		[RequiredField]
		[Tooltip("The vector2 of the tan")]
		public FsmVector2 vector2;

		// Token: 0x040049AC RID: 18860
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The resulting angle. Note:If you want degrees, simply check RadToDeg")]
		public FsmFloat angle;

		// Token: 0x040049AD RID: 18861
		[Tooltip("Check on if you want the angle expressed in degrees.")]
		public FsmBool RadToDeg;

		// Token: 0x040049AE RID: 18862
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;
	}
}
