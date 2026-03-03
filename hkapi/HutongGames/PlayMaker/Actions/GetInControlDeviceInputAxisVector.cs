using System;
using InControl;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000ABF RID: 2751
	[ActionCategory("InControl")]
	[Tooltip("Gets a world direction Vector from 2 Incontrol control Axis for a given device. Typically used for a third person controller with Relative To set to the camera.")]
	public class GetInControlDeviceInputAxisVector : FsmStateAction
	{
		// Token: 0x06003B33 RID: 15155 RVA: 0x00155DB8 File Offset: 0x00153FB8
		public override void Reset()
		{
			this.deviceIndex = 0;
			this.horizontalAxis = InputControlType.LeftStickRight;
			this.verticalAxis = InputControlType.LeftStickRight;
			this.multiplier = 1f;
			this.mapToPlane = GetInControlDeviceInputAxisVector.AxisPlane.XZ;
			this.storeVector = null;
			this.storeMagnitude = null;
		}

		// Token: 0x06003B34 RID: 15156 RVA: 0x00155E04 File Offset: 0x00154004
		public override void OnUpdate()
		{
			Vector3 vector = default(Vector3);
			Vector3 a = default(Vector3);
			if (this.relativeTo.Value == null)
			{
				switch (this.mapToPlane)
				{
				case GetInControlDeviceInputAxisVector.AxisPlane.XZ:
					vector = Vector3.forward;
					a = Vector3.right;
					break;
				case GetInControlDeviceInputAxisVector.AxisPlane.XY:
					vector = Vector3.up;
					a = Vector3.right;
					break;
				case GetInControlDeviceInputAxisVector.AxisPlane.YZ:
					vector = Vector3.up;
					a = Vector3.forward;
					break;
				}
			}
			else
			{
				Transform transform = this.relativeTo.Value.transform;
				GetInControlDeviceInputAxisVector.AxisPlane axisPlane = this.mapToPlane;
				if (axisPlane != GetInControlDeviceInputAxisVector.AxisPlane.XZ)
				{
					if (axisPlane - GetInControlDeviceInputAxisVector.AxisPlane.XY <= 1)
					{
						vector = Vector3.up;
						vector.z = 0f;
						vector = vector.normalized;
						a = transform.TransformDirection(Vector3.right);
					}
				}
				else
				{
					vector = transform.TransformDirection(Vector3.forward);
					vector.y = 0f;
					vector = vector.normalized;
					a = new Vector3(vector.z, 0f, -vector.x);
				}
			}
			if (this.deviceIndex.Value == -1)
			{
				this._inputDevice = InputManager.ActiveDevice;
			}
			else
			{
				this._inputDevice = InputManager.Devices[this.deviceIndex.Value];
			}
			float value = this._inputDevice.GetControl(this.horizontalAxis).Value;
			float value2 = this._inputDevice.GetControl(this.verticalAxis).Value;
			Vector3 vector2 = value * a + value2 * vector;
			vector2 *= this.multiplier.Value;
			this.storeVector.Value = vector2;
			if (!this.storeMagnitude.IsNone)
			{
				this.storeMagnitude.Value = vector2.magnitude;
			}
		}

		// Token: 0x04003E7E RID: 15998
		[Tooltip("The index of the device. -1 to use the active device")]
		public FsmInt deviceIndex;

		// Token: 0x04003E7F RID: 15999
		public InputControlType horizontalAxis;

		// Token: 0x04003E80 RID: 16000
		public InputControlType verticalAxis;

		// Token: 0x04003E81 RID: 16001
		[Tooltip("Input axis are reported in the range -1 to 1, this multiplier lets you set a new range.")]
		public FsmFloat multiplier;

		// Token: 0x04003E82 RID: 16002
		[RequiredField]
		[Tooltip("The world plane to map the 2d input onto.")]
		public GetInControlDeviceInputAxisVector.AxisPlane mapToPlane;

		// Token: 0x04003E83 RID: 16003
		[Tooltip("Make the result relative to a GameObject, typically the main camera.")]
		public FsmGameObject relativeTo;

		// Token: 0x04003E84 RID: 16004
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the direction vector.")]
		public FsmVector3 storeVector;

		// Token: 0x04003E85 RID: 16005
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the length of the direction vector.")]
		public FsmFloat storeMagnitude;

		// Token: 0x04003E86 RID: 16006
		private InputDevice _inputDevice;

		// Token: 0x04003E87 RID: 16007
		private InputControl _inputControl;

		// Token: 0x02000AC0 RID: 2752
		public enum AxisPlane
		{
			// Token: 0x04003E89 RID: 16009
			XZ,
			// Token: 0x04003E8A RID: 16010
			XY,
			// Token: 0x04003E8B RID: 16011
			YZ
		}
	}
}
