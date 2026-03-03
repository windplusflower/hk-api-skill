using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CDF RID: 3295
	[ActionCategory(ActionCategory.Transform)]
	[Tooltip("Sets the Rotation of a Game Object. To leave any axis unchanged, set variable to 'None'.")]
	public class SetRotation : FsmStateAction
	{
		// Token: 0x06004480 RID: 17536 RVA: 0x00175F9C File Offset: 0x0017419C
		public override void Reset()
		{
			this.gameObject = null;
			this.quaternion = null;
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
			this.space = Space.World;
			this.everyFrame = false;
			this.lateUpdate = false;
		}

		// Token: 0x06004481 RID: 17537 RVA: 0x00176009 File Offset: 0x00174209
		public override void OnPreprocess()
		{
			if (this.lateUpdate)
			{
				base.Fsm.HandleLateUpdate = true;
			}
		}

		// Token: 0x06004482 RID: 17538 RVA: 0x0017601F File Offset: 0x0017421F
		public override void OnEnter()
		{
			if (!this.everyFrame && !this.lateUpdate)
			{
				this.DoSetRotation();
				base.Finish();
			}
		}

		// Token: 0x06004483 RID: 17539 RVA: 0x0017603D File Offset: 0x0017423D
		public override void OnUpdate()
		{
			if (!this.lateUpdate)
			{
				this.DoSetRotation();
			}
		}

		// Token: 0x06004484 RID: 17540 RVA: 0x0017604D File Offset: 0x0017424D
		public override void OnLateUpdate()
		{
			if (this.lateUpdate)
			{
				this.DoSetRotation();
			}
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004485 RID: 17541 RVA: 0x0017606C File Offset: 0x0017426C
		private void DoSetRotation()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			Vector3 vector;
			if (!this.quaternion.IsNone)
			{
				vector = this.quaternion.Value.eulerAngles;
			}
			else if (!this.vector.IsNone)
			{
				vector = this.vector.Value;
			}
			else
			{
				vector = ((this.space == Space.Self) ? ownerDefaultTarget.transform.localEulerAngles : ownerDefaultTarget.transform.eulerAngles);
			}
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
			if (this.space == Space.Self)
			{
				ownerDefaultTarget.transform.localEulerAngles = vector;
				return;
			}
			ownerDefaultTarget.transform.eulerAngles = vector;
		}

		// Token: 0x040048C7 RID: 18631
		[RequiredField]
		[Tooltip("The GameObject to rotate.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040048C8 RID: 18632
		[UIHint(UIHint.Variable)]
		[Tooltip("Use a stored quaternion, or vector angles below.")]
		public FsmQuaternion quaternion;

		// Token: 0x040048C9 RID: 18633
		[UIHint(UIHint.Variable)]
		[Title("Euler Angles")]
		[Tooltip("Use euler angles stored in a Vector3 variable, and/or set each axis below.")]
		public FsmVector3 vector;

		// Token: 0x040048CA RID: 18634
		public FsmFloat xAngle;

		// Token: 0x040048CB RID: 18635
		public FsmFloat yAngle;

		// Token: 0x040048CC RID: 18636
		public FsmFloat zAngle;

		// Token: 0x040048CD RID: 18637
		[Tooltip("Use local or world space.")]
		public Space space;

		// Token: 0x040048CE RID: 18638
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		// Token: 0x040048CF RID: 18639
		[Tooltip("Perform in LateUpdate. This is useful if you want to override the position of objects that are animated or otherwise positioned in Update.")]
		public bool lateUpdate;
	}
}
