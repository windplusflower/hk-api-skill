using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B85 RID: 2949
	[ActionCategory(ActionCategory.Effects)]
	[Tooltip("Randomly flickers a Game Object on/off.")]
	public class Flicker : ComponentAction<Renderer>
	{
		// Token: 0x06003EA6 RID: 16038 RVA: 0x00164E6F File Offset: 0x0016306F
		public override void Reset()
		{
			this.gameObject = null;
			this.frequency = 0.1f;
			this.amountOn = 0.5f;
			this.rendererOnly = true;
			this.realTime = false;
		}

		// Token: 0x06003EA7 RID: 16039 RVA: 0x00164EA6 File Offset: 0x001630A6
		public override void OnEnter()
		{
			this.startTime = FsmTime.RealtimeSinceStartup;
			this.timer = 0f;
		}

		// Token: 0x06003EA8 RID: 16040 RVA: 0x00164EC0 File Offset: 0x001630C0
		public override void OnUpdate()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			if (this.realTime)
			{
				this.timer = FsmTime.RealtimeSinceStartup - this.startTime;
			}
			else
			{
				this.timer += Time.deltaTime;
			}
			if (this.timer > this.frequency.Value)
			{
				bool flag = UnityEngine.Random.Range(0f, 1f) < this.amountOn.Value;
				if (this.rendererOnly)
				{
					if (base.UpdateCache(ownerDefaultTarget))
					{
						base.renderer.enabled = flag;
					}
				}
				else
				{
					ownerDefaultTarget.SetActive(flag);
				}
				this.startTime = this.timer;
				this.timer = 0f;
			}
		}

		// Token: 0x040042B4 RID: 17076
		[RequiredField]
		[Tooltip("The GameObject to flicker.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040042B5 RID: 17077
		[HasFloatSlider(0f, 1f)]
		[Tooltip("The frequency of the flicker in seconds.")]
		public FsmFloat frequency;

		// Token: 0x040042B6 RID: 17078
		[HasFloatSlider(0f, 1f)]
		[Tooltip("Amount of time flicker is On (0-1). E.g. Use 0.95 for an occasional flicker.")]
		public FsmFloat amountOn;

		// Token: 0x040042B7 RID: 17079
		[Tooltip("Only effect the renderer, leaving other components active.")]
		public bool rendererOnly;

		// Token: 0x040042B8 RID: 17080
		[Tooltip("Ignore time scale. Useful if flickering UI when the game is paused.")]
		public bool realTime;

		// Token: 0x040042B9 RID: 17081
		private float startTime;

		// Token: 0x040042BA RID: 17082
		private float timer;
	}
}
