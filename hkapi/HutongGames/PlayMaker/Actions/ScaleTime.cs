using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C7F RID: 3199
	[ActionCategory(ActionCategory.Time)]
	[Tooltip("Scales time: 1 = normal, 0.5 = half speed, 2 = double speed.")]
	public class ScaleTime : FsmStateAction
	{
		// Token: 0x060042E3 RID: 17123 RVA: 0x00171467 File Offset: 0x0016F667
		public override void Reset()
		{
			this.timeScale = 1f;
			this.adjustFixedDeltaTime = true;
			this.everyFrame = false;
		}

		// Token: 0x060042E4 RID: 17124 RVA: 0x0017148C File Offset: 0x0016F68C
		public override void OnEnter()
		{
			this.DoTimeScale();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060042E5 RID: 17125 RVA: 0x001714A2 File Offset: 0x0016F6A2
		public override void OnUpdate()
		{
			this.DoTimeScale();
		}

		// Token: 0x060042E6 RID: 17126 RVA: 0x001714AA File Offset: 0x0016F6AA
		private void DoTimeScale()
		{
			Debug.LogErrorFormat("ScaleTime PlayMaker action was manually disabled.", Array.Empty<object>());
		}

		// Token: 0x04004727 RID: 18215
		[RequiredField]
		[HasFloatSlider(0f, 4f)]
		[Tooltip("Scales time: 1 = normal, 0.5 = half speed, 2 = double speed.")]
		public FsmFloat timeScale;

		// Token: 0x04004728 RID: 18216
		[Tooltip("Adjust the fixed physics time step to match the time scale.")]
		public FsmBool adjustFixedDeltaTime;

		// Token: 0x04004729 RID: 18217
		[Tooltip("Repeat every frame. Useful when animating the value.")]
		public bool everyFrame;
	}
}
