using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C68 RID: 3176
	[ActionCategory(ActionCategory.Quaternion)]
	[Tooltip("Spherically interpolates between from and to by t.")]
	public class QuaternionSlerp : QuaternionBaseAction
	{
		// Token: 0x0600426D RID: 17005 RVA: 0x0016FD70 File Offset: 0x0016DF70
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
			this.amount = 0.1f;
			this.storeResult = null;
			this.everyFrame = true;
			this.everyFrameOption = QuaternionBaseAction.everyFrameOptions.Update;
		}

		// Token: 0x0600426E RID: 17006 RVA: 0x0016FDC6 File Offset: 0x0016DFC6
		public override void OnEnter()
		{
			this.DoQuatSlerp();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600426F RID: 17007 RVA: 0x0016FDDC File Offset: 0x0016DFDC
		public override void OnUpdate()
		{
			if (this.everyFrameOption == QuaternionBaseAction.everyFrameOptions.Update)
			{
				this.DoQuatSlerp();
			}
		}

		// Token: 0x06004270 RID: 17008 RVA: 0x0016FDEC File Offset: 0x0016DFEC
		public override void OnLateUpdate()
		{
			if (this.everyFrameOption == QuaternionBaseAction.everyFrameOptions.LateUpdate)
			{
				this.DoQuatSlerp();
			}
		}

		// Token: 0x06004271 RID: 17009 RVA: 0x0016FDFD File Offset: 0x0016DFFD
		public override void OnFixedUpdate()
		{
			if (this.everyFrameOption == QuaternionBaseAction.everyFrameOptions.FixedUpdate)
			{
				this.DoQuatSlerp();
			}
		}

		// Token: 0x06004272 RID: 17010 RVA: 0x0016FE0E File Offset: 0x0016E00E
		private void DoQuatSlerp()
		{
			this.storeResult.Value = Quaternion.Slerp(this.fromQuaternion.Value, this.toQuaternion.Value, this.amount.Value);
		}

		// Token: 0x040046B6 RID: 18102
		[RequiredField]
		[Tooltip("From Quaternion.")]
		public FsmQuaternion fromQuaternion;

		// Token: 0x040046B7 RID: 18103
		[RequiredField]
		[Tooltip("To Quaternion.")]
		public FsmQuaternion toQuaternion;

		// Token: 0x040046B8 RID: 18104
		[RequiredField]
		[Tooltip("Interpolate between fromQuaternion and toQuaternion by this amount. Value is clamped to 0-1 range. 0 = fromQuaternion; 1 = toQuaternion; 0.5 = half way between.")]
		[HasFloatSlider(0f, 1f)]
		public FsmFloat amount;

		// Token: 0x040046B9 RID: 18105
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in this quaternion variable.")]
		public FsmQuaternion storeResult;
	}
}
