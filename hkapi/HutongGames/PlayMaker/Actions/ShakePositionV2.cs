using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A5E RID: 2654
	[ActionCategory("Hollow Knight")]
	[Tooltip("Randomly shakes a GameObject's position by a diminishing amount over time.")]
	public class ShakePositionV2 : FsmStateAction
	{
		// Token: 0x06003956 RID: 14678 RVA: 0x0014DE60 File Offset: 0x0014C060
		public override void Reset()
		{
			base.Reset();
			this.Target = new FsmOwnerDefault
			{
				OwnerOption = OwnerDefaultOption.UseOwner
			};
			this.Extents = null;
			this.Duration = 1f;
			this.IsLooping = false;
			this.StopEvent = null;
			this.FpsLimit = null;
			this.IsCameraShake = null;
		}

		// Token: 0x06003957 RID: 14679 RVA: 0x0014DEC0 File Offset: 0x0014C0C0
		public override void OnEnter()
		{
			base.OnEnter();
			this.timer = 0f;
			GameObject safe = this.Target.GetSafe(this);
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

		// Token: 0x06003958 RID: 14680 RVA: 0x0014DF20 File Offset: 0x0014C120
		public override void OnUpdate()
		{
			base.OnUpdate();
			this.UpdateShaking();
		}

		// Token: 0x06003959 RID: 14681 RVA: 0x0014DF2E File Offset: 0x0014C12E
		public override void OnExit()
		{
			this.StopAndReset();
			base.OnExit();
		}

		// Token: 0x0600395A RID: 14682 RVA: 0x0014DF3C File Offset: 0x0014C13C
		private void UpdateShaking()
		{
			if (this.target != null)
			{
				this.timer += Time.deltaTime;
				if (this.FpsLimit.Value > 0f)
				{
					if (Time.unscaledTime < this.nextUpdateTime)
					{
						return;
					}
					this.nextUpdateTime = Time.unscaledTime + 1f / this.FpsLimit.Value;
				}
				bool value = this.IsLooping.Value;
				float num = value ? 1f : Mathf.Clamp01(1f - this.timer / this.Duration.Value);
				if (this.IsCameraShake.Value)
				{
					num *= ConfigManager.CameraShakeMultiplier;
				}
				Vector3 a = Vector3.Scale(this.Extents.Value, new Vector3(UnityEngine.Random.Range(-1f, 1f), UnityEngine.Random.Range(-1f, 1f), UnityEngine.Random.Range(-1f, 1f)));
				this.target.position = this.startingWorldPosition + a * num;
				if (!value && this.timer > this.Duration.Value)
				{
					this.StopAndReset();
					base.Fsm.Event(this.StopEvent);
					base.Finish();
					return;
				}
			}
			else
			{
				this.StopAndReset();
				base.Fsm.Event(this.StopEvent);
				base.Finish();
			}
		}

		// Token: 0x0600395B RID: 14683 RVA: 0x0014E0A1 File Offset: 0x0014C2A1
		private void StopAndReset()
		{
			if (this.target != null)
			{
				this.target.position = this.startingWorldPosition;
				this.target = null;
			}
		}

		// Token: 0x04003BF7 RID: 15351
		[RequiredField]
		public FsmOwnerDefault Target;

		// Token: 0x04003BF8 RID: 15352
		[RequiredField]
		public FsmVector3 Extents;

		// Token: 0x04003BF9 RID: 15353
		public FsmFloat Duration;

		// Token: 0x04003BFA RID: 15354
		public FsmBool IsLooping;

		// Token: 0x04003BFB RID: 15355
		public FsmEvent StopEvent;

		// Token: 0x04003BFC RID: 15356
		public FsmFloat FpsLimit;

		// Token: 0x04003BFD RID: 15357
		public FsmBool IsCameraShake;

		// Token: 0x04003BFE RID: 15358
		private float timer;

		// Token: 0x04003BFF RID: 15359
		private float nextUpdateTime;

		// Token: 0x04003C00 RID: 15360
		private Transform target;

		// Token: 0x04003C01 RID: 15361
		private Vector3 startingWorldPosition;
	}
}
