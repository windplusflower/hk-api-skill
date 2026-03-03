using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000262 RID: 610
public class BossStatueFlashEffect : MonoBehaviour
{
	// Token: 0x14000016 RID: 22
	// (add) Token: 0x06000CD4 RID: 3284 RVA: 0x00041054 File Offset: 0x0003F254
	// (remove) Token: 0x06000CD5 RID: 3285 RVA: 0x0004108C File Offset: 0x0003F28C
	public event BossStatueFlashEffect.FlashCompleteDelegate OnFlashBegin;

	// Token: 0x06000CD6 RID: 3286 RVA: 0x000410C1 File Offset: 0x0003F2C1
	private void Awake()
	{
		this.parentStatue = base.GetComponentInParent<BossStatue>();
		this.animator = base.GetComponent<Animator>();
	}

	// Token: 0x06000CD7 RID: 3287 RVA: 0x000410DC File Offset: 0x0003F2DC
	private void Start()
	{
		if (this.templateSprite)
		{
			this.templateSprite.transform.localPosition += new Vector3(0f, -2000f, 0f);
			this.mat = new Material(this.templateSprite.sharedMaterial);
		}
		if (!this.parentStatue.StatueState.hasBeenSeen && !this.parentStatue.isAlwaysUnlocked)
		{
			if (this.statueSpritesParent)
			{
				this.statueSprites = this.statueSpritesParent.GetComponentsInChildren<SpriteRenderer>();
				foreach (SpriteRenderer spriteRenderer in this.statueSprites)
				{
					spriteRenderer.color = Color.clear;
					spriteRenderer.sharedMaterial = this.mat;
				}
			}
			if (this.triggerEvent)
			{
				TriggerEnterEvent.CollisionEvent temp = null;
				temp = delegate(Collider2D collider, GameObject sender)
				{
					this.gameObject.SetActive(true);
					this.statueSpritesParent.SetActive(true);
					if (this.inspect)
					{
						this.inspect.SetActive(false);
					}
					this.StartCoroutine(this.FlashRoutine());
					this.triggerEvent.OnTriggerEntered -= temp;
				};
				this.triggerEvent.OnTriggerEntered += temp;
			}
		}
		this.propBlock = new MaterialPropertyBlock();
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000CD8 RID: 3288 RVA: 0x00041207 File Offset: 0x0003F407
	private IEnumerator FlashRoutine()
	{
		if (this.OnFlashBegin != null)
		{
			this.OnFlashBegin();
		}
		this.animator.cullingMode = AnimatorCullingMode.AlwaysAnimate;
		float duration = this.animator.GetCurrentAnimatorStateInfo(0).length;
		for (float elapsed = 0f; elapsed <= duration; elapsed += Time.deltaTime)
		{
			SpriteRenderer[] array = this.statueSprites;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].color = this.templateSprite.color;
			}
			this.templateSprite.GetPropertyBlock(this.propBlock);
			this.mat.SetFloat("_FlashAmount", this.propBlock.GetFloat("_FlashAmount"));
			yield return null;
		}
		yield return null;
		this.animator.enabled = false;
		SpriteFadeMaterial component = this.statueSpritesParent.GetComponent<SpriteFadeMaterial>();
		if (component)
		{
			component.FadeBack();
		}
		yield break;
	}

	// Token: 0x06000CD9 RID: 3289 RVA: 0x00041216 File Offset: 0x0003F416
	public void FlashApex()
	{
		if (this.inspect)
		{
			this.inspect.SetActive(true);
		}
		this.parentStatue.SetPlaquesVisible(true);
	}

	// Token: 0x04000DC8 RID: 3528
	public SpriteRenderer templateSprite;

	// Token: 0x04000DC9 RID: 3529
	public GameObject statueSpritesParent;

	// Token: 0x04000DCA RID: 3530
	private SpriteRenderer[] statueSprites;

	// Token: 0x04000DCB RID: 3531
	public GameObject inspect;

	// Token: 0x04000DCC RID: 3532
	public TriggerEnterEvent triggerEvent;

	// Token: 0x04000DCD RID: 3533
	private BossStatue parentStatue;

	// Token: 0x04000DCE RID: 3534
	private Animator animator;

	// Token: 0x04000DCF RID: 3535
	private Material mat;

	// Token: 0x04000DD0 RID: 3536
	private MaterialPropertyBlock propBlock;

	// Token: 0x02000263 RID: 611
	// (Invoke) Token: 0x06000CDC RID: 3292
	public delegate void FlashCompleteDelegate();
}
