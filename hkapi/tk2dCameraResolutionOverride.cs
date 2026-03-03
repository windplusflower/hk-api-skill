using System;
using UnityEngine;

// Token: 0x02000540 RID: 1344
[Serializable]
public class tk2dCameraResolutionOverride
{
	// Token: 0x06001D69 RID: 7529 RVA: 0x00091EAC File Offset: 0x000900AC
	public bool Match(int pixelWidth, int pixelHeight)
	{
		switch (this.matchBy)
		{
		case tk2dCameraResolutionOverride.MatchByType.Resolution:
			return pixelWidth == this.width && pixelHeight == this.height;
		case tk2dCameraResolutionOverride.MatchByType.AspectRatio:
			return Mathf.Abs((float)pixelHeight / (float)pixelWidth * this.aspectRatioNumerator - this.aspectRatioDenominator) < 0.05f;
		case tk2dCameraResolutionOverride.MatchByType.Wildcard:
			return true;
		default:
			return false;
		}
	}

	// Token: 0x06001D6A RID: 7530 RVA: 0x00091F0C File Offset: 0x0009010C
	public void Upgrade(int version)
	{
		if (version == 0)
		{
			this.matchBy = (((this.width == -1 && this.height == -1) || (this.width == 0 && this.height == 0)) ? tk2dCameraResolutionOverride.MatchByType.Wildcard : tk2dCameraResolutionOverride.MatchByType.Resolution);
		}
	}

	// Token: 0x170003AB RID: 939
	// (get) Token: 0x06001D6B RID: 7531 RVA: 0x00091F3D File Offset: 0x0009013D
	public static tk2dCameraResolutionOverride DefaultOverride
	{
		get
		{
			return new tk2dCameraResolutionOverride
			{
				name = "Override",
				matchBy = tk2dCameraResolutionOverride.MatchByType.Wildcard,
				autoScaleMode = tk2dCameraResolutionOverride.AutoScaleMode.FitVisible,
				fitMode = tk2dCameraResolutionOverride.FitMode.Center
			};
		}
	}

	// Token: 0x06001D6C RID: 7532 RVA: 0x00091F64 File Offset: 0x00090164
	public tk2dCameraResolutionOverride()
	{
		this.aspectRatioNumerator = 4f;
		this.aspectRatioDenominator = 3f;
		this.scale = 1f;
		this.offsetPixels = new Vector2(0f, 0f);
		base..ctor();
	}

	// Token: 0x040022E6 RID: 8934
	public string name;

	// Token: 0x040022E7 RID: 8935
	public tk2dCameraResolutionOverride.MatchByType matchBy;

	// Token: 0x040022E8 RID: 8936
	public int width;

	// Token: 0x040022E9 RID: 8937
	public int height;

	// Token: 0x040022EA RID: 8938
	public float aspectRatioNumerator;

	// Token: 0x040022EB RID: 8939
	public float aspectRatioDenominator;

	// Token: 0x040022EC RID: 8940
	public float scale;

	// Token: 0x040022ED RID: 8941
	public Vector2 offsetPixels;

	// Token: 0x040022EE RID: 8942
	public tk2dCameraResolutionOverride.AutoScaleMode autoScaleMode;

	// Token: 0x040022EF RID: 8943
	public tk2dCameraResolutionOverride.FitMode fitMode;

	// Token: 0x02000541 RID: 1345
	public enum MatchByType
	{
		// Token: 0x040022F1 RID: 8945
		Resolution,
		// Token: 0x040022F2 RID: 8946
		AspectRatio,
		// Token: 0x040022F3 RID: 8947
		Wildcard
	}

	// Token: 0x02000542 RID: 1346
	public enum AutoScaleMode
	{
		// Token: 0x040022F5 RID: 8949
		None,
		// Token: 0x040022F6 RID: 8950
		FitWidth,
		// Token: 0x040022F7 RID: 8951
		FitHeight,
		// Token: 0x040022F8 RID: 8952
		FitVisible,
		// Token: 0x040022F9 RID: 8953
		StretchToFit,
		// Token: 0x040022FA RID: 8954
		ClosestMultipleOfTwo,
		// Token: 0x040022FB RID: 8955
		PixelPerfect,
		// Token: 0x040022FC RID: 8956
		Fill
	}

	// Token: 0x02000543 RID: 1347
	public enum FitMode
	{
		// Token: 0x040022FE RID: 8958
		Constant,
		// Token: 0x040022FF RID: 8959
		Center
	}
}
