using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x02000188 RID: 392
[ActionCategory("Hollow Knight")]
public class SetDreamNailConvo : FsmStateAction
{
	// Token: 0x060008D5 RID: 2261 RVA: 0x00030984 File Offset: 0x0002EB84
	public override void Reset()
	{
		this.target = new FsmOwnerDefault();
		this.title = new FsmString
		{
			UseVariable = false
		};
	}

	// Token: 0x060008D6 RID: 2262 RVA: 0x000309A4 File Offset: 0x0002EBA4
	public override void OnEnter()
	{
		GameObject gameObject = (this.target.OwnerOption == OwnerDefaultOption.UseOwner) ? base.Owner : this.target.GameObject.Value;
		if (gameObject != null)
		{
			EnemyDreamnailReaction component = gameObject.GetComponent<EnemyDreamnailReaction>();
			if (component != null && !this.title.IsNone)
			{
				component.SetConvoTitle(this.title.Value);
			}
		}
		base.Finish();
	}

	// Token: 0x040009D2 RID: 2514
	[UIHint(UIHint.Variable)]
	public FsmOwnerDefault target;

	// Token: 0x040009D3 RID: 2515
	public FsmString title;
}
