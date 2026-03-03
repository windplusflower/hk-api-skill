using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B7F RID: 2943
	[ActionCategory(ActionCategory.Physics)]
	[Tooltip("Applies an explosion Force to all Game Objects with a Rigid Body inside a Radius.")]
	public class Explosion : FsmStateAction
	{
		// Token: 0x06003E89 RID: 16009 RVA: 0x001647E1 File Offset: 0x001629E1
		public override void Reset()
		{
			this.center = null;
			this.upwardsModifier = 0f;
			this.forceMode = ForceMode.Force;
			this.everyFrame = false;
		}

		// Token: 0x06003E8A RID: 16010 RVA: 0x00070581 File Offset: 0x0006E781
		public override void OnPreprocess()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x06003E8B RID: 16011 RVA: 0x00164808 File Offset: 0x00162A08
		public override void OnEnter()
		{
			this.DoExplosion();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003E8C RID: 16012 RVA: 0x0016481E File Offset: 0x00162A1E
		public override void OnFixedUpdate()
		{
			this.DoExplosion();
		}

		// Token: 0x06003E8D RID: 16013 RVA: 0x00164828 File Offset: 0x00162A28
		private void DoExplosion()
		{
			foreach (Collider collider in Physics.OverlapSphere(this.center.Value, this.radius.Value))
			{
				Rigidbody component = collider.gameObject.GetComponent<Rigidbody>();
				if (component != null && this.ShouldApplyForce(collider.gameObject))
				{
					component.AddExplosionForce(this.force.Value, this.center.Value, this.radius.Value, this.upwardsModifier.Value, this.forceMode);
				}
			}
		}

		// Token: 0x06003E8E RID: 16014 RVA: 0x001648C0 File Offset: 0x00162AC0
		private bool ShouldApplyForce(GameObject go)
		{
			int num = ActionHelpers.LayerArrayToLayerMask(this.layerMask, this.invertMask.Value);
			return (1 << go.layer & num) > 0;
		}

		// Token: 0x04004297 RID: 17047
		[RequiredField]
		[Tooltip("The world position of the center of the explosion.")]
		public FsmVector3 center;

		// Token: 0x04004298 RID: 17048
		[RequiredField]
		[Tooltip("The strength of the explosion.")]
		public FsmFloat force;

		// Token: 0x04004299 RID: 17049
		[RequiredField]
		[Tooltip("The radius of the explosion. Force falls of linearly with distance.")]
		public FsmFloat radius;

		// Token: 0x0400429A RID: 17050
		[Tooltip("Applies the force as if it was applied from beneath the object. This is useful since explosions that throw things up instead of pushing things to the side look cooler. A value of 2 will apply a force as if it is applied from 2 meters below while not changing the actual explosion position.")]
		public FsmFloat upwardsModifier;

		// Token: 0x0400429B RID: 17051
		[Tooltip("The type of force to apply.")]
		public ForceMode forceMode;

		// Token: 0x0400429C RID: 17052
		[UIHint(UIHint.Layer)]
		public FsmInt layer;

		// Token: 0x0400429D RID: 17053
		[UIHint(UIHint.Layer)]
		[Tooltip("Layers to effect.")]
		public FsmInt[] layerMask;

		// Token: 0x0400429E RID: 17054
		[Tooltip("Invert the mask, so you effect all layers except those defined above.")]
		public FsmBool invertMask;

		// Token: 0x0400429F RID: 17055
		[Tooltip("Repeat every frame while the state is active.")]
		public bool everyFrame;
	}
}
