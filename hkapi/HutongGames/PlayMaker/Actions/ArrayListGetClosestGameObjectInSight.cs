using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000946 RID: 2374
	[ActionCategory("ArrayMaker/ArrayList")]
	[Tooltip("Return the closest GameObject within an arrayList from a transform or position which does not have a collider between itself and another GameObject")]
	public class ArrayListGetClosestGameObjectInSight : ArrayListActions
	{
		// Token: 0x06003444 RID: 13380 RVA: 0x00138814 File Offset: 0x00136A14
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
			this.distanceFrom = null;
			this.orDistanceFromVector3 = null;
			this.closestGameObject = null;
			this.closestIndex = null;
			this.everyframe = true;
			this.fromGameObject = null;
			this.layerMask = new FsmInt[0];
			this.invertMask = false;
		}

		// Token: 0x06003445 RID: 13381 RVA: 0x00138871 File Offset: 0x00136A71
		public override void OnEnter()
		{
			if (!base.SetUpArrayListProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				base.Finish();
			}
			this.DoFindClosestGo();
			if (!this.everyframe)
			{
				base.Finish();
			}
		}

		// Token: 0x06003446 RID: 13382 RVA: 0x001388B1 File Offset: 0x00136AB1
		public override void OnUpdate()
		{
			this.DoFindClosestGo();
		}

		// Token: 0x06003447 RID: 13383 RVA: 0x001388BC File Offset: 0x00136ABC
		private void DoFindClosestGo()
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
					if (sqrMagnitude <= num)
					{
						num = sqrMagnitude;
						this.closestGameObject.Value = gameObject;
						this.closestIndex.Value = num2;
					}
				}
				num2++;
			}
		}

		// Token: 0x06003448 RID: 13384 RVA: 0x001389B8 File Offset: 0x00136BB8
		private bool DoLineCast(GameObject toGameObject)
		{
			Vector3 position = base.Fsm.GetOwnerDefaultTarget(this.fromGameObject).transform.position;
			Vector3 position2 = toGameObject.transform.position;
			RaycastHit raycastHitInfo;
			bool result = !Physics.Linecast(position, position2, out raycastHitInfo, ActionHelpers.LayerArrayToLayerMask(this.layerMask, this.invertMask.Value));
			base.Fsm.RaycastHitInfo = raycastHitInfo;
			return result;
		}

		// Token: 0x040035E1 RID: 13793
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker ArrayList Proxy component")]
		[CheckForComponent(typeof(PlayMakerArrayListProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040035E2 RID: 13794
		[Tooltip("Author defined Reference of the PlayMaker ArrayList Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;

		// Token: 0x040035E3 RID: 13795
		[Tooltip("Compare the distance of the items in the list to the position of this gameObject")]
		public FsmGameObject distanceFrom;

		// Token: 0x040035E4 RID: 13796
		[Tooltip("If DistanceFrom declared, use OrDistanceFromVector3 as an offset")]
		public FsmVector3 orDistanceFromVector3;

		// Token: 0x040035E5 RID: 13797
		public bool everyframe;

		// Token: 0x040035E6 RID: 13798
		[ActionSection("Raycast Settings")]
		[Tooltip("The line start of the sweep.")]
		public FsmOwnerDefault fromGameObject;

		// Token: 0x040035E7 RID: 13799
		[UIHint(UIHint.Layer)]
		[Tooltip("Pick only from these layers.")]
		public FsmInt[] layerMask;

		// Token: 0x040035E8 RID: 13800
		[Tooltip("Invert the mask, so you pick from all layers except those defined above.")]
		public FsmBool invertMask;

		// Token: 0x040035E9 RID: 13801
		[ActionSection("Result")]
		[UIHint(UIHint.Variable)]
		public FsmGameObject closestGameObject;

		// Token: 0x040035EA RID: 13802
		[UIHint(UIHint.Variable)]
		public FsmInt closestIndex;
	}
}
