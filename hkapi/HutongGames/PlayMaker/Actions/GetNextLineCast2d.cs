using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AC9 RID: 2761
	[ActionCategory(ActionCategory.Physics2D)]
	[Tooltip("Iterate through a list of all colliders detected by a LineCastThe colliders iterated are sorted in order of increasing Z coordinate. No iteration will take place if there are no colliders within the area.")]
	public class GetNextLineCast2d : FsmStateAction
	{
		// Token: 0x06003B60 RID: 15200 RVA: 0x001568A4 File Offset: 0x00154AA4
		public override void Reset()
		{
			this.fromGameObject = null;
			this.fromPosition = new FsmVector2
			{
				UseVariable = true
			};
			this.toGameObject = null;
			this.toPosition = new FsmVector2
			{
				UseVariable = true
			};
			this.minDepth = new FsmInt
			{
				UseVariable = true
			};
			this.maxDepth = new FsmInt
			{
				UseVariable = true
			};
			this.layerMask = new FsmInt[0];
			this.invertMask = false;
			this.collidersCount = null;
			this.storeNextCollider = null;
			this.storeNextHitPoint = null;
			this.storeNextHitNormal = null;
			this.storeNextHitDistance = null;
			this.loopEvent = null;
			this.finishedEvent = null;
		}

		// Token: 0x06003B61 RID: 15201 RVA: 0x00156950 File Offset: 0x00154B50
		public override void OnEnter()
		{
			if (this.hits == null)
			{
				this.hits = this.GetLineCastAll();
				this.colliderCount = this.hits.Length;
				this.collidersCount.Value = this.colliderCount;
			}
			this.DoGetNextCollider();
			base.Finish();
		}

		// Token: 0x06003B62 RID: 15202 RVA: 0x0015699C File Offset: 0x00154B9C
		private void DoGetNextCollider()
		{
			if (this.nextColliderIndex >= this.colliderCount)
			{
				this.hits = new RaycastHit2D[0];
				this.nextColliderIndex = 0;
				base.Fsm.Event(this.finishedEvent);
				return;
			}
			Fsm.RecordLastRaycastHit2DInfo(base.Fsm, this.hits[this.nextColliderIndex]);
			this.storeNextCollider.Value = this.hits[this.nextColliderIndex].collider.gameObject;
			this.storeNextHitPoint.Value = this.hits[this.nextColliderIndex].point;
			this.storeNextHitNormal.Value = this.hits[this.nextColliderIndex].normal;
			this.storeNextHitDistance.Value = this.hits[this.nextColliderIndex].fraction;
			if (this.nextColliderIndex >= this.colliderCount)
			{
				this.hits = new RaycastHit2D[0];
				this.nextColliderIndex = 0;
				base.Fsm.Event(this.finishedEvent);
				return;
			}
			this.nextColliderIndex++;
			if (this.loopEvent != null)
			{
				base.Fsm.Event(this.loopEvent);
			}
		}

		// Token: 0x06003B63 RID: 15203 RVA: 0x00156ADC File Offset: 0x00154CDC
		private RaycastHit2D[] GetLineCastAll()
		{
			Vector2 value = this.fromPosition.Value;
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.fromGameObject);
			if (ownerDefaultTarget != null)
			{
				value.x += ownerDefaultTarget.transform.position.x;
				value.y += ownerDefaultTarget.transform.position.y;
			}
			Vector2 value2 = this.toPosition.Value;
			GameObject value3 = this.toGameObject.Value;
			if (value3 != null)
			{
				value2.x += value3.transform.position.x;
				value2.y += value3.transform.position.y;
			}
			if (this.minDepth.IsNone && this.maxDepth.IsNone)
			{
				return Physics2D.LinecastAll(value, value2, ActionHelpers.LayerArrayToLayerMask(this.layerMask, this.invertMask.Value));
			}
			float num = this.minDepth.IsNone ? float.NegativeInfinity : ((float)this.minDepth.Value);
			float num2 = this.maxDepth.IsNone ? float.PositiveInfinity : ((float)this.maxDepth.Value);
			return Physics2D.LinecastAll(value, value2, ActionHelpers.LayerArrayToLayerMask(this.layerMask, this.invertMask.Value), num, num2);
		}

		// Token: 0x04003EB6 RID: 16054
		[ActionSection("Setup")]
		[Tooltip("Start ray at game object position. \nOr use From Position parameter.")]
		public FsmOwnerDefault fromGameObject;

		// Token: 0x04003EB7 RID: 16055
		[Tooltip("Start ray at a vector2 world position. \nOr use fromGameObject parameter. If both define, will add fromPosition to the fromGameObject position")]
		public FsmVector2 fromPosition;

		// Token: 0x04003EB8 RID: 16056
		[Tooltip("End ray at game object position. \nOr use From Position parameter.")]
		public FsmGameObject toGameObject;

		// Token: 0x04003EB9 RID: 16057
		[Tooltip("End ray at a vector2 world position. \nOr use fromGameObject parameter. If both define, will add toPosition to the ToGameObject position")]
		public FsmVector2 toPosition;

		// Token: 0x04003EBA RID: 16058
		[Tooltip("Only include objects with a Z coordinate (depth) greater than this value. leave to none for no effect")]
		public FsmInt minDepth;

		// Token: 0x04003EBB RID: 16059
		[Tooltip("Only include objects with a Z coordinate (depth) less than this value. leave to none")]
		public FsmInt maxDepth;

		// Token: 0x04003EBC RID: 16060
		[ActionSection("Filter")]
		[UIHint(UIHint.Layer)]
		[Tooltip("Pick only from these layers.")]
		public FsmInt[] layerMask;

		// Token: 0x04003EBD RID: 16061
		[Tooltip("Invert the mask, so you pick from all layers except those defined above.")]
		public FsmBool invertMask;

		// Token: 0x04003EBE RID: 16062
		[ActionSection("Result")]
		[Tooltip("Store the number of colliders found for this overlap.")]
		[UIHint(UIHint.Variable)]
		public FsmInt collidersCount;

		// Token: 0x04003EBF RID: 16063
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the next collider in a GameObject variable.")]
		public FsmGameObject storeNextCollider;

		// Token: 0x04003EC0 RID: 16064
		[Tooltip("Get the 2d position of the next ray hit point and store it in a variable.")]
		public FsmVector2 storeNextHitPoint;

		// Token: 0x04003EC1 RID: 16065
		[Tooltip("Get the 2d normal at the next hit point and store it in a variable.")]
		public FsmVector2 storeNextHitNormal;

		// Token: 0x04003EC2 RID: 16066
		[Tooltip("Get the distance along the ray to the next hit point and store it in a variable.")]
		public FsmFloat storeNextHitDistance;

		// Token: 0x04003EC3 RID: 16067
		[Tooltip("Event to send to get the next collider.")]
		public FsmEvent loopEvent;

		// Token: 0x04003EC4 RID: 16068
		[Tooltip("Event to send when there are no more colliders to iterate.")]
		public FsmEvent finishedEvent;

		// Token: 0x04003EC5 RID: 16069
		private RaycastHit2D[] hits;

		// Token: 0x04003EC6 RID: 16070
		private int colliderCount;

		// Token: 0x04003EC7 RID: 16071
		private int nextColliderIndex;
	}
}
