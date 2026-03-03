using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000ADB RID: 2779
	[ActionCategory(ActionCategory.Input)]
	[Tooltip("Sends Events based on mouse interactions with a 2d Game Object: MouseOver, MouseDown, MouseUp, MouseOff.")]
	public class MousePick2dEvent : FsmStateAction
	{
		// Token: 0x06003BB6 RID: 15286 RVA: 0x00158540 File Offset: 0x00156740
		public override void Reset()
		{
			this.GameObject = null;
			this.mouseOver = null;
			this.mouseDown = null;
			this.mouseUp = null;
			this.mouseOff = null;
			this.layerMask = new FsmInt[0];
			this.invertMask = false;
			this.everyFrame = true;
		}

		// Token: 0x06003BB7 RID: 15287 RVA: 0x0015858F File Offset: 0x0015678F
		public override void OnEnter()
		{
			this.DoMousePickEvent();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003BB8 RID: 15288 RVA: 0x001585A5 File Offset: 0x001567A5
		public override void OnUpdate()
		{
			this.DoMousePickEvent();
		}

		// Token: 0x06003BB9 RID: 15289 RVA: 0x001585B0 File Offset: 0x001567B0
		private void DoMousePickEvent()
		{
			if (this.DoRaycast())
			{
				if (this.mouseDown != null && Input.GetMouseButtonDown(0))
				{
					base.Fsm.Event(this.mouseDown);
				}
				if (this.mouseOver != null)
				{
					base.Fsm.Event(this.mouseOver);
				}
				if (this.mouseUp != null && Input.GetMouseButtonUp(0))
				{
					base.Fsm.Event(this.mouseUp);
					return;
				}
			}
			else if (this.mouseOff != null)
			{
				base.Fsm.Event(this.mouseOff);
			}
		}

		// Token: 0x06003BBA RID: 15290 RVA: 0x0015863C File Offset: 0x0015683C
		private bool DoRaycast()
		{
			GameObject y = (this.GameObject.OwnerOption == OwnerDefaultOption.UseOwner) ? base.Owner : this.GameObject.GameObject.Value;
			RaycastHit2D rayIntersection = Physics2D.GetRayIntersection(Camera.main.ScreenPointToRay(Input.mousePosition), float.PositiveInfinity, ActionHelpers.LayerArrayToLayerMask(this.layerMask, this.invertMask.Value));
			Fsm.RecordLastRaycastHit2DInfo(base.Fsm, rayIntersection);
			return rayIntersection.transform != null && rayIntersection.transform.gameObject == y;
		}

		// Token: 0x04003F53 RID: 16211
		[CheckForComponent(typeof(Collider2D))]
		[Tooltip("The GameObject with a Collider2D attached.")]
		public FsmOwnerDefault GameObject;

		// Token: 0x04003F54 RID: 16212
		[Tooltip("Event to send when the mouse is over the GameObject.")]
		public FsmEvent mouseOver;

		// Token: 0x04003F55 RID: 16213
		[Tooltip("Event to send when the mouse is pressed while over the GameObject.")]
		public FsmEvent mouseDown;

		// Token: 0x04003F56 RID: 16214
		[Tooltip("Event to send when the mouse is released while over the GameObject.")]
		public FsmEvent mouseUp;

		// Token: 0x04003F57 RID: 16215
		[Tooltip("Event to send when the mouse moves off the GameObject.")]
		public FsmEvent mouseOff;

		// Token: 0x04003F58 RID: 16216
		[Tooltip("Pick only from these layers.")]
		[UIHint(UIHint.Layer)]
		public FsmInt[] layerMask;

		// Token: 0x04003F59 RID: 16217
		[Tooltip("Invert the mask, so you pick from all layers except those defined above.")]
		public FsmBool invertMask;

		// Token: 0x04003F5A RID: 16218
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;
	}
}
