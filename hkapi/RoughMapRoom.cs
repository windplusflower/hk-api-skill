using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020004B5 RID: 1205
public class RoughMapRoom : MonoBehaviour
{
	// Token: 0x06001AB3 RID: 6835 RVA: 0x0007F901 File Offset: 0x0007DB01
	private void Start()
	{
		this.gm = GameManager.instance;
		this.pd = PlayerData.instance;
		this.sr = base.GetComponent<SpriteRenderer>();
	}

	// Token: 0x06001AB4 RID: 6836 RVA: 0x0007F928 File Offset: 0x0007DB28
	private void OnEnable()
	{
		if (this.gm == null)
		{
			this.gm = GameManager.instance;
		}
		if (this.sr == null)
		{
			this.sr = base.GetComponent<SpriteRenderer>();
		}
		if (!this.fullSpriteDisplayed && (this.gm.playerData.GetVariable<List<string>>("scenesMapped").Contains(base.transform.name) || this.gm.playerData.GetBool("mapAllRooms")))
		{
			this.sr.sprite = this.fullSprite;
			this.fullSpriteDisplayed = true;
		}
	}

	// Token: 0x04002002 RID: 8194
	public Sprite fullSprite;

	// Token: 0x04002003 RID: 8195
	public PlayerData pd;

	// Token: 0x04002004 RID: 8196
	private GameManager gm;

	// Token: 0x04002005 RID: 8197
	private SpriteRenderer sr;

	// Token: 0x04002006 RID: 8198
	public bool fullSpriteDisplayed;
}
