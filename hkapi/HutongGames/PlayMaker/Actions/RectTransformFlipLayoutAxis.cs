using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A0E RID: 2574
	[ActionCategory("RectTransform")]
	[Tooltip("Flips the horizontal and vertical axes of the RectTransform size and alignment, and optionally its children as well.")]
	public class RectTransformFlipLayoutAxis : FsmStateAction
	{
		// Token: 0x0600380C RID: 14348 RVA: 0x00149290 File Offset: 0x00147490
		public override void Reset()
		{
			this.gameObject = null;
			this.axis = RectTransformFlipLayoutAxis.RectTransformFlipOptions.Both;
			this.keepPositioning = null;
			this.recursive = null;
		}

		// Token: 0x0600380D RID: 14349 RVA: 0x001492AE File Offset: 0x001474AE
		public override void OnEnter()
		{
			this.DoFlip();
			base.Finish();
		}

		// Token: 0x0600380E RID: 14350 RVA: 0x001492BC File Offset: 0x001474BC
		private void DoFlip()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				RectTransform component = ownerDefaultTarget.GetComponent<RectTransform>();
				if (component != null)
				{
					if (this.axis == RectTransformFlipLayoutAxis.RectTransformFlipOptions.Both)
					{
						RectTransformUtility.FlipLayoutAxes(component, this.keepPositioning.Value, this.recursive.Value);
						return;
					}
					if (this.axis == RectTransformFlipLayoutAxis.RectTransformFlipOptions.Horizontal)
					{
						RectTransformUtility.FlipLayoutOnAxis(component, 0, this.keepPositioning.Value, this.recursive.Value);
						return;
					}
					if (this.axis == RectTransformFlipLayoutAxis.RectTransformFlipOptions.Vertical)
					{
						RectTransformUtility.FlipLayoutOnAxis(component, 1, this.keepPositioning.Value, this.recursive.Value);
					}
				}
			}
		}

		// Token: 0x04003A96 RID: 14998
		[RequiredField]
		[CheckForComponent(typeof(RectTransform))]
		[Tooltip("The GameObject target.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003A97 RID: 14999
		[Tooltip("The axis to flip")]
		public RectTransformFlipLayoutAxis.RectTransformFlipOptions axis;

		// Token: 0x04003A98 RID: 15000
		[Tooltip("Flips around the pivot if true. Flips within the parent rect if false.")]
		public FsmBool keepPositioning;

		// Token: 0x04003A99 RID: 15001
		[Tooltip("Flip the children as well?")]
		public FsmBool recursive;

		// Token: 0x02000A0F RID: 2575
		public enum RectTransformFlipOptions
		{
			// Token: 0x04003A9B RID: 15003
			Horizontal,
			// Token: 0x04003A9C RID: 15004
			Vertical,
			// Token: 0x04003A9D RID: 15005
			Both
		}
	}
}
