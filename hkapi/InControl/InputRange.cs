using System;
using UnityEngine;

namespace InControl
{
	// Token: 0x020006DD RID: 1757
	[Serializable]
	public struct InputRange
	{
		// Token: 0x06002A29 RID: 10793 RVA: 0x000E8461 File Offset: 0x000E6661
		private InputRange(float value0, float value1, InputRangeType type)
		{
			this.Value0 = value0;
			this.Value1 = value1;
			this.Type = type;
		}

		// Token: 0x06002A2A RID: 10794 RVA: 0x000E8478 File Offset: 0x000E6678
		public InputRange(InputRangeType type)
		{
			this.Value0 = InputRange.typeToRange[(int)type].Value0;
			this.Value1 = InputRange.typeToRange[(int)type].Value1;
			this.Type = type;
		}

		// Token: 0x06002A2B RID: 10795 RVA: 0x000E84AD File Offset: 0x000E66AD
		public bool Includes(float value)
		{
			return !this.Excludes(value);
		}

		// Token: 0x06002A2C RID: 10796 RVA: 0x000E84B9 File Offset: 0x000E66B9
		private bool Excludes(float value)
		{
			return this.Type == InputRangeType.None || value < Mathf.Min(this.Value0, this.Value1) || value > Mathf.Max(this.Value0, this.Value1);
		}

		// Token: 0x06002A2D RID: 10797 RVA: 0x000E84EF File Offset: 0x000E66EF
		public static bool Excludes(InputRangeType rangeType, float value)
		{
			return InputRange.typeToRange[(int)rangeType].Excludes(value);
		}

		// Token: 0x06002A2E RID: 10798 RVA: 0x000E8504 File Offset: 0x000E6704
		private static float Remap(float value, InputRange sourceRange, InputRange targetRange)
		{
			if (sourceRange.Excludes(value))
			{
				return 0f;
			}
			float t = Mathf.InverseLerp(sourceRange.Value0, sourceRange.Value1, value);
			return Mathf.Lerp(targetRange.Value0, targetRange.Value1, t);
		}

		// Token: 0x06002A2F RID: 10799 RVA: 0x000E8548 File Offset: 0x000E6748
		public static float Remap(float value, InputRangeType sourceRangeType, InputRangeType targetRangeType)
		{
			InputRange sourceRange = InputRange.typeToRange[(int)sourceRangeType];
			InputRange targetRange = InputRange.typeToRange[(int)targetRangeType];
			return InputRange.Remap(value, sourceRange, targetRange);
		}

		// Token: 0x06002A30 RID: 10800 RVA: 0x000E8578 File Offset: 0x000E6778
		// Note: this type is marked as 'beforefieldinit'.
		static InputRange()
		{
			InputRange.None = new InputRange(0f, 0f, InputRangeType.None);
			InputRange.MinusOneToOne = new InputRange(-1f, 1f, InputRangeType.MinusOneToOne);
			InputRange.OneToMinusOne = new InputRange(1f, -1f, InputRangeType.OneToMinusOne);
			InputRange.ZeroToOne = new InputRange(0f, 1f, InputRangeType.ZeroToOne);
			InputRange.ZeroToMinusOne = new InputRange(0f, -1f, InputRangeType.ZeroToMinusOne);
			InputRange.OneToZero = new InputRange(1f, 0f, InputRangeType.OneToZero);
			InputRange.MinusOneToZero = new InputRange(-1f, 0f, InputRangeType.MinusOneToZero);
			InputRange.typeToRange = new InputRange[]
			{
				InputRange.None,
				InputRange.MinusOneToOne,
				InputRange.OneToMinusOne,
				InputRange.ZeroToOne,
				InputRange.ZeroToMinusOne,
				InputRange.OneToZero,
				InputRange.MinusOneToZero
			};
		}

		// Token: 0x04003073 RID: 12403
		public static readonly InputRange None;

		// Token: 0x04003074 RID: 12404
		public static readonly InputRange MinusOneToOne;

		// Token: 0x04003075 RID: 12405
		public static readonly InputRange OneToMinusOne;

		// Token: 0x04003076 RID: 12406
		public static readonly InputRange ZeroToOne;

		// Token: 0x04003077 RID: 12407
		public static readonly InputRange ZeroToMinusOne;

		// Token: 0x04003078 RID: 12408
		public static readonly InputRange OneToZero;

		// Token: 0x04003079 RID: 12409
		public static readonly InputRange MinusOneToZero;

		// Token: 0x0400307A RID: 12410
		private static readonly InputRange[] typeToRange;

		// Token: 0x0400307B RID: 12411
		public readonly float Value0;

		// Token: 0x0400307C RID: 12412
		public readonly float Value1;

		// Token: 0x0400307D RID: 12413
		public readonly InputRangeType Type;
	}
}
