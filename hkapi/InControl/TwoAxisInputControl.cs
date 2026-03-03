using System;
using UnityEngine;

namespace InControl
{
	// Token: 0x020006E0 RID: 1760
	public class TwoAxisInputControl : IInputControl
	{
		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06002A58 RID: 10840 RVA: 0x000E8C19 File Offset: 0x000E6E19
		// (set) Token: 0x06002A59 RID: 10841 RVA: 0x000E8C21 File Offset: 0x000E6E21
		public float X { get; protected set; }

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06002A5A RID: 10842 RVA: 0x000E8C2A File Offset: 0x000E6E2A
		// (set) Token: 0x06002A5B RID: 10843 RVA: 0x000E8C32 File Offset: 0x000E6E32
		public float Y { get; protected set; }

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06002A5C RID: 10844 RVA: 0x000E8C3B File Offset: 0x000E6E3B
		// (set) Token: 0x06002A5D RID: 10845 RVA: 0x000E8C43 File Offset: 0x000E6E43
		public OneAxisInputControl Left { get; protected set; }

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06002A5E RID: 10846 RVA: 0x000E8C4C File Offset: 0x000E6E4C
		// (set) Token: 0x06002A5F RID: 10847 RVA: 0x000E8C54 File Offset: 0x000E6E54
		public OneAxisInputControl Right { get; protected set; }

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06002A60 RID: 10848 RVA: 0x000E8C5D File Offset: 0x000E6E5D
		// (set) Token: 0x06002A61 RID: 10849 RVA: 0x000E8C65 File Offset: 0x000E6E65
		public OneAxisInputControl Up { get; protected set; }

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06002A62 RID: 10850 RVA: 0x000E8C6E File Offset: 0x000E6E6E
		// (set) Token: 0x06002A63 RID: 10851 RVA: 0x000E8C76 File Offset: 0x000E6E76
		public OneAxisInputControl Down { get; protected set; }

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06002A64 RID: 10852 RVA: 0x000E8C7F File Offset: 0x000E6E7F
		// (set) Token: 0x06002A65 RID: 10853 RVA: 0x000E8C87 File Offset: 0x000E6E87
		public ulong UpdateTick { get; protected set; }

		// Token: 0x06002A66 RID: 10854 RVA: 0x000E8C90 File Offset: 0x000E6E90
		public TwoAxisInputControl()
		{
			this.DeadZoneFunc = new DeadZoneFunc(DeadZone.Circular);
			this.sensitivity = 1f;
			this.upperDeadZone = 1f;
			base..ctor();
			this.Left = new OneAxisInputControl();
			this.Right = new OneAxisInputControl();
			this.Up = new OneAxisInputControl();
			this.Down = new OneAxisInputControl();
		}

		// Token: 0x06002A67 RID: 10855 RVA: 0x000E8CF8 File Offset: 0x000E6EF8
		public void ClearInputState()
		{
			this.Left.ClearInputState();
			this.Right.ClearInputState();
			this.Up.ClearInputState();
			this.Down.ClearInputState();
			this.lastState = false;
			this.lastValue = Vector2.zero;
			this.thisState = false;
			this.thisValue = Vector2.zero;
			this.X = 0f;
			this.Y = 0f;
			this.clearInputState = true;
		}

		// Token: 0x06002A68 RID: 10856 RVA: 0x000E8D72 File Offset: 0x000E6F72
		public void Filter(TwoAxisInputControl twoAxisInputControl, float deltaTime)
		{
			this.UpdateWithAxes(twoAxisInputControl.X, twoAxisInputControl.Y, InputManager.CurrentTick, deltaTime);
		}

		// Token: 0x06002A69 RID: 10857 RVA: 0x000E8D8C File Offset: 0x000E6F8C
		internal void UpdateWithAxes(float x, float y, ulong updateTick, float deltaTime)
		{
			this.lastState = this.thisState;
			this.lastValue = this.thisValue;
			this.thisValue = (this.Raw ? new Vector2(x, y) : this.DeadZoneFunc(x, y, this.LowerDeadZone, this.UpperDeadZone));
			this.X = this.thisValue.x;
			this.Y = this.thisValue.y;
			this.Left.CommitWithValue(Mathf.Max(0f, -this.X), updateTick, deltaTime);
			this.Right.CommitWithValue(Mathf.Max(0f, this.X), updateTick, deltaTime);
			if (InputManager.InvertYAxis)
			{
				this.Up.CommitWithValue(Mathf.Max(0f, -this.Y), updateTick, deltaTime);
				this.Down.CommitWithValue(Mathf.Max(0f, this.Y), updateTick, deltaTime);
			}
			else
			{
				this.Up.CommitWithValue(Mathf.Max(0f, this.Y), updateTick, deltaTime);
				this.Down.CommitWithValue(Mathf.Max(0f, -this.Y), updateTick, deltaTime);
			}
			this.thisState = (this.Up.State || this.Down.State || this.Left.State || this.Right.State);
			if (this.clearInputState)
			{
				this.lastState = this.thisState;
				this.lastValue = this.thisValue;
				this.clearInputState = false;
				this.HasChanged = false;
				return;
			}
			if (this.thisValue != this.lastValue)
			{
				this.UpdateTick = updateTick;
				this.HasChanged = true;
				return;
			}
			this.HasChanged = false;
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06002A6A RID: 10858 RVA: 0x000E8F56 File Offset: 0x000E7156
		// (set) Token: 0x06002A6B RID: 10859 RVA: 0x000E8F60 File Offset: 0x000E7160
		public float Sensitivity
		{
			get
			{
				return this.sensitivity;
			}
			set
			{
				this.sensitivity = Mathf.Clamp01(value);
				this.Left.Sensitivity = this.sensitivity;
				this.Right.Sensitivity = this.sensitivity;
				this.Up.Sensitivity = this.sensitivity;
				this.Down.Sensitivity = this.sensitivity;
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06002A6C RID: 10860 RVA: 0x000E8FBD File Offset: 0x000E71BD
		// (set) Token: 0x06002A6D RID: 10861 RVA: 0x000E8FC8 File Offset: 0x000E71C8
		public float StateThreshold
		{
			get
			{
				return this.stateThreshold;
			}
			set
			{
				this.stateThreshold = Mathf.Clamp01(value);
				this.Left.StateThreshold = this.stateThreshold;
				this.Right.StateThreshold = this.stateThreshold;
				this.Up.StateThreshold = this.stateThreshold;
				this.Down.StateThreshold = this.stateThreshold;
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06002A6E RID: 10862 RVA: 0x000E9025 File Offset: 0x000E7225
		// (set) Token: 0x06002A6F RID: 10863 RVA: 0x000E9030 File Offset: 0x000E7230
		public float LowerDeadZone
		{
			get
			{
				return this.lowerDeadZone;
			}
			set
			{
				this.lowerDeadZone = Mathf.Clamp01(value);
				this.Left.LowerDeadZone = this.lowerDeadZone;
				this.Right.LowerDeadZone = this.lowerDeadZone;
				this.Up.LowerDeadZone = this.lowerDeadZone;
				this.Down.LowerDeadZone = this.lowerDeadZone;
			}
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06002A70 RID: 10864 RVA: 0x000E908D File Offset: 0x000E728D
		// (set) Token: 0x06002A71 RID: 10865 RVA: 0x000E9098 File Offset: 0x000E7298
		public float UpperDeadZone
		{
			get
			{
				return this.upperDeadZone;
			}
			set
			{
				this.upperDeadZone = Mathf.Clamp01(value);
				this.Left.UpperDeadZone = this.upperDeadZone;
				this.Right.UpperDeadZone = this.upperDeadZone;
				this.Up.UpperDeadZone = this.upperDeadZone;
				this.Down.UpperDeadZone = this.upperDeadZone;
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06002A72 RID: 10866 RVA: 0x000E90F5 File Offset: 0x000E72F5
		public bool State
		{
			get
			{
				return this.thisState;
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06002A73 RID: 10867 RVA: 0x000E90FD File Offset: 0x000E72FD
		public bool LastState
		{
			get
			{
				return this.lastState;
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06002A74 RID: 10868 RVA: 0x000E9105 File Offset: 0x000E7305
		public Vector2 Value
		{
			get
			{
				return this.thisValue;
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06002A75 RID: 10869 RVA: 0x000E910D File Offset: 0x000E730D
		public Vector2 LastValue
		{
			get
			{
				return this.lastValue;
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06002A76 RID: 10870 RVA: 0x000E9105 File Offset: 0x000E7305
		public Vector2 Vector
		{
			get
			{
				return this.thisValue;
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06002A77 RID: 10871 RVA: 0x000E9115 File Offset: 0x000E7315
		// (set) Token: 0x06002A78 RID: 10872 RVA: 0x000E911D File Offset: 0x000E731D
		public bool HasChanged { get; protected set; }

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06002A79 RID: 10873 RVA: 0x000E90F5 File Offset: 0x000E72F5
		public bool IsPressed
		{
			get
			{
				return this.thisState;
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06002A7A RID: 10874 RVA: 0x000E9126 File Offset: 0x000E7326
		public bool WasPressed
		{
			get
			{
				return this.thisState && !this.lastState;
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06002A7B RID: 10875 RVA: 0x000E913B File Offset: 0x000E733B
		public bool WasReleased
		{
			get
			{
				return !this.thisState && this.lastState;
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06002A7C RID: 10876 RVA: 0x000E914D File Offset: 0x000E734D
		public float Angle
		{
			get
			{
				return Utility.VectorToAngle(this.thisValue);
			}
		}

		// Token: 0x06002A7D RID: 10877 RVA: 0x000E90F5 File Offset: 0x000E72F5
		public static implicit operator bool(TwoAxisInputControl instance)
		{
			return instance.thisState;
		}

		// Token: 0x06002A7E RID: 10878 RVA: 0x000E9105 File Offset: 0x000E7305
		public static implicit operator Vector2(TwoAxisInputControl instance)
		{
			return instance.thisValue;
		}

		// Token: 0x06002A7F RID: 10879 RVA: 0x000E915A File Offset: 0x000E735A
		public static implicit operator Vector3(TwoAxisInputControl instance)
		{
			return instance.thisValue;
		}

		// Token: 0x06002A80 RID: 10880 RVA: 0x000E9167 File Offset: 0x000E7367
		// Note: this type is marked as 'beforefieldinit'.
		static TwoAxisInputControl()
		{
			TwoAxisInputControl.Null = new TwoAxisInputControl();
		}

		// Token: 0x04003099 RID: 12441
		public static readonly TwoAxisInputControl Null;

		// Token: 0x040030A1 RID: 12449
		public DeadZoneFunc DeadZoneFunc;

		// Token: 0x040030A2 RID: 12450
		private float sensitivity;

		// Token: 0x040030A3 RID: 12451
		private float lowerDeadZone;

		// Token: 0x040030A4 RID: 12452
		private float upperDeadZone;

		// Token: 0x040030A5 RID: 12453
		private float stateThreshold;

		// Token: 0x040030A6 RID: 12454
		public bool Raw;

		// Token: 0x040030A7 RID: 12455
		private bool thisState;

		// Token: 0x040030A8 RID: 12456
		private bool lastState;

		// Token: 0x040030A9 RID: 12457
		private Vector2 thisValue;

		// Token: 0x040030AA RID: 12458
		private Vector2 lastValue;

		// Token: 0x040030AB RID: 12459
		private bool clearInputState;
	}
}
