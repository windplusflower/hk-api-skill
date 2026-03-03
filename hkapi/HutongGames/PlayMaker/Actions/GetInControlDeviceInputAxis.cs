using System;
using InControl;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000ABE RID: 2750
	[ActionCategory("InControl")]
	[Tooltip("Gets the value of the specified Incontrol control Axis for a given device and stores it in a Float Variable.")]
	public class GetInControlDeviceInputAxis : FsmStateAction
	{
		// Token: 0x06003B2E RID: 15150 RVA: 0x00155CE3 File Offset: 0x00153EE3
		public override void Reset()
		{
			this.deviceIndex = 0;
			this.axis = InputControlType.LeftStickRight;
			this.multiplier = 1f;
			this.store = null;
			this.everyFrame = true;
		}

		// Token: 0x06003B2F RID: 15151 RVA: 0x00155D16 File Offset: 0x00153F16
		public override void OnEnter()
		{
			this.DoGetAxis();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003B30 RID: 15152 RVA: 0x00155D2C File Offset: 0x00153F2C
		public override void OnUpdate()
		{
			this.DoGetAxis();
		}

		// Token: 0x06003B31 RID: 15153 RVA: 0x00155D34 File Offset: 0x00153F34
		private void DoGetAxis()
		{
			if (this.deviceIndex.Value == -1)
			{
				this._inputDevice = InputManager.ActiveDevice;
			}
			else
			{
				this._inputDevice = InputManager.Devices[this.deviceIndex.Value];
			}
			float num = this._inputDevice.GetControl(this.axis).Value;
			if (!this.multiplier.IsNone)
			{
				num *= this.multiplier.Value;
			}
			this.store.Value = num;
		}

		// Token: 0x04003E78 RID: 15992
		[Tooltip("The index of the device. -1 to use the active device")]
		public FsmInt deviceIndex;

		// Token: 0x04003E79 RID: 15993
		public InputControlType axis;

		// Token: 0x04003E7A RID: 15994
		[Tooltip("Axis values are in the range -1 to 1. Use the multiplier to set a larger range.")]
		public FsmFloat multiplier;

		// Token: 0x04003E7B RID: 15995
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in a float variable.")]
		public FsmFloat store;

		// Token: 0x04003E7C RID: 15996
		[Tooltip("Repeat every frame. Typically this would be set to True.")]
		public bool everyFrame;

		// Token: 0x04003E7D RID: 15997
		private InputDevice _inputDevice;
	}
}
