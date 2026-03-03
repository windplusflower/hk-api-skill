using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C67 RID: 3175
	[ActionCategory(ActionCategory.Quaternion)]
	[Tooltip("Rotates a rotation from towards to. This is essentially the same as Quaternion.Slerp but instead the function will ensure that the angular speed never exceeds maxDegreesDelta. Negative values of maxDegreesDelta pushes the rotation away from to.")]
	public class QuaternionRotateTowards : QuaternionBaseAction
	{
		// Token: 0x06004266 RID: 16998 RVA: 0x0016FC9C File Offset: 0x0016DE9C
		public override void Reset()
		{
			this.fromQuaternion = new FsmQuaternion
			{
				UseVariable = true
			};
			this.toQuaternion = new FsmQuaternion
			{
				UseVariable = true
			};
			this.maxDegreesDelta = 10f;
			this.storeResult = null;
			this.everyFrame = true;
			this.everyFrameOption = QuaternionBaseAction.everyFrameOptions.Update;
		}

		// Token: 0x06004267 RID: 16999 RVA: 0x0016FCF2 File Offset: 0x0016DEF2
		public override void OnEnter()
		{
			this.DoQuatRotateTowards();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004268 RID: 17000 RVA: 0x0016FD08 File Offset: 0x0016DF08
		public override void OnUpdate()
		{
			if (this.everyFrameOption == QuaternionBaseAction.everyFrameOptions.Update)
			{
				this.DoQuatRotateTowards();
			}
		}

		// Token: 0x06004269 RID: 17001 RVA: 0x0016FD18 File Offset: 0x0016DF18
		public override void OnLateUpdate()
		{
			if (this.everyFrameOption == QuaternionBaseAction.everyFrameOptions.LateUpdate)
			{
				this.DoQuatRotateTowards();
			}
		}

		// Token: 0x0600426A RID: 17002 RVA: 0x0016FD29 File Offset: 0x0016DF29
		public override void OnFixedUpdate()
		{
			if (this.everyFrameOption == QuaternionBaseAction.everyFrameOptions.FixedUpdate)
			{
				this.DoQuatRotateTowards();
			}
		}

		// Token: 0x0600426B RID: 17003 RVA: 0x0016FD3A File Offset: 0x0016DF3A
		private void DoQuatRotateTowards()
		{
			this.storeResult.Value = Quaternion.RotateTowards(this.fromQuaternion.Value, this.toQuaternion.Value, this.maxDegreesDelta.Value);
		}

		// Token: 0x040046B2 RID: 18098
		[RequiredField]
		[Tooltip("From Quaternion.")]
		public FsmQuaternion fromQuaternion;

		// Token: 0x040046B3 RID: 18099
		[RequiredField]
		[Tooltip("To Quaternion.")]
		public FsmQuaternion toQuaternion;

		// Token: 0x040046B4 RID: 18100
		[RequiredField]
		[Tooltip("The angular speed never exceeds maxDegreesDelta. Negative values of maxDegreesDelta pushes the rotation away from to.")]
		public FsmFloat maxDegreesDelta;

		// Token: 0x040046B5 RID: 18101
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in this quaternion variable.")]
		public FsmQuaternion storeResult;
	}
}
