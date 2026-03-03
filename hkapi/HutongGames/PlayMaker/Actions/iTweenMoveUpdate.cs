using System;
using System.Collections;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D2F RID: 3375
	[ActionCategory("iTween")]
	[Tooltip("Similar to MoveTo but incredibly less expensive for usage inside the Update function or similar looping situations involving a 'live' set of changing values. Does not utilize an EaseType.")]
	public class iTweenMoveUpdate : FsmStateAction
	{
		// Token: 0x060045E0 RID: 17888 RVA: 0x0017BF64 File Offset: 0x0017A164
		public override void Reset()
		{
			this.transformPosition = new FsmGameObject
			{
				UseVariable = true
			};
			this.vectorPosition = new FsmVector3
			{
				UseVariable = true
			};
			this.time = 1f;
			this.space = Space.World;
			this.orientToPath = new FsmBool
			{
				Value = true
			};
			this.lookAtObject = new FsmGameObject
			{
				UseVariable = true
			};
			this.lookAtVector = new FsmVector3
			{
				UseVariable = true
			};
			this.lookTime = 0f;
			this.axis = iTweenFsmAction.AxisRestriction.none;
		}

		// Token: 0x060045E1 RID: 17889 RVA: 0x0017BFFC File Offset: 0x0017A1FC
		public override void OnEnter()
		{
			this.hash = new Hashtable();
			this.go = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (this.go == null)
			{
				base.Finish();
				return;
			}
			if (this.transformPosition.IsNone)
			{
				this.hash.Add("position", this.vectorPosition.IsNone ? Vector3.zero : this.vectorPosition.Value);
			}
			else if (this.vectorPosition.IsNone)
			{
				this.hash.Add("position", this.transformPosition.Value.transform);
			}
			else if (this.space == Space.World || this.go.transform.parent == null)
			{
				this.hash.Add("position", this.transformPosition.Value.transform.position + this.vectorPosition.Value);
			}
			else
			{
				this.hash.Add("position", this.go.transform.parent.InverseTransformPoint(this.transformPosition.Value.transform.position) + this.vectorPosition.Value);
			}
			this.hash.Add("time", this.time.IsNone ? 1f : this.time.Value);
			this.hash.Add("islocal", this.space == Space.Self);
			this.hash.Add("axis", (this.axis == iTweenFsmAction.AxisRestriction.none) ? "" : Enum.GetName(typeof(iTweenFsmAction.AxisRestriction), this.axis));
			if (!this.orientToPath.IsNone)
			{
				this.hash.Add("orienttopath", this.orientToPath.Value);
			}
			if (this.lookAtObject.IsNone)
			{
				if (!this.lookAtVector.IsNone)
				{
					this.hash.Add("looktarget", this.lookAtVector.Value);
				}
			}
			else
			{
				this.hash.Add("looktarget", this.lookAtObject.Value.transform);
			}
			if (!this.lookAtObject.IsNone || !this.lookAtVector.IsNone)
			{
				this.hash.Add("looktime", this.lookTime.IsNone ? 0f : this.lookTime.Value);
			}
			this.DoiTween();
		}

		// Token: 0x060045E2 RID: 17890 RVA: 0x0017C2CC File Offset: 0x0017A4CC
		public override void OnUpdate()
		{
			this.hash.Remove("position");
			if (this.transformPosition.IsNone)
			{
				this.hash.Add("position", this.vectorPosition.IsNone ? Vector3.zero : this.vectorPosition.Value);
			}
			else if (this.vectorPosition.IsNone)
			{
				this.hash.Add("position", this.transformPosition.Value.transform);
			}
			else if (this.space == Space.World)
			{
				this.hash.Add("position", this.transformPosition.Value.transform.position + this.vectorPosition.Value);
			}
			else
			{
				this.hash.Add("position", this.transformPosition.Value.transform.localPosition + this.vectorPosition.Value);
			}
			this.DoiTween();
		}

		// Token: 0x060045E3 RID: 17891 RVA: 0x00003603 File Offset: 0x00001803
		public override void OnExit()
		{
		}

		// Token: 0x060045E4 RID: 17892 RVA: 0x0017C3E5 File Offset: 0x0017A5E5
		private void DoiTween()
		{
			iTween.MoveUpdate(this.go, this.hash);
		}

		// Token: 0x04004A8B RID: 19083
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004A8C RID: 19084
		[Tooltip("Move From a transform rotation.")]
		public FsmGameObject transformPosition;

		// Token: 0x04004A8D RID: 19085
		[Tooltip("The position the GameObject will animate from.  If transformPosition is set, this is used as an offset.")]
		public FsmVector3 vectorPosition;

		// Token: 0x04004A8E RID: 19086
		[Tooltip("The time in seconds the animation will take to complete.")]
		public FsmFloat time;

		// Token: 0x04004A8F RID: 19087
		[Tooltip("Whether to animate in local or world space.")]
		public Space space;

		// Token: 0x04004A90 RID: 19088
		[ActionSection("LookAt")]
		[Tooltip("Whether or not the GameObject will orient to its direction of travel. False by default.")]
		public FsmBool orientToPath;

		// Token: 0x04004A91 RID: 19089
		[Tooltip("A target object the GameObject will look at.")]
		public FsmGameObject lookAtObject;

		// Token: 0x04004A92 RID: 19090
		[Tooltip("A target position the GameObject will look at.")]
		public FsmVector3 lookAtVector;

		// Token: 0x04004A93 RID: 19091
		[Tooltip("The time in seconds the object will take to look at either the Look At Target or Orient To Path. 0 by default")]
		public FsmFloat lookTime;

		// Token: 0x04004A94 RID: 19092
		[Tooltip("Restricts rotation to the supplied axis only.")]
		public iTweenFsmAction.AxisRestriction axis;

		// Token: 0x04004A95 RID: 19093
		private Hashtable hash;

		// Token: 0x04004A96 RID: 19094
		private GameObject go;
	}
}
