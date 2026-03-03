using System;
using UnityEngine;

namespace InControl
{
	// Token: 0x0200070A RID: 1802
	public class TouchButtonControl : TouchControl
	{
		// Token: 0x06002C6E RID: 11374 RVA: 0x000EFFEC File Offset: 0x000EE1EC
		public override void CreateControl()
		{
			this.button.Create("Button", base.transform, 1000);
		}

		// Token: 0x06002C6F RID: 11375 RVA: 0x000F0009 File Offset: 0x000EE209
		public override void DestroyControl()
		{
			this.button.Delete();
			if (this.currentTouch != null)
			{
				this.TouchEnded(this.currentTouch);
				this.currentTouch = null;
			}
		}

		// Token: 0x06002C70 RID: 11376 RVA: 0x000F0031 File Offset: 0x000EE231
		public override void ConfigureControl()
		{
			base.transform.position = base.OffsetToWorldPosition(this.anchor, this.offset, this.offsetUnitType, this.lockAspectRatio);
			this.button.Update(true);
		}

		// Token: 0x06002C71 RID: 11377 RVA: 0x000F0068 File Offset: 0x000EE268
		public override void DrawGizmos()
		{
			this.button.DrawGizmos(this.ButtonPosition, Color.yellow);
		}

		// Token: 0x06002C72 RID: 11378 RVA: 0x000F0080 File Offset: 0x000EE280
		private void Update()
		{
			if (this.dirty)
			{
				this.ConfigureControl();
				this.dirty = false;
				return;
			}
			this.button.Update();
		}

		// Token: 0x06002C73 RID: 11379 RVA: 0x000F00A4 File Offset: 0x000EE2A4
		public override void SubmitControlState(ulong updateTick, float deltaTime)
		{
			if (this.pressureSensitive)
			{
				float num = 0f;
				if (this.currentTouch == null)
				{
					if (this.allowSlideToggle)
					{
						int touchCount = TouchManager.TouchCount;
						for (int i = 0; i < touchCount; i++)
						{
							Touch touch = TouchManager.GetTouch(i);
							if (this.button.Contains(touch))
							{
								num = Utility.Max(num, touch.NormalizedPressure);
							}
						}
					}
				}
				else
				{
					num = this.currentTouch.NormalizedPressure;
				}
				this.ButtonState = (num > 0f);
				base.SubmitButtonValue(this.target, num, updateTick, deltaTime);
				return;
			}
			if (this.currentTouch == null && this.allowSlideToggle)
			{
				this.ButtonState = false;
				int touchCount2 = TouchManager.TouchCount;
				for (int j = 0; j < touchCount2; j++)
				{
					this.ButtonState = (this.ButtonState || this.button.Contains(TouchManager.GetTouch(j)));
				}
			}
			base.SubmitButtonState(this.target, this.ButtonState, updateTick, deltaTime);
		}

		// Token: 0x06002C74 RID: 11380 RVA: 0x000F0198 File Offset: 0x000EE398
		public override void CommitControlState(ulong updateTick, float deltaTime)
		{
			base.CommitButton(this.target);
		}

		// Token: 0x06002C75 RID: 11381 RVA: 0x000F01A6 File Offset: 0x000EE3A6
		public override void TouchBegan(Touch touch)
		{
			if (this.currentTouch != null)
			{
				return;
			}
			if (this.button.Contains(touch))
			{
				this.ButtonState = true;
				this.currentTouch = touch;
			}
		}

		// Token: 0x06002C76 RID: 11382 RVA: 0x000F01CD File Offset: 0x000EE3CD
		public override void TouchMoved(Touch touch)
		{
			if (this.currentTouch != touch)
			{
				return;
			}
			if (this.toggleOnLeave && !this.button.Contains(touch))
			{
				this.ButtonState = false;
				this.currentTouch = null;
			}
		}

		// Token: 0x06002C77 RID: 11383 RVA: 0x000F01FD File Offset: 0x000EE3FD
		public override void TouchEnded(Touch touch)
		{
			if (this.currentTouch != touch)
			{
				return;
			}
			this.ButtonState = false;
			this.currentTouch = null;
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06002C78 RID: 11384 RVA: 0x000F0217 File Offset: 0x000EE417
		// (set) Token: 0x06002C79 RID: 11385 RVA: 0x000F021F File Offset: 0x000EE41F
		private bool ButtonState
		{
			get
			{
				return this.buttonState;
			}
			set
			{
				if (this.buttonState != value)
				{
					this.buttonState = value;
					this.button.State = value;
				}
			}
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x06002C7A RID: 11386 RVA: 0x000F023D File Offset: 0x000EE43D
		// (set) Token: 0x06002C7B RID: 11387 RVA: 0x000F0263 File Offset: 0x000EE463
		public Vector3 ButtonPosition
		{
			get
			{
				if (!this.button.Ready)
				{
					return base.transform.position;
				}
				return this.button.Position;
			}
			set
			{
				if (this.button.Ready)
				{
					this.button.Position = value;
				}
			}
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x06002C7C RID: 11388 RVA: 0x000F027E File Offset: 0x000EE47E
		// (set) Token: 0x06002C7D RID: 11389 RVA: 0x000F0286 File Offset: 0x000EE486
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

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x06002C7E RID: 11390 RVA: 0x000F029F File Offset: 0x000EE49F
		// (set) Token: 0x06002C7F RID: 11391 RVA: 0x000F02A7 File Offset: 0x000EE4A7
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

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x06002C80 RID: 11392 RVA: 0x000F02C5 File Offset: 0x000EE4C5
		// (set) Token: 0x06002C81 RID: 11393 RVA: 0x000F02CD File Offset: 0x000EE4CD
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

		// Token: 0x06002C82 RID: 11394 RVA: 0x000F02E8 File Offset: 0x000EE4E8
		public TouchButtonControl()
		{
			this.anchor = TouchControlAnchor.BottomRight;
			this.offset = new Vector2(-10f, 10f);
			this.lockAspectRatio = true;
			this.target = TouchControl.ButtonTarget.Action1;
			this.allowSlideToggle = true;
			this.button = new TouchSprite(15f);
			base..ctor();
		}

		// Token: 0x040031CF RID: 12751
		[Header("Position")]
		[SerializeField]
		private TouchControlAnchor anchor;

		// Token: 0x040031D0 RID: 12752
		[SerializeField]
		private TouchUnitType offsetUnitType;

		// Token: 0x040031D1 RID: 12753
		[SerializeField]
		private Vector2 offset;

		// Token: 0x040031D2 RID: 12754
		[SerializeField]
		private bool lockAspectRatio;

		// Token: 0x040031D3 RID: 12755
		[Header("Options")]
		public TouchControl.ButtonTarget target;

		// Token: 0x040031D4 RID: 12756
		public bool allowSlideToggle;

		// Token: 0x040031D5 RID: 12757
		public bool toggleOnLeave;

		// Token: 0x040031D6 RID: 12758
		public bool pressureSensitive;

		// Token: 0x040031D7 RID: 12759
		[Header("Sprites")]
		public TouchSprite button;

		// Token: 0x040031D8 RID: 12760
		private bool buttonState;

		// Token: 0x040031D9 RID: 12761
		private Touch currentTouch;

		// Token: 0x040031DA RID: 12762
		private bool dirty;
	}
}
