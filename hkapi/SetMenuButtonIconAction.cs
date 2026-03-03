using System;
using HutongGames.PlayMaker;

// Token: 0x02000488 RID: 1160
[ActionCategory("Hollow Knight")]
public class SetMenuButtonIconAction : FsmStateAction
{
	// Token: 0x06001A0F RID: 6671 RVA: 0x0007D720 File Offset: 0x0007B920
	public override void Reset()
	{
		this.target = null;
		this.menuAction = null;
	}

	// Token: 0x06001A10 RID: 6672 RVA: 0x0007D730 File Offset: 0x0007B930
	public override void OnEnter()
	{
		if (this.target.Value)
		{
			MenuButtonIcon componentInChildren = this.target.Value.GetComponentInChildren<MenuButtonIcon>();
			if (componentInChildren)
			{
				componentInChildren.menuAction = (Platform.MenuActions)this.menuAction.Value;
				componentInChildren.RefreshButtonIcon();
			}
		}
		base.Finish();
	}

	// Token: 0x04001F6D RID: 8045
	public FsmGameObject target;

	// Token: 0x04001F6E RID: 8046
	[ObjectType(typeof(Platform.MenuActions))]
	public FsmEnum menuAction;
}
