using System;
using UnityEngine;

// Token: 0x02000213 RID: 531
public class GlobalPrefabDefaults : MonoBehaviour
{
	// Token: 0x06000B71 RID: 2929 RVA: 0x0003C77D File Offset: 0x0003A97D
	private void Awake()
	{
		GlobalPrefabDefaults.Instance = this;
	}

	// Token: 0x06000B72 RID: 2930 RVA: 0x0003C788 File Offset: 0x0003A988
	private void Start()
	{
		if (this.bloodSplatterParticle)
		{
			ParticleSystem component = this.bloodSplatterParticle.GetComponent<ParticleSystem>();
			if (component)
			{
				this.initialBloodColour = component.main.startColor;
			}
		}
	}

	// Token: 0x06000B73 RID: 2931 RVA: 0x0003C7CC File Offset: 0x0003A9CC
	public void SpawnBlood(Vector3 position, short minCount, short maxCount, float minSpeed, float maxSpeed, float angleMin = 0f, float angleMax = 360f, Color? colorOverride = null)
	{
		if (this.bloodSplatterParticle)
		{
			ParticleSystem component = this.bloodSplatterParticle.Spawn().GetComponent<ParticleSystem>();
			if (component)
			{
				component.Stop();
				component.emission.SetBursts(new ParticleSystem.Burst[]
				{
					new ParticleSystem.Burst(0f, (short)Mathf.RoundToInt((float)minCount * this.amountMultiplier), (short)Mathf.RoundToInt((float)maxCount * this.amountMultiplier))
				});
				ParticleSystem.MainModule main = component.main;
				main.maxParticles = Mathf.RoundToInt((float)maxCount * this.amountMultiplier);
				main.startSpeed = new ParticleSystem.MinMaxCurve(minSpeed * this.speedMultiplier, maxSpeed * this.speedMultiplier);
				if (colorOverride == null)
				{
					main.startColor = this.initialBloodColour;
				}
				else
				{
					main.startColor = new ParticleSystem.MinMaxGradient(colorOverride.Value);
				}
				component.shape.arc = angleMax - angleMin;
				component.transform.SetRotation2D(angleMin);
				component.transform.position = position;
				component.Play();
			}
		}
	}

	// Token: 0x06000B74 RID: 2932 RVA: 0x0003C8E8 File Offset: 0x0003AAE8
	public GlobalPrefabDefaults()
	{
		this.speedMultiplier = 1.2f;
		this.amountMultiplier = 1.3f;
		base..ctor();
	}

	// Token: 0x04000C63 RID: 3171
	public static GlobalPrefabDefaults Instance;

	// Token: 0x04000C64 RID: 3172
	public GameObject bloodSplatterParticle;

	// Token: 0x04000C65 RID: 3173
	public float speedMultiplier;

	// Token: 0x04000C66 RID: 3174
	public float amountMultiplier;

	// Token: 0x04000C67 RID: 3175
	private ParticleSystem.MinMaxGradient initialBloodColour;
}
