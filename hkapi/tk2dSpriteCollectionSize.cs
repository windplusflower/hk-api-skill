using System;

// Token: 0x02000589 RID: 1417
[Serializable]
public class tk2dSpriteCollectionSize
{
	// Token: 0x06001F50 RID: 8016 RVA: 0x0009BE96 File Offset: 0x0009A096
	public static tk2dSpriteCollectionSize Explicit(float orthoSize, float targetHeight)
	{
		return tk2dSpriteCollectionSize.ForResolution(orthoSize, targetHeight, targetHeight);
	}

	// Token: 0x06001F51 RID: 8017 RVA: 0x0009BEA0 File Offset: 0x0009A0A0
	public static tk2dSpriteCollectionSize PixelsPerMeter(float pixelsPerMeter)
	{
		return new tk2dSpriteCollectionSize
		{
			type = tk2dSpriteCollectionSize.Type.PixelsPerMeter,
			pixelsPerMeter = pixelsPerMeter
		};
	}

	// Token: 0x06001F52 RID: 8018 RVA: 0x0009BEB5 File Offset: 0x0009A0B5
	public static tk2dSpriteCollectionSize ForResolution(float orthoSize, float width, float height)
	{
		return new tk2dSpriteCollectionSize
		{
			type = tk2dSpriteCollectionSize.Type.Explicit,
			orthoSize = orthoSize,
			width = width,
			height = height
		};
	}

	// Token: 0x06001F53 RID: 8019 RVA: 0x0009BED8 File Offset: 0x0009A0D8
	public static tk2dSpriteCollectionSize ForTk2dCamera()
	{
		return new tk2dSpriteCollectionSize
		{
			type = tk2dSpriteCollectionSize.Type.PixelsPerMeter,
			pixelsPerMeter = 1f
		};
	}

	// Token: 0x06001F54 RID: 8020 RVA: 0x0009BEF4 File Offset: 0x0009A0F4
	public static tk2dSpriteCollectionSize ForTk2dCamera(tk2dCamera camera)
	{
		tk2dSpriteCollectionSize tk2dSpriteCollectionSize = new tk2dSpriteCollectionSize();
		tk2dCameraSettings cameraSettings = camera.SettingsRoot.CameraSettings;
		if (cameraSettings.projection == tk2dCameraSettings.ProjectionType.Orthographic)
		{
			tk2dCameraSettings.OrthographicType orthographicType = cameraSettings.orthographicType;
			if (orthographicType != tk2dCameraSettings.OrthographicType.PixelsPerMeter)
			{
				if (orthographicType == tk2dCameraSettings.OrthographicType.OrthographicSize)
				{
					tk2dSpriteCollectionSize.type = tk2dSpriteCollectionSize.Type.Explicit;
					tk2dSpriteCollectionSize.height = (float)camera.nativeResolutionHeight;
					tk2dSpriteCollectionSize.orthoSize = cameraSettings.orthographicSize;
				}
			}
			else
			{
				tk2dSpriteCollectionSize.type = tk2dSpriteCollectionSize.Type.PixelsPerMeter;
				tk2dSpriteCollectionSize.pixelsPerMeter = cameraSettings.orthographicPixelsPerMeter;
			}
		}
		else if (cameraSettings.projection == tk2dCameraSettings.ProjectionType.Perspective)
		{
			tk2dSpriteCollectionSize.type = tk2dSpriteCollectionSize.Type.PixelsPerMeter;
			tk2dSpriteCollectionSize.pixelsPerMeter = 100f;
		}
		return tk2dSpriteCollectionSize;
	}

	// Token: 0x06001F55 RID: 8021 RVA: 0x0009BF7E File Offset: 0x0009A17E
	public static tk2dSpriteCollectionSize Default()
	{
		return tk2dSpriteCollectionSize.PixelsPerMeter(100f);
	}

	// Token: 0x06001F56 RID: 8022 RVA: 0x0009BF8A File Offset: 0x0009A18A
	public void CopyFromLegacy(bool useTk2dCamera, float orthoSize, float targetHeight)
	{
		if (useTk2dCamera)
		{
			this.type = tk2dSpriteCollectionSize.Type.PixelsPerMeter;
			this.pixelsPerMeter = 1f;
			return;
		}
		this.type = tk2dSpriteCollectionSize.Type.Explicit;
		this.height = targetHeight;
		this.orthoSize = orthoSize;
	}

	// Token: 0x06001F57 RID: 8023 RVA: 0x0009BFB7 File Offset: 0x0009A1B7
	public void CopyFrom(tk2dSpriteCollectionSize source)
	{
		this.type = source.type;
		this.width = source.width;
		this.height = source.height;
		this.orthoSize = source.orthoSize;
		this.pixelsPerMeter = source.pixelsPerMeter;
	}

	// Token: 0x17000407 RID: 1031
	// (get) Token: 0x06001F58 RID: 8024 RVA: 0x0009BFF8 File Offset: 0x0009A1F8
	public float OrthoSize
	{
		get
		{
			tk2dSpriteCollectionSize.Type type = this.type;
			if (type == tk2dSpriteCollectionSize.Type.Explicit)
			{
				return this.orthoSize;
			}
			if (type != tk2dSpriteCollectionSize.Type.PixelsPerMeter)
			{
				return this.orthoSize;
			}
			return 0.5f;
		}
	}

	// Token: 0x17000408 RID: 1032
	// (get) Token: 0x06001F59 RID: 8025 RVA: 0x0009C028 File Offset: 0x0009A228
	public float TargetHeight
	{
		get
		{
			tk2dSpriteCollectionSize.Type type = this.type;
			if (type == tk2dSpriteCollectionSize.Type.Explicit)
			{
				return this.height;
			}
			if (type != tk2dSpriteCollectionSize.Type.PixelsPerMeter)
			{
				return this.height;
			}
			return this.pixelsPerMeter;
		}
	}

	// Token: 0x06001F5A RID: 8026 RVA: 0x0009C059 File Offset: 0x0009A259
	public tk2dSpriteCollectionSize()
	{
		this.type = tk2dSpriteCollectionSize.Type.PixelsPerMeter;
		this.orthoSize = 10f;
		this.pixelsPerMeter = 100f;
		this.width = 960f;
		this.height = 640f;
		base..ctor();
	}

	// Token: 0x04002551 RID: 9553
	public tk2dSpriteCollectionSize.Type type;

	// Token: 0x04002552 RID: 9554
	public float orthoSize;

	// Token: 0x04002553 RID: 9555
	public float pixelsPerMeter;

	// Token: 0x04002554 RID: 9556
	public float width;

	// Token: 0x04002555 RID: 9557
	public float height;

	// Token: 0x0200058A RID: 1418
	public enum Type
	{
		// Token: 0x04002557 RID: 9559
		Explicit,
		// Token: 0x04002558 RID: 9560
		PixelsPerMeter
	}
}
