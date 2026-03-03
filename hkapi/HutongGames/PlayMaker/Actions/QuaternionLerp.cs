using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C64 RID: 3172
	[ActionCategory(ActionCategory.Quaternion)]
	[Tooltip("Interpolates between from and to by t and normalizes the result afterwards.")]
	public class QuaternionLerp : QuaternionBaseAction
	{
		// Token: 0x06004251 RID: 16977 RVA: 0x0016F8D4 File Offset: 0x0016DAD4
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
			this.amount = 0.5f;
			this.storeResult = null;
			this.everyFrame = true;
			this.everyFrameOption = QuaternionBaseAction.everyFrameOptions.Update;
		}

		// Token: 0x06004252 RID: 16978 RVA: 0x0016F92A File Offset: 0x0016DB2A
		public override void OnEnter()
		{
			this.DoQuatLerp();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004253 RID: 16979 RVA: 0x0016F940 File Offset: 0x0016DB40
		public override void OnUpdate()
		{
			if (this.everyFrameOption == QuaternionBaseAction.everyFrameOptions.Update)
			{
				this.DoQuatLerp();
			}
		}

		// Token: 0x06004254 RID: 16980 RVA: 0x0016F950 File Offset: 0x0016DB50
		public override void OnLateUpdate()
		{
			if (this.everyFrameOption == QuaternionBaseAction.everyFrameOptions.LateUpdate)
			{
				this.DoQuatLerp();
			}
		}

		// Token: 0x06004255 RID: 16981 RVA: 0x0016F961 File Offset: 0x0016DB61
		public override void OnFixedUpdate()
		{
			if (this.everyFrameOption == QuaternionBaseAction.everyFrameOptions.FixedUpdate)
			{
				this.DoQuatLerp();
			}
		}

		// Token: 0x06004256 RID: 16982 RVA: 0x0016F972 File Offset: 0x0016DB72
		private void DoQuatLerp()
		{
			this.storeResult.Value = Quaternion.Lerp(this.fromQuaternion.Value, this.toQuaternion.Value, this.amount.Value);
		}

		// Token: 0x040046A8 RID: 18088
		[RequiredField]
		[Tooltip("From Quaternion.")]
		public FsmQuaternion fromQuaternion;

		// Token: 0x040046A9 RID: 18089
		[RequiredField]
		[Tooltip("To Quaternion.")]
		public FsmQuaternion toQuaternion;

		// Token: 0x040046AA RID: 18090
		[RequiredField]
		[Tooltip("Interpolate between fromQuaternion and toQuaternion by this amount. Value is clamped to 0-1 range. 0 = fromQuaternion; 1 = toQuaternion; 0.5 = half way between.")]
		[HasFloatSlider(0f, 1f)]
		public FsmFloat amount;

		// Token: 0x040046AB RID: 18091
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in this quaternion variable.")]
		public FsmQuaternion storeResult;
	}
}
