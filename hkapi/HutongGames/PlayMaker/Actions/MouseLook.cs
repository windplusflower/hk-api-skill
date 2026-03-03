using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C3B RID: 3131
	[ActionCategory(ActionCategory.Input)]
	[Tooltip("Rotates a GameObject based on mouse movement. Minimum and Maximum values can be used to constrain the rotation.")]
	public class MouseLook : FsmStateAction
	{
		// Token: 0x06004190 RID: 16784 RVA: 0x0016CF04 File Offset: 0x0016B104
		public override void Reset()
		{
			this.gameObject = null;
			this.axes = MouseLook.RotationAxes.MouseXAndY;
			this.sensitivityX = 15f;
			this.sensitivityY = 15f;
			this.minimumX = new FsmFloat
			{
				UseVariable = true
			};
			this.maximumX = new FsmFloat
			{
				UseVariable = true
			};
			this.minimumY = -60f;
			this.maximumY = 60f;
			this.everyFrame = true;
		}

		// Token: 0x06004191 RID: 16785 RVA: 0x0016CF8C File Offset: 0x0016B18C
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				base.Finish();
				return;
			}
			Rigidbody component = ownerDefaultTarget.GetComponent<Rigidbody>();
			if (component != null)
			{
				component.freezeRotation = true;
			}
			this.rotationX = ownerDefaultTarget.transform.localRotation.eulerAngles.y;
			this.rotationY = ownerDefaultTarget.transform.localRotation.eulerAngles.x;
			this.DoMouseLook();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004192 RID: 16786 RVA: 0x0016D022 File Offset: 0x0016B222
		public override void OnUpdate()
		{
			this.DoMouseLook();
		}

		// Token: 0x06004193 RID: 16787 RVA: 0x0016D02C File Offset: 0x0016B22C
		private void DoMouseLook()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			Transform transform = ownerDefaultTarget.transform;
			switch (this.axes)
			{
			case MouseLook.RotationAxes.MouseXAndY:
				transform.localEulerAngles = new Vector3(this.GetYRotation(), this.GetXRotation(), 0f);
				return;
			case MouseLook.RotationAxes.MouseX:
				transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, this.GetXRotation(), 0f);
				return;
			case MouseLook.RotationAxes.MouseY:
				transform.localEulerAngles = new Vector3(-this.GetYRotation(), transform.localEulerAngles.y, 0f);
				return;
			default:
				return;
			}
		}

		// Token: 0x06004194 RID: 16788 RVA: 0x0016D0D8 File Offset: 0x0016B2D8
		private float GetXRotation()
		{
			this.rotationX += Input.GetAxis("Mouse X") * this.sensitivityX.Value;
			this.rotationX = MouseLook.ClampAngle(this.rotationX, this.minimumX, this.maximumX);
			return this.rotationX;
		}

		// Token: 0x06004195 RID: 16789 RVA: 0x0016D12C File Offset: 0x0016B32C
		private float GetYRotation()
		{
			this.rotationY += Input.GetAxis("Mouse Y") * this.sensitivityY.Value;
			this.rotationY = MouseLook.ClampAngle(this.rotationY, this.minimumY, this.maximumY);
			return this.rotationY;
		}

		// Token: 0x06004196 RID: 16790 RVA: 0x0016D17F File Offset: 0x0016B37F
		private static float ClampAngle(float angle, FsmFloat min, FsmFloat max)
		{
			if (!min.IsNone && angle < min.Value)
			{
				angle = min.Value;
			}
			if (!max.IsNone && angle > max.Value)
			{
				angle = max.Value;
			}
			return angle;
		}

		// Token: 0x040045DC RID: 17884
		[RequiredField]
		[Tooltip("The GameObject to rotate.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040045DD RID: 17885
		[Tooltip("The axes to rotate around.")]
		public MouseLook.RotationAxes axes;

		// Token: 0x040045DE RID: 17886
		[RequiredField]
		[Tooltip("Sensitivity of movement in X direction.")]
		public FsmFloat sensitivityX;

		// Token: 0x040045DF RID: 17887
		[RequiredField]
		[Tooltip("Sensitivity of movement in Y direction.")]
		public FsmFloat sensitivityY;

		// Token: 0x040045E0 RID: 17888
		[HasFloatSlider(-360f, 360f)]
		[Tooltip("Clamp rotation around X axis. Set to None for no clamping.")]
		public FsmFloat minimumX;

		// Token: 0x040045E1 RID: 17889
		[HasFloatSlider(-360f, 360f)]
		[Tooltip("Clamp rotation around X axis. Set to None for no clamping.")]
		public FsmFloat maximumX;

		// Token: 0x040045E2 RID: 17890
		[HasFloatSlider(-360f, 360f)]
		[Tooltip("Clamp rotation around Y axis. Set to None for no clamping.")]
		public FsmFloat minimumY;

		// Token: 0x040045E3 RID: 17891
		[HasFloatSlider(-360f, 360f)]
		[Tooltip("Clamp rotation around Y axis. Set to None for no clamping.")]
		public FsmFloat maximumY;

		// Token: 0x040045E4 RID: 17892
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		// Token: 0x040045E5 RID: 17893
		private float rotationX;

		// Token: 0x040045E6 RID: 17894
		private float rotationY;

		// Token: 0x02000C3C RID: 3132
		public enum RotationAxes
		{
			// Token: 0x040045E8 RID: 17896
			MouseXAndY,
			// Token: 0x040045E9 RID: 17897
			MouseX,
			// Token: 0x040045EA RID: 17898
			MouseY
		}
	}
}
