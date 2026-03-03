using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000395 RID: 917
public class Breakable : MonoBehaviour, IHitResponder
{
	// Token: 0x06001539 RID: 5433 RVA: 0x00064960 File Offset: 0x00062B60
	protected void Reset()
	{
		this.inertBackgroundThreshold = 1f;
		this.inertForegroundThreshold = -1f;
		this.effectOffset = new Vector3(0f, 0.5f, 0f);
		this.flingSpeedMin = 10f;
		this.flingSpeedMax = 17f;
	}

	// Token: 0x0600153A RID: 5434 RVA: 0x000649B4 File Offset: 0x00062BB4
	protected void Awake()
	{
		this.bodyCollider = base.GetComponent<Collider2D>();
		PersistentBoolItem component = base.GetComponent<PersistentBoolItem>();
		if (component != null)
		{
			component.OnGetSaveState += delegate(ref bool val)
			{
				val = this.isBroken;
			};
			component.OnSetSaveState += delegate(bool val)
			{
				this.isBroken = val;
				if (this.isBroken)
				{
					this.SetStaticPartsActivation(true);
				}
			};
		}
	}

	// Token: 0x0600153B RID: 5435 RVA: 0x00064A04 File Offset: 0x00062C04
	protected void Start()
	{
		this.CreateAdditionalDebrisParts(this.debrisParts);
		float z = base.transform.position.z;
		if (z > this.inertBackgroundThreshold || z < this.inertForegroundThreshold)
		{
			BoxCollider2D component = base.GetComponent<BoxCollider2D>();
			if (component != null)
			{
				component.enabled = false;
			}
			UnityEngine.Object.Destroy(this);
			return;
		}
		for (int i = 0; i < this.remnantParts.Length; i++)
		{
			GameObject gameObject = this.remnantParts[i];
			if (gameObject != null && gameObject.activeSelf)
			{
				gameObject.SetActive(false);
			}
		}
		this.angleOffset *= Mathf.Sign(base.transform.localScale.x);
	}

	// Token: 0x0600153C RID: 5436 RVA: 0x00003603 File Offset: 0x00001803
	protected virtual void CreateAdditionalDebrisParts(List<GameObject> debrisParts)
	{
	}

	// Token: 0x0600153D RID: 5437 RVA: 0x00064AB4 File Offset: 0x00062CB4
	public void BreakSelf()
	{
		if (this.isBroken)
		{
			return;
		}
		this.Break(70f, 110f, 1f);
	}

	// Token: 0x0600153E RID: 5438 RVA: 0x00064AD4 File Offset: 0x00062CD4
	public void Hit(HitInstance damageInstance)
	{
		if (this.isBroken)
		{
			return;
		}
		float impactAngle = damageInstance.Direction;
		float num = damageInstance.MagnitudeMultiplier;
		if (damageInstance.AttackType == AttackTypes.Spell)
		{
			this.spellHitEffectPrefab.Spawn(base.transform.position).SetPositionZ(0.0031f);
		}
		else
		{
			if (damageInstance.AttackType != AttackTypes.Nail && damageInstance.AttackType != AttackTypes.Generic)
			{
				impactAngle = 90f;
				num = 1f;
			}
			this.strikeEffectPrefab.Spawn(base.transform.position);
			Vector3 position = (damageInstance.Source.transform.position + base.transform.position) * 0.5f;
			Breakable.SpawnNailHitEffect(this.nailHitEffectPrefab, position, impactAngle);
		}
		int cardinalDirection = DirectionUtils.GetCardinalDirection(damageInstance.Direction);
		Transform transform = this.dustHitRegularPrefab;
		float flingAngleMin;
		float flingAngleMax;
		Vector3 euler;
		if (cardinalDirection == 2)
		{
			this.angleOffset *= -1f;
			flingAngleMin = 120f;
			flingAngleMax = 160f;
			euler = new Vector3(180f, 90f, 270f);
		}
		else if (cardinalDirection == 0)
		{
			flingAngleMin = 30f;
			flingAngleMax = 70f;
			euler = new Vector3(0f, 90f, 270f);
		}
		else if (cardinalDirection == 1)
		{
			this.angleOffset = 0f;
			flingAngleMin = 70f;
			flingAngleMax = 110f;
			num *= 1.5f;
			euler = new Vector3(270f, 90f, 270f);
		}
		else
		{
			this.angleOffset = 0f;
			flingAngleMin = 160f;
			flingAngleMax = 380f;
			transform = this.dustHitDownPrefab;
			euler = new Vector3(-72.5f, -180f, -180f);
		}
		if (transform != null)
		{
			transform.Spawn(base.transform.position + this.effectOffset, Quaternion.Euler(euler));
		}
		this.Break(flingAngleMin, flingAngleMax, num);
	}

	// Token: 0x0600153F RID: 5439 RVA: 0x00064CB8 File Offset: 0x00062EB8
	private static Transform SpawnNailHitEffect(Transform nailHitEffectPrefab, Vector3 position, float impactAngle)
	{
		if (nailHitEffectPrefab == null)
		{
			return null;
		}
		int cardinalDirection = DirectionUtils.GetCardinalDirection(impactAngle);
		float y = 1.5f;
		float minInclusive;
		float maxInclusive;
		if (cardinalDirection == 3)
		{
			minInclusive = 250f;
			maxInclusive = 290f;
		}
		else if (cardinalDirection == 1)
		{
			minInclusive = 70f;
			maxInclusive = 110f;
		}
		else
		{
			minInclusive = 340f;
			maxInclusive = 380f;
		}
		float x = (cardinalDirection == 2) ? -1.5f : 1.5f;
		Transform transform = nailHitEffectPrefab.Spawn(position);
		Vector3 eulerAngles = transform.eulerAngles;
		eulerAngles.z = UnityEngine.Random.Range(minInclusive, maxInclusive);
		transform.eulerAngles = eulerAngles;
		Vector3 localScale = transform.localScale;
		localScale.x = x;
		localScale.y = y;
		transform.localScale = localScale;
		return transform;
	}

	// Token: 0x06001540 RID: 5440 RVA: 0x00064D68 File Offset: 0x00062F68
	private void SetStaticPartsActivation(bool broken)
	{
		if (this.wholeRenderer != null)
		{
			this.wholeRenderer.enabled = !broken;
		}
		for (int i = 0; i < this.wholeParts.Length; i++)
		{
			GameObject gameObject = this.wholeParts[i];
			if (gameObject == null)
			{
				Debug.LogErrorFormat(this, "Unassigned whole part in {0}", new object[]
				{
					this
				});
			}
			else
			{
				gameObject.SetActive(!broken);
			}
		}
		for (int j = 0; j < this.remnantParts.Length; j++)
		{
			GameObject gameObject2 = this.remnantParts[j];
			if (gameObject2 == null)
			{
				Debug.LogErrorFormat(this, "Unassigned remnant part in {0}", new object[]
				{
					this
				});
			}
			else
			{
				gameObject2.SetActive(broken);
			}
		}
		if (this.hitEventReciever != null)
		{
			FSMUtility.SendEventToGameObject(this.hitEventReciever, "HIT", false);
		}
		if (this.bodyCollider)
		{
			this.bodyCollider.enabled = !broken;
		}
	}

	// Token: 0x06001541 RID: 5441 RVA: 0x00064E58 File Offset: 0x00063058
	public void Break(float flingAngleMin, float flingAngleMax, float impactMultiplier)
	{
		if (this.isBroken)
		{
			return;
		}
		this.SetStaticPartsActivation(true);
		for (int i = 0; i < this.debrisParts.Count; i++)
		{
			GameObject gameObject = this.debrisParts[i];
			if (gameObject == null)
			{
				Debug.LogErrorFormat(this, "Unassigned debris part in {0}", new object[]
				{
					this
				});
			}
			else
			{
				gameObject.SetActive(true);
				gameObject.transform.SetRotationZ(gameObject.transform.localEulerAngles.z + this.angleOffset);
				Rigidbody2D component = gameObject.GetComponent<Rigidbody2D>();
				if (component != null)
				{
					float num = UnityEngine.Random.Range(flingAngleMin, flingAngleMax);
					Vector2 a = new Vector2(Mathf.Cos(num * 0.017453292f), Mathf.Sin(num * 0.017453292f));
					float d = UnityEngine.Random.Range(this.flingSpeedMin, this.flingSpeedMax) * impactMultiplier;
					component.velocity = a * d;
				}
			}
		}
		if (this.containingParticles.Length != 0)
		{
			GameObject gameObject2 = Probability.GetRandomGameObjectByProbability(this.containingParticles);
			if (gameObject2)
			{
				if (gameObject2.transform.parent != base.transform)
				{
					Breakable.FlingObject flingObject = null;
					foreach (Breakable.FlingObject flingObject2 in this.flingObjectRegister)
					{
						if (flingObject2.referenceObject == gameObject2)
						{
							flingObject = flingObject2;
							break;
						}
					}
					if (flingObject != null)
					{
						flingObject.Fling(base.transform.position);
					}
					else
					{
						gameObject2 = gameObject2.Spawn(base.transform.position);
					}
				}
				gameObject2.SetActive(true);
			}
		}
		this.breakAudioEvent.SpawnAndPlayOneShot(this.audioSourcePrefab, base.transform.position);
		this.breakAudioClipTable.SpawnAndPlayOneShot(this.audioSourcePrefab, base.transform.position);
		if (this.hitEventReciever != null)
		{
			FSMUtility.SendEventToGameObject(this.hitEventReciever, "HIT", false);
		}
		if (this.forwardBreakEvent)
		{
			FSMUtility.SendEventToGameObject(base.gameObject, "BREAK", false);
		}
		GameObject gameObject3 = GameObject.FindGameObjectWithTag("CameraParent");
		if (gameObject3 != null)
		{
			PlayMakerFSM playMakerFSM = PlayMakerFSM.FindFsmOnGameObject(gameObject3, "CameraShake");
			if (playMakerFSM != null)
			{
				playMakerFSM.SendEvent("EnemyKillShake");
			}
		}
		this.bodyCollider.enabled = false;
		this.isBroken = true;
	}

	// Token: 0x06001542 RID: 5442 RVA: 0x000650AF File Offset: 0x000632AF
	public Breakable()
	{
		this.angleOffset = -60f;
		base..ctor();
	}

	// Token: 0x04001944 RID: 6468
	private Collider2D bodyCollider;

	// Token: 0x04001945 RID: 6469
	[Tooltip("Renderer which presents the undestroyed object.")]
	[SerializeField]
	private Renderer wholeRenderer;

	// Token: 0x04001946 RID: 6470
	[Tooltip("List of child game objects which also represent the whole object.")]
	[SerializeField]
	private GameObject[] wholeParts;

	// Token: 0x04001947 RID: 6471
	[Tooltip("List of child game objects which represent remnants that remain static after destruction.")]
	[SerializeField]
	private GameObject[] remnantParts;

	// Token: 0x04001948 RID: 6472
	[SerializeField]
	private List<GameObject> debrisParts;

	// Token: 0x04001949 RID: 6473
	[SerializeField]
	private float angleOffset;

	// Token: 0x0400194A RID: 6474
	[Tooltip("Breakables behind this threshold are inert.")]
	[SerializeField]
	private float inertBackgroundThreshold;

	// Token: 0x0400194B RID: 6475
	[Tooltip("Breakables in front of this threshold are inert.")]
	[SerializeField]
	private float inertForegroundThreshold;

	// Token: 0x0400194C RID: 6476
	[Tooltip("Breakable effects are spawned at this offset.")]
	[SerializeField]
	private Vector3 effectOffset;

	// Token: 0x0400194D RID: 6477
	[Tooltip("Prefab to spawn for audio.")]
	[SerializeField]
	private AudioSource audioSourcePrefab;

	// Token: 0x0400194E RID: 6478
	[Tooltip("Table of audio clips to play upon break.")]
	[SerializeField]
	private AudioEvent breakAudioEvent;

	// Token: 0x0400194F RID: 6479
	[Tooltip("Table of audio clips to play upon break.")]
	[SerializeField]
	private RandomAudioClipTable breakAudioClipTable;

	// Token: 0x04001950 RID: 6480
	[Tooltip("Prefab to spawn when hit from a non-down angle.")]
	[SerializeField]
	private Transform dustHitRegularPrefab;

	// Token: 0x04001951 RID: 6481
	[Tooltip("Prefab to spawn when hit from a down angle.")]
	[SerializeField]
	private Transform dustHitDownPrefab;

	// Token: 0x04001952 RID: 6482
	[Tooltip("Prefab to spawn when hit from a down angle.")]
	[SerializeField]
	private float flingSpeedMin;

	// Token: 0x04001953 RID: 6483
	[Tooltip("Prefab to spawn when hit from a down angle.")]
	[SerializeField]
	private float flingSpeedMax;

	// Token: 0x04001954 RID: 6484
	[Tooltip("Strike effect prefab to spawn.")]
	[SerializeField]
	private Transform strikeEffectPrefab;

	// Token: 0x04001955 RID: 6485
	[Tooltip("Nail hit prefab to spawn.")]
	[SerializeField]
	private Transform nailHitEffectPrefab;

	// Token: 0x04001956 RID: 6486
	[Tooltip("Spell hit effect prefab to spawn.")]
	[SerializeField]
	private Transform spellHitEffectPrefab;

	// Token: 0x04001957 RID: 6487
	[Tooltip("Legacy flag that was set but has always been broken but is no longer used?")]
	[SerializeField]
	private bool preventParticleRotation;

	// Token: 0x04001958 RID: 6488
	[Tooltip("Object to send HIT event to.")]
	[SerializeField]
	private GameObject hitEventReciever;

	// Token: 0x04001959 RID: 6489
	[Tooltip("Forward break effect to sibling FSMs.")]
	[SerializeField]
	private bool forwardBreakEvent;

	// Token: 0x0400195A RID: 6490
	[Space]
	public Probability.ProbabilityGameObject[] containingParticles;

	// Token: 0x0400195B RID: 6491
	public Breakable.FlingObject[] flingObjectRegister;

	// Token: 0x0400195C RID: 6492
	private bool isBroken;

	// Token: 0x02000396 RID: 918
	[Serializable]
	public class FlingObject
	{
		// Token: 0x06001545 RID: 5445 RVA: 0x000650E4 File Offset: 0x000632E4
		public FlingObject()
		{
			this.spawnMin = 25;
			this.spawnMax = 30;
			this.speedMin = 9f;
			this.speedMax = 20f;
			this.angleMin = 20f;
			this.angleMax = 160f;
			this.originVariation = new Vector2(0.5f, 0.5f);
		}

		// Token: 0x06001546 RID: 5446 RVA: 0x00065148 File Offset: 0x00063348
		public void Fling(Vector3 origin)
		{
			if (!this.referenceObject)
			{
				return;
			}
			int num = UnityEngine.Random.Range(this.spawnMin, this.spawnMax + 1);
			for (int i = 0; i < num; i++)
			{
				GameObject gameObject = this.referenceObject.Spawn();
				if (gameObject)
				{
					gameObject.transform.position = origin + new Vector3(UnityEngine.Random.Range(-this.originVariation.x, this.originVariation.x), UnityEngine.Random.Range(-this.originVariation.y, this.originVariation.y), 0f);
					float num2 = UnityEngine.Random.Range(this.speedMin, this.speedMax);
					float num3 = UnityEngine.Random.Range(this.angleMin, this.angleMax);
					float x = num2 * Mathf.Cos(num3 * 0.017453292f);
					float y = num2 * Mathf.Sin(num3 * 0.017453292f);
					Vector2 force = new Vector2(x, y);
					Rigidbody2D component = gameObject.GetComponent<Rigidbody2D>();
					if (component)
					{
						component.AddForce(force, ForceMode2D.Impulse);
					}
				}
			}
		}

		// Token: 0x0400195D RID: 6493
		public GameObject referenceObject;

		// Token: 0x0400195E RID: 6494
		[Space]
		public int spawnMin;

		// Token: 0x0400195F RID: 6495
		public int spawnMax;

		// Token: 0x04001960 RID: 6496
		public float speedMin;

		// Token: 0x04001961 RID: 6497
		public float speedMax;

		// Token: 0x04001962 RID: 6498
		public float angleMin;

		// Token: 0x04001963 RID: 6499
		public float angleMax;

		// Token: 0x04001964 RID: 6500
		public Vector2 originVariation;
	}
}
