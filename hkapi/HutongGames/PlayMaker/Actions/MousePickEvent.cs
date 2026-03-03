using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C40 RID: 3136
	[ActionCategory(ActionCategory.Input)]
	[ActionTarget(typeof(GameObject), "GameObject", false)]
	[Tooltip("Sends Events based on mouse interactions with a Game Object: MouseOver, MouseDown, MouseUp, MouseOff. Use Ray Distance to set how close the camera must be to pick the object.\n\nNOTE: Picking uses the Main Camera.")]
	public class MousePickEvent : FsmStateAction
	{
		// Token: 0x060041A5 RID: 16805 RVA: 0x0016D574 File Offset: 0x0016B774
		public override void Reset()
		{
			this.GameObject = null;
			this.rayDistance = 100f;
			this.mouseOver = null;
			this.mouseDown = null;
			this.mouseUp = null;
			this.mouseOff = null;
			this.layerMask = new FsmInt[0];
			this.invertMask = false;
			this.everyFrame = true;
		}

		// Token: 0x060041A6 RID: 16806 RVA: 0x0016D5D3 File Offset: 0x0016B7D3
		public override void OnEnter()
		{
			this.DoMousePickEvent();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060041A7 RID: 16807 RVA: 0x0016D5E9 File Offset: 0x0016B7E9
		public override void OnUpdate()
		{
			this.DoMousePickEvent();
		}

		// Token: 0x060041A8 RID: 16808 RVA: 0x0016D5F4 File Offset: 0x0016B7F4
		private void DoMousePickEvent()
		{
			bool flag = this.DoRaycast();
			base.Fsm.RaycastHitInfo = ActionHelpers.mousePickInfo;
			if (flag)
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

		// Token: 0x060041A9 RID: 16809 RVA: 0x0016D690 File Offset: 0x0016B890
		private bool DoRaycast()
		{
			return ActionHelpers.IsMouseOver((this.GameObject.OwnerOption == OwnerDefaultOption.UseOwner) ? base.Owner : this.GameObject.GameObject.Value, this.rayDistance.Value, ActionHelpers.LayerArrayToLayerMask(this.layerMask, this.invertMask.Value));
		}

		// Token: 0x060041AA RID: 16810 RVA: 0x0016D6E8 File Offset: 0x0016B8E8
		public override string ErrorCheck()
		{
			return "" + ActionHelpers.CheckRayDistance(this.rayDistance.Value) + ActionHelpers.CheckPhysicsSetup(this.GameObject);
		}

		// Token: 0x060041AB RID: 16811 RVA: 0x0016D714 File Offset: 0x0016B914
		public MousePickEvent()
		{
			this.rayDistance = 100f;
			base..ctor();
		}

		// Token: 0x04004603 RID: 17923
		[CheckForComponent(typeof(Collider))]
		public FsmOwnerDefault GameObject;

		// Token: 0x04004604 RID: 17924
		[Tooltip("Length of the ray to cast from the camera.")]
		public FsmFloat rayDistance;

		// Token: 0x04004605 RID: 17925
		[Tooltip("Event to send when the mouse is over the GameObject.")]
		public FsmEvent mouseOver;

		// Token: 0x04004606 RID: 17926
		[Tooltip("Event to send when the mouse is pressed while over the GameObject.")]
		public FsmEvent mouseDown;

		// Token: 0x04004607 RID: 17927
		[Tooltip("Event to send when the mouse is released while over the GameObject.")]
		public FsmEvent mouseUp;

		// Token: 0x04004608 RID: 17928
		[Tooltip("Event to send when the mouse moves off the GameObject.")]
		public FsmEvent mouseOff;

		// Token: 0x04004609 RID: 17929
		[Tooltip("Pick only from these layers.")]
		[UIHint(UIHint.Layer)]
		public FsmInt[] layerMask;

		// Token: 0x0400460A RID: 17930
		[Tooltip("Invert the mask, so you pick from all layers except those defined above.")]
		public FsmBool invertMask;

		// Token: 0x0400460B RID: 17931
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;
	}
}
