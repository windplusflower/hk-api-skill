using System;
using System.Collections;
using UnityEngine;

// Token: 0x020002BB RID: 699
public class SpawnJarControl : MonoBehaviour
{
	// Token: 0x06000ED5 RID: 3797 RVA: 0x000495BB File Offset: 0x000477BB
	private void Awake()
	{
		this.col = base.GetComponent<CircleCollider2D>();
		this.body = base.GetComponent<Rigidbody2D>();
		this.sprite = base.GetComponent<SpriteRenderer>();
	}

	// Token: 0x06000ED6 RID: 3798 RVA: 0x000495E1 File Offset: 0x000477E1
	private void OnEnable()
	{
		this.col.enabled = false;
		this.sprite.enabled = false;
		base.StartCoroutine(this.Behaviour());
	}

	// Token: 0x06000ED7 RID: 3799 RVA: 0x00049608 File Offset: 0x00047808
	private IEnumerator Behaviour()
	{
		this.transform.SetPositionY(this.spawnY);
		this.transform.SetPositionZ(0.01f);
		this.readyDust.Play();
		yield return new WaitForSeconds(0.5f);
		this.col.enabled = true;
		this.body.velocity = new Vector2(0f, -25f);
		this.body.angularVelocity = (float)((UnityEngine.Random.Range(0, 2) > 0) ? -300 : 300);
		this.readyDust.Stop();
		this.dustTrail.Play();
		this.sprite.enabled = true;
		while (this.transform.position.y > this.breakY)
		{
			yield return null;
		}
		this.transform.SetPositionY(this.breakY);
		GameCameras.instance.cameraShakeFSM.SendEvent("EnemyKillShake");
		this.dustTrail.Stop();
		this.ptBreakS.Play();
		this.ptBreakL.Play();
		this.strikeNailR.Spawn(this.transform.position);
		this.col.enabled = false;
		this.body.velocity = Vector2.zero;
		this.body.angularVelocity = 0f;
		this.sprite.enabled = false;
		this.breakSound.SpawnAndPlayOneShot(this.audioSourcePrefab, this.transform.position);
		if (this.enemyToSpawn)
		{
			GameObject gameObject = this.enemyToSpawn.Spawn(this.transform.position);
			HealthManager component = gameObject.GetComponent<HealthManager>();
			if (component)
			{
				component.hp = this.enemyHealth;
			}
			gameObject.tag = "Boss";
		}
		yield return new WaitForSeconds(2f);
		this.gameObject.Recycle();
		yield break;
	}

	// Token: 0x06000ED8 RID: 3800 RVA: 0x00049617 File Offset: 0x00047817
	public void SetEnemySpawn(GameObject prefab, int health)
	{
		this.enemyToSpawn = prefab;
		this.enemyHealth = health;
	}

	// Token: 0x06000ED9 RID: 3801 RVA: 0x00049627 File Offset: 0x00047827
	public SpawnJarControl()
	{
		this.spawnY = 106.52f;
		this.breakY = 94.55f;
		base..ctor();
	}

	// Token: 0x04000F92 RID: 3986
	public float spawnY;

	// Token: 0x04000F93 RID: 3987
	public float breakY;

	// Token: 0x04000F94 RID: 3988
	public ParticleSystem readyDust;

	// Token: 0x04000F95 RID: 3989
	public ParticleSystem dustTrail;

	// Token: 0x04000F96 RID: 3990
	public ParticleSystem ptBreakS;

	// Token: 0x04000F97 RID: 3991
	public ParticleSystem ptBreakL;

	// Token: 0x04000F98 RID: 3992
	public GameObject strikeNailR;

	// Token: 0x04000F99 RID: 3993
	public AudioEventRandom breakSound;

	// Token: 0x04000F9A RID: 3994
	public AudioSource audioSourcePrefab;

	// Token: 0x04000F9B RID: 3995
	private GameObject enemyToSpawn;

	// Token: 0x04000F9C RID: 3996
	private int enemyHealth;

	// Token: 0x04000F9D RID: 3997
	private CircleCollider2D col;

	// Token: 0x04000F9E RID: 3998
	private Rigidbody2D body;

	// Token: 0x04000F9F RID: 3999
	private SpriteRenderer sprite;
}
