using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x02000029 RID: 41
public class SetRigidbodySimulated2D : FsmStateAction
{
	// Token: 0x06000108 RID: 264 RVA: 0x0000644C File Offset: 0x0000464C
	public override void Reset()
	{
		this.gameObject = null;
		this.isSimulated = true;
	}

	// Token: 0x06000109 RID: 265 RVA: 0x00006461 File Offset: 0x00004661
	public override void OnEnter()
	{
		this.DoSetIsKinematic();
		base.Finish();
	}

	// Token: 0x0600010A RID: 266 RVA: 0x00006470 File Offset: 0x00004670
	private void DoSetIsKinematic()
	{
		GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
		if (ownerDefaultTarget)
		{
			Rigidbody2D component = ownerDefaultTarget.GetComponent<Rigidbody2D>();
			if (component)
			{
				component.simulated = this.isSimulated.Value;
			}
		}
	}

	// Token: 0x040000BA RID: 186
	[RequiredField]
	[CheckForComponent(typeof(Rigidbody2D))]
	public FsmOwnerDefault gameObject;

	// Token: 0x040000BB RID: 187
	[RequiredField]
	public FsmBool isSimulated;
}
