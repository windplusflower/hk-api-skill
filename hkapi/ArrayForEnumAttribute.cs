using System;
using UnityEngine;

// Token: 0x020000A5 RID: 165
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
public class ArrayForEnumAttribute : PropertyAttribute
{
	// Token: 0x17000060 RID: 96
	// (get) Token: 0x0600038C RID: 908 RVA: 0x00012B4A File Offset: 0x00010D4A
	public bool IsValid
	{
		get
		{
			return this.EnumType != null && this.EnumType.IsEnum && this.EnumLength > 0;
		}
	}

	// Token: 0x0600038D RID: 909 RVA: 0x00012B74 File Offset: 0x00010D74
	public ArrayForEnumAttribute(Type enumType)
	{
		this.EnumType = enumType;
		if (enumType != null && enumType.IsEnum)
		{
			int num = 0;
			Array values = Enum.GetValues(enumType);
			for (int i = 0; i < values.Length; i++)
			{
				int num2 = (int)values.GetValue(i);
				if (num2 >= 0 && num < num2)
				{
					num = num2 + 1;
				}
			}
			this.EnumLength = num;
			return;
		}
		this.EnumLength = 0;
	}

	// Token: 0x0600038E RID: 910 RVA: 0x00012BE4 File Offset: 0x00010DE4
	public static void EnsureArraySize<T>(ref T[] array, Type enumType)
	{
		int num = Enum.GetNames(enumType).Length;
		if (array != null)
		{
			if (array.Length != num)
			{
				T[] array2 = array;
				array = new T[num];
				for (int i = 0; i < Mathf.Min(num, array2.Length); i++)
				{
					array[i] = array2[i];
				}
				return;
			}
		}
		else
		{
			array = new T[num];
		}
	}

	// Token: 0x040002F4 RID: 756
	public readonly Type EnumType;

	// Token: 0x040002F5 RID: 757
	public readonly int EnumLength;
}
