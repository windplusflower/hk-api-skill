using System;
using GlobalEnums;
using UnityEngine;

// Token: 0x020000E1 RID: 225
public class CameraTarget : MonoBehaviour
{
	// Token: 0x060004AE RID: 1198 RVA: 0x000173C1 File Offset: 0x000155C1
	public void GameInit()
	{
		this.gm = GameManager.instance;
		if (this.cameraCtrl == null)
		{
			this.cameraCtrl = base.transform.parent.GetComponent<CameraController>();
		}
	}

	// Token: 0x060004AF RID: 1199 RVA: 0x000173F4 File Offset: 0x000155F4
	public void SceneInit()
	{
		if (this.gm == null)
		{
			this.gm = GameManager.instance;
		}
		if (this.gm.IsGameplayScene())
		{
			this.isGameplayScene = true;
			this.hero_ctrl = HeroController.instance;
			this.heroTransform = this.hero_ctrl.transform;
			this.mode = CameraTarget.TargetMode.FOLLOW_HERO;
			this.stickToHeroX = true;
			this.stickToHeroY = true;
			this.fallCatcher = 0f;
			this.xLockMin = 0f;
			this.xLockMax = this.cameraCtrl.xLimit;
			this.yLockMin = 0f;
			this.yLockMax = this.cameraCtrl.yLimit;
			return;
		}
		this.isGameplayScene = false;
		this.mode = CameraTarget.TargetMode.FREE;
	}

	// Token: 0x060004B0 RID: 1200 RVA: 0x000174B4 File Offset: 0x000156B4
	public void Update()
	{
		if (this.hero_ctrl == null || !this.isGameplayScene)
		{
			this.mode = CameraTarget.TargetMode.FREE;
			return;
		}
		if (this.isGameplayScene)
		{
			float num = base.transform.position.x;
			float num2 = base.transform.position.y;
			float z = base.transform.position.z;
			float x = this.heroTransform.position.x;
			float y = this.heroTransform.position.y;
			Vector3 position = this.heroTransform.position;
			if (this.mode == CameraTarget.TargetMode.FOLLOW_HERO)
			{
				this.SetDampTime();
				this.destination = this.heroTransform.position;
				if (!this.fallStick && this.fallCatcher <= 0f)
				{
					base.transform.position = new Vector3(Vector3.SmoothDamp(base.transform.position, new Vector3(this.destination.x, base.transform.position.y, z), ref this.velocityX, this.dampTimeX).x, Vector3.SmoothDamp(base.transform.position, new Vector3(base.transform.position.x, this.destination.y, z), ref this.velocityY, this.dampTimeY).y, z);
				}
				else
				{
					base.transform.position = new Vector3(Vector3.SmoothDamp(base.transform.position, new Vector3(this.destination.x, base.transform.position.y, z), ref this.velocityX, this.dampTimeX).x, base.transform.position.y, z);
				}
				num = base.transform.position.x;
				num2 = base.transform.position.y;
				z = base.transform.position.z;
				if ((this.heroPrevPosition.x < num && x > num) || (this.heroPrevPosition.x > num && x < num) || (num >= x - this.snapDistance && num <= x + this.snapDistance))
				{
					this.stickToHeroX = true;
				}
				if ((this.heroPrevPosition.y < num2 && y > num2) || (this.heroPrevPosition.y > num2 && y < num2) || (num2 >= y - this.snapDistance && num2 <= y + this.snapDistance))
				{
					this.stickToHeroY = true;
				}
				if (this.stickToHeroX)
				{
					base.transform.SetPositionX(x);
					num = x;
				}
				if (this.stickToHeroY)
				{
					base.transform.SetPositionY(y);
					num2 = y;
				}
			}
			if (this.mode == CameraTarget.TargetMode.LOCK_ZONE)
			{
				this.SetDampTime();
				this.destination = this.heroTransform.position;
				if (this.destination.x < this.xLockMin)
				{
					this.destination.x = this.xLockMin;
				}
				if (this.destination.x > this.xLockMax)
				{
					this.destination.x = this.xLockMax;
				}
				if (this.destination.y < this.yLockMin)
				{
					this.destination.y = this.yLockMin;
				}
				if (this.destination.y > this.yLockMax)
				{
					this.destination.y = this.yLockMax;
				}
				if (!this.fallStick && this.fallCatcher <= 0f)
				{
					base.transform.position = new Vector3(Vector3.SmoothDamp(base.transform.position, new Vector3(this.destination.x, num2, z), ref this.velocityX, this.dampTimeX).x, Vector3.SmoothDamp(base.transform.position, new Vector3(num, this.destination.y, z), ref this.velocityY, this.dampTimeY).y, z);
				}
				else
				{
					base.transform.position = new Vector3(Vector3.SmoothDamp(base.transform.position, new Vector3(this.destination.x, num2, z), ref this.velocityX, this.dampTimeX).x, num2, z);
				}
				num = base.transform.position.x;
				num2 = base.transform.position.y;
				z = base.transform.position.z;
				if ((this.heroPrevPosition.x < num && x > num) || (this.heroPrevPosition.x > num && x < num) || (num >= x - this.snapDistance && num <= x + this.snapDistance))
				{
					this.stickToHeroX = true;
				}
				if ((this.heroPrevPosition.y < num2 && y > num2) || (this.heroPrevPosition.y > num2 && y < num2) || (num2 >= y - this.snapDistance && num2 <= y + this.snapDistance))
				{
					this.stickToHeroY = true;
				}
				if (this.stickToHeroX)
				{
					bool flag = false;
					if (x >= this.xLockMin && x <= this.xLockMax)
					{
						flag = true;
					}
					if (x <= this.xLockMax && x >= num)
					{
						flag = true;
					}
					if (x >= this.xLockMin && x <= num)
					{
						flag = true;
					}
					if (flag)
					{
						base.transform.SetPositionX(x);
						num = x;
					}
				}
				if (this.stickToHeroY)
				{
					bool flag2 = false;
					if (y >= this.yLockMin && y <= this.yLockMax)
					{
						flag2 = true;
					}
					if (y <= this.yLockMax && y >= num2)
					{
						flag2 = true;
					}
					if (y >= this.yLockMin && y <= num2)
					{
						flag2 = true;
					}
					if (flag2)
					{
						base.transform.SetPositionY(y);
					}
				}
			}
			if (this.hero_ctrl != null)
			{
				if (this.hero_ctrl.cState.facingRight)
				{
					if (this.xOffset < this.xLookAhead)
					{
						this.xOffset += Time.deltaTime * 6f;
					}
				}
				else if (this.xOffset > -this.xLookAhead)
				{
					this.xOffset -= Time.deltaTime * 6f;
				}
				if (this.xOffset < -this.xLookAhead)
				{
					this.xOffset = -this.xLookAhead;
				}
				if (this.xOffset > this.xLookAhead)
				{
					this.xOffset = this.xLookAhead;
				}
				if (this.mode == CameraTarget.TargetMode.LOCK_ZONE)
				{
					if (x < this.xLockMin && this.hero_ctrl.cState.facingRight)
					{
						this.xOffset = x - num + 1f;
					}
					if (x > this.xLockMax && !this.hero_ctrl.cState.facingRight)
					{
						this.xOffset = x - num - 1f;
					}
					if (num + this.xOffset > this.xLockMax)
					{
						this.xOffset = this.xLockMax - num;
					}
					if (num + this.xOffset < this.xLockMin)
					{
						this.xOffset = this.xLockMin - num;
					}
				}
				if (this.xOffset < -this.xLookAhead)
				{
					this.xOffset = -this.xLookAhead;
				}
				if (this.xOffset > this.xLookAhead)
				{
					this.xOffset = this.xLookAhead;
				}
				if (this.hero_ctrl.cState.dashing && (this.hero_ctrl.current_velocity.x > 5f || this.hero_ctrl.current_velocity.x < -5f))
				{
					if (this.hero_ctrl.cState.facingRight)
					{
						this.dashOffset = this.dashLookAhead;
					}
					else
					{
						this.dashOffset = -this.dashLookAhead;
					}
					if (this.mode == CameraTarget.TargetMode.LOCK_ZONE)
					{
						if (num + this.dashOffset > this.xLockMax)
						{
							this.dashOffset = 0f;
						}
						if (num + this.dashOffset < this.xLockMin)
						{
							this.dashOffset = 0f;
						}
						if (x > this.xLockMax || x < this.xLockMin)
						{
							this.dashOffset = 0f;
						}
					}
				}
				else if (this.superDashing)
				{
					if (this.hero_ctrl.cState.facingRight)
					{
						this.dashOffset = this.superDashLookAhead;
					}
					else
					{
						this.dashOffset = -this.superDashLookAhead;
					}
					if (this.mode == CameraTarget.TargetMode.LOCK_ZONE)
					{
						if (num + this.dashOffset > this.xLockMax)
						{
							this.dashOffset = 0f;
						}
						if (num + this.dashOffset < this.xLockMin)
						{
							this.dashOffset = 0f;
						}
						if (x > this.xLockMax || x < this.xLockMin)
						{
							this.dashOffset = 0f;
						}
					}
				}
				else
				{
					this.dashOffset = 0f;
				}
				this.heroPrevPosition = this.heroTransform.position;
			}
			if (this.hero_ctrl != null && !this.hero_ctrl.cState.falling)
			{
				this.fallCatcher = 0f;
				this.fallStick = false;
			}
			if (this.mode == CameraTarget.TargetMode.FOLLOW_HERO || this.mode == CameraTarget.TargetMode.LOCK_ZONE)
			{
				if (this.hero_ctrl.cState.falling && this.cameraCtrl.transform.position.y > y + 0.1f && !this.fallStick && !this.hero_ctrl.cState.transitioning && (this.cameraCtrl.transform.position.y - 0.1f >= this.yLockMin || this.mode != CameraTarget.TargetMode.LOCK_ZONE))
				{
					this.cameraCtrl.transform.SetPositionY(this.cameraCtrl.transform.position.y - this.fallCatcher * Time.deltaTime);
					if (this.mode == CameraTarget.TargetMode.LOCK_ZONE && this.cameraCtrl.transform.position.y < this.yLockMin)
					{
						this.cameraCtrl.transform.SetPositionY(this.yLockMin);
					}
					if (this.cameraCtrl.transform.position.y < 8.3f)
					{
						this.cameraCtrl.transform.SetPositionY(8.3f);
					}
					if (this.fallCatcher < 25f)
					{
						this.fallCatcher += 80f * Time.deltaTime;
					}
					if (this.cameraCtrl.transform.position.y < this.heroTransform.position.y + 0.1f)
					{
						this.fallStick = true;
					}
					base.transform.SetPositionY(this.cameraCtrl.transform.position.y);
					num2 = this.cameraCtrl.transform.position.y;
				}
				if (this.fallStick)
				{
					this.fallCatcher = 0f;
					if (this.heroTransform.position.y + 0.1f >= this.yLockMin || this.mode != CameraTarget.TargetMode.LOCK_ZONE)
					{
						this.cameraCtrl.transform.SetPositionY(this.heroTransform.position.y + 0.1f);
						base.transform.SetPositionY(this.cameraCtrl.transform.position.y);
						num2 = this.cameraCtrl.transform.position.y;
					}
					if (this.mode == CameraTarget.TargetMode.LOCK_ZONE && this.cameraCtrl.transform.position.y < this.yLockMin)
					{
						this.cameraCtrl.transform.SetPositionY(this.yLockMin);
					}
					if (this.cameraCtrl.transform.position.y < 8.3f)
					{
						this.cameraCtrl.transform.SetPositionY(8.3f);
					}
				}
			}
			if (this.quaking)
			{
				num2 = this.heroTransform.position.y;
				if (this.mode == CameraTarget.TargetMode.LOCK_ZONE && num2 < this.yLockMin)
				{
					base.transform.SetPositionY(this.yLockMin);
					num2 = this.yLockMin;
				}
				base.transform.SetPositionY(num2);
			}
		}
	}

	// Token: 0x060004B1 RID: 1201 RVA: 0x000180B0 File Offset: 0x000162B0
	public void EnterLockZone(float xLockMin_var, float xLockMax_var, float yLockMin_var, float yLockMax_var)
	{
		this.xLockMin = xLockMin_var;
		this.xLockMax = xLockMax_var;
		this.yLockMin = yLockMin_var;
		this.yLockMax = yLockMax_var;
		this.mode = CameraTarget.TargetMode.LOCK_ZONE;
		float x = base.transform.position.x;
		float y = base.transform.position.y;
		Vector3 position = base.transform.position;
		float x2 = this.heroTransform.position.x;
		float y2 = this.heroTransform.position.y;
		Vector3 position2 = this.heroTransform.position;
		if ((!this.enteredLeft || this.xLockMin != 14.6f) && (!this.enteredRight || this.xLockMax != this.cameraCtrl.xLimit))
		{
			this.dampTimeX = this.dampTimeSlow;
		}
		if ((!this.enteredBot || this.yLockMin != 8.3f) && (!this.enteredTop || this.yLockMax != this.cameraCtrl.yLimit))
		{
			this.dampTimeY = this.dampTimeSlow;
		}
		this.slowTimer = this.slowTime;
		if (x >= x2 - this.snapDistance && x <= x2 + this.snapDistance)
		{
			this.stickToHeroX = true;
		}
		else
		{
			this.stickToHeroX = false;
		}
		if (y >= y2 - this.snapDistance && y <= y2 + this.snapDistance)
		{
			this.stickToHeroY = true;
			return;
		}
		this.stickToHeroY = false;
	}

	// Token: 0x060004B2 RID: 1202 RVA: 0x0001820C File Offset: 0x0001640C
	public void EnterLockZoneInstant(float xLockMin_var, float xLockMax_var, float yLockMin_var, float yLockMax_var)
	{
		this.xLockMin = xLockMin_var;
		this.xLockMax = xLockMax_var;
		this.yLockMin = yLockMin_var;
		this.yLockMax = yLockMax_var;
		this.mode = CameraTarget.TargetMode.LOCK_ZONE;
		if (base.transform.position.x < this.xLockMin)
		{
			base.transform.SetPositionX(this.xLockMin);
		}
		if (base.transform.position.x > this.xLockMax)
		{
			base.transform.SetPositionX(this.xLockMax);
		}
		if (base.transform.position.y < this.yLockMin)
		{
			base.transform.SetPositionY(this.yLockMin);
		}
		if (base.transform.position.y > this.yLockMax)
		{
			base.transform.SetPositionY(this.yLockMax);
		}
		this.stickToHeroX = true;
		this.stickToHeroY = true;
	}

	// Token: 0x060004B3 RID: 1203 RVA: 0x000182F0 File Offset: 0x000164F0
	public void ExitLockZone()
	{
		if (this.mode == CameraTarget.TargetMode.FREE)
		{
			return;
		}
		if (this.hero_ctrl.cState.hazardDeath || this.hero_ctrl.cState.dead || (this.hero_ctrl.transitionState != HeroTransitionState.WAITING_TO_TRANSITION && this.hero_ctrl.transitionState != HeroTransitionState.WAITING_TO_ENTER_LEVEL))
		{
			this.mode = CameraTarget.TargetMode.FREE;
		}
		else
		{
			this.mode = CameraTarget.TargetMode.FOLLOW_HERO;
		}
		if ((!this.exitedLeft || this.xLockMin != 14.6f) && (!this.exitedRight || this.xLockMax != this.cameraCtrl.xLimit))
		{
			this.dampTimeX = this.dampTimeSlow;
		}
		if ((!this.exitedBot || this.yLockMin != 8.3f) && (!this.exitedTop || this.yLockMax != this.cameraCtrl.yLimit))
		{
			this.dampTimeY = this.dampTimeSlow;
		}
		this.slowTimer = this.slowTime;
		this.stickToHeroX = false;
		this.stickToHeroY = false;
		this.fallStick = false;
		this.xLockMin = 0f;
		this.xLockMax = this.cameraCtrl.xLimit;
		this.yLockMin = 0f;
		this.yLockMax = this.cameraCtrl.yLimit;
		if (this.hero_ctrl != null)
		{
			if (base.transform.position.x >= this.heroTransform.position.x - this.snapDistance && base.transform.position.x <= this.heroTransform.position.x + this.snapDistance)
			{
				this.stickToHeroX = true;
			}
			else
			{
				this.stickToHeroX = false;
			}
			if (base.transform.position.y >= this.heroTransform.position.y - this.snapDistance && base.transform.position.y <= this.heroTransform.position.y + this.snapDistance)
			{
				this.stickToHeroY = true;
				return;
			}
			this.stickToHeroY = false;
		}
	}

	// Token: 0x060004B4 RID: 1204 RVA: 0x000184FC File Offset: 0x000166FC
	private void SetDampTime()
	{
		if (this.slowTimer > 0f)
		{
			this.slowTimer -= Time.deltaTime;
			return;
		}
		if (this.dampTimeX > this.dampTimeNormal)
		{
			this.dampTimeX -= 0.007f;
		}
		else if (this.dampTimeX < this.dampTimeNormal)
		{
			this.dampTimeX = this.dampTimeNormal;
		}
		if (this.dampTimeY > this.dampTimeNormal)
		{
			this.dampTimeY -= 0.007f;
			return;
		}
		if (this.dampTimeY < this.dampTimeNormal)
		{
			this.dampTimeY = this.dampTimeNormal;
		}
	}

	// Token: 0x060004B5 RID: 1205 RVA: 0x000185A0 File Offset: 0x000167A0
	public void SetSuperDash(bool active)
	{
		this.superDashing = active;
	}

	// Token: 0x060004B6 RID: 1206 RVA: 0x000185A9 File Offset: 0x000167A9
	public void SetQuake(bool quake)
	{
		this.quaking = quake;
	}

	// Token: 0x060004B7 RID: 1207 RVA: 0x000185B2 File Offset: 0x000167B2
	public void FreezeInPlace()
	{
		this.mode = CameraTarget.TargetMode.FREE;
	}

	// Token: 0x060004B8 RID: 1208 RVA: 0x000185BC File Offset: 0x000167BC
	public void PositionToStart()
	{
		float x = base.transform.position.x;
		Vector3 position = base.transform.position;
		float x2 = this.heroTransform.position.x;
		float y = this.heroTransform.position.y;
		this.velocityX = Vector3.zero;
		this.velocityY = Vector3.zero;
		this.destination = this.heroTransform.position;
		if (this.hero_ctrl.cState.facingRight)
		{
			this.xOffset = 1f;
		}
		else
		{
			this.xOffset = -1f;
		}
		if (this.mode == CameraTarget.TargetMode.LOCK_ZONE)
		{
			if (x2 < this.xLockMin && this.hero_ctrl.cState.facingRight)
			{
				this.xOffset = x2 - x + 1f;
			}
			if (x2 > this.xLockMax && !this.hero_ctrl.cState.facingRight)
			{
				this.xOffset = x2 - x - 1f;
			}
			if (x + this.xOffset > this.xLockMax)
			{
				this.xOffset = this.xLockMax - x;
			}
			if (x + this.xOffset < this.xLockMin)
			{
				this.xOffset = this.xLockMin - x;
			}
		}
		if (this.xOffset < -this.xLookAhead)
		{
			this.xOffset = -this.xLookAhead;
		}
		if (this.xOffset > this.xLookAhead)
		{
			this.xOffset = this.xLookAhead;
		}
		if (this.verboseMode)
		{
			Debug.LogFormat("CT PTS - xOffset: {0} HeroPos: {1}, {2}", new object[]
			{
				this.xOffset,
				x2,
				y
			});
		}
		if (this.mode == CameraTarget.TargetMode.FOLLOW_HERO)
		{
			if (this.verboseMode)
			{
				Debug.LogFormat("CT PTS - Follow Hero - CT Pos: {0}", new object[]
				{
					base.transform.position
				});
			}
			base.transform.position = this.cameraCtrl.KeepWithinSceneBounds(this.destination);
		}
		else if (this.mode == CameraTarget.TargetMode.LOCK_ZONE)
		{
			if (this.destination.x < this.xLockMin)
			{
				this.destination.x = this.xLockMin;
			}
			if (this.destination.x > this.xLockMax)
			{
				this.destination.x = this.xLockMax;
			}
			if (this.destination.y < this.yLockMin)
			{
				this.destination.y = this.yLockMin;
			}
			if (this.destination.y > this.yLockMax)
			{
				this.destination.y = this.yLockMax;
			}
			base.transform.position = this.destination;
			if (this.verboseMode)
			{
				Debug.LogFormat("CT PTS - Lock Zone - CT Pos: {0}", new object[]
				{
					base.transform.position
				});
			}
		}
		if (this.verboseMode)
		{
			Debug.LogFormat("CT - PTS: HeroPos: {0} Mode: {1} Dest: {2}", new object[]
			{
				this.heroTransform.position,
				this.mode,
				this.destination
			});
		}
		this.heroPrevPosition = this.heroTransform.position;
	}

	// Token: 0x060004B9 RID: 1209 RVA: 0x000188E7 File Offset: 0x00016AE7
	public CameraTarget()
	{
		this.slowTime = 0.5f;
		this.snapDistance = 0.15f;
		base..ctor();
	}

	// Token: 0x04000453 RID: 1107
	private bool verboseMode;

	// Token: 0x04000454 RID: 1108
	[HideInInspector]
	public GameManager gm;

	// Token: 0x04000455 RID: 1109
	[HideInInspector]
	public HeroController hero_ctrl;

	// Token: 0x04000456 RID: 1110
	private Transform heroTransform;

	// Token: 0x04000457 RID: 1111
	public CameraController cameraCtrl;

	// Token: 0x04000458 RID: 1112
	public CameraTarget.TargetMode mode;

	// Token: 0x04000459 RID: 1113
	public Vector3 destination;

	// Token: 0x0400045A RID: 1114
	private Vector3 velocityX;

	// Token: 0x0400045B RID: 1115
	private Vector3 velocityY;

	// Token: 0x0400045C RID: 1116
	public float xOffset;

	// Token: 0x0400045D RID: 1117
	public float dashOffset;

	// Token: 0x0400045E RID: 1118
	public float fallOffset;

	// Token: 0x0400045F RID: 1119
	public float fallOffset_multiplier;

	// Token: 0x04000460 RID: 1120
	public float xLockMin;

	// Token: 0x04000461 RID: 1121
	public float xLockMax;

	// Token: 0x04000462 RID: 1122
	public float yLockMin;

	// Token: 0x04000463 RID: 1123
	public float yLockMax;

	// Token: 0x04000464 RID: 1124
	public bool enteredLeft;

	// Token: 0x04000465 RID: 1125
	public bool enteredRight;

	// Token: 0x04000466 RID: 1126
	public bool enteredTop;

	// Token: 0x04000467 RID: 1127
	public bool enteredBot;

	// Token: 0x04000468 RID: 1128
	public bool exitedLeft;

	// Token: 0x04000469 RID: 1129
	public bool exitedRight;

	// Token: 0x0400046A RID: 1130
	public bool exitedTop;

	// Token: 0x0400046B RID: 1131
	public bool exitedBot;

	// Token: 0x0400046C RID: 1132
	public bool superDashing;

	// Token: 0x0400046D RID: 1133
	public bool quaking;

	// Token: 0x0400046E RID: 1134
	public float slowTime;

	// Token: 0x0400046F RID: 1135
	public float dampTimeNormal;

	// Token: 0x04000470 RID: 1136
	public float dampTimeSlow;

	// Token: 0x04000471 RID: 1137
	public float xLookAhead;

	// Token: 0x04000472 RID: 1138
	public float dashLookAhead;

	// Token: 0x04000473 RID: 1139
	public float superDashLookAhead;

	// Token: 0x04000474 RID: 1140
	private Vector3 heroPrevPosition;

	// Token: 0x04000475 RID: 1141
	private float dampTime;

	// Token: 0x04000476 RID: 1142
	private float dampTimeX;

	// Token: 0x04000477 RID: 1143
	private float dampTimeY;

	// Token: 0x04000478 RID: 1144
	private float slowTimer;

	// Token: 0x04000479 RID: 1145
	private float snapDistance;

	// Token: 0x0400047A RID: 1146
	public float fallCatcher;

	// Token: 0x0400047B RID: 1147
	public bool stickToHeroX;

	// Token: 0x0400047C RID: 1148
	public bool stickToHeroY;

	// Token: 0x0400047D RID: 1149
	public bool enteredFromLockZone;

	// Token: 0x0400047E RID: 1150
	private float prevTarget_y;

	// Token: 0x0400047F RID: 1151
	private float prevCam_y;

	// Token: 0x04000480 RID: 1152
	public bool fallStick;

	// Token: 0x04000481 RID: 1153
	private bool isGameplayScene;

	// Token: 0x020000E2 RID: 226
	public enum TargetMode
	{
		// Token: 0x04000483 RID: 1155
		FOLLOW_HERO,
		// Token: 0x04000484 RID: 1156
		LOCK_ZONE,
		// Token: 0x04000485 RID: 1157
		BOSS,
		// Token: 0x04000486 RID: 1158
		FREE
	}
}
