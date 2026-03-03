using System;
using System.Globalization;
using UnityEngine;

namespace InControl
{
	// Token: 0x0200072C RID: 1836
	[Serializable]
	public struct OptionalInt32
	{
		// Token: 0x06002DC2 RID: 11714 RVA: 0x000F4889 File Offset: 0x000F2A89
		public OptionalInt32(int value)
		{
			this.value = value;
			this.hasValue = true;
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06002DC3 RID: 11715 RVA: 0x000F4899 File Offset: 0x000F2A99
		public bool HasValue
		{
			get
			{
				return this.hasValue;
			}
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06002DC4 RID: 11716 RVA: 0x000F48A1 File Offset: 0x000F2AA1
		public bool HasNoValue
		{
			get
			{
				return !this.hasValue;
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x06002DC5 RID: 11717 RVA: 0x000F48AC File Offset: 0x000F2AAC
		// (set) Token: 0x06002DC6 RID: 11718 RVA: 0x000F4889 File Offset: 0x000F2A89
		public int Value
		{
			get
			{
				if (!this.hasValue)
				{
					throw new OptionalTypeHasNoValueException("Trying to get a value from an OptionalInt32 that has no value.");
				}
				return this.value;
			}
			set
			{
				this.value = value;
				this.hasValue = true;
			}
		}

		// Token: 0x06002DC7 RID: 11719 RVA: 0x000F48C7 File Offset: 0x000F2AC7
		public void Clear()
		{
			this.value = 0;
			this.hasValue = false;
		}

		// Token: 0x06002DC8 RID: 11720 RVA: 0x000F48D7 File Offset: 0x000F2AD7
		public int GetValueOrDefault(int defaultValue)
		{
			if (!this.hasValue)
			{
				return defaultValue;
			}
			return this.value;
		}

		// Token: 0x06002DC9 RID: 11721 RVA: 0x000F48E9 File Offset: 0x000F2AE9
		public int GetValueOrZero()
		{
			if (!this.hasValue)
			{
				return 0;
			}
			return this.value;
		}

		// Token: 0x06002DCA RID: 11722 RVA: 0x000F4889 File Offset: 0x000F2A89
		public void SetValue(int value)
		{
			this.value = value;
			this.hasValue = true;
		}

		// Token: 0x06002DCB RID: 11723 RVA: 0x000F48FB File Offset: 0x000F2AFB
		public override bool Equals(object other)
		{
			return (other == null && !this.hasValue) || this.value.Equals(other);
		}

		// Token: 0x06002DCC RID: 11724 RVA: 0x000F4916 File Offset: 0x000F2B16
		public bool Equals(OptionalInt32 other)
		{
			return this.hasValue && other.hasValue && this.value == other.value;
		}

		// Token: 0x06002DCD RID: 11725 RVA: 0x000F4938 File Offset: 0x000F2B38
		public bool Equals(int other)
		{
			return this.hasValue && this.value == other;
		}

		// Token: 0x06002DCE RID: 11726 RVA: 0x000F4916 File Offset: 0x000F2B16
		public static bool operator ==(OptionalInt32 a, OptionalInt32 b)
		{
			return a.hasValue && b.hasValue && a.value == b.value;
		}

		// Token: 0x06002DCF RID: 11727 RVA: 0x000F494D File Offset: 0x000F2B4D
		public static bool operator !=(OptionalInt32 a, OptionalInt32 b)
		{
			return !(a == b);
		}

		// Token: 0x06002DD0 RID: 11728 RVA: 0x000F4938 File Offset: 0x000F2B38
		public static bool operator ==(OptionalInt32 a, int b)
		{
			return a.hasValue && a.value == b;
		}

		// Token: 0x06002DD1 RID: 11729 RVA: 0x000F4959 File Offset: 0x000F2B59
		public static bool operator !=(OptionalInt32 a, int b)
		{
			return !a.hasValue || a.value != b;
		}

		// Token: 0x06002DD2 RID: 11730 RVA: 0x000F4419 File Offset: 0x000F2619
		private static int CombineHashCodes(int h1, int h2)
		{
			return (h1 << 5) + h1 ^ h2;
		}

		// Token: 0x06002DD3 RID: 11731 RVA: 0x000F4971 File Offset: 0x000F2B71
		public override int GetHashCode()
		{
			return OptionalInt32.CombineHashCodes(this.hasValue.GetHashCode(), this.value.GetHashCode());
		}

		// Token: 0x06002DD4 RID: 11732 RVA: 0x000F498E File Offset: 0x000F2B8E
		public override string ToString()
		{
			if (!this.hasValue)
			{
				return "";
			}
			return this.value.ToString(CultureInfo.InvariantCulture);
		}

		// Token: 0x06002DD5 RID: 11733 RVA: 0x000F49AE File Offset: 0x000F2BAE
		public static implicit operator OptionalInt32(int value)
		{
			return new OptionalInt32(value);
		}

		// Token: 0x06002DD6 RID: 11734 RVA: 0x000F49B6 File Offset: 0x000F2BB6
		public static explicit operator int(OptionalInt32 optional)
		{
			return optional.Value;
		}

		// Token: 0x040032CD RID: 13005
		[SerializeField]
		private bool hasValue;

		// Token: 0x040032CE RID: 13006
		[SerializeField]
		private int value;
	}
}
