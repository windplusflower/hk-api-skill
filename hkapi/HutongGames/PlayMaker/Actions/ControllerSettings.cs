using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B4C RID: 2892
	[ActionCategory(ActionCategory.Character)]
	[Tooltip("Modify various character controller settings.\n'None' leaves the setting unchanged.")]
	public class ControllerSettings : FsmStateAction
	{
		// Token: 0x06003DC9 RID: 15817 RVA: 0x00162898 File Offset: 0x00160A98
		public override void Reset()
		{
			this.gameObject = null;
			this.height = new FsmFloat
			{
				UseVariable = true
			};
			this.radius = new FsmFloat
			{
				UseVariable = true
			};
			this.slopeLimit = new FsmFloat
			{
				UseVariable = true
			};
			this.stepOffset = new FsmFloat
			{
				UseVariable = true
			};
			this.center = new FsmVector3
			{
				UseVariable = true
			};
			this.detectCollisions = new FsmBool
			{
				UseVariable = true
			};
			this.everyFrame = false;
		}

		// Token: 0x06003DCA RID: 15818 RVA: 0x0016291F File Offset: 0x00160B1F
		public override void OnEnter()
		{
			this.DoControllerSettings();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003DCB RID: 15819 RVA: 0x00162935 File Offset: 0x00160B35
		public override void OnUpdate()
		{
			this.DoControllerSettings();
		}

		// Token: 0x06003DCC RID: 15820 RVA: 0x00162940 File Offset: 0x00160B40
		private void DoControllerSettings()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			if (ownerDefaultTarget != this.previousGo)
			{
				this.controller = ownerDefaultTarget.GetComponent<CharacterController>();
				this.previousGo = ownerDefaultTarget;
			}
			if (this.controller != null)
			{
				if (!this.height.IsNone)
				{
					this.controller.height = this.height.Value;
				}
				if (!this.radius.IsNone)
				{
					this.controller.radius = this.radius.Value;
				}
				if (!this.slopeLimit.IsNone)
				{
					this.controller.slopeLimit = this.slopeLimit.Value;
				}
				if (!this.stepOffset.IsNone)
				{
					this.controller.stepOffset = this.stepOffset.Value;
				}
				if (!this.center.IsNone)
				{
					this.controller.center = this.center.Value;
				}
				if (!this.detectCollisions.IsNone)
				{
					this.controller.detectCollisions = this.detectCollisions.Value;
				}
			}
		}

		// Token: 0x040041E1 RID: 16865
		[RequiredField]
		[CheckForComponent(typeof(CharacterController))]
		[Tooltip("The GameObject that owns the CharacterController.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040041E2 RID: 16866
		[Tooltip("The height of the character's capsule.")]
		public FsmFloat height;

		// Token: 0x040041E3 RID: 16867
		[Tooltip("The radius of the character's capsule.")]
		public FsmFloat radius;

		// Token: 0x040041E4 RID: 16868
		[Tooltip("The character controllers slope limit in degrees.")]
		public FsmFloat slopeLimit;

		// Token: 0x040041E5 RID: 16869
		[Tooltip("The character controllers step offset in meters.")]
		public FsmFloat stepOffset;

		// Token: 0x040041E6 RID: 16870
		[Tooltip("The center of the character's capsule relative to the transform's position")]
		public FsmVector3 center;

		// Token: 0x040041E7 RID: 16871
		[Tooltip("Should other rigidbodies or character controllers collide with this character controller (By default always enabled).")]
		public FsmBool detectCollisions;

		// Token: 0x040041E8 RID: 16872
		[Tooltip("Repeat every frame while the state is active.")]
		public bool everyFrame;

		// Token: 0x040041E9 RID: 16873
		private GameObject previousGo;

		// Token: 0x040041EA RID: 16874
		private CharacterController controller;
	}
}
