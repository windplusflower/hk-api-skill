using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000458 RID: 1112
public class GameCameraTextureDisplay : MonoBehaviour
{
	// Token: 0x060018EF RID: 6383 RVA: 0x00074B8D File Offset: 0x00072D8D
	private void Awake()
	{
		GameCameraTextureDisplay.Instance = this;
	}

	// Token: 0x060018F0 RID: 6384 RVA: 0x00074B98 File Offset: 0x00072D98
	private void LateUpdate()
	{
		if (this.image)
		{
			if (GameManager.instance && GameManager.instance.sceneName != "Menu_Title")
			{
				this.image.texture = this.texture;
				if (this.image.texture == null)
				{
					this.image.enabled = false;
				}
				else
				{
					this.image.enabled = true;
				}
			}
			else
			{
				this.image.enabled = false;
			}
			if (this.altImage)
			{
				this.altImage.enabled = !this.image.enabled;
			}
		}
	}

	// Token: 0x060018F1 RID: 6385 RVA: 0x00074C4C File Offset: 0x00072E4C
	public void UpdateDisplay(RenderTexture source, Material material)
	{
		if (base.gameObject.activeInHierarchy)
		{
			if (this.texture == null)
			{
				this.texture = new RenderTexture(source.width, source.height, source.depth);
			}
			Graphics.Blit(source, GameCameraTextureDisplay.Instance.texture, material);
		}
	}

	// Token: 0x04001DE2 RID: 7650
	public static GameCameraTextureDisplay Instance;

	// Token: 0x04001DE3 RID: 7651
	private RenderTexture texture;

	// Token: 0x04001DE4 RID: 7652
	public RawImage image;

	// Token: 0x04001DE5 RID: 7653
	public Image altImage;
}
