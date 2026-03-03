using System;
using UnityEngine;

// Token: 0x020000D4 RID: 212
[RequireComponent(typeof(LightBlurredBackground))]
public class BlurManager : MonoBehaviour
{
	// Token: 0x06000455 RID: 1109 RVA: 0x00014F58 File Offset: 0x00013158
	protected void Awake()
	{
		this.appliedShaderQuality = ShaderQualities.High;
		this.lightBlurredBackground = base.GetComponent<LightBlurredBackground>();
		int renderTextureHeight = this.baseHeight;
		if (Application.isConsolePlatform)
		{
			renderTextureHeight = this.largeConsoleHeight;
		}
		this.lightBlurredBackground.RenderTextureHeight = renderTextureHeight;
	}

	// Token: 0x06000456 RID: 1110 RVA: 0x00014F9C File Offset: 0x0001319C
	protected void Update()
	{
		GameManager unsafeInstance = GameManager.UnsafeInstance;
		if (unsafeInstance != null)
		{
			ShaderQualities shaderQuality = unsafeInstance.gameSettings.shaderQuality;
			if (shaderQuality != this.appliedShaderQuality)
			{
				this.appliedShaderQuality = shaderQuality;
				if (shaderQuality <= ShaderQualities.Medium)
				{
					this.lightBlurredBackground.PassGroupCount = ((shaderQuality == ShaderQualities.Low) ? 1 : 2);
					this.lightBlurredBackground.enabled = true;
					return;
				}
				this.lightBlurredBackground.enabled = false;
			}
		}
	}

	// Token: 0x040003D9 RID: 985
	private ShaderQualities appliedShaderQuality;

	// Token: 0x040003DA RID: 986
	private LightBlurredBackground lightBlurredBackground;

	// Token: 0x040003DB RID: 987
	[SerializeField]
	private int baseHeight;

	// Token: 0x040003DC RID: 988
	[SerializeField]
	private int largeConsoleHeight;
}
