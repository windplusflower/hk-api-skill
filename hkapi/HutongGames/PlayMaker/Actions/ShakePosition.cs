using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A5D RID: 2653
	[ActionCategory("Hollow Knight")]
	[Tooltip("Randomly shakes a GameObject's position by a diminishing amount over time.")]
	public class ShakePosition : FsmStateAction
	{
		// Token: 0x0600394F RID: 14671 RVA: 0x0014DC67 File Offset: 0x0014BE67
		public override void Reset()
		{
			base.Reset();
			this.gameObject = new FsmOwnerDefault
			{
				OwnerOption = OwnerDefaultOption.UseOwner
			};
			this.duration = 1f;
			this.isLooping = false;
			this.stopEvent = null;
		}

		// Token: 0x06003950 RID: 14672 RVA: 0x0014DCA4 File Offset: 0x0014BEA4
		public override void OnEnter()
		{
			base.OnEnter();
			this.timer = 0f;
			GameObject safe = this.gameObject.GetSafe(this);
			if (safe != null)
			{
				this.target = safe.transform;
				this.startingWorldPosition = this.target.position;
			}
			else
			{
				this.target = null;
			}
			this.UpdateShaking();
		}

		// Token: 0x06003951 RID: 14673 RVA: 0x0014DD04 File Offset: 0x0014BF04
		public override void OnUpdate()
		{
			base.OnUpdate();
			this.UpdateShaking();
		}

		// Token: 0x06003952 RID: 14674 RVA: 0x0014DD12 File Offset: 0x0014BF12
		public override void OnExit()
		{
			this.StopAndReset();
			base.OnExit();
		}

		// Token: 0x06003953 RID: 14675 RVA: 0x0014DD20 File Offset: 0x0014BF20
		private void UpdateShaking()
		{
			if (this.target != null)
			{
				bool value = this.isLooping.Value;
				float num = Mathf.Clamp01(1f - this.timer / this.duration.Value);
				Vector3 a = Vector3.Scale(this.extents.Value, new Vector3(UnityEngine.Random.Range(-1f, 1f), UnityEngine.Random.Range(-1f, 1f), UnityEngine.Random.Range(-1f, 1f)));
				this.target.position = this.startingWorldPosition + a * (value ? 1f : num);
				this.timer += Time.deltaTime;
				if (!value && this.timer > this.duration.Value)
				{
					this.StopAndReset();
					base.Fsm.Event(this.stopEvent);
					base.Finish();
					return;
				}
			}
			else
			{
				this.StopAndReset();
				base.Fsm.Event(this.stopEvent);
				base.Finish();
			}
		}

		// Token: 0x06003954 RID: 14676 RVA: 0x0014DE35 File Offset: 0x0014C035
		private void StopAndReset()
		{
			if (this.target != null)
			{
				this.target.position = this.startingWorldPosition;
				this.target = null;
			}
		}

		// Token: 0x04003BEF RID: 15343
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003BF0 RID: 15344
		[RequiredField]
		public FsmVector3 extents;

		// Token: 0x04003BF1 RID: 15345
		public FsmFloat duration;

		// Token: 0x04003BF2 RID: 15346
		public FsmBool isLooping;

		// Token: 0x04003BF3 RID: 15347
		public FsmEvent stopEvent;

		// Token: 0x04003BF4 RID: 15348
		private float timer;

		// Token: 0x04003BF5 RID: 15349
		private Transform target;

		// Token: 0x04003BF6 RID: 15350
		private Vector3 startingWorldPosition;
	}
}
