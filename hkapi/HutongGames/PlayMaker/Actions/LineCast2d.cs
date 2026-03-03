using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AD7 RID: 2775
	[ActionCategory(ActionCategory.Physics2D)]
	[Tooltip("Casts a Ray against all Colliders in the scene.A linecast is an imaginary line between two points in world space. Any object making contact with the beam can be detected and reported. This differs from the similar raycast in that raycasting specifies the line using an origin and direction.Use GetRaycastHit2dInfo to get more detailed info.")]
	public class LineCast2d : FsmStateAction
	{
		// Token: 0x06003BA2 RID: 15266 RVA: 0x00157E04 File Offset: 0x00156004
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

		// Token: 0x06003BA3 RID: 15267 RVA: 0x00157EB0 File Offset: 0x001560B0
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.fromGameObject);
			if (ownerDefaultTarget != null)
			{
				this._fromTrans = ownerDefaultTarget.transform;
			}
			GameObject value = this.toGameObject.Value;
			if (value != null)
			{
				this._toTrans = value.transform;
			}
			this.DoRaycast();
			if (this.repeatInterval.Value == 0)
			{
				base.Finish();
			}
		}

		// Token: 0x06003BA4 RID: 15268 RVA: 0x00157F1E File Offset: 0x0015611E
		public override void OnUpdate()
		{
			this.repeat--;
			if (this.repeat == 0)
			{
				this.DoRaycast();
			}
		}

		// Token: 0x06003BA5 RID: 15269 RVA: 0x00157F3C File Offset: 0x0015613C
		private void DoRaycast()
		{
			this.repeat = this.repeatInterval.Value;
			Vector2 value = this.fromPosition.Value;
			if (this._fromTrans != null)
			{
				value.x += this._fromTrans.position.x;
				value.y += this._fromTrans.position.y;
			}
			Vector2 value2 = this.toPosition.Value;
			if (this._toTrans != null)
			{
				value2.x += this._toTrans.position.x;
				value2.y += this._toTrans.position.y;
			}
			RaycastHit2D info;
			if (this.minDepth.IsNone && this.maxDepth.IsNone)
			{
				info = Physics2D.Linecast(value, value2, ActionHelpers.LayerArrayToLayerMask(this.layerMask, this.invertMask.Value));
			}
			else
			{
				float num = this.minDepth.IsNone ? float.NegativeInfinity : ((float)this.minDepth.Value);
				float num2 = this.maxDepth.IsNone ? float.PositiveInfinity : ((float)this.maxDepth.Value);
				info = Physics2D.Linecast(value, value2, ActionHelpers.LayerArrayToLayerMask(this.layerMask, this.invertMask.Value), num, num2);
			}
			Fsm.RecordLastRaycastHit2DInfo(base.Fsm, info);
			bool flag = info.collider != null;
			this.storeDidHit.Value = flag;
			if (flag)
			{
				this.storeHitObject.Value = info.collider.gameObject;
				this.storeHitPoint.Value = info.point;
				this.storeHitNormal.Value = info.normal;
				this.storeHitDistance.Value = info.fraction;
				base.Fsm.Event(this.hitEvent);
			}
			if (this.debug.Value)
			{
				Vector3 start = new Vector3(value.x, value.y, 0f);
				Vector3 end = new Vector3(value2.x, value2.y, 0f);
				Debug.DrawLine(start, end, this.debugColor.Value);
			}
		}

		// Token: 0x04003F2A RID: 16170
		[ActionSection("Setup")]
		[Tooltip("Start ray at game object position. \nOr use From Position parameter.")]
		public FsmOwnerDefault fromGameObject;

		// Token: 0x04003F2B RID: 16171
		[Tooltip("Start ray at a vector2 world position. \nOr use fromGameObject parameter. If both define, will add fromPosition to the fromGameObject position")]
		public FsmVector2 fromPosition;

		// Token: 0x04003F2C RID: 16172
		[Tooltip("End ray at game object position. \nOr use From Position parameter.")]
		public FsmGameObject toGameObject;

		// Token: 0x04003F2D RID: 16173
		[Tooltip("End ray at a vector2 world position. \nOr use fromGameObject parameter. If both define, will add toPosition to the ToGameObject position")]
		public FsmVector2 toPosition;

		// Token: 0x04003F2E RID: 16174
		[Tooltip("Only include objects with a Z coordinate (depth) greater than this value. leave to none for no effect")]
		public FsmInt minDepth;

		// Token: 0x04003F2F RID: 16175
		[Tooltip("Only include objects with a Z coordinate (depth) less than this value. leave to none")]
		public FsmInt maxDepth;

		// Token: 0x04003F30 RID: 16176
		[ActionSection("Result")]
		[Tooltip("Event to send if the ray hits an object.")]
		[UIHint(UIHint.Variable)]
		public FsmEvent hitEvent;

		// Token: 0x04003F31 RID: 16177
		[Tooltip("Set a bool variable to true if hit something, otherwise false.")]
		[UIHint(UIHint.Variable)]
		public FsmBool storeDidHit;

		// Token: 0x04003F32 RID: 16178
		[Tooltip("Store the game object hit in a variable.")]
		[UIHint(UIHint.Variable)]
		public FsmGameObject storeHitObject;

		// Token: 0x04003F33 RID: 16179
		[UIHint(UIHint.Variable)]
		[Tooltip("Get the 2d position of the ray hit point and store it in a variable.")]
		public FsmVector2 storeHitPoint;

		// Token: 0x04003F34 RID: 16180
		[UIHint(UIHint.Variable)]
		[Tooltip("Get the 2d normal at the hit point and store it in a variable.")]
		public FsmVector2 storeHitNormal;

		// Token: 0x04003F35 RID: 16181
		[UIHint(UIHint.Variable)]
		[Tooltip("Get the distance along the ray to the hit point and store it in a variable.")]
		public FsmFloat storeHitDistance;

		// Token: 0x04003F36 RID: 16182
		[ActionSection("Filter")]
		[Tooltip("Set how often to cast a ray. 0 = once, don't repeat; 1 = everyFrame; 2 = every other frame... \nSince raycasts can get expensive use the highest repeat interval you can get away with.")]
		public FsmInt repeatInterval;

		// Token: 0x04003F37 RID: 16183
		[UIHint(UIHint.Layer)]
		[Tooltip("Pick only from these layers.")]
		public FsmInt[] layerMask;

		// Token: 0x04003F38 RID: 16184
		[Tooltip("Invert the mask, so you pick from all layers except those defined above.")]
		public FsmBool invertMask;

		// Token: 0x04003F39 RID: 16185
		[ActionSection("Debug")]
		[Tooltip("The color to use for the debug line.")]
		public FsmColor debugColor;

		// Token: 0x04003F3A RID: 16186
		[Tooltip("Draw a debug line. Note: Check Gizmos in the Game View to see it in game.")]
		public FsmBool debug;

		// Token: 0x04003F3B RID: 16187
		private Transform _fromTrans;

		// Token: 0x04003F3C RID: 16188
		private Transform _toTrans;

		// Token: 0x04003F3D RID: 16189
		private int repeat;
	}
}
