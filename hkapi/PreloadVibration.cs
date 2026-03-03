using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x02000508 RID: 1288
[ActionCategory("Hollow Knight")]
public class PreloadVibration : FsmStateAction
{
	// Token: 0x06001C62 RID: 7266 RVA: 0x00085924 File Offset: 0x00083B24
	public override void Reset()
	{
		base.Reset();
		this.lowFidelityVibration = new FsmEnum
		{
			UseVariable = false
		};
		this.highFidelityVibration = new FsmObject
		{
			UseVariable = false
		};
	}

	// Token: 0x06001C63 RID: 7267 RVA: 0x00085950 File Offset: 0x00083B50
	public override void OnEnter()
	{
		base.OnEnter();
		base.Finish();
	}

	// Token: 0x04002208 RID: 8712
	[ObjectType(typeof(LowFidelityVibrations))]
	private FsmEnum lowFidelityVibration;

	// Token: 0x04002209 RID: 8713
	[ObjectType(typeof(TextAsset))]
	private FsmObject highFidelityVibration;
}
