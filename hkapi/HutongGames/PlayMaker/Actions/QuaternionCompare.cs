using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C61 RID: 3169
	[ActionCategory(ActionCategory.Quaternion)]
	[Tooltip("Check if two quaternions are equals or not. Takes in account inversed representations of quaternions")]
	public class QuaternionCompare : QuaternionBaseAction
	{
		// Token: 0x0600423C RID: 16956 RVA: 0x0016F6CC File Offset: 0x0016D8CC
		public override void Reset()
		{
			this.Quaternion1 = new FsmQuaternion
			{
				UseVariable = true
			};
			this.Quaternion2 = new FsmQuaternion
			{
				UseVariable = true
			};
			this.equal = null;
			this.equalEvent = null;
			this.notEqualEvent = null;
			this.everyFrameOption = QuaternionBaseAction.everyFrameOptions.Update;
		}

		// Token: 0x0600423D RID: 16957 RVA: 0x0016F719 File Offset: 0x0016D919
		public override void OnEnter()
		{
			this.DoQuatCompare();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600423E RID: 16958 RVA: 0x0016F72F File Offset: 0x0016D92F
		public override void OnUpdate()
		{
			if (this.everyFrameOption == QuaternionBaseAction.everyFrameOptions.Update)
			{
				this.DoQuatCompare();
			}
		}

		// Token: 0x0600423F RID: 16959 RVA: 0x0016F73F File Offset: 0x0016D93F
		public override void OnLateUpdate()
		{
			if (this.everyFrameOption == QuaternionBaseAction.everyFrameOptions.LateUpdate)
			{
				this.DoQuatCompare();
			}
		}

		// Token: 0x06004240 RID: 16960 RVA: 0x0016F750 File Offset: 0x0016D950
		public override void OnFixedUpdate()
		{
			if (this.everyFrameOption == QuaternionBaseAction.everyFrameOptions.FixedUpdate)
			{
				this.DoQuatCompare();
			}
		}

		// Token: 0x06004241 RID: 16961 RVA: 0x0016F764 File Offset: 0x0016D964
		private void DoQuatCompare()
		{
			bool flag = Mathf.Abs(Quaternion.Dot(this.Quaternion1.Value, this.Quaternion2.Value)) > 0.999999f;
			this.equal.Value = flag;
			if (flag)
			{
				base.Fsm.Event(this.equalEvent);
				return;
			}
			base.Fsm.Event(this.notEqualEvent);
		}

		// Token: 0x0400469F RID: 18079
		[RequiredField]
		[Tooltip("First Quaternion")]
		public FsmQuaternion Quaternion1;

		// Token: 0x040046A0 RID: 18080
		[RequiredField]
		[Tooltip("Second Quaternion")]
		public FsmQuaternion Quaternion2;

		// Token: 0x040046A1 RID: 18081
		[Tooltip("true if Quaternions are equal")]
		public FsmBool equal;

		// Token: 0x040046A2 RID: 18082
		[Tooltip("Event sent if Quaternions are equal")]
		public FsmEvent equalEvent;

		// Token: 0x040046A3 RID: 18083
		[Tooltip("Event sent if Quaternions are not equal")]
		public FsmEvent notEqualEvent;
	}
}
