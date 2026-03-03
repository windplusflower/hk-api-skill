using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C7E RID: 3198
	[ActionCategory(ActionCategory.GUI)]
	[Tooltip("Scales the GUI around a pivot point. By default only effects GUI rendered by this FSM, check Apply Globally to effect all GUI controls.")]
	public class ScaleGUI : FsmStateAction
	{
		// Token: 0x060042DF RID: 17119 RVA: 0x00171320 File Offset: 0x0016F520
		public override void Reset()
		{
			this.scaleX = 1f;
			this.scaleY = 1f;
			this.pivotX = 0.5f;
			this.pivotY = 0.5f;
			this.normalized = true;
			this.applyGlobally = false;
		}

		// Token: 0x060042E0 RID: 17120 RVA: 0x0017137C File Offset: 0x0016F57C
		public override void OnGUI()
		{
			if (this.applied)
			{
				return;
			}
			Vector2 vector = new Vector2(this.scaleX.Value, this.scaleY.Value);
			if (object.Equals(vector.x, 0))
			{
				vector.x = 0.0001f;
			}
			if (object.Equals(vector.y, 0))
			{
				vector.x = 0.0001f;
			}
			Vector2 pivotPoint = new Vector2(this.pivotX.Value, this.pivotY.Value);
			if (this.normalized)
			{
				pivotPoint.x *= (float)Screen.width;
				pivotPoint.y *= (float)Screen.height;
			}
			GUIUtility.ScaleAroundPivot(vector, pivotPoint);
			if (this.applyGlobally)
			{
				PlayMakerGUI.GUIMatrix = GUI.matrix;
				this.applied = true;
			}
		}

		// Token: 0x060042E1 RID: 17121 RVA: 0x0017145E File Offset: 0x0016F65E
		public override void OnUpdate()
		{
			this.applied = false;
		}

		// Token: 0x04004720 RID: 18208
		[RequiredField]
		public FsmFloat scaleX;

		// Token: 0x04004721 RID: 18209
		[RequiredField]
		public FsmFloat scaleY;

		// Token: 0x04004722 RID: 18210
		[RequiredField]
		public FsmFloat pivotX;

		// Token: 0x04004723 RID: 18211
		[RequiredField]
		public FsmFloat pivotY;

		// Token: 0x04004724 RID: 18212
		[Tooltip("Pivot point uses normalized coordinates. E.g. 0.5 is the center of the screen.")]
		public bool normalized;

		// Token: 0x04004725 RID: 18213
		public bool applyGlobally;

		// Token: 0x04004726 RID: 18214
		private bool applied;
	}
}
