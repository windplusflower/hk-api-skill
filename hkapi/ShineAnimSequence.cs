using System;
using System.Collections;
using UnityEngine;

// Token: 0x0200008A RID: 138
public class ShineAnimSequence : MonoBehaviour
{
	// Token: 0x060002E4 RID: 740 RVA: 0x0000FAEF File Offset: 0x0000DCEF
	private void Start()
	{
		base.StartCoroutine(this.ShineSequence());
	}

	// Token: 0x060002E5 RID: 741 RVA: 0x0000FAFE File Offset: 0x0000DCFE
	private IEnumerator ShineSequence()
	{
		for (;;)
		{
			yield return new WaitForSeconds(this.sequencePauseTime);
			foreach (ShineAnimSequence.ShineObject shineObject in this.shineObjects)
			{
				if (shineObject.renderer.gameObject.activeInHierarchy)
				{
					this.StartCoroutine(shineObject.ShineAnim());
				}
				yield return new WaitForSeconds(this.shineDelay);
			}
			ShineAnimSequence.ShineObject[] array = null;
		}
		yield break;
	}

	// Token: 0x060002E6 RID: 742 RVA: 0x0000FB0D File Offset: 0x0000DD0D
	public ShineAnimSequence()
	{
		this.shineDelay = 0.5f;
		this.sequencePauseTime = 3f;
		base..ctor();
	}

	// Token: 0x04000266 RID: 614
	public ShineAnimSequence.ShineObject[] shineObjects;

	// Token: 0x04000267 RID: 615
	public float shineDelay;

	// Token: 0x04000268 RID: 616
	public float sequencePauseTime;

	// Token: 0x0200008B RID: 139
	[Serializable]
	public class ShineObject
	{
		// Token: 0x060002E7 RID: 743 RVA: 0x0000FB2B File Offset: 0x0000DD2B
		public IEnumerator ShineAnim()
		{
			if (this.renderer && this.shineSprites.Length != 0)
			{
				Sprite initialSprite = this.renderer.sprite;
				WaitForSeconds wait = new WaitForSeconds(1f / this.fps);
				foreach (Sprite sprite in this.shineSprites)
				{
					this.renderer.sprite = sprite;
					yield return wait;
				}
				Sprite[] array = null;
				this.renderer.sprite = initialSprite;
				initialSprite = null;
				wait = null;
			}
			yield break;
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x0000FB3A File Offset: 0x0000DD3A
		public ShineObject()
		{
			this.fps = 12f;
			base..ctor();
		}

		// Token: 0x04000269 RID: 617
		public SpriteRenderer renderer;

		// Token: 0x0400026A RID: 618
		public Sprite[] shineSprites;

		// Token: 0x0400026B RID: 619
		public float fps;
	}
}
