using System;
using UnityEngine;

// Token: 0x020001D6 RID: 470
public class Walker : MonoBehaviour
{
	// Token: 0x06000A4E RID: 2638 RVA: 0x000383E3 File Offset: 0x000365E3
	protected void Awake()
	{
		this.body = base.GetComponent<Rigidbody2D>();
		this.bodyCollider = base.GetComponent<Collider2D>();
		this.animator = base.GetComponent<tk2dSpriteAnimator>();
		this.audioSource = base.GetComponent<AudioSource>();
	}

	// Token: 0x06000A4F RID: 2639 RVA: 0x00038418 File Offset: 0x00036618
	protected void Start()
	{
		this.mainCamera = GameCameras.instance.mainCamera;
		this.hero = HeroController.instance;
		if (this.currentFacing == 0)
		{
			this.currentFacing = ((base.transform.localScale.x * this.rightScale >= 0f) ? 1 : -1);
		}
		if (this.state == Walker.States.NotReady)
		{
			this.turnCooldownRemaining = -Mathf.Epsilon;
			this.BeginWaitingForConditions();
		}
	}

	// Token: 0x06000A50 RID: 2640 RVA: 0x0003848C File Offset: 0x0003668C
	protected void Update()
	{
		this.turnCooldownRemaining -= Time.deltaTime;
		switch (this.state)
		{
		case Walker.States.WaitingForConditions:
			this.UpdateWaitingForConditions();
			return;
		case Walker.States.Stopped:
			this.UpdateStopping();
			return;
		case Walker.States.Walking:
			this.UpdateWalking();
			return;
		case Walker.States.Turning:
			this.UpdateTurning();
			return;
		default:
			return;
		}
	}

	// Token: 0x06000A51 RID: 2641 RVA: 0x000384E8 File Offset: 0x000366E8
	public void StartMoving()
	{
		if (this.state == Walker.States.Stopped || this.state == Walker.States.WaitingForConditions)
		{
			this.startInactive = false;
			int facing;
			if (this.currentFacing == 0)
			{
				facing = ((UnityEngine.Random.Range(0, 2) == 0) ? -1 : 1);
			}
			else
			{
				facing = this.currentFacing;
			}
			this.BeginWalkingOrTurning(facing);
		}
		this.Update();
	}

	// Token: 0x06000A52 RID: 2642 RVA: 0x0003853A File Offset: 0x0003673A
	public void CancelTurn()
	{
		if (this.state == Walker.States.Turning)
		{
			this.BeginWalking(this.currentFacing);
		}
	}

	// Token: 0x06000A53 RID: 2643 RVA: 0x00038554 File Offset: 0x00036754
	public void Go(int facing)
	{
		this.turnCooldownRemaining = -Mathf.Epsilon;
		if (this.state == Walker.States.Stopped || this.state == Walker.States.Walking)
		{
			this.BeginWalkingOrTurning(facing);
		}
		else if (this.state == Walker.States.Turning && this.currentFacing == facing)
		{
			this.CancelTurn();
		}
		this.Update();
	}

	// Token: 0x06000A54 RID: 2644 RVA: 0x000385A6 File Offset: 0x000367A6
	public void RecieveGoMessage(int facing)
	{
		if (this.state != Walker.States.Stopped || this.stopReason != Walker.StopReasons.Controlled)
		{
			this.Go(facing);
		}
	}

	// Token: 0x06000A55 RID: 2645 RVA: 0x000385C1 File Offset: 0x000367C1
	public void Stop(Walker.StopReasons reason)
	{
		this.BeginStopped(reason);
	}

	// Token: 0x06000A56 RID: 2646 RVA: 0x000385CA File Offset: 0x000367CA
	public void ChangeFacing(int facing)
	{
		if (this.state == Walker.States.Turning)
		{
			this.turningFacing = facing;
			this.currentFacing = -facing;
			return;
		}
		this.currentFacing = facing;
	}

	// Token: 0x06000A57 RID: 2647 RVA: 0x000385EC File Offset: 0x000367EC
	private void BeginWaitingForConditions()
	{
		this.state = Walker.States.WaitingForConditions;
		this.didFulfilCameraDistanceCondition = false;
		this.didFulfilHeroXCondition = false;
		this.UpdateWaitingForConditions();
	}

	// Token: 0x06000A58 RID: 2648 RVA: 0x0003860C File Offset: 0x0003680C
	private void UpdateWaitingForConditions()
	{
		if (!this.didFulfilCameraDistanceCondition && (this.mainCamera.transform.position - base.transform.position).sqrMagnitude < 3600f)
		{
			this.didFulfilCameraDistanceCondition = true;
		}
		if (this.didFulfilCameraDistanceCondition && !this.didFulfilHeroXCondition && this.hero != null && Mathf.Abs(this.hero.transform.GetPositionX() - this.waitHeroX) < 1f)
		{
			this.didFulfilHeroXCondition = true;
		}
		if (this.didFulfilCameraDistanceCondition && (!this.waitForHeroX || this.didFulfilHeroXCondition) && !this.startInactive && !this.ambush)
		{
			this.BeginStopped(Walker.StopReasons.Bored);
			this.StartMoving();
		}
	}

	// Token: 0x06000A59 RID: 2649 RVA: 0x000386D4 File Offset: 0x000368D4
	private void BeginStopped(Walker.StopReasons reason)
	{
		this.state = Walker.States.Stopped;
		this.stopReason = reason;
		if (this.audioSource)
		{
			this.audioSource.Stop();
		}
		if (reason == Walker.StopReasons.Bored)
		{
			tk2dSpriteAnimationClip clipByName = this.animator.GetClipByName(this.idleClip);
			if (clipByName != null)
			{
				this.animator.Play(clipByName);
			}
			this.body.velocity = Vector2.Scale(this.body.velocity, new Vector2(0f, 1f));
			if (this.pauses)
			{
				this.pauseTimeRemaining = UnityEngine.Random.Range(this.pauseTimeMin, this.pauseTimeMax);
				return;
			}
			this.EndStopping();
		}
	}

	// Token: 0x06000A5A RID: 2650 RVA: 0x0003877B File Offset: 0x0003697B
	private void UpdateStopping()
	{
		if (this.stopReason == Walker.StopReasons.Bored)
		{
			this.pauseTimeRemaining -= Time.deltaTime;
			if (this.pauseTimeRemaining <= 0f)
			{
				this.EndStopping();
			}
		}
	}

	// Token: 0x06000A5B RID: 2651 RVA: 0x000387AC File Offset: 0x000369AC
	private void EndStopping()
	{
		if (this.currentFacing == 0)
		{
			this.BeginWalkingOrTurning((UnityEngine.Random.Range(0, 2) == 0) ? 1 : -1);
			return;
		}
		if (UnityEngine.Random.Range(0, 100) < this.turnAfterIdlePercentage)
		{
			this.BeginTurning(-this.currentFacing);
			return;
		}
		this.BeginWalking(this.currentFacing);
	}

	// Token: 0x06000A5C RID: 2652 RVA: 0x000387FF File Offset: 0x000369FF
	private void BeginWalkingOrTurning(int facing)
	{
		if (this.currentFacing == facing)
		{
			this.BeginWalking(facing);
			return;
		}
		this.BeginTurning(facing);
	}

	// Token: 0x06000A5D RID: 2653 RVA: 0x0003881C File Offset: 0x00036A1C
	private void BeginWalking(int facing)
	{
		this.state = Walker.States.Walking;
		this.animator.Play(this.walkClip);
		if (!this.preventScaleChange)
		{
			base.transform.SetScaleX((float)facing * this.rightScale);
		}
		this.walkTimeRemaining = UnityEngine.Random.Range(this.pauseWaitMin, this.pauseWaitMax);
		if (this.audioSource)
		{
			this.audioSource.Play();
		}
		this.body.velocity = new Vector2((facing > 0) ? this.walkSpeedR : this.walkSpeedL, this.body.velocity.y);
	}

	// Token: 0x06000A5E RID: 2654 RVA: 0x000388C0 File Offset: 0x00036AC0
	private void UpdateWalking()
	{
		if (this.turnCooldownRemaining <= 0f)
		{
			Sweep sweep = new Sweep(this.bodyCollider, 1 - this.currentFacing, 3, 0.1f);
			if (sweep.Check(base.transform.position, this.bodyCollider.bounds.extents.x + 0.5f, 256))
			{
				this.BeginTurning(-this.currentFacing);
				return;
			}
			if (!this.preventTurningToFaceHero && (this.hero != null && this.hero.transform.GetPositionX() > base.transform.GetPositionX() != this.currentFacing > 0) && this.lineOfSightDetector != null && this.lineOfSightDetector.CanSeeHero && this.alertRange != null && this.alertRange.IsHeroInRange)
			{
				this.BeginTurning(-this.currentFacing);
				return;
			}
			if (!this.ignoreHoles)
			{
				Sweep sweep2 = new Sweep(this.bodyCollider, 3, 3, 0.1f);
				if (!sweep2.Check(base.transform.position + new Vector2((this.bodyCollider.bounds.extents.x + 0.5f + this.edgeXAdjuster) * (float)this.currentFacing, 0f), 0.25f, 256))
				{
					this.BeginTurning(-this.currentFacing);
					return;
				}
			}
		}
		if (this.pauses)
		{
			this.walkTimeRemaining -= Time.deltaTime;
			if (this.walkTimeRemaining <= 0f)
			{
				this.BeginStopped(Walker.StopReasons.Bored);
				return;
			}
		}
		this.body.velocity = new Vector2((this.currentFacing > 0) ? this.walkSpeedR : this.walkSpeedL, this.body.velocity.y);
	}

	// Token: 0x06000A5F RID: 2655 RVA: 0x00038AC8 File Offset: 0x00036CC8
	private void BeginTurning(int facing)
	{
		this.state = Walker.States.Turning;
		this.turningFacing = facing;
		if (this.preventTurn)
		{
			this.EndTurning();
			return;
		}
		this.turnCooldownRemaining = this.turnPause;
		this.body.velocity = Vector2.Scale(this.body.velocity, new Vector2(0f, 1f));
		this.animator.Play(this.turnClip);
		FSMUtility.SendEventToGameObject(base.gameObject, (facing > 0) ? "TURN RIGHT" : "TURN LEFT", false);
	}

	// Token: 0x06000A60 RID: 2656 RVA: 0x00038B55 File Offset: 0x00036D55
	private void UpdateTurning()
	{
		this.body.velocity = Vector2.Scale(this.body.velocity, new Vector2(0f, 1f));
		if (!this.animator.Playing)
		{
			this.EndTurning();
		}
	}

	// Token: 0x06000A61 RID: 2657 RVA: 0x00038B94 File Offset: 0x00036D94
	private void EndTurning()
	{
		this.currentFacing = this.turningFacing;
		this.BeginWalking(this.currentFacing);
	}

	// Token: 0x06000A62 RID: 2658 RVA: 0x00038BAE File Offset: 0x00036DAE
	public void ClearTurnCooldown()
	{
		this.turnCooldownRemaining = -Mathf.Epsilon;
	}

	// Token: 0x04000B64 RID: 2916
	[Header("Structure")]
	[SerializeField]
	private LineOfSightDetector lineOfSightDetector;

	// Token: 0x04000B65 RID: 2917
	[SerializeField]
	private AlertRange alertRange;

	// Token: 0x04000B66 RID: 2918
	private Rigidbody2D body;

	// Token: 0x04000B67 RID: 2919
	private Collider2D bodyCollider;

	// Token: 0x04000B68 RID: 2920
	private tk2dSpriteAnimator animator;

	// Token: 0x04000B69 RID: 2921
	private AudioSource audioSource;

	// Token: 0x04000B6A RID: 2922
	private Camera mainCamera;

	// Token: 0x04000B6B RID: 2923
	private HeroController hero;

	// Token: 0x04000B6C RID: 2924
	private const float CameraDistanceForActivation = 60f;

	// Token: 0x04000B6D RID: 2925
	private const float WaitHeroXThreshold = 1f;

	// Token: 0x04000B6E RID: 2926
	[Header("Configuration")]
	[SerializeField]
	private bool ambush;

	// Token: 0x04000B6F RID: 2927
	[SerializeField]
	private string idleClip;

	// Token: 0x04000B70 RID: 2928
	[SerializeField]
	private string turnClip;

	// Token: 0x04000B71 RID: 2929
	[SerializeField]
	private string walkClip;

	// Token: 0x04000B72 RID: 2930
	[SerializeField]
	private float edgeXAdjuster;

	// Token: 0x04000B73 RID: 2931
	[SerializeField]
	private bool preventScaleChange;

	// Token: 0x04000B74 RID: 2932
	[SerializeField]
	private bool preventTurn;

	// Token: 0x04000B75 RID: 2933
	[SerializeField]
	private float pauseTimeMin;

	// Token: 0x04000B76 RID: 2934
	[SerializeField]
	private float pauseTimeMax;

	// Token: 0x04000B77 RID: 2935
	[SerializeField]
	private float pauseWaitMin;

	// Token: 0x04000B78 RID: 2936
	[SerializeField]
	private float pauseWaitMax;

	// Token: 0x04000B79 RID: 2937
	[SerializeField]
	private bool pauses;

	// Token: 0x04000B7A RID: 2938
	[SerializeField]
	private float rightScale;

	// Token: 0x04000B7B RID: 2939
	[SerializeField]
	public bool startInactive;

	// Token: 0x04000B7C RID: 2940
	[SerializeField]
	private int turnAfterIdlePercentage;

	// Token: 0x04000B7D RID: 2941
	[SerializeField]
	private float turnPause;

	// Token: 0x04000B7E RID: 2942
	[SerializeField]
	private bool waitForHeroX;

	// Token: 0x04000B7F RID: 2943
	[SerializeField]
	private float waitHeroX;

	// Token: 0x04000B80 RID: 2944
	[SerializeField]
	public float walkSpeedL;

	// Token: 0x04000B81 RID: 2945
	[SerializeField]
	public float walkSpeedR;

	// Token: 0x04000B82 RID: 2946
	[SerializeField]
	public bool ignoreHoles;

	// Token: 0x04000B83 RID: 2947
	[SerializeField]
	private bool preventTurningToFaceHero;

	// Token: 0x04000B84 RID: 2948
	private Walker.States state;

	// Token: 0x04000B85 RID: 2949
	private bool didFulfilCameraDistanceCondition;

	// Token: 0x04000B86 RID: 2950
	private bool didFulfilHeroXCondition;

	// Token: 0x04000B87 RID: 2951
	private int currentFacing;

	// Token: 0x04000B88 RID: 2952
	private int turningFacing;

	// Token: 0x04000B89 RID: 2953
	private float walkTimeRemaining;

	// Token: 0x04000B8A RID: 2954
	private float pauseTimeRemaining;

	// Token: 0x04000B8B RID: 2955
	private float turnCooldownRemaining;

	// Token: 0x04000B8C RID: 2956
	private Walker.StopReasons stopReason;

	// Token: 0x020001D7 RID: 471
	private enum States
	{
		// Token: 0x04000B8E RID: 2958
		NotReady,
		// Token: 0x04000B8F RID: 2959
		WaitingForConditions,
		// Token: 0x04000B90 RID: 2960
		Stopped,
		// Token: 0x04000B91 RID: 2961
		Walking,
		// Token: 0x04000B92 RID: 2962
		Turning
	}

	// Token: 0x020001D8 RID: 472
	public enum StopReasons
	{
		// Token: 0x04000B94 RID: 2964
		Bored,
		// Token: 0x04000B95 RID: 2965
		Controlled
	}
}
