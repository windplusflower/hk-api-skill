using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x020001CA RID: 458
[ActionCategory("Hollow Knight")]
public class SetRecoilSpeed : FsmStateAction
{
	// Token: 0x06000A1E RID: 2590 RVA: 0x0003789F File Offset: 0x00035A9F
	public override void Reset()
	{
		this.target = new FsmOwnerDefault();
		this.newRecoilSpeed = new FsmFloat();
	}

	// Token: 0x06000A1F RID: 2591 RVA: 0x000378B8 File Offset: 0x00035AB8
	public override void OnEnter()
	{
		GameObject gameObject = (this.target.OwnerOption == OwnerDefaultOption.UseOwner) ? base.Owner : this.target.GameObject.Value;
		if (gameObject != null)
		{
			Recoil component = gameObject.GetComponent<Recoil>();
			if (component != null)
			{
				component.SetRecoilSpeed(this.newRecoilSpeed.Value);
			}
		}
		base.Finish();
	}

	// Token: 0x04000B37 RID: 2871
	[UIHint(UIHint.Variable)]
	public FsmOwnerDefault target;

	// Token: 0x04000B38 RID: 2872
	public FsmFloat newRecoilSpeed;
}
