using System;
using System.Collections.Generic;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009A3 RID: 2467
	[ActionCategory(ActionCategory.Physics)]
	[Tooltip("Detect additional collisions between the Owner of this FSM and other object with additional raycasting.")]
	public class CheckCollisionSide : FsmStateAction
	{
		// Token: 0x06003612 RID: 13842 RVA: 0x0013EAAF File Offset: 0x0013CCAF
		public override void Reset()
		{
			this.checkUp = false;
			this.checkDown = false;
			this.checkLeft = false;
			this.checkRight = false;
		}

		// Token: 0x06003613 RID: 13843 RVA: 0x0013EAD0 File Offset: 0x0013CCD0
		public override void OnEnter()
		{
			this.col2d = base.Fsm.GameObject.GetComponent<Collider2D>();
			this.topRays = new List<Vector2>(3);
			this.rightRays = new List<Vector2>(3);
			this.bottomRays = new List<Vector2>(3);
			this.leftRays = new List<Vector2>(3);
			this._proxy = base.Owner.GetComponent<PlayMakerUnity2DProxy>();
			if (this._proxy == null)
			{
				this._proxy = base.Owner.AddComponent<PlayMakerUnity2DProxy>();
			}
			this._proxy.AddOnCollisionStay2dDelegate(new PlayMakerUnity2DProxy.OnCollisionStay2dDelegate(this.DoCollisionStay2D));
			if (!this.topHit.IsNone || this.topHitEvent != null)
			{
				this.checkUp = true;
			}
			else
			{
				this.checkUp = false;
			}
			if (!this.rightHit.IsNone || this.rightHitEvent != null)
			{
				this.checkRight = true;
			}
			else
			{
				this.checkRight = false;
			}
			if (!this.bottomHit.IsNone || this.bottomHitEvent != null)
			{
				this.checkDown = true;
			}
			else
			{
				this.checkDown = false;
			}
			if (!this.leftHit.IsNone || this.leftHitEvent != null)
			{
				this.checkLeft = true;
				return;
			}
			this.checkLeft = false;
		}

		// Token: 0x06003614 RID: 13844 RVA: 0x0013EBFD File Offset: 0x0013CDFD
		public override void OnExit()
		{
			this._proxy.RemoveOnCollisionStay2dDelegate(new PlayMakerUnity2DProxy.OnCollisionStay2dDelegate(this.DoCollisionStay2D));
		}

		// Token: 0x06003615 RID: 13845 RVA: 0x0013EC18 File Offset: 0x0013CE18
		public override void OnUpdate()
		{
			if (this.topHit.Value || this.bottomHit.Value || this.rightHit.Value || this.leftHit.Value)
			{
				if (!this.otherLayer)
				{
					this.CheckTouching(8);
					return;
				}
				this.CheckTouching(this.otherLayerNumber);
			}
		}

		// Token: 0x06003616 RID: 13846 RVA: 0x0013EC7F File Offset: 0x0013CE7F
		public new void DoCollisionStay2D(Collision2D collision)
		{
			if (!this.otherLayer)
			{
				if (collision.gameObject.layer == 8)
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

		// Token: 0x06003617 RID: 13847 RVA: 0x0013ECB5 File Offset: 0x0013CEB5
		public new void DoCollisionExit2D(Collision2D collision)
		{
			this.topHit.Value = false;
			this.rightHit.Value = false;
			this.bottomHit.Value = false;
			this.leftHit.Value = false;
		}

		// Token: 0x06003618 RID: 13848 RVA: 0x0013ECE8 File Offset: 0x0013CEE8
		private void CheckTouching(LayerMask layer)
		{
			if (this.checkUp)
			{
				this.topRays.Clear();
				this.topRays.Add(new Vector2(this.col2d.bounds.min.x, this.col2d.bounds.max.y));
				this.topRays.Add(new Vector2(this.col2d.bounds.center.x, this.col2d.bounds.max.y));
				this.topRays.Add(this.col2d.bounds.max);
				this.topHit.Value = false;
				for (int i = 0; i < 3; i++)
				{
					RaycastHit2D raycastHit2D = Physics2D.Raycast(this.topRays[i], Vector2.up, 0.08f, 1 << layer);
					if (raycastHit2D.collider != null && (!this.ignoreTriggers.Value || !raycastHit2D.collider.isTrigger))
					{
						this.topHit.Value = true;
						base.Fsm.Event(this.topHitEvent);
						break;
					}
				}
			}
			if (this.checkRight)
			{
				this.rightRays.Clear();
				this.rightRays.Add(this.col2d.bounds.max);
				this.rightRays.Add(new Vector2(this.col2d.bounds.max.x, this.col2d.bounds.center.y));
				this.rightRays.Add(new Vector2(this.col2d.bounds.max.x, this.col2d.bounds.min.y));
				this.rightHit.Value = false;
				for (int j = 0; j < 3; j++)
				{
					RaycastHit2D raycastHit2D2 = Physics2D.Raycast(this.rightRays[j], Vector2.right, 0.08f, 1 << layer);
					if (raycastHit2D2.collider != null && (!this.ignoreTriggers.Value || !raycastHit2D2.collider.isTrigger))
					{
						this.rightHit.Value = true;
						base.Fsm.Event(this.rightHitEvent);
						break;
					}
				}
			}
			if (this.checkDown)
			{
				this.bottomRays.Clear();
				this.bottomRays.Add(new Vector2(this.col2d.bounds.max.x, this.col2d.bounds.min.y));
				this.bottomRays.Add(new Vector2(this.col2d.bounds.center.x, this.col2d.bounds.min.y));
				this.bottomRays.Add(this.col2d.bounds.min);
				this.bottomHit.Value = false;
				for (int k = 0; k < 3; k++)
				{
					RaycastHit2D raycastHit2D3 = Physics2D.Raycast(this.bottomRays[k], -Vector2.up, 0.08f, 1 << layer);
					if (raycastHit2D3.collider != null && (!this.ignoreTriggers.Value || !raycastHit2D3.collider.isTrigger))
					{
						this.bottomHit.Value = true;
						base.Fsm.Event(this.bottomHitEvent);
						break;
					}
				}
			}
			if (this.checkLeft)
			{
				this.leftRays.Clear();
				this.leftRays.Add(this.col2d.bounds.min);
				this.leftRays.Add(new Vector2(this.col2d.bounds.min.x, this.col2d.bounds.center.y));
				this.leftRays.Add(new Vector2(this.col2d.bounds.min.x, this.col2d.bounds.max.y));
				this.leftHit.Value = false;
				for (int l = 0; l < 3; l++)
				{
					RaycastHit2D raycastHit2D4 = Physics2D.Raycast(this.leftRays[l], -Vector2.right, 0.08f, 1 << layer);
					if (raycastHit2D4.collider != null && (!this.ignoreTriggers.Value || !raycastHit2D4.collider.isTrigger))
					{
						this.leftHit.Value = true;
						base.Fsm.Event(this.leftHitEvent);
						return;
					}
				}
			}
		}

		// Token: 0x040037C0 RID: 14272
		[UIHint(UIHint.Variable)]
		public FsmBool topHit;

		// Token: 0x040037C1 RID: 14273
		[UIHint(UIHint.Variable)]
		public FsmBool rightHit;

		// Token: 0x040037C2 RID: 14274
		[UIHint(UIHint.Variable)]
		public FsmBool bottomHit;

		// Token: 0x040037C3 RID: 14275
		[UIHint(UIHint.Variable)]
		public FsmBool leftHit;

		// Token: 0x040037C4 RID: 14276
		public FsmEvent topHitEvent;

		// Token: 0x040037C5 RID: 14277
		public FsmEvent rightHitEvent;

		// Token: 0x040037C6 RID: 14278
		public FsmEvent bottomHitEvent;

		// Token: 0x040037C7 RID: 14279
		public FsmEvent leftHitEvent;

		// Token: 0x040037C8 RID: 14280
		public bool otherLayer;

		// Token: 0x040037C9 RID: 14281
		public int otherLayerNumber;

		// Token: 0x040037CA RID: 14282
		public FsmBool ignoreTriggers;

		// Token: 0x040037CB RID: 14283
		private PlayMakerUnity2DProxy _proxy;

		// Token: 0x040037CC RID: 14284
		private Collider2D col2d;

		// Token: 0x040037CD RID: 14285
		private const float RAYCAST_LENGTH = 0.08f;

		// Token: 0x040037CE RID: 14286
		private List<Vector2> topRays;

		// Token: 0x040037CF RID: 14287
		private List<Vector2> rightRays;

		// Token: 0x040037D0 RID: 14288
		private List<Vector2> bottomRays;

		// Token: 0x040037D1 RID: 14289
		private List<Vector2> leftRays;

		// Token: 0x040037D2 RID: 14290
		private bool checkUp;

		// Token: 0x040037D3 RID: 14291
		private bool checkDown;

		// Token: 0x040037D4 RID: 14292
		private bool checkLeft;

		// Token: 0x040037D5 RID: 14293
		private bool checkRight;

		// Token: 0x020009A4 RID: 2468
		public enum CollisionSide
		{
			// Token: 0x040037D7 RID: 14295
			top,
			// Token: 0x040037D8 RID: 14296
			left,
			// Token: 0x040037D9 RID: 14297
			right,
			// Token: 0x040037DA RID: 14298
			bottom,
			// Token: 0x040037DB RID: 14299
			other
		}
	}
}
