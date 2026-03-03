using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CEF RID: 3311
	[ActionCategory(ActionCategory.Transform)]
	[Tooltip("Smoothly Rotates a Game Object so its forward vector points in the specified Direction. Lets you fire an event when minmagnitude is reached")]
	public class SmoothLookAtDirection : FsmStateAction
	{
		// Token: 0x060044D1 RID: 17617 RVA: 0x00177160 File Offset: 0x00175360
		public override void Reset()
		{
			this.gameObject = null;
			this.targetDirection = new FsmVector3
			{
				UseVariable = true
			};
			this.minMagnitude = 0.1f;
			this.upVector = new FsmVector3
			{
				UseVariable = true
			};
			this.keepVertical = true;
			this.speed = 5f;
			this.lateUpdate = true;
			this.finishEvent = null;
		}

		// Token: 0x060044D2 RID: 17618 RVA: 0x001593EE File Offset: 0x001575EE
		public override void OnPreprocess()
		{
			base.Fsm.HandleLateUpdate = true;
		}

		// Token: 0x060044D3 RID: 17619 RVA: 0x001771D2 File Offset: 0x001753D2
		public override void OnEnter()
		{
			this.previousGo = null;
		}

		// Token: 0x060044D4 RID: 17620 RVA: 0x001771DB File Offset: 0x001753DB
		public override void OnUpdate()
		{
			if (!this.lateUpdate)
			{
				this.DoSmoothLookAtDirection();
			}
		}

		// Token: 0x060044D5 RID: 17621 RVA: 0x001771EB File Offset: 0x001753EB
		public override void OnLateUpdate()
		{
			if (this.lateUpdate)
			{
				this.DoSmoothLookAtDirection();
			}
		}

		// Token: 0x060044D6 RID: 17622 RVA: 0x001771FC File Offset: 0x001753FC
		private void DoSmoothLookAtDirection()
		{
			if (this.targetDirection.IsNone)
			{
				return;
			}
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			if (this.previousGo != ownerDefaultTarget)
			{
				this.lastRotation = ownerDefaultTarget.transform.rotation;
				this.desiredRotation = this.lastRotation;
				this.previousGo = ownerDefaultTarget;
			}
			Vector3 value = this.targetDirection.Value;
			if (this.keepVertical.Value)
			{
				value.y = 0f;
			}
			bool flag = false;
			if (value.sqrMagnitude > this.minMagnitude.Value)
			{
				this.desiredRotation = Quaternion.LookRotation(value, this.upVector.IsNone ? Vector3.up : this.upVector.Value);
			}
			else
			{
				flag = true;
			}
			this.lastRotation = Quaternion.Slerp(this.lastRotation, this.desiredRotation, this.speed.Value * Time.deltaTime);
			ownerDefaultTarget.transform.rotation = this.lastRotation;
			if (flag)
			{
				base.Fsm.Event(this.finishEvent);
				if (this.finish.Value)
				{
					base.Finish();
				}
			}
		}

		// Token: 0x0400491D RID: 18717
		[RequiredField]
		[Tooltip("The GameObject to rotate.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400491E RID: 18718
		[RequiredField]
		[Tooltip("The direction to smoothly rotate towards.")]
		public FsmVector3 targetDirection;

		// Token: 0x0400491F RID: 18719
		[Tooltip("Only rotate if Target Direction Vector length is greater than this threshold.")]
		public FsmFloat minMagnitude;

		// Token: 0x04004920 RID: 18720
		[Tooltip("Keep this vector pointing up as the GameObject rotates.")]
		public FsmVector3 upVector;

		// Token: 0x04004921 RID: 18721
		[RequiredField]
		[Tooltip("Eliminate any tilt up/down as the GameObject rotates.")]
		public FsmBool keepVertical;

		// Token: 0x04004922 RID: 18722
		[RequiredField]
		[HasFloatSlider(0.5f, 15f)]
		[Tooltip("How quickly to rotate.")]
		public FsmFloat speed;

		// Token: 0x04004923 RID: 18723
		[Tooltip("Perform in LateUpdate. This can help eliminate jitters in some situations.")]
		public bool lateUpdate;

		// Token: 0x04004924 RID: 18724
		[Tooltip("Event to send if the direction difference is less than Min Magnitude.")]
		public FsmEvent finishEvent;

		// Token: 0x04004925 RID: 18725
		[Tooltip("Stop running the action if the direction difference is less than Min Magnitude.")]
		public FsmBool finish;

		// Token: 0x04004926 RID: 18726
		private GameObject previousGo;

		// Token: 0x04004927 RID: 18727
		private Quaternion lastRotation;

		// Token: 0x04004928 RID: 18728
		private Quaternion desiredRotation;
	}
}
