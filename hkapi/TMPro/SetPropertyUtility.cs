using System;
using UnityEngine;

namespace TMPro
{
	// Token: 0x020005FA RID: 1530
	internal static class SetPropertyUtility
	{
		// Token: 0x06002429 RID: 9257 RVA: 0x000B9F44 File Offset: 0x000B8144
		public static bool SetColor(ref Color currentValue, Color newValue)
		{
			if (currentValue.r == newValue.r && currentValue.g == newValue.g && currentValue.b == newValue.b && currentValue.a == newValue.a)
			{
				return false;
			}
			currentValue = newValue;
			return true;
		}

		// Token: 0x0600242A RID: 9258 RVA: 0x000B9F93 File Offset: 0x000B8193
		public static bool SetEquatableStruct<T>(ref T currentValue, T newValue) where T : IEquatable<T>
		{
			if (currentValue.Equals(newValue))
			{
				return false;
			}
			currentValue = newValue;
			return true;
		}

		// Token: 0x0600242B RID: 9259 RVA: 0x000B9FAE File Offset: 0x000B81AE
		public static bool SetStruct<T>(ref T currentValue, T newValue) where T : struct
		{
			if (currentValue.Equals(newValue))
			{
				return false;
			}
			currentValue = newValue;
			return true;
		}

		// Token: 0x0600242C RID: 9260 RVA: 0x000B9FD0 File Offset: 0x000B81D0
		public static bool SetClass<T>(ref T currentValue, T newValue) where T : class
		{
			if ((currentValue == null && newValue == null) || (currentValue != null && currentValue.Equals(newValue)))
			{
				return false;
			}
			currentValue = newValue;
			return true;
		}
	}
}
