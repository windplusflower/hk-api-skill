using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B2F RID: 2863
	public abstract class BaseAnimationAction : ComponentAction<Animation>
	{
		// Token: 0x06003D3E RID: 15678 RVA: 0x00160688 File Offset: 0x0015E888
		public override void OnActionTargetInvoked(object targetObject)
		{
			AnimationClip animationClip = targetObject as AnimationClip;
			if (animationClip == null)
			{
				return;
			}
			Animation component = base.Owner.GetComponent<Animation>();
			if (component != null)
			{
				component.AddClip(animationClip, animationClip.name);
			}
		}
	}
}
