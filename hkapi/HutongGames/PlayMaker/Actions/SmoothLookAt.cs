using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CEE RID: 3310
	[ActionCategory(ActionCategory.Transform)]
	[Tooltip("Smoothly Rotates a Game Object so its forward vector points at a Target. The target can be defined as a Game Object or a world Position. If you specify both, then the position will be used as a local offset from the object's position.")]
	public class SmoothLookAt : FsmStateAction
	{
		// Token: 0x060044CB RID: 17611 RVA: 0x00176EE4 File Offset: 0x001750E4
		public override void Reset()
		{
			this.gameObject = null;
			this.targetObject = null;
			this.targetPosition = new FsmVector3
			{
				UseVariable = true
			};
			this.upVector = new FsmVector3
			{
				UseVariable = true
			};
			this.keepVertical = true;
			this.debug = false;
			this.speed = 5f;
			this.finishTolerance = 1f;
			this.finishEvent = null;
		}

		// Token: 0x060044CC RID: 17612 RVA: 0x001593EE File Offset: 0x001575EE
		public override void OnPreprocess()
		{
			base.Fsm.HandleLateUpdate = true;
		}

		// Token: 0x060044CD RID: 17613 RVA: 0x00176F62 File Offset: 0x00175162
		public override void OnEnter()
		{
			this.previousGo = null;
		}

		// Token: 0x060044CE RID: 17614 RVA: 0x00176F6B File Offset: 0x0017516B
		public override void OnLateUpdate()
		{
			this.DoSmoothLookAt();
		}

		// Token: 0x060044CF RID: 17615 RVA: 0x00176F74 File Offset: 0x00175174
		private void DoSmoothLookAt()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			GameObject value = this.targetObject.Value;
			if (value == null && this.targetPosition.IsNone)
			{
				return;
			}
			if (this.previousGo != ownerDefaultTarget)
			{
				this.lastRotation = ownerDefaultTarget.transform.rotation;
				this.desiredRotation = this.lastRotation;
				this.previousGo = ownerDefaultTarget;
			}
			Vector3 vector;
			if (value != null)
			{
				vector = ((!this.targetPosition.IsNone) ? value.transform.TransformPoint(this.targetPosition.Value) : value.transform.position);
			}
			else
			{
				vector = this.targetPosition.Value;
			}
			if (this.keepVertical.Value)
			{
				vector.y = ownerDefaultTarget.transform.position.y;
			}
			Vector3 vector2 = vector - ownerDefaultTarget.transform.position;
			if (vector2 != Vector3.zero && vector2.sqrMagnitude > 0f)
			{
				this.desiredRotation = Quaternion.LookRotation(vector2, this.upVector.IsNone ? Vector3.up : this.upVector.Value);
			}
			this.lastRotation = Quaternion.Slerp(this.lastRotation, this.desiredRotation, this.speed.Value * Time.deltaTime);
			ownerDefaultTarget.transform.rotation = this.lastRotation;
			if (this.debug.Value)
			{
				Debug.DrawLine(ownerDefaultTarget.transform.position, vector, Color.grey);
			}
			if (this.finishEvent != null && Mathf.Abs(Vector3.Angle(vector - ownerDefaultTarget.transform.position, ownerDefaultTarget.transform.forward)) <= this.finishTolerance.Value)
			{
				base.Fsm.Event(this.finishEvent);
			}
		}

		// Token: 0x04004911 RID: 18705
		[RequiredField]
		[Tooltip("The GameObject to rotate to face a target.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004912 RID: 18706
		[Tooltip("A target GameObject.")]
		public FsmGameObject targetObject;

		// Token: 0x04004913 RID: 18707
		[Tooltip("A target position. If a Target Object is defined, this is used as a local offset.")]
		public FsmVector3 targetPosition;

		// Token: 0x04004914 RID: 18708
		[Tooltip("Used to keep the game object generally upright. If left undefined the world y axis is used.")]
		public FsmVector3 upVector;

		// Token: 0x04004915 RID: 18709
		[Tooltip("Force the game object to remain vertical. Useful for characters.")]
		public FsmBool keepVertical;

		// Token: 0x04004916 RID: 18710
		[HasFloatSlider(0.5f, 15f)]
		[Tooltip("How fast the look at moves.")]
		public FsmFloat speed;

		// Token: 0x04004917 RID: 18711
		[Tooltip("Draw a line in the Scene View to the look at position.")]
		public FsmBool debug;

		// Token: 0x04004918 RID: 18712
		[Tooltip("If the angle to the target is less than this, send the Finish Event below. Measured in degrees.")]
		public FsmFloat finishTolerance;

		// Token: 0x04004919 RID: 18713
		[Tooltip("Event to send if the angle to target is less than the Finish Tolerance.")]
		public FsmEvent finishEvent;

		// Token: 0x0400491A RID: 18714
		private GameObject previousGo;

		// Token: 0x0400491B RID: 18715
		private Quaternion lastRotation;

		// Token: 0x0400491C RID: 18716
		private Quaternion desiredRotation;
	}
}
