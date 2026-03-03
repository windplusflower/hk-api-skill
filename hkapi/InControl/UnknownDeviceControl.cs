using System;
using System.IO;

namespace InControl
{
	// Token: 0x020006D1 RID: 1745
	public struct UnknownDeviceControl : IEquatable<UnknownDeviceControl>
	{
		// Token: 0x060029CA RID: 10698 RVA: 0x000E7980 File Offset: 0x000E5B80
		public UnknownDeviceControl(InputControlType control, InputRangeType sourceRange)
		{
			this.Control = control;
			this.SourceRange = sourceRange;
			this.IsButton = Utility.TargetIsButton(control);
			this.IsAnalog = !this.IsButton;
		}

		// Token: 0x060029CB RID: 10699 RVA: 0x000E79AB File Offset: 0x000E5BAB
		internal float GetValue(InputDevice device)
		{
			if (device == null)
			{
				return 0f;
			}
			return InputRange.Remap(device.GetControl(this.Control).Value, this.SourceRange, InputRangeType.ZeroToOne);
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x060029CC RID: 10700 RVA: 0x000E79D3 File Offset: 0x000E5BD3
		public int Index
		{
			get
			{
				return this.Control - (this.IsButton ? InputControlType.Button0 : InputControlType.Analog0);
			}
		}

		// Token: 0x060029CD RID: 10701 RVA: 0x000E79F0 File Offset: 0x000E5BF0
		public static bool operator ==(UnknownDeviceControl a, UnknownDeviceControl b)
		{
			if (a == null)
			{
				return b == null;
			}
			return a.Equals(b);
		}

		// Token: 0x060029CE RID: 10702 RVA: 0x000E7A0C File Offset: 0x000E5C0C
		public static bool operator !=(UnknownDeviceControl a, UnknownDeviceControl b)
		{
			return !(a == b);
		}

		// Token: 0x060029CF RID: 10703 RVA: 0x000E7A18 File Offset: 0x000E5C18
		public bool Equals(UnknownDeviceControl other)
		{
			return this.Control == other.Control && this.SourceRange == other.SourceRange;
		}

		// Token: 0x060029D0 RID: 10704 RVA: 0x000E7A38 File Offset: 0x000E5C38
		public override bool Equals(object other)
		{
			return this.Equals((UnknownDeviceControl)other);
		}

		// Token: 0x060029D1 RID: 10705 RVA: 0x000E7A46 File Offset: 0x000E5C46
		public override int GetHashCode()
		{
			return this.Control.GetHashCode() ^ this.SourceRange.GetHashCode();
		}

		// Token: 0x060029D2 RID: 10706 RVA: 0x000E7A6B File Offset: 0x000E5C6B
		public static implicit operator bool(UnknownDeviceControl control)
		{
			return control.Control > InputControlType.None;
		}

		// Token: 0x060029D3 RID: 10707 RVA: 0x000E7A76 File Offset: 0x000E5C76
		public override string ToString()
		{
			return string.Format("UnknownDeviceControl( {0}, {1} )", this.Control.ToString(), this.SourceRange.ToString());
		}

		// Token: 0x060029D4 RID: 10708 RVA: 0x000E7AA4 File Offset: 0x000E5CA4
		internal void Save(BinaryWriter writer)
		{
			writer.Write((int)this.Control);
			writer.Write((int)this.SourceRange);
		}

		// Token: 0x060029D5 RID: 10709 RVA: 0x000E7ABE File Offset: 0x000E5CBE
		internal void Load(BinaryReader reader)
		{
			this.Control = (InputControlType)reader.ReadInt32();
			this.SourceRange = (InputRangeType)reader.ReadInt32();
			this.IsButton = Utility.TargetIsButton(this.Control);
			this.IsAnalog = !this.IsButton;
		}

		// Token: 0x060029D6 RID: 10710 RVA: 0x000E7AF8 File Offset: 0x000E5CF8
		// Note: this type is marked as 'beforefieldinit'.
		static UnknownDeviceControl()
		{
			UnknownDeviceControl.None = new UnknownDeviceControl(InputControlType.None, InputRangeType.None);
		}

		// Token: 0x04002FBA RID: 12218
		public static readonly UnknownDeviceControl None;

		// Token: 0x04002FBB RID: 12219
		public InputControlType Control;

		// Token: 0x04002FBC RID: 12220
		public InputRangeType SourceRange;

		// Token: 0x04002FBD RID: 12221
		public bool IsButton;

		// Token: 0x04002FBE RID: 12222
		public bool IsAnalog;
	}
}
