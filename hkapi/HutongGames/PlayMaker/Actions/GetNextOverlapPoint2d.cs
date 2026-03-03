using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000ACC RID: 2764
	[ActionCategory(ActionCategory.Physics2D)]
	[Tooltip("Iterate through a list of all colliders that overlap a point in space.The colliders iterated are sorted in order of increasing Z coordinate. No iteration will take place if there are no colliders overlap this point.")]
	public class GetNextOverlapPoint2d : FsmStateAction
	{
		// Token: 0x06003B6F RID: 15215 RVA: 0x001571BC File Offset: 0x001553BC
		public override void Reset()
		{
			this.gameObject = null;
			this.position = new FsmVector2
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
			this.loopEvent = null;
			this.finishedEvent = null;
		}

		// Token: 0x06003B70 RID: 15216 RVA: 0x0015723C File Offset: 0x0015543C
		public override void OnEnter()
		{
			if (this.colliders == null)
			{
				this.colliders = this.GetOverlapPointAll();
				this.colliderCount = this.colliders.Length;
				this.collidersCount.Value = this.colliderCount;
			}
			this.DoGetNextCollider();
			base.Finish();
		}

		// Token: 0x06003B71 RID: 15217 RVA: 0x00157288 File Offset: 0x00155488
		private void DoGetNextCollider()
		{
			if (this.nextColliderIndex >= this.colliderCount)
			{
				this.nextColliderIndex = 0;
				base.Fsm.Event(this.finishedEvent);
				return;
			}
			this.storeNextCollider.Value = this.colliders[this.nextColliderIndex].gameObject;
			if (this.nextColliderIndex >= this.colliderCount)
			{
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

		// Token: 0x06003B72 RID: 15218 RVA: 0x00157328 File Offset: 0x00155528
		private Collider2D[] GetOverlapPointAll()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			Vector2 value = this.position.Value;
			if (ownerDefaultTarget != null)
			{
				value.x += ownerDefaultTarget.transform.position.x;
				value.y += ownerDefaultTarget.transform.position.y;
			}
			if (this.minDepth.IsNone && this.maxDepth.IsNone)
			{
				return Physics2D.OverlapPointAll(value, ActionHelpers.LayerArrayToLayerMask(this.layerMask, this.invertMask.Value));
			}
			float num = this.minDepth.IsNone ? float.NegativeInfinity : ((float)this.minDepth.Value);
			float num2 = this.maxDepth.IsNone ? float.PositiveInfinity : ((float)this.maxDepth.Value);
			return Physics2D.OverlapPointAll(value, ActionHelpers.LayerArrayToLayerMask(this.layerMask, this.invertMask.Value), num, num2);
		}

		// Token: 0x04003EE5 RID: 16101
		[ActionSection("Setup")]
		[Tooltip("Point using the gameObject position. \nOr use From Position parameter.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003EE6 RID: 16102
		[Tooltip("Point as a world position. \nOr use gameObject parameter. If both define, will add position to the gameObject position")]
		public FsmVector2 position;

		// Token: 0x04003EE7 RID: 16103
		[Tooltip("Only include objects with a Z coordinate (depth) greater than this value. leave to none for no effect")]
		public FsmInt minDepth;

		// Token: 0x04003EE8 RID: 16104
		[Tooltip("Only include objects with a Z coordinate (depth) less than this value. leave to none")]
		public FsmInt maxDepth;

		// Token: 0x04003EE9 RID: 16105
		[ActionSection("Filter")]
		[UIHint(UIHint.Layer)]
		[Tooltip("Pick only from these layers.")]
		public FsmInt[] layerMask;

		// Token: 0x04003EEA RID: 16106
		[Tooltip("Invert the mask, so you pick from all layers except those defined above.")]
		public FsmBool invertMask;

		// Token: 0x04003EEB RID: 16107
		[ActionSection("Result")]
		[Tooltip("Store the number of colliders found for this overlap.")]
		[UIHint(UIHint.Variable)]
		public FsmInt collidersCount;

		// Token: 0x04003EEC RID: 16108
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the next collider in a GameObject variable.")]
		public FsmGameObject storeNextCollider;

		// Token: 0x04003EED RID: 16109
		[Tooltip("Event to send to get the next collider.")]
		public FsmEvent loopEvent;

		// Token: 0x04003EEE RID: 16110
		[Tooltip("Event to send when there are no more colliders to iterate.")]
		public FsmEvent finishedEvent;

		// Token: 0x04003EEF RID: 16111
		private Collider2D[] colliders;

		// Token: 0x04003EF0 RID: 16112
		private int colliderCount;

		// Token: 0x04003EF1 RID: 16113
		private int nextColliderIndex;
	}
}
