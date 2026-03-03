using System;
using UnityEngine;

namespace InControl
{
	// Token: 0x020006DF RID: 1759
	public class OneAxisInputControl : IInputControl
	{
		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06002A31 RID: 10801 RVA: 0x000E8677 File Offset: 0x000E6877
		// (set) Token: 0x06002A32 RID: 10802 RVA: 0x000E867F File Offset: 0x000E687F
		public ulong UpdateTick { get; protected set; }

		// Token: 0x06002A33 RID: 10803 RVA: 0x000E8688 File Offset: 0x000E6888
		private void PrepareForUpdate(ulong updateTick)
		{
			if (this.isNullControl)
			{
				return;
			}
			if (updateTick < this.pendingTick)
			{
				throw new InvalidOperationException("Cannot be updated with an earlier tick.");
			}
			if (this.pendingCommit && updateTick != this.pendingTick)
			{
				throw new InvalidOperationException("Cannot be updated for a new tick until pending tick is committed.");
			}
			if (updateTick > this.pendingTick)
			{
				this.lastState = this.thisState;
				this.nextState.Reset();
				this.pendingTick = updateTick;
				this.pendingCommit = true;
			}
		}

		// Token: 0x06002A34 RID: 10804 RVA: 0x000E86FC File Offset: 0x000E68FC
		public bool UpdateWithState(bool state, ulong updateTick, float deltaTime)
		{
			if (this.isNullControl)
			{
				return false;
			}
			this.PrepareForUpdate(updateTick);
			this.nextState.Set(state || this.nextState.State);
			return state;
		}

		// Token: 0x06002A35 RID: 10805 RVA: 0x000E872C File Offset: 0x000E692C
		public bool UpdateWithValue(float value, ulong updateTick, float deltaTime)
		{
			if (this.isNullControl)
			{
				return false;
			}
			this.PrepareForUpdate(updateTick);
			if (Utility.Abs(value) > Utility.Abs(this.nextState.RawValue))
			{
				this.nextState.RawValue = value;
				if (!this.Raw)
				{
					value = Utility.ApplyDeadZone(value, this.lowerDeadZone, this.upperDeadZone);
				}
				this.nextState.Set(value, this.stateThreshold);
				return true;
			}
			return false;
		}

		// Token: 0x06002A36 RID: 10806 RVA: 0x000E87A4 File Offset: 0x000E69A4
		internal bool UpdateWithRawValue(float value, ulong updateTick, float deltaTime)
		{
			if (this.isNullControl)
			{
				return false;
			}
			this.Raw = true;
			this.PrepareForUpdate(updateTick);
			if (Utility.Abs(value) > Utility.Abs(this.nextState.RawValue))
			{
				this.nextState.RawValue = value;
				this.nextState.Set(value, this.stateThreshold);
				return true;
			}
			return false;
		}

		// Token: 0x06002A37 RID: 10807 RVA: 0x000E8804 File Offset: 0x000E6A04
		internal void SetValue(float value, ulong updateTick)
		{
			if (this.isNullControl)
			{
				return;
			}
			if (updateTick > this.pendingTick)
			{
				this.lastState = this.thisState;
				this.nextState.Reset();
				this.pendingTick = updateTick;
				this.pendingCommit = true;
			}
			this.nextState.RawValue = value;
			this.nextState.Set(value, this.StateThreshold);
		}

		// Token: 0x06002A38 RID: 10808 RVA: 0x000E8866 File Offset: 0x000E6A66
		public void ClearInputState()
		{
			this.lastState.Reset();
			this.thisState.Reset();
			this.nextState.Reset();
			this.wasRepeated = false;
			this.clearInputState = true;
		}

		// Token: 0x06002A39 RID: 10809 RVA: 0x000E8898 File Offset: 0x000E6A98
		public void Commit()
		{
			if (this.isNullControl)
			{
				return;
			}
			this.pendingCommit = false;
			this.thisState = this.nextState;
			if (this.clearInputState)
			{
				this.lastState = this.nextState;
				this.UpdateTick = this.pendingTick;
				this.clearInputState = false;
				return;
			}
			bool state = this.lastState.State;
			bool state2 = this.thisState.State;
			this.wasRepeated = false;
			if (state && !state2)
			{
				this.nextRepeatTime = 0f;
			}
			else if (state2)
			{
				float realtimeSinceStartup = Time.realtimeSinceStartup;
				if (!state)
				{
					this.nextRepeatTime = realtimeSinceStartup + this.FirstRepeatDelay;
				}
				else if (realtimeSinceStartup >= this.nextRepeatTime)
				{
					this.wasRepeated = true;
					this.nextRepeatTime = realtimeSinceStartup + this.RepeatDelay;
				}
			}
			if (this.thisState != this.lastState)
			{
				this.UpdateTick = this.pendingTick;
			}
		}

		// Token: 0x06002A3A RID: 10810 RVA: 0x000E8974 File Offset: 0x000E6B74
		public void CommitWithState(bool state, ulong updateTick, float deltaTime)
		{
			this.UpdateWithState(state, updateTick, deltaTime);
			this.Commit();
		}

		// Token: 0x06002A3B RID: 10811 RVA: 0x000E8986 File Offset: 0x000E6B86
		public void CommitWithValue(float value, ulong updateTick, float deltaTime)
		{
			this.UpdateWithValue(value, updateTick, deltaTime);
			this.Commit();
		}

		// Token: 0x06002A3C RID: 10812 RVA: 0x000E8998 File Offset: 0x000E6B98
		internal void CommitWithSides(InputControl negativeSide, InputControl positiveSide, ulong updateTick, float deltaTime)
		{
			this.LowerDeadZone = Mathf.Max(negativeSide.LowerDeadZone, positiveSide.LowerDeadZone);
			this.UpperDeadZone = Mathf.Min(negativeSide.UpperDeadZone, positiveSide.UpperDeadZone);
			this.Raw = (negativeSide.Raw || positiveSide.Raw);
			float value = Utility.ValueFromSides(negativeSide.RawValue, positiveSide.RawValue);
			this.CommitWithValue(value, updateTick, deltaTime);
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06002A3D RID: 10813 RVA: 0x000E8A06 File Offset: 0x000E6C06
		public bool State
		{
			get
			{
				return this.EnabledInHierarchy && this.thisState.State;
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06002A3E RID: 10814 RVA: 0x000E8A1D File Offset: 0x000E6C1D
		public bool LastState
		{
			get
			{
				return this.EnabledInHierarchy && this.lastState.State;
			}
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06002A3F RID: 10815 RVA: 0x000E8A34 File Offset: 0x000E6C34
		public float Value
		{
			get
			{
				if (!this.EnabledInHierarchy)
				{
					return 0f;
				}
				return this.thisState.Value;
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06002A40 RID: 10816 RVA: 0x000E8A4F File Offset: 0x000E6C4F
		public float LastValue
		{
			get
			{
				if (!this.EnabledInHierarchy)
				{
					return 0f;
				}
				return this.lastState.Value;
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06002A41 RID: 10817 RVA: 0x000E8A6A File Offset: 0x000E6C6A
		public float RawValue
		{
			get
			{
				if (!this.EnabledInHierarchy)
				{
					return 0f;
				}
				return this.thisState.RawValue;
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06002A42 RID: 10818 RVA: 0x000E8A85 File Offset: 0x000E6C85
		internal float NextRawValue
		{
			get
			{
				if (!this.EnabledInHierarchy)
				{
					return 0f;
				}
				return this.nextState.RawValue;
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06002A43 RID: 10819 RVA: 0x000E8AA0 File Offset: 0x000E6CA0
		internal bool HasInput
		{
			get
			{
				return this.EnabledInHierarchy && Utility.IsNotZero(this.thisState.Value);
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06002A44 RID: 10820 RVA: 0x000E8ABC File Offset: 0x000E6CBC
		public bool HasChanged
		{
			get
			{
				return this.EnabledInHierarchy && this.thisState != this.lastState;
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06002A45 RID: 10821 RVA: 0x000E8A06 File Offset: 0x000E6C06
		public bool IsPressed
		{
			get
			{
				return this.EnabledInHierarchy && this.thisState.State;
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06002A46 RID: 10822 RVA: 0x000E8AD9 File Offset: 0x000E6CD9
		public bool WasPressed
		{
			get
			{
				return this.EnabledInHierarchy && this.thisState && !this.lastState;
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06002A47 RID: 10823 RVA: 0x000E8B00 File Offset: 0x000E6D00
		public bool WasReleased
		{
			get
			{
				return this.EnabledInHierarchy && !this.thisState && this.lastState;
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06002A48 RID: 10824 RVA: 0x000E8B24 File Offset: 0x000E6D24
		public bool WasRepeated
		{
			get
			{
				return this.EnabledInHierarchy && this.wasRepeated;
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06002A49 RID: 10825 RVA: 0x000E8B36 File Offset: 0x000E6D36
		// (set) Token: 0x06002A4A RID: 10826 RVA: 0x000E8B3E File Offset: 0x000E6D3E
		public float Sensitivity
		{
			get
			{
				return this.sensitivity;
			}
			set
			{
				this.sensitivity = Mathf.Clamp01(value);
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06002A4B RID: 10827 RVA: 0x000E8B4C File Offset: 0x000E6D4C
		// (set) Token: 0x06002A4C RID: 10828 RVA: 0x000E8B54 File Offset: 0x000E6D54
		public float LowerDeadZone
		{
			get
			{
				return this.lowerDeadZone;
			}
			set
			{
				this.lowerDeadZone = Mathf.Clamp01(value);
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06002A4D RID: 10829 RVA: 0x000E8B62 File Offset: 0x000E6D62
		// (set) Token: 0x06002A4E RID: 10830 RVA: 0x000E8B6A File Offset: 0x000E6D6A
		public float UpperDeadZone
		{
			get
			{
				return this.upperDeadZone;
			}
			set
			{
				this.upperDeadZone = Mathf.Clamp01(value);
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06002A4F RID: 10831 RVA: 0x000E8B78 File Offset: 0x000E6D78
		// (set) Token: 0x06002A50 RID: 10832 RVA: 0x000E8B80 File Offset: 0x000E6D80
		public float StateThreshold
		{
			get
			{
				return this.stateThreshold;
			}
			set
			{
				this.stateThreshold = Mathf.Clamp01(value);
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06002A51 RID: 10833 RVA: 0x000E8B8E File Offset: 0x000E6D8E
		public bool IsNullControl
		{
			get
			{
				return this.isNullControl;
			}
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06002A52 RID: 10834 RVA: 0x000E8B96 File Offset: 0x000E6D96
		// (set) Token: 0x06002A53 RID: 10835 RVA: 0x000E8B9E File Offset: 0x000E6D9E
		public bool Enabled
		{
			get
			{
				return this.enabled;
			}
			set
			{
				this.enabled = value;
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06002A54 RID: 10836 RVA: 0x000E8BA7 File Offset: 0x000E6DA7
		public bool EnabledInHierarchy
		{
			get
			{
				return this.enabled && this.ownerEnabled;
			}
		}

		// Token: 0x06002A55 RID: 10837 RVA: 0x000E8BB9 File Offset: 0x000E6DB9
		public static implicit operator bool(OneAxisInputControl instance)
		{
			return instance.State;
		}

		// Token: 0x06002A56 RID: 10838 RVA: 0x000E8BC1 File Offset: 0x000E6DC1
		public static implicit operator float(OneAxisInputControl instance)
		{
			return instance.Value;
		}

		// Token: 0x06002A57 RID: 10839 RVA: 0x000E8BCC File Offset: 0x000E6DCC
		public OneAxisInputControl()
		{
			this.sensitivity = 1f;
			this.upperDeadZone = 1f;
			this.FirstRepeatDelay = 0.8f;
			this.RepeatDelay = 0.1f;
			this.enabled = true;
			this.ownerEnabled = true;
			base..ctor();
		}

		// Token: 0x04003087 RID: 12423
		private float sensitivity;

		// Token: 0x04003088 RID: 12424
		private float lowerDeadZone;

		// Token: 0x04003089 RID: 12425
		private float upperDeadZone;

		// Token: 0x0400308A RID: 12426
		private float stateThreshold;

		// Token: 0x0400308B RID: 12427
		protected bool isNullControl;

		// Token: 0x0400308C RID: 12428
		public float FirstRepeatDelay;

		// Token: 0x0400308D RID: 12429
		public float RepeatDelay;

		// Token: 0x0400308E RID: 12430
		public bool Raw;

		// Token: 0x0400308F RID: 12431
		private bool enabled;

		// Token: 0x04003090 RID: 12432
		protected bool ownerEnabled;

		// Token: 0x04003091 RID: 12433
		private ulong pendingTick;

		// Token: 0x04003092 RID: 12434
		private bool pendingCommit;

		// Token: 0x04003093 RID: 12435
		private float nextRepeatTime;

		// Token: 0x04003094 RID: 12436
		private bool wasRepeated;

		// Token: 0x04003095 RID: 12437
		private bool clearInputState;

		// Token: 0x04003096 RID: 12438
		private InputControlState lastState;

		// Token: 0x04003097 RID: 12439
		private InputControlState nextState;

		// Token: 0x04003098 RID: 12440
		private InputControlState thisState;
	}
}
