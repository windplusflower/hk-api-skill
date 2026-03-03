using System;
using System.Collections;
using UnityEngine;

// Token: 0x0200012E RID: 302
[Serializable]
public class GradeMarker : MonoBehaviour
{
	// Token: 0x060006FF RID: 1791 RVA: 0x00028224 File Offset: 0x00026424
	protected void OnEnable()
	{
		this.gm = GameManager.instance;
		if (this.gm != null)
		{
			this.gm.UnloadingLevel += this.OnUnloadingLevel;
		}
	}

	// Token: 0x06000700 RID: 1792 RVA: 0x00028256 File Offset: 0x00026456
	protected void OnDisable()
	{
		if (this.gm != null)
		{
			this.gm.UnloadingLevel -= this.OnUnloadingLevel;
		}
	}

	// Token: 0x06000701 RID: 1793 RVA: 0x0002827D File Offset: 0x0002647D
	private void Start()
	{
		if (this.startup != null)
		{
			base.StopCoroutine(this.startup);
		}
		this.startup = this.OnStart();
		base.StartCoroutine(this.startup);
	}

	// Token: 0x06000702 RID: 1794 RVA: 0x000282AC File Offset: 0x000264AC
	private void OnUnloadingLevel()
	{
		this.Deactivate();
		base.enabled = false;
	}

	// Token: 0x06000703 RID: 1795 RVA: 0x000282BC File Offset: 0x000264BC
	public void SetStartSizeForTrigger()
	{
		this.origCutoffRadius = this.cutoffRadius;
		this.origMaxIntensityRadius = this.maxIntensityRadius;
		this.cutoffRadius = this.origCutoffRadius * (this.shrunkPercentage / 100f);
		this.maxIntensityRadius = this.origMaxIntensityRadius * (this.shrunkPercentage / 100f);
		this.startCutoffRadius = this.cutoffRadius;
		this.startMaxIntensityRadius = this.maxIntensityRadius;
	}

	// Token: 0x06000704 RID: 1796 RVA: 0x0002832C File Offset: 0x0002652C
	public void Activate()
	{
		this.heading = this.hero.transform.position - base.transform.position;
		this.sqrNear = this.maxIntensityRadius * this.maxIntensityRadius;
		this.sqrFar = this.cutoffRadius * this.cutoffRadius;
		this.sqrEffectRange = this.sqrFar - this.sqrNear;
		this.u = (this.heading.sqrMagnitude - this.sqrNear) / this.sqrEffectRange;
		this.t = Mathf.Clamp01(1f - this.u);
		this.scm.SaturationB = SceneManager.AdjustSaturationForPlatform(this.saturation, null);
		this.scm.RedB = this.redChannel;
		this.scm.GreenB = this.greenChannel;
		this.scm.BlueB = this.blueChannel;
		this.scm.AmbientColorB = this.ambientColor;
		this.scm.AmbientIntensityB = this.ambientIntensity;
		if (GameManager.instance.IsGameplayScene())
		{
			this.scm.HeroLightColorB = this.heroLightColor;
		}
		this.enableGrade = true;
		this.scm.MarkerActive(true);
	}

	// Token: 0x06000705 RID: 1797 RVA: 0x00028477 File Offset: 0x00026677
	public void Deactivate()
	{
		if (this.startup != null)
		{
			base.StopCoroutine(this.startup);
		}
		this.startup = null;
		if (this.scm == null)
		{
			this.enableGrade = false;
			return;
		}
		this.orig_Deactivate();
	}

	// Token: 0x06000706 RID: 1798 RVA: 0x000284B0 File Offset: 0x000266B0
	public void ActivateGradual()
	{
		this.startCutoffRadius = this.cutoffRadius;
		this.startMaxIntensityRadius = this.maxIntensityRadius;
		this.finalCutoffRadius = this.origCutoffRadius;
		this.finalMaxIntensityRadius = this.origMaxIntensityRadius;
		this.cutoffRadius = this.startCutoffRadius;
		this.maxIntensityRadius = this.startMaxIntensityRadius;
		this.Activate();
		this.activating = true;
		this.deactivating = false;
		this.easeTimer = 0f;
	}

	// Token: 0x06000707 RID: 1799 RVA: 0x00028524 File Offset: 0x00026724
	public void DeactivateGradual()
	{
		this.startCutoffRadius = this.cutoffRadius;
		this.startMaxIntensityRadius = this.maxIntensityRadius;
		this.finalCutoffRadius = this.cutoffRadius * (this.shrunkPercentage / 100f);
		this.finalMaxIntensityRadius = this.maxIntensityRadius * (this.shrunkPercentage / 100f);
		this.activating = false;
		this.deactivating = true;
		this.easeTimer = 0f;
	}

	// Token: 0x06000708 RID: 1800 RVA: 0x00028594 File Offset: 0x00026794
	private void Update()
	{
		if (this.hero == null)
		{
			return;
		}
		this.orig_Update();
	}

	// Token: 0x06000709 RID: 1801 RVA: 0x000285AB File Offset: 0x000267AB
	private void UpdateLow()
	{
		if (this.hero == null)
		{
			return;
		}
		this.orig_UpdateLow();
	}

	// Token: 0x0600070A RID: 1802 RVA: 0x000285C2 File Offset: 0x000267C2
	public GradeMarker()
	{
		this.enableGrade = true;
		this.updateEvery = 2;
		this.shrunkPercentage = 30f;
		this.easeDuration = 1.5f;
		this.easeTimer = 2f;
		base..ctor();
	}

	// Token: 0x0600070B RID: 1803 RVA: 0x000285F9 File Offset: 0x000267F9
	private void orig_Start()
	{
		this.gc = GameCameras.instance;
		this.scm = this.gc.sceneColorManager;
		this.hero = HeroController.instance;
		if (this.enableGrade)
		{
			this.Activate();
		}
	}

	// Token: 0x0600070C RID: 1804 RVA: 0x00028630 File Offset: 0x00026830
	private IEnumerator OnStart()
	{
		GradeMarker.<OnStart>d__5 <OnStart>d__ = new GradeMarker.<OnStart>d__5(0);
		<OnStart>d__.<>4__this = this;
		return <OnStart>d__;
	}

	// Token: 0x0600070D RID: 1805 RVA: 0x00028640 File Offset: 0x00026840
	private void orig_Update()
	{
		if (Time.frameCount % this.updateEvery == 0)
		{
			this.UpdateLow();
		}
		if (this.easeTimer < this.easeDuration)
		{
			this.easeTimer += Time.deltaTime;
			float num = this.easeTimer / this.easeDuration;
			this.maxIntensityRadius = Mathf.Lerp(this.startMaxIntensityRadius, this.finalMaxIntensityRadius, num);
			this.cutoffRadius = Mathf.Lerp(this.startCutoffRadius, this.finalCutoffRadius, num);
			if (this.activating)
			{
				if (this.easeTimer >= this.easeDuration)
				{
					this.activating = false;
				}
			}
			else if (this.deactivating && this.easeTimer >= this.easeDuration)
			{
				this.deactivating = false;
				this.enableGrade = false;
			}
			if (this.easeTimer > this.easeDuration)
			{
				this.easeTimer = this.easeDuration;
			}
		}
	}

	// Token: 0x0600070E RID: 1806 RVA: 0x00028720 File Offset: 0x00026920
	private void orig_UpdateLow()
	{
		this.heading = this.hero.transform.position - base.transform.position;
		this.sqrNear = this.maxIntensityRadius * this.maxIntensityRadius;
		this.sqrFar = this.cutoffRadius * this.cutoffRadius;
		this.sqrEffectRange = this.sqrFar - this.sqrNear;
		this.u = (this.heading.sqrMagnitude - this.sqrNear) / this.sqrEffectRange;
		this.t = Mathf.Clamp01(1f - this.u);
		if (this.scm.startBufferActive)
		{
			this.scm.MarkerActive(true);
			this.scm.SetFactor(this.t);
			return;
		}
		bool markerActive = this.scm.markerActive;
		if (this.u < 0f)
		{
			this.scm.MarkerActive(false);
			this.scm.SetFactor(1f);
		}
		else if (this.u < 1.1f)
		{
			this.scm.MarkerActive(true);
			this.scm.SetFactor(this.t);
		}
		else
		{
			this.scm.MarkerActive(false);
			this.scm.SetFactor(0f);
		}
		if (markerActive != this.scm.markerActive)
		{
			this.scm.UpdateScript(false);
		}
	}

	// Token: 0x0600070F RID: 1807 RVA: 0x00028889 File Offset: 0x00026A89
	public void orig_Deactivate()
	{
		this.enableGrade = false;
		this.scm.SetFactor(0f);
	}

	// Token: 0x0400079F RID: 1951
	public bool enableGrade;

	// Token: 0x040007A0 RID: 1952
	private bool activating;

	// Token: 0x040007A1 RID: 1953
	private bool deactivating;

	// Token: 0x040007A2 RID: 1954
	[Header("Range")]
	public float maxIntensityRadius;

	// Token: 0x040007A3 RID: 1955
	public float cutoffRadius;

	// Token: 0x040007A4 RID: 1956
	[Header("Target Color Grade")]
	[Range(0f, 5f)]
	public float saturation;

	// Token: 0x040007A5 RID: 1957
	public AnimationCurve redChannel;

	// Token: 0x040007A6 RID: 1958
	public AnimationCurve greenChannel;

	// Token: 0x040007A7 RID: 1959
	public AnimationCurve blueChannel;

	// Token: 0x040007A8 RID: 1960
	[Header("Target Scene Lighting")]
	[Range(0f, 1f)]
	public float ambientIntensity;

	// Token: 0x040007A9 RID: 1961
	public Color ambientColor;

	// Token: 0x040007AA RID: 1962
	[Header("Target Hero Light")]
	public Color heroLightColor;

	// Token: 0x040007AB RID: 1963
	private GameManager gm;

	// Token: 0x040007AC RID: 1964
	private GameCameras gc;

	// Token: 0x040007AD RID: 1965
	private HeroController hero;

	// Token: 0x040007AE RID: 1966
	private SceneColorManager scm;

	// Token: 0x040007AF RID: 1967
	private int updateEvery;

	// Token: 0x040007B0 RID: 1968
	private Vector2 heading;

	// Token: 0x040007B1 RID: 1969
	private float sqrNear;

	// Token: 0x040007B2 RID: 1970
	private float sqrFar;

	// Token: 0x040007B3 RID: 1971
	private float sqrEffectRange;

	// Token: 0x040007B4 RID: 1972
	private float t;

	// Token: 0x040007B5 RID: 1973
	private float u;

	// Token: 0x040007B6 RID: 1974
	private float origMaxIntensityRadius;

	// Token: 0x040007B7 RID: 1975
	private float origCutoffRadius;

	// Token: 0x040007B8 RID: 1976
	private float startMaxIntensityRadius;

	// Token: 0x040007B9 RID: 1977
	private float startCutoffRadius;

	// Token: 0x040007BA RID: 1978
	private float finalMaxIntensityRadius;

	// Token: 0x040007BB RID: 1979
	private float finalCutoffRadius;

	// Token: 0x040007BC RID: 1980
	private float shrunkPercentage;

	// Token: 0x040007BD RID: 1981
	[HideInInspector]
	public float easeDuration;

	// Token: 0x040007BE RID: 1982
	private float easeTimer;

	// Token: 0x040007BF RID: 1983
	private IEnumerator startup;
}
