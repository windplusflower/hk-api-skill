using System;
using System.Globalization;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000728 RID: 1832
	[Serializable]
	public struct OptionalFloat
	{
		// Token: 0x06002D6C RID: 11628 RVA: 0x000F4320 File Offset: 0x000F2520
		public OptionalFloat(float value)
		{
			this.value = value;
			this.hasValue = true;
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06002D6D RID: 11629 RVA: 0x000F4330 File Offset: 0x000F2530
		public bool HasValue
		{
			get
			{
				return this.hasValue;
			}
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x06002D6E RID: 11630 RVA: 0x000F4338 File Offset: 0x000F2538
		public bool HasNoValue
		{
			get
			{
				return !this.hasValue;
			}
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x06002D6F RID: 11631 RVA: 0x000F4343 File Offset: 0x000F2543
		// (set) Token: 0x06002D70 RID: 11632 RVA: 0x000F4320 File Offset: 0x000F2520
		public float Value
		{
			get
			{
				if (!this.hasValue)
				{
					throw new OptionalTypeHasNoValueException("Trying to get a value from an OptionalFloat that has no value.");
				}
				return this.value;
			}
			set
			{
				this.value = value;
				this.hasValue = true;
			}
		}

		// Token: 0x06002D71 RID: 11633 RVA: 0x000F435E File Offset: 0x000F255E
		public void Clear()
		{
			this.value = 0f;
			this.hasValue = false;
		}

		// Token: 0x06002D72 RID: 11634 RVA: 0x000F4372 File Offset: 0x000F2572
		public float GetValueOrDefault(float defaultValue)
		{
			if (!this.hasValue)
			{
				return defaultValue;
			}
			return this.value;
		}

		// Token: 0x06002D73 RID: 11635 RVA: 0x000F4384 File Offset: 0x000F2584
		public float GetValueOrZero()
		{
			if (!this.hasValue)
			{
				return 0f;
			}
			return this.value;
		}

		// Token: 0x06002D74 RID: 11636 RVA: 0x000F4320 File Offset: 0x000F2520
		public void SetValue(float value)
		{
			this.value = value;
			this.hasValue = true;
		}

		// Token: 0x06002D75 RID: 11637 RVA: 0x000F439A File Offset: 0x000F259A
		public override bool Equals(object other)
		{
			return (other == null && !this.hasValue) || this.value.Equals(other);
		}

		// Token: 0x06002D76 RID: 11638 RVA: 0x000F43B5 File Offset: 0x000F25B5
		public bool Equals(OptionalFloat other)
		{
			return this.hasValue && other.hasValue && OptionalFloat.IsApproximatelyEqual(this.value, other.value);
		}

		// Token: 0x06002D77 RID: 11639 RVA: 0x000F43DA File Offset: 0x000F25DA
		public bool Equals(float other)
		{
			return this.hasValue && OptionalFloat.IsApproximatelyEqual(this.value, other);
		}

		// Token: 0x06002D78 RID: 11640 RVA: 0x000F43B5 File Offset: 0x000F25B5
		public static bool operator ==(OptionalFloat a, OptionalFloat b)
		{
			return a.hasValue && b.hasValue && OptionalFloat.IsApproximatelyEqual(a.value, b.value);
		}

		// Token: 0x06002D79 RID: 11641 RVA: 0x000F43F2 File Offset: 0x000F25F2
		public static bool operator !=(OptionalFloat a, OptionalFloat b)
		{
			return !(a == b);
		}

		// Token: 0x06002D7A RID: 11642 RVA: 0x000F43DA File Offset: 0x000F25DA
		public static bool operator ==(OptionalFloat a, float b)
		{
			return a.hasValue && OptionalFloat.IsApproximatelyEqual(a.value, b);
		}

		// Token: 0x06002D7B RID: 11643 RVA: 0x000F43FE File Offset: 0x000F25FE
		public static bool operator !=(OptionalFloat a, float b)
		{
			return !a.hasValue || !OptionalFloat.IsApproximatelyEqual(a.value, b);
		}

		// Token: 0x06002D7C RID: 11644 RVA: 0x000F4419 File Offset: 0x000F2619
		private static int CombineHashCodes(int h1, int h2)
		{
			return (h1 << 5) + h1 ^ h2;
		}

		// Token: 0x06002D7D RID: 11645 RVA: 0x000F4422 File Offset: 0x000F2622
		public override int GetHashCode()
		{
			return OptionalFloat.CombineHashCodes(this.hasValue.GetHashCode(), this.value.GetHashCode());
		}

		// Token: 0x06002D7E RID: 11646 RVA: 0x000F443F File Offset: 0x000F263F
		public override string ToString()
		{
			if (!this.hasValue)
			{
				return "";
			}
			return this.value.ToString(CultureInfo.InvariantCulture);
		}

		// Token: 0x06002D7F RID: 11647 RVA: 0x000F445F File Offset: 0x000F265F
		public static implicit operator OptionalFloat(float value)
		{
			return new OptionalFloat(value);
		}

		// Token: 0x06002D80 RID: 11648 RVA: 0x000F4467 File Offset: 0x000F2667
		public static explicit operator float(OptionalFloat optional)
		{
			return optional.Value;
		}

		// Token: 0x06002D81 RID: 11649 RVA: 0x000F4470 File Offset: 0x000F2670
		private static bool IsApproximatelyEqual(float a, float b)
		{
			float num = a - b;
			return num >= -1E-07f && num <= 1E-07f;
		}

		// Token: 0x06002D82 RID: 11650 RVA: 0x000F4498 File Offset: 0x000F2698
		public bool ApproximatelyEquals(float other)
		{
			if (!this.hasValue)
			{
				return false;
			}
			float num = this.value - other;
			return num >= -1E-07f && num <= 1E-07f;
		}

		// Token: 0x040032C4 RID: 12996
		[SerializeField]
		private bool hasValue;

		// Token: 0x040032C5 RID: 12997
		[SerializeField]
		private float value;

		// Token: 0x040032C6 RID: 12998
		private const float epsilon = 1E-07f;
	}
}
