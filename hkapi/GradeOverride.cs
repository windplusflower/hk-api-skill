using System;
using UnityEngine;

// Token: 0x02000130 RID: 304
public class GradeOverride : MonoBehaviour
{
	// Token: 0x06000716 RID: 1814 RVA: 0x0002891C File Offset: 0x00026B1C
	private void Start()
	{
		this.gc = GameCameras.instance;
		this.hero = HeroController.instance;
	}

	// Token: 0x06000717 RID: 1815 RVA: 0x00028934 File Offset: 0x00026B34
	private void OnEnable()
	{
		base.Invoke("Activate", 0.1f);
	}

	// Token: 0x06000718 RID: 1816 RVA: 0x00028946 File Offset: 0x00026B46
	private void OnDisable()
	{
		this.Deactivate();
	}

	// Token: 0x06000719 RID: 1817 RVA: 0x00028950 File Offset: 0x00026B50
	public void Activate()
	{
		this.gc = GameCameras.instance;
		this.scm = this.gc.sceneColorManager;
		this.hero = HeroController.instance;
		this.o_saturation = this.scm.SaturationA;
		this.o_redChannel = this.scm.RedA;
		this.o_greenChannel = this.scm.GreenA;
		this.o_blueChannel = this.scm.BlueA;
		this.o_ambientIntensity = this.scm.AmbientIntensityA;
		this.o_ambientColor = this.scm.AmbientColorA;
		this.scm.SaturationA = SceneManager.AdjustSaturationForPlatform(this.saturation, null);
		this.scm.RedA = this.redChannel;
		this.scm.GreenA = this.greenChannel;
		this.scm.BlueA = this.blueChannel;
		this.scm.AmbientColorA = this.ambientColor;
		this.scm.AmbientIntensityA = this.ambientIntensity;
		SceneManager.SetLighting(this.ambientColor, this.ambientIntensity);
		if (GameManager.instance.IsGameplayScene())
		{
			this.o_heroLightColor = this.scm.HeroLightColorA;
			this.scm.HeroLightColorA = this.heroLightColor;
		}
		this.scm.MarkerActive(true);
		base.StartCoroutine(this.scm.ForceRefresh());
	}

	// Token: 0x0600071A RID: 1818 RVA: 0x00028ABC File Offset: 0x00026CBC
	public void Deactivate()
	{
		this.scm.SaturationA = this.o_saturation;
		this.scm.RedA = this.o_redChannel;
		this.scm.GreenA = this.o_greenChannel;
		this.scm.BlueA = this.o_blueChannel;
		this.scm.AmbientColorA = this.o_ambientColor;
		this.scm.AmbientIntensityA = this.o_ambientIntensity;
		SceneManager.SetLighting(this.o_ambientColor, this.o_ambientIntensity);
		if (GameManager.instance != null && GameManager.instance.IsGameplayScene())
		{
			this.scm.HeroLightColorA = this.o_heroLightColor;
		}
	}

	// Token: 0x040007C3 RID: 1987
	[Header("Overriding Color Grade")]
	[Range(0f, 5f)]
	public float saturation;

	// Token: 0x040007C4 RID: 1988
	public AnimationCurve redChannel;

	// Token: 0x040007C5 RID: 1989
	public AnimationCurve greenChannel;

	// Token: 0x040007C6 RID: 1990
	public AnimationCurve blueChannel;

	// Token: 0x040007C7 RID: 1991
	[Header("Overriding Scene Lighting")]
	[Range(0f, 1f)]
	public float ambientIntensity;

	// Token: 0x040007C8 RID: 1992
	public Color ambientColor;

	// Token: 0x040007C9 RID: 1993
	[Header("Overriding Hero Light")]
	public Color heroLightColor;

	// Token: 0x040007CA RID: 1994
	private float o_saturation;

	// Token: 0x040007CB RID: 1995
	private AnimationCurve o_redChannel;

	// Token: 0x040007CC RID: 1996
	private AnimationCurve o_greenChannel;

	// Token: 0x040007CD RID: 1997
	private AnimationCurve o_blueChannel;

	// Token: 0x040007CE RID: 1998
	private float o_ambientIntensity;

	// Token: 0x040007CF RID: 1999
	private Color o_ambientColor;

	// Token: 0x040007D0 RID: 2000
	private Color o_heroLightColor;

	// Token: 0x040007D1 RID: 2001
	private GameCameras gc;

	// Token: 0x040007D2 RID: 2002
	private HeroController hero;

	// Token: 0x040007D3 RID: 2003
	private SceneColorManager scm;
}
