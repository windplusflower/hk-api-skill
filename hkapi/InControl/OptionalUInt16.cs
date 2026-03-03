using System;
using System.Globalization;
using UnityEngine;

namespace InControl
{
	// Token: 0x0200072D RID: 1837
	[Serializable]
	public struct OptionalUInt16
	{
		// Token: 0x06002DD7 RID: 11735 RVA: 0x000F49BF File Offset: 0x000F2BBF
		public OptionalUInt16(ushort value)
		{
			this.value = value;
			this.hasValue = true;
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x06002DD8 RID: 11736 RVA: 0x000F49CF File Offset: 0x000F2BCF
		public bool HasValue
		{
			get
			{
				return this.hasValue;
			}
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x06002DD9 RID: 11737 RVA: 0x000F49D7 File Offset: 0x000F2BD7
		public bool HasNoValue
		{
			get
			{
				return !this.hasValue;
			}
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06002DDA RID: 11738 RVA: 0x000F49E2 File Offset: 0x000F2BE2
		// (set) Token: 0x06002DDB RID: 11739 RVA: 0x000F49BF File Offset: 0x000F2BBF
		public ushort Value
		{
			get
			{
				if (!this.hasValue)
				{
					throw new OptionalTypeHasNoValueException("Trying to get a value from an OptionalUInt16 that has no value.");
				}
				return this.value;
			}
			set
			{
				this.value = value;
				this.hasValue = true;
			}
		}

		// Token: 0x06002DDC RID: 11740 RVA: 0x000F49FD File Offset: 0x000F2BFD
		public void Clear()
		{
			this.value = 0;
			this.hasValue = false;
		}

		// Token: 0x06002DDD RID: 11741 RVA: 0x000F4A0D File Offset: 0x000F2C0D
		public ushort GetValueOrDefault(ushort defaultValue)
		{
			if (!this.hasValue)
			{
				return defaultValue;
			}
			return this.value;
		}

		// Token: 0x06002DDE RID: 11742 RVA: 0x000F4A1F File Offset: 0x000F2C1F
		public ushort GetValueOrZero()
		{
			if (!this.hasValue)
			{
				return 0;
			}
			return this.value;
		}

		// Token: 0x06002DDF RID: 11743 RVA: 0x000F49BF File Offset: 0x000F2BBF
		public void SetValue(ushort value)
		{
			this.value = value;
			this.hasValue = true;
		}

		// Token: 0x06002DE0 RID: 11744 RVA: 0x000F4A31 File Offset: 0x000F2C31
		public override bool Equals(object other)
		{
			return (other == null && !this.hasValue) || this.value.Equals(other);
		}

		// Token: 0x06002DE1 RID: 11745 RVA: 0x000F4A4C File Offset: 0x000F2C4C
		public bool Equals(OptionalUInt16 other)
		{
			return this.hasValue && other.hasValue && this.value == other.value;
		}

		// Token: 0x06002DE2 RID: 11746 RVA: 0x000F4A6E File Offset: 0x000F2C6E
		public bool Equals(ushort other)
		{
			return this.hasValue && this.value == other;
		}

		// Token: 0x06002DE3 RID: 11747 RVA: 0x000F4A4C File Offset: 0x000F2C4C
		public static bool operator ==(OptionalUInt16 a, OptionalUInt16 b)
		{
			return a.hasValue && b.hasValue && a.value == b.value;
		}

		// Token: 0x06002DE4 RID: 11748 RVA: 0x000F4A83 File Offset: 0x000F2C83
		public static bool operator !=(OptionalUInt16 a, OptionalUInt16 b)
		{
			return !(a == b);
		}

		// Token: 0x06002DE5 RID: 11749 RVA: 0x000F4A6E File Offset: 0x000F2C6E
		public static bool operator ==(OptionalUInt16 a, ushort b)
		{
			return a.hasValue && a.value == b;
		}

		// Token: 0x06002DE6 RID: 11750 RVA: 0x000F4A8F File Offset: 0x000F2C8F
		public static bool operator !=(OptionalUInt16 a, ushort b)
		{
			return !a.hasValue || a.value != b;
		}

		// Token: 0x06002DE7 RID: 11751 RVA: 0x000F4419 File Offset: 0x000F2619
		private static int CombineHashCodes(int h1, int h2)
		{
			return (h1 << 5) + h1 ^ h2;
		}

		// Token: 0x06002DE8 RID: 11752 RVA: 0x000F4AA7 File Offset: 0x000F2CA7
		public override int GetHashCode()
		{
			return OptionalUInt16.CombineHashCodes(this.hasValue.GetHashCode(), this.value.GetHashCode());
		}

		// Token: 0x06002DE9 RID: 11753 RVA: 0x000F4AC4 File Offset: 0x000F2CC4
		public override string ToString()
		{
			if (!this.hasValue)
			{
				return "";
			}
			return this.value.ToString(CultureInfo.InvariantCulture);
		}

		// Token: 0x06002DEA RID: 11754 RVA: 0x000F4AE4 File Offset: 0x000F2CE4
		public static implicit operator OptionalUInt16(ushort value)
		{
			return new OptionalUInt16(value);
		}

		// Token: 0x06002DEB RID: 11755 RVA: 0x000F4AEC File Offset: 0x000F2CEC
		public static explicit operator ushort(OptionalUInt16 optional)
		{
			return optional.Value;
		}

		// Token: 0x040032CF RID: 13007
		[SerializeField]
		private bool hasValue;

		// Token: 0x040032D0 RID: 13008
		[SerializeField]
		private ushort value;
	}
}
