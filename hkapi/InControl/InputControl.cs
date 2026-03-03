using System;

namespace InControl
{
	// Token: 0x020006D7 RID: 1751
	public class InputControl : OneAxisInputControl
	{
		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x060029ED RID: 10733 RVA: 0x000E7F4E File Offset: 0x000E614E
		// (set) Token: 0x060029EE RID: 10734 RVA: 0x000E7F56 File Offset: 0x000E6156
		public string Handle { get; protected set; }

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x060029EF RID: 10735 RVA: 0x000E7F5F File Offset: 0x000E615F
		// (set) Token: 0x060029F0 RID: 10736 RVA: 0x000E7F67 File Offset: 0x000E6167
		public InputControlType Target { get; protected set; }

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x060029F1 RID: 10737 RVA: 0x000E7F70 File Offset: 0x000E6170
		// (set) Token: 0x060029F2 RID: 10738 RVA: 0x000E7F78 File Offset: 0x000E6178
		public bool IsButton { get; protected set; }

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x060029F3 RID: 10739 RVA: 0x000E7F81 File Offset: 0x000E6181
		// (set) Token: 0x060029F4 RID: 10740 RVA: 0x000E7F89 File Offset: 0x000E6189
		public bool IsAnalog { get; protected set; }

		// Token: 0x060029F5 RID: 10741 RVA: 0x000E7F92 File Offset: 0x000E6192
		private InputControl()
		{
			this.Handle = "None";
			this.Target = InputControlType.None;
			this.Passive = false;
			this.IsButton = false;
			this.IsAnalog = false;
		}

		// Token: 0x060029F6 RID: 10742 RVA: 0x000E7FC1 File Offset: 0x000E61C1
		public InputControl(string handle, InputControlType target)
		{
			this.Handle = handle;
			this.Target = target;
			this.Passive = false;
			this.IsButton = Utility.TargetIsButton(target);
			this.IsAnalog = !this.IsButton;
		}

		// Token: 0x060029F7 RID: 10743 RVA: 0x000E7FF9 File Offset: 0x000E61F9
		public InputControl(string handle, InputControlType target, bool passive) : this(handle, target)
		{
			this.Passive = passive;
		}

		// Token: 0x060029F8 RID: 10744 RVA: 0x000E800A File Offset: 0x000E620A
		internal void SetZeroTick()
		{
			this.zeroTick = base.UpdateTick;
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x060029F9 RID: 10745 RVA: 0x000E8018 File Offset: 0x000E6218
		internal bool IsOnZeroTick
		{
			get
			{
				return base.UpdateTick == this.zeroTick;
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x060029FA RID: 10746 RVA: 0x000E8028 File Offset: 0x000E6228
		public bool IsStandard
		{
			get
			{
				return Utility.TargetIsStandard(this.Target);
			}
		}

		// Token: 0x060029FB RID: 10747 RVA: 0x000E8035 File Offset: 0x000E6235
		// Note: this type is marked as 'beforefieldinit'.
		static InputControl()
		{
			InputControl.Null = new InputControl
			{
				isNullControl = true
			};
		}

		// Token: 0x04002FD6 RID: 12246
		public static readonly InputControl Null;

		// Token: 0x04002FD9 RID: 12249
		public bool Passive;

		// Token: 0x04002FDC RID: 12252
		private ulong zeroTick;
	}
}
