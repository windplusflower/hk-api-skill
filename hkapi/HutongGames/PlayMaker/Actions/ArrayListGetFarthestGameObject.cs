using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000947 RID: 2375
	[ActionCategory("ArrayMaker/ArrayList")]
	[Tooltip("Return the farthest GameObject within an arrayList from a transform or position.")]
	public class ArrayListGetFarthestGameObject : ArrayListActions
	{
		// Token: 0x0600344A RID: 13386 RVA: 0x00138A19 File Offset: 0x00136C19
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
			this.distanceFrom = null;
			this.orDistanceFromVector3 = null;
			this.farthestGameObject = null;
			this.farthestIndex = null;
			this.everyframe = true;
		}

		// Token: 0x0600344B RID: 13387 RVA: 0x00138A4C File Offset: 0x00136C4C
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

		// Token: 0x0600344C RID: 13388 RVA: 0x00138A8C File Offset: 0x00136C8C
		public override void OnUpdate()
		{
			this.DoFindFarthestGo();
		}

		// Token: 0x0600344D RID: 13389 RVA: 0x00138A94 File Offset: 0x00136C94
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
				if (gameObject != null)
				{
					float sqrMagnitude = (gameObject.transform.position - vector).sqrMagnitude;
					if (sqrMagnitude <= num)
					{
						num = sqrMagnitude;
						this.farthestGameObject.Value = gameObject;
						this.farthestIndex.Value = num2;
					}
				}
				num2++;
			}
		}

		// Token: 0x040035EB RID: 13803
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker ArrayList Proxy component")]
		[CheckForComponent(typeof(PlayMakerArrayListProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040035EC RID: 13804
		[Tooltip("Author defined Reference of the PlayMaker ArrayList Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;

		// Token: 0x040035ED RID: 13805
		[Tooltip("Compare the distance of the items in the list to the position of this gameObject")]
		public FsmGameObject distanceFrom;

		// Token: 0x040035EE RID: 13806
		[Tooltip("If DistanceFrom declared, use OrDistanceFromVector3 as an offset")]
		public FsmVector3 orDistanceFromVector3;

		// Token: 0x040035EF RID: 13807
		public bool everyframe;

		// Token: 0x040035F0 RID: 13808
		[ActionSection("Result")]
		[UIHint(UIHint.Variable)]
		public FsmGameObject farthestGameObject;

		// Token: 0x040035F1 RID: 13809
		[UIHint(UIHint.Variable)]
		public FsmInt farthestIndex;
	}
}
