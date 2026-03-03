using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B34 RID: 2868
	[ActionCategory(ActionCategory.Effects)]
	[Tooltip("Turns a Game Object on/off in a regular repeating pattern.")]
	public class Blink : ComponentAction<Renderer>
	{
		// Token: 0x06003D4F RID: 15695 RVA: 0x001609B0 File Offset: 0x0015EBB0
		public override void Reset()
		{
			this.gameObject = null;
			this.timeOff = 0.5f;
			this.timeOn = 0.5f;
			this.rendererOnly = true;
			this.startOn = false;
			this.realTime = false;
		}

		// Token: 0x06003D50 RID: 15696 RVA: 0x001609FE File Offset: 0x0015EBFE
		public override void OnEnter()
		{
			this.startTime = FsmTime.RealtimeSinceStartup;
			this.timer = 0f;
			this.UpdateBlinkState(this.startOn.Value);
		}

		// Token: 0x06003D51 RID: 15697 RVA: 0x00160A28 File Offset: 0x0015EC28
		public override void OnUpdate()
		{
			if (this.realTime)
			{
				this.timer = FsmTime.RealtimeSinceStartup - this.startTime;
			}
			else
			{
				this.timer += Time.deltaTime;
			}
			if (this.blinkOn && this.timer > this.timeOn.Value)
			{
				this.UpdateBlinkState(false);
			}
			if (!this.blinkOn && this.timer > this.timeOff.Value)
			{
				this.UpdateBlinkState(true);
			}
		}

		// Token: 0x06003D52 RID: 15698 RVA: 0x00160AA8 File Offset: 0x0015ECA8
		private void UpdateBlinkState(bool state)
		{
			GameObject gameObject = (this.gameObject.OwnerOption == OwnerDefaultOption.UseOwner) ? base.Owner : this.gameObject.GameObject.Value;
			if (gameObject == null)
			{
				return;
			}
			if (this.rendererOnly)
			{
				if (base.UpdateCache(gameObject))
				{
					base.renderer.enabled = state;
				}
			}
			else
			{
				gameObject.SetActive(state);
			}
			this.blinkOn = state;
			this.startTime = FsmTime.RealtimeSinceStartup;
			this.timer = 0f;
		}

		// Token: 0x0400415E RID: 16734
		[RequiredField]
		[Tooltip("The GameObject to blink on/off.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400415F RID: 16735
		[HasFloatSlider(0f, 5f)]
		[Tooltip("Time to stay off in seconds.")]
		public FsmFloat timeOff;

		// Token: 0x04004160 RID: 16736
		[HasFloatSlider(0f, 5f)]
		[Tooltip("Time to stay on in seconds.")]
		public FsmFloat timeOn;

		// Token: 0x04004161 RID: 16737
		[Tooltip("Should the object start in the active/visible state?")]
		public FsmBool startOn;

		// Token: 0x04004162 RID: 16738
		[Tooltip("Only effect the renderer, keeping other components active.")]
		public bool rendererOnly;

		// Token: 0x04004163 RID: 16739
		[Tooltip("Ignore TimeScale. Useful if the game is paused.")]
		public bool realTime;

		// Token: 0x04004164 RID: 16740
		private float startTime;

		// Token: 0x04004165 RID: 16741
		private float timer;

		// Token: 0x04004166 RID: 16742
		private bool blinkOn;
	}
}
