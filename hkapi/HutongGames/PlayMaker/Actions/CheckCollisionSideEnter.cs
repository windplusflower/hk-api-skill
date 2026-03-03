using System;
using System.Collections.Generic;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009A5 RID: 2469
	[ActionCategory(ActionCategory.Physics)]
	[Tooltip("Detect additional collisions between the Owner of this FSM and other object with additional raycasting.")]
	public class CheckCollisionSideEnter : FsmStateAction
	{
		// Token: 0x0600361A RID: 13850 RVA: 0x00003603 File Offset: 0x00001803
		public override void Reset()
		{
		}

		// Token: 0x0600361B RID: 13851 RVA: 0x0013F228 File Offset: 0x0013D428
		public override void OnEnter()
		{
			this.col2d = base.Fsm.GameObject.GetComponent<Collider2D>();
			this._proxy = base.Owner.GetComponent<PlayMakerUnity2DProxy>();
			if (this._proxy == null)
			{
				this._proxy = base.Owner.AddComponent<PlayMakerUnity2DProxy>();
			}
			this._proxy.AddOnCollisionEnter2dDelegate(new PlayMakerUnity2DProxy.OnCollisionEnter2dDelegate(this.DoCollisionEnter2D));
		}

		// Token: 0x0600361C RID: 13852 RVA: 0x0013F292 File Offset: 0x0013D492
		public override void OnExit()
		{
			this._proxy.RemoveOnCollisionEnter2dDelegate(new PlayMakerUnity2DProxy.OnCollisionEnter2dDelegate(this.DoCollisionEnter2D));
		}

		// Token: 0x0600361D RID: 13853 RVA: 0x00003603 File Offset: 0x00001803
		public override void OnUpdate()
		{
		}

		// Token: 0x0600361E RID: 13854 RVA: 0x0013F2AC File Offset: 0x0013D4AC
		public new void DoCollisionEnter2D(Collision2D collision)
		{
			if (!this.otherLayer)
			{
				if (LayerMask.LayerToName(collision.gameObject.layer) == "Terrain")
				{
					this.CheckTouching(8);
					return;
				}
			}
			else
			{
				this.CheckTouching(this.otherLayerNumber);
			}
		}

		// Token: 0x0600361F RID: 13855 RVA: 0x0013F2FC File Offset: 0x0013D4FC
		private void CheckTouching(LayerMask layer)
		{
			this.topRays = new List<Vector2>();
			this.topRays.Add(new Vector2(this.col2d.bounds.min.x, this.col2d.bounds.max.y));
			this.topRays.Add(new Vector2(this.col2d.bounds.center.x, this.col2d.bounds.max.y));
			this.topRays.Add(this.col2d.bounds.max);
			this.rightRays = new List<Vector2>();
			this.rightRays.Add(this.col2d.bounds.max);
			this.rightRays.Add(new Vector2(this.col2d.bounds.max.x, this.col2d.bounds.center.y));
			this.rightRays.Add(new Vector2(this.col2d.bounds.max.x, this.col2d.bounds.min.y));
			this.bottomRays = new List<Vector2>();
			this.bottomRays.Add(new Vector2(this.col2d.bounds.max.x, this.col2d.bounds.min.y));
			this.bottomRays.Add(new Vector2(this.col2d.bounds.center.x, this.col2d.bounds.min.y));
			this.bottomRays.Add(this.col2d.bounds.min);
			this.leftRays = new List<Vector2>();
			this.leftRays.Add(this.col2d.bounds.min);
			this.leftRays.Add(new Vector2(this.col2d.bounds.min.x, this.col2d.bounds.center.y));
			this.leftRays.Add(new Vector2(this.col2d.bounds.min.x, this.col2d.bounds.max.y));
			this.topHit.Value = false;
			this.rightHit.Value = false;
			this.bottomHit.Value = false;
			this.leftHit.Value = false;
			foreach (Vector2 v in this.topRays)
			{
				RaycastHit2D raycastHit2D = Physics2D.Raycast(v, Vector2.up, 0.08f, 1 << layer);
				if (raycastHit2D.collider != null && (!this.ignoreTriggers.Value || !raycastHit2D.collider.isTrigger))
				{
					this.topHit.Value = true;
					base.Fsm.Event(this.topHitEvent);
					break;
				}
			}
			foreach (Vector2 v2 in this.rightRays)
			{
				RaycastHit2D raycastHit2D2 = Physics2D.Raycast(v2, Vector2.right, 0.08f, 1 << layer);
				if (raycastHit2D2.collider != null && (!this.ignoreTriggers.Value || !raycastHit2D2.collider.isTrigger))
				{
					this.rightHit.Value = true;
					base.Fsm.Event(this.rightHitEvent);
					break;
				}
			}
			foreach (Vector2 v3 in this.bottomRays)
			{
				RaycastHit2D raycastHit2D3 = Physics2D.Raycast(v3, -Vector2.up, 0.08f, 1 << layer);
				if (raycastHit2D3.collider != null && (!this.ignoreTriggers.Value || !raycastHit2D3.collider.isTrigger))
				{
					this.bottomHit.Value = true;
					base.Fsm.Event(this.bottomHitEvent);
					break;
				}
			}
			foreach (Vector2 v4 in this.leftRays)
			{
				RaycastHit2D raycastHit2D4 = Physics2D.Raycast(v4, -Vector2.right, 0.08f, 1 << layer);
				if (raycastHit2D4.collider != null && (!this.ignoreTriggers.Value || !raycastHit2D4.collider.isTrigger))
				{
					this.leftHit.Value = true;
					base.Fsm.Event(this.leftHitEvent);
					break;
				}
			}
		}

		// Token: 0x040037DC RID: 14300
		[UIHint(UIHint.Variable)]
		public FsmBool topHit;

		// Token: 0x040037DD RID: 14301
		[UIHint(UIHint.Variable)]
		public FsmBool rightHit;

		// Token: 0x040037DE RID: 14302
		[UIHint(UIHint.Variable)]
		public FsmBool bottomHit;

		// Token: 0x040037DF RID: 14303
		[UIHint(UIHint.Variable)]
		public FsmBool leftHit;

		// Token: 0x040037E0 RID: 14304
		public FsmEvent topHitEvent;

		// Token: 0x040037E1 RID: 14305
		public FsmEvent rightHitEvent;

		// Token: 0x040037E2 RID: 14306
		public FsmEvent bottomHitEvent;

		// Token: 0x040037E3 RID: 14307
		public FsmEvent leftHitEvent;

		// Token: 0x040037E4 RID: 14308
		public bool otherLayer;

		// Token: 0x040037E5 RID: 14309
		public int otherLayerNumber;

		// Token: 0x040037E6 RID: 14310
		public FsmBool ignoreTriggers;

		// Token: 0x040037E7 RID: 14311
		private PlayMakerUnity2DProxy _proxy;

		// Token: 0x040037E8 RID: 14312
		private Collider2D col2d;

		// Token: 0x040037E9 RID: 14313
		private const float RAYCAST_LENGTH = 0.08f;

		// Token: 0x040037EA RID: 14314
		private List<Vector2> topRays;

		// Token: 0x040037EB RID: 14315
		private List<Vector2> rightRays;

		// Token: 0x040037EC RID: 14316
		private List<Vector2> bottomRays;

		// Token: 0x040037ED RID: 14317
		private List<Vector2> leftRays;

		// Token: 0x020009A6 RID: 2470
		public enum CollisionSide
		{
			// Token: 0x040037EF RID: 14319
			top,
			// Token: 0x040037F0 RID: 14320
			left,
			// Token: 0x040037F1 RID: 14321
			right,
			// Token: 0x040037F2 RID: 14322
			bottom,
			// Token: 0x040037F3 RID: 14323
			other
		}
	}
}
