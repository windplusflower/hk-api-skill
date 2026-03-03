using System;
using System.Collections;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D3E RID: 3390
	[ActionCategory("iTween")]
	[Tooltip("CSimilar to ScaleTo but incredibly less expensive for usage inside the Update function or similar looping situations involving a 'live' set of changing values. Does not utilize an EaseType.")]
	public class iTweenScaleUpdate : FsmStateAction
	{
		// Token: 0x0600462B RID: 17963 RVA: 0x0017E5D4 File Offset: 0x0017C7D4
		public override void Reset()
		{
			this.transformScale = new FsmGameObject
			{
				UseVariable = true
			};
			this.vectorScale = new FsmVector3
			{
				UseVariable = true
			};
			this.time = 1f;
		}

		// Token: 0x0600462C RID: 17964 RVA: 0x0017E60C File Offset: 0x0017C80C
		public override void OnEnter()
		{
			this.hash = new Hashtable();
			this.go = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (this.go == null)
			{
				base.Finish();
				return;
			}
			if (this.transformScale.IsNone)
			{
				this.hash.Add("scale", this.vectorScale.IsNone ? Vector3.zero : this.vectorScale.Value);
			}
			else if (this.vectorScale.IsNone)
			{
				this.hash.Add("scale", this.transformScale.Value.transform);
			}
			else
			{
				this.hash.Add("scale", this.transformScale.Value.transform.localScale + this.vectorScale.Value);
			}
			this.hash.Add("time", this.time.IsNone ? 1f : this.time.Value);
			this.DoiTween();
		}

		// Token: 0x0600462D RID: 17965 RVA: 0x00003603 File Offset: 0x00001803
		public override void OnExit()
		{
		}

		// Token: 0x0600462E RID: 17966 RVA: 0x0017E738 File Offset: 0x0017C938
		public override void OnUpdate()
		{
			this.hash.Remove("scale");
			if (this.transformScale.IsNone)
			{
				this.hash.Add("scale", this.vectorScale.IsNone ? Vector3.zero : this.vectorScale.Value);
			}
			else if (this.vectorScale.IsNone)
			{
				this.hash.Add("scale", this.transformScale.Value.transform);
			}
			else
			{
				this.hash.Add("scale", this.transformScale.Value.transform.localScale + this.vectorScale.Value);
			}
			this.DoiTween();
		}

		// Token: 0x0600462F RID: 17967 RVA: 0x0017E807 File Offset: 0x0017CA07
		private void DoiTween()
		{
			iTween.ScaleUpdate(this.go, this.hash);
		}

		// Token: 0x04004B03 RID: 19203
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004B04 RID: 19204
		[Tooltip("Scale To a transform scale.")]
		public FsmGameObject transformScale;

		// Token: 0x04004B05 RID: 19205
		[Tooltip("A scale vector the GameObject will animate To.")]
		public FsmVector3 vectorScale;

		// Token: 0x04004B06 RID: 19206
		[Tooltip("The time in seconds the animation will take to complete. If transformScale is set, this is used as an offset.")]
		public FsmFloat time;

		// Token: 0x04004B07 RID: 19207
		private Hashtable hash;

		// Token: 0x04004B08 RID: 19208
		private GameObject go;
	}
}
