using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C79 RID: 3193
	[ActionCategory(ActionCategory.Transform)]
	[Tooltip("Rotates a Game Object around each Axis. Use a Vector3 Variable and/or XYZ components. To leave any axis unchanged, set variable to 'None'.")]
	public class Rotate : FsmStateAction
	{
		// Token: 0x060042B1 RID: 17073 RVA: 0x00170C0C File Offset: 0x0016EE0C
		public override void Reset()
		{
			this.gameObject = null;
			this.vector = null;
			this.xAngle = new FsmFloat
			{
				UseVariable = true
			};
			this.yAngle = new FsmFloat
			{
				UseVariable = true
			};
			this.zAngle = new FsmFloat
			{
				UseVariable = true
			};
			this.space = Space.Self;
			this.perSecond = false;
			this.everyFrame = true;
			this.lateUpdate = false;
			this.fixedUpdate = false;
		}

		// Token: 0x060042B2 RID: 17074 RVA: 0x00170C80 File Offset: 0x0016EE80
		public override void OnPreprocess()
		{
			if (this.fixedUpdate)
			{
				base.Fsm.HandleFixedUpdate = true;
			}
			if (this.lateUpdate)
			{
				base.Fsm.HandleLateUpdate = true;
			}
		}

		// Token: 0x060042B3 RID: 17075 RVA: 0x00170CAA File Offset: 0x0016EEAA
		public override void OnEnter()
		{
			if (!this.everyFrame && !this.lateUpdate && !this.fixedUpdate)
			{
				this.DoRotate();
				base.Finish();
			}
		}

		// Token: 0x060042B4 RID: 17076 RVA: 0x00170CD0 File Offset: 0x0016EED0
		public override void OnUpdate()
		{
			if (!this.lateUpdate && !this.fixedUpdate)
			{
				this.DoRotate();
			}
		}

		// Token: 0x060042B5 RID: 17077 RVA: 0x00170CE8 File Offset: 0x0016EEE8
		public override void OnLateUpdate()
		{
			if (this.lateUpdate)
			{
				this.DoRotate();
			}
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060042B6 RID: 17078 RVA: 0x00170D06 File Offset: 0x0016EF06
		public override void OnFixedUpdate()
		{
			if (this.fixedUpdate)
			{
				this.DoRotate();
			}
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060042B7 RID: 17079 RVA: 0x00170D24 File Offset: 0x0016EF24
		private void DoRotate()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			Vector3 vector = this.vector.IsNone ? new Vector3(this.xAngle.Value, this.yAngle.Value, this.zAngle.Value) : this.vector.Value;
			if (!this.xAngle.IsNone)
			{
				vector.x = this.xAngle.Value;
			}
			if (!this.yAngle.IsNone)
			{
				vector.y = this.yAngle.Value;
			}
			if (!this.zAngle.IsNone)
			{
				vector.z = this.zAngle.Value;
			}
			if (!this.perSecond)
			{
				ownerDefaultTarget.transform.Rotate(vector, this.space);
				return;
			}
			ownerDefaultTarget.transform.Rotate(vector * Time.deltaTime, this.space);
		}

		// Token: 0x04004708 RID: 18184
		[RequiredField]
		[Tooltip("The game object to rotate.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004709 RID: 18185
		[Tooltip("A rotation vector. NOTE: You can override individual axis below.")]
		[UIHint(UIHint.Variable)]
		public FsmVector3 vector;

		// Token: 0x0400470A RID: 18186
		[Tooltip("Rotation around x axis.")]
		public FsmFloat xAngle;

		// Token: 0x0400470B RID: 18187
		[Tooltip("Rotation around y axis.")]
		public FsmFloat yAngle;

		// Token: 0x0400470C RID: 18188
		[Tooltip("Rotation around z axis.")]
		public FsmFloat zAngle;

		// Token: 0x0400470D RID: 18189
		[Tooltip("Rotate in local or world space.")]
		public Space space;

		// Token: 0x0400470E RID: 18190
		[Tooltip("Rotate over one second")]
		public bool perSecond;

		// Token: 0x0400470F RID: 18191
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		// Token: 0x04004710 RID: 18192
		[Tooltip("Perform the rotation in LateUpdate. This is useful if you want to override the rotation of objects that are animated or otherwise rotated in Update.")]
		public bool lateUpdate;

		// Token: 0x04004711 RID: 18193
		[Tooltip("Perform the rotation in FixedUpdate. This is useful when working with rigid bodies and physics.")]
		public bool fixedUpdate;
	}
}
