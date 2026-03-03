using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C81 RID: 3201
	[ActionCategory(ActionCategory.Camera)]
	[Tooltip("Transforms position from screen space into world space. NOTE: Uses the MainCamera!")]
	public class ScreenToWorldPoint : FsmStateAction
	{
		// Token: 0x060042ED RID: 17133 RVA: 0x00171728 File Offset: 0x0016F928
		public override void Reset()
		{
			this.screenVector = null;
			this.screenX = new FsmFloat
			{
				UseVariable = true
			};
			this.screenY = new FsmFloat
			{
				UseVariable = true
			};
			this.screenZ = 1f;
			this.normalized = false;
			this.storeWorldVector = null;
			this.storeWorldX = null;
			this.storeWorldY = null;
			this.storeWorldZ = null;
			this.everyFrame = false;
		}

		// Token: 0x060042EE RID: 17134 RVA: 0x0017179F File Offset: 0x0016F99F
		public override void OnEnter()
		{
			this.DoScreenToWorldPoint();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060042EF RID: 17135 RVA: 0x001717B5 File Offset: 0x0016F9B5
		public override void OnUpdate()
		{
			this.DoScreenToWorldPoint();
		}

		// Token: 0x060042F0 RID: 17136 RVA: 0x001717C0 File Offset: 0x0016F9C0
		private void DoScreenToWorldPoint()
		{
			if (Camera.main == null)
			{
				base.LogError("No MainCamera defined!");
				base.Finish();
				return;
			}
			Vector3 vector = Vector3.zero;
			if (!this.screenVector.IsNone)
			{
				vector = this.screenVector.Value;
			}
			if (!this.screenX.IsNone)
			{
				vector.x = this.screenX.Value;
			}
			if (!this.screenY.IsNone)
			{
				vector.y = this.screenY.Value;
			}
			if (!this.screenZ.IsNone)
			{
				vector.z = this.screenZ.Value;
			}
			if (this.normalized.Value)
			{
				vector.x *= (float)Screen.width;
				vector.y *= (float)Screen.height;
			}
			vector = Camera.main.ScreenToWorldPoint(vector);
			this.storeWorldVector.Value = vector;
			this.storeWorldX.Value = vector.x;
			this.storeWorldY.Value = vector.y;
			this.storeWorldZ.Value = vector.z;
		}

		// Token: 0x04004737 RID: 18231
		[UIHint(UIHint.Variable)]
		[Tooltip("Screen position as a vector.")]
		public FsmVector3 screenVector;

		// Token: 0x04004738 RID: 18232
		[Tooltip("Screen X position in pixels or normalized. See Normalized.")]
		public FsmFloat screenX;

		// Token: 0x04004739 RID: 18233
		[Tooltip("Screen X position in pixels or normalized. See Normalized.")]
		public FsmFloat screenY;

		// Token: 0x0400473A RID: 18234
		[Tooltip("Distance into the screen in world units.")]
		public FsmFloat screenZ;

		// Token: 0x0400473B RID: 18235
		[Tooltip("If true, X/Y coordinates are considered normalized (0-1), otherwise they are expected to be in pixels")]
		public FsmBool normalized;

		// Token: 0x0400473C RID: 18236
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the world position in a vector3 variable.")]
		public FsmVector3 storeWorldVector;

		// Token: 0x0400473D RID: 18237
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the world X position in a float variable.")]
		public FsmFloat storeWorldX;

		// Token: 0x0400473E RID: 18238
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the world Y position in a float variable.")]
		public FsmFloat storeWorldY;

		// Token: 0x0400473F RID: 18239
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the world Z position in a float variable.")]
		public FsmFloat storeWorldZ;

		// Token: 0x04004740 RID: 18240
		[Tooltip("Repeat every frame")]
		public bool everyFrame;
	}
}
