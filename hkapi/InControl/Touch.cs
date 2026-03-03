using System;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000710 RID: 1808
	public class Touch
	{
		// Token: 0x06002CBE RID: 11454 RVA: 0x000F12DA File Offset: 0x000EF4DA
		internal Touch()
		{
			this.fingerId = -1;
			this.phase = TouchPhase.Ended;
		}

		// Token: 0x06002CBF RID: 11455 RVA: 0x000F12F0 File Offset: 0x000EF4F0
		internal void Reset()
		{
			this.fingerId = -1;
			this.mouseButton = 0;
			this.phase = TouchPhase.Ended;
			this.tapCount = 0;
			this.position = Vector2.zero;
			this.startPosition = Vector2.zero;
			this.deltaPosition = Vector2.zero;
			this.lastPosition = Vector2.zero;
			this.deltaTime = 0f;
			this.updateTick = 0UL;
			this.type = TouchType.Direct;
			this.altitudeAngle = 0f;
			this.azimuthAngle = 0f;
			this.maximumPossiblePressure = 1f;
			this.pressure = 0f;
			this.radius = 0f;
			this.radiusVariance = 0f;
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x06002CC0 RID: 11456 RVA: 0x000F13A1 File Offset: 0x000EF5A1
		[Obsolete("normalizedPressure is deprecated, please use NormalizedPressure instead.")]
		public float normalizedPressure
		{
			get
			{
				return Mathf.Clamp(this.pressure / this.maximumPossiblePressure, 0.001f, 1f);
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x06002CC1 RID: 11457 RVA: 0x000F13A1 File Offset: 0x000EF5A1
		public float NormalizedPressure
		{
			get
			{
				return Mathf.Clamp(this.pressure / this.maximumPossiblePressure, 0.001f, 1f);
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x06002CC2 RID: 11458 RVA: 0x000F13BF File Offset: 0x000EF5BF
		public bool IsMouse
		{
			get
			{
				return this.type == TouchType.Mouse;
			}
		}

		// Token: 0x06002CC3 RID: 11459 RVA: 0x000F13CC File Offset: 0x000EF5CC
		internal void SetWithTouchData(Touch touch, ulong updateTick, float deltaTime)
		{
			this.phase = touch.phase;
			this.tapCount = touch.tapCount;
			this.mouseButton = 0;
			this.altitudeAngle = touch.altitudeAngle;
			this.azimuthAngle = touch.azimuthAngle;
			this.maximumPossiblePressure = touch.maximumPossiblePressure;
			this.pressure = touch.pressure;
			this.radius = touch.radius;
			this.radiusVariance = touch.radiusVariance;
			Vector2 vector = touch.position;
			vector.x = Mathf.Clamp(vector.x, 0f, (float)Screen.width);
			vector.y = Mathf.Clamp(vector.y, 0f, (float)Screen.height);
			if (this.phase == TouchPhase.Began)
			{
				this.startPosition = vector;
				this.deltaPosition = Vector2.zero;
				this.lastPosition = vector;
				this.position = vector;
			}
			else
			{
				if (this.phase == TouchPhase.Stationary)
				{
					this.phase = TouchPhase.Moved;
				}
				this.deltaPosition = vector - this.lastPosition;
				this.lastPosition = this.position;
				this.position = vector;
			}
			this.deltaTime = deltaTime;
			this.updateTick = updateTick;
		}

		// Token: 0x06002CC4 RID: 11460 RVA: 0x000F14F8 File Offset: 0x000EF6F8
		internal bool SetWithMouseData(int button, ulong updateTick, float deltaTime)
		{
			if (Input.touchCount > 0)
			{
				return false;
			}
			if (button < 0 || button > 2)
			{
				return false;
			}
			Vector2 vector = InputManager.MouseProvider.GetPosition();
			Vector2 a = new Vector2(Mathf.Round(vector.x), Mathf.Round(vector.y));
			Mouse control = Mouse.LeftButton + button;
			if (InputManager.MouseProvider.GetButtonWasPressed(control))
			{
				this.phase = TouchPhase.Began;
				this.pressure = 1f;
				this.maximumPossiblePressure = 1f;
				this.tapCount = 1;
				this.type = TouchType.Mouse;
				this.mouseButton = button;
				this.startPosition = a;
				this.deltaPosition = Vector2.zero;
				this.lastPosition = a;
				this.position = a;
				this.deltaTime = deltaTime;
				this.updateTick = updateTick;
				return true;
			}
			if (InputManager.MouseProvider.GetButtonWasReleased(control))
			{
				this.phase = TouchPhase.Ended;
				this.pressure = 0f;
				this.maximumPossiblePressure = 1f;
				this.tapCount = 1;
				this.type = TouchType.Mouse;
				this.mouseButton = button;
				this.deltaPosition = a - this.lastPosition;
				this.lastPosition = this.position;
				this.position = a;
				this.deltaTime = deltaTime;
				this.updateTick = updateTick;
				return true;
			}
			if (InputManager.MouseProvider.GetButtonIsPressed(control))
			{
				this.phase = TouchPhase.Moved;
				this.pressure = 1f;
				this.maximumPossiblePressure = 1f;
				this.tapCount = 1;
				this.type = TouchType.Mouse;
				this.mouseButton = button;
				this.deltaPosition = a - this.lastPosition;
				this.lastPosition = this.position;
				this.position = a;
				this.deltaTime = deltaTime;
				this.updateTick = updateTick;
				return true;
			}
			return false;
		}

		// Token: 0x04003224 RID: 12836
		public const int FingerID_None = -1;

		// Token: 0x04003225 RID: 12837
		public const int FingerID_Mouse = -2;

		// Token: 0x04003226 RID: 12838
		public int fingerId;

		// Token: 0x04003227 RID: 12839
		public int mouseButton;

		// Token: 0x04003228 RID: 12840
		public TouchPhase phase;

		// Token: 0x04003229 RID: 12841
		public int tapCount;

		// Token: 0x0400322A RID: 12842
		public Vector2 position;

		// Token: 0x0400322B RID: 12843
		public Vector2 startPosition;

		// Token: 0x0400322C RID: 12844
		public Vector2 deltaPosition;

		// Token: 0x0400322D RID: 12845
		public Vector2 lastPosition;

		// Token: 0x0400322E RID: 12846
		public float deltaTime;

		// Token: 0x0400322F RID: 12847
		public ulong updateTick;

		// Token: 0x04003230 RID: 12848
		public TouchType type;

		// Token: 0x04003231 RID: 12849
		public float altitudeAngle;

		// Token: 0x04003232 RID: 12850
		public float azimuthAngle;

		// Token: 0x04003233 RID: 12851
		public float maximumPossiblePressure;

		// Token: 0x04003234 RID: 12852
		public float pressure;

		// Token: 0x04003235 RID: 12853
		public float radius;

		// Token: 0x04003236 RID: 12854
		public float radiusVariance;
	}
}
