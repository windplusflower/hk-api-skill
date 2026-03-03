using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CD9 RID: 3289
	[ActionCategory(ActionCategory.Transform)]
	[Tooltip("Sets the Position of a Game Object to another Game Object's position")]
	public class SetPositionToObject : FsmStateAction
	{
		// Token: 0x06004467 RID: 17511 RVA: 0x00175A9B File Offset: 0x00173C9B
		public override void Reset()
		{
			this.gameObject = null;
			this.targetObject = null;
			this.xOffset = null;
			this.yOffset = null;
			this.zOffset = null;
		}

		// Token: 0x06004468 RID: 17512 RVA: 0x00175AC0 File Offset: 0x00173CC0
		public override void OnEnter()
		{
			this.DoSetPosition();
			base.Finish();
		}

		// Token: 0x06004469 RID: 17513 RVA: 0x00175AD0 File Offset: 0x00173CD0
		private void DoSetPosition()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null || this.targetObject.IsNone || this.targetObject.Value == null)
			{
				return;
			}
			Vector3 position = this.targetObject.Value.transform.position;
			if (!this.xOffset.IsNone)
			{
				position = new Vector3(position.x + this.xOffset.Value, position.y, position.z);
			}
			if (!this.yOffset.IsNone)
			{
				position = new Vector3(position.x, position.y + this.yOffset.Value, position.z);
			}
			if (!this.zOffset.IsNone)
			{
				position = new Vector3(position.x, position.y, position.z + this.zOffset.Value);
			}
			ownerDefaultTarget.transform.position = position;
		}

		// Token: 0x040048B0 RID: 18608
		[RequiredField]
		[Tooltip("The GameObject to position.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040048B1 RID: 18609
		public FsmGameObject targetObject;

		// Token: 0x040048B2 RID: 18610
		public FsmFloat xOffset;

		// Token: 0x040048B3 RID: 18611
		public FsmFloat yOffset;

		// Token: 0x040048B4 RID: 18612
		public FsmFloat zOffset;
	}
}
