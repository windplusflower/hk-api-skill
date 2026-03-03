using System;
using UnityEngine;

namespace InControl
{
	// Token: 0x0200072A RID: 1834
	[Serializable]
	public struct OptionalInputDeviceTransportType
	{
		// Token: 0x06002D98 RID: 11672 RVA: 0x000F4610 File Offset: 0x000F2810
		public OptionalInputDeviceTransportType(InputDeviceTransportType value)
		{
			this.value = value;
			this.hasValue = true;
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x06002D99 RID: 11673 RVA: 0x000F4620 File Offset: 0x000F2820
		public bool HasValue
		{
			get
			{
				return this.hasValue;
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x06002D9A RID: 11674 RVA: 0x000F4628 File Offset: 0x000F2828
		public bool HasNoValue
		{
			get
			{
				return !this.hasValue;
			}
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06002D9B RID: 11675 RVA: 0x000F4633 File Offset: 0x000F2833
		// (set) Token: 0x06002D9C RID: 11676 RVA: 0x000F4610 File Offset: 0x000F2810
		public InputDeviceTransportType Value
		{
			get
			{
				if (!this.hasValue)
				{
					throw new OptionalTypeHasNoValueException("Trying to get a value from an OptionalInputDeviceTransportType that has no value.");
				}
				return this.value;
			}
			set
			{
				this.value = value;
				this.hasValue = true;
			}
		}

		// Token: 0x06002D9D RID: 11677 RVA: 0x000F464E File Offset: 0x000F284E
		public void Clear()
		{
			this.value = InputDeviceTransportType.Unknown;
			this.hasValue = false;
		}

		// Token: 0x06002D9E RID: 11678 RVA: 0x000F465E File Offset: 0x000F285E
		public InputDeviceTransportType GetValueOrDefault(InputDeviceTransportType defaultValue)
		{
			if (!this.hasValue)
			{
				return defaultValue;
			}
			return this.value;
		}

		// Token: 0x06002D9F RID: 11679 RVA: 0x000F4670 File Offset: 0x000F2870
		public InputDeviceTransportType GetValueOrZero()
		{
			if (!this.hasValue)
			{
				return InputDeviceTransportType.Unknown;
			}
			return this.value;
		}

		// Token: 0x06002DA0 RID: 11680 RVA: 0x000F4610 File Offset: 0x000F2810
		public void SetValue(InputDeviceTransportType value)
		{
			this.value = value;
			this.hasValue = true;
		}

		// Token: 0x06002DA1 RID: 11681 RVA: 0x000F4682 File Offset: 0x000F2882
		public override bool Equals(object other)
		{
			return (other == null && !this.hasValue) || this.value.Equals(other);
		}

		// Token: 0x06002DA2 RID: 11682 RVA: 0x000F46A3 File Offset: 0x000F28A3
		public bool Equals(OptionalInputDeviceTransportType other)
		{
			return this.hasValue && other.hasValue && this.value == other.value;
		}

		// Token: 0x06002DA3 RID: 11683 RVA: 0x000F46C5 File Offset: 0x000F28C5
		public bool Equals(InputDeviceTransportType other)
		{
			return this.hasValue && this.value == other;
		}

		// Token: 0x06002DA4 RID: 11684 RVA: 0x000F46A3 File Offset: 0x000F28A3
		public static bool operator ==(OptionalInputDeviceTransportType a, OptionalInputDeviceTransportType b)
		{
			return a.hasValue && b.hasValue && a.value == b.value;
		}

		// Token: 0x06002DA5 RID: 11685 RVA: 0x000F46DA File Offset: 0x000F28DA
		public static bool operator !=(OptionalInputDeviceTransportType a, OptionalInputDeviceTransportType b)
		{
			return !(a == b);
		}

		// Token: 0x06002DA6 RID: 11686 RVA: 0x000F46C5 File Offset: 0x000F28C5
		public static bool operator ==(OptionalInputDeviceTransportType a, InputDeviceTransportType b)
		{
			return a.hasValue && a.value == b;
		}

		// Token: 0x06002DA7 RID: 11687 RVA: 0x000F46E6 File Offset: 0x000F28E6
		public static bool operator !=(OptionalInputDeviceTransportType a, InputDeviceTransportType b)
		{
			return !a.hasValue || a.value != b;
		}

		// Token: 0x06002DA8 RID: 11688 RVA: 0x000F4419 File Offset: 0x000F2619
		private static int CombineHashCodes(int h1, int h2)
		{
			return (h1 << 5) + h1 ^ h2;
		}

		// Token: 0x06002DA9 RID: 11689 RVA: 0x000F46FE File Offset: 0x000F28FE
		public override int GetHashCode()
		{
			return OptionalInputDeviceTransportType.CombineHashCodes(this.hasValue.GetHashCode(), this.value.GetHashCode());
		}

		// Token: 0x06002DAA RID: 11690 RVA: 0x000F4721 File Offset: 0x000F2921
		public override string ToString()
		{
			if (!this.hasValue)
			{
				return "";
			}
			return this.value.ToString();
		}

		// Token: 0x06002DAB RID: 11691 RVA: 0x000F4742 File Offset: 0x000F2942
		public static implicit operator OptionalInputDeviceTransportType(InputDeviceTransportType value)
		{
			return new OptionalInputDeviceTransportType(value);
		}

		// Token: 0x06002DAC RID: 11692 RVA: 0x000F474A File Offset: 0x000F294A
		public static explicit operator InputDeviceTransportType(OptionalInputDeviceTransportType optional)
		{
			return optional.Value;
		}

		// Token: 0x040032C9 RID: 13001
		[SerializeField]
		private bool hasValue;

		// Token: 0x040032CA RID: 13002
		[SerializeField]
		private InputDeviceTransportType value;
	}
}
