using System;
using UnityEngine;

// Token: 0x0200045D RID: 1117
public class GeoCounter : MonoBehaviour
{
	// Token: 0x06001926 RID: 6438 RVA: 0x00077EAE File Offset: 0x000760AE
	private void Awake()
	{
		this.geoSpriteFsm = FSMUtility.GetFSM(this.geoSprite);
		this.subTextFsm = FSMUtility.GetFSM(this.subTextMesh.gameObject);
		this.addTextFsm = FSMUtility.GetFSM(this.addTextMesh.gameObject);
	}

	// Token: 0x06001927 RID: 6439 RVA: 0x00077EED File Offset: 0x000760ED
	private void Start()
	{
		this.playerData = PlayerData.instance;
		this.counterCurrent = this.playerData.GetInt("geo");
		this.geoTextMesh.text = this.counterCurrent.ToString();
	}

	// Token: 0x06001928 RID: 6440 RVA: 0x00003603 File Offset: 0x00001803
	public void UpdateGeo()
	{
	}

	// Token: 0x06001929 RID: 6441 RVA: 0x00077F28 File Offset: 0x00076128
	public void NewSceneRefresh()
	{
		this.counterCurrent = this.playerData.GetInt("geo");
		this.geoTextMesh.text = this.counterCurrent.ToString();
		this.toZero = false;
		this.takeRollerState = 0;
		this.addRollerState = 0;
	}

	// Token: 0x0600192A RID: 6442 RVA: 0x00077F78 File Offset: 0x00076178
	public void AddGeo(int geo)
	{
		this.geoSpriteFsm.SendEvent("CHECK FIRST");
		if (this.takeRollerState > 0)
		{
			this.geoChange = geo;
			this.addCounter = this.geoChange;
			this.takeRollerState = 0;
			this.geoSpriteFsm.SendEvent("IDLE");
			this.subTextFsm.SendEvent("DOWN");
			this.counterCurrent = this.playerData.GetInt("geo") + -this.addCounter;
			this.geoTextMesh.text = this.counterCurrent.ToString();
		}
		if (this.addRollerState == 0)
		{
			this.geoChange = geo;
			this.addCounter = this.geoChange;
			this.addTextFsm.SendEvent("UP");
			this.addTextMesh.text = "+ " + this.addCounter.ToString();
			this.addRollerStartTimer = 1.5f;
			this.addRollerState = 1;
		}
		else if (this.addRollerState == 1)
		{
			this.geoChange = geo;
			this.addCounter += this.geoChange;
			this.addTextMesh.text = "+ " + this.addCounter.ToString();
			this.addRollerStartTimer = 1.5f;
		}
		else if (this.addRollerState == 2)
		{
			this.geoChange = geo;
			this.addCounter = this.geoChange;
			this.geoSpriteFsm.SendEvent("IDLE");
			this.counterCurrent = this.playerData.GetInt("geo");
			this.geoTextMesh.text = this.counterCurrent.ToString();
			this.addTextMesh.text = "+ " + this.addCounter.ToString();
			this.addRollerState = 1;
			this.addRollerStartTimer = 1.5f;
		}
		this.changePerTick = (int)((double)((float)this.addCounter * 0.025f) * 1.75);
		if (this.changePerTick < 1)
		{
			this.changePerTick = 1;
		}
	}

	// Token: 0x0600192B RID: 6443 RVA: 0x00078180 File Offset: 0x00076380
	public void TakeGeo(int geo)
	{
		if (this.addRollerState > 0)
		{
			this.geoChange = -geo;
			this.takeCounter = this.geoChange;
			this.addRollerState = 0;
			this.geoSpriteFsm.SendEvent("IDLE");
			this.addTextFsm.SendEvent("DOWN");
			this.counterCurrent = this.playerData.GetInt("geo") + -this.takeCounter;
			this.geoTextMesh.text = this.counterCurrent.ToString();
		}
		if (this.takeRollerState == 0)
		{
			this.geoChange = -geo;
			this.takeCounter = this.geoChange;
			this.subTextFsm.SendEvent("UP");
			this.subTextMesh.text = "- " + (-this.takeCounter).ToString();
			this.takeRollerStartTimer = 1.5f;
			this.takeRollerState = 1;
		}
		else if (this.takeRollerState == 1)
		{
			this.geoChange = -geo;
			this.takeCounter += this.geoChange;
			this.subTextMesh.text = "- " + (-this.takeCounter).ToString();
			this.takeRollerStartTimer = 1.5f;
		}
		else if (this.takeRollerState == 2)
		{
			this.geoChange = -geo;
			this.takeCounter = this.geoChange;
			this.geoSpriteFsm.SendEvent("IDLE");
			this.counterCurrent = this.playerData.GetInt("geo");
			this.geoTextMesh.text = this.counterCurrent.ToString();
			this.subTextMesh.text = "- " + (-this.takeCounter).ToString();
			this.takeRollerState = 1;
			this.takeRollerStartTimer = 1.5f;
		}
		this.changePerTick = (int)((double)((float)this.takeCounter * 0.025f) * 1.75);
		if (this.changePerTick > -1)
		{
			this.changePerTick = -1;
		}
	}

	// Token: 0x0600192C RID: 6444 RVA: 0x00078388 File Offset: 0x00076588
	public void ToZero()
	{
		if (this.counterCurrent == 0)
		{
			this.geoSpriteFsm.SendEvent("SHATTER");
			return;
		}
		this.changePerTick = -(int)((float)this.counterCurrent * 0.025f * 1.75f);
		if (this.changePerTick > -1)
		{
			this.changePerTick = -1;
		}
		this.geoSpriteFsm.SendEvent("TO ZERO");
		this.toZero = true;
	}

	// Token: 0x0600192D RID: 6445 RVA: 0x000783F0 File Offset: 0x000765F0
	private void Update()
	{
		if (this.toZero)
		{
			if (this.digitChangeTimer >= 0f)
			{
				this.digitChangeTimer -= Time.deltaTime;
				return;
			}
			if (this.counterCurrent > 0)
			{
				this.counterCurrent += this.changePerTick;
				if (this.counterCurrent <= 0)
				{
					this.counterCurrent = 0;
					this.geoSpriteFsm.SendEvent("SHATTER");
					this.toZero = false;
				}
				this.geoTextMesh.text = this.counterCurrent.ToString();
				this.digitChangeTimer += 0.025f;
				return;
			}
		}
		else
		{
			if (this.addRollerState == 1)
			{
				if (this.addRollerStartTimer > 0f)
				{
					this.addRollerStartTimer -= Time.deltaTime;
				}
				else
				{
					this.addRollerState = 2;
				}
			}
			if (this.addRollerState == 2 && this.addCounter > 0)
			{
				this.geoSpriteFsm.SendEvent("GET");
				if (this.digitChangeTimer < 0f)
				{
					this.addCounter -= this.changePerTick;
					this.counterCurrent += this.changePerTick;
					this.geoTextMesh.text = this.counterCurrent.ToString();
					if (this.addTextMesh != null)
					{
						this.addTextMesh.text = "+ " + this.addCounter.ToString();
					}
					if (this.addCounter <= 0)
					{
						this.geoSpriteFsm.SendEvent("IDLE");
						this.addCounter = 0;
						this.addTextMesh.text = "+ 0";
						this.addRollerState = 0;
						this.counterCurrent = this.playerData.GetInt("geo");
						this.geoTextMesh.text = this.counterCurrent.ToString();
						this.addTextFsm.SendEvent("DOWN");
					}
					this.digitChangeTimer += 0.025f;
				}
				else
				{
					this.digitChangeTimer -= Time.deltaTime;
				}
			}
			if (this.takeRollerState == 1)
			{
				if (this.takeRollerStartTimer > 0f)
				{
					this.takeRollerStartTimer -= Time.deltaTime;
				}
				else
				{
					this.takeRollerState = 2;
				}
			}
			if (this.takeRollerState == 2 && this.takeCounter < 0)
			{
				this.geoSpriteFsm.SendEvent("TAKE");
				if (this.digitChangeTimer < 0f)
				{
					this.takeCounter -= this.changePerTick;
					this.counterCurrent += this.changePerTick;
					this.geoTextMesh.text = this.counterCurrent.ToString();
					if (this.subTextMesh != null)
					{
						this.subTextMesh.text = "- " + (-this.takeCounter).ToString();
					}
					if (this.takeCounter >= 0)
					{
						this.geoSpriteFsm.SendEvent("IDLE");
						this.takeCounter = 0;
						this.subTextMesh.text = "- 0";
						this.takeRollerState = 0;
						this.counterCurrent = this.playerData.GetInt("geo");
						this.geoTextMesh.text = this.counterCurrent.ToString();
						this.subTextFsm.SendEvent("DOWN");
					}
					this.digitChangeTimer += 0.025f;
					return;
				}
				this.digitChangeTimer -= Time.deltaTime;
			}
		}
	}

	// Token: 0x04001E27 RID: 7719
	private const float ROLLER_START_PAUSE = 1.5f;

	// Token: 0x04001E28 RID: 7720
	private const float DIGIT_CHANGE_TIME = 0.025f;

	// Token: 0x04001E29 RID: 7721
	[HideInInspector]
	public PlayerData playerData;

	// Token: 0x04001E2A RID: 7722
	public GameObject geoSprite;

	// Token: 0x04001E2B RID: 7723
	public TextMesh geoTextMesh;

	// Token: 0x04001E2C RID: 7724
	public TextMesh subTextMesh;

	// Token: 0x04001E2D RID: 7725
	public TextMesh addTextMesh;

	// Token: 0x04001E2E RID: 7726
	private PlayMakerFSM geoSpriteFsm;

	// Token: 0x04001E2F RID: 7727
	private PlayMakerFSM subTextFsm;

	// Token: 0x04001E30 RID: 7728
	private PlayMakerFSM addTextFsm;

	// Token: 0x04001E31 RID: 7729
	private int counterCurrent;

	// Token: 0x04001E32 RID: 7730
	private int geoChange;

	// Token: 0x04001E33 RID: 7731
	private int addCounter;

	// Token: 0x04001E34 RID: 7732
	private int takeCounter;

	// Token: 0x04001E35 RID: 7733
	private int addRollerState;

	// Token: 0x04001E36 RID: 7734
	private int takeRollerState;

	// Token: 0x04001E37 RID: 7735
	private int changePerTick;

	// Token: 0x04001E38 RID: 7736
	private float addRollerStartTimer;

	// Token: 0x04001E39 RID: 7737
	private float takeRollerStartTimer;

	// Token: 0x04001E3A RID: 7738
	private float digitChangeTimer;

	// Token: 0x04001E3B RID: 7739
	private bool toZero;
}
