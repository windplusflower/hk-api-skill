using System;
using UnityEngine.EventSystems;

// Token: 0x020004C0 RID: 1216
public class StartGameEventTrigger : MenuButtonListCondition, ISubmitHandler, IEventSystemHandler, IPointerClickHandler
{
	// Token: 0x06001AFA RID: 6906 RVA: 0x00080C26 File Offset: 0x0007EE26
	public void OnSubmit(BaseEventData eventData)
	{
		UIManager.instance.StartNewGame(this.permaDeath, this.bossRush);
	}

	// Token: 0x06001AFB RID: 6907 RVA: 0x00080C3E File Offset: 0x0007EE3E
	public void OnPointerClick(PointerEventData eventData)
	{
		this.OnSubmit(eventData);
	}

	// Token: 0x06001AFC RID: 6908 RVA: 0x00080C48 File Offset: 0x0007EE48
	public override bool IsFulfilled()
	{
		bool result = true;
		if (this.permaDeath && GameManager.instance.GetStatusRecordInt("RecPermadeathMode") == 0)
		{
			result = false;
		}
		if (this.bossRush && GameManager.instance.GetStatusRecordInt("RecBossRushMode") == 0)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x04002055 RID: 8277
	public bool permaDeath;

	// Token: 0x04002056 RID: 8278
	public bool bossRush;
}
