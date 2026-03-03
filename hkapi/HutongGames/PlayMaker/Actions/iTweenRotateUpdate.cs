using System;
using System.Collections;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D39 RID: 3385
	[ActionCategory("iTween")]
	[Tooltip("Similar to RotateTo but incredibly less expensive for usage inside the Update function or similar looping situations involving a 'live' set of changing values. Does not utilize an EaseType.")]
	public class iTweenRotateUpdate : FsmStateAction
	{
		// Token: 0x06004611 RID: 17937 RVA: 0x0017D7FC File Offset: 0x0017B9FC
		public override void Reset()
		{
			this.transformRotation = new FsmGameObject
			{
				UseVariable = true
			};
			this.vectorRotation = new FsmVector3
			{
				UseVariable = true
			};
			this.time = 1f;
			this.space = Space.World;
		}

		// Token: 0x06004612 RID: 17938 RVA: 0x0017D83C File Offset: 0x0017BA3C
		public override void OnEnter()
		{
			this.hash = new Hashtable();
			this.go = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (this.go == null)
			{
				base.Finish();
				return;
			}
			if (this.transformRotation.IsNone)
			{
				this.hash.Add("rotation", this.vectorRotation.IsNone ? Vector3.zero : this.vectorRotation.Value);
			}
			else if (this.vectorRotation.IsNone)
			{
				this.hash.Add("rotation", this.transformRotation.Value.transform);
			}
			else if (this.space == Space.World)
			{
				this.hash.Add("rotation", this.transformRotation.Value.transform.eulerAngles + this.vectorRotation.Value);
			}
			else
			{
				this.hash.Add("rotation", this.transformRotation.Value.transform.localEulerAngles + this.vectorRotation.Value);
			}
			this.hash.Add("time", this.time.IsNone ? 1f : this.time.Value);
			this.hash.Add("islocal", this.space == Space.Self);
			this.DoiTween();
		}

		// Token: 0x06004613 RID: 17939 RVA: 0x00003603 File Offset: 0x00001803
		public override void OnExit()
		{
		}

		// Token: 0x06004614 RID: 17940 RVA: 0x0017D9D0 File Offset: 0x0017BBD0
		public override void OnUpdate()
		{
			this.hash.Remove("rotation");
			if (this.transformRotation.IsNone)
			{
				this.hash.Add("rotation", this.vectorRotation.IsNone ? Vector3.zero : this.vectorRotation.Value);
			}
			else if (this.vectorRotation.IsNone)
			{
				this.hash.Add("rotation", this.transformRotation.Value.transform);
			}
			else if (this.space == Space.World)
			{
				this.hash.Add("rotation", this.transformRotation.Value.transform.eulerAngles + this.vectorRotation.Value);
			}
			else
			{
				this.hash.Add("rotation", this.transformRotation.Value.transform.localEulerAngles + this.vectorRotation.Value);
			}
			this.DoiTween();
		}

		// Token: 0x06004615 RID: 17941 RVA: 0x0017DAE9 File Offset: 0x0017BCE9
		private void DoiTween()
		{
			iTween.RotateUpdate(this.go, this.hash);
		}

		// Token: 0x04004ADA RID: 19162
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004ADB RID: 19163
		[Tooltip("Rotate to a transform rotation.")]
		public FsmGameObject transformRotation;

		// Token: 0x04004ADC RID: 19164
		[Tooltip("A rotation the GameObject will animate from.")]
		public FsmVector3 vectorRotation;

		// Token: 0x04004ADD RID: 19165
		[Tooltip("The time in seconds the animation will take to complete. If transformRotation is set, this is used as an offset.")]
		public FsmFloat time;

		// Token: 0x04004ADE RID: 19166
		[Tooltip("Whether to animate in local or world space.")]
		public Space space;

		// Token: 0x04004ADF RID: 19167
		private Hashtable hash;

		// Token: 0x04004AE0 RID: 19168
		private GameObject go;
	}
}
