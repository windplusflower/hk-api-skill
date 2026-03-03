using System;

namespace InControl
{
	// Token: 0x020006C2 RID: 1730
	public class DeviceBindingSourceListener : BindingSourceListener
	{
		// Token: 0x060028EF RID: 10479 RVA: 0x000E50CC File Offset: 0x000E32CC
		public void Reset()
		{
			this.detectFound = InputControlType.None;
			this.detectPhase = 0;
		}

		// Token: 0x060028F0 RID: 10480 RVA: 0x000E50DC File Offset: 0x000E32DC
		public BindingSource Listen(BindingListenOptions listenOptions, InputDevice device)
		{
			if (!listenOptions.IncludeControllers || device.IsUnknown)
			{
				return null;
			}
			if (this.detectFound != InputControlType.None && !this.IsPressed(this.detectFound, device) && this.detectPhase == 2)
			{
				BindingSource result = new DeviceBindingSource(this.detectFound);
				this.Reset();
				return result;
			}
			InputControlType inputControlType = this.ListenForControl(listenOptions, device);
			if (inputControlType != InputControlType.None)
			{
				if (this.detectPhase == 1)
				{
					this.detectFound = inputControlType;
					this.detectPhase = 2;
				}
			}
			else if (this.detectPhase == 0)
			{
				this.detectPhase = 1;
			}
			return null;
		}

		// Token: 0x060028F1 RID: 10481 RVA: 0x000E5162 File Offset: 0x000E3362
		private bool IsPressed(InputControl control)
		{
			return Utility.AbsoluteIsOverThreshold(control.Value, 0.5f);
		}

		// Token: 0x060028F2 RID: 10482 RVA: 0x000E5174 File Offset: 0x000E3374
		private bool IsPressed(InputControlType control, InputDevice device)
		{
			return this.IsPressed(device.GetControl(control));
		}

		// Token: 0x060028F3 RID: 10483 RVA: 0x000E5184 File Offset: 0x000E3384
		private InputControlType ListenForControl(BindingListenOptions listenOptions, InputDevice device)
		{
			if (device.IsKnown)
			{
				int count = device.Controls.Count;
				for (int i = 0; i < count; i++)
				{
					InputControl inputControl = device.Controls[i];
					if (inputControl != null && this.IsPressed(inputControl) && (listenOptions.IncludeNonStandardControls || inputControl.IsStandard))
					{
						InputControlType target = inputControl.Target;
						if (target != InputControlType.Command || !listenOptions.IncludeNonStandardControls)
						{
							return target;
						}
					}
				}
			}
			return InputControlType.None;
		}

		// Token: 0x04002ED3 RID: 11987
		private InputControlType detectFound;

		// Token: 0x04002ED4 RID: 11988
		private int detectPhase;
	}
}
