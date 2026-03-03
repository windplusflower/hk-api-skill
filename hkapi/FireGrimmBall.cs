using System;
using HutongGames.PlayMaker;

// Token: 0x020002B8 RID: 696
[ActionCategory("Hollow Knight")]
public class FireGrimmBall : FsmStateAction
{
	// Token: 0x06000EC1 RID: 3777 RVA: 0x00048F68 File Offset: 0x00047168
	public override void Reset()
	{
		this.storedObject = null;
		this.tweenY = null;
		this.force = null;
	}

	// Token: 0x06000EC2 RID: 3778 RVA: 0x00048F80 File Offset: 0x00047180
	public override void OnEnter()
	{
		if (this.storedObject.Value)
		{
			GrimmballControl component = this.storedObject.Value.GetComponent<GrimmballControl>();
			if (component)
			{
				component.TweenY = this.tweenY.Value;
				component.Force = this.force.Value;
				component.Fire();
			}
		}
		base.Finish();
	}

	// Token: 0x04000F79 RID: 3961
	[RequiredField]
	[UIHint(UIHint.Variable)]
	public FsmGameObject storedObject;

	// Token: 0x04000F7A RID: 3962
	public FsmFloat tweenY;

	// Token: 0x04000F7B RID: 3963
	public FsmFloat force;
}
