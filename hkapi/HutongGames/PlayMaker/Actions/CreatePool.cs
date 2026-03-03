using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009AA RID: 2474
	[ActionCategory("Object Pool")]
	[Tooltip("Creates an Object Pool")]
	public class CreatePool : FsmStateAction
	{
		// Token: 0x06003631 RID: 13873 RVA: 0x0013FCD3 File Offset: 0x0013DED3
		public override void OnEnter()
		{
			if (base.Owner != null)
			{
				base.Owner.Recycle();
			}
			base.Finish();
		}
	}
}
