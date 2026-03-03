using System;
using HutongGames.PlayMaker;

// Token: 0x02000394 RID: 916
public class HidePromptMarker : FsmStateAction
{
	// Token: 0x06001536 RID: 5430 RVA: 0x00064902 File Offset: 0x00062B02
	public override void Reset()
	{
		this.storedObject = new FsmGameObject();
	}

	// Token: 0x06001537 RID: 5431 RVA: 0x00064910 File Offset: 0x00062B10
	public override void OnEnter()
	{
		if (this.storedObject.Value)
		{
			PromptMarker component = this.storedObject.Value.GetComponent<PromptMarker>();
			if (component)
			{
				component.Hide();
				this.storedObject.Value = null;
			}
		}
		base.Finish();
	}

	// Token: 0x04001943 RID: 6467
	[UIHint(UIHint.Variable)]
	public FsmGameObject storedObject;
}
