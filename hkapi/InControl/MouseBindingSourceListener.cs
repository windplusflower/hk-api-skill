using System;

namespace InControl
{
	// Token: 0x020006C9 RID: 1737
	public class MouseBindingSourceListener : BindingSourceListener
	{
		// Token: 0x06002939 RID: 10553 RVA: 0x000E5B8B File Offset: 0x000E3D8B
		public void Reset()
		{
			this.detectFound = Mouse.None;
			this.detectPhase = 0;
		}

		// Token: 0x0600293A RID: 10554 RVA: 0x000E5B9C File Offset: 0x000E3D9C
		public BindingSource Listen(BindingListenOptions listenOptions, InputDevice device)
		{
			if (this.detectFound != Mouse.None && !this.IsPressed(this.detectFound) && this.detectPhase == 2)
			{
				BindingSource result = new MouseBindingSource(this.detectFound);
				this.Reset();
				return result;
			}
			Mouse mouse = this.ListenForControl(listenOptions);
			if (mouse != Mouse.None)
			{
				if (this.detectPhase == 1)
				{
					this.detectFound = mouse;
					this.detectPhase = 2;
				}
			}
			else if (this.detectPhase == 0)
			{
				this.detectPhase = 1;
			}
			return null;
		}

		// Token: 0x0600293B RID: 10555 RVA: 0x000E5C0E File Offset: 0x000E3E0E
		private bool IsPressed(Mouse control)
		{
			if (control == Mouse.PositiveScrollWheel)
			{
				return MouseBindingSource.PositiveScrollWheelIsActive(MouseBindingSourceListener.ScrollWheelThreshold);
			}
			if (control == Mouse.NegativeScrollWheel)
			{
				return MouseBindingSource.NegativeScrollWheelIsActive(MouseBindingSourceListener.ScrollWheelThreshold);
			}
			return MouseBindingSource.ButtonIsPressed(control);
		}

		// Token: 0x0600293C RID: 10556 RVA: 0x000E5C38 File Offset: 0x000E3E38
		private Mouse ListenForControl(BindingListenOptions listenOptions)
		{
			if (listenOptions.IncludeMouseButtons)
			{
				for (Mouse mouse = Mouse.None; mouse <= Mouse.Button9; mouse++)
				{
					if (MouseBindingSource.ButtonIsPressed(mouse))
					{
						return mouse;
					}
				}
			}
			if (listenOptions.IncludeMouseScrollWheel)
			{
				if (MouseBindingSource.NegativeScrollWheelIsActive(MouseBindingSourceListener.ScrollWheelThreshold))
				{
					return Mouse.NegativeScrollWheel;
				}
				if (MouseBindingSource.PositiveScrollWheelIsActive(MouseBindingSourceListener.ScrollWheelThreshold))
				{
					return Mouse.PositiveScrollWheel;
				}
			}
			return Mouse.None;
		}

		// Token: 0x0600293E RID: 10558 RVA: 0x000E5C8A File Offset: 0x000E3E8A
		// Note: this type is marked as 'beforefieldinit'.
		static MouseBindingSourceListener()
		{
			MouseBindingSourceListener.ScrollWheelThreshold = 0.001f;
		}

		// Token: 0x04002F79 RID: 12153
		public static float ScrollWheelThreshold;

		// Token: 0x04002F7A RID: 12154
		private Mouse detectFound;

		// Token: 0x04002F7B RID: 12155
		private int detectPhase;
	}
}
