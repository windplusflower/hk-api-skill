using System;
using System.Collections;
using UnityEngine;

// Token: 0x020003AC RID: 940
public class DreamPlantOrb : MonoBehaviour
{
	// Token: 0x06001593 RID: 5523 RVA: 0x00066FA4 File Offset: 0x000651A4
	private void Awake()
	{
		this.rend = base.GetComponent<Renderer>();
		PersistentBoolItem persist = base.GetComponent<PersistentBoolItem>();
		if (persist)
		{
			persist.OnGetSaveState += delegate(ref bool value)
			{
				value = this.pickedUp;
			};
			persist.OnSetSaveState += delegate(bool value)
			{
				if (!this.didEverSetSaveState)
				{
					this.pickedUp = value;
					this.didEverSetSaveState = true;
					persist.enabled = false;
				}
			};
			persist.PreSetup();
		}
	}

	// Token: 0x06001594 RID: 5524 RVA: 0x0006701C File Offset: 0x0006521C
	private void Start()
	{
		this.SetActive(false);
		this.initialScale = base.transform.localScale;
	}

	// Token: 0x06001595 RID: 5525 RVA: 0x00067038 File Offset: 0x00065238
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (!this.isActive || this.pickedUp || !this.canPickup)
		{
			return;
		}
		if (collision.tag == "Player")
		{
			GameManager.instance.IncrementPlayerDataInt("dreamOrbs");
			EventRegister.SendEvent("DREAM ORB COLLECT");
			if (this.soundSource && this.collectSound)
			{
				if (DreamPlantOrb.currentPitch <= 0f || Time.time >= DreamPlantOrb.pitchReturnTime)
				{
					DreamPlantOrb.currentPitch = this.basePitch;
				}
				if (DreamPlantOrb.currentPitch > this.maxPitch)
				{
					DreamPlantOrb.currentPitch = this.maxPitch;
				}
				this.soundSource.pitch = DreamPlantOrb.currentPitch;
				this.soundSource.PlayOneShot(this.collectSound);
				DreamPlantOrb.currentPitch += this.increasePitch;
				DreamPlantOrb.pitchReturnTime = Time.time + this.pitchReturnDelay;
			}
			if (this.pickupParticles)
			{
				this.pickupParticles.gameObject.SetActive(true);
			}
			if (this.whiteFlash)
			{
				this.whiteFlash.gameObject.SetActive(true);
			}
			if (this.pickupAnim)
			{
				this.pickupAnim.gameObject.SetActive(true);
				base.StartCoroutine(this.DisableAfterTime(this.pickupAnim.gameObject, this.pickupAnim.Length));
			}
			PersistentBoolItem component = base.GetComponent<PersistentBoolItem>();
			if (component)
			{
				component.enabled = true;
			}
			this.pickedUp = true;
			this.Disable();
		}
	}

	// Token: 0x06001596 RID: 5526 RVA: 0x000671CA File Offset: 0x000653CA
	public void Show()
	{
		if (this.pickedUp)
		{
			return;
		}
		this.SetActive(true);
		DreamPlantOrb.plant.AddOrbCount();
		this.spreadRoutine = base.StartCoroutine(this.Spread());
	}

	// Token: 0x06001597 RID: 5527 RVA: 0x000671F8 File Offset: 0x000653F8
	private void SetActive(bool value)
	{
		this.isActive = value;
		if (this.rend)
		{
			this.rend.enabled = value;
		}
		if (this.loopSource)
		{
			this.loopSource.enabled = value;
		}
	}

	// Token: 0x06001598 RID: 5528 RVA: 0x00067233 File Offset: 0x00065433
	private IEnumerator Spread()
	{
		if (this.rend)
		{
			this.rend.enabled = false;
		}
		yield return null;
		this.transform.localScale = this.initialScale.MultiplyElements(new Vector3(0.5f, 0.5f, 1f));
		Vector3 position = DreamPlantOrb.plant.transform.position;
		position.z = UnityEngine.Random.Range(0.003f, 0.004f);
		position.x += (float)UnityEngine.Random.Range(-1, 1);
		position.y += (float)UnityEngine.Random.Range(-3, -2);
		Vector3 initialPos = this.transform.position;
		initialPos.z = 0.003f;
		this.transform.position = position;
		if (this.rend)
		{
			this.rend.enabled = true;
		}
		if (this.trailParticles)
		{
			this.trailParticles.gameObject.SetActive(true);
		}
		Vector3 vector = initialPos - this.transform.position;
		vector.z = 0f;
		vector.Normalize();
		vector *= UnityEngine.Random.Range(2f, 10f);
		Vector3 position2 = this.transform.position + vector;
		yield return this.StartCoroutine(this.TweenPosition(position2, 1f, this.spread1Curve));
		yield return new WaitForSeconds(UnityEngine.Random.Range(1f, 1.5f));
		yield return this.StartCoroutine(this.TweenPosition(initialPos, 1f, this.spread2Curve));
		this.transform.localScale = this.initialScale.MultiplyElements(new Vector3(1f, 1f, 1f));
		if (this.whiteFlash)
		{
			this.whiteFlash.gameObject.SetActive(true);
		}
		if (this.activateParticles)
		{
			this.activateParticles.gameObject.SetActive(true);
		}
		if (this.trailParticles)
		{
			this.trailParticles.Stop(true, ParticleSystemStopBehavior.StopEmitting);
		}
		this.canPickup = true;
		yield break;
	}

	// Token: 0x06001599 RID: 5529 RVA: 0x00067242 File Offset: 0x00065442
	private void Disable()
	{
		this.pickedUp = true;
		if (DreamPlantOrb.plant != null)
		{
			DreamPlantOrb.plant.RemoveOrbCount();
		}
		this.SetActive(false);
		if (this.spreadRoutine != null)
		{
			base.StopCoroutine(this.spreadRoutine);
		}
	}

	// Token: 0x0600159A RID: 5530 RVA: 0x0006727D File Offset: 0x0006547D
	private IEnumerator DisableAfterTime(GameObject obj, float time)
	{
		yield return new WaitForSeconds(time);
		obj.SetActive(false);
		yield break;
	}

	// Token: 0x0600159B RID: 5531 RVA: 0x00067293 File Offset: 0x00065493
	private IEnumerator TweenPosition(Vector3 position, float time, AnimationCurve curve)
	{
		Vector3 startPos = this.transform.position;
		for (float elapsed = 0f; elapsed <= time; elapsed += Time.deltaTime)
		{
			this.transform.position = Vector3.Lerp(startPos, position, curve.Evaluate(elapsed / time));
			yield return null;
		}
		this.transform.position = position;
		yield break;
	}

	// Token: 0x0600159C RID: 5532 RVA: 0x000672B7 File Offset: 0x000654B7
	public DreamPlantOrb()
	{
		this.basePitch = 0.85f;
		this.increasePitch = 0.025f;
		this.maxPitch = 1.25f;
		this.pitchReturnDelay = 3f;
		base..ctor();
	}

	// Token: 0x040019E6 RID: 6630
	public static DreamPlant plant;

	// Token: 0x040019E7 RID: 6631
	public BasicSpriteAnimator pickupAnim;

	// Token: 0x040019E8 RID: 6632
	private Renderer rend;

	// Token: 0x040019E9 RID: 6633
	private Vector3 initialScale;

	// Token: 0x040019EA RID: 6634
	public AudioSource loopSource;

	// Token: 0x040019EB RID: 6635
	[Space]
	public AudioSource soundSource;

	// Token: 0x040019EC RID: 6636
	public AudioClip collectSound;

	// Token: 0x040019ED RID: 6637
	public float basePitch;

	// Token: 0x040019EE RID: 6638
	public float increasePitch;

	// Token: 0x040019EF RID: 6639
	public float maxPitch;

	// Token: 0x040019F0 RID: 6640
	public float pitchReturnDelay;

	// Token: 0x040019F1 RID: 6641
	private static float currentPitch;

	// Token: 0x040019F2 RID: 6642
	private static float pitchReturnTime;

	// Token: 0x040019F3 RID: 6643
	[Space]
	public GameObject whiteFlash;

	// Token: 0x040019F4 RID: 6644
	[Space]
	public ParticleSystem pickupParticles;

	// Token: 0x040019F5 RID: 6645
	[Space]
	public ParticleSystem trailParticles;

	// Token: 0x040019F6 RID: 6646
	public ParticleSystem activateParticles;

	// Token: 0x040019F7 RID: 6647
	[Space]
	public AnimationCurve spread1Curve;

	// Token: 0x040019F8 RID: 6648
	public AnimationCurve spread2Curve;

	// Token: 0x040019F9 RID: 6649
	private bool pickedUp;

	// Token: 0x040019FA RID: 6650
	private bool canPickup;

	// Token: 0x040019FB RID: 6651
	private bool isActive;

	// Token: 0x040019FC RID: 6652
	private bool didEverSetSaveState;

	// Token: 0x040019FD RID: 6653
	private Coroutine spreadRoutine;
}
