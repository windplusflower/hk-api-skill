using System;
using UnityEngine;

// Token: 0x0200046C RID: 1132
public class InvVesselFragments : MonoBehaviour
{
	// Token: 0x0600195F RID: 6495 RVA: 0x00078F50 File Offset: 0x00077150
	private void OnEnable()
	{
		if (this.playerData == null)
		{
			this.playerData = PlayerData.instance;
		}
		if (this.playerData.GetInt("MPReserveMax") == this.playerData.GetInt("MPReserveCap"))
		{
			this.full.sprite = this.fullSprite;
			this.self.sprite = this.emptySprite;
			this.piece1.sprite = this.emptySprite;
			this.piece2.sprite = this.emptySprite;
			return;
		}
		if (this.playerData.GetInt("vesselFragments") == 2)
		{
			this.full.sprite = this.emptySprite;
			this.self.sprite = this.backboardSprite;
			this.piece1.sprite = this.emptySprite;
			this.piece2.sprite = this.doublePieceSprite;
			return;
		}
		if (this.playerData.GetInt("vesselFragments") == 1)
		{
			this.full.sprite = this.emptySprite;
			this.self.sprite = this.backboardSprite;
			this.piece1.sprite = this.singlePieceSprite;
			this.piece2.sprite = this.emptySprite;
			return;
		}
		this.full.sprite = this.emptySprite;
		this.self.sprite = this.backboardSprite;
		this.piece1.sprite = this.emptySprite;
		this.piece2.sprite = this.emptySprite;
	}

	// Token: 0x04001E75 RID: 7797
	public SpriteRenderer self;

	// Token: 0x04001E76 RID: 7798
	public SpriteRenderer piece1;

	// Token: 0x04001E77 RID: 7799
	public SpriteRenderer piece2;

	// Token: 0x04001E78 RID: 7800
	public SpriteRenderer full;

	// Token: 0x04001E79 RID: 7801
	public Sprite backboardSprite;

	// Token: 0x04001E7A RID: 7802
	public Sprite singlePieceSprite;

	// Token: 0x04001E7B RID: 7803
	public Sprite doublePieceSprite;

	// Token: 0x04001E7C RID: 7804
	public Sprite fullSprite;

	// Token: 0x04001E7D RID: 7805
	public Sprite emptySprite;

	// Token: 0x04001E7E RID: 7806
	private PlayerData playerData;
}
