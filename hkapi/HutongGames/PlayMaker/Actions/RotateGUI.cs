using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C7A RID: 3194
	[ActionCategory(ActionCategory.GUI)]
	[Tooltip("Rotates the GUI around a pivot point. By default only effects GUI rendered by this FSM, check Apply Globally to effect all GUI controls.")]
	public class RotateGUI : FsmStateAction
	{
		// Token: 0x060042B9 RID: 17081 RVA: 0x00170E22 File Offset: 0x0016F022
		public override void Reset()
		{
			this.angle = 0f;
			this.pivotX = 0.5f;
			this.pivotY = 0.5f;
			this.normalized = true;
			this.applyGlobally = false;
		}

		// Token: 0x060042BA RID: 17082 RVA: 0x00170E64 File Offset: 0x0016F064
		public override void OnGUI()
		{
			if (this.applied)
			{
				return;
			}
			Vector2 pivotPoint = new Vector2(this.pivotX.Value, this.pivotY.Value);
			if (this.normalized)
			{
				pivotPoint.x *= (float)Screen.width;
				pivotPoint.y *= (float)Screen.height;
			}
			GUIUtility.RotateAroundPivot(this.angle.Value, pivotPoint);
			if (this.applyGlobally)
			{
				PlayMakerGUI.GUIMatrix = GUI.matrix;
				this.applied = true;
			}
		}

		// Token: 0x060042BB RID: 17083 RVA: 0x00170EEB File Offset: 0x0016F0EB
		public override void OnUpdate()
		{
			this.applied = false;
		}

		// Token: 0x04004712 RID: 18194
		[RequiredField]
		public FsmFloat angle;

		// Token: 0x04004713 RID: 18195
		[RequiredField]
		public FsmFloat pivotX;

		// Token: 0x04004714 RID: 18196
		[RequiredField]
		public FsmFloat pivotY;

		// Token: 0x04004715 RID: 18197
		public bool normalized;

		// Token: 0x04004716 RID: 18198
		public bool applyGlobally;

		// Token: 0x04004717 RID: 18199
		private bool applied;
	}
}
