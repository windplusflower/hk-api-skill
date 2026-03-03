using System;
using UnityEngine;

// Token: 0x02000135 RID: 309
public class GrassCut : MonoBehaviour
{
	// Token: 0x06000738 RID: 1848 RVA: 0x00029487 File Offset: 0x00027687
	private void Awake()
	{
		this.col = base.GetComponent<Collider2D>();
	}

	// Token: 0x06000739 RID: 1849 RVA: 0x00029498 File Offset: 0x00027698
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (GrassCut.ShouldCut(collision))
		{
			GrassBehaviour componentInParent = base.GetComponentInParent<GrassBehaviour>();
			SpriteRenderer[] array = this.disable;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].enabled = false;
			}
			array = this.enable;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].enabled = true;
			}
			Collider2D[] array2 = this.disableColliders;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].enabled = false;
			}
			array2 = this.enableColliders;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].enabled = true;
			}
			if (this.particles)
			{
				Renderer component = this.particles.GetComponent<Renderer>();
				if (component && componentInParent)
				{
					component.material.color = componentInParent.SharedMaterial.color;
				}
				this.particles.SetActive(true);
				this.particles.transform.position = new Vector3(this.particles.transform.position.x, this.particles.transform.position.y, this.particles.transform.position.z);
			}
			if (componentInParent)
			{
				componentInParent.CutReact(collision);
			}
			if (this.cutEffectPrefab)
			{
				Vector3 position = (collision.bounds.center + this.col.bounds.center) / 2f;
				float num = Mathf.Sign(base.transform.position.x - collision.transform.position.x);
				this.cutEffectPrefab.Spawn(position);
				this.cutEffectPrefab.transform.SetScaleX(-num * 0.6f);
				this.cutEffectPrefab.transform.SetScaleY(1f);
			}
			UnityEngine.Object.Destroy(this);
		}
	}

	// Token: 0x0600073A RID: 1850 RVA: 0x00029694 File Offset: 0x00027894
	public static bool ShouldCut(Collider2D collision)
	{
		return collision.tag == "Nail Attack" || (collision.tag == "HeroBox" && HeroController.instance.cState.superDashing) || collision.tag == "Sharp Shadow";
	}

	// Token: 0x040007F9 RID: 2041
	public SpriteRenderer[] disable;

	// Token: 0x040007FA RID: 2042
	public SpriteRenderer[] enable;

	// Token: 0x040007FB RID: 2043
	[Space]
	public Collider2D[] disableColliders;

	// Token: 0x040007FC RID: 2044
	public Collider2D[] enableColliders;

	// Token: 0x040007FD RID: 2045
	[Space]
	public GameObject particles;

	// Token: 0x040007FE RID: 2046
	public GameObject cutEffectPrefab;

	// Token: 0x040007FF RID: 2047
	private Collider2D col;
}
