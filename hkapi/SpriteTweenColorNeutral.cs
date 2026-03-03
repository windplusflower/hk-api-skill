using System;
using System.Collections;
using UnityEngine;

// Token: 0x0200040E RID: 1038
public class SpriteTweenColorNeutral : MonoBehaviour
{
	// Token: 0x0600177E RID: 6014 RVA: 0x0006F128 File Offset: 0x0006D328
	private void ColorReturnNeutral()
	{
		tk2dSprite component = base.GetComponent<tk2dSprite>();
		Hashtable hashtable = new Hashtable();
		hashtable.Add("from", component.color);
		hashtable.Add("to", this.Color);
		hashtable.Add("time", this.Duration);
		hashtable.Add("OnUpdate", "updateSpriteColor");
		hashtable.Add("looptype", iTween.LoopType.none);
		hashtable.Add("easetype", iTween.EaseType.linear);
		iTween.ValueTo(base.gameObject, hashtable);
	}

	// Token: 0x0600177F RID: 6015 RVA: 0x0006F1C3 File Offset: 0x0006D3C3
	private void updateSpriteColor(Color color)
	{
		base.GetComponent<tk2dSprite>().color = color;
	}

	// Token: 0x06001780 RID: 6016 RVA: 0x00003603 File Offset: 0x00001803
	private void onEnable()
	{
	}

	// Token: 0x06001781 RID: 6017 RVA: 0x0006F1D1 File Offset: 0x0006D3D1
	public SpriteTweenColorNeutral()
	{
		this.Color = new Color(1f, 1f, 1f, 1f);
		this.Duration = 0.25f;
		base..ctor();
	}

	// Token: 0x04001C48 RID: 7240
	private Color Color;

	// Token: 0x04001C49 RID: 7241
	private float Duration;
}
