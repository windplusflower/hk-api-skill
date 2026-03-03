using System;
using System.Collections;
using System.Text;
using Language;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

// Token: 0x02000445 RID: 1093
public class ContentPackDetailsUI : MonoBehaviour
{
	// Token: 0x06001892 RID: 6290 RVA: 0x000732D3 File Offset: 0x000714D3
	private void Awake()
	{
		ContentPackDetailsUI.Instance = this;
	}

	// Token: 0x06001893 RID: 6291 RVA: 0x000732DC File Offset: 0x000714DC
	public void ShowPackDetails(int index)
	{
		this.packDetailsIndex = index;
		if (MenuStyles.Instance)
		{
			this.oldMenuStyleIndex = MenuStyles.Instance.CurrentStyle;
			MenuStyles.Instance.SetStyle(this.details[this.packDetailsIndex].menuStyleIndex, true, false);
		}
	}

	// Token: 0x06001894 RID: 6292 RVA: 0x0007332A File Offset: 0x0007152A
	private void OnEnable()
	{
		base.StartCoroutine(this.UpdateDelayed());
	}

	// Token: 0x06001895 RID: 6293 RVA: 0x00073339 File Offset: 0x00071539
	private void OnDisable()
	{
		if (this.descriptionText)
		{
			this.descriptionText.text = "";
		}
	}

	// Token: 0x06001896 RID: 6294 RVA: 0x00073358 File Offset: 0x00071558
	private IEnumerator UpdateDelayed()
	{
		if (this.packDetailsIndex >= 0 && this.packDetailsIndex < this.details.Length)
		{
			ContentPackDetailsUI.ContentPackDetails contentPackDetails = this.details[this.packDetailsIndex];
			if (this.posterImage)
			{
				this.posterImage.sprite = contentPackDetails.posterSprite;
			}
			if (this.titleText)
			{
				this.titleText.text = Language.Get(contentPackDetails.titleText, this.languageSheet);
			}
			if (this.scrollRect)
			{
				this.scrollRect.verticalNormalizedPosition = 1f;
			}
			if (this.descriptionText)
			{
				string text = Language.Get(contentPackDetails.descriptionText, this.languageSheet);
				this.descriptionText.text = text.Replace("<br>", "\n");
				StringBuilder sb = new StringBuilder();
				sb.Append('\n', this.beforeSpaces);
				sb.Append(this.descriptionText.text);
				this.descriptionText.text = sb.ToString();
				while (!this.descriptionText.gameObject.activeInHierarchy)
				{
					yield return null;
				}
				yield return null;
				float preferredHeight = LayoutUtility.GetPreferredHeight(this.descriptionText.rectTransform);
				float height = this.scrollRect.viewport.rect.height;
				bool flag = preferredHeight > height;
				if (flag)
				{
					sb.Append('\n', this.afterSpaces);
				}
				if (this.softMask)
				{
					this.softMask.HardBlend = !flag;
				}
				this.descriptionText.text = sb.ToString();
				sb = null;
			}
		}
		else
		{
			Debug.LogError("Content Pack Details do not exist for index " + this.packDetailsIndex.ToString());
		}
		yield break;
	}

	// Token: 0x06001897 RID: 6295 RVA: 0x00073367 File Offset: 0x00071567
	public void UndoMenuStyle()
	{
		if (MenuStyles.Instance)
		{
			MenuStyles.Instance.SetStyle(this.oldMenuStyleIndex, true, true);
		}
	}

	// Token: 0x06001898 RID: 6296 RVA: 0x00073387 File Offset: 0x00071587
	public ContentPackDetailsUI()
	{
		this.languageSheet = "CP3";
		this.beforeSpaces = 1;
		this.afterSpaces = 3;
		base..ctor();
	}

	// Token: 0x04001D6D RID: 7533
	public static ContentPackDetailsUI Instance;

	// Token: 0x04001D6E RID: 7534
	public ContentPackDetailsUI.ContentPackDetails[] details;

	// Token: 0x04001D6F RID: 7535
	[Space]
	public Image posterImage;

	// Token: 0x04001D70 RID: 7536
	public Text titleText;

	// Token: 0x04001D71 RID: 7537
	public Text descriptionText;

	// Token: 0x04001D72 RID: 7538
	public SoftMaskScript softMask;

	// Token: 0x04001D73 RID: 7539
	public ScrollRect scrollRect;

	// Token: 0x04001D74 RID: 7540
	public string languageSheet;

	// Token: 0x04001D75 RID: 7541
	public int beforeSpaces;

	// Token: 0x04001D76 RID: 7542
	public int afterSpaces;

	// Token: 0x04001D77 RID: 7543
	private int oldMenuStyleIndex;

	// Token: 0x04001D78 RID: 7544
	private int packDetailsIndex;

	// Token: 0x02000446 RID: 1094
	[Serializable]
	public class ContentPackDetails
	{
		// Token: 0x04001D79 RID: 7545
		public Sprite posterSprite;

		// Token: 0x04001D7A RID: 7546
		public string titleText;

		// Token: 0x04001D7B RID: 7547
		[Multiline]
		public string descriptionText;

		// Token: 0x04001D7C RID: 7548
		public int menuStyleIndex;
	}
}
