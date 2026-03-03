using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C3A RID: 3130
	[ActionCategory(ActionCategory.Transform)]
	[Tooltip("Rotates a Game Object so its forward vector points at a Target. The Target can be specified as a GameObject or a world Position. If you specify both, then Position specifies a local offset from the target object's Position.")]
	public class LookAt : FsmStateAction
	{
		// Token: 0x06004187 RID: 16775 RVA: 0x0016CCD0 File Offset: 0x0016AED0
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
			this.debugLineColor = Color.yellow;
			this.everyFrame = true;
		}

		// Token: 0x06004188 RID: 16776 RVA: 0x001593EE File Offset: 0x001575EE
		public override void OnPreprocess()
		{
			base.Fsm.HandleLateUpdate = true;
		}

		// Token: 0x06004189 RID: 16777 RVA: 0x0016CD3E File Offset: 0x0016AF3E
		public override void OnEnter()
		{
			this.DoLookAt();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600418A RID: 16778 RVA: 0x0016CD54 File Offset: 0x0016AF54
		public override void OnLateUpdate()
		{
			this.DoLookAt();
		}

		// Token: 0x0600418B RID: 16779 RVA: 0x0016CD5C File Offset: 0x0016AF5C
		private void DoLookAt()
		{
			if (!this.UpdateLookAtPosition())
			{
				return;
			}
			this.go.transform.LookAt(this.lookAtPos, this.upVector.IsNone ? Vector3.up : this.upVector.Value);
			if (this.debug.Value)
			{
				Debug.DrawLine(this.go.transform.position, this.lookAtPos, this.debugLineColor.Value);
			}
		}

		// Token: 0x0600418C RID: 16780 RVA: 0x0016CDDC File Offset: 0x0016AFDC
		public bool UpdateLookAtPosition()
		{
			if (base.Fsm == null)
			{
				return false;
			}
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
				this.lookAtPos = ((!this.targetPosition.IsNone) ? this.goTarget.transform.TransformPoint(this.targetPosition.Value) : this.goTarget.transform.position);
			}
			else
			{
				this.lookAtPos = this.targetPosition.Value;
			}
			this.lookAtPosWithVertical = this.lookAtPos;
			if (this.keepVertical.Value)
			{
				this.lookAtPos.y = this.go.transform.position.y;
			}
			return true;
		}

		// Token: 0x0600418D RID: 16781 RVA: 0x0016CEE3 File Offset: 0x0016B0E3
		public Vector3 GetLookAtPosition()
		{
			return this.lookAtPos;
		}

		// Token: 0x0600418E RID: 16782 RVA: 0x0016CEEB File Offset: 0x0016B0EB
		public Vector3 GetLookAtPositionWithVertical()
		{
			return this.lookAtPosWithVertical;
		}

		// Token: 0x0600418F RID: 16783 RVA: 0x0016CEF3 File Offset: 0x0016B0F3
		public LookAt()
		{
			this.everyFrame = true;
			base..ctor();
		}

		// Token: 0x040045D0 RID: 17872
		[RequiredField]
		[Tooltip("The GameObject to rotate.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040045D1 RID: 17873
		[Tooltip("The GameObject to Look At.")]
		public FsmGameObject targetObject;

		// Token: 0x040045D2 RID: 17874
		[Tooltip("World position to look at, or local offset from Target Object if specified.")]
		public FsmVector3 targetPosition;

		// Token: 0x040045D3 RID: 17875
		[Tooltip("Rotate the GameObject to point its up direction vector in the direction hinted at by the Up Vector. See Unity Look At docs for more details.")]
		public FsmVector3 upVector;

		// Token: 0x040045D4 RID: 17876
		[Tooltip("Don't rotate vertically.")]
		public FsmBool keepVertical;

		// Token: 0x040045D5 RID: 17877
		[Title("Draw Debug Line")]
		[Tooltip("Draw a debug line from the GameObject to the Target.")]
		public FsmBool debug;

		// Token: 0x040045D6 RID: 17878
		[Tooltip("Color to use for the debug line.")]
		public FsmColor debugLineColor;

		// Token: 0x040045D7 RID: 17879
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		// Token: 0x040045D8 RID: 17880
		private GameObject go;

		// Token: 0x040045D9 RID: 17881
		private GameObject goTarget;

		// Token: 0x040045DA RID: 17882
		private Vector3 lookAtPos;

		// Token: 0x040045DB RID: 17883
		private Vector3 lookAtPosWithVertical;
	}
}
