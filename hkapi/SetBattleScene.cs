using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x0200019F RID: 415
[ActionCategory("Hollow Knight")]
public class SetBattleScene : FsmStateAction
{
	// Token: 0x06000958 RID: 2392 RVA: 0x0003402E File Offset: 0x0003222E
	public override void Reset()
	{
		this.target = new FsmOwnerDefault();
		this.battleScene = new FsmGameObject();
	}

	// Token: 0x06000959 RID: 2393 RVA: 0x00034048 File Offset: 0x00032248
	public override void OnEnter()
	{
		GameObject gameObject = (this.target.OwnerOption == OwnerDefaultOption.UseOwner) ? base.Owner : this.target.GameObject.Value;
		if (gameObject != null)
		{
			HealthManager component = gameObject.GetComponent<HealthManager>();
			if (component != null)
			{
				component.SetBattleScene(this.battleScene.Value);
			}
		}
		base.Finish();
	}

	// Token: 0x04000A7C RID: 2684
	[UIHint(UIHint.Variable)]
	public FsmOwnerDefault target;

	// Token: 0x04000A7D RID: 2685
	[UIHint(UIHint.Variable)]
	public FsmGameObject battleScene;
}
