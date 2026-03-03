using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000452 RID: 1106
public class EngagedUserPanel : MonoBehaviour
{
	// Token: 0x060018D6 RID: 6358 RVA: 0x0007426D File Offset: 0x0007246D
	protected void Awake()
	{
		Platform.Current.EngagedDisplayInfoChanged += this.UpdateContent;
	}

	// Token: 0x060018D7 RID: 6359 RVA: 0x00074285 File Offset: 0x00072485
	protected void OnDestroy()
	{
		Platform.Current.EngagedDisplayInfoChanged -= this.UpdateContent;
	}

	// Token: 0x060018D8 RID: 6360 RVA: 0x0007429D File Offset: 0x0007249D
	protected void Start()
	{
		this.UpdateContent();
		base.enabled = false;
	}

	// Token: 0x060018D9 RID: 6361 RVA: 0x000742AC File Offset: 0x000724AC
	private void UpdateContent()
	{
		if (Platform.Current.EngagementRequirement == Platform.EngagementRequirements.Invisible)
		{
			this.canvasGroup.alpha = 0f;
			this.displayNameText.enabled = false;
			this.displayImageImage.enabled = false;
			return;
		}
		this.canvasGroup.alpha = 1f;
		this.displayNameText.enabled = true;
		this.displayNameText.text = (Platform.Current.EngagedDisplayName ?? "");
		Texture2D engagedDisplayImage = Platform.Current.EngagedDisplayImage;
		this.displayImageImage.enabled = (engagedDisplayImage != null);
		this.displayImageImage.texture = engagedDisplayImage;
	}

	// Token: 0x04001DC6 RID: 7622
	[SerializeField]
	private CanvasGroup canvasGroup;

	// Token: 0x04001DC7 RID: 7623
	[SerializeField]
	private Text displayNameText;

	// Token: 0x04001DC8 RID: 7624
	[SerializeField]
	private RawImage displayImageImage;
}
