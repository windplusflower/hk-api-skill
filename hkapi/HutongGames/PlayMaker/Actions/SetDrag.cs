using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C9E RID: 3230
	[ActionCategory(ActionCategory.Physics)]
	[HelpUrl("http://hutonggames.com/playmakerforum/index.php?topic=4734.0")]
	[Tooltip("Sets the Drag of a Game Object's Rigid Body.")]
	public class SetDrag : ComponentAction<Rigidbody>
	{
		// Token: 0x06004366 RID: 17254 RVA: 0x00172F1F File Offset: 0x0017111F
		public override void Reset()
		{
			this.gameObject = null;
			this.drag = 1f;
		}

		// Token: 0x06004367 RID: 17255 RVA: 0x00172F38 File Offset: 0x00171138
		public override void OnEnter()
		{
			this.DoSetDrag();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004368 RID: 17256 RVA: 0x00172F4E File Offset: 0x0017114E
		public override void OnUpdate()
		{
			this.DoSetDrag();
		}

		// Token: 0x06004369 RID: 17257 RVA: 0x00172F58 File Offset: 0x00171158
		private void DoSetDrag()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (base.UpdateCache(ownerDefaultTarget))
			{
				base.rigidbody.drag = this.drag.Value;
			}
		}

		// Token: 0x040047A9 RID: 18345
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040047AA RID: 18346
		[RequiredField]
		[HasFloatSlider(0f, 10f)]
		public FsmFloat drag;

		// Token: 0x040047AB RID: 18347
		[Tooltip("Repeat every frame. Typically this would be set to True.")]
		public bool everyFrame;
	}
}
