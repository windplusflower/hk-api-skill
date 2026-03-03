using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CCF RID: 3279
	[ActionCategory(ActionCategory.Physics)]
	[Tooltip("Sets the Mass of a Game Object's Rigid Body.")]
	public class SetMass : ComponentAction<Rigidbody>
	{
		// Token: 0x0600443B RID: 17467 RVA: 0x0017517C File Offset: 0x0017337C
		public override void Reset()
		{
			this.gameObject = null;
			this.mass = 1f;
		}

		// Token: 0x0600443C RID: 17468 RVA: 0x00175195 File Offset: 0x00173395
		public override void OnEnter()
		{
			this.DoSetMass();
			base.Finish();
		}

		// Token: 0x0600443D RID: 17469 RVA: 0x001751A4 File Offset: 0x001733A4
		private void DoSetMass()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (base.UpdateCache(ownerDefaultTarget))
			{
				base.rigidbody.mass = this.mass.Value;
			}
		}

		// Token: 0x04004885 RID: 18565
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004886 RID: 18566
		[RequiredField]
		[HasFloatSlider(0.1f, 10f)]
		public FsmFloat mass;
	}
}
