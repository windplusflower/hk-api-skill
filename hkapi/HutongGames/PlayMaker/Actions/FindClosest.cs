using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B82 RID: 2946
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Finds the closest object to the specified Game Object.\nOptionally filter by Tag and Visibility.")]
	public class FindClosest : FsmStateAction
	{
		// Token: 0x06003E9A RID: 16026 RVA: 0x00164B8C File Offset: 0x00162D8C
		public override void Reset()
		{
			this.gameObject = null;
			this.withTag = "Untagged";
			this.ignoreOwner = true;
			this.mustBeVisible = false;
			this.storeObject = null;
			this.storeDistance = null;
			this.everyFrame = false;
		}

		// Token: 0x06003E9B RID: 16027 RVA: 0x00164BDD File Offset: 0x00162DDD
		public override void OnEnter()
		{
			this.DoFindClosest();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003E9C RID: 16028 RVA: 0x00164BF3 File Offset: 0x00162DF3
		public override void OnUpdate()
		{
			this.DoFindClosest();
		}

		// Token: 0x06003E9D RID: 16029 RVA: 0x00164BFC File Offset: 0x00162DFC
		private void DoFindClosest()
		{
			GameObject gameObject = (this.gameObject.OwnerOption == OwnerDefaultOption.UseOwner) ? base.Owner : this.gameObject.GameObject.Value;
			GameObject[] array;
			if (string.IsNullOrEmpty(this.withTag.Value) || this.withTag.Value == "Untagged")
			{
				array = (GameObject[])UnityEngine.Object.FindObjectsOfType(typeof(GameObject));
			}
			else
			{
				array = GameObject.FindGameObjectsWithTag(this.withTag.Value);
			}
			GameObject value = null;
			float num = float.PositiveInfinity;
			foreach (GameObject gameObject2 in array)
			{
				if ((!this.ignoreOwner.Value || !(gameObject2 == base.Owner)) && (!this.mustBeVisible.Value || ActionHelpers.IsVisible(gameObject2)))
				{
					float sqrMagnitude = (gameObject.transform.position - gameObject2.transform.position).sqrMagnitude;
					if (sqrMagnitude < num)
					{
						num = sqrMagnitude;
						value = gameObject2;
					}
				}
			}
			this.storeObject.Value = value;
			if (!this.storeDistance.IsNone)
			{
				this.storeDistance.Value = Mathf.Sqrt(num);
			}
		}

		// Token: 0x040042AA RID: 17066
		[RequiredField]
		[Tooltip("The GameObject to measure from.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040042AB RID: 17067
		[RequiredField]
		[UIHint(UIHint.Tag)]
		[Tooltip("Only consider objects with this Tag. NOTE: It's generally a lot quicker to find objects with a Tag!")]
		public FsmString withTag;

		// Token: 0x040042AC RID: 17068
		[Tooltip("If checked, ignores the object that owns this FSM.")]
		public FsmBool ignoreOwner;

		// Token: 0x040042AD RID: 17069
		[Tooltip("Only consider objects visible to the camera.")]
		public FsmBool mustBeVisible;

		// Token: 0x040042AE RID: 17070
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the closest object.")]
		public FsmGameObject storeObject;

		// Token: 0x040042AF RID: 17071
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the distance to the closest object.")]
		public FsmFloat storeDistance;

		// Token: 0x040042B0 RID: 17072
		[Tooltip("Repeat every frame")]
		public bool everyFrame;
	}
}
