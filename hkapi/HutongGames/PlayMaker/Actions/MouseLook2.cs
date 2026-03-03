using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C3D RID: 3133
	[ActionCategory(ActionCategory.Input)]
	[Tooltip("Rotates a GameObject based on mouse movement. Minimum and Maximum values can be used to constrain the rotation.")]
	public class MouseLook2 : ComponentAction<Rigidbody>
	{
		// Token: 0x06004198 RID: 16792 RVA: 0x0016D1B8 File Offset: 0x0016B3B8
		public override void Reset()
		{
			this.gameObject = null;
			this.axes = MouseLook2.RotationAxes.MouseXAndY;
			this.sensitivityX = 15f;
			this.sensitivityY = 15f;
			this.minimumX = -360f;
			this.maximumX = 360f;
			this.minimumY = -60f;
			this.maximumY = 60f;
			this.everyFrame = true;
		}

		// Token: 0x06004199 RID: 16793 RVA: 0x0016D23C File Offset: 0x0016B43C
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				base.Finish();
				return;
			}
			if (!base.UpdateCache(ownerDefaultTarget) && base.rigidbody)
			{
				base.rigidbody.freezeRotation = true;
			}
			this.DoMouseLook();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600419A RID: 16794 RVA: 0x0016D2A1 File Offset: 0x0016B4A1
		public override void OnUpdate()
		{
			this.DoMouseLook();
		}

		// Token: 0x0600419B RID: 16795 RVA: 0x0016D2AC File Offset: 0x0016B4AC
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
			case MouseLook2.RotationAxes.MouseXAndY:
				transform.localEulerAngles = new Vector3(this.GetYRotation(), this.GetXRotation(), 0f);
				return;
			case MouseLook2.RotationAxes.MouseX:
				transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, this.GetXRotation(), 0f);
				return;
			case MouseLook2.RotationAxes.MouseY:
				transform.localEulerAngles = new Vector3(-this.GetYRotation(), transform.localEulerAngles.y, 0f);
				return;
			default:
				return;
			}
		}

		// Token: 0x0600419C RID: 16796 RVA: 0x0016D358 File Offset: 0x0016B558
		private float GetXRotation()
		{
			this.rotationX += Input.GetAxis("Mouse X") * this.sensitivityX.Value;
			this.rotationX = MouseLook2.ClampAngle(this.rotationX, this.minimumX, this.maximumX);
			return this.rotationX;
		}

		// Token: 0x0600419D RID: 16797 RVA: 0x0016D3AC File Offset: 0x0016B5AC
		private float GetYRotation()
		{
			this.rotationY += Input.GetAxis("Mouse Y") * this.sensitivityY.Value;
			this.rotationY = MouseLook2.ClampAngle(this.rotationY, this.minimumY, this.maximumY);
			return this.rotationY;
		}

		// Token: 0x0600419E RID: 16798 RVA: 0x0016D17F File Offset: 0x0016B37F
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

		// Token: 0x040045EB RID: 17899
		[RequiredField]
		[Tooltip("The GameObject to rotate.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040045EC RID: 17900
		[Tooltip("The axes to rotate around.")]
		public MouseLook2.RotationAxes axes;

		// Token: 0x040045ED RID: 17901
		[RequiredField]
		public FsmFloat sensitivityX;

		// Token: 0x040045EE RID: 17902
		[RequiredField]
		public FsmFloat sensitivityY;

		// Token: 0x040045EF RID: 17903
		[RequiredField]
		[HasFloatSlider(-360f, 360f)]
		public FsmFloat minimumX;

		// Token: 0x040045F0 RID: 17904
		[RequiredField]
		[HasFloatSlider(-360f, 360f)]
		public FsmFloat maximumX;

		// Token: 0x040045F1 RID: 17905
		[RequiredField]
		[HasFloatSlider(-360f, 360f)]
		public FsmFloat minimumY;

		// Token: 0x040045F2 RID: 17906
		[RequiredField]
		[HasFloatSlider(-360f, 360f)]
		public FsmFloat maximumY;

		// Token: 0x040045F3 RID: 17907
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		// Token: 0x040045F4 RID: 17908
		private float rotationX;

		// Token: 0x040045F5 RID: 17909
		private float rotationY;

		// Token: 0x02000C3E RID: 3134
		public enum RotationAxes
		{
			// Token: 0x040045F7 RID: 17911
			MouseXAndY,
			// Token: 0x040045F8 RID: 17912
			MouseX,
			// Token: 0x040045F9 RID: 17913
			MouseY
		}
	}
}
