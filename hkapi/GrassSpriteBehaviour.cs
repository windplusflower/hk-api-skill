using System;
using UnityEngine;

// Token: 0x02000136 RID: 310
public class GrassSpriteBehaviour : MonoBehaviour
{
	// Token: 0x0600073C RID: 1852 RVA: 0x000296E8 File Offset: 0x000278E8
	private void Awake()
	{
		this.animator = base.GetComponent<Animator>();
		this.source = base.GetComponent<AudioSource>();
	}

	// Token: 0x0600073D RID: 1853 RVA: 0x00029702 File Offset: 0x00027902
	private void Start()
	{
		if (Mathf.Abs(base.transform.position.z - 0.004f) > 1.8f)
		{
			this.interaction = false;
		}
		this.Init();
	}

	// Token: 0x0600073E RID: 1854 RVA: 0x00029733 File Offset: 0x00027933
	private void OnBecameVisible()
	{
		this.visible = true;
	}

	// Token: 0x0600073F RID: 1855 RVA: 0x0002973C File Offset: 0x0002793C
	private void OnBecameInvisible()
	{
		this.visible = false;
	}

	// Token: 0x06000740 RID: 1856 RVA: 0x00029748 File Offset: 0x00027948
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (!this.isCut && this.interaction && this.visible)
		{
			if (GrassCut.ShouldCut(collision))
			{
				this.animator.Play(this.cutAnimation);
				this.isCut = true;
				if (this.isWindy && this.deathParticlesWindy)
				{
					this.deathParticlesWindy.SetActive(true);
				}
				else if (this.deathParticles)
				{
					this.deathParticles.SetActive(true);
				}
				if (this.source && this.cutSounds.Length != 0)
				{
					this.source.PlayOneShot(this.cutSounds[UnityEngine.Random.Range(0, this.cutSounds.Length)]);
				}
				if (this.cutEffectPrefab)
				{
					int num = (int)Mathf.Sign(collision.transform.position.x - base.transform.position.x);
					Vector3 position = (collision.transform.position + base.transform.position) / 2f;
					GameObject gameObject = this.cutEffectPrefab.Spawn(position);
					Vector3 localScale = gameObject.transform.localScale;
					localScale.x = Mathf.Abs(localScale.x) * (float)(-(float)num);
					gameObject.transform.localScale = localScale;
					return;
				}
			}
			else
			{
				if (!this.noPushAnimation)
				{
					this.animator.Play(this.isWindy ? this.pushWindyAnimation : this.pushAnimation);
				}
				if (this.source && this.pushSounds.Length != 0)
				{
					this.source.PlayOneShot(this.pushSounds[UnityEngine.Random.Range(0, this.pushSounds.Length)]);
				}
			}
		}
	}

	// Token: 0x06000741 RID: 1857 RVA: 0x00029902 File Offset: 0x00027B02
	private void Init()
	{
		this.animator.Play(this.isWindy ? this.idleWindyAnimation : this.idleAnimation);
	}

	// Token: 0x06000742 RID: 1858 RVA: 0x00029925 File Offset: 0x00027B25
	public void SetWindy()
	{
		if (this.isCut)
		{
			return;
		}
		this.isWindy = true;
		this.noPushAnimation = true;
		this.Init();
	}

	// Token: 0x06000743 RID: 1859 RVA: 0x00029944 File Offset: 0x00027B44
	public void SetNotWindy()
	{
		if (this.isCut)
		{
			return;
		}
		this.isWindy = false;
		this.noPushAnimation = false;
		this.Init();
	}

	// Token: 0x06000744 RID: 1860 RVA: 0x00029964 File Offset: 0x00027B64
	public GrassSpriteBehaviour()
	{
		this.idleAnimation = "Idle";
		this.pushAnimation = "Push";
		this.cutAnimation = "Dead";
		this.idleWindyAnimation = "WindyIdle";
		this.pushWindyAnimation = "WindyPush";
		this.interaction = true;
		base..ctor();
	}

	// Token: 0x04000800 RID: 2048
	[Header("Variables")]
	public bool isWindy;

	// Token: 0x04000801 RID: 2049
	public bool noPushAnimation;

	// Token: 0x04000802 RID: 2050
	[Space]
	public GameObject deathParticles;

	// Token: 0x04000803 RID: 2051
	public GameObject deathParticlesWindy;

	// Token: 0x04000804 RID: 2052
	public GameObject cutEffectPrefab;

	// Token: 0x04000805 RID: 2053
	[Space]
	public AudioClip[] pushSounds;

	// Token: 0x04000806 RID: 2054
	public AudioClip[] cutSounds;

	// Token: 0x04000807 RID: 2055
	[Header("Animation State Names")]
	public string idleAnimation;

	// Token: 0x04000808 RID: 2056
	public string pushAnimation;

	// Token: 0x04000809 RID: 2057
	public string cutAnimation;

	// Token: 0x0400080A RID: 2058
	[Space]
	public string idleWindyAnimation;

	// Token: 0x0400080B RID: 2059
	public string pushWindyAnimation;

	// Token: 0x0400080C RID: 2060
	private bool isCut;

	// Token: 0x0400080D RID: 2061
	private bool interaction;

	// Token: 0x0400080E RID: 2062
	private bool visible;

	// Token: 0x0400080F RID: 2063
	private Animator animator;

	// Token: 0x04000810 RID: 2064
	private AudioSource source;
}
