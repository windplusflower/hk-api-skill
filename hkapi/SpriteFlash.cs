using System;
using UnityEngine;

// Token: 0x02000094 RID: 148
public class SpriteFlash : MonoBehaviour
{
	// Token: 0x0600030F RID: 783 RVA: 0x0001020B File Offset: 0x0000E40B
	private void Start()
	{
		if (this.rend == null)
		{
			this.rend = base.GetComponent<Renderer>();
		}
		if (this.block == null)
		{
			this.block = new MaterialPropertyBlock();
		}
	}

	// Token: 0x06000310 RID: 784 RVA: 0x0001023C File Offset: 0x0000E43C
	private void OnDisable()
	{
		if (this.rend == null)
		{
			this.rend = base.GetComponent<Renderer>();
		}
		if (this.block == null)
		{
			this.block = new MaterialPropertyBlock();
		}
		this.block.SetFloat("_FlashAmount", 0f);
		this.rend.SetPropertyBlock(this.block);
		this.flashTimer = 0f;
		this.flashingState = 0;
		this.repeatFlash = false;
		this.cancelFlash = false;
		this.geoFlash = false;
	}

	// Token: 0x06000311 RID: 785 RVA: 0x000102C4 File Offset: 0x0000E4C4
	private void Update()
	{
		if (this.cancelFlash)
		{
			this.block.SetFloat("_FlashAmount", 0f);
			this.rend.SetPropertyBlock(this.block);
			this.flashingState = 0;
			this.cancelFlash = false;
		}
		if (this.flashingState == 1)
		{
			if (this.flashTimer < this.timeUp)
			{
				this.flashTimer += Time.deltaTime;
				this.t = this.flashTimer / this.timeUp;
				this.amountCurrent = Mathf.Lerp(0f, this.amount, this.t);
				this.block.SetFloat("_FlashAmount", this.amountCurrent);
				this.rend.SetPropertyBlock(this.block);
			}
			else
			{
				this.block.SetFloat("_FlashAmount", this.amount);
				this.rend.SetPropertyBlock(this.block);
				this.flashTimer = 0f;
				this.flashingState = 2;
			}
		}
		if (this.flashingState == 2)
		{
			if (this.flashTimer < this.stayTime)
			{
				this.flashTimer += Time.deltaTime;
			}
			else
			{
				this.flashTimer = 0f;
				this.flashingState = 3;
			}
		}
		if (this.flashingState == 3)
		{
			if (this.flashTimer < this.timeDown)
			{
				this.flashTimer += Time.deltaTime;
				this.t = this.flashTimer / this.timeDown;
				this.amountCurrent = Mathf.Lerp(this.amount, 0f, this.t);
				this.block.SetFloat("_FlashAmount", this.amountCurrent);
				this.rend.SetPropertyBlock(this.block);
			}
			else
			{
				this.block.SetFloat("_FlashAmount", 0f);
				this.rend.SetPropertyBlock(this.block);
				this.flashTimer = 0f;
				if (this.repeatFlash)
				{
					this.flashingState = 1;
				}
				else
				{
					this.flashingState = 0;
				}
			}
		}
		if (this.geoFlash)
		{
			if (this.geoTimer > 0f)
			{
				this.geoTimer -= Time.deltaTime;
				return;
			}
			this.FlashingSuperDash();
			this.geoFlash = false;
		}
	}

	// Token: 0x06000312 RID: 786 RVA: 0x00010509 File Offset: 0x0000E709
	public void GeoFlash()
	{
		this.geoFlash = true;
		this.geoTimer = 0.25f;
	}

	// Token: 0x06000313 RID: 787 RVA: 0x00010520 File Offset: 0x0000E720
	public void flash(Color flashColour_var, float amount_var, float timeUp_var, float stayTime_var, float timeDown_var)
	{
		this.flashColour = flashColour_var;
		this.amount = amount_var;
		this.timeUp = timeUp_var;
		this.stayTime = stayTime_var;
		this.timeDown = timeDown_var;
		this.block.Clear();
		this.block.SetColor("_FlashColor", this.flashColour);
		this.flashingState = 1;
		this.flashTimer = 0f;
		this.repeatFlash = false;
	}

	// Token: 0x06000314 RID: 788 RVA: 0x0001058C File Offset: 0x0000E78C
	public void CancelFlash()
	{
		this.cancelFlash = true;
	}

	// Token: 0x06000315 RID: 789 RVA: 0x00010598 File Offset: 0x0000E798
	public void FlashingSuperDash()
	{
		this.flashColour = new Color(1f, 1f, 1f);
		this.amount = 0.7f;
		this.timeUp = 0.1f;
		this.stayTime = 0.01f;
		this.timeDown = 0.1f;
		this.block.Clear();
		this.block.SetColor("_FlashColor", this.flashColour);
		this.flashingState = 1;
		this.flashTimer = 0f;
		this.repeatFlash = true;
		this.SendToChildren(new Action(this.FlashingSuperDash));
	}

	// Token: 0x06000316 RID: 790 RVA: 0x00010638 File Offset: 0x0000E838
	public void FlashingGhostWounded()
	{
		this.flashColour = new Color(1f, 1f, 1f);
		this.amount = 0.7f;
		this.timeUp = 0.5f;
		this.stayTime = 0.01f;
		this.timeDown = 0.5f;
		this.block.Clear();
		this.block.SetColor("_FlashColor", this.flashColour);
		this.flashingState = 1;
		this.flashTimer = 0f;
		this.repeatFlash = true;
		this.SendToChildren(new Action(this.FlashingGhostWounded));
	}

	// Token: 0x06000317 RID: 791 RVA: 0x000106D8 File Offset: 0x0000E8D8
	public void FlashingWhiteStay()
	{
		this.flashColour = new Color(1f, 1f, 1f);
		this.amount = 0.6f;
		this.timeUp = 0.01f;
		this.stayTime = 999f;
		this.timeDown = 0.01f;
		this.block.Clear();
		this.block.SetColor("_FlashColor", this.flashColour);
		this.flashingState = 1;
		this.flashTimer = 0f;
		this.repeatFlash = true;
		this.SendToChildren(new Action(this.FlashingWhiteStay));
	}

	// Token: 0x06000318 RID: 792 RVA: 0x00010778 File Offset: 0x0000E978
	public void FlashingWhiteStayMoth()
	{
		this.flashColour = new Color(1f, 1f, 1f);
		this.amount = 0.6f;
		this.timeUp = 2f;
		this.stayTime = 9999f;
		this.timeDown = 2f;
		this.block.Clear();
		this.block.SetColor("_FlashColor", this.flashColour);
		this.flashingState = 1;
		this.flashTimer = 0f;
		this.repeatFlash = true;
		this.SendToChildren(new Action(this.FlashingWhiteStayMoth));
	}

	// Token: 0x06000319 RID: 793 RVA: 0x00010818 File Offset: 0x0000EA18
	public void FlashingFury()
	{
		this.Start();
		this.flashColour = new Color(0.71f, 0.18f, 0.18f);
		this.amount = 0.75f;
		this.timeUp = 0.25f;
		this.stayTime = 0.01f;
		this.timeDown = 0.25f;
		this.block.Clear();
		this.block.SetColor("_FlashColor", this.flashColour);
		this.flashingState = 1;
		this.flashTimer = 0f;
		this.repeatFlash = true;
		this.SendToChildren(new Action(this.FlashingFury));
	}

	// Token: 0x0600031A RID: 794 RVA: 0x000108C0 File Offset: 0x0000EAC0
	public void FlashingOrange()
	{
		this.flashColour = new Color(1f, 0.31f, 0f);
		this.amount = 0.7f;
		this.timeUp = 0.1f;
		this.stayTime = 0.01f;
		this.timeDown = 0.1f;
		this.block.Clear();
		this.block.SetColor("_FlashColor", this.flashColour);
		this.flashingState = 1;
		this.flashTimer = 0f;
		this.repeatFlash = true;
		this.SendToChildren(new Action(this.FlashingOrange));
	}

	// Token: 0x0600031B RID: 795 RVA: 0x00010960 File Offset: 0x0000EB60
	public void flashInfected()
	{
		if (this.block == null)
		{
			this.block = new MaterialPropertyBlock();
		}
		this.flashColour = new Color(1f, 0.31f, 0f);
		this.amount = 0.9f;
		this.timeUp = 0.01f;
		this.stayTime = 0.01f;
		this.timeDown = 0.25f;
		this.block.Clear();
		this.block.SetColor("_FlashColor", this.flashColour);
		this.flashingState = 1;
		this.flashTimer = 0f;
		this.repeatFlash = false;
		this.SendToChildren(new Action(this.flashInfected));
	}

	// Token: 0x0600031C RID: 796 RVA: 0x00010A14 File Offset: 0x0000EC14
	public void flashDung()
	{
		if (this.block == null)
		{
			this.block = new MaterialPropertyBlock();
		}
		this.flashColour = new Color(0.45f, 0.27f, 0f);
		this.amount = 0.9f;
		this.timeUp = 0.01f;
		this.stayTime = 0.01f;
		this.timeDown = 0.25f;
		this.block.Clear();
		this.block.SetColor("_FlashColor", this.flashColour);
		this.flashingState = 1;
		this.flashTimer = 0f;
		this.repeatFlash = false;
		this.SendToChildren(new Action(this.flashDung));
	}

	// Token: 0x0600031D RID: 797 RVA: 0x00010AC8 File Offset: 0x0000ECC8
	public void flashDungQuick()
	{
		if (this.block == null)
		{
			this.block = new MaterialPropertyBlock();
		}
		this.flashColour = new Color(0.45f, 0.27f, 0f);
		this.amount = 0.75f;
		this.timeUp = 0.001f;
		this.stayTime = 0.05f;
		this.timeDown = 0.1f;
		this.block.Clear();
		this.block.SetColor("_FlashColor", this.flashColour);
		this.flashingState = 1;
		this.flashTimer = 0f;
		this.repeatFlash = false;
		this.SendToChildren(new Action(this.flashDungQuick));
	}

	// Token: 0x0600031E RID: 798 RVA: 0x00010B7C File Offset: 0x0000ED7C
	public void flashSporeQuick()
	{
		if (this.block == null)
		{
			this.block = new MaterialPropertyBlock();
		}
		this.flashColour = new Color(0.95f, 0.9f, 0.15f);
		this.amount = 0.75f;
		this.timeUp = 0.001f;
		this.stayTime = 0.05f;
		this.timeDown = 0.1f;
		this.block.Clear();
		this.block.SetColor("_FlashColor", this.flashColour);
		this.flashingState = 1;
		this.flashTimer = 0f;
		this.repeatFlash = false;
		this.SendToChildren(new Action(this.flashSporeQuick));
	}

	// Token: 0x0600031F RID: 799 RVA: 0x00010C30 File Offset: 0x0000EE30
	public void flashWhiteQuick()
	{
		if (this.block == null)
		{
			this.block = new MaterialPropertyBlock();
		}
		this.flashColour = new Color(1f, 1f, 1f);
		this.amount = 1f;
		this.timeUp = 0.001f;
		this.stayTime = 0.05f;
		this.timeDown = 0.001f;
		this.block.Clear();
		this.block.SetColor("_FlashColor", this.flashColour);
		this.flashingState = 1;
		this.flashTimer = 0f;
		this.repeatFlash = false;
		this.SendToChildren(new Action(this.flashWhiteQuick));
	}

	// Token: 0x06000320 RID: 800 RVA: 0x00010CE4 File Offset: 0x0000EEE4
	public void flashInfectedLong()
	{
		this.flashColour = new Color(1f, 0.31f, 0f);
		this.amount = 0.9f;
		this.timeUp = 0.01f;
		this.stayTime = 0.25f;
		this.timeDown = 0.35f;
		this.block.Clear();
		this.block.SetColor("_FlashColor", this.flashColour);
		this.flashingState = 1;
		this.flashTimer = 0f;
		this.repeatFlash = false;
		this.SendToChildren(new Action(this.flashInfectedLong));
	}

	// Token: 0x06000321 RID: 801 RVA: 0x00010D84 File Offset: 0x0000EF84
	public void flashArmoured()
	{
		this.flashColour = new Color(1f, 1f, 1f);
		this.amount = 0.9f;
		this.timeUp = 0.01f;
		this.stayTime = 0.01f;
		this.timeDown = 0.25f;
		if (this.block != null)
		{
			this.block.Clear();
			this.block.SetColor("_FlashColor", this.flashColour);
		}
		this.flashingState = 1;
		this.flashTimer = 0f;
		this.repeatFlash = false;
		this.SendToChildren(new Action(this.flashArmoured));
	}

	// Token: 0x06000322 RID: 802 RVA: 0x00010E2C File Offset: 0x0000F02C
	public void flashBenchRest()
	{
		this.flashColour = new Color(1f, 1f, 1f);
		this.amount = 0.7f;
		this.timeUp = 0.01f;
		this.stayTime = 0.1f;
		this.timeDown = 0.75f;
		this.block.Clear();
		this.block.SetColor("_FlashColor", this.flashColour);
		this.flashingState = 1;
		this.flashTimer = 0f;
		this.repeatFlash = false;
		this.SendToChildren(new Action(this.flashBenchRest));
	}

	// Token: 0x06000323 RID: 803 RVA: 0x00010ECC File Offset: 0x0000F0CC
	public void flashDreamImpact()
	{
		this.flashColour = new Color(1f, 1f, 1f);
		this.amount = 0.9f;
		this.timeUp = 0.01f;
		this.stayTime = 0.25f;
		this.timeDown = 0.75f;
		if (this.block != null)
		{
			this.block.Clear();
			this.block.SetColor("_FlashColor", this.flashColour);
		}
		this.flashingState = 1;
		this.flashTimer = 0f;
		this.repeatFlash = false;
		this.SendToChildren(new Action(this.flashDreamImpact));
	}

	// Token: 0x06000324 RID: 804 RVA: 0x00010F74 File Offset: 0x0000F174
	public void flashMothDepart()
	{
		this.flashColour = new Color(1f, 1f, 1f);
		this.amount = 0.75f;
		this.timeUp = 1.9f;
		this.stayTime = 1f;
		this.timeDown = 0.25f;
		this.block.Clear();
		this.block.SetColor("_FlashColor", this.flashColour);
		this.flashingState = 1;
		this.flashTimer = 0f;
		this.repeatFlash = false;
		this.SendToChildren(new Action(this.flashMothDepart));
	}

	// Token: 0x06000325 RID: 805 RVA: 0x00011014 File Offset: 0x0000F214
	public void flashSoulGet()
	{
		this.flashColour = new Color(1f, 1f, 1f);
		this.amount = 0.5f;
		this.timeUp = 0.01f;
		this.stayTime = 0.01f;
		this.timeDown = 0.25f;
		this.block.Clear();
		this.block.SetColor("_FlashColor", this.flashColour);
		this.flashingState = 1;
		this.flashTimer = 0f;
		this.repeatFlash = false;
		this.SendToChildren(new Action(this.flashSoulGet));
	}

	// Token: 0x06000326 RID: 806 RVA: 0x000110B4 File Offset: 0x0000F2B4
	public void flashShadeGet()
	{
		this.flashColour = new Color(0f, 0f, 0f);
		this.amount = 0.5f;
		this.timeUp = 0.01f;
		this.stayTime = 0.01f;
		this.timeDown = 0.25f;
		this.block.Clear();
		this.block.SetColor("_FlashColor", this.flashColour);
		this.flashingState = 1;
		this.flashTimer = 0f;
		this.repeatFlash = false;
		this.SendToChildren(new Action(this.flashShadeGet));
	}

	// Token: 0x06000327 RID: 807 RVA: 0x00011154 File Offset: 0x0000F354
	public void flashWhiteLong()
	{
		this.flashColour = new Color(1f, 1f, 1f);
		this.amount = 1f;
		this.timeUp = 0.01f;
		this.stayTime = 0.01f;
		this.timeDown = 2f;
		this.block.Clear();
		this.block.SetColor("_FlashColor", this.flashColour);
		this.flashingState = 1;
		this.flashTimer = 0f;
		this.repeatFlash = false;
		this.SendToChildren(new Action(this.flashWhiteLong));
	}

	// Token: 0x06000328 RID: 808 RVA: 0x000111F4 File Offset: 0x0000F3F4
	public void flashOvercharmed()
	{
		this.flashColour = new Color(0.72f, 0.376f, 0.72f);
		this.amount = 0.75f;
		this.timeUp = 0.2f;
		this.stayTime = 0.01f;
		this.timeDown = 0.5f;
		this.block.Clear();
		this.block.SetColor("_FlashColor", this.flashColour);
		this.flashingState = 1;
		this.flashTimer = 0f;
		this.repeatFlash = false;
		this.SendToChildren(new Action(this.flashOvercharmed));
	}

	// Token: 0x06000329 RID: 809 RVA: 0x00011294 File Offset: 0x0000F494
	public void flashFocusHeal()
	{
		this.Start();
		this.flashColour = new Color(1f, 1f, 1f);
		this.amount = 0.85f;
		this.timeUp = 0.01f;
		this.stayTime = 0.01f;
		this.timeDown = 0.35f;
		this.block.Clear();
		this.block.SetColor("_FlashColor", this.flashColour);
		this.flashingState = 1;
		this.flashTimer = 0f;
		this.repeatFlash = false;
		this.SendToChildren(new Action(this.flashFocusHeal));
	}

	// Token: 0x0600032A RID: 810 RVA: 0x0001133C File Offset: 0x0000F53C
	public void flashFocusGet()
	{
		this.Start();
		this.flashColour = new Color(1f, 1f, 1f);
		this.amount = 0.5f;
		this.timeUp = 0.01f;
		this.stayTime = 0.01f;
		this.timeDown = 0.35f;
		this.block.Clear();
		this.block.SetColor("_FlashColor", this.flashColour);
		this.flashingState = 1;
		this.flashTimer = 0f;
		this.repeatFlash = false;
		this.SendToChildren(new Action(this.flashFocusGet));
	}

	// Token: 0x0600032B RID: 811 RVA: 0x000113E4 File Offset: 0x0000F5E4
	public void flashWhitePulse()
	{
		this.Start();
		this.flashColour = new Color(1f, 1f, 1f);
		this.amount = 0.35f;
		this.timeUp = 0.5f;
		this.stayTime = 0.01f;
		this.timeDown = 0.75f;
		this.block.Clear();
		this.block.SetColor("_FlashColor", this.flashColour);
		this.flashingState = 1;
		this.flashTimer = 0f;
		this.repeatFlash = false;
		this.SendToChildren(new Action(this.flashWhitePulse));
	}

	// Token: 0x0600032C RID: 812 RVA: 0x0001148C File Offset: 0x0000F68C
	public void flashHealBlue()
	{
		this.flashColour = new Color(0f, 0.584f, 1f);
		this.amount = 0.75f;
		this.timeUp = 0.01f;
		this.stayTime = 0.01f;
		this.timeDown = 0.5f;
		this.block.Clear();
		this.block.SetColor("_FlashColor", this.flashColour);
		this.flashingState = 1;
		this.flashTimer = 0f;
		this.repeatFlash = false;
		this.SendToChildren(new Action(this.flashHealBlue));
	}

	// Token: 0x0600032D RID: 813 RVA: 0x0001152C File Offset: 0x0000F72C
	public void FlashShadowRecharge()
	{
		this.Start();
		this.flashColour = new Color(0f, 0f, 0f);
		this.amount = 0.75f;
		this.timeUp = 0.01f;
		this.stayTime = 0.01f;
		this.timeDown = 0.35f;
		this.block.Clear();
		this.block.SetColor("_FlashColor", this.flashColour);
		this.flashingState = 1;
		this.flashTimer = 0f;
		this.repeatFlash = false;
		this.SendToChildren(new Action(this.FlashShadowRecharge));
	}

	// Token: 0x0600032E RID: 814 RVA: 0x000115D4 File Offset: 0x0000F7D4
	public void flashInfectedLoop()
	{
		this.flashColour = new Color(1f, 0.31f, 0f);
		this.amount = 0.9f;
		this.timeUp = 0.2f;
		this.stayTime = 0.01f;
		this.timeDown = 0.2f;
		this.block.Clear();
		this.block.SetColor("_FlashColor", this.flashColour);
		this.flashingState = 1;
		this.flashTimer = 0f;
		this.repeatFlash = true;
		this.SendToChildren(new Action(this.flashInfectedLoop));
	}

	// Token: 0x0600032F RID: 815 RVA: 0x00011674 File Offset: 0x0000F874
	public void FlashGrimmflame()
	{
		this.Start();
		this.flashColour = new Color(1f, 0.25f, 0.25f);
		this.amount = 0.75f;
		this.timeUp = 0.01f;
		this.stayTime = 0.01f;
		this.timeDown = 1f;
		this.block.Clear();
		this.block.SetColor("_FlashColor", this.flashColour);
		this.flashingState = 1;
		this.flashTimer = 0f;
		this.repeatFlash = false;
		this.SendToChildren(new Action(this.FlashGrimmflame));
	}

	// Token: 0x06000330 RID: 816 RVA: 0x0001171C File Offset: 0x0000F91C
	public void FlashGrimmHit()
	{
		this.Start();
		this.flashColour = new Color(1f, 0.25f, 0.25f);
		this.amount = 0.75f;
		this.timeUp = 0.01f;
		this.stayTime = 0.01f;
		this.timeDown = 0.25f;
		this.block.Clear();
		this.block.SetColor("_FlashColor", this.flashColour);
		this.flashingState = 1;
		this.flashTimer = 0f;
		this.repeatFlash = false;
		this.SendToChildren(new Action(this.FlashGrimmHit));
	}

	// Token: 0x06000331 RID: 817 RVA: 0x000117C4 File Offset: 0x0000F9C4
	private void SendToChildren(Action function)
	{
		if (!this.sendToChildren)
		{
			return;
		}
		foreach (SpriteFlash spriteFlash in base.GetComponentsInChildren<SpriteFlash>())
		{
			if (!(spriteFlash == this))
			{
				spriteFlash.sendToChildren = false;
				spriteFlash.GetType().GetMethod(function.Method.Name).Invoke(spriteFlash, null);
			}
		}
	}

	// Token: 0x06000332 RID: 818 RVA: 0x00011821 File Offset: 0x0000FA21
	public SpriteFlash()
	{
		this.sendToChildren = true;
		base..ctor();
	}

	// Token: 0x0400028C RID: 652
	private Renderer rend;

	// Token: 0x0400028D RID: 653
	private Color flashColour;

	// Token: 0x0400028E RID: 654
	private float amount;

	// Token: 0x0400028F RID: 655
	private float timeUp;

	// Token: 0x04000290 RID: 656
	private float stayTime;

	// Token: 0x04000291 RID: 657
	private float timeDown;

	// Token: 0x04000292 RID: 658
	private int flashingState;

	// Token: 0x04000293 RID: 659
	private float flashTimer;

	// Token: 0x04000294 RID: 660
	private float amountCurrent;

	// Token: 0x04000295 RID: 661
	private float t;

	// Token: 0x04000296 RID: 662
	private bool repeatFlash;

	// Token: 0x04000297 RID: 663
	private bool cancelFlash;

	// Token: 0x04000298 RID: 664
	private float geoTimer;

	// Token: 0x04000299 RID: 665
	private bool geoFlash;

	// Token: 0x0400029A RID: 666
	private MaterialPropertyBlock block;

	// Token: 0x0400029B RID: 667
	private bool sendToChildren;
}
