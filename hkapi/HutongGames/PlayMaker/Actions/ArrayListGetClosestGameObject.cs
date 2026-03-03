using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000945 RID: 2373
	[ActionCategory("ArrayMaker/ArrayList")]
	[Tooltip("Return the closest GameObject within an arrayList from a transform or position.")]
	public class ArrayListGetClosestGameObject : ArrayListActions
	{
		// Token: 0x0600343F RID: 13375 RVA: 0x001386A9 File Offset: 0x001368A9
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
			this.distanceFrom = null;
			this.orDistanceFromVector3 = null;
			this.closestGameObject = null;
			this.closestIndex = null;
			this.everyframe = true;
		}

		// Token: 0x06003440 RID: 13376 RVA: 0x001386DC File Offset: 0x001368DC
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

		// Token: 0x06003441 RID: 13377 RVA: 0x0013871C File Offset: 0x0013691C
		public override void OnUpdate()
		{
			this.DoFindClosestGo();
		}

		// Token: 0x06003442 RID: 13378 RVA: 0x00138724 File Offset: 0x00136924
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
				if (gameObject != null)
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

		// Token: 0x040035DA RID: 13786
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker ArrayList Proxy component")]
		[CheckForComponent(typeof(PlayMakerArrayListProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040035DB RID: 13787
		[Tooltip("Author defined Reference of the PlayMaker ArrayList Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;

		// Token: 0x040035DC RID: 13788
		[Tooltip("Compare the distance of the items in the list to the position of this gameObject")]
		public FsmGameObject distanceFrom;

		// Token: 0x040035DD RID: 13789
		[Tooltip("If DistanceFrom declared, use OrDistanceFromVector3 as an offset")]
		public FsmVector3 orDistanceFromVector3;

		// Token: 0x040035DE RID: 13790
		public bool everyframe;

		// Token: 0x040035DF RID: 13791
		[ActionSection("Result")]
		[UIHint(UIHint.Variable)]
		public FsmGameObject closestGameObject;

		// Token: 0x040035E0 RID: 13792
		[UIHint(UIHint.Variable)]
		public FsmInt closestIndex;
	}
}
