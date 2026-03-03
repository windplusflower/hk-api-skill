using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000190 RID: 400
[RequireComponent(typeof(tk2dSprite))]
public class EnemySpawner : MonoBehaviour
{
	// Token: 0x1400000D RID: 13
	// (add) Token: 0x060008F4 RID: 2292 RVA: 0x00031F68 File Offset: 0x00030168
	// (remove) Token: 0x060008F5 RID: 2293 RVA: 0x00031FA0 File Offset: 0x000301A0
	public event Action<GameObject> OnEnemySpawned;

	// Token: 0x060008F6 RID: 2294 RVA: 0x00031FD8 File Offset: 0x000301D8
	private void Awake()
	{
		this.sprite = base.GetComponent<tk2dSprite>();
		this.sprite.color = this.startColor;
		if (this.enemyPrefab)
		{
			this.spawnedEnemy = UnityEngine.Object.Instantiate<GameObject>(this.enemyPrefab);
			this.spawnedEnemy.SetActive(false);
		}
	}

	// Token: 0x060008F7 RID: 2295 RVA: 0x0003202C File Offset: 0x0003022C
	private void Start()
	{
		if (UnityEngine.Random.Range(0f, 1f) <= this.spawnChance)
		{
			if (this.killEvent)
			{
				this.killEvent.OnReceivedEvent += delegate()
				{
					base.gameObject.SetActive(false);
				};
			}
			Hashtable hashtable = new Hashtable();
			hashtable.Add("amount", this.moveBy);
			hashtable.Add("time", this.easeTime);
			hashtable.Add("easetype", this.easeType);
			hashtable.Add("space", Space.World);
			iTween.MoveBy(base.gameObject, hashtable);
			return;
		}
		base.gameObject.SetActive(false);
	}

	// Token: 0x060008F8 RID: 2296 RVA: 0x000320EC File Offset: 0x000302EC
	private void Update()
	{
		if (!this.isComplete)
		{
			this.elapsed += Time.deltaTime;
			this.sprite.color = Color.Lerp(this.startColor, this.endColor, Mathf.Clamp(this.elapsed / this.easeTime, 0f, 1f));
			if (this.elapsed > this.easeTime)
			{
				this.isComplete = true;
				this.spawnedEnemy.transform.position = base.transform.position;
				this.spawnedEnemy.transform.localScale = base.transform.localScale;
				this.spawnedEnemy.SetActive(true);
				if (this.OnEnemySpawned != null)
				{
					this.OnEnemySpawned(this.spawnedEnemy);
				}
				PlayMakerFSM playMakerFSM = PlayMakerFSM.FindFsmOnGameObject(this.spawnedEnemy, "chaser");
				if (playMakerFSM)
				{
					playMakerFSM.FsmVariables.FindFsmBool("Start Alert").Value = true;
				}
				base.gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x060008F9 RID: 2297 RVA: 0x000321FC File Offset: 0x000303FC
	public EnemySpawner()
	{
		this.spawnChance = 0.75f;
		this.easeType = iTween.EaseType.easeOutSine;
		this.moveBy = new Vector3(0f, -8f, -16.98f);
		this.easeTime = 1f;
		this.startColor = Color.black;
		this.endColor = Color.white;
		base..ctor();
	}

	// Token: 0x04000A02 RID: 2562
	public GameObject enemyPrefab;

	// Token: 0x04000A03 RID: 2563
	private GameObject spawnedEnemy;

	// Token: 0x04000A04 RID: 2564
	[Range(0f, 1f)]
	public float spawnChance;

	// Token: 0x04000A05 RID: 2565
	public iTween.EaseType easeType;

	// Token: 0x04000A06 RID: 2566
	public Vector3 moveBy;

	// Token: 0x04000A07 RID: 2567
	public float easeTime;

	// Token: 0x04000A08 RID: 2568
	private float elapsed;

	// Token: 0x04000A09 RID: 2569
	private bool isComplete;

	// Token: 0x04000A0A RID: 2570
	public Color startColor;

	// Token: 0x04000A0B RID: 2571
	public Color endColor;

	// Token: 0x04000A0C RID: 2572
	public EventRegister killEvent;

	// Token: 0x04000A0D RID: 2573
	private tk2dSprite sprite;
}
