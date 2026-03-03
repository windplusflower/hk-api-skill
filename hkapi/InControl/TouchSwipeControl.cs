using System;
using UnityEngine;

namespace InControl
{
	// Token: 0x0200070E RID: 1806
	public class TouchSwipeControl : TouchControl
	{
		// Token: 0x06002C9E RID: 11422 RVA: 0x00003603 File Offset: 0x00001803
		public override void CreateControl()
		{
		}

		// Token: 0x06002C9F RID: 11423 RVA: 0x000F0B9A File Offset: 0x000EED9A
		public override void DestroyControl()
		{
			if (this.currentTouch != null)
			{
				this.TouchEnded(this.currentTouch);
				this.currentTouch = null;
			}
		}

		// Token: 0x06002CA0 RID: 11424 RVA: 0x000F0BB7 File Offset: 0x000EEDB7
		public override void ConfigureControl()
		{
			this.worldActiveArea = TouchManager.ConvertToWorld(this.activeArea, this.areaUnitType);
		}

		// Token: 0x06002CA1 RID: 11425 RVA: 0x000F0BD0 File Offset: 0x000EEDD0
		public override void DrawGizmos()
		{
			Utility.DrawRectGizmo(this.worldActiveArea, Color.yellow);
		}

		// Token: 0x06002CA2 RID: 11426 RVA: 0x000F0BE2 File Offset: 0x000EEDE2
		private void Update()
		{
			if (this.dirty)
			{
				this.ConfigureControl();
				this.dirty = false;
			}
		}

		// Token: 0x06002CA3 RID: 11427 RVA: 0x000F0BFC File Offset: 0x000EEDFC
		public override void SubmitControlState(ulong updateTick, float deltaTime)
		{
			Vector3 v = TouchControl.SnapTo(this.currentVector, this.snapAngles);
			base.SubmitAnalogValue(this.target, v, 0f, 1f, updateTick, deltaTime);
			base.SubmitButtonState(this.upTarget, this.fireButtonTarget && this.nextButtonTarget == this.upTarget, updateTick, deltaTime);
			base.SubmitButtonState(this.downTarget, this.fireButtonTarget && this.nextButtonTarget == this.downTarget, updateTick, deltaTime);
			base.SubmitButtonState(this.leftTarget, this.fireButtonTarget && this.nextButtonTarget == this.leftTarget, updateTick, deltaTime);
			base.SubmitButtonState(this.rightTarget, this.fireButtonTarget && this.nextButtonTarget == this.rightTarget, updateTick, deltaTime);
			base.SubmitButtonState(this.tapTarget, this.fireButtonTarget && this.nextButtonTarget == this.tapTarget, updateTick, deltaTime);
			if (this.fireButtonTarget && this.nextButtonTarget != TouchControl.ButtonTarget.None)
			{
				this.fireButtonTarget = !this.oneSwipePerTouch;
				this.lastButtonTarget = this.nextButtonTarget;
				this.nextButtonTarget = TouchControl.ButtonTarget.None;
			}
		}

		// Token: 0x06002CA4 RID: 11428 RVA: 0x000F0D34 File Offset: 0x000EEF34
		public override void CommitControlState(ulong updateTick, float deltaTime)
		{
			base.CommitAnalog(this.target);
			base.CommitButton(this.upTarget);
			base.CommitButton(this.downTarget);
			base.CommitButton(this.leftTarget);
			base.CommitButton(this.rightTarget);
			base.CommitButton(this.tapTarget);
		}

		// Token: 0x06002CA5 RID: 11429 RVA: 0x000F0D8C File Offset: 0x000EEF8C
		public override void TouchBegan(Touch touch)
		{
			if (this.currentTouch != null)
			{
				return;
			}
			this.beganPosition = TouchManager.ScreenToWorldPoint(touch.position);
			if (this.worldActiveArea.Contains(this.beganPosition))
			{
				this.lastPosition = this.beganPosition;
				this.currentTouch = touch;
				this.currentVector = Vector2.zero;
				this.currentVectorIsSet = false;
				this.fireButtonTarget = true;
				this.nextButtonTarget = TouchControl.ButtonTarget.None;
				this.lastButtonTarget = TouchControl.ButtonTarget.None;
			}
		}

		// Token: 0x06002CA6 RID: 11430 RVA: 0x000F0E08 File Offset: 0x000EF008
		public override void TouchMoved(Touch touch)
		{
			if (this.currentTouch != touch)
			{
				return;
			}
			Vector3 a = TouchManager.ScreenToWorldPoint(touch.position);
			Vector3 vector = a - this.lastPosition;
			if (vector.magnitude >= this.sensitivity)
			{
				this.lastPosition = a;
				if (!this.oneSwipePerTouch || !this.currentVectorIsSet)
				{
					this.currentVector = vector.normalized;
					this.currentVectorIsSet = true;
				}
				if (this.fireButtonTarget)
				{
					TouchControl.ButtonTarget buttonTargetForVector = this.GetButtonTargetForVector(this.currentVector);
					if (buttonTargetForVector != this.lastButtonTarget)
					{
						this.nextButtonTarget = buttonTargetForVector;
					}
				}
			}
		}

		// Token: 0x06002CA7 RID: 11431 RVA: 0x000F0E9C File Offset: 0x000EF09C
		public override void TouchEnded(Touch touch)
		{
			if (this.currentTouch != touch)
			{
				return;
			}
			this.currentTouch = null;
			this.currentVector = Vector2.zero;
			this.currentVectorIsSet = false;
			Vector3 b = TouchManager.ScreenToWorldPoint(touch.position);
			if ((this.beganPosition - b).magnitude < this.sensitivity)
			{
				this.fireButtonTarget = true;
				this.nextButtonTarget = this.tapTarget;
				this.lastButtonTarget = TouchControl.ButtonTarget.None;
				return;
			}
			this.fireButtonTarget = false;
			this.nextButtonTarget = TouchControl.ButtonTarget.None;
			this.lastButtonTarget = TouchControl.ButtonTarget.None;
		}

		// Token: 0x06002CA8 RID: 11432 RVA: 0x000F0F2C File Offset: 0x000EF12C
		private TouchControl.ButtonTarget GetButtonTargetForVector(Vector2 vector)
		{
			Vector2 lhs = TouchControl.SnapTo(vector, TouchControl.SnapAngles.Four);
			if (lhs == Vector2.up)
			{
				return this.upTarget;
			}
			if (lhs == Vector2.right)
			{
				return this.rightTarget;
			}
			if (lhs == -Vector2.up)
			{
				return this.downTarget;
			}
			if (lhs == -Vector2.right)
			{
				return this.leftTarget;
			}
			return TouchControl.ButtonTarget.None;
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x06002CA9 RID: 11433 RVA: 0x000F0FA1 File Offset: 0x000EF1A1
		// (set) Token: 0x06002CAA RID: 11434 RVA: 0x000F0FA9 File Offset: 0x000EF1A9
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

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x06002CAB RID: 11435 RVA: 0x000F0FC7 File Offset: 0x000EF1C7
		// (set) Token: 0x06002CAC RID: 11436 RVA: 0x000F0FCF File Offset: 0x000EF1CF
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

		// Token: 0x06002CAD RID: 11437 RVA: 0x000F0FE8 File Offset: 0x000EF1E8
		public TouchSwipeControl()
		{
			this.activeArea = new Rect(25f, 25f, 50f, 50f);
			this.sensitivity = 0.1f;
			base..ctor();
		}

		// Token: 0x04003200 RID: 12800
		[Header("Position")]
		[SerializeField]
		private TouchUnitType areaUnitType;

		// Token: 0x04003201 RID: 12801
		[SerializeField]
		private Rect activeArea;

		// Token: 0x04003202 RID: 12802
		[Header("Options")]
		[Range(0f, 1f)]
		public float sensitivity;

		// Token: 0x04003203 RID: 12803
		public bool oneSwipePerTouch;

		// Token: 0x04003204 RID: 12804
		[Header("Analog Target")]
		public TouchControl.AnalogTarget target;

		// Token: 0x04003205 RID: 12805
		public TouchControl.SnapAngles snapAngles;

		// Token: 0x04003206 RID: 12806
		[Header("Button Targets")]
		public TouchControl.ButtonTarget upTarget;

		// Token: 0x04003207 RID: 12807
		public TouchControl.ButtonTarget downTarget;

		// Token: 0x04003208 RID: 12808
		public TouchControl.ButtonTarget leftTarget;

		// Token: 0x04003209 RID: 12809
		public TouchControl.ButtonTarget rightTarget;

		// Token: 0x0400320A RID: 12810
		public TouchControl.ButtonTarget tapTarget;

		// Token: 0x0400320B RID: 12811
		private Rect worldActiveArea;

		// Token: 0x0400320C RID: 12812
		private Vector3 currentVector;

		// Token: 0x0400320D RID: 12813
		private bool currentVectorIsSet;

		// Token: 0x0400320E RID: 12814
		private Vector3 beganPosition;

		// Token: 0x0400320F RID: 12815
		private Vector3 lastPosition;

		// Token: 0x04003210 RID: 12816
		private Touch currentTouch;

		// Token: 0x04003211 RID: 12817
		private bool fireButtonTarget;

		// Token: 0x04003212 RID: 12818
		private TouchControl.ButtonTarget nextButtonTarget;

		// Token: 0x04003213 RID: 12819
		private TouchControl.ButtonTarget lastButtonTarget;

		// Token: 0x04003214 RID: 12820
		private bool dirty;
	}
}
