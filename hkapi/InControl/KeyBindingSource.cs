using System;
using System.IO;

namespace InControl
{
	// Token: 0x020006C4 RID: 1732
	public class KeyBindingSource : BindingSource
	{
		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x060028F5 RID: 10485 RVA: 0x000E51F4 File Offset: 0x000E33F4
		// (set) Token: 0x060028F6 RID: 10486 RVA: 0x000E51FC File Offset: 0x000E33FC
		public KeyCombo Control { get; protected set; }

		// Token: 0x060028F7 RID: 10487 RVA: 0x000E5205 File Offset: 0x000E3405
		internal KeyBindingSource()
		{
		}

		// Token: 0x060028F8 RID: 10488 RVA: 0x000E520D File Offset: 0x000E340D
		public KeyBindingSource(KeyCombo keyCombo)
		{
			this.Control = keyCombo;
		}

		// Token: 0x060028F9 RID: 10489 RVA: 0x000E521C File Offset: 0x000E341C
		public KeyBindingSource(params Key[] keys)
		{
			this.Control = new KeyCombo(keys);
		}

		// Token: 0x060028FA RID: 10490 RVA: 0x000E5230 File Offset: 0x000E3430
		public override float GetValue(InputDevice inputDevice)
		{
			if (!this.GetState(inputDevice))
			{
				return 0f;
			}
			return 1f;
		}

		// Token: 0x060028FB RID: 10491 RVA: 0x000E5248 File Offset: 0x000E3448
		public override bool GetState(InputDevice inputDevice)
		{
			return this.Control.IsPressed;
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x060028FC RID: 10492 RVA: 0x000E5264 File Offset: 0x000E3464
		public override string Name
		{
			get
			{
				return this.Control.ToString();
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x060028FD RID: 10493 RVA: 0x000E5285 File Offset: 0x000E3485
		public override string DeviceName
		{
			get
			{
				return "Keyboard";
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x060028FE RID: 10494 RVA: 0x0004E56C File Offset: 0x0004C76C
		public override InputDeviceClass DeviceClass
		{
			get
			{
				return InputDeviceClass.Keyboard;
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x060028FF RID: 10495 RVA: 0x0000D742 File Offset: 0x0000B942
		public override InputDeviceStyle DeviceStyle
		{
			get
			{
				return InputDeviceStyle.Unknown;
			}
		}

		// Token: 0x06002900 RID: 10496 RVA: 0x000E528C File Offset: 0x000E348C
		public override bool Equals(BindingSource other)
		{
			if (other == null)
			{
				return false;
			}
			KeyBindingSource keyBindingSource = other as KeyBindingSource;
			return keyBindingSource != null && this.Control == keyBindingSource.Control;
		}

		// Token: 0x06002901 RID: 10497 RVA: 0x000E52C8 File Offset: 0x000E34C8
		public override bool Equals(object other)
		{
			if (other == null)
			{
				return false;
			}
			KeyBindingSource keyBindingSource = other as KeyBindingSource;
			return keyBindingSource != null && this.Control == keyBindingSource.Control;
		}

		// Token: 0x06002902 RID: 10498 RVA: 0x000E5300 File Offset: 0x000E3500
		public override int GetHashCode()
		{
			return this.Control.GetHashCode();
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06002903 RID: 10499 RVA: 0x00058FB1 File Offset: 0x000571B1
		public override BindingSourceType BindingSourceType
		{
			get
			{
				return BindingSourceType.KeyBindingSource;
			}
		}

		// Token: 0x06002904 RID: 10500 RVA: 0x000E5324 File Offset: 0x000E3524
		public override void Load(BinaryReader reader, ushort dataFormatVersion)
		{
			KeyCombo control = default(KeyCombo);
			control.Load(reader, dataFormatVersion);
			this.Control = control;
		}

		// Token: 0x06002905 RID: 10501 RVA: 0x000E534C File Offset: 0x000E354C
		public override void Save(BinaryWriter writer)
		{
			this.Control.Save(writer);
		}
	}
}
