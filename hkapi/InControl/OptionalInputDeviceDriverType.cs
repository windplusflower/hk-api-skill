using System;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000729 RID: 1833
	[Serializable]
	public struct OptionalInputDeviceDriverType
	{
		// Token: 0x06002D83 RID: 11651 RVA: 0x000F44CD File Offset: 0x000F26CD
		public OptionalInputDeviceDriverType(InputDeviceDriverType value)
		{
			this.value = value;
			this.hasValue = true;
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x06002D84 RID: 11652 RVA: 0x000F44DD File Offset: 0x000F26DD
		public bool HasValue
		{
			get
			{
				return this.hasValue;
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x06002D85 RID: 11653 RVA: 0x000F44E5 File Offset: 0x000F26E5
		public bool HasNoValue
		{
			get
			{
				return !this.hasValue;
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06002D86 RID: 11654 RVA: 0x000F44F0 File Offset: 0x000F26F0
		// (set) Token: 0x06002D87 RID: 11655 RVA: 0x000F44CD File Offset: 0x000F26CD
		public InputDeviceDriverType Value
		{
			get
			{
				if (!this.hasValue)
				{
					throw new OptionalTypeHasNoValueException("Trying to get a value from an OptionalInputDeviceDriverType that has no value.");
				}
				return this.value;
			}
			set
			{
				this.value = value;
				this.hasValue = true;
			}
		}

		// Token: 0x06002D88 RID: 11656 RVA: 0x000F450B File Offset: 0x000F270B
		public void Clear()
		{
			this.value = InputDeviceDriverType.Unknown;
			this.hasValue = false;
		}

		// Token: 0x06002D89 RID: 11657 RVA: 0x000F451B File Offset: 0x000F271B
		public InputDeviceDriverType GetValueOrDefault(InputDeviceDriverType defaultValue)
		{
			if (!this.hasValue)
			{
				return defaultValue;
			}
			return this.value;
		}

		// Token: 0x06002D8A RID: 11658 RVA: 0x000F452D File Offset: 0x000F272D
		public InputDeviceDriverType GetValueOrZero()
		{
			if (!this.hasValue)
			{
				return InputDeviceDriverType.Unknown;
			}
			return this.value;
		}

		// Token: 0x06002D8B RID: 11659 RVA: 0x000F44CD File Offset: 0x000F26CD
		public void SetValue(InputDeviceDriverType value)
		{
			this.value = value;
			this.hasValue = true;
		}

		// Token: 0x06002D8C RID: 11660 RVA: 0x000F453F File Offset: 0x000F273F
		public override bool Equals(object other)
		{
			return (other == null && !this.hasValue) || this.value.Equals(other);
		}

		// Token: 0x06002D8D RID: 11661 RVA: 0x000F4560 File Offset: 0x000F2760
		public bool Equals(OptionalInputDeviceDriverType other)
		{
			return this.hasValue && other.hasValue && this.value == other.value;
		}

		// Token: 0x06002D8E RID: 11662 RVA: 0x000F4582 File Offset: 0x000F2782
		public bool Equals(InputDeviceDriverType other)
		{
			return this.hasValue && this.value == other;
		}

		// Token: 0x06002D8F RID: 11663 RVA: 0x000F4560 File Offset: 0x000F2760
		public static bool operator ==(OptionalInputDeviceDriverType a, OptionalInputDeviceDriverType b)
		{
			return a.hasValue && b.hasValue && a.value == b.value;
		}

		// Token: 0x06002D90 RID: 11664 RVA: 0x000F4597 File Offset: 0x000F2797
		public static bool operator !=(OptionalInputDeviceDriverType a, OptionalInputDeviceDriverType b)
		{
			return !(a == b);
		}

		// Token: 0x06002D91 RID: 11665 RVA: 0x000F4582 File Offset: 0x000F2782
		public static bool operator ==(OptionalInputDeviceDriverType a, InputDeviceDriverType b)
		{
			return a.hasValue && a.value == b;
		}

		// Token: 0x06002D92 RID: 11666 RVA: 0x000F45A3 File Offset: 0x000F27A3
		public static bool operator !=(OptionalInputDeviceDriverType a, InputDeviceDriverType b)
		{
			return !a.hasValue || a.value != b;
		}

		// Token: 0x06002D93 RID: 11667 RVA: 0x000F4419 File Offset: 0x000F2619
		private static int CombineHashCodes(int h1, int h2)
		{
			return (h1 << 5) + h1 ^ h2;
		}

		// Token: 0x06002D94 RID: 11668 RVA: 0x000F45BB File Offset: 0x000F27BB
		public override int GetHashCode()
		{
			return OptionalInputDeviceDriverType.CombineHashCodes(this.hasValue.GetHashCode(), this.value.GetHashCode());
		}

		// Token: 0x06002D95 RID: 11669 RVA: 0x000F45DE File Offset: 0x000F27DE
		public override string ToString()
		{
			if (!this.hasValue)
			{
				return "";
			}
			return this.value.ToString();
		}

		// Token: 0x06002D96 RID: 11670 RVA: 0x000F45FF File Offset: 0x000F27FF
		public static implicit operator OptionalInputDeviceDriverType(InputDeviceDriverType value)
		{
			return new OptionalInputDeviceDriverType(value);
		}

		// Token: 0x06002D97 RID: 11671 RVA: 0x000F4607 File Offset: 0x000F2807
		public static explicit operator InputDeviceDriverType(OptionalInputDeviceDriverType optional)
		{
			return optional.Value;
		}

		// Token: 0x040032C7 RID: 12999
		[SerializeField]
		private bool hasValue;

		// Token: 0x040032C8 RID: 13000
		[SerializeField]
		private InputDeviceDriverType value;
	}
}
