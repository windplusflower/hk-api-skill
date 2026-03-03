using System;
using System.Collections;
using System.Collections.Generic;
using GlobalEnums;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.ImageEffects;

// Token: 0x020000D5 RID: 213
public class CameraController : MonoBehaviour
{
	// Token: 0x06000458 RID: 1112 RVA: 0x00015004 File Offset: 0x00013204
	public void GameInit()
	{
		this.gm = GameManager.instance;
		this.cam = base.GetComponent<Camera>();
		this.cameraParent = base.transform.parent.transform;
		this.fadeFSM = FSMUtility.LocateFSM(base.gameObject, "CameraFade");
		this.ApplyEffectConfiguration(false, false);
		this.gm.UnloadingLevel += this.OnLevelUnload;
	}

	// Token: 0x06000459 RID: 1113 RVA: 0x00015074 File Offset: 0x00013274
	public void SceneInit()
	{
		this.startLockedTimer = 0.5f;
		this.velocity = Vector3.zero;
		bool isBloomForced = false;
		if (this.gm.IsGameplayScene())
		{
			this.isGameplayScene = true;
			if (this.hero_ctrl == null)
			{
				this.hero_ctrl = HeroController.instance;
				this.hero_ctrl.heroInPosition += this.PositionToHero;
			}
			this.lockZoneList = new List<CameraLockArea>();
			this.GetTilemapInfo();
			this.xLockMin = 0f;
			this.xLockMax = this.xLimit;
			this.yLockMin = 0f;
			this.yLockMax = this.yLimit;
			this.dampTimeX = this.dampTime;
			this.dampTimeY = this.dampTime;
			this.maxVelocityCurrent = this.maxVelocity;
			string currentMapZone = this.gm.GetCurrentMapZone();
			if (currentMapZone == MapZone.WHITE_PALACE.ToString() || currentMapZone == MapZone.GODS_GLORY.ToString())
			{
				isBloomForced = true;
			}
			string name = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;
			if (name != null && name.StartsWith("Dream_Guardian_"))
			{
				isBloomForced = true;
			}
		}
		else
		{
			this.isGameplayScene = false;
			if (this.gm.IsMenuScene())
			{
				isBloomForced = true;
			}
		}
		this.ApplyEffectConfiguration(this.isGameplayScene, isBloomForced);
	}

	// Token: 0x0600045A RID: 1114 RVA: 0x000151C8 File Offset: 0x000133C8
	public void ApplyEffectConfiguration(bool isGameplayLevel, bool isBloomForced)
	{
		bool flag = Platform.Current.GraphicsTier > Platform.GraphicsTiers.Low;
		base.GetComponent<FastNoise>().enabled = (isGameplayLevel && flag);
		base.GetComponent<BloomOptimized>().enabled = (flag || isBloomForced);
		base.GetComponent<BrightnessEffect>().enabled = flag;
		base.GetComponent<ColorCorrectionCurves>().enabled = true;
	}

	// Token: 0x0600045B RID: 1115 RVA: 0x00015218 File Offset: 0x00013418
	private void LateUpdate()
	{
		float x = base.transform.position.x;
		float y = base.transform.position.y;
		float z = base.transform.position.z;
		float x2 = this.cameraParent.position.x;
		float y2 = this.cameraParent.position.y;
		if (this.isGameplayScene && this.mode != CameraController.CameraMode.FROZEN)
		{
			if (this.hero_ctrl.cState.lookingUp)
			{
				this.lookOffset = this.hero_ctrl.transform.position.y - this.camTarget.transform.position.y + 6f;
			}
			else if (this.hero_ctrl.cState.lookingDown)
			{
				this.lookOffset = this.hero_ctrl.transform.position.y - this.camTarget.transform.position.y - 6f;
			}
			else
			{
				this.lookOffset = 0f;
			}
			this.UpdateTargetDestinationDelta();
			Vector3 vector = this.cam.WorldToViewportPoint(this.camTarget.transform.position);
			Vector3 vector2 = new Vector3(this.targetDeltaX, this.targetDeltaY, 0f) - this.cam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, vector.z));
			this.destination = new Vector3(x + vector2.x, y + vector2.y, z);
			if (this.mode == CameraController.CameraMode.LOCKED && this.currentLockArea != null)
			{
				if (this.lookOffset > 0f && this.currentLockArea.preventLookUp && this.destination.y > this.currentLockArea.cameraYMax)
				{
					if (base.transform.position.y > this.currentLockArea.cameraYMax)
					{
						this.destination = new Vector3(this.destination.x, this.destination.y - this.lookOffset, this.destination.z);
					}
					else
					{
						this.destination = new Vector3(this.destination.x, this.currentLockArea.cameraYMax, this.destination.z);
					}
				}
				if (this.lookOffset < 0f && this.currentLockArea.preventLookDown && this.destination.y < this.currentLockArea.cameraYMin)
				{
					if (base.transform.position.y < this.currentLockArea.cameraYMin)
					{
						this.destination = new Vector3(this.destination.x, this.destination.y - this.lookOffset, this.destination.z);
					}
					else
					{
						this.destination = new Vector3(this.destination.x, this.currentLockArea.cameraYMin, this.destination.z);
					}
				}
			}
			if (this.mode == CameraController.CameraMode.FOLLOWING || this.mode == CameraController.CameraMode.LOCKED)
			{
				this.destination = this.KeepWithinSceneBounds(this.destination);
			}
			Vector3 vector3 = Vector3.SmoothDamp(base.transform.position, new Vector3(this.destination.x, y, z), ref this.velocityX, this.dampTimeX);
			Vector3 vector4 = Vector3.SmoothDamp(base.transform.position, new Vector3(x, this.destination.y, z), ref this.velocityY, this.dampTimeY);
			base.transform.SetPosition2D(vector3.x, vector4.y);
			x = base.transform.position.x;
			y = base.transform.position.y;
			if (this.velocity.magnitude > this.maxVelocityCurrent)
			{
				this.velocity = this.velocity.normalized * this.maxVelocityCurrent;
			}
		}
		if (this.isGameplayScene)
		{
			if (x + x2 < 14.6f)
			{
				base.transform.SetPositionX(14.6f);
			}
			if (base.transform.position.x + x2 > this.xLimit)
			{
				base.transform.SetPositionX(this.xLimit);
			}
			if (base.transform.position.y + y2 < 8.3f)
			{
				base.transform.SetPositionY(8.3f);
			}
			if (base.transform.position.y + y2 > this.yLimit)
			{
				base.transform.SetPositionY(this.yLimit);
			}
			if (this.startLockedTimer > 0f)
			{
				this.startLockedTimer -= Time.deltaTime;
			}
		}
	}

	// Token: 0x0600045C RID: 1116 RVA: 0x000156F3 File Offset: 0x000138F3
	private void OnDisable()
	{
		if (this.hero_ctrl != null)
		{
			this.hero_ctrl.heroInPosition -= this.PositionToHero;
		}
	}

	// Token: 0x0600045D RID: 1117 RVA: 0x0001571A File Offset: 0x0001391A
	public void FreezeInPlace(bool freezeTargetAlso = false)
	{
		this.SetMode(CameraController.CameraMode.FROZEN);
		if (freezeTargetAlso)
		{
			this.camTarget.FreezeInPlace();
		}
	}

	// Token: 0x0600045E RID: 1118 RVA: 0x00015734 File Offset: 0x00013934
	public void FadeOut(CameraFadeType type)
	{
		this.SetMode(CameraController.CameraMode.FROZEN);
		if (type == CameraFadeType.LEVEL_TRANSITION)
		{
			this.fadeFSM.Fsm.Event("FADE OUT");
			return;
		}
		if (type == CameraFadeType.HERO_DEATH)
		{
			this.fadeFSM.Fsm.Event("RESPAWN FADE");
			return;
		}
		if (type == CameraFadeType.HERO_HAZARD_DEATH)
		{
			this.fadeFSM.Fsm.Event("HAZARD FADE");
			return;
		}
		if (type == CameraFadeType.JUST_FADE)
		{
			this.fadeFSM.Fsm.Event("JUST FADE");
			return;
		}
		if (type == CameraFadeType.START_FADE)
		{
			this.fadeFSM.Fsm.Event("START FADE");
		}
	}

	// Token: 0x0600045F RID: 1119 RVA: 0x000157C8 File Offset: 0x000139C8
	public void FadeSceneIn()
	{
		GameCameras.instance.cameraFadeFSM.Fsm.Event("FADE SCENE IN");
	}

	// Token: 0x06000460 RID: 1120 RVA: 0x000157E4 File Offset: 0x000139E4
	public void LockToArea(CameraLockArea lockArea)
	{
		if (!this.lockZoneList.Contains(lockArea))
		{
			if (this.verboseMode)
			{
				Debug.LogFormat("LockZone Activated: {0} at startLockedTimer {1} ({2}s)", new object[]
				{
					lockArea.name,
					this.startLockedTimer,
					Time.timeSinceLevelLoad
				});
			}
			this.lockZoneList.Add(lockArea);
			if (this.currentLockArea != null && this.currentLockArea.maxPriority && !lockArea.maxPriority)
			{
				return;
			}
			this.currentLockArea = lockArea;
			this.SetMode(CameraController.CameraMode.LOCKED);
			if (lockArea.cameraXMin < 0f)
			{
				this.xLockMin = 14.6f;
			}
			else
			{
				this.xLockMin = lockArea.cameraXMin;
			}
			if (lockArea.cameraXMax < 0f)
			{
				this.xLockMax = this.xLimit;
			}
			else
			{
				this.xLockMax = lockArea.cameraXMax;
			}
			if (lockArea.cameraYMin < 0f)
			{
				this.yLockMin = 8.3f;
			}
			else
			{
				this.yLockMin = lockArea.cameraYMin;
			}
			if (lockArea.cameraYMax < 0f)
			{
				this.yLockMax = this.yLimit;
			}
			else
			{
				this.yLockMax = lockArea.cameraYMax;
			}
			if (this.startLockedTimer > 0f)
			{
				this.camTarget.transform.SetPosition2D(this.KeepWithinLockBounds(this.hero_ctrl.transform.position));
				this.camTarget.destination = this.camTarget.transform.position;
				this.camTarget.EnterLockZoneInstant(this.xLockMin, this.xLockMax, this.yLockMin, this.yLockMax);
				base.transform.SetPosition2D(this.KeepWithinLockBounds(this.hero_ctrl.transform.position));
				this.destination = base.transform.position;
				return;
			}
			this.camTarget.EnterLockZone(this.xLockMin, this.xLockMax, this.yLockMin, this.yLockMax);
		}
	}

	// Token: 0x06000461 RID: 1121 RVA: 0x000159EC File Offset: 0x00013BEC
	public void ReleaseLock(CameraLockArea lockarea)
	{
		this.lockZoneList.Remove(lockarea);
		if (this.verboseMode)
		{
			Debug.Log("LockZone Released " + lockarea.name);
		}
		if (lockarea == this.currentLockArea)
		{
			if (this.lockZoneList.Count > 0)
			{
				this.currentLockArea = this.lockZoneList[this.lockZoneList.Count - 1];
				this.xLockMin = this.currentLockArea.cameraXMin;
				this.xLockMax = this.currentLockArea.cameraXMax;
				this.yLockMin = this.currentLockArea.cameraYMin;
				this.yLockMax = this.currentLockArea.cameraYMax;
				this.camTarget.enteredFromLockZone = true;
				this.camTarget.EnterLockZone(this.xLockMin, this.xLockMax, this.yLockMin, this.yLockMax);
				return;
			}
			this.lastLockPosition = base.transform.position;
			if (this.camTarget != null)
			{
				this.camTarget.enteredFromLockZone = false;
				this.camTarget.ExitLockZone();
			}
			this.currentLockArea = null;
			if (!this.hero_ctrl.cState.hazardDeath && !this.hero_ctrl.cState.dead && this.gm.gameState != GameState.EXITING_LEVEL)
			{
				this.SetMode(CameraController.CameraMode.FOLLOWING);
				return;
			}
		}
		else if (this.verboseMode)
		{
			Debug.Log("LockZone was not the current lock when removed.");
		}
	}

	// Token: 0x06000462 RID: 1122 RVA: 0x00015B65 File Offset: 0x00013D65
	public void ResetStartTimer()
	{
		this.startLockedTimer = 0.5f;
	}

	// Token: 0x06000463 RID: 1123 RVA: 0x00015B74 File Offset: 0x00013D74
	public void SnapTo(float x, float y)
	{
		this.camTarget.transform.position = new Vector3(x, y, this.camTarget.transform.position.z);
		base.transform.position = new Vector3(x, y, base.transform.position.z);
	}

	// Token: 0x06000464 RID: 1124 RVA: 0x00015BD0 File Offset: 0x00013DD0
	private void UpdateTargetDestinationDelta()
	{
		this.targetDeltaX = this.camTarget.transform.position.x + this.camTarget.xOffset + this.camTarget.dashOffset;
		this.targetDeltaY = this.camTarget.transform.position.y + this.camTarget.fallOffset + this.lookOffset;
	}

	// Token: 0x06000465 RID: 1125 RVA: 0x00015C3E File Offset: 0x00013E3E
	public void SetMode(CameraController.CameraMode newMode)
	{
		if (newMode != this.mode)
		{
			if (newMode == CameraController.CameraMode.PREVIOUS)
			{
				this.mode = this.prevMode;
				return;
			}
			this.prevMode = this.mode;
			this.mode = newMode;
		}
	}

	// Token: 0x06000466 RID: 1126 RVA: 0x00015C70 File Offset: 0x00013E70
	public Vector3 KeepWithinSceneBounds(Vector3 targetDest)
	{
		Vector3 vector = targetDest;
		bool flag = false;
		bool flag2 = false;
		if (vector.x < 14.6f)
		{
			vector = new Vector3(14.6f, vector.y, vector.z);
			flag = true;
			flag2 = true;
		}
		if (vector.x > this.xLimit)
		{
			vector = new Vector3(this.xLimit, vector.y, vector.z);
			flag = true;
			flag2 = true;
		}
		if (vector.y < 8.3f)
		{
			vector = new Vector3(vector.x, 8.3f, vector.z);
			flag = true;
		}
		if (vector.y > this.yLimit)
		{
			vector = new Vector3(vector.x, this.yLimit, vector.z);
			flag = true;
		}
		this.atSceneBounds = flag;
		this.atHorizontalSceneBounds = flag2;
		return vector;
	}

	// Token: 0x06000467 RID: 1127 RVA: 0x00015D38 File Offset: 0x00013F38
	private Vector2 KeepWithinSceneBounds(Vector2 targetDest)
	{
		bool flag = false;
		if (targetDest.x < 14.6f)
		{
			targetDest = new Vector2(14.6f, targetDest.y);
			flag = true;
		}
		if (targetDest.x > this.xLimit)
		{
			targetDest = new Vector2(this.xLimit, targetDest.y);
			flag = true;
		}
		if (targetDest.y < 8.3f)
		{
			targetDest = new Vector2(targetDest.x, 8.3f);
			flag = true;
		}
		if (targetDest.y > this.yLimit)
		{
			targetDest = new Vector2(targetDest.x, this.yLimit);
			flag = true;
		}
		this.atSceneBounds = flag;
		return targetDest;
	}

	// Token: 0x06000468 RID: 1128 RVA: 0x00015DD8 File Offset: 0x00013FD8
	private bool IsAtSceneBounds(Vector2 targetDest)
	{
		bool result = false;
		if (targetDest.x <= 14.6f)
		{
			result = true;
		}
		if (targetDest.x >= this.xLimit)
		{
			result = true;
		}
		if (targetDest.y <= 8.3f)
		{
			result = true;
		}
		if (targetDest.y >= this.yLimit)
		{
			result = true;
		}
		return result;
	}

	// Token: 0x06000469 RID: 1129 RVA: 0x00015E28 File Offset: 0x00014028
	private bool IsAtHorizontalSceneBounds(Vector2 targetDest, out bool leftSide)
	{
		bool result = false;
		leftSide = false;
		if (targetDest.x <= 14.6f)
		{
			result = true;
			leftSide = true;
		}
		if (targetDest.x >= this.xLimit)
		{
			result = true;
			leftSide = false;
		}
		return result;
	}

	// Token: 0x0600046A RID: 1130 RVA: 0x00015E60 File Offset: 0x00014060
	private bool IsTouchingSides(float x)
	{
		bool result = false;
		if (x <= 14.6f)
		{
			result = true;
		}
		if (x >= this.xLimit)
		{
			result = true;
		}
		return result;
	}

	// Token: 0x0600046B RID: 1131 RVA: 0x00015E88 File Offset: 0x00014088
	public Vector2 KeepWithinLockBounds(Vector2 targetDest)
	{
		float x = targetDest.x;
		float y = targetDest.y;
		if (x < this.xLockMin)
		{
			x = this.xLockMin;
		}
		if (x > this.xLockMax)
		{
			x = this.xLockMax;
		}
		if (y < this.yLockMin)
		{
			y = this.yLockMin;
		}
		if (y > this.yLockMax)
		{
			y = this.yLockMax;
		}
		return new Vector2(x, y);
	}

	// Token: 0x0600046C RID: 1132 RVA: 0x00015EEC File Offset: 0x000140EC
	private void GetTilemapInfo()
	{
		this.tilemap = this.gm.tilemap;
		this.sceneWidth = (float)this.tilemap.width;
		this.sceneHeight = (float)this.tilemap.height;
		this.xLimit = this.sceneWidth - 14.6f;
		this.yLimit = this.sceneHeight - 8.3f;
	}

	// Token: 0x0600046D RID: 1133 RVA: 0x00015F52 File Offset: 0x00014152
	public void PositionToHero(bool forceDirect)
	{
		base.StartCoroutine(this.DoPositionToHero(forceDirect));
	}

	// Token: 0x0600046E RID: 1134 RVA: 0x00015F62 File Offset: 0x00014162
	private IEnumerator DoPositionToHero(bool forceDirect)
	{
		yield return new WaitForFixedUpdate();
		this.GetTilemapInfo();
		this.camTarget.PositionToStart();
		this.UpdateTargetDestinationDelta();
		CameraController.CameraMode previousMode = this.mode;
		this.SetMode(CameraController.CameraMode.FROZEN);
		this.teleporting = true;
		Vector3 newPosition = this.KeepWithinSceneBounds(this.camTarget.transform.position);
		if (this.verboseMode)
		{
			Debug.LogFormat("CC - STR: NewPosition: {0} TargetDelta: ({1}, {2}) CT-XOffset: {3} HeroPos: {4} CT-Pos: {5}", new object[]
			{
				newPosition,
				this.targetDeltaX,
				this.targetDeltaY,
				this.camTarget.xOffset,
				this.hero_ctrl.transform.position,
				this.camTarget.transform.position
			});
		}
		if (forceDirect)
		{
			if (this.verboseMode)
			{
				Debug.Log("====> TEST 1a - ForceDirect Positioning Mode");
			}
			this.transform.SetPosition2D(newPosition);
		}
		else
		{
			if (this.verboseMode)
			{
				Debug.Log("====> TEST 1b - Normal Positioning Mode");
			}
			bool flag2;
			bool flag = this.IsAtHorizontalSceneBounds(newPosition, out flag2);
			bool flag3 = false;
			if (this.currentLockArea != null)
			{
				flag3 = true;
			}
			if (flag3)
			{
				if (this.verboseMode)
				{
					Debug.Log("====> TEST 3 - Lock Zone Active");
				}
				this.PositionToHeroFacing(newPosition, true);
				this.transform.SetPosition2D(this.KeepWithinLockBounds(this.transform.position));
			}
			else
			{
				if (this.verboseMode)
				{
					Debug.Log("====> TEST 4 - No Lock Zone");
				}
				this.PositionToHeroFacing(newPosition, false);
			}
			if (flag)
			{
				if (this.verboseMode)
				{
					Debug.Log("====> TEST 2 - At Horizontal Scene Bounds");
				}
				if ((flag2 && !this.hero_ctrl.cState.facingRight) || (!flag2 && this.hero_ctrl.cState.facingRight))
				{
					if (this.verboseMode)
					{
						Debug.Log("====> TEST 2a - Hero Facing Bounds");
					}
					this.transform.SetPosition2D(newPosition);
				}
				else
				{
					if (this.verboseMode)
					{
						Debug.Log("====> TEST 2b - Hero Facing Inwards");
					}
					if (this.IsTouchingSides(this.targetDeltaX))
					{
						if (this.verboseMode)
						{
							Debug.Log("Xoffset still touching sides");
						}
						this.transform.SetPosition2D(newPosition);
					}
					else
					{
						if (this.verboseMode)
						{
							Debug.LogFormat("Not Touching Sides with Xoffset CT: {0} Hero: {1}", new object[]
							{
								this.camTarget.transform.position,
								this.hero_ctrl.transform.position
							});
						}
						if (this.hero_ctrl.cState.facingRight)
						{
							this.transform.SetPosition2D(this.hero_ctrl.transform.position.x + 1f, newPosition.y);
						}
						else
						{
							this.transform.SetPosition2D(this.hero_ctrl.transform.position.x - 1f, newPosition.y);
						}
					}
				}
			}
		}
		this.destination = this.transform.position;
		this.velocity = Vector3.zero;
		this.velocityX = Vector3.zero;
		this.velocityY = Vector3.zero;
		yield return new WaitForSeconds(0.1f);
		GameCameras.instance.cameraFadeFSM.Fsm.Event("LEVEL LOADED");
		this.teleporting = false;
		if (previousMode == CameraController.CameraMode.FROZEN)
		{
			this.SetMode(CameraController.CameraMode.FOLLOWING);
		}
		else if (previousMode == CameraController.CameraMode.LOCKED)
		{
			if (this.currentLockArea != null)
			{
				this.SetMode(previousMode);
			}
			else
			{
				this.SetMode(CameraController.CameraMode.FOLLOWING);
			}
		}
		else
		{
			this.SetMode(previousMode);
		}
		if (this.verboseMode)
		{
			Debug.LogFormat("CC - PositionToHero FIN: - TargetDelta: ({0}, {1}) Destination: {2} CT-XOffset: {3} NewPosition: {4} CamTargetPos: {5} HeroPos: {6}", new object[]
			{
				this.targetDeltaX,
				this.targetDeltaY,
				this.destination,
				this.camTarget.xOffset,
				newPosition,
				this.camTarget.transform.position,
				this.hero_ctrl.transform.position
			});
		}
		yield break;
	}

	// Token: 0x0600046F RID: 1135 RVA: 0x00015F78 File Offset: 0x00014178
	private void PositionToHeroFacing()
	{
		if (this.hero_ctrl.cState.facingRight)
		{
			base.transform.SetPosition2D(this.camTarget.transform.position.x + 1f, this.camTarget.transform.position.y);
			return;
		}
		base.transform.SetPosition2D(this.camTarget.transform.position.x - 1f, this.camTarget.transform.position.y);
	}

	// Token: 0x06000470 RID: 1136 RVA: 0x00016010 File Offset: 0x00014210
	private void PositionToHeroFacing(Vector2 newPosition, bool useXOffset)
	{
		if (useXOffset)
		{
			base.transform.SetPosition2D(newPosition.x + this.camTarget.xOffset, newPosition.y);
			return;
		}
		if (this.hero_ctrl.cState.facingRight)
		{
			base.transform.SetPosition2D(newPosition.x + 1f, newPosition.y);
			return;
		}
		base.transform.SetPosition2D(newPosition.x - 1f, newPosition.y);
	}

	// Token: 0x06000471 RID: 1137 RVA: 0x00016094 File Offset: 0x00014294
	private Vector2 GetPositionToHeroFacing(Vector2 newPosition, bool useXOffset)
	{
		if (useXOffset)
		{
			return new Vector2(newPosition.x + this.camTarget.xOffset, newPosition.y);
		}
		if (this.hero_ctrl.cState.facingRight)
		{
			return new Vector2(newPosition.x + 1f, newPosition.y);
		}
		return new Vector2(newPosition.x - 1f, newPosition.y);
	}

	// Token: 0x06000472 RID: 1138 RVA: 0x00016103 File Offset: 0x00014303
	private IEnumerator FadeInFailSafe()
	{
		yield return new WaitForSeconds(5f);
		if (this.fadeFSM.ActiveStateName != "Normal" && this.fadeFSM.ActiveStateName != "FadingOut")
		{
			Debug.LogFormat("Failsafe fade in activated. State: {0} Scene: {1}", new object[]
			{
				this.fadeFSM.ActiveStateName,
				this.gm.sceneName
			});
			this.fadeFSM.Fsm.Event("FADE SCENE IN");
		}
		yield break;
	}

	// Token: 0x06000473 RID: 1139 RVA: 0x00016112 File Offset: 0x00014312
	private void StopFailSafe()
	{
		if (this.fadeInFailSafeCo != null)
		{
			base.StopCoroutine(this.fadeInFailSafeCo);
		}
	}

	// Token: 0x06000474 RID: 1140 RVA: 0x00016128 File Offset: 0x00014328
	private void OnLevelUnload()
	{
		if (this.verboseMode)
		{
			Debug.Log("Removing cam locks. (" + this.lockZoneList.Count.ToString() + " total)");
		}
		while (this.lockZoneList.Count > 0)
		{
			this.ReleaseLock(this.lockZoneList[0]);
		}
	}

	// Token: 0x06000475 RID: 1141 RVA: 0x00016186 File Offset: 0x00014386
	private void OnDestroy()
	{
		if (this.gm != null)
		{
			this.gm.UnloadingLevel -= this.OnLevelUnload;
		}
	}

	// Token: 0x040003DD RID: 989
	private bool verboseMode;

	// Token: 0x040003DE RID: 990
	public CameraController.CameraMode mode;

	// Token: 0x040003DF RID: 991
	private CameraController.CameraMode prevMode;

	// Token: 0x040003E0 RID: 992
	public bool atSceneBounds;

	// Token: 0x040003E1 RID: 993
	public bool atHorizontalSceneBounds;

	// Token: 0x040003E2 RID: 994
	private bool isGameplayScene;

	// Token: 0x040003E3 RID: 995
	private bool teleporting;

	// Token: 0x040003E4 RID: 996
	public Vector3 lastFramePosition;

	// Token: 0x040003E5 RID: 997
	public Vector2 lastLockPosition;

	// Token: 0x040003E6 RID: 998
	private Coroutine fadeInFailSafeCo;

	// Token: 0x040003E7 RID: 999
	[Header("Inspector Variables")]
	public float dampTime;

	// Token: 0x040003E8 RID: 1000
	public float dampTimeX;

	// Token: 0x040003E9 RID: 1001
	public float dampTimeY;

	// Token: 0x040003EA RID: 1002
	public float dampTimeFalling;

	// Token: 0x040003EB RID: 1003
	public float heroBotYLimit;

	// Token: 0x040003EC RID: 1004
	private float panTime;

	// Token: 0x040003ED RID: 1005
	private float currentPanTime;

	// Token: 0x040003EE RID: 1006
	private Vector3 velocity;

	// Token: 0x040003EF RID: 1007
	private Vector3 velocityX;

	// Token: 0x040003F0 RID: 1008
	private Vector3 velocityY;

	// Token: 0x040003F1 RID: 1009
	public float fallOffset;

	// Token: 0x040003F2 RID: 1010
	public float fallOffset_multiplier;

	// Token: 0x040003F3 RID: 1011
	public Vector3 destination;

	// Token: 0x040003F4 RID: 1012
	public float maxVelocity;

	// Token: 0x040003F5 RID: 1013
	public float maxVelocityFalling;

	// Token: 0x040003F6 RID: 1014
	private float maxVelocityCurrent;

	// Token: 0x040003F7 RID: 1015
	private float horizontalOffset;

	// Token: 0x040003F8 RID: 1016
	public float lookOffset;

	// Token: 0x040003F9 RID: 1017
	private float startLockedTimer;

	// Token: 0x040003FA RID: 1018
	private float targetDeltaX;

	// Token: 0x040003FB RID: 1019
	private float targetDeltaY;

	// Token: 0x040003FC RID: 1020
	[HideInInspector]
	public Vector2 panToTarget;

	// Token: 0x040003FD RID: 1021
	public float sceneWidth;

	// Token: 0x040003FE RID: 1022
	public float sceneHeight;

	// Token: 0x040003FF RID: 1023
	public float xLimit;

	// Token: 0x04000400 RID: 1024
	public float yLimit;

	// Token: 0x04000401 RID: 1025
	private CameraLockArea currentLockArea;

	// Token: 0x04000402 RID: 1026
	private Vector3 panStartPos;

	// Token: 0x04000403 RID: 1027
	private Vector3 panEndPos;

	// Token: 0x04000404 RID: 1028
	public Camera cam;

	// Token: 0x04000405 RID: 1029
	private HeroController hero_ctrl;

	// Token: 0x04000406 RID: 1030
	private GameManager gm;

	// Token: 0x04000407 RID: 1031
	public tk2dTileMap tilemap;

	// Token: 0x04000408 RID: 1032
	public CameraTarget camTarget;

	// Token: 0x04000409 RID: 1033
	private PlayMakerFSM fadeFSM;

	// Token: 0x0400040A RID: 1034
	private Transform cameraParent;

	// Token: 0x0400040B RID: 1035
	public List<CameraLockArea> lockZoneList;

	// Token: 0x0400040C RID: 1036
	public float xLockMin;

	// Token: 0x0400040D RID: 1037
	public float xLockMax;

	// Token: 0x0400040E RID: 1038
	public float yLockMin;

	// Token: 0x0400040F RID: 1039
	public float yLockMax;

	// Token: 0x020000D6 RID: 214
	public enum CameraMode
	{
		// Token: 0x04000411 RID: 1041
		FROZEN,
		// Token: 0x04000412 RID: 1042
		FOLLOWING,
		// Token: 0x04000413 RID: 1043
		LOCKED,
		// Token: 0x04000414 RID: 1044
		PANNING,
		// Token: 0x04000415 RID: 1045
		FADEOUT,
		// Token: 0x04000416 RID: 1046
		FADEIN,
		// Token: 0x04000417 RID: 1047
		PREVIOUS
	}
}
