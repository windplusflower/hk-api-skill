using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020004B2 RID: 1202
public class ResolutionCountdownTimer : MonoBehaviour
{
	// Token: 0x06001AA0 RID: 6816 RVA: 0x0007F6ED File Offset: 0x0007D8ED
	private void Start()
	{
		this.ih = GameManager.instance.inputHandler;
	}

	// Token: 0x06001AA1 RID: 6817 RVA: 0x0007F700 File Offset: 0x0007D900
	public void StartTimer()
	{
		this.currentTime = this.timerDuration;
		this.timerText.text = this.currentTime.ToString() + "s";
		this.running = true;
		base.StartCoroutine("CountDown");
	}

	// Token: 0x06001AA2 RID: 6818 RVA: 0x0007F74C File Offset: 0x0007D94C
	public void CancelTimer()
	{
		this.running = false;
		base.StopCoroutine("CountDown");
	}

	// Token: 0x06001AA3 RID: 6819 RVA: 0x0007F760 File Offset: 0x0007D960
	private void TickDown()
	{
		if (this.currentTime == 0)
		{
			this.timerText.text = "";
			this.running = false;
			this.CancelTimer();
			base.StartCoroutine(this.RollbackRes());
			return;
		}
		this.timerText.text = this.currentTime.ToString() + "s";
		this.currentTime--;
	}

	// Token: 0x06001AA4 RID: 6820 RVA: 0x0007F7CE File Offset: 0x0007D9CE
	private IEnumerator CountDown()
	{
		int num;
		for (int i = 0; i < 20; i = num + 1)
		{
			if (this.running)
			{
				this.TickDown();
				yield return this.StartCoroutine(GameManager.instance.timeTool.TimeScaleIndependentWaitForSeconds(1f));
			}
			num = i;
		}
		yield break;
	}

	// Token: 0x06001AA5 RID: 6821 RVA: 0x0007F7DD File Offset: 0x0007D9DD
	private IEnumerator RollbackRes()
	{
		this.ih.StopUIInput();
		yield return null;
		UIManager.instance.UIGoToVideoMenu(true);
		yield break;
	}

	// Token: 0x04001FF6 RID: 8182
	public int timerDuration;

	// Token: 0x04001FF7 RID: 8183
	public Text timerText;

	// Token: 0x04001FF8 RID: 8184
	private int currentTime;

	// Token: 0x04001FF9 RID: 8185
	private bool running;

	// Token: 0x04001FFA RID: 8186
	private InputHandler ih;
}
