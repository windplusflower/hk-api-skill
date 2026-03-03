using System;
using GlobalEnums;
using UnityEngine;

// Token: 0x020004C8 RID: 1224
public class ButtonSkin
{
	// Token: 0x06001B3F RID: 6975 RVA: 0x00082FD6 File Offset: 0x000811D6
	public ButtonSkin(Sprite startSprite, string startSymbol, ButtonSkinType startSkinType)
	{
		this.sprite = startSprite;
		this.symbol = startSymbol;
		this.skinType = startSkinType;
	}

	// Token: 0x040020B4 RID: 8372
	public Sprite sprite;

	// Token: 0x040020B5 RID: 8373
	public string symbol;

	// Token: 0x040020B6 RID: 8374
	public ButtonSkinType skinType;
}
