using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C65 RID: 3173
	[ActionCategory(ActionCategory.Quaternion)]
	[Tooltip("Creates a rotation that looks along forward with the the head upwards along upwards.")]
	public class QuaternionLookRotation : QuaternionBaseAction
	{
		// Token: 0x06004258 RID: 16984 RVA: 0x0016F9A5 File Offset: 0x0016DBA5
		public override void Reset()
		{
			this.direction = null;
			this.upVector = new FsmVector3
			{
				UseVariable = true
			};
			this.result = null;
			this.everyFrame = true;
			this.everyFrameOption = QuaternionBaseAction.everyFrameOptions.Update;
		}

		// Token: 0x06004259 RID: 16985 RVA: 0x0016F9D5 File Offset: 0x0016DBD5
		public override void OnEnter()
		{
			this.DoQuatLookRotation();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600425A RID: 16986 RVA: 0x0016F9EB File Offset: 0x0016DBEB
		public override void OnUpdate()
		{
			if (this.everyFrameOption == QuaternionBaseAction.everyFrameOptions.Update)
			{
				this.DoQuatLookRotation();
			}
		}

		// Token: 0x0600425B RID: 16987 RVA: 0x0016F9FB File Offset: 0x0016DBFB
		public override void OnLateUpdate()
		{
			if (this.everyFrameOption == QuaternionBaseAction.everyFrameOptions.LateUpdate)
			{
				this.DoQuatLookRotation();
			}
		}

		// Token: 0x0600425C RID: 16988 RVA: 0x0016FA0C File Offset: 0x0016DC0C
		public override void OnFixedUpdate()
		{
			if (this.everyFrameOption == QuaternionBaseAction.everyFrameOptions.FixedUpdate)
			{
				this.DoQuatLookRotation();
			}
		}

		// Token: 0x0600425D RID: 16989 RVA: 0x0016FA20 File Offset: 0x0016DC20
		private void DoQuatLookRotation()
		{
			if (!this.upVector.IsNone)
			{
				this.result.Value = Quaternion.LookRotation(this.direction.Value, this.upVector.Value);
				return;
			}
			this.result.Value = Quaternion.LookRotation(this.direction.Value);
		}

		// Token: 0x040046AC RID: 18092
		[RequiredField]
		[Tooltip("the rotation direction")]
		public FsmVector3 direction;

		// Token: 0x040046AD RID: 18093
		[Tooltip("The up direction")]
		public FsmVector3 upVector;

		// Token: 0x040046AE RID: 18094
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the inverse of the rotation variable.")]
		public FsmQuaternion result;
	}
}
