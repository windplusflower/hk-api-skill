using System;
using System.Globalization;
using UnityEngine;

namespace InControl
{
	// Token: 0x0200072B RID: 1835
	[Serializable]
	public struct OptionalInt16
	{
		// Token: 0x06002DAD RID: 11693 RVA: 0x000F4753 File Offset: 0x000F2953
		public OptionalInt16(short value)
		{
			this.value = value;
			this.hasValue = true;
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06002DAE RID: 11694 RVA: 0x000F4763 File Offset: 0x000F2963
		public bool HasValue
		{
			get
			{
				return this.hasValue;
			}
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x06002DAF RID: 11695 RVA: 0x000F476B File Offset: 0x000F296B
		public bool HasNoValue
		{
			get
			{
				return !this.hasValue;
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x06002DB0 RID: 11696 RVA: 0x000F4776 File Offset: 0x000F2976
		// (set) Token: 0x06002DB1 RID: 11697 RVA: 0x000F4753 File Offset: 0x000F2953
		public short Value
		{
			get
			{
				if (!this.hasValue)
				{
					throw new OptionalTypeHasNoValueException("Trying to get a value from an OptionalInt16 that has no value.");
				}
				return this.value;
			}
			set
			{
				this.value = value;
				this.hasValue = true;
			}
		}

		// Token: 0x06002DB2 RID: 11698 RVA: 0x000F4791 File Offset: 0x000F2991
		public void Clear()
		{
			this.value = 0;
			this.hasValue = false;
		}

		// Token: 0x06002DB3 RID: 11699 RVA: 0x000F47A1 File Offset: 0x000F29A1
		public short GetValueOrDefault(short defaultValue)
		{
			if (!this.hasValue)
			{
				return defaultValue;
			}
			return this.value;
		}

		// Token: 0x06002DB4 RID: 11700 RVA: 0x000F47B3 File Offset: 0x000F29B3
		public short GetValueOrZero()
		{
			if (!this.hasValue)
			{
				return 0;
			}
			return this.value;
		}

		// Token: 0x06002DB5 RID: 11701 RVA: 0x000F4753 File Offset: 0x000F2953
		public void SetValue(short value)
		{
			this.value = value;
			this.hasValue = true;
		}

		// Token: 0x06002DB6 RID: 11702 RVA: 0x000F47C5 File Offset: 0x000F29C5
		public override bool Equals(object other)
		{
			return (other == null && !this.hasValue) || this.value.Equals(other);
		}

		// Token: 0x06002DB7 RID: 11703 RVA: 0x000F47E0 File Offset: 0x000F29E0
		public bool Equals(OptionalInt16 other)
		{
			return this.hasValue && other.hasValue && this.value == other.value;
		}

		// Token: 0x06002DB8 RID: 11704 RVA: 0x000F4802 File Offset: 0x000F2A02
		public bool Equals(short other)
		{
			return this.hasValue && this.value == other;
		}

		// Token: 0x06002DB9 RID: 11705 RVA: 0x000F47E0 File Offset: 0x000F29E0
		public static bool operator ==(OptionalInt16 a, OptionalInt16 b)
		{
			return a.hasValue && b.hasValue && a.value == b.value;
		}

		// Token: 0x06002DBA RID: 11706 RVA: 0x000F4817 File Offset: 0x000F2A17
		public static bool operator !=(OptionalInt16 a, OptionalInt16 b)
		{
			return !(a == b);
		}

		// Token: 0x06002DBB RID: 11707 RVA: 0x000F4802 File Offset: 0x000F2A02
		public static bool operator ==(OptionalInt16 a, short b)
		{
			return a.hasValue && a.value == b;
		}

		// Token: 0x06002DBC RID: 11708 RVA: 0x000F4823 File Offset: 0x000F2A23
		public static bool operator !=(OptionalInt16 a, short b)
		{
			return !a.hasValue || a.value != b;
		}

		// Token: 0x06002DBD RID: 11709 RVA: 0x000F4419 File Offset: 0x000F2619
		private static int CombineHashCodes(int h1, int h2)
		{
			return (h1 << 5) + h1 ^ h2;
		}

		// Token: 0x06002DBE RID: 11710 RVA: 0x000F483B File Offset: 0x000F2A3B
		public override int GetHashCode()
		{
			return OptionalInt16.CombineHashCodes(this.hasValue.GetHashCode(), this.value.GetHashCode());
		}

		// Token: 0x06002DBF RID: 11711 RVA: 0x000F4858 File Offset: 0x000F2A58
		public override string ToString()
		{
			if (!this.hasValue)
			{
				return "";
			}
			return this.value.ToString(CultureInfo.InvariantCulture);
		}

		// Token: 0x06002DC0 RID: 11712 RVA: 0x000F4878 File Offset: 0x000F2A78
		public static implicit operator OptionalInt16(short value)
		{
			return new OptionalInt16(value);
		}

		// Token: 0x06002DC1 RID: 11713 RVA: 0x000F4880 File Offset: 0x000F2A80
		public static explicit operator short(OptionalInt16 optional)
		{
			return optional.Value;
		}

		// Token: 0x040032CB RID: 13003
		[SerializeField]
		private bool hasValue;

		// Token: 0x040032CC RID: 13004
		[SerializeField]
		private short value;
	}
}
