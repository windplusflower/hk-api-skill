using System;
using UnityEngine;

namespace InControl
{
	// Token: 0x0200070F RID: 1807
	public class TouchTrackControl : TouchControl
	{
		// Token: 0x06002CAE RID: 11438 RVA: 0x000F101A File Offset: 0x000EF21A
		public override void CreateControl()
		{
			this.ConfigureControl();
		}

		// Token: 0x06002CAF RID: 11439 RVA: 0x000F1022 File Offset: 0x000EF222
		public override void DestroyControl()
		{
			if (this.currentTouch != null)
			{
				this.TouchEnded(this.currentTouch);
				this.currentTouch = null;
			}
		}

		// Token: 0x06002CB0 RID: 11440 RVA: 0x000F103F File Offset: 0x000EF23F
		public override void ConfigureControl()
		{
			this.worldActiveArea = TouchManager.ConvertToWorld(this.activeArea, this.areaUnitType);
		}

		// Token: 0x06002CB1 RID: 11441 RVA: 0x000F1058 File Offset: 0x000EF258
		public override void DrawGizmos()
		{
			Utility.DrawRectGizmo(this.worldActiveArea, Color.yellow);
		}

		// Token: 0x06002CB2 RID: 11442 RVA: 0x000F106A File Offset: 0x000EF26A
		private void OnValidate()
		{
			if (this.maxTapDuration < 0f)
			{
				this.maxTapDuration = 0f;
			}
		}

		// Token: 0x06002CB3 RID: 11443 RVA: 0x000F1084 File Offset: 0x000EF284
		private void Update()
		{
			if (this.dirty)
			{
				this.ConfigureControl();
				this.dirty = false;
			}
		}

		// Token: 0x06002CB4 RID: 11444 RVA: 0x000F109C File Offset: 0x000EF29C
		public override void SubmitControlState(ulong updateTick, float deltaTime)
		{
			Vector3 a = this.thisPosition - this.lastPosition;
			base.SubmitRawAnalogValue(this.target, a * this.scale, updateTick, deltaTime);
			this.lastPosition = this.thisPosition;
			base.SubmitButtonState(this.tapTarget, this.fireButtonTarget, updateTick, deltaTime);
			this.fireButtonTarget = false;
		}

		// Token: 0x06002CB5 RID: 11445 RVA: 0x000F1101 File Offset: 0x000EF301
		public override void CommitControlState(ulong updateTick, float deltaTime)
		{
			base.CommitAnalog(this.target);
			base.CommitButton(this.tapTarget);
		}

		// Token: 0x06002CB6 RID: 11446 RVA: 0x000F111C File Offset: 0x000EF31C
		public override void TouchBegan(Touch touch)
		{
			if (this.currentTouch != null)
			{
				return;
			}
			this.beganPosition = TouchManager.ScreenToWorldPoint(touch.position);
			if (this.worldActiveArea.Contains(this.beganPosition))
			{
				this.thisPosition = TouchManager.ScreenToViewPoint(touch.position * 100f);
				this.lastPosition = this.thisPosition;
				this.currentTouch = touch;
				this.beganTime = Time.realtimeSinceStartup;
			}
		}

		// Token: 0x06002CB7 RID: 11447 RVA: 0x000F118F File Offset: 0x000EF38F
		public override void TouchMoved(Touch touch)
		{
			if (this.currentTouch != touch)
			{
				return;
			}
			this.thisPosition = TouchManager.ScreenToViewPoint(touch.position * 100f);
		}

		// Token: 0x06002CB8 RID: 11448 RVA: 0x000F11B8 File Offset: 0x000EF3B8
		public override void TouchEnded(Touch touch)
		{
			if (this.currentTouch != touch)
			{
				return;
			}
			Vector3 vector = TouchManager.ScreenToWorldPoint(touch.position) - this.beganPosition;
			float num = Time.realtimeSinceStartup - this.beganTime;
			if (vector.magnitude <= this.maxTapMovement && num <= this.maxTapDuration && this.tapTarget != TouchControl.ButtonTarget.None)
			{
				this.fireButtonTarget = true;
			}
			this.thisPosition = Vector3.zero;
			this.lastPosition = Vector3.zero;
			this.currentTouch = null;
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x06002CB9 RID: 11449 RVA: 0x000F1237 File Offset: 0x000EF437
		// (set) Token: 0x06002CBA RID: 11450 RVA: 0x000F123F File Offset: 0x000EF43F
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

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x06002CBB RID: 11451 RVA: 0x000F125D File Offset: 0x000EF45D
		// (set) Token: 0x06002CBC RID: 11452 RVA: 0x000F1265 File Offset: 0x000EF465
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

		// Token: 0x06002CBD RID: 11453 RVA: 0x000F1280 File Offset: 0x000EF480
		public TouchTrackControl()
		{
			this.activeArea = new Rect(25f, 25f, 50f, 50f);
			this.target = TouchControl.AnalogTarget.LeftStick;
			this.scale = 1f;
			this.maxTapDuration = 0.5f;
			this.maxTapMovement = 1f;
			base..ctor();
		}

		// Token: 0x04003215 RID: 12821
		[Header("Dimensions")]
		[SerializeField]
		private TouchUnitType areaUnitType;

		// Token: 0x04003216 RID: 12822
		[SerializeField]
		private Rect activeArea;

		// Token: 0x04003217 RID: 12823
		[Header("Analog Target")]
		public TouchControl.AnalogTarget target;

		// Token: 0x04003218 RID: 12824
		public float scale;

		// Token: 0x04003219 RID: 12825
		[Header("Button Target")]
		public TouchControl.ButtonTarget tapTarget;

		// Token: 0x0400321A RID: 12826
		public float maxTapDuration;

		// Token: 0x0400321B RID: 12827
		public float maxTapMovement;

		// Token: 0x0400321C RID: 12828
		private Rect worldActiveArea;

		// Token: 0x0400321D RID: 12829
		private Vector3 lastPosition;

		// Token: 0x0400321E RID: 12830
		private Vector3 thisPosition;

		// Token: 0x0400321F RID: 12831
		private Touch currentTouch;

		// Token: 0x04003220 RID: 12832
		private bool dirty;

		// Token: 0x04003221 RID: 12833
		private bool fireButtonTarget;

		// Token: 0x04003222 RID: 12834
		private float beganTime;

		// Token: 0x04003223 RID: 12835
		private Vector3 beganPosition;
	}
}
