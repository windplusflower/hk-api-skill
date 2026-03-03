using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AF1 RID: 2801
	[ActionCategory(ActionCategory.Physics)]
	[Tooltip("Applies a force to a Game Object that simulates explosion effects. The explosion force will fall off linearly with distance. Hint: Use the Explosion Action instead to apply an explosion force to all objects in a blast radius.")]
	public class AddExplosionForce : ComponentAction<Rigidbody>
	{
		// Token: 0x06003C21 RID: 15393 RVA: 0x0015A0F3 File Offset: 0x001582F3
		public override void Reset()
		{
			this.gameObject = null;
			this.center = new FsmVector3
			{
				UseVariable = true
			};
			this.upwardsModifier = 0f;
			this.forceMode = ForceMode.Force;
			this.everyFrame = false;
		}

		// Token: 0x06003C22 RID: 15394 RVA: 0x00070581 File Offset: 0x0006E781
		public override void OnPreprocess()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x06003C23 RID: 15395 RVA: 0x0015A12C File Offset: 0x0015832C
		public override void OnEnter()
		{
			this.DoAddExplosionForce();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003C24 RID: 15396 RVA: 0x0015A142 File Offset: 0x00158342
		public override void OnFixedUpdate()
		{
			this.DoAddExplosionForce();
		}

		// Token: 0x06003C25 RID: 15397 RVA: 0x0015A14C File Offset: 0x0015834C
		private void DoAddExplosionForce()
		{
			GameObject go = (this.gameObject.OwnerOption == OwnerDefaultOption.UseOwner) ? base.Owner : this.gameObject.GameObject.Value;
			if (this.center == null || !base.UpdateCache(go))
			{
				return;
			}
			base.rigidbody.AddExplosionForce(this.force.Value, this.center.Value, this.radius.Value, this.upwardsModifier.Value, this.forceMode);
		}

		// Token: 0x04003FC9 RID: 16329
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody))]
		[Tooltip("The GameObject to add the explosion force to.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003FCA RID: 16330
		[RequiredField]
		[Tooltip("The center of the explosion. Hint: this is often the position returned from a GetCollisionInfo action.")]
		public FsmVector3 center;

		// Token: 0x04003FCB RID: 16331
		[RequiredField]
		[Tooltip("The strength of the explosion.")]
		public FsmFloat force;

		// Token: 0x04003FCC RID: 16332
		[RequiredField]
		[Tooltip("The radius of the explosion. Force falls off linearly with distance.")]
		public FsmFloat radius;

		// Token: 0x04003FCD RID: 16333
		[Tooltip("Applies the force as if it was applied from beneath the object. This is useful since explosions that throw things up instead of pushing things to the side look cooler. A value of 2 will apply a force as if it is applied from 2 meters below while not changing the actual explosion position.")]
		public FsmFloat upwardsModifier;

		// Token: 0x04003FCE RID: 16334
		[Tooltip("The type of force to apply. See Unity Physics docs.")]
		public ForceMode forceMode;

		// Token: 0x04003FCF RID: 16335
		[Tooltip("Repeat every frame while the state is active.")]
		public bool everyFrame;
	}
}
