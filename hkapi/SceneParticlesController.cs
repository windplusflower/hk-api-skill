using System;
using GlobalEnums;
using UnityEngine;

// Token: 0x02000149 RID: 329
public class SceneParticlesController : MonoBehaviour
{
	// Token: 0x060007AF RID: 1967 RVA: 0x0002B812 File Offset: 0x00029A12
	public void SceneInit()
	{
		this.BeginScene();
	}

	// Token: 0x060007B0 RID: 1968 RVA: 0x0002B81C File Offset: 0x00029A1C
	public void EnableParticles()
	{
		this.foundMatch = false;
		if (this.sm.overrideParticlesWith == MapZone.NONE)
		{
			this.sceneParticleZoneType = this.sm.mapZone;
		}
		else
		{
			this.sceneParticleZoneType = this.sm.overrideParticlesWith;
		}
		for (int i = 0; i < this.sceneParticles.Length; i++)
		{
			if (this.sceneParticles[i].mapZone == this.sceneParticleZoneType)
			{
				if (this.sceneParticles[i].particleObject != null)
				{
					this.foundMatch = true;
					this.sceneParticles[i].particleObject.gameObject.SetActive(true);
				}
				else
				{
					Debug.LogError("Trying to enable Particle Object for MapZone: " + this.sceneParticleZoneType.ToString() + " but Particle Object is not set.");
				}
			}
			else if (this.sceneParticles[i].particleObject != null)
			{
				this.sceneParticles[i].particleObject.gameObject.SetActive(false);
			}
			else
			{
				Debug.LogError("Trying to disable Particle Object for MapZone: " + this.sceneParticleZoneType.ToString() + " but Particle Object is not set.");
			}
		}
		if (!this.foundMatch)
		{
			if (this.defaultParticles.particleObject != null)
			{
				this.defaultParticles.particleObject.gameObject.SetActive(true);
				return;
			}
			Debug.LogError("Trying to enable Default Particle Object but Default Particle Object is not set.");
			return;
		}
		else
		{
			if (this.defaultParticles.particleObject != null)
			{
				this.defaultParticles.particleObject.gameObject.SetActive(false);
				return;
			}
			Debug.LogError("Trying to disable Default Particle Object but Default Particle Object is not set.");
			return;
		}
	}

	// Token: 0x060007B1 RID: 1969 RVA: 0x0002B9B4 File Offset: 0x00029BB4
	public void DisableParticles()
	{
		for (int i = 0; i < this.sceneParticles.Length; i++)
		{
			if (this.sceneParticles[i].particleObject != null)
			{
				this.sceneParticles[i].particleObject.gameObject.SetActive(false);
			}
			else
			{
				Debug.LogError("Trying to disable Particle Object for MapZone: " + this.sceneParticleZoneType.ToString() + " but Particle Object is not set.");
			}
		}
		if (this.defaultParticles.particleObject != null)
		{
			this.defaultParticles.particleObject.gameObject.SetActive(false);
			return;
		}
		Debug.LogError("Trying to disable Default Particle Object but Default Particle Object is not set.");
	}

	// Token: 0x060007B2 RID: 1970 RVA: 0x0002BA5C File Offset: 0x00029C5C
	private void BeginScene()
	{
		this.gm = GameManager.instance;
		this.sm = this.gm.sm;
		if (this.sm == null)
		{
			this.sm = UnityEngine.Object.FindObjectOfType<SceneManager>();
		}
		this.gc = GameCameras.instance;
		if (!this.gm.IsGameplayScene() || this.gm.IsCinematicScene())
		{
			this.DisableParticles();
			return;
		}
		if (!this.sm.noParticles)
		{
			this.EnableParticles();
			return;
		}
		this.DisableParticles();
	}

	// Token: 0x04000885 RID: 2181
	public SceneParticles defaultParticles;

	// Token: 0x04000886 RID: 2182
	public SceneParticles[] sceneParticles;

	// Token: 0x04000887 RID: 2183
	private GameManager gm;

	// Token: 0x04000888 RID: 2184
	private SceneManager sm;

	// Token: 0x04000889 RID: 2185
	private GameCameras gc;

	// Token: 0x0400088A RID: 2186
	private bool foundMatch;

	// Token: 0x0400088B RID: 2187
	private MapZone sceneParticleZoneType;
}
