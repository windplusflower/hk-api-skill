using System;
using System.Collections;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D2A RID: 3370
	[ActionCategory("iTween")]
	[Tooltip("Rotates a GameObject to look at a supplied Transform or Vector3 over time.")]
	public class iTweenLookUpdate : FsmStateAction
	{
		// Token: 0x060045C5 RID: 17861 RVA: 0x0017A6B6 File Offset: 0x001788B6
		public override void Reset()
		{
			this.transformTarget = new FsmGameObject
			{
				UseVariable = true
			};
			this.vectorTarget = new FsmVector3
			{
				UseVariable = true
			};
			this.time = 1f;
			this.axis = iTweenFsmAction.AxisRestriction.none;
		}

		// Token: 0x060045C6 RID: 17862 RVA: 0x0017A6F4 File Offset: 0x001788F4
		public override void OnEnter()
		{
			this.hash = new Hashtable();
			this.go = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (this.go == null)
			{
				base.Finish();
				return;
			}
			if (this.transformTarget.IsNone)
			{
				this.hash.Add("looktarget", this.vectorTarget.IsNone ? Vector3.zero : this.vectorTarget.Value);
			}
			else if (this.vectorTarget.IsNone)
			{
				this.hash.Add("looktarget", this.transformTarget.Value.transform);
			}
			else
			{
				this.hash.Add("looktarget", this.transformTarget.Value.transform.position + this.vectorTarget.Value);
			}
			this.hash.Add("time", this.time.IsNone ? 1f : this.time.Value);
			this.hash.Add("axis", (this.axis == iTweenFsmAction.AxisRestriction.none) ? "" : Enum.GetName(typeof(iTweenFsmAction.AxisRestriction), this.axis));
			this.DoiTween();
		}

		// Token: 0x060045C7 RID: 17863 RVA: 0x00003603 File Offset: 0x00001803
		public override void OnExit()
		{
		}

		// Token: 0x060045C8 RID: 17864 RVA: 0x0017A858 File Offset: 0x00178A58
		public override void OnUpdate()
		{
			this.hash.Remove("looktarget");
			if (this.transformTarget.IsNone)
			{
				this.hash.Add("looktarget", this.vectorTarget.IsNone ? Vector3.zero : this.vectorTarget.Value);
			}
			else if (this.vectorTarget.IsNone)
			{
				this.hash.Add("looktarget", this.transformTarget.Value.transform);
			}
			else
			{
				this.hash.Add("looktarget", this.transformTarget.Value.transform.position + this.vectorTarget.Value);
			}
			this.DoiTween();
		}

		// Token: 0x060045C9 RID: 17865 RVA: 0x0017A927 File Offset: 0x00178B27
		private void DoiTween()
		{
			iTween.LookUpdate(this.go, this.hash);
		}

		// Token: 0x04004A44 RID: 19012
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004A45 RID: 19013
		[Tooltip("Look at a transform position.")]
		public FsmGameObject transformTarget;

		// Token: 0x04004A46 RID: 19014
		[Tooltip("A target position the GameObject will look at. If Transform Target is defined this is used as a look offset.")]
		public FsmVector3 vectorTarget;

		// Token: 0x04004A47 RID: 19015
		[Tooltip("The time in seconds the animation will take to complete.")]
		public FsmFloat time;

		// Token: 0x04004A48 RID: 19016
		[Tooltip("Restricts rotation to the supplied axis only. Just put there strinc like 'x' or 'xz'")]
		public iTweenFsmAction.AxisRestriction axis;

		// Token: 0x04004A49 RID: 19017
		private Hashtable hash;

		// Token: 0x04004A4A RID: 19018
		private GameObject go;
	}
}
