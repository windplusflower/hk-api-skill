using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000948 RID: 2376
	[ActionCategory("ArrayMaker/ArrayList")]
	[Tooltip("Return the farthest GameObject within an arrayList from a transform or position which does not have a collider between itself and another GameObject")]
	public class ArrayListGetFarthestGameObjectInSight : ArrayListActions
	{
		// Token: 0x0600344F RID: 13391 RVA: 0x00138B84 File Offset: 0x00136D84
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
			this.distanceFrom = null;
			this.orDistanceFromVector3 = null;
			this.farthestGameObject = null;
			this.farthestIndex = null;
			this.everyframe = true;
			this.fromGameObject = null;
			this.layerMask = new FsmInt[0];
			this.invertMask = false;
		}

		// Token: 0x06003450 RID: 13392 RVA: 0x00138BE1 File Offset: 0x00136DE1
		public override void OnEnter()
		{
			if (!base.SetUpArrayListProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				base.Finish();
			}
			this.DoFindFarthestGo();
			if (!this.everyframe)
			{
				base.Finish();
			}
		}

		// Token: 0x06003451 RID: 13393 RVA: 0x00138C21 File Offset: 0x00136E21
		public override void OnUpdate()
		{
			this.DoFindFarthestGo();
		}

		// Token: 0x06003452 RID: 13394 RVA: 0x00138C2C File Offset: 0x00136E2C
		private void DoFindFarthestGo()
		{
			if (!base.isProxyValid())
			{
				return;
			}
			Vector3 vector = this.orDistanceFromVector3.Value;
			GameObject value = this.distanceFrom.Value;
			if (value != null)
			{
				vector += value.transform.position;
			}
			float num = float.PositiveInfinity;
			int num2 = 0;
			foreach (object obj in this.proxy.arrayList)
			{
				GameObject gameObject = (GameObject)obj;
				if (gameObject != null && this.DoLineCast(gameObject))
				{
					float sqrMagnitude = (gameObject.transform.position - vector).sqrMagnitude;
					if (sqrMagnitude >= num)
					{
						num = sqrMagnitude;
						this.farthestGameObject.Value = gameObject;
						this.farthestIndex.Value = num2;
					}
				}
				num2++;
			}
		}

		// Token: 0x06003453 RID: 13395 RVA: 0x00138D28 File Offset: 0x00136F28
		private bool DoLineCast(GameObject toGameObject)
		{
			Vector3 position = base.Fsm.GetOwnerDefaultTarget(this.fromGameObject).transform.position;
			Vector3 position2 = toGameObject.transform.position;
			RaycastHit raycastHitInfo;
			bool result = !Physics.Linecast(position, position2, out raycastHitInfo, ActionHelpers.LayerArrayToLayerMask(this.layerMask, this.invertMask.Value));
			base.Fsm.RaycastHitInfo = raycastHitInfo;
			return result;
		}

		// Token: 0x040035F2 RID: 13810
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker ArrayList Proxy component")]
		[CheckForComponent(typeof(PlayMakerArrayListProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040035F3 RID: 13811
		[Tooltip("Author defined Reference of the PlayMaker ArrayList Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;

		// Token: 0x040035F4 RID: 13812
		[Tooltip("Compare the distance of the items in the list to the position of this gameObject")]
		public FsmGameObject distanceFrom;

		// Token: 0x040035F5 RID: 13813
		[Tooltip("If DistanceFrom declared, use OrDistanceFromVector3 as an offset")]
		public FsmVector3 orDistanceFromVector3;

		// Token: 0x040035F6 RID: 13814
		public bool everyframe;

		// Token: 0x040035F7 RID: 13815
		[ActionSection("Raycast Settings")]
		[Tooltip("The line start of the sweep.")]
		public FsmOwnerDefault fromGameObject;

		// Token: 0x040035F8 RID: 13816
		[UIHint(UIHint.Layer)]
		[Tooltip("Pick only from these layers.")]
		public FsmInt[] layerMask;

		// Token: 0x040035F9 RID: 13817
		[Tooltip("Invert the mask, so you pick from all layers except those defined above.")]
		public FsmBool invertMask;

		// Token: 0x040035FA RID: 13818
		[ActionSection("Result")]
		[UIHint(UIHint.Variable)]
		public FsmGameObject farthestGameObject;

		// Token: 0x040035FB RID: 13819
		[UIHint(UIHint.Variable)]
		public FsmInt farthestIndex;
	}
}
