using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C70 RID: 3184
	[ActionCategory(ActionCategory.Physics)]
	[Tooltip("Casts a Ray against all Colliders in the scene. Use either a Game Object or Vector3 world position as the origin of the ray. Use GetRaycastInfo to get more detailed info.")]
	public class Raycast : FsmStateAction
	{
		// Token: 0x0600428C RID: 17036 RVA: 0x00170234 File Offset: 0x0016E434
		public override void Reset()
		{
			this.fromGameObject = null;
			this.fromPosition = new FsmVector3
			{
				UseVariable = true
			};
			this.direction = new FsmVector3
			{
				UseVariable = true
			};
			this.space = Space.Self;
			this.distance = 100f;
			this.hitEvent = null;
			this.storeDidHit = null;
			this.storeHitObject = null;
			this.storeHitPoint = null;
			this.storeHitNormal = null;
			this.storeHitDistance = null;
			this.repeatInterval = 1;
			this.layerMask = new FsmInt[0];
			this.invertMask = false;
			this.debugColor = Color.yellow;
			this.debug = false;
		}

		// Token: 0x0600428D RID: 17037 RVA: 0x001702ED File Offset: 0x0016E4ED
		public override void OnEnter()
		{
			this.DoRaycast();
			if (this.repeatInterval.Value == 0)
			{
				base.Finish();
			}
		}

		// Token: 0x0600428E RID: 17038 RVA: 0x00170308 File Offset: 0x0016E508
		public override void OnUpdate()
		{
			this.repeat--;
			if (this.repeat == 0)
			{
				this.DoRaycast();
			}
		}

		// Token: 0x0600428F RID: 17039 RVA: 0x00170328 File Offset: 0x0016E528
		private void DoRaycast()
		{
			this.repeat = this.repeatInterval.Value;
			if (this.distance.Value == 0f)
			{
				return;
			}
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.fromGameObject);
			Vector3 vector = (ownerDefaultTarget != null) ? ownerDefaultTarget.transform.position : this.fromPosition.Value;
			float num = float.PositiveInfinity;
			if (this.distance.Value > 0f)
			{
				num = this.distance.Value;
			}
			Vector3 a = this.direction.Value;
			if (ownerDefaultTarget != null && this.space == Space.Self)
			{
				a = ownerDefaultTarget.transform.TransformDirection(this.direction.Value);
			}
			RaycastHit raycastHitInfo;
			Physics.Raycast(vector, a, out raycastHitInfo, num, ActionHelpers.LayerArrayToLayerMask(this.layerMask, this.invertMask.Value));
			base.Fsm.RaycastHitInfo = raycastHitInfo;
			bool flag = raycastHitInfo.collider != null;
			this.storeDidHit.Value = flag;
			if (flag)
			{
				this.storeHitObject.Value = raycastHitInfo.collider.gameObject;
				this.storeHitPoint.Value = base.Fsm.RaycastHitInfo.point;
				this.storeHitNormal.Value = base.Fsm.RaycastHitInfo.normal;
				this.storeHitDistance.Value = base.Fsm.RaycastHitInfo.distance;
				base.Fsm.Event(this.hitEvent);
			}
			if (this.debug.Value)
			{
				float d = Mathf.Min(num, 1000f);
				Debug.DrawLine(vector, vector + a * d, this.debugColor.Value);
			}
		}

		// Token: 0x040046D2 RID: 18130
		[Tooltip("Start ray at game object position. \nOr use From Position parameter.")]
		public FsmOwnerDefault fromGameObject;

		// Token: 0x040046D3 RID: 18131
		[Tooltip("Start ray at a vector3 world position. \nOr use Game Object parameter.")]
		public FsmVector3 fromPosition;

		// Token: 0x040046D4 RID: 18132
		[Tooltip("A vector3 direction vector")]
		public FsmVector3 direction;

		// Token: 0x040046D5 RID: 18133
		[Tooltip("Cast the ray in world or local space. Note if no Game Object is specfied, the direction is in world space.")]
		public Space space;

		// Token: 0x040046D6 RID: 18134
		[Tooltip("The length of the ray. Set to -1 for infinity.")]
		public FsmFloat distance;

		// Token: 0x040046D7 RID: 18135
		[ActionSection("Result")]
		[Tooltip("Event to send if the ray hits an object.")]
		[UIHint(UIHint.Variable)]
		public FsmEvent hitEvent;

		// Token: 0x040046D8 RID: 18136
		[Tooltip("Set a bool variable to true if hit something, otherwise false.")]
		[UIHint(UIHint.Variable)]
		public FsmBool storeDidHit;

		// Token: 0x040046D9 RID: 18137
		[Tooltip("Store the game object hit in a variable.")]
		[UIHint(UIHint.Variable)]
		public FsmGameObject storeHitObject;

		// Token: 0x040046DA RID: 18138
		[UIHint(UIHint.Variable)]
		[Tooltip("Get the world position of the ray hit point and store it in a variable.")]
		public FsmVector3 storeHitPoint;

		// Token: 0x040046DB RID: 18139
		[UIHint(UIHint.Variable)]
		[Tooltip("Get the normal at the hit point and store it in a variable.")]
		public FsmVector3 storeHitNormal;

		// Token: 0x040046DC RID: 18140
		[UIHint(UIHint.Variable)]
		[Tooltip("Get the distance along the ray to the hit point and store it in a variable.")]
		public FsmFloat storeHitDistance;

		// Token: 0x040046DD RID: 18141
		[ActionSection("Filter")]
		[Tooltip("Set how often to cast a ray. 0 = once, don't repeat; 1 = everyFrame; 2 = every other frame... \nSince raycasts can get expensive use the highest repeat interval you can get away with.")]
		public FsmInt repeatInterval;

		// Token: 0x040046DE RID: 18142
		[UIHint(UIHint.Layer)]
		[Tooltip("Pick only from these layers.")]
		public FsmInt[] layerMask;

		// Token: 0x040046DF RID: 18143
		[Tooltip("Invert the mask, so you pick from all layers except those defined above.")]
		public FsmBool invertMask;

		// Token: 0x040046E0 RID: 18144
		[ActionSection("Debug")]
		[Tooltip("The color to use for the debug line.")]
		public FsmColor debugColor;

		// Token: 0x040046E1 RID: 18145
		[Tooltip("Draw a debug line. Note: Check Gizmos in the Game View to see it in game.")]
		public FsmBool debug;

		// Token: 0x040046E2 RID: 18146
		private int repeat;
	}
}
