using System;
using UnityEngine;

// Token: 0x02000404 RID: 1028
public class SetRandomSpriteId : MonoBehaviour, IExternalDebris
{
	// Token: 0x06001755 RID: 5973 RVA: 0x0006E709 File Offset: 0x0006C909
	protected void Awake()
	{
		this.sprite = base.GetComponent<tk2dSprite>();
	}

	// Token: 0x06001756 RID: 5974 RVA: 0x0006E718 File Offset: 0x0006C918
	public void Init()
	{
		if (this.sprite != null)
		{
			tk2dSpriteCollectionData collection = this.sprite.Collection;
			if (collection != null)
			{
				this.sprite.SetSprite(collection, UnityEngine.Random.Range(0, collection.Count));
			}
		}
	}

	// Token: 0x06001757 RID: 5975 RVA: 0x0006E760 File Offset: 0x0006C960
	void IExternalDebris.InitExternalDebris()
	{
		this.Init();
	}

	// Token: 0x04001C1B RID: 7195
	private tk2dSprite sprite;
}
