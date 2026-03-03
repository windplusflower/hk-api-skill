using System;
using UnityEngine;

// Token: 0x02000011 RID: 17
public class ObjectBounce : MonoBehaviour
{
	// Token: 0x14000001 RID: 1
	// (add) Token: 0x0600004E RID: 78 RVA: 0x000037F8 File Offset: 0x000019F8
	// (remove) Token: 0x0600004F RID: 79 RVA: 0x00003830 File Offset: 0x00001A30
	public event ObjectBounce.BounceEvent OnBounce;

	// Token: 0x06000050 RID: 80 RVA: 0x00003865 File Offset: 0x00001A65
	private void Start()
	{
		this.rb = base.GetComponent<Rigidbody2D>();
		this.audio = base.GetComponent<AudioSource>();
		this.animator = base.GetComponent<tk2dSpriteAnimator>();
		if (this.sendFSMEvent)
		{
			this.fsm = base.GetComponent<PlayMakerFSM>();
		}
	}

	// Token: 0x06000051 RID: 81 RVA: 0x000038A0 File Offset: 0x00001AA0
	private void FixedUpdate()
	{
		if (this.bouncing)
		{
			if (this.stepCounter >= 3)
			{
				Vector2 a = new Vector2(base.transform.position.x, base.transform.position.y);
				this.velocity = a - this.lastPos;
				this.lastPos = a;
				this.speed = (this.rb ? this.rb.velocity.magnitude : 0f);
				this.stepCounter = 0;
				return;
			}
			this.stepCounter++;
		}
	}

	// Token: 0x06000052 RID: 82 RVA: 0x00003944 File Offset: 0x00001B44
	private void Update()
	{
		if (this.animTimer > 0f)
		{
			this.animTimer -= Time.deltaTime;
		}
	}

	// Token: 0x06000053 RID: 83 RVA: 0x00003968 File Offset: 0x00001B68
	private void OnCollisionEnter2D(Collision2D col)
	{
		if (!this.rb || this.rb.isKinematic)
		{
			return;
		}
		if (this.bouncing && this.speed > this.speedThreshold)
		{
			Vector3 inNormal = col.GetSafeContact().Normal;
			Vector3 normalized = Vector3.Reflect(this.velocity.normalized, inNormal).normalized;
			this.rb.velocity = new Vector2(normalized.x, normalized.y) * (this.speed * (this.bounceFactor * UnityEngine.Random.Range(0.8f, 1.2f)));
			if (this.playSound)
			{
				this.chooser = UnityEngine.Random.Range(1, 100);
				int num = UnityEngine.Random.Range(0, this.clips.Length - 1);
				AudioClip clip = this.clips[num];
				if (this.chooser <= this.chanceToPlay)
				{
					float pitch = UnityEngine.Random.Range(this.pitchMin, this.pitchMax);
					this.audio.pitch = pitch;
					this.audio.PlayOneShot(clip);
				}
			}
			if (this.playAnimationOnBounce && this.animTimer <= 0f)
			{
				this.animator.Play(this.animationName);
				this.animator.PlayFromFrame(0);
				this.animTimer = this.animPause;
			}
			if (this.sendFSMEvent && this.fsm)
			{
				this.fsm.SendEvent("BOUNCE");
			}
			if (this.OnBounce != null)
			{
				this.OnBounce();
			}
		}
	}

	// Token: 0x06000054 RID: 84 RVA: 0x00003AFC File Offset: 0x00001CFC
	public void StopBounce()
	{
		this.bouncing = false;
	}

	// Token: 0x06000055 RID: 85 RVA: 0x00003B05 File Offset: 0x00001D05
	public void StartBounce()
	{
		this.bouncing = true;
	}

	// Token: 0x06000056 RID: 86 RVA: 0x00003B0E File Offset: 0x00001D0E
	public void SetBounceFactor(float value)
	{
		this.bounceFactor = value;
	}

	// Token: 0x06000057 RID: 87 RVA: 0x00003B17 File Offset: 0x00001D17
	public void SetBounceAnimation(bool set)
	{
		this.playAnimationOnBounce = set;
	}

	// Token: 0x06000058 RID: 88 RVA: 0x00003B20 File Offset: 0x00001D20
	public ObjectBounce()
	{
		this.speedThreshold = 1f;
		this.chanceToPlay = 100;
		this.pitchMin = 1f;
		this.pitchMax = 1f;
		this.animPause = 0.5f;
		this.bouncing = true;
		base..ctor();
	}

	// Token: 0x0400003A RID: 58
	public float bounceFactor;

	// Token: 0x0400003B RID: 59
	public float speedThreshold;

	// Token: 0x0400003C RID: 60
	public bool playSound;

	// Token: 0x0400003D RID: 61
	public AudioClip[] clips;

	// Token: 0x0400003E RID: 62
	public int chanceToPlay;

	// Token: 0x0400003F RID: 63
	public float pitchMin;

	// Token: 0x04000040 RID: 64
	public float pitchMax;

	// Token: 0x04000041 RID: 65
	public bool playAnimationOnBounce;

	// Token: 0x04000042 RID: 66
	public string animationName;

	// Token: 0x04000043 RID: 67
	public float animPause;

	// Token: 0x04000044 RID: 68
	public bool sendFSMEvent;

	// Token: 0x04000045 RID: 69
	private float speed;

	// Token: 0x04000046 RID: 70
	private float animTimer;

	// Token: 0x04000047 RID: 71
	private tk2dSpriteAnimator animator;

	// Token: 0x04000048 RID: 72
	private PlayMakerFSM fsm;

	// Token: 0x04000049 RID: 73
	private Vector2 velocity;

	// Token: 0x0400004A RID: 74
	private Vector2 lastPos;

	// Token: 0x0400004B RID: 75
	private Rigidbody2D rb;

	// Token: 0x0400004C RID: 76
	private AudioSource audio;

	// Token: 0x0400004D RID: 77
	private int chooser;

	// Token: 0x0400004E RID: 78
	private bool bouncing;

	// Token: 0x0400004F RID: 79
	private int stepCounter;

	// Token: 0x02000012 RID: 18
	// (Invoke) Token: 0x0600005A RID: 90
	public delegate void BounceEvent();
}
