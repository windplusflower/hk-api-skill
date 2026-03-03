using System;

namespace InControl
{
	// Token: 0x020006DB RID: 1755
	public struct InputControlState
	{
		// Token: 0x06002A21 RID: 10785 RVA: 0x000E8394 File Offset: 0x000E6594
		public void Reset()
		{
			this.State = false;
			this.Value = 0f;
			this.RawValue = 0f;
		}

		// Token: 0x06002A22 RID: 10786 RVA: 0x000E83B3 File Offset: 0x000E65B3
		public void Set(float value)
		{
			this.Value = value;
			this.State = Utility.IsNotZero(value);
		}

		// Token: 0x06002A23 RID: 10787 RVA: 0x000E83C8 File Offset: 0x000E65C8
		public void Set(float value, float threshold)
		{
			this.Value = value;
			this.State = Utility.AbsoluteIsOverThreshold(value, threshold);
		}

		// Token: 0x06002A24 RID: 10788 RVA: 0x000E83DE File Offset: 0x000E65DE
		public void Set(bool state)
		{
			this.State = state;
			this.Value = (state ? 1f : 0f);
			this.RawValue = this.Value;
		}

		// Token: 0x06002A25 RID: 10789 RVA: 0x000E8408 File Offset: 0x000E6608
		public static implicit operator bool(InputControlState state)
		{
			return state.State;
		}

		// Token: 0x06002A26 RID: 10790 RVA: 0x000E8410 File Offset: 0x000E6610
		public static implicit operator float(InputControlState state)
		{
			return state.Value;
		}

		// Token: 0x06002A27 RID: 10791 RVA: 0x000E8418 File Offset: 0x000E6618
		public static bool operator ==(InputControlState a, InputControlState b)
		{
			return a.State == b.State && Utility.Approximately(a.Value, b.Value);
		}

		// Token: 0x06002A28 RID: 10792 RVA: 0x000E843B File Offset: 0x000E663B
		public static bool operator !=(InputControlState a, InputControlState b)
		{
			return a.State != b.State || !Utility.Approximately(a.Value, b.Value);
		}

		// Token: 0x04002FF1 RID: 12273
		public bool State;

		// Token: 0x04002FF2 RID: 12274
		public float Value;

		// Token: 0x04002FF3 RID: 12275
		public float RawValue;
	}
}
