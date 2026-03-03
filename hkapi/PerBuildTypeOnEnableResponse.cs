using System;
using GlobalEnums;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x020004EA RID: 1258
public class PerBuildTypeOnEnableResponse : MonoBehaviour
{
	// Token: 0x06001BD4 RID: 7124 RVA: 0x000846D8 File Offset: 0x000828D8
	private void OnEnable()
	{
		BuildTypes buildTypes = BuildTypes.Regular;
		BuildTypes[] array = this.buildTypes;
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] == buildTypes)
			{
				this.DoEvent(true);
				return;
			}
		}
		this.DoEvent(false);
	}

	// Token: 0x06001BD5 RID: 7125 RVA: 0x00084714 File Offset: 0x00082914
	private void DoEvent(bool value)
	{
		if (value)
		{
			UnityEvent onIsBuildType = this.OnIsBuildType;
			if (onIsBuildType != null)
			{
				onIsBuildType.Invoke();
			}
			foreach (PerBuildTypeOnEnableResponse.Tk2dSpriteColorResponse tk2dSpriteColorResponse in this.isBuildTypeColor)
			{
				if (tk2dSpriteColorResponse.Sprite)
				{
					tk2dSpriteColorResponse.Sprite.color = tk2dSpriteColorResponse.Color;
				}
			}
			return;
		}
		UnityEvent onNotBuildType = this.OnNotBuildType;
		if (onNotBuildType != null)
		{
			onNotBuildType.Invoke();
		}
		foreach (PerBuildTypeOnEnableResponse.Tk2dSpriteColorResponse tk2dSpriteColorResponse2 in this.notBuildTypeColor)
		{
			if (tk2dSpriteColorResponse2.Sprite)
			{
				tk2dSpriteColorResponse2.Sprite.color = tk2dSpriteColorResponse2.Color;
			}
		}
	}

	// Token: 0x040021BC RID: 8636
	[SerializeField]
	private BuildTypes[] buildTypes;

	// Token: 0x040021BD RID: 8637
	[Space]
	public UnityEvent OnIsBuildType;

	// Token: 0x040021BE RID: 8638
	[SerializeField]
	private PerBuildTypeOnEnableResponse.Tk2dSpriteColorResponse[] isBuildTypeColor;

	// Token: 0x040021BF RID: 8639
	[Space]
	public UnityEvent OnNotBuildType;

	// Token: 0x040021C0 RID: 8640
	[SerializeField]
	private PerBuildTypeOnEnableResponse.Tk2dSpriteColorResponse[] notBuildTypeColor;

	// Token: 0x020004EB RID: 1259
	[Serializable]
	private struct Tk2dSpriteColorResponse
	{
		// Token: 0x040021C1 RID: 8641
		public tk2dSprite Sprite;

		// Token: 0x040021C2 RID: 8642
		public Color Color;
	}
}
