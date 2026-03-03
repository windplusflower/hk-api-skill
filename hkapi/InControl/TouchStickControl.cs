using System;
using UnityEngine;

namespace InControl
{
	// Token: 0x0200070D RID: 1805
	public class TouchStickControl : TouchControl
	{
		// Token: 0x06002C83 RID: 11395 RVA: 0x000F033D File Offset: 0x000EE53D
		public override void CreateControl()
		{
			this.ring.Create("Ring", base.transform, 1000);
			this.knob.Create("Knob", base.transform, 1001);
		}

		// Token: 0x06002C84 RID: 11396 RVA: 0x000F0375 File Offset: 0x000EE575
		public override void DestroyControl()
		{
			this.ring.Delete();
			this.knob.Delete();
			if (this.currentTouch != null)
			{
				this.TouchEnded(this.currentTouch);
				this.currentTouch = null;
			}
		}

		// Token: 0x06002C85 RID: 11397 RVA: 0x000F03A8 File Offset: 0x000EE5A8
		public override void ConfigureControl()
		{
			this.resetPosition = base.OffsetToWorldPosition(this.anchor, this.offset, this.offsetUnitType, true);
			base.transform.position = this.resetPosition;
			this.ring.Update(true);
			this.knob.Update(true);
			this.worldActiveArea = TouchManager.ConvertToWorld(this.activeArea, this.areaUnitType);
			this.worldKnobRange = TouchManager.ConvertToWorld(this.knobRange, this.knob.SizeUnitType);
		}

		// Token: 0x06002C86 RID: 11398 RVA: 0x000F0430 File Offset: 0x000EE630
		public override void DrawGizmos()
		{
			this.ring.DrawGizmos(this.RingPosition, Color.yellow);
			this.knob.DrawGizmos(this.KnobPosition, Color.yellow);
			Utility.DrawCircleGizmo(this.RingPosition, this.worldKnobRange, Color.red);
			Utility.DrawRectGizmo(this.worldActiveArea, Color.green);
		}

		// Token: 0x06002C87 RID: 11399 RVA: 0x000F0494 File Offset: 0x000EE694
		private void Update()
		{
			if (this.dirty)
			{
				this.ConfigureControl();
				this.dirty = false;
			}
			else
			{
				this.ring.Update();
				this.knob.Update();
			}
			if (this.IsNotActive)
			{
				if (this.resetWhenDone && this.KnobPosition != this.resetPosition)
				{
					Vector3 b = this.KnobPosition - this.RingPosition;
					this.RingPosition = Vector3.MoveTowards(this.RingPosition, this.resetPosition, this.ringResetSpeed * Time.unscaledDeltaTime);
					this.KnobPosition = this.RingPosition + b;
				}
				if (this.KnobPosition != this.RingPosition)
				{
					this.KnobPosition = Vector3.MoveTowards(this.KnobPosition, this.RingPosition, this.knobResetSpeed * Time.unscaledDeltaTime);
				}
			}
		}

		// Token: 0x06002C88 RID: 11400 RVA: 0x000F0571 File Offset: 0x000EE771
		public override void SubmitControlState(ulong updateTick, float deltaTime)
		{
			base.SubmitAnalogValue(this.target, this.value, this.lowerDeadZone, this.upperDeadZone, updateTick, deltaTime);
		}

		// Token: 0x06002C89 RID: 11401 RVA: 0x000F0598 File Offset: 0x000EE798
		public override void CommitControlState(ulong updateTick, float deltaTime)
		{
			base.CommitAnalog(this.target);
		}

		// Token: 0x06002C8A RID: 11402 RVA: 0x000F05A8 File Offset: 0x000EE7A8
		public override void TouchBegan(Touch touch)
		{
			if (this.IsActive)
			{
				return;
			}
			this.beganPosition = TouchManager.ScreenToWorldPoint(touch.position);
			bool flag = this.worldActiveArea.Contains(this.beganPosition);
			bool flag2 = this.ring.Contains(this.beganPosition);
			if (this.snapToInitialTouch && (flag || flag2))
			{
				this.RingPosition = this.beganPosition;
				this.KnobPosition = this.beganPosition;
				this.currentTouch = touch;
			}
			else if (flag2)
			{
				this.KnobPosition = this.beganPosition;
				this.beganPosition = this.RingPosition;
				this.currentTouch = touch;
			}
			if (this.IsActive)
			{
				this.TouchMoved(touch);
				this.ring.State = true;
				this.knob.State = true;
			}
		}

		// Token: 0x06002C8B RID: 11403 RVA: 0x000F0670 File Offset: 0x000EE870
		public override void TouchMoved(Touch touch)
		{
			if (this.currentTouch != touch)
			{
				return;
			}
			this.movedPosition = TouchManager.ScreenToWorldPoint(touch.position);
			if (this.lockToAxis == LockAxis.Horizontal && this.allowDraggingAxis == DragAxis.Horizontal)
			{
				this.movedPosition.y = this.beganPosition.y;
			}
			else if (this.lockToAxis == LockAxis.Vertical && this.allowDraggingAxis == DragAxis.Vertical)
			{
				this.movedPosition.x = this.beganPosition.x;
			}
			Vector3 vector = this.movedPosition - this.beganPosition;
			Vector3 normalized = vector.normalized;
			float magnitude = vector.magnitude;
			if (this.allowDragging)
			{
				float num = magnitude - this.worldKnobRange;
				if (num < 0f)
				{
					num = 0f;
				}
				Vector3 b = num * normalized;
				if (this.allowDraggingAxis == DragAxis.Horizontal)
				{
					b.y = 0f;
				}
				else if (this.allowDraggingAxis == DragAxis.Vertical)
				{
					b.x = 0f;
				}
				this.beganPosition += b;
				this.RingPosition = this.beganPosition;
			}
			this.movedPosition = this.beganPosition + Mathf.Clamp(magnitude, 0f, this.worldKnobRange) * normalized;
			if (this.lockToAxis == LockAxis.Horizontal)
			{
				this.movedPosition.y = this.beganPosition.y;
			}
			else if (this.lockToAxis == LockAxis.Vertical)
			{
				this.movedPosition.x = this.beganPosition.x;
			}
			if (this.snapAngles != TouchControl.SnapAngles.None)
			{
				this.movedPosition = TouchControl.SnapTo(this.movedPosition - this.beganPosition, this.snapAngles) + this.beganPosition;
			}
			this.RingPosition = this.beganPosition;
			this.KnobPosition = this.movedPosition;
			this.value = (this.movedPosition - this.beganPosition) / this.worldKnobRange;
			this.value.x = this.inputCurve.Evaluate(Utility.Abs(this.value.x)) * Mathf.Sign(this.value.x);
			this.value.y = this.inputCurve.Evaluate(Utility.Abs(this.value.y)) * Mathf.Sign(this.value.y);
		}

		// Token: 0x06002C8C RID: 11404 RVA: 0x000F08CC File Offset: 0x000EEACC
		public override void TouchEnded(Touch touch)
		{
			if (this.currentTouch != touch)
			{
				return;
			}
			this.value = Vector3.zero;
			float magnitude = (this.resetPosition - this.RingPosition).magnitude;
			this.ringResetSpeed = (Utility.IsZero(this.resetDuration) ? magnitude : (magnitude / this.resetDuration));
			float magnitude2 = (this.RingPosition - this.KnobPosition).magnitude;
			this.knobResetSpeed = (Utility.IsZero(this.resetDuration) ? this.knobRange : (magnitude2 / this.resetDuration));
			this.currentTouch = null;
			this.ring.State = false;
			this.knob.State = false;
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x06002C8D RID: 11405 RVA: 0x000F0982 File Offset: 0x000EEB82
		public bool IsActive
		{
			get
			{
				return this.currentTouch != null;
			}
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x06002C8E RID: 11406 RVA: 0x000F098D File Offset: 0x000EEB8D
		public bool IsNotActive
		{
			get
			{
				return this.currentTouch == null;
			}
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x06002C8F RID: 11407 RVA: 0x000F0998 File Offset: 0x000EEB98
		// (set) Token: 0x06002C90 RID: 11408 RVA: 0x000F09BE File Offset: 0x000EEBBE
		public Vector3 RingPosition
		{
			get
			{
				if (!this.ring.Ready)
				{
					return base.transform.position;
				}
				return this.ring.Position;
			}
			set
			{
				if (this.ring.Ready)
				{
					this.ring.Position = value;
				}
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x06002C91 RID: 11409 RVA: 0x000F09D9 File Offset: 0x000EEBD9
		// (set) Token: 0x06002C92 RID: 11410 RVA: 0x000F09FF File Offset: 0x000EEBFF
		public Vector3 KnobPosition
		{
			get
			{
				if (!this.knob.Ready)
				{
					return base.transform.position;
				}
				return this.knob.Position;
			}
			set
			{
				if (this.knob.Ready)
				{
					this.knob.Position = value;
				}
			}
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x06002C93 RID: 11411 RVA: 0x000F0A1A File Offset: 0x000EEC1A
		// (set) Token: 0x06002C94 RID: 11412 RVA: 0x000F0A22 File Offset: 0x000EEC22
		public TouchControlAnchor Anchor
		{
			get
			{
				return this.anchor;
			}
			set
			{
				if (this.anchor != value)
				{
					this.anchor = value;
					this.dirty = true;
				}
			}
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x06002C95 RID: 11413 RVA: 0x000F0A3B File Offset: 0x000EEC3B
		// (set) Token: 0x06002C96 RID: 11414 RVA: 0x000F0A43 File Offset: 0x000EEC43
		public Vector2 Offset
		{
			get
			{
				return this.offset;
			}
			set
			{
				if (this.offset != value)
				{
					this.offset = value;
					this.dirty = true;
				}
			}
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x06002C97 RID: 11415 RVA: 0x000F0A61 File Offset: 0x000EEC61
		// (set) Token: 0x06002C98 RID: 11416 RVA: 0x000F0A69 File Offset: 0x000EEC69
		public TouchUnitType OffsetUnitType
		{
			get
			{
				return this.offsetUnitType;
			}
			set
			{
				if (this.offsetUnitType != value)
				{
					this.offsetUnitType = value;
					this.dirty = true;
				}
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x06002C99 RID: 11417 RVA: 0x000F0A82 File Offset: 0x000EEC82
		// (set) Token: 0x06002C9A RID: 11418 RVA: 0x000F0A8A File Offset: 0x000EEC8A
		public Rect ActiveArea
		{
			get
			{
				return this.activeArea;
			}
			set
			{
				if (this.activeArea != value)
				{
					this.activeArea = value;
					this.dirty = true;
				}
			}
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x06002C9B RID: 11419 RVA: 0x000F0AA8 File Offset: 0x000EECA8
		// (set) Token: 0x06002C9C RID: 11420 RVA: 0x000F0AB0 File Offset: 0x000EECB0
		public TouchUnitType AreaUnitType
		{
			get
			{
				return this.areaUnitType;
			}
			set
			{
				if (this.areaUnitType != value)
				{
					this.areaUnitType = value;
					this.dirty = true;
				}
			}
		}

		// Token: 0x06002C9D RID: 11421 RVA: 0x000F0ACC File Offset: 0x000EECCC
		public TouchStickControl()
		{
			this.anchor = TouchControlAnchor.BottomLeft;
			this.offset = new Vector2(20f, 20f);
			this.activeArea = new Rect(0f, 0f, 50f, 100f);
			this.target = TouchControl.AnalogTarget.LeftStick;
			this.lowerDeadZone = 0.1f;
			this.upperDeadZone = 0.9f;
			this.inputCurve = AnimationCurve.Linear(0f, 0f, 1f, 1f);
			this.snapToInitialTouch = true;
			this.resetWhenDone = true;
			this.resetDuration = 0.1f;
			this.ring = new TouchSprite(20f);
			this.knob = new TouchSprite(10f);
			this.knobRange = 7.5f;
			base..ctor();
		}

		// Token: 0x040031E3 RID: 12771
		[Header("Position")]
		[SerializeField]
		private TouchControlAnchor anchor;

		// Token: 0x040031E4 RID: 12772
		[SerializeField]
		private TouchUnitType offsetUnitType;

		// Token: 0x040031E5 RID: 12773
		[SerializeField]
		private Vector2 offset;

		// Token: 0x040031E6 RID: 12774
		[SerializeField]
		private TouchUnitType areaUnitType;

		// Token: 0x040031E7 RID: 12775
		[SerializeField]
		private Rect activeArea;

		// Token: 0x040031E8 RID: 12776
		[Header("Options")]
		public TouchControl.AnalogTarget target;

		// Token: 0x040031E9 RID: 12777
		public TouchControl.SnapAngles snapAngles;

		// Token: 0x040031EA RID: 12778
		public LockAxis lockToAxis;

		// Token: 0x040031EB RID: 12779
		[Range(0f, 1f)]
		public float lowerDeadZone;

		// Token: 0x040031EC RID: 12780
		[Range(0f, 1f)]
		public float upperDeadZone;

		// Token: 0x040031ED RID: 12781
		public AnimationCurve inputCurve;

		// Token: 0x040031EE RID: 12782
		public bool allowDragging;

		// Token: 0x040031EF RID: 12783
		public DragAxis allowDraggingAxis;

		// Token: 0x040031F0 RID: 12784
		public bool snapToInitialTouch;

		// Token: 0x040031F1 RID: 12785
		public bool resetWhenDone;

		// Token: 0x040031F2 RID: 12786
		public float resetDuration;

		// Token: 0x040031F3 RID: 12787
		[Header("Sprites")]
		public TouchSprite ring;

		// Token: 0x040031F4 RID: 12788
		public TouchSprite knob;

		// Token: 0x040031F5 RID: 12789
		public float knobRange;

		// Token: 0x040031F6 RID: 12790
		private Vector3 resetPosition;

		// Token: 0x040031F7 RID: 12791
		private Vector3 beganPosition;

		// Token: 0x040031F8 RID: 12792
		private Vector3 movedPosition;

		// Token: 0x040031F9 RID: 12793
		private float ringResetSpeed;

		// Token: 0x040031FA RID: 12794
		private float knobResetSpeed;

		// Token: 0x040031FB RID: 12795
		private Rect worldActiveArea;

		// Token: 0x040031FC RID: 12796
		private float worldKnobRange;

		// Token: 0x040031FD RID: 12797
		private Vector3 value;

		// Token: 0x040031FE RID: 12798
		private Touch currentTouch;

		// Token: 0x040031FF RID: 12799
		private bool dirty;
	}
}
