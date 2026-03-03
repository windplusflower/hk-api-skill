using System;
using UnityEngine;

// Token: 0x020004AE RID: 1198
public class ProgressSaveMessagePanel : MonoBehaviour
{
	// Token: 0x06001A97 RID: 6807 RVA: 0x0007F63D File Offset: 0x0007D83D
	protected void OnEnable()
	{
		this.canvasGroup.alpha = (Platform.Current.IsSavingAllowedByEngagement ? 1f : 0f);
	}

	// Token: 0x04001FF3 RID: 8179
	[SerializeField]
	private CanvasGroup canvasGroup;
}
