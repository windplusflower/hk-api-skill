using System;
using GlobalEnums;
using Modding;
using UnityEngine;

// Token: 0x02000109 RID: 265
public class NailSlash : MonoBehaviour
{
	// Token: 0x06000676 RID: 1654 RVA: 0x00026230 File Offset: 0x00024430
	private void Awake()
	{
		try
		{
			this.heroCtrl = base.transform.root.GetComponent<HeroController>();
		}
		catch (NullReferenceException ex)
		{
			string str = "NailSlash: could not find HeroController on parent: ";
			string name = base.transform.root.name;
			string str2 = " ";
			NullReferenceException ex2 = ex;
			Debug.LogError(str + name + str2 + ((ex2 != null) ? ex2.ToString() : null));
		}
		this.audio = base.GetComponent<AudioSource>();
		this.anim = base.GetComponent<tk2dSpriteAnimator>();
		this.slashFsm = base.GetComponent<PlayMakerFSM>();
		this.poly = base.GetComponent<PolygonCollider2D>();
		this.mesh = base.GetComponent<MeshRenderer>();
		this.clashTinkPoly = base.transform.Find("Clash Tink").GetComponent<PolygonCollider2D>();
		this.poly.enabled = false;
		this.mesh.enabled = false;
	}

	// Token: 0x06000677 RID: 1655 RVA: 0x00026308 File Offset: 0x00024508
	public void StartSlash()
	{
		this.audio.Play();
		this.slashAngle = this.slashFsm.FsmVariables.FindFsmFloat("direction").Value;
		if (this.mantis && this.longnail)
		{
			base.transform.localScale = new Vector3(this.scale.x * 1.4f, this.scale.y * 1.4f, this.scale.z);
			this.anim.Play(this.animName + " M");
		}
		else if (this.mantis)
		{
			base.transform.localScale = new Vector3(this.scale.x * 1.25f, this.scale.y * 1.25f, this.scale.z);
			this.anim.Play(this.animName + " M");
		}
		else if (this.longnail)
		{
			base.transform.localScale = new Vector3(this.scale.x * 1.15f, this.scale.y * 1.15f, this.scale.z);
			this.anim.Play(this.animName);
		}
		else
		{
			base.transform.localScale = this.scale;
			this.anim.Play(this.animName);
		}
		if (this.fury)
		{
			this.anim.Play(this.animName + " F");
		}
		this.anim.PlayFromFrame(0);
		this.stepCounter = 0;
		this.polyCounter = 0;
		this.poly.enabled = false;
		this.clashTinkPoly.enabled = false;
		this.animCompleted = false;
		this.anim.AnimationCompleted = new Action<tk2dSpriteAnimator, tk2dSpriteAnimationClip>(this.Disable);
		this.slashing = true;
		this.mesh.enabled = true;
	}

	// Token: 0x06000678 RID: 1656 RVA: 0x00026514 File Offset: 0x00024714
	private void FixedUpdate()
	{
		if (this.slashing)
		{
			if (this.stepCounter == 1)
			{
				this.poly.enabled = true;
				this.clashTinkPoly.enabled = true;
			}
			if (this.stepCounter >= 5 && (float)this.polyCounter > 0f)
			{
				this.poly.enabled = false;
				this.clashTinkPoly.enabled = false;
			}
			if (this.animCompleted && this.polyCounter > 1)
			{
				this.CancelAttack();
			}
			if (this.poly.enabled)
			{
				this.polyCounter++;
			}
			this.stepCounter++;
		}
	}

	// Token: 0x06000679 RID: 1657 RVA: 0x000265BC File Offset: 0x000247BC
	private void OnTriggerEnter2D(Collider2D otherCollider)
	{
		ModHooks.OnSlashHit(otherCollider, base.gameObject);
		this.orig_OnTriggerEnter2D(otherCollider);
	}

	// Token: 0x0600067A RID: 1658 RVA: 0x000265D4 File Offset: 0x000247D4
	private void Bounce(Collider2D otherCollider, bool useEffects)
	{
		PlayMakerFSM playMakerFSM = FSMUtility.LocateFSM(otherCollider.gameObject, "Bounce Shroom");
		if (playMakerFSM)
		{
			playMakerFSM.SendEvent("BOUNCE UPWARD");
			return;
		}
		BounceShroom component = otherCollider.GetComponent<BounceShroom>();
		if (component)
		{
			component.BounceLarge(useEffects);
		}
	}

	// Token: 0x0600067B RID: 1659 RVA: 0x0002661C File Offset: 0x0002481C
	private void OnTriggerStay2D(Collider2D otherCollider)
	{
		this.OnTriggerEnter2D(otherCollider);
	}

	// Token: 0x0600067C RID: 1660 RVA: 0x00026625 File Offset: 0x00024825
	private void Disable(tk2dSpriteAnimator sprite, tk2dSpriteAnimationClip clip)
	{
		this.animCompleted = true;
	}

	// Token: 0x0600067D RID: 1661 RVA: 0x0002662E File Offset: 0x0002482E
	public void SetLongnail(bool set)
	{
		this.longnail = set;
	}

	// Token: 0x0600067E RID: 1662 RVA: 0x00026637 File Offset: 0x00024837
	public void SetMantis(bool set)
	{
		this.mantis = set;
	}

	// Token: 0x0600067F RID: 1663 RVA: 0x00026640 File Offset: 0x00024840
	public void SetFury(bool set)
	{
		this.fury = set;
	}

	// Token: 0x06000680 RID: 1664 RVA: 0x00026649 File Offset: 0x00024849
	public void CancelAttack()
	{
		this.slashing = false;
		this.poly.enabled = false;
		this.clashTinkPoly.enabled = false;
		this.mesh.enabled = false;
	}

	// Token: 0x06000682 RID: 1666 RVA: 0x00026678 File Offset: 0x00024878
	private void orig_OnTriggerEnter2D(Collider2D otherCollider)
	{
		if (otherCollider != null)
		{
			if (this.slashAngle == 0f)
			{
				int layer = otherCollider.gameObject.layer;
				if (layer == 11 && (otherCollider.gameObject.GetComponent<NonBouncer>() == null || !otherCollider.gameObject.GetComponent<NonBouncer>().active))
				{
					if (otherCollider.gameObject.GetComponent<BounceShroom>() != null)
					{
						this.heroCtrl.RecoilLeftLong();
						this.Bounce(otherCollider, false);
					}
					else
					{
						this.heroCtrl.RecoilLeft();
					}
				}
				if (layer == 19 && otherCollider.gameObject.GetComponent<BounceShroom>() != null)
				{
					this.heroCtrl.RecoilLeftLong();
					this.Bounce(otherCollider, false);
					return;
				}
			}
			else if (this.slashAngle == 180f)
			{
				int layer2 = otherCollider.gameObject.layer;
				if (layer2 == 11 && (otherCollider.gameObject.GetComponent<NonBouncer>() == null || !otherCollider.gameObject.GetComponent<NonBouncer>().active))
				{
					if (otherCollider.gameObject.GetComponent<BounceShroom>() != null)
					{
						this.heroCtrl.RecoilRightLong();
						this.Bounce(otherCollider, false);
					}
					else
					{
						this.heroCtrl.RecoilRight();
					}
				}
				if (layer2 == 19 && otherCollider.gameObject.GetComponent<BounceShroom>() != null)
				{
					this.heroCtrl.RecoilRightLong();
					this.Bounce(otherCollider, false);
					return;
				}
			}
			else if (this.slashAngle == 90f)
			{
				int layer3 = otherCollider.gameObject.layer;
				if (layer3 == 11 && (otherCollider.gameObject.GetComponent<NonBouncer>() == null || !otherCollider.gameObject.GetComponent<NonBouncer>().active))
				{
					if (otherCollider.gameObject.GetComponent<BounceShroom>() != null)
					{
						this.heroCtrl.RecoilDown();
						this.Bounce(otherCollider, false);
					}
					else
					{
						this.heroCtrl.RecoilDown();
					}
				}
				if (layer3 == 19 && otherCollider.gameObject.GetComponent<BounceShroom>() != null)
				{
					this.heroCtrl.RecoilDown();
					this.Bounce(otherCollider, false);
					return;
				}
			}
			else if (this.slashAngle == 270f)
			{
				PhysLayers layer4 = (PhysLayers)otherCollider.gameObject.layer;
				if ((layer4 == PhysLayers.ENEMIES || layer4 == PhysLayers.INTERACTIVE_OBJECT || layer4 == PhysLayers.HERO_ATTACK) && (otherCollider.gameObject.GetComponent<NonBouncer>() == null || !otherCollider.gameObject.GetComponent<NonBouncer>().active))
				{
					if (otherCollider.gameObject.GetComponent<BigBouncer>() != null)
					{
						this.heroCtrl.BounceHigh();
						return;
					}
					if (otherCollider.gameObject.GetComponent<BounceShroom>() != null)
					{
						this.heroCtrl.ShroomBounce();
						this.Bounce(otherCollider, true);
						return;
					}
					this.heroCtrl.Bounce();
				}
			}
		}
	}

	// Token: 0x040006EA RID: 1770
	public string animName;

	// Token: 0x040006EB RID: 1771
	public Vector3 scale;

	// Token: 0x040006EC RID: 1772
	private HeroController heroCtrl;

	// Token: 0x040006ED RID: 1773
	private PlayMakerFSM slashFsm;

	// Token: 0x040006EE RID: 1774
	private tk2dSpriteAnimator anim;

	// Token: 0x040006EF RID: 1775
	private MeshRenderer mesh;

	// Token: 0x040006F0 RID: 1776
	private float slashAngle;

	// Token: 0x040006F1 RID: 1777
	private bool struck;

	// Token: 0x040006F2 RID: 1778
	private bool longnail;

	// Token: 0x040006F3 RID: 1779
	private bool mantis;

	// Token: 0x040006F4 RID: 1780
	private bool fury;

	// Token: 0x040006F5 RID: 1781
	private bool slashing;

	// Token: 0x040006F6 RID: 1782
	private int stepCounter;

	// Token: 0x040006F7 RID: 1783
	private PolygonCollider2D poly;

	// Token: 0x040006F8 RID: 1784
	private int polyCounter;

	// Token: 0x040006F9 RID: 1785
	private bool animCompleted;

	// Token: 0x040006FA RID: 1786
	private AudioSource audio;

	// Token: 0x040006FB RID: 1787
	private PolygonCollider2D clashTinkPoly;
}
