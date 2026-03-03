using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C42 RID: 3138
	[ActionCategory(ActionCategory.Transform)]
	[Tooltip("Moves a Game Object towards a Target. Optionally sends an event when successful. The Target can be specified as a Game Object or a world Position. If you specify both, then the Position is used as a local offset from the Object's Position.")]
	public class MoveTowards : FsmStateAction
	{
		// Token: 0x060041B0 RID: 16816 RVA: 0x0016DA3B File Offset: 0x0016BC3B
		public override void Reset()
		{
			this.gameObject = null;
			this.targetObject = null;
			this.maxSpeed = 10f;
			this.finishDistance = 1f;
			this.finishEvent = null;
		}

		// Token: 0x060041B1 RID: 16817 RVA: 0x0016DA72 File Offset: 0x0016BC72
		public override void OnUpdate()
		{
			this.DoMoveTowards();
		}

		// Token: 0x060041B2 RID: 16818 RVA: 0x0016DA7C File Offset: 0x0016BC7C
		private void DoMoveTowards()
		{
			if (!this.UpdateTargetPos())
			{
				return;
			}
			this.go.transform.position = Vector3.MoveTowards(this.go.transform.position, this.targetPos, this.maxSpeed.Value * Time.deltaTime);
			if ((this.go.transform.position - this.targetPos).magnitude < this.finishDistance.Value)
			{
				base.Fsm.Event(this.finishEvent);
				base.Finish();
			}
		}

		// Token: 0x060041B3 RID: 16819 RVA: 0x0016DB18 File Offset: 0x0016BD18
		public bool UpdateTargetPos()
		{
			this.go = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (this.go == null)
			{
				return false;
			}
			this.goTarget = this.targetObject.Value;
			if (this.goTarget == null && this.targetPosition.IsNone)
			{
				return false;
			}
			if (this.goTarget != null)
			{
				this.targetPos = ((!this.targetPosition.IsNone) ? this.goTarget.transform.TransformPoint(this.targetPosition.Value) : this.goTarget.transform.position);
			}
			else
			{
				this.targetPos = this.targetPosition.Value;
			}
			this.targetPosWithVertical = this.targetPos;
			if (this.ignoreVertical.Value)
			{
				this.targetPos.y = this.go.transform.position.y;
			}
			return true;
		}

		// Token: 0x060041B4 RID: 16820 RVA: 0x0016DC15 File Offset: 0x0016BE15
		public Vector3 GetTargetPos()
		{
			return this.targetPos;
		}

		// Token: 0x060041B5 RID: 16821 RVA: 0x0016DC1D File Offset: 0x0016BE1D
		public Vector3 GetTargetPosWithVertical()
		{
			return this.targetPosWithVertical;
		}

		// Token: 0x04004612 RID: 17938
		[RequiredField]
		[Tooltip("The GameObject to Move")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004613 RID: 17939
		[Tooltip("A target GameObject to move towards. Or use a world Target Position below.")]
		public FsmGameObject targetObject;

		// Token: 0x04004614 RID: 17940
		[Tooltip("A world position if no Target Object. Otherwise used as a local offset from the Target Object.")]
		public FsmVector3 targetPosition;

		// Token: 0x04004615 RID: 17941
		[Tooltip("Ignore any height difference in the target.")]
		public FsmBool ignoreVertical;

		// Token: 0x04004616 RID: 17942
		[HasFloatSlider(0f, 20f)]
		[Tooltip("The maximum movement speed. HINT: You can make this a variable to change it over time.")]
		public FsmFloat maxSpeed;

		// Token: 0x04004617 RID: 17943
		[HasFloatSlider(0f, 5f)]
		[Tooltip("Distance at which the move is considered finished, and the Finish Event is sent.")]
		public FsmFloat finishDistance;

		// Token: 0x04004618 RID: 17944
		[Tooltip("Event to send when the Finish Distance is reached.")]
		public FsmEvent finishEvent;

		// Token: 0x04004619 RID: 17945
		private GameObject go;

		// Token: 0x0400461A RID: 17946
		private GameObject goTarget;

		// Token: 0x0400461B RID: 17947
		private Vector3 targetPos;

		// Token: 0x0400461C RID: 17948
		private Vector3 targetPosWithVertical;
	}
}
