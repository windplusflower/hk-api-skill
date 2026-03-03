using System;
using InControl;
using UnityEngine;

// Token: 0x02000444 RID: 1092
public class ConnectControllerPanel : MonoBehaviour
{
	// Token: 0x0600188E RID: 6286 RVA: 0x00073243 File Offset: 0x00071443
	protected void Start()
	{
		if (!Platform.Current.WillEverPauseOnControllerDisconnected)
		{
			base.enabled = false;
			return;
		}
		this.UpdateContent();
	}

	// Token: 0x0600188F RID: 6287 RVA: 0x0007325F File Offset: 0x0007145F
	protected void Update()
	{
		this.UpdateContent();
	}

	// Token: 0x06001890 RID: 6288 RVA: 0x00073268 File Offset: 0x00071468
	private void UpdateContent()
	{
		InputDevice activeDevice = InputManager.ActiveDevice;
		GameManager instance = GameManager.instance;
		float num = (!Platform.Current.IsPausingOnControllerDisconnected) ? 0f : 1f;
		if (this.canvasGroup.alpha != num)
		{
			this.canvasGroup.alpha = Mathf.MoveTowards(this.canvasGroup.alpha, num, this.fadeRate * Time.unscaledDeltaTime);
		}
	}

	// Token: 0x04001D6B RID: 7531
	[SerializeField]
	private CanvasGroup canvasGroup;

	// Token: 0x04001D6C RID: 7532
	[SerializeField]
	private float fadeRate;
}
