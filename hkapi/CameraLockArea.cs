using System;
using System.Collections;
using GlobalEnums;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x020000DE RID: 222
public class CameraLockArea : MonoBehaviour
{
	// Token: 0x06000496 RID: 1174 RVA: 0x00016BAC File Offset: 0x00014DAC
	private void Awake()
	{
		this.box2d = base.GetComponent<Collider2D>();
	}

	// Token: 0x06000497 RID: 1175 RVA: 0x00016BBA File Offset: 0x00014DBA
	private IEnumerator Start()
	{
		CameraLockArea.<Start>d__9 <Start>d__ = new CameraLockArea.<Start>d__9(0);
		<Start>d__.<>4__this = this;
		return <Start>d__;
	}

	// Token: 0x06000498 RID: 1176 RVA: 0x00016BCC File Offset: 0x00014DCC
	private bool IsInApplicableGameState()
	{
		GameManager unsafeInstance = GameManager.UnsafeInstance;
		return !(unsafeInstance == null) && (unsafeInstance.gameState == GameState.PLAYING || unsafeInstance.gameState == GameState.ENTERING_LEVEL);
	}

	// Token: 0x06000499 RID: 1177 RVA: 0x00016C00 File Offset: 0x00014E00
	public void OnTriggerEnter2D(Collider2D otherCollider)
	{
		if (this.IsInApplicableGameState() && otherCollider.CompareTag("Player"))
		{
			this.heroPos = otherCollider.gameObject.transform.position;
			if (this.box2d != null)
			{
				if (this.heroPos.x > this.leftSideX - 1f && this.heroPos.x < this.leftSideX + 1f)
				{
					this.camTarget.enteredLeft = true;
				}
				else
				{
					this.camTarget.enteredLeft = false;
				}
				if (this.heroPos.x > this.rightSideX - 1f && this.heroPos.x < this.rightSideX + 1f)
				{
					this.camTarget.enteredRight = true;
				}
				else
				{
					this.camTarget.enteredRight = false;
				}
				if (this.heroPos.y > this.topSideY - 2f && this.heroPos.y < this.topSideY + 2f)
				{
					this.camTarget.enteredTop = true;
				}
				else
				{
					this.camTarget.enteredTop = false;
				}
				if (this.heroPos.y > this.botSideY - 1f && this.heroPos.y < this.botSideY + 1f)
				{
					this.camTarget.enteredBot = true;
				}
				else
				{
					this.camTarget.enteredBot = false;
				}
			}
			this.cameraCtrl.LockToArea(this);
			if (this.verboseMode)
			{
				Debug.Log("Lockzone Enter Lock " + base.name);
			}
		}
	}

	// Token: 0x0600049A RID: 1178 RVA: 0x00016DA8 File Offset: 0x00014FA8
	public void OnTriggerStay2D(Collider2D otherCollider)
	{
		if (!base.isActiveAndEnabled || !this.box2d.isActiveAndEnabled)
		{
			Debug.LogWarning("Fix for Unity trigger event queue!");
			return;
		}
		if (this.IsInApplicableGameState() && otherCollider.CompareTag("Player"))
		{
			if (this.verboseMode)
			{
				Debug.Log("Lockzone Stay Lock " + base.name);
			}
			this.cameraCtrl.LockToArea(this);
		}
	}

	// Token: 0x0600049B RID: 1179 RVA: 0x00016E14 File Offset: 0x00015014
	public void OnTriggerExit2D(Collider2D otherCollider)
	{
		if (otherCollider.CompareTag("Player"))
		{
			this.heroPos = otherCollider.gameObject.transform.position;
			if (this.box2d != null)
			{
				if (this.heroPos.x > this.leftSideX - 1f && this.heroPos.x < this.leftSideX + 1f)
				{
					this.camTarget.exitedLeft = true;
				}
				else
				{
					this.camTarget.exitedLeft = false;
				}
				if (this.heroPos.x > this.rightSideX - 1f && this.heroPos.x < this.rightSideX + 1f)
				{
					this.camTarget.exitedRight = true;
				}
				else
				{
					this.camTarget.exitedRight = false;
				}
				if (this.heroPos.y > this.topSideY - 2f && this.heroPos.y < this.topSideY + 2f)
				{
					this.camTarget.exitedTop = true;
				}
				else
				{
					this.camTarget.exitedTop = false;
				}
				if (this.heroPos.y > this.botSideY - 1f && this.heroPos.y < this.botSideY + 1f)
				{
					this.camTarget.exitedBot = true;
				}
				else
				{
					this.camTarget.exitedBot = false;
				}
			}
			this.cameraCtrl.ReleaseLock(this);
			if (this.verboseMode)
			{
				Debug.Log("Lockzone Exit Lock " + base.name);
			}
		}
	}

	// Token: 0x0600049C RID: 1180 RVA: 0x00016FB1 File Offset: 0x000151B1
	public void OnDisable()
	{
		if (this.cameraCtrl != null)
		{
			this.cameraCtrl.ReleaseLock(this);
		}
	}

	// Token: 0x0600049D RID: 1181 RVA: 0x00016FD0 File Offset: 0x000151D0
	private bool ValidateBounds()
	{
		if (this.cameraXMin == -1f)
		{
			this.cameraXMin = 14.6f;
		}
		if (this.cameraXMax == -1f)
		{
			this.cameraXMax = this.cameraCtrl.xLimit;
		}
		if (this.cameraYMin == -1f)
		{
			this.cameraYMin = 8.3f;
		}
		if (this.cameraYMax == -1f)
		{
			this.cameraYMax = this.cameraCtrl.yLimit;
		}
		return this.cameraXMin != 0f || this.cameraXMax != 0f || this.cameraYMin != 0f || this.cameraYMax != 0f;
	}

	// Token: 0x0600049E RID: 1182 RVA: 0x00017080 File Offset: 0x00015280
	public void SetXMin(float xmin)
	{
		this.cameraXMin = xmin;
	}

	// Token: 0x0600049F RID: 1183 RVA: 0x00017089 File Offset: 0x00015289
	public void SetXMax(float xmax)
	{
		this.cameraXMax = xmax;
	}

	// Token: 0x060004A1 RID: 1185 RVA: 0x00017092 File Offset: 0x00015292
	private IEnumerator orig_Start()
	{
		this.gcams = GameCameras.instance;
		this.cameraCtrl = this.gcams.cameraController;
		this.camTarget = this.gcams.cameraTarget;
		Scene scene = this.gameObject.scene;
		while (this.cameraCtrl.tilemap == null || this.cameraCtrl.tilemap.gameObject.scene != scene)
		{
			yield return null;
		}
		if (!this.ValidateBounds())
		{
			Debug.LogError("Camera bounds are unspecified for " + this.name + ", please specify lock area bounds for this Camera Lock Area.");
		}
		if (this.box2d != null)
		{
			this.leftSideX = this.box2d.bounds.min.x;
			this.rightSideX = this.box2d.bounds.max.x;
			this.botSideY = this.box2d.bounds.min.y;
			this.topSideY = this.box2d.bounds.max.y;
		}
		yield break;
	}

	// Token: 0x04000432 RID: 1074
	private bool verboseMode;

	// Token: 0x04000433 RID: 1075
	public float cameraXMin;

	// Token: 0x04000434 RID: 1076
	public float cameraYMin;

	// Token: 0x04000435 RID: 1077
	public float cameraXMax;

	// Token: 0x04000436 RID: 1078
	public float cameraYMax;

	// Token: 0x04000437 RID: 1079
	private float leftSideX;

	// Token: 0x04000438 RID: 1080
	private float rightSideX;

	// Token: 0x04000439 RID: 1081
	private float topSideY;

	// Token: 0x0400043A RID: 1082
	private float botSideY;

	// Token: 0x0400043B RID: 1083
	private Vector3 heroPos;

	// Token: 0x0400043C RID: 1084
	private bool enteredLeft;

	// Token: 0x0400043D RID: 1085
	private bool enteredRight;

	// Token: 0x0400043E RID: 1086
	private bool enteredTop;

	// Token: 0x0400043F RID: 1087
	private bool enteredBot;

	// Token: 0x04000440 RID: 1088
	private bool exitedLeft;

	// Token: 0x04000441 RID: 1089
	private bool exitedRight;

	// Token: 0x04000442 RID: 1090
	private bool exitedTop;

	// Token: 0x04000443 RID: 1091
	private bool exitedBot;

	// Token: 0x04000444 RID: 1092
	public bool preventLookUp;

	// Token: 0x04000445 RID: 1093
	public bool preventLookDown;

	// Token: 0x04000446 RID: 1094
	public bool maxPriority;

	// Token: 0x04000447 RID: 1095
	private GameCameras gcams;

	// Token: 0x04000448 RID: 1096
	private CameraController cameraCtrl;

	// Token: 0x04000449 RID: 1097
	private CameraTarget camTarget;

	// Token: 0x0400044A RID: 1098
	private Collider2D box2d;
}
