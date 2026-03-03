using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CFF RID: 3327
	[ActionCategory(ActionCategory.Device)]
	[ActionTarget(typeof(GameObject), "gameObject", false)]
	[Tooltip("Sends events when an object is touched. Optionally filter by a fingerID. NOTE: Uses the MainCamera!")]
	public class TouchObjectEvent : FsmStateAction
	{
		// Token: 0x06004510 RID: 17680 RVA: 0x00178110 File Offset: 0x00176310
		public override void Reset()
		{
			this.gameObject = null;
			this.pickDistance = 100f;
			this.fingerId = new FsmInt
			{
				UseVariable = true
			};
			this.touchBegan = null;
			this.touchMoved = null;
			this.touchStationary = null;
			this.touchEnded = null;
			this.touchCanceled = null;
			this.storeFingerId = null;
			this.storeHitPoint = null;
			this.storeHitNormal = null;
		}

		// Token: 0x06004511 RID: 17681 RVA: 0x00178180 File Offset: 0x00176380
		public override void OnUpdate()
		{
			if (Camera.main == null)
			{
				base.LogError("No MainCamera defined!");
				base.Finish();
				return;
			}
			if (Input.touchCount > 0)
			{
				GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
				if (ownerDefaultTarget == null)
				{
					return;
				}
				foreach (Touch touch in Input.touches)
				{
					if (this.fingerId.IsNone || touch.fingerId == this.fingerId.Value)
					{
						Vector2 position = touch.position;
						RaycastHit raycastHitInfo;
						Physics.Raycast(Camera.main.ScreenPointToRay(position), out raycastHitInfo, this.pickDistance.Value);
						base.Fsm.RaycastHitInfo = raycastHitInfo;
						if (raycastHitInfo.transform != null && raycastHitInfo.transform.gameObject == ownerDefaultTarget)
						{
							this.storeFingerId.Value = touch.fingerId;
							this.storeHitPoint.Value = raycastHitInfo.point;
							this.storeHitNormal.Value = raycastHitInfo.normal;
							switch (touch.phase)
							{
							case TouchPhase.Began:
								base.Fsm.Event(this.touchBegan);
								return;
							case TouchPhase.Moved:
								base.Fsm.Event(this.touchMoved);
								return;
							case TouchPhase.Stationary:
								base.Fsm.Event(this.touchStationary);
								return;
							case TouchPhase.Ended:
								base.Fsm.Event(this.touchEnded);
								return;
							case TouchPhase.Canceled:
								base.Fsm.Event(this.touchCanceled);
								return;
							}
						}
					}
				}
			}
		}

		// Token: 0x0400496E RID: 18798
		[RequiredField]
		[CheckForComponent(typeof(Collider))]
		[Tooltip("The Game Object to detect touches on.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400496F RID: 18799
		[RequiredField]
		[Tooltip("How far from the camera is the Game Object pickable.")]
		public FsmFloat pickDistance;

		// Token: 0x04004970 RID: 18800
		[Tooltip("Only detect touches that match this fingerID, or set to None.")]
		public FsmInt fingerId;

		// Token: 0x04004971 RID: 18801
		[ActionSection("Events")]
		[Tooltip("Event to send on touch began.")]
		public FsmEvent touchBegan;

		// Token: 0x04004972 RID: 18802
		[Tooltip("Event to send on touch moved.")]
		public FsmEvent touchMoved;

		// Token: 0x04004973 RID: 18803
		[Tooltip("Event to send on stationary touch.")]
		public FsmEvent touchStationary;

		// Token: 0x04004974 RID: 18804
		[Tooltip("Event to send on touch ended.")]
		public FsmEvent touchEnded;

		// Token: 0x04004975 RID: 18805
		[Tooltip("Event to send on touch cancel.")]
		public FsmEvent touchCanceled;

		// Token: 0x04004976 RID: 18806
		[ActionSection("Store Results")]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the fingerId of the touch.")]
		public FsmInt storeFingerId;

		// Token: 0x04004977 RID: 18807
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the world position where the object was touched.")]
		public FsmVector3 storeHitPoint;

		// Token: 0x04004978 RID: 18808
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the surface normal vector where the object was touched.")]
		public FsmVector3 storeHitNormal;
	}
}
