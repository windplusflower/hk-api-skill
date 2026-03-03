using System;
using UnityEngine;

// Token: 0x0200046E RID: 1134
public class JournalEntryStats : MonoBehaviour
{
	// Token: 0x06001965 RID: 6501 RVA: 0x0007917C File Offset: 0x0007737C
	private void Awake()
	{
		foreach (object obj in base.transform)
		{
			((Transform)obj).gameObject.SetActive(false);
		}
		this.hidden = true;
		this.pd = PlayerData.instance;
		this.posOriginalY = base.transform.localPosition.y;
		this.posUpY = this.posOriginalY + 0.8f;
		this.posDownY = this.posOriginalY - 0.8f;
		this.portrait = base.transform.Find("Portrait").gameObject;
		this.nameObject = base.transform.Find("Name").gameObject;
		this.frame = UnityEngine.Object.Instantiate<GameObject>(this.frameObject);
		this.frame.transform.parent = this.portrait.transform;
		this.frame.transform.localPosition = new Vector3(0f, 0f, -0.0001f);
		this.frame.transform.localScale = new Vector3(1f, 1f, 1f);
		this.portrait.SetActive(false);
		this.newDot = UnityEngine.Object.Instantiate<GameObject>(this.newDotObject);
		this.newDot.transform.parent = base.transform;
		this.newDot.transform.localPosition = new Vector3(-0.65f, 0f, -0.0001f);
		this.newDot.SetActive(false);
		this.dotTransform = this.newDot.transform;
		this.nameConvo = "NAME_" + this.convoName;
		this.descConvo = "DESC_" + this.convoName;
		this.notesConvo = "NOTE_" + this.convoName;
		this.playerDataKillsName = "kills" + this.playerDataName;
		this.playerDataBoolName = "killed" + this.playerDataName;
		this.playerDataNewDataName = "newData" + this.playerDataName;
	}

	// Token: 0x06001966 RID: 6502 RVA: 0x000793C8 File Offset: 0x000775C8
	private void OnEnable()
	{
		foreach (object obj in base.transform)
		{
			((Transform)obj).gameObject.SetActive(false);
		}
		this.hidden = true;
		if (!this.frameVisible && this.pd.GetInt(this.playerDataKillsName) <= 0)
		{
			this.frame.GetComponent<SpriteRenderer>().enabled = true;
			this.frameVisible = true;
		}
		if (!this.dotVisible && this.pd.GetBool(this.playerDataNewDataName))
		{
			this.newDot.GetComponent<SpriteRenderer>().enabled = true;
			this.dotVisible = true;
		}
	}

	// Token: 0x06001967 RID: 6503 RVA: 0x00079494 File Offset: 0x00077694
	private void OnDisable()
	{
		if (!this.dotVisible)
		{
			this.newDot.GetComponent<SpriteRenderer>().enabled = false;
		}
		this.shrinkingDot = false;
	}

	// Token: 0x06001968 RID: 6504 RVA: 0x000794B8 File Offset: 0x000776B8
	private void Update()
	{
		float y = base.transform.position.y;
		if (y > this.topY || y < this.botY)
		{
			if (!this.hidden)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(false);
				}
				this.hidden = true;
			}
		}
		else if (this.hidden)
		{
			foreach (object obj2 in base.transform)
			{
				((Transform)obj2).gameObject.SetActive(true);
			}
			this.hidden = false;
		}
		if (!this.hidden)
		{
			if (y < this.centreBotY)
			{
				this.portrait.transform.localPosition = new Vector3(0f, -0.778f, 0f);
				this.portrait.transform.localScale = this.scaleSmall;
				this.nameObject.transform.localPosition = new Vector3(2.16f, -0.769f, 0f);
				this.newDot.transform.localPosition = new Vector3(-0.65f, -0.8f, -0.0001f);
			}
			else if (y > this.centreTopY)
			{
				this.portrait.transform.localPosition = new Vector3(0f, 0.822f, 0f);
				this.portrait.transform.localScale = this.scaleSmall;
				this.nameObject.transform.localPosition = new Vector3(2.16f, 0.831f, 0f);
				this.newDot.transform.localPosition = new Vector3(-0.65f, 0.8f, -0.0001f);
			}
			else
			{
				this.portrait.transform.localPosition = new Vector3(0f, 0.022f, 0f);
				this.portrait.transform.localScale = this.scaleNormal;
				this.nameObject.transform.localPosition = new Vector3(2.16f, 0.031f, 0f);
				this.newDot.transform.localPosition = new Vector3(-0.65f, 0f, -0.0001f);
				if (this.dotVisible)
				{
					this.shrinkingDot = true;
					this.dotVisible = false;
					this.pd.SetBool(this.playerDataNewDataName, false);
				}
			}
		}
		if (this.shrinkingDot)
		{
			this.dotScale -= Time.deltaTime * 3f;
			this.dotTransform.localScale = new Vector3(this.dotScale, this.dotScale, this.dotScale);
			if (this.dotScale <= 0f)
			{
				this.newDot.GetComponent<SpriteRenderer>().enabled = false;
				this.shrinkingDot = false;
			}
		}
	}

	// Token: 0x06001969 RID: 6505 RVA: 0x000797E8 File Offset: 0x000779E8
	public string GetNameConvo()
	{
		return this.nameConvo;
	}

	// Token: 0x0600196A RID: 6506 RVA: 0x000797F0 File Offset: 0x000779F0
	public string GetDescConvo()
	{
		return this.descConvo;
	}

	// Token: 0x0600196B RID: 6507 RVA: 0x000797F8 File Offset: 0x000779F8
	public string GetNotesConvo()
	{
		return this.notesConvo;
	}

	// Token: 0x0600196C RID: 6508 RVA: 0x00079800 File Offset: 0x00077A00
	public string GetPlayerDataBoolName()
	{
		return this.playerDataBoolName;
	}

	// Token: 0x0600196D RID: 6509 RVA: 0x00079808 File Offset: 0x00077A08
	public string GetPlayerDataKillsName()
	{
		return this.playerDataKillsName;
	}

	// Token: 0x0600196E RID: 6510 RVA: 0x00079810 File Offset: 0x00077A10
	public string GetPlayerDataNewDataName()
	{
		return this.playerDataNewDataName;
	}

	// Token: 0x0600196F RID: 6511 RVA: 0x00079818 File Offset: 0x00077A18
	public int GetItemNumber()
	{
		return this.itemNumber;
	}

	// Token: 0x06001970 RID: 6512 RVA: 0x00079820 File Offset: 0x00077A20
	public Sprite GetSprite()
	{
		return this.sprite;
	}

	// Token: 0x06001971 RID: 6513 RVA: 0x00079828 File Offset: 0x00077A28
	public bool GetWarriorGhost()
	{
		return this.warriorGhost;
	}

	// Token: 0x06001972 RID: 6514 RVA: 0x00079830 File Offset: 0x00077A30
	public bool GetGrimm()
	{
		return this.grimmEntry;
	}

	// Token: 0x06001973 RID: 6515 RVA: 0x00079838 File Offset: 0x00077A38
	public JournalEntryStats()
	{
		this.topY = 5.78f;
		this.botY = -6.49f;
		this.hidden = true;
		this.scaleNormal = new Vector3(0.634f, 0.634f, 0.634f);
		this.scaleSmall = new Vector3(0.5f, 0.5f, 0.5f);
		this.centreTopY = 1.2f;
		this.centreBotY = -0.38f;
		this.dotScale = 0.48f;
		base..ctor();
	}

	// Token: 0x04001E84 RID: 7812
	public GameObject frameObject;

	// Token: 0x04001E85 RID: 7813
	public GameObject newDotObject;

	// Token: 0x04001E86 RID: 7814
	public string playerDataName;

	// Token: 0x04001E87 RID: 7815
	public string convoName;

	// Token: 0x04001E88 RID: 7816
	public Sprite sprite;

	// Token: 0x04001E89 RID: 7817
	public bool warriorGhost;

	// Token: 0x04001E8A RID: 7818
	public bool grimmEntry;

	// Token: 0x04001E8B RID: 7819
	[Space(10f)]
	[Header("Below variables don't need to be filled out")]
	[Space(5f)]
	public string nameConvo;

	// Token: 0x04001E8C RID: 7820
	public string descConvo;

	// Token: 0x04001E8D RID: 7821
	public string notesConvo;

	// Token: 0x04001E8E RID: 7822
	public string playerDataKillsName;

	// Token: 0x04001E8F RID: 7823
	public string playerDataBoolName;

	// Token: 0x04001E90 RID: 7824
	public string playerDataNewDataName;

	// Token: 0x04001E91 RID: 7825
	public int itemNumber;

	// Token: 0x04001E92 RID: 7826
	private PlayerData pd;

	// Token: 0x04001E93 RID: 7827
	private float timer;

	// Token: 0x04001E94 RID: 7828
	private float topY;

	// Token: 0x04001E95 RID: 7829
	private float botY;

	// Token: 0x04001E96 RID: 7830
	private bool hidden;

	// Token: 0x04001E97 RID: 7831
	private float posOriginalY;

	// Token: 0x04001E98 RID: 7832
	private float posUpY;

	// Token: 0x04001E99 RID: 7833
	private float posDownY;

	// Token: 0x04001E9A RID: 7834
	private Vector3 scaleNormal;

	// Token: 0x04001E9B RID: 7835
	private Vector3 scaleSmall;

	// Token: 0x04001E9C RID: 7836
	private float centreTopY;

	// Token: 0x04001E9D RID: 7837
	private float centreBotY;

	// Token: 0x04001E9E RID: 7838
	private GameObject portrait;

	// Token: 0x04001E9F RID: 7839
	private GameObject nameObject;

	// Token: 0x04001EA0 RID: 7840
	private GameObject frame;

	// Token: 0x04001EA1 RID: 7841
	private GameObject newDot;

	// Token: 0x04001EA2 RID: 7842
	private bool frameVisible;

	// Token: 0x04001EA3 RID: 7843
	private bool dotVisible;

	// Token: 0x04001EA4 RID: 7844
	private bool shrinkingDot;

	// Token: 0x04001EA5 RID: 7845
	private float dotScale;

	// Token: 0x04001EA6 RID: 7846
	private Transform dotTransform;
}
