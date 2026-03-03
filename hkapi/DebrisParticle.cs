using System;
using UnityEngine;

// Token: 0x0200011C RID: 284
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(tk2dSprite))]
public class DebrisParticle : MonoBehaviour
{
	// Token: 0x060006A8 RID: 1704 RVA: 0x00026E1A File Offset: 0x0002501A
	protected void Reset()
	{
		this.startZ = 0.019f;
		this.scaleMin = 1.25f;
		this.scaleMax = 2f;
		this.blackChance = 0.33333334f;
	}

	// Token: 0x060006A9 RID: 1705 RVA: 0x00026E48 File Offset: 0x00025048
	protected void Awake()
	{
		this.body = base.GetComponent<Rigidbody2D>();
		this.sprite = base.GetComponent<tk2dSprite>();
	}

	// Token: 0x060006AA RID: 1706 RVA: 0x00026E64 File Offset: 0x00025064
	protected void OnEnable()
	{
		if (this.randomSpriteIds.Length != 0)
		{
			this.sprite.SetSprite(this.sprite.Collection, this.randomSpriteIds[UnityEngine.Random.Range(0, this.randomSpriteIds.Length)]);
		}
		Vector3 position = base.transform.position;
		position.z = this.startZ;
		base.transform.position = position;
		float num = UnityEngine.Random.Range(this.scaleMin, this.scaleMax);
		Vector3 localScale = base.transform.localScale;
		localScale.x = num;
		localScale.y = num;
		base.transform.localScale = localScale;
		if (UnityEngine.Random.Range(0f, 1f) < this.blackChance)
		{
			this.sprite.color = Color.black;
			position.z -= 0.05f;
			base.transform.position = position;
		}
		else
		{
			this.sprite.color = Color.white;
		}
		this.didSpin = false;
	}

	// Token: 0x060006AB RID: 1707 RVA: 0x00026F61 File Offset: 0x00025161
	protected void Update()
	{
		if (!this.didSpin)
		{
			this.didSpin = true;
			this.body.AddTorque(-this.body.velocity.x, ForceMode2D.Force);
		}
	}

	// Token: 0x0400073D RID: 1853
	private Rigidbody2D body;

	// Token: 0x0400073E RID: 1854
	private tk2dSprite sprite;

	// Token: 0x0400073F RID: 1855
	[SerializeField]
	private string[] randomSpriteIds;

	// Token: 0x04000740 RID: 1856
	[SerializeField]
	private float startZ;

	// Token: 0x04000741 RID: 1857
	[SerializeField]
	private float scaleMin;

	// Token: 0x04000742 RID: 1858
	[SerializeField]
	private float scaleMax;

	// Token: 0x04000743 RID: 1859
	[SerializeField]
	private float blackChance;

	// Token: 0x04000744 RID: 1860
	private bool didSpin;
}
