using System;
using UnityEngine;

// Token: 0x02000398 RID: 920
public class BreakableObject : MonoBehaviour
{
	// Token: 0x0600154C RID: 5452 RVA: 0x00065498 File Offset: 0x00063698
	private void Awake()
	{
		this.source = base.GetComponent<AudioSource>();
	}

	// Token: 0x0600154D RID: 5453 RVA: 0x000654A8 File Offset: 0x000636A8
	private void Start()
	{
		if (Mathf.Abs(base.transform.position.z - 0.004f) > 1f)
		{
			if (this.source)
			{
				this.source.enabled = false;
			}
			Collider2D component = base.GetComponent<Collider2D>();
			if (component)
			{
				component.enabled = false;
			}
			base.enabled = false;
		}
	}

	// Token: 0x0600154E RID: 5454 RVA: 0x00065510 File Offset: 0x00063710
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (this.activated)
		{
			return;
		}
		bool flag = false;
		int num = (int)Mathf.Sign(base.transform.position.x - collision.transform.position.x);
		float num2 = 1f;
		BreakableObject.Direction direction = null;
		if (collision.tag == "Nail Attack")
		{
			flag = true;
			num2 = this.attackMagnitude;
			if (this.objectNailEffectPrefab)
			{
				GameObject gameObject = this.objectNailEffectPrefab.Spawn(base.transform.position);
				Vector3 localScale = gameObject.transform.localScale;
				localScale.x = Mathf.Abs(localScale.x) * (float)num;
				gameObject.transform.localScale = localScale;
			}
			if (this.midpointNailEffectPrefab)
			{
				GameObject gameObject2 = this.midpointNailEffectPrefab.Spawn((collision.transform.position + base.transform.position) / 2f);
				Vector3 localScale2 = gameObject2.transform.localScale;
				localScale2.x = Mathf.Abs(localScale2.x) * (float)num;
				gameObject2.transform.localScale = localScale2;
			}
			float value = PlayMakerFSM.FindFsmOnGameObject(collision.gameObject, "damages_enemy").FsmVariables.FindFsmFloat("direction").Value;
			if (value < 45f)
			{
				direction = this.right;
			}
			else if (value < 135f)
			{
				direction = this.up;
			}
			else if (value < 225f)
			{
				direction = this.left;
			}
			else if (value < 360f)
			{
				direction = this.down;
			}
			if (direction != null && direction.effectPrefab)
			{
				GameObject gameObject3 = direction.effectPrefab.Spawn(base.transform.position);
				if (gameObject3)
				{
					gameObject3.transform.localScale = direction.scale;
					gameObject3.transform.localEulerAngles = direction.rotation;
				}
			}
		}
		else if (collision.tag == "Hero Spell")
		{
			flag = true;
			if (this.spellHitEffectPrefab)
			{
				this.spellHitEffectPrefab.Spawn(base.transform.position);
			}
			else
			{
				Debug.Log("No spell hit effect assigned to: " + base.gameObject.name);
			}
		}
		if (flag)
		{
			if (this.containingParticles.Length != 0)
			{
				GameObject gameObject4 = Probability.GetRandomGameObjectByProbability(this.containingParticles);
				if (gameObject4)
				{
					if (gameObject4.transform.parent != base.transform)
					{
						BreakableObject.FlingObject flingObject = null;
						foreach (BreakableObject.FlingObject flingObject2 in this.flingObjectRegister)
						{
							if (flingObject2.referenceObject == gameObject4)
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
							gameObject4 = gameObject4.Spawn(base.transform.position);
						}
					}
					gameObject4.SetActive(true);
				}
			}
			foreach (GameObject gameObject5 in this.flingDebris)
			{
				if (gameObject5)
				{
					gameObject5.SetActive(true);
					float num3 = UnityEngine.Random.Range(direction.minFlingSpeed, direction.maxFlingSpeed) * num2;
					float num4 = UnityEngine.Random.Range(direction.minFlingAngle, direction.maxFlingAngle);
					float x = num3 * Mathf.Cos(num4 * 0.017453292f);
					float y = num3 * Mathf.Sin(num4 * 0.017453292f);
					Vector2 force = new Vector2(x, y);
					Rigidbody2D component = gameObject5.GetComponent<Rigidbody2D>();
					if (component)
					{
						component.AddForce(force, ForceMode2D.Impulse);
					}
				}
			}
			if (this.source && this.cutSound.Length != 0)
			{
				this.source.clip = this.cutSound[UnityEngine.Random.Range(0, this.cutSound.Length)];
				this.source.pitch = UnityEngine.Random.Range(this.pitchMin, this.pitchMax);
				this.source.Play();
			}
			GameCameras gameCameras = UnityEngine.Object.FindObjectOfType<GameCameras>();
			if (gameCameras)
			{
				gameCameras.cameraShakeFSM.SendEvent("EnemyKillShake");
			}
			SpriteRenderer component2 = base.GetComponent<SpriteRenderer>();
			if (component2)
			{
				component2.enabled = false;
			}
			this.activated = true;
		}
	}

	// Token: 0x0600154F RID: 5455 RVA: 0x0006594C File Offset: 0x00063B4C
	public BreakableObject()
	{
		this.attackMagnitude = 6f;
		this.pitchMin = 0.9f;
		this.pitchMax = 1.1f;
		base..ctor();
	}

	// Token: 0x04001971 RID: 6513
	public GameObject[] flingDebris;

	// Token: 0x04001972 RID: 6514
	public float attackMagnitude;

	// Token: 0x04001973 RID: 6515
	[Space]
	public BreakableObject.Direction right;

	// Token: 0x04001974 RID: 6516
	public BreakableObject.Direction left;

	// Token: 0x04001975 RID: 6517
	public BreakableObject.Direction up;

	// Token: 0x04001976 RID: 6518
	public BreakableObject.Direction down;

	// Token: 0x04001977 RID: 6519
	[Space]
	public Probability.ProbabilityGameObject[] containingParticles;

	// Token: 0x04001978 RID: 6520
	public BreakableObject.FlingObject[] flingObjectRegister;

	// Token: 0x04001979 RID: 6521
	[Space]
	public GameObject objectNailEffectPrefab;

	// Token: 0x0400197A RID: 6522
	public GameObject midpointNailEffectPrefab;

	// Token: 0x0400197B RID: 6523
	public GameObject spellHitEffectPrefab;

	// Token: 0x0400197C RID: 6524
	[Space]
	public AudioClip[] cutSound;

	// Token: 0x0400197D RID: 6525
	public float pitchMin;

	// Token: 0x0400197E RID: 6526
	public float pitchMax;

	// Token: 0x0400197F RID: 6527
	private AudioSource source;

	// Token: 0x04001980 RID: 6528
	private bool activated;

	// Token: 0x02000399 RID: 921
	[Serializable]
	public class Direction
	{
		// Token: 0x06001550 RID: 5456 RVA: 0x00065975 File Offset: 0x00063B75
		public Direction()
		{
			this.scale = Vector3.one;
			this.minFlingSpeed = 4f;
			this.maxFlingSpeed = 4f;
			this.minFlingAngle = 5f;
			this.maxFlingAngle = 5f;
			base..ctor();
		}

		// Token: 0x04001981 RID: 6529
		public GameObject effectPrefab;

		// Token: 0x04001982 RID: 6530
		public Vector3 scale;

		// Token: 0x04001983 RID: 6531
		public Vector3 rotation;

		// Token: 0x04001984 RID: 6532
		[Space]
		public float minFlingSpeed;

		// Token: 0x04001985 RID: 6533
		public float maxFlingSpeed;

		// Token: 0x04001986 RID: 6534
		public float minFlingAngle;

		// Token: 0x04001987 RID: 6535
		public float maxFlingAngle;
	}

	// Token: 0x0200039A RID: 922
	[Serializable]
	public class FlingObject
	{
		// Token: 0x06001551 RID: 5457 RVA: 0x000659B4 File Offset: 0x00063BB4
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

		// Token: 0x06001552 RID: 5458 RVA: 0x00065AC8 File Offset: 0x00063CC8
		public FlingObject()
		{
			this.spawnMin = 25;
			this.spawnMax = 30;
			this.speedMin = 9f;
			this.speedMax = 20f;
			this.angleMin = 20f;
			this.angleMax = 160f;
			this.originVariation = new Vector2(0.5f, 0.5f);
			base..ctor();
		}

		// Token: 0x04001988 RID: 6536
		public GameObject referenceObject;

		// Token: 0x04001989 RID: 6537
		[Space]
		public int spawnMin;

		// Token: 0x0400198A RID: 6538
		public int spawnMax;

		// Token: 0x0400198B RID: 6539
		public float speedMin;

		// Token: 0x0400198C RID: 6540
		public float speedMax;

		// Token: 0x0400198D RID: 6541
		public float angleMin;

		// Token: 0x0400198E RID: 6542
		public float angleMax;

		// Token: 0x0400198F RID: 6543
		public Vector2 originVariation;
	}
}
