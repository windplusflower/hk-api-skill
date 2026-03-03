using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A2A RID: 2602
	[ActionCategory("Object Pool")]
	[Tooltip("Recycles the Owner of the Fsm. Useful for Object Pool spawned Prefabs that need to kill themselves, e.g., a projectile that explodes on impact.")]
	public class RecycleSelf : FsmStateAction
	{
		// Token: 0x06003888 RID: 14472 RVA: 0x0013FCD3 File Offset: 0x0013DED3
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
