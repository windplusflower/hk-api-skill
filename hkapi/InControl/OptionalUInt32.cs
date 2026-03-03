using System;
using System.Globalization;
using UnityEngine;

namespace InControl
{
	// Token: 0x0200072E RID: 1838
	[Serializable]
	public struct OptionalUInt32
	{
		// Token: 0x06002DEC RID: 11756 RVA: 0x000F4AF5 File Offset: 0x000F2CF5
		public OptionalUInt32(uint value)
		{
			this.value = value;
			this.hasValue = true;
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06002DED RID: 11757 RVA: 0x000F4B05 File Offset: 0x000F2D05
		public bool HasValue
		{
			get
			{
				return this.hasValue;
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x06002DEE RID: 11758 RVA: 0x000F4B0D File Offset: 0x000F2D0D
		public bool HasNoValue
		{
			get
			{
				return !this.hasValue;
			}
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x06002DEF RID: 11759 RVA: 0x000F4B18 File Offset: 0x000F2D18
		// (set) Token: 0x06002DF0 RID: 11760 RVA: 0x000F4AF5 File Offset: 0x000F2CF5
		public uint Value
		{
			get
			{
				if (!this.hasValue)
				{
					throw new OptionalTypeHasNoValueException("Trying to get a value from an OptionalUInt32 that has no value.");
				}
				return this.value;
			}
			set
			{
				this.value = value;
				this.hasValue = true;
			}
		}

		// Token: 0x06002DF1 RID: 11761 RVA: 0x000F4B33 File Offset: 0x000F2D33
		public void Clear()
		{
			this.value = 0U;
			this.hasValue = false;
		}

		// Token: 0x06002DF2 RID: 11762 RVA: 0x000F4B43 File Offset: 0x000F2D43
		public uint GetValueOrDefault(uint defaultValue)
		{
			if (!this.hasValue)
			{
				return defaultValue;
			}
			return this.value;
		}

		// Token: 0x06002DF3 RID: 11763 RVA: 0x000F4B55 File Offset: 0x000F2D55
		public uint GetValueOrZero()
		{
			if (!this.hasValue)
			{
				return 0U;
			}
			return this.value;
		}

		// Token: 0x06002DF4 RID: 11764 RVA: 0x000F4AF5 File Offset: 0x000F2CF5
		public void SetValue(uint value)
		{
			this.value = value;
			this.hasValue = true;
		}

		// Token: 0x06002DF5 RID: 11765 RVA: 0x000F4B67 File Offset: 0x000F2D67
		public override bool Equals(object other)
		{
			return (other == null && !this.hasValue) || this.value.Equals(other);
		}

		// Token: 0x06002DF6 RID: 11766 RVA: 0x000F4B82 File Offset: 0x000F2D82
		public bool Equals(OptionalUInt32 other)
		{
			return this.hasValue && other.hasValue && this.value == other.value;
		}

		// Token: 0x06002DF7 RID: 11767 RVA: 0x000F4BA4 File Offset: 0x000F2DA4
		public bool Equals(uint other)
		{
			return this.hasValue && this.value == other;
		}

		// Token: 0x06002DF8 RID: 11768 RVA: 0x000F4B82 File Offset: 0x000F2D82
		public static bool operator ==(OptionalUInt32 a, OptionalUInt32 b)
		{
			return a.hasValue && b.hasValue && a.value == b.value;
		}

		// Token: 0x06002DF9 RID: 11769 RVA: 0x000F4BB9 File Offset: 0x000F2DB9
		public static bool operator !=(OptionalUInt32 a, OptionalUInt32 b)
		{
			return !(a == b);
		}

		// Token: 0x06002DFA RID: 11770 RVA: 0x000F4BA4 File Offset: 0x000F2DA4
		public static bool operator ==(OptionalUInt32 a, uint b)
		{
			return a.hasValue && a.value == b;
		}

		// Token: 0x06002DFB RID: 11771 RVA: 0x000F4BC5 File Offset: 0x000F2DC5
		public static bool operator !=(OptionalUInt32 a, uint b)
		{
			return !a.hasValue || a.value != b;
		}

		// Token: 0x06002DFC RID: 11772 RVA: 0x000F4419 File Offset: 0x000F2619
		private static int CombineHashCodes(int h1, int h2)
		{
			return (h1 << 5) + h1 ^ h2;
		}

		// Token: 0x06002DFD RID: 11773 RVA: 0x000F4BDD File Offset: 0x000F2DDD
		public override int GetHashCode()
		{
			return OptionalUInt32.CombineHashCodes(this.hasValue.GetHashCode(), this.value.GetHashCode());
		}

		// Token: 0x06002DFE RID: 11774 RVA: 0x000F4BFA File Offset: 0x000F2DFA
		public override string ToString()
		{
			if (!this.hasValue)
			{
				return "";
			}
			return this.value.ToString(CultureInfo.InvariantCulture);
		}

		// Token: 0x06002DFF RID: 11775 RVA: 0x000F4C1A File Offset: 0x000F2E1A
		public static implicit operator OptionalUInt32(uint value)
		{
			return new OptionalUInt32(value);
		}

		// Token: 0x06002E00 RID: 11776 RVA: 0x000F4C22 File Offset: 0x000F2E22
		public static explicit operator uint(OptionalUInt32 optional)
		{
			return optional.Value;
		}

		// Token: 0x040032D1 RID: 13009
		[SerializeField]
		private bool hasValue;

		// Token: 0x040032D2 RID: 13010
		[SerializeField]
		private uint value;
	}
}
