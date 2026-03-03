using System;
using System.Collections.Generic;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x020001B2 RID: 434
[ActionCategory("Hollow Knight")]
public class PlayHitEffects : FsmStateAction
{
	// Token: 0x06000990 RID: 2448 RVA: 0x000348D8 File Offset: 0x00032AD8
	public override void Awake()
	{
		base.Awake();
		this.hitEffectRecievers = new List<IHitEffectReciever>();
	}

	// Token: 0x06000991 RID: 2449 RVA: 0x000348EB File Offset: 0x00032AEB
	public override void Reset()
	{
		this.target = new FsmOwnerDefault();
		this.attackDirection = new FsmFloat();
	}

	// Token: 0x06000992 RID: 2450 RVA: 0x00034904 File Offset: 0x00032B04
	public override void OnEnter()
	{
		GameObject gameObject = (this.target.OwnerOption == OwnerDefaultOption.UseOwner) ? base.Owner : this.target.GameObject.Value;
		if (gameObject != null)
		{
			this.hitEffectRecievers.Clear();
			gameObject.GetComponents<IHitEffectReciever>(this.hitEffectRecievers);
			for (int i = 0; i < this.hitEffectRecievers.Count; i++)
			{
				this.hitEffectRecievers[i].RecieveHitEffect(this.attackDirection.Value);
			}
			this.hitEffectRecievers.Clear();
		}
		base.Finish();
	}

	// Token: 0x04000AA3 RID: 2723
	[UIHint(UIHint.Variable)]
	public FsmOwnerDefault target;

	// Token: 0x04000AA4 RID: 2724
	[UIHint(UIHint.Variable)]
	public FsmFloat attackDirection;

	// Token: 0x04000AA5 RID: 2725
	private List<IHitEffectReciever> hitEffectRecievers;
}
