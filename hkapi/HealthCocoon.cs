using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020003CF RID: 975
public class HealthCocoon : MonoBehaviour
{
	// Token: 0x0600165D RID: 5725 RVA: 0x00069B44 File Offset: 0x00067D44
	private void Awake()
	{
		this.source = base.GetComponent<AudioSource>();
		this.animator = base.GetComponent<tk2dSpriteAnimator>();
		PersistentBoolItem component = base.GetComponent<PersistentBoolItem>();
		if (component)
		{
			component.OnGetSaveState += delegate(ref bool value)
			{
				value = this.activated;
			};
			component.OnSetSaveState += delegate(bool value)
			{
				this.activated = value;
				if (this.activated)
				{
					this.SetBroken();
				}
			};
		}
	}

	// Token: 0x0600165E RID: 5726 RVA: 0x00069B9C File Offset: 0x00067D9C
	private void Start()
	{
		this.animRoutine = base.StartCoroutine(this.Animate());
		HealthCocoon.FlingPrefab[] array = this.flingPrefabs;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].SetupPool(base.transform);
		}
	}

	// Token: 0x0600165F RID: 5727 RVA: 0x00069BDE File Offset: 0x00067DDE
	private void PlaySound(AudioClip clip)
	{
		if (this.source && clip)
		{
			this.source.PlayOneShot(clip);
		}
	}

	// Token: 0x06001660 RID: 5728 RVA: 0x00069C01 File Offset: 0x00067E01
	private IEnumerator Animate()
	{
		for (;;)
		{
			yield return new WaitForSeconds(UnityEngine.Random.Range(this.waitMin, this.waitMax));
			this.PlaySound(this.moveSound);
			if (this.animator)
			{
				tk2dSpriteAnimationClip clipByName = this.animator.GetClipByName(this.sweatAnimation);
				this.animator.Play(clipByName);
				yield return new WaitForSeconds((float)clipByName.frames.Length / clipByName.fps);
				this.animator.Play(this.idleAnimation);
			}
		}
		yield break;
	}

	// Token: 0x06001661 RID: 5729 RVA: 0x00069C10 File Offset: 0x00067E10
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (!this.activated)
		{
			bool flag = false;
			if (collision.tag == "Nail Attack")
			{
				flag = true;
				float value = PlayMakerFSM.FindFsmOnGameObject(collision.gameObject, "damages_enemy").FsmVariables.FindFsmFloat("direction").Value;
				float z = 0f;
				Vector2 v = new Vector2(1.5f, 1.5f);
				if (value < 45f)
				{
					z = (float)UnityEngine.Random.Range(340, 380);
				}
				else if (value < 135f)
				{
					z = (float)UnityEngine.Random.Range(340, 380);
				}
				else if (value < 225f)
				{
					v.x *= -1f;
					z = (float)UnityEngine.Random.Range(70, 110);
				}
				else if (value < 360f)
				{
					z = (float)UnityEngine.Random.Range(250, 290);
				}
				GameObject[] array = this.slashEffects;
				for (int i = 0; i < array.Length; i++)
				{
					GameObject gameObject = array[i].Spawn(base.transform.position + this.effectOrigin);
					gameObject.transform.eulerAngles = new Vector3(0f, 0f, z);
					gameObject.transform.localScale = v;
				}
			}
			if (collision.tag == "Hero Spell")
			{
				flag = true;
				GameObject[] array = this.spellEffects;
				for (int i = 0; i < array.Length; i++)
				{
					GameObject gameObject2 = array[i].Spawn(base.transform.position + this.effectOrigin);
					Vector3 position = gameObject2.transform.position;
					position.z = 0.0031f;
					gameObject2.transform.position = position;
				}
			}
			if (flag)
			{
				this.activated = true;
				GameObject[] array = this.enableChildren;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].SetActive(true);
				}
				if (this.cap)
				{
					this.cap.gameObject.SetActive(true);
					Vector3 a = base.transform.position - collision.transform.position;
					a.Normalize();
					this.cap.AddForce(this.capHitForce * a, ForceMode2D.Impulse);
				}
				foreach (HealthCocoon.FlingPrefab fling in this.flingPrefabs)
				{
					this.FlingObjects(fling);
				}
				this.PlaySound(this.deathSound);
				this.SetBroken();
				GameManager.instance.AddToCocoonList();
				GameCameras gameCameras = UnityEngine.Object.FindObjectOfType<GameCameras>();
				if (gameCameras)
				{
					gameCameras.cameraShakeFSM.SendEvent("EnemyKillShake");
				}
			}
		}
	}

	// Token: 0x06001662 RID: 5730 RVA: 0x00069EC8 File Offset: 0x000680C8
	private void SetBroken()
	{
		base.StopCoroutine(this.animRoutine);
		base.GetComponent<MeshRenderer>().enabled = false;
		GameObject[] array = this.disableChildren;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].SetActive(false);
		}
		Collider2D[] array2 = this.disableColliders;
		for (int i = 0; i < array2.Length; i++)
		{
			array2[i].enabled = false;
		}
	}

	// Token: 0x06001663 RID: 5731 RVA: 0x00069F2C File Offset: 0x0006812C
	private void FlingObjects(HealthCocoon.FlingPrefab fling)
	{
		if (fling.prefab)
		{
			int num = UnityEngine.Random.Range(fling.minAmount, fling.maxAmount + 1);
			for (int i = 1; i <= num; i++)
			{
				GameObject gameObject = fling.Spawn();
				gameObject.transform.position += new Vector3(fling.originVariation.x * UnityEngine.Random.Range(-1f, 1f), fling.originVariation.y * UnityEngine.Random.Range(-1f, 1f));
				float num2 = UnityEngine.Random.Range(fling.minSpeed, fling.maxSpeed);
				float num3 = UnityEngine.Random.Range(fling.minAngle, fling.maxAngle);
				float x = num2 * Mathf.Cos(num3 * 0.017453292f);
				float y = num2 * Mathf.Sin(num3 * 0.017453292f);
				Vector2 velocity;
				velocity.x = x;
				velocity.y = y;
				Rigidbody2D component = gameObject.GetComponent<Rigidbody2D>();
				if (component)
				{
					component.velocity = velocity;
				}
			}
		}
	}

	// Token: 0x06001664 RID: 5732 RVA: 0x0006A034 File Offset: 0x00068234
	public void SetScuttlerAmount(int amount)
	{
		foreach (HealthCocoon.FlingPrefab flingPrefab in this.flingPrefabs)
		{
			if (flingPrefab.prefab.name == "Health Scuttler")
			{
				HealthCocoon.FlingPrefab flingPrefab2 = flingPrefab;
				flingPrefab.maxAmount = amount;
				flingPrefab2.minAmount = amount;
				flingPrefab.SetupPool(base.transform);
				return;
			}
		}
	}

	// Token: 0x06001665 RID: 5733 RVA: 0x0006A090 File Offset: 0x00068290
	public HealthCocoon()
	{
		this.effectOrigin = new Vector3(0f, 0.8f, 0f);
		this.capHitForce = 10f;
		this.idleAnimation = "Cocoon Idle";
		this.sweatAnimation = "Cocoon Sweat";
		this.waitMin = 2f;
		this.waitMax = 6f;
		base..ctor();
	}

	// Token: 0x04001ADC RID: 6876
	[Header("Behaviour")]
	public GameObject[] slashEffects;

	// Token: 0x04001ADD RID: 6877
	public GameObject[] spellEffects;

	// Token: 0x04001ADE RID: 6878
	public Vector3 effectOrigin;

	// Token: 0x04001ADF RID: 6879
	[Space]
	public HealthCocoon.FlingPrefab[] flingPrefabs;

	// Token: 0x04001AE0 RID: 6880
	[Space]
	public GameObject[] enableChildren;

	// Token: 0x04001AE1 RID: 6881
	public GameObject[] disableChildren;

	// Token: 0x04001AE2 RID: 6882
	public Collider2D[] disableColliders;

	// Token: 0x04001AE3 RID: 6883
	[Space]
	public Rigidbody2D cap;

	// Token: 0x04001AE4 RID: 6884
	public float capHitForce;

	// Token: 0x04001AE5 RID: 6885
	[Space]
	public AudioClip deathSound;

	// Token: 0x04001AE6 RID: 6886
	private bool activated;

	// Token: 0x04001AE7 RID: 6887
	[Header("Animation")]
	public string idleAnimation;

	// Token: 0x04001AE8 RID: 6888
	public string sweatAnimation;

	// Token: 0x04001AE9 RID: 6889
	public AudioClip moveSound;

	// Token: 0x04001AEA RID: 6890
	public float waitMin;

	// Token: 0x04001AEB RID: 6891
	public float waitMax;

	// Token: 0x04001AEC RID: 6892
	private Coroutine animRoutine;

	// Token: 0x04001AED RID: 6893
	private AudioSource source;

	// Token: 0x04001AEE RID: 6894
	private tk2dSpriteAnimator animator;

	// Token: 0x020003D0 RID: 976
	[Serializable]
	public class FlingPrefab
	{
		// Token: 0x06001668 RID: 5736 RVA: 0x0006A118 File Offset: 0x00068318
		public void SetupPool(Transform parent)
		{
			if (this.prefab)
			{
				this.pool.Capacity = this.maxAmount;
				for (int i = this.pool.Count; i < this.maxAmount; i++)
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.prefab, parent);
					gameObject.transform.localPosition = Vector3.zero;
					gameObject.SetActive(false);
					this.pool.Add(gameObject);
				}
			}
		}

		// Token: 0x06001669 RID: 5737 RVA: 0x0006A190 File Offset: 0x00068390
		public GameObject Spawn()
		{
			foreach (GameObject gameObject in this.pool)
			{
				if (!gameObject.activeSelf)
				{
					gameObject.SetActive(true);
					return gameObject;
				}
			}
			return null;
		}

		// Token: 0x0600166A RID: 5738 RVA: 0x0006A1F4 File Offset: 0x000683F4
		public FlingPrefab()
		{
			this.pool = new List<GameObject>();
			this.originVariation = new Vector2(0.5f, 0.5f);
			base..ctor();
		}

		// Token: 0x04001AEF RID: 6895
		public GameObject prefab;

		// Token: 0x04001AF0 RID: 6896
		private List<GameObject> pool;

		// Token: 0x04001AF1 RID: 6897
		public int minAmount;

		// Token: 0x04001AF2 RID: 6898
		public int maxAmount;

		// Token: 0x04001AF3 RID: 6899
		public Vector2 originVariation;

		// Token: 0x04001AF4 RID: 6900
		public float minSpeed;

		// Token: 0x04001AF5 RID: 6901
		public float maxSpeed;

		// Token: 0x04001AF6 RID: 6902
		public float minAngle;

		// Token: 0x04001AF7 RID: 6903
		public float maxAngle;
	}
}
