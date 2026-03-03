using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000ACA RID: 2762
	[ActionCategory(ActionCategory.Physics2D)]
	[Tooltip("Iterate through a list of all colliders that fall within a rectangular area.The colliders iterated are sorted in order of increasing Z coordinate. No iteration will take place if there are no colliders within the area.")]
	public class GetNextOverlapArea2d : FsmStateAction
	{
		// Token: 0x06003B65 RID: 15205 RVA: 0x00156C3C File Offset: 0x00154E3C
		public override void Reset()
		{
			this.firstCornerGameObject = null;
			this.firstCornerPosition = new FsmVector2
			{
				UseVariable = true
			};
			this.secondCornerGameObject = null;
			this.secondCornerPosition = new FsmVector2
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

		// Token: 0x06003B66 RID: 15206 RVA: 0x00156CD4 File Offset: 0x00154ED4
		public override void OnEnter()
		{
			if (this.colliders == null)
			{
				this.colliders = this.GetOverlapAreaAll();
				this.colliderCount = this.colliders.Length;
				this.collidersCount.Value = this.colliderCount;
			}
			this.DoGetNextCollider();
			base.Finish();
		}

		// Token: 0x06003B67 RID: 15207 RVA: 0x00156D20 File Offset: 0x00154F20
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

		// Token: 0x06003B68 RID: 15208 RVA: 0x00156DC0 File Offset: 0x00154FC0
		private Collider2D[] GetOverlapAreaAll()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.firstCornerGameObject);
			Vector2 value = this.firstCornerPosition.Value;
			if (ownerDefaultTarget != null)
			{
				value.x += ownerDefaultTarget.transform.position.x;
				value.y += ownerDefaultTarget.transform.position.y;
			}
			GameObject value2 = this.secondCornerGameObject.Value;
			Vector2 value3 = this.secondCornerPosition.Value;
			if (value2 != null)
			{
				value3.x += value2.transform.position.x;
				value3.y += value2.transform.position.y;
			}
			if (this.minDepth.IsNone && this.maxDepth.IsNone)
			{
				return Physics2D.OverlapAreaAll(value, value3, ActionHelpers.LayerArrayToLayerMask(this.layerMask, this.invertMask.Value));
			}
			float num = this.minDepth.IsNone ? float.NegativeInfinity : ((float)this.minDepth.Value);
			float num2 = this.maxDepth.IsNone ? float.PositiveInfinity : ((float)this.maxDepth.Value);
			return Physics2D.OverlapAreaAll(value, value3, ActionHelpers.LayerArrayToLayerMask(this.layerMask, this.invertMask.Value), num, num2);
		}

		// Token: 0x04003EC8 RID: 16072
		[ActionSection("Setup")]
		[Tooltip("First corner of the rectangle area using the game object position. \nOr use firstCornerPosition parameter.")]
		public FsmOwnerDefault firstCornerGameObject;

		// Token: 0x04003EC9 RID: 16073
		[Tooltip("First Corner of the rectangle area as a world position. \nOr use FirstCornerGameObject parameter. If both define, will add firstCornerPosition to the FirstCornerGameObject position")]
		public FsmVector2 firstCornerPosition;

		// Token: 0x04003ECA RID: 16074
		[Tooltip("Second corner of the rectangle area using the game object position. \nOr use secondCornerPosition parameter.")]
		public FsmGameObject secondCornerGameObject;

		// Token: 0x04003ECB RID: 16075
		[Tooltip("Second Corner rectangle area as a world position. \nOr use SecondCornerGameObject parameter. If both define, will add secondCornerPosition to the SecondCornerGameObject position")]
		public FsmVector2 secondCornerPosition;

		// Token: 0x04003ECC RID: 16076
		[Tooltip("Only include objects with a Z coordinate (depth) greater than this value. leave to none for no effect")]
		public FsmInt minDepth;

		// Token: 0x04003ECD RID: 16077
		[Tooltip("Only include objects with a Z coordinate (depth) less than this value. leave to none")]
		public FsmInt maxDepth;

		// Token: 0x04003ECE RID: 16078
		[ActionSection("Filter")]
		[UIHint(UIHint.Layer)]
		[Tooltip("Pick only from these layers.")]
		public FsmInt[] layerMask;

		// Token: 0x04003ECF RID: 16079
		[Tooltip("Invert the mask, so you pick from all layers except those defined above.")]
		public FsmBool invertMask;

		// Token: 0x04003ED0 RID: 16080
		[ActionSection("Result")]
		[Tooltip("Store the number of colliders found for this overlap.")]
		[UIHint(UIHint.Variable)]
		public FsmInt collidersCount;

		// Token: 0x04003ED1 RID: 16081
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the next collider in a GameObject variable.")]
		public FsmGameObject storeNextCollider;

		// Token: 0x04003ED2 RID: 16082
		[Tooltip("Event to send to get the next collider.")]
		public FsmEvent loopEvent;

		// Token: 0x04003ED3 RID: 16083
		[Tooltip("Event to send when there are no more colliders to iterate.")]
		public FsmEvent finishedEvent;

		// Token: 0x04003ED4 RID: 16084
		private Collider2D[] colliders;

		// Token: 0x04003ED5 RID: 16085
		private int colliderCount;

		// Token: 0x04003ED6 RID: 16086
		private int nextColliderIndex;
	}
}
