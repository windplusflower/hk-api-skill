using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x0200043E RID: 1086
public class CharmDisplay : MonoBehaviour
{
	// Token: 0x06001875 RID: 6261 RVA: 0x00072C80 File Offset: 0x00070E80
	private void Reset()
	{
		if (!this.spriteRenderer)
		{
			this.spriteRenderer = base.GetComponent<SpriteRenderer>();
		}
		if (!this.flashSpriteRenderer)
		{
			Transform transform = base.transform.Find("Flash Sprite");
			if (transform)
			{
				this.flashSpriteRenderer = transform.GetComponent<SpriteRenderer>();
			}
		}
	}

	// Token: 0x06001876 RID: 6262 RVA: 0x00072CD8 File Offset: 0x00070ED8
	private void Start()
	{
		Sprite sprite;
		if (this.id == 23 && GameManager.instance.playerData.GetBool("brokenCharm_23"))
		{
			sprite = this.brokenGlassHP;
		}
		else if (this.id == 24 && GameManager.instance.playerData.GetBool("brokenCharm_24"))
		{
			sprite = this.brokenGlassGeo;
		}
		else if (this.id == 25 && GameManager.instance.playerData.GetBool("brokenCharm_25"))
		{
			sprite = this.brokenGlassAttack;
		}
		else if (this.id == 36)
		{
			if (GameManager.instance.playerData.GetInt("royalCharmState") <= 3)
			{
				sprite = this.whiteCharm;
			}
			else
			{
				sprite = this.blackCharm;
			}
		}
		else
		{
			sprite = CharmIconList.Instance.GetSprite(this.id);
		}
		if (this.spriteRenderer)
		{
			this.spriteRenderer.sprite = sprite;
		}
		if (this.flashSpriteRenderer)
		{
			this.flashSpriteRenderer.sprite = sprite;
		}
		this.Check();
	}

	// Token: 0x06001877 RID: 6263 RVA: 0x00072DE4 File Offset: 0x00070FE4
	public void Check()
	{
		if (CharmDisplay.charmsMenuFsm == null)
		{
			GameObject gameObject = GameObject.FindWithTag("Charms Pane");
			if (gameObject)
			{
				CharmDisplay.charmsMenuFsm = PlayMakerFSM.FindFsmOnGameObject(gameObject, "UI Charms");
			}
		}
		if (CharmDisplay.charmsMenuFsm)
		{
			FsmString fsmString = CharmDisplay.charmsMenuFsm.FsmVariables.FindFsmString("Newly Equipped Name");
			if (fsmString != null && fsmString.Value == base.gameObject.name)
			{
				fsmString.Value = "none";
				if (this.charmPlaceEffect)
				{
					this.charmPlaceEffect.Spawn(base.transform.position + new Vector3(0f, 0f, -1f));
					if (this.flashSpriteRenderer)
					{
						this.flashSpriteRenderer.gameObject.SetActive(true);
					}
				}
			}
		}
		if (GameManager.instance.playerData.GetBool("overcharmed"))
		{
			this.startPos = base.transform.localPosition;
			this.doJitter = true;
		}
	}

	// Token: 0x06001878 RID: 6264 RVA: 0x00072EF8 File Offset: 0x000710F8
	private void FixedUpdate()
	{
		if (this.doJitter)
		{
			base.transform.localPosition = new Vector3(this.startPos.x + UnityEngine.Random.Range(-0.075f, 0.075f), this.startPos.y + UnityEngine.Random.Range(-0.075f, 0.075f), this.startPos.z);
		}
	}

	// Token: 0x04001D44 RID: 7492
	public int id;

	// Token: 0x04001D45 RID: 7493
	public SpriteRenderer spriteRenderer;

	// Token: 0x04001D46 RID: 7494
	public SpriteRenderer flashSpriteRenderer;

	// Token: 0x04001D47 RID: 7495
	[Space]
	public Sprite brokenGlassHP;

	// Token: 0x04001D48 RID: 7496
	public Sprite brokenGlassGeo;

	// Token: 0x04001D49 RID: 7497
	public Sprite brokenGlassAttack;

	// Token: 0x04001D4A RID: 7498
	public Sprite whiteCharm;

	// Token: 0x04001D4B RID: 7499
	public Sprite blackCharm;

	// Token: 0x04001D4C RID: 7500
	public GameObject charmPlaceEffect;

	// Token: 0x04001D4D RID: 7501
	private static PlayMakerFSM charmsMenuFsm;

	// Token: 0x04001D4E RID: 7502
	private bool doJitter;

	// Token: 0x04001D4F RID: 7503
	private Vector3 startPos;

	// Token: 0x04001D50 RID: 7504
	private const float jitterX = 0.075f;

	// Token: 0x04001D51 RID: 7505
	private const float jitterY = 0.075f;
}
