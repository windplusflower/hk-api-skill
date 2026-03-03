using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x020003C7 RID: 967
[ActionCategory("Hollow Knight")]
public class GlowResponseEnd : FsmStateAction
{
	// Token: 0x0600163A RID: 5690 RVA: 0x00069442 File Offset: 0x00067642
	public override void Reset()
	{
		this.target = new FsmOwnerDefault();
	}

	// Token: 0x0600163B RID: 5691 RVA: 0x00069450 File Offset: 0x00067650
	public override void OnEnter()
	{
		GameObject gameObject = (this.target.OwnerOption == OwnerDefaultOption.UseOwner) ? base.Owner : this.target.GameObject.Value;
		if (gameObject != null)
		{
			GlowResponse component = gameObject.GetComponent<GlowResponse>();
			if (component != null)
			{
				component.FadeEnd();
			}
		}
		base.Finish();
	}

	// Token: 0x04001AA6 RID: 6822
	[UIHint(UIHint.Variable)]
	public FsmOwnerDefault target;
}
