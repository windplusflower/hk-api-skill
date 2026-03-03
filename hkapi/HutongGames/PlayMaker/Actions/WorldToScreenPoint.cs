using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D25 RID: 3365
	[ActionCategory(ActionCategory.Camera)]
	[Tooltip("Transforms position from world space into screen space. NOTE: Uses the MainCamera!")]
	public class WorldToScreenPoint : FsmStateAction
	{
		// Token: 0x060045B1 RID: 17841 RVA: 0x00179D58 File Offset: 0x00177F58
		public override void Reset()
		{
			this.worldPosition = null;
			this.worldX = new FsmFloat
			{
				UseVariable = true
			};
			this.worldY = new FsmFloat
			{
				UseVariable = true
			};
			this.worldZ = new FsmFloat
			{
				UseVariable = true
			};
			this.storeScreenPoint = null;
			this.storeScreenX = null;
			this.storeScreenY = null;
			this.everyFrame = false;
		}

		// Token: 0x060045B2 RID: 17842 RVA: 0x00179DBE File Offset: 0x00177FBE
		public override void OnEnter()
		{
			this.DoWorldToScreenPoint();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060045B3 RID: 17843 RVA: 0x00179DD4 File Offset: 0x00177FD4
		public override void OnUpdate()
		{
			this.DoWorldToScreenPoint();
		}

		// Token: 0x060045B4 RID: 17844 RVA: 0x00179DDC File Offset: 0x00177FDC
		private void DoWorldToScreenPoint()
		{
			if (Camera.main == null)
			{
				base.LogError("No MainCamera defined!");
				base.Finish();
				return;
			}
			Vector3 vector = Vector3.zero;
			if (!this.worldPosition.IsNone)
			{
				vector = this.worldPosition.Value;
			}
			if (!this.worldX.IsNone)
			{
				vector.x = this.worldX.Value;
			}
			if (!this.worldY.IsNone)
			{
				vector.y = this.worldY.Value;
			}
			if (!this.worldZ.IsNone)
			{
				vector.z = this.worldZ.Value;
			}
			vector = Camera.main.WorldToScreenPoint(vector);
			if (this.normalize.Value)
			{
				vector.x /= (float)Screen.width;
				vector.y /= (float)Screen.height;
			}
			this.storeScreenPoint.Value = vector;
			this.storeScreenX.Value = vector.x;
			this.storeScreenY.Value = vector.y;
		}

		// Token: 0x04004A17 RID: 18967
		[UIHint(UIHint.Variable)]
		[Tooltip("World position to transform into screen coordinates.")]
		public FsmVector3 worldPosition;

		// Token: 0x04004A18 RID: 18968
		[Tooltip("World X position.")]
		public FsmFloat worldX;

		// Token: 0x04004A19 RID: 18969
		[Tooltip("World Y position.")]
		public FsmFloat worldY;

		// Token: 0x04004A1A RID: 18970
		[Tooltip("World Z position.")]
		public FsmFloat worldZ;

		// Token: 0x04004A1B RID: 18971
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the screen position in a Vector3 Variable. Z will equal zero.")]
		public FsmVector3 storeScreenPoint;

		// Token: 0x04004A1C RID: 18972
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the screen X position in a Float Variable.")]
		public FsmFloat storeScreenX;

		// Token: 0x04004A1D RID: 18973
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the screen Y position in a Float Variable.")]
		public FsmFloat storeScreenY;

		// Token: 0x04004A1E RID: 18974
		[Tooltip("Normalize screen coordinates (0-1). Otherwise coordinates are in pixels.")]
		public FsmBool normalize;

		// Token: 0x04004A1F RID: 18975
		[Tooltip("Repeat every frame")]
		public bool everyFrame;
	}
}
