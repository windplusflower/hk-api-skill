using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C0B RID: 3083
	[ActionCategory(ActionCategory.Physics)]
	[Tooltip("Gets info on the last RaycastAll and store in array variables.")]
	public class GetRaycastAllInfo : FsmStateAction
	{
		// Token: 0x060040B8 RID: 16568 RVA: 0x0016AC3F File Offset: 0x00168E3F
		public override void Reset()
		{
			this.storeHitObjects = null;
			this.points = null;
			this.normals = null;
			this.distances = null;
			this.everyFrame = false;
		}

		// Token: 0x060040B9 RID: 16569 RVA: 0x0016AC64 File Offset: 0x00168E64
		private void StoreRaycastAllInfo()
		{
			if (RaycastAll.RaycastAllHitInfo == null)
			{
				return;
			}
			this.storeHitObjects.Resize(RaycastAll.RaycastAllHitInfo.Length);
			this.points.Resize(RaycastAll.RaycastAllHitInfo.Length);
			this.normals.Resize(RaycastAll.RaycastAllHitInfo.Length);
			this.distances.Resize(RaycastAll.RaycastAllHitInfo.Length);
			for (int i = 0; i < RaycastAll.RaycastAllHitInfo.Length; i++)
			{
				this.storeHitObjects.Values[i] = RaycastAll.RaycastAllHitInfo[i].collider.gameObject;
				this.points.Values[i] = RaycastAll.RaycastAllHitInfo[i].point;
				this.normals.Values[i] = RaycastAll.RaycastAllHitInfo[i].normal;
				this.distances.Values[i] = RaycastAll.RaycastAllHitInfo[i].distance;
			}
		}

		// Token: 0x060040BA RID: 16570 RVA: 0x0016AD61 File Offset: 0x00168F61
		public override void OnEnter()
		{
			this.StoreRaycastAllInfo();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060040BB RID: 16571 RVA: 0x0016AD77 File Offset: 0x00168F77
		public override void OnUpdate()
		{
			this.StoreRaycastAllInfo();
		}

		// Token: 0x04004501 RID: 17665
		[Tooltip("Store the GameObjects hit in an array variable.")]
		[UIHint(UIHint.Variable)]
		[ArrayEditor(VariableType.GameObject, "", 0, 0, 65536)]
		public FsmArray storeHitObjects;

		// Token: 0x04004502 RID: 17666
		[Tooltip("Get the world position of all ray hit point and store them in an array variable.")]
		[UIHint(UIHint.Variable)]
		[ArrayEditor(VariableType.Vector3, "", 0, 0, 65536)]
		public FsmArray points;

		// Token: 0x04004503 RID: 17667
		[Tooltip("Get the normal at all hit points and store them in an array variable.")]
		[UIHint(UIHint.Variable)]
		[ArrayEditor(VariableType.Vector3, "", 0, 0, 65536)]
		public FsmArray normals;

		// Token: 0x04004504 RID: 17668
		[Tooltip("Get the distance along the ray to all hit points and store tjem in an array variable.")]
		[UIHint(UIHint.Variable)]
		[ArrayEditor(VariableType.Float, "", 0, 0, 65536)]
		public FsmArray distances;

		// Token: 0x04004505 RID: 17669
		[Tooltip("Repeat every frame. Warning, this could be affecting performances")]
		public bool everyFrame;
	}
}
