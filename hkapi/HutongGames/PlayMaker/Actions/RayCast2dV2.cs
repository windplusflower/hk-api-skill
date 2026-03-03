using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A0B RID: 2571
	[ActionCategory("Physics 2d")]
	[Tooltip("Casts a Ray against all Colliders in the scene. A raycast is conceptually like a laser beam that is fired from a point in space along a particular direction. Any object making contact with the beam can be detected and reported. Use GetRaycastHit2dInfo to get more detailed info. CHERRYNOTE: Added ability to measure distance in units to hit point.")]
	public class RayCast2dV2 : FsmStateAction
	{
		// Token: 0x060037F0 RID: 14320 RVA: 0x00148700 File Offset: 0x00146900
		public override void Reset()
		{
			this.fromGameObject = null;
			this.fromPosition = new FsmVector2
			{
				UseVariable = true
			};
			this.direction = new FsmVector2
			{
				UseVariable = true
			};
			this.space = Space.Self;
			this.minDepth = new FsmInt
			{
				UseVariable = true
			};
			this.maxDepth = new FsmInt
			{
				UseVariable = true
			};
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

		// Token: 0x060037F1 RID: 14321 RVA: 0x001487E0 File Offset: 0x001469E0
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.fromGameObject);
			if (ownerDefaultTarget != null)
			{
				this._trans = ownerDefaultTarget.transform;
			}
			this.DoRaycast();
			if (this.repeatInterval.Value == 0)
			{
				base.Finish();
			}
		}

		// Token: 0x060037F2 RID: 14322 RVA: 0x0014882D File Offset: 0x00146A2D
		public override void OnUpdate()
		{
			this.repeat--;
			if (this.repeat == 0)
			{
				this.DoRaycast();
			}
		}

		// Token: 0x060037F3 RID: 14323 RVA: 0x0014884C File Offset: 0x00146A4C
		private void DoRaycast()
		{
			this.repeat = this.repeatInterval.Value;
			if (this.distance.Value == 0f)
			{
				return;
			}
			Vector2 value = this.fromPosition.Value;
			if (this._trans != null)
			{
				value.x += this._trans.position.x;
				value.y += this._trans.position.y;
			}
			float a = float.PositiveInfinity;
			if (this.distance.Value > 0f)
			{
				a = this.distance.Value;
			}
			Vector2 normalized = this.direction.Value.normalized;
			if (this._trans != null && this.space == Space.Self)
			{
				Vector3 vector = this._trans.TransformDirection(new Vector3(this.direction.Value.x, this.direction.Value.y, 0f));
				normalized.x = vector.x;
				normalized.y = vector.y;
			}
			RaycastHit2D info;
			if (this.minDepth.IsNone && this.maxDepth.IsNone)
			{
				info = Physics2D.Raycast(value, normalized, a, ActionHelpers.LayerArrayToLayerMask(this.layerMask, this.invertMask.Value));
			}
			else
			{
				float num = this.minDepth.IsNone ? float.NegativeInfinity : ((float)this.minDepth.Value);
				float num2 = this.maxDepth.IsNone ? float.PositiveInfinity : ((float)this.maxDepth.Value);
				info = Physics2D.Raycast(value, normalized, a, ActionHelpers.LayerArrayToLayerMask(this.layerMask, this.invertMask.Value), num, num2);
			}
			PlayMakerUnity2d.RecordLastRaycastHitInfo(base.Fsm, info);
			bool flag = info.collider != null;
			this.storeDidHit.Value = flag;
			if (flag)
			{
				this.storeHitObject.Value = info.collider.gameObject;
				this.storeHitPoint.Value = info.point;
				this.storeHitNormal.Value = info.normal;
				this.storeHitDistance.Value = info.fraction;
				this.storeDistance.Value = info.distance;
				base.Fsm.Event(this.hitEvent);
			}
			if (this.debug.Value)
			{
				float d = Mathf.Min(a, 1000f);
				Vector3 vector2 = new Vector3(value.x, value.y, 0f);
				Vector3 a2 = new Vector3(normalized.x, normalized.y, 0f);
				Vector3 end = vector2 + a2 * d;
				Debug.DrawLine(vector2, end, this.debugColor.Value);
			}
		}

		// Token: 0x04003A74 RID: 14964
		[ActionSection("Setup")]
		[Tooltip("Start ray at game object position. \nOr use From Position parameter.")]
		public FsmOwnerDefault fromGameObject;

		// Token: 0x04003A75 RID: 14965
		[Tooltip("Start ray at a vector2 world position. \nOr use Game Object parameter.")]
		public FsmVector2 fromPosition;

		// Token: 0x04003A76 RID: 14966
		[Tooltip("A vector2 direction vector")]
		public FsmVector2 direction;

		// Token: 0x04003A77 RID: 14967
		[Tooltip("Cast the ray in world or local space. Note if no Game Object is specified, the direction is in world space.")]
		public Space space;

		// Token: 0x04003A78 RID: 14968
		[Tooltip("The length of the ray. Set to -1 for infinity.")]
		public FsmFloat distance;

		// Token: 0x04003A79 RID: 14969
		[Tooltip("Only include objects with a Z coordinate (depth) greater than this value. leave to none for no effect")]
		public FsmInt minDepth;

		// Token: 0x04003A7A RID: 14970
		[Tooltip("Only include objects with a Z coordinate (depth) less than this value. leave to none")]
		public FsmInt maxDepth;

		// Token: 0x04003A7B RID: 14971
		[ActionSection("Result")]
		[Tooltip("Event to send if the ray hits an object.")]
		[UIHint(UIHint.Variable)]
		public FsmEvent hitEvent;

		// Token: 0x04003A7C RID: 14972
		[Tooltip("Set a bool variable to true if hit something, otherwise false.")]
		[UIHint(UIHint.Variable)]
		public FsmBool storeDidHit;

		// Token: 0x04003A7D RID: 14973
		[Tooltip("Store the game object hit in a variable.")]
		[UIHint(UIHint.Variable)]
		public FsmGameObject storeHitObject;

		// Token: 0x04003A7E RID: 14974
		[UIHint(UIHint.Variable)]
		[Tooltip("Get the 2d position of the ray hit point and store it in a variable.")]
		public FsmVector2 storeHitPoint;

		// Token: 0x04003A7F RID: 14975
		[UIHint(UIHint.Variable)]
		[Tooltip("Get the 2d normal at the hit point and store it in a variable.")]
		public FsmVector2 storeHitNormal;

		// Token: 0x04003A80 RID: 14976
		[UIHint(UIHint.Variable)]
		[Tooltip("Get the distance along the ray to the hit point and store it in a variable.")]
		public FsmFloat storeHitDistance;

		// Token: 0x04003A81 RID: 14977
		[UIHint(UIHint.Variable)]
		[Tooltip("Get the distance in units... hopefully.")]
		public FsmFloat storeDistance;

		// Token: 0x04003A82 RID: 14978
		[ActionSection("Filter")]
		[Tooltip("Set how often to cast a ray. 0 = once, don't repeat; 1 = everyFrame; 2 = every other frame... \nSince raycasts can get expensive use the highest repeat interval you can get away with.")]
		public FsmInt repeatInterval;

		// Token: 0x04003A83 RID: 14979
		[UIHint(UIHint.Layer)]
		[Tooltip("Pick only from these layers.")]
		public FsmInt[] layerMask;

		// Token: 0x04003A84 RID: 14980
		[Tooltip("Invert the mask, so you pick from all layers except those defined above.")]
		public FsmBool invertMask;

		// Token: 0x04003A85 RID: 14981
		[ActionSection("Debug")]
		[Tooltip("The color to use for the debug line.")]
		public FsmColor debugColor;

		// Token: 0x04003A86 RID: 14982
		[Tooltip("Draw a debug line. Note: Check Gizmos in the Game View to see it in game.")]
		public FsmBool debug;

		// Token: 0x04003A87 RID: 14983
		private Transform _trans;

		// Token: 0x04003A88 RID: 14984
		private int repeat;
	}
}
