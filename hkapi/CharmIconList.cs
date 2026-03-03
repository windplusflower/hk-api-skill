using System;
using UnityEngine;

// Token: 0x0200043F RID: 1087
public class CharmIconList : MonoBehaviour
{
	// Token: 0x0600187B RID: 6267 RVA: 0x00072F5E File Offset: 0x0007115E
	private void Awake()
	{
		CharmIconList.Instance = this;
	}

	// Token: 0x0600187C RID: 6268 RVA: 0x00072F66 File Offset: 0x00071166
	private void Start()
	{
		this.playerData = PlayerData.instance;
	}

	// Token: 0x0600187D RID: 6269 RVA: 0x00072F74 File Offset: 0x00071174
	public Sprite GetSprite(int id)
	{
		this.playerData = PlayerData.instance;
		if (id == 23)
		{
			if (this.playerData.GetBool("fragileHealth_unbreakable"))
			{
				return this.unbreakableHeart;
			}
		}
		else if (id == 24)
		{
			if (this.playerData.GetBool("fragileGreed_unbreakable"))
			{
				return this.unbreakableGreed;
			}
		}
		else if (id == 25)
		{
			if (this.playerData.GetBool("fragileStrength_unbreakable"))
			{
				return this.unbreakableStrength;
			}
		}
		else if (id == 40)
		{
			if (this.playerData.GetInt("grimmChildLevel") == 1)
			{
				return this.grimmchildLevel1;
			}
			if (this.playerData.GetInt("grimmChildLevel") == 2)
			{
				return this.grimmchildLevel2;
			}
			if (this.playerData.GetInt("grimmChildLevel") == 3)
			{
				return this.grimmchildLevel3;
			}
			if (this.playerData.GetInt("grimmChildLevel") == 4)
			{
				return this.grimmchildLevel4;
			}
			if (this.playerData.GetInt("grimmChildLevel") == 5)
			{
				return this.nymmCharm;
			}
		}
		return this.spriteList[id];
	}

	// Token: 0x04001D52 RID: 7506
	public static CharmIconList Instance;

	// Token: 0x04001D53 RID: 7507
	public Sprite[] spriteList;

	// Token: 0x04001D54 RID: 7508
	public Sprite unbreakableHeart;

	// Token: 0x04001D55 RID: 7509
	public Sprite unbreakableGreed;

	// Token: 0x04001D56 RID: 7510
	public Sprite unbreakableStrength;

	// Token: 0x04001D57 RID: 7511
	public Sprite grimmchildLevel1;

	// Token: 0x04001D58 RID: 7512
	public Sprite grimmchildLevel2;

	// Token: 0x04001D59 RID: 7513
	public Sprite grimmchildLevel3;

	// Token: 0x04001D5A RID: 7514
	public Sprite grimmchildLevel4;

	// Token: 0x04001D5B RID: 7515
	public Sprite nymmCharm;

	// Token: 0x04001D5C RID: 7516
	private PlayerData playerData;
}
