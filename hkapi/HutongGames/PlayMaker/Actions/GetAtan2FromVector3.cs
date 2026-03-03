using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D0B RID: 3339
	[ActionCategory(ActionCategory.Trigonometry)]
	[Tooltip("Get the Arc Tangent 2 as in atan2(y,x) from a vector 3, where you pick which is x and y from the vector 3. You can get the result in degrees, simply check on the RadToDeg conversion")]
	public class GetAtan2FromVector3 : FsmStateAction
	{
		// Token: 0x06004549 RID: 17737 RVA: 0x00178C1C File Offset: 0x00176E1C
		public override void Reset()
		{
			this.vector3 = null;
			this.xAxis = GetAtan2FromVector3.aTan2EnumAxis.x;
			this.yAxis = GetAtan2FromVector3.aTan2EnumAxis.y;
			this.RadToDeg = true;
			this.everyFrame = false;
			this.angle = null;
		}

		// Token: 0x0600454A RID: 17738 RVA: 0x00178C4D File Offset: 0x00176E4D
		public override void OnEnter()
		{
			this.DoATan();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600454B RID: 17739 RVA: 0x00178C63 File Offset: 0x00176E63
		public override void OnUpdate()
		{
			this.DoATan();
		}

		// Token: 0x0600454C RID: 17740 RVA: 0x00178C6C File Offset: 0x00176E6C
		private void DoATan()
		{
			float x = this.vector3.Value.x;
			if (this.xAxis == GetAtan2FromVector3.aTan2EnumAxis.y)
			{
				x = this.vector3.Value.y;
			}
			else if (this.xAxis == GetAtan2FromVector3.aTan2EnumAxis.z)
			{
				x = this.vector3.Value.z;
			}
			float y = this.vector3.Value.y;
			if (this.yAxis == GetAtan2FromVector3.aTan2EnumAxis.x)
			{
				y = this.vector3.Value.x;
			}
			else if (this.yAxis == GetAtan2FromVector3.aTan2EnumAxis.z)
			{
				y = this.vector3.Value.z;
			}
			float num = Mathf.Atan2(y, x);
			if (this.RadToDeg.Value)
			{
				num *= 57.29578f;
			}
			this.angle.Value = num;
		}

		// Token: 0x040049AF RID: 18863
		[RequiredField]
		[Tooltip("The vector3 definition of the tan")]
		public FsmVector3 vector3;

		// Token: 0x040049B0 RID: 18864
		[RequiredField]
		[Tooltip("which axis in the vector3 to use as the x value of the tan")]
		public GetAtan2FromVector3.aTan2EnumAxis xAxis;

		// Token: 0x040049B1 RID: 18865
		[RequiredField]
		[Tooltip("which axis in the vector3 to use as the y value of the tan")]
		public GetAtan2FromVector3.aTan2EnumAxis yAxis;

		// Token: 0x040049B2 RID: 18866
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The resulting angle. Note:If you want degrees, simply check RadToDeg")]
		public FsmFloat angle;

		// Token: 0x040049B3 RID: 18867
		[Tooltip("Check on if you want the angle expressed in degrees.")]
		public FsmBool RadToDeg;

		// Token: 0x040049B4 RID: 18868
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		// Token: 0x02000D0C RID: 3340
		public enum aTan2EnumAxis
		{
			// Token: 0x040049B6 RID: 18870
			x,
			// Token: 0x040049B7 RID: 18871
			y,
			// Token: 0x040049B8 RID: 18872
			z
		}
	}
}
