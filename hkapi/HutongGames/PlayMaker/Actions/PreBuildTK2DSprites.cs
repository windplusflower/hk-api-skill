using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A08 RID: 2568
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Activate or deactivate all children on a GameObject.")]
	public class PreBuildTK2DSprites : FsmStateAction
	{
		// Token: 0x060037E1 RID: 14305 RVA: 0x00148422 File Offset: 0x00146622
		public override void Reset()
		{
			this.gameObject = null;
			this.useChildren = true;
		}

		// Token: 0x060037E2 RID: 14306 RVA: 0x00148434 File Offset: 0x00146634
		public override void OnEnter()
		{
			GameObject value = this.gameObject.Value;
			if (value != null)
			{
				tk2dSprite[] array = this.useChildren ? value.GetComponentsInChildren<tk2dSprite>(true) : value.GetComponents<tk2dSprite>();
				for (int i = 0; i < array.Length; i++)
				{
					array[i].ForceBuild();
				}
			}
			base.Finish();
		}

		// Token: 0x04003A65 RID: 14949
		[RequiredField]
		public FsmGameObject gameObject;

		// Token: 0x04003A66 RID: 14950
		public bool useChildren;
	}
}
