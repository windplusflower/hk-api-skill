using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AE3 RID: 2787
	[ActionCategory(ActionCategory.Physics2D)]
	[Tooltip("Sets the Mass of a Game Object's Rigid Body 2D.")]
	public class SetMass2d : ComponentAction<Rigidbody2D>
	{
		// Token: 0x06003BDC RID: 15324 RVA: 0x00159083 File Offset: 0x00157283
		public override void Reset()
		{
			this.gameObject = null;
			this.mass = 1f;
		}

		// Token: 0x06003BDD RID: 15325 RVA: 0x0015909C File Offset: 0x0015729C
		public override void OnEnter()
		{
			this.DoSetMass();
			base.Finish();
		}

		// Token: 0x06003BDE RID: 15326 RVA: 0x001590AC File Offset: 0x001572AC
		private void DoSetMass()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (!base.UpdateCache(ownerDefaultTarget))
			{
				return;
			}
			base.rigidbody2d.mass = this.mass.Value;
		}

		// Token: 0x04003F88 RID: 16264
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		[Tooltip("The GameObject with the Rigidbody2D attached")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003F89 RID: 16265
		[RequiredField]
		[HasFloatSlider(0.1f, 10f)]
		[Tooltip("The Mass")]
		public FsmFloat mass;
	}
}
