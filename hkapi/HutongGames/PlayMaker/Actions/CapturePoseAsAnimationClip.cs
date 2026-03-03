using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B43 RID: 2883
	[ActionCategory(ActionCategory.Animation)]
	[Tooltip("Captures the current pose of a hierarchy as an animation clip.\n\nUseful to blend from an arbitrary pose (e.g. a ragdoll death) back to a known animation (e.g. idle).")]
	public class CapturePoseAsAnimationClip : FsmStateAction
	{
		// Token: 0x06003D94 RID: 15764 RVA: 0x00161C30 File Offset: 0x0015FE30
		public override void Reset()
		{
			this.gameObject = null;
			this.position = false;
			this.rotation = true;
			this.scale = false;
			this.storeAnimationClip = null;
		}

		// Token: 0x06003D95 RID: 15765 RVA: 0x00161C64 File Offset: 0x0015FE64
		public override void OnEnter()
		{
			this.DoCaptureAnimationClip();
			base.Finish();
		}

		// Token: 0x06003D96 RID: 15766 RVA: 0x00161C74 File Offset: 0x0015FE74
		private void DoCaptureAnimationClip()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			AnimationClip animationClip = new AnimationClip();
			foreach (object obj in ownerDefaultTarget.transform)
			{
				Transform transform = (Transform)obj;
				this.CaptureTransform(transform, "", animationClip);
			}
			this.storeAnimationClip.Value = animationClip;
		}

		// Token: 0x06003D97 RID: 15767 RVA: 0x00161D04 File Offset: 0x0015FF04
		private void CaptureTransform(Transform transform, string path, AnimationClip clip)
		{
			path += transform.name;
			if (this.position.Value)
			{
				this.CapturePosition(transform, path, clip);
			}
			if (this.rotation.Value)
			{
				this.CaptureRotation(transform, path, clip);
			}
			if (this.scale.Value)
			{
				this.CaptureScale(transform, path, clip);
			}
			foreach (object obj in transform)
			{
				Transform transform2 = (Transform)obj;
				this.CaptureTransform(transform2, path + "/", clip);
			}
		}

		// Token: 0x06003D98 RID: 15768 RVA: 0x00161DB8 File Offset: 0x0015FFB8
		private void CapturePosition(Transform transform, string path, AnimationClip clip)
		{
			this.SetConstantCurve(clip, path, "localPosition.x", transform.localPosition.x);
			this.SetConstantCurve(clip, path, "localPosition.y", transform.localPosition.y);
			this.SetConstantCurve(clip, path, "localPosition.z", transform.localPosition.z);
		}

		// Token: 0x06003D99 RID: 15769 RVA: 0x00161E10 File Offset: 0x00160010
		private void CaptureRotation(Transform transform, string path, AnimationClip clip)
		{
			this.SetConstantCurve(clip, path, "localRotation.x", transform.localRotation.x);
			this.SetConstantCurve(clip, path, "localRotation.y", transform.localRotation.y);
			this.SetConstantCurve(clip, path, "localRotation.z", transform.localRotation.z);
			this.SetConstantCurve(clip, path, "localRotation.w", transform.localRotation.w);
		}

		// Token: 0x06003D9A RID: 15770 RVA: 0x00161E80 File Offset: 0x00160080
		private void CaptureScale(Transform transform, string path, AnimationClip clip)
		{
			this.SetConstantCurve(clip, path, "localScale.x", transform.localScale.x);
			this.SetConstantCurve(clip, path, "localScale.y", transform.localScale.y);
			this.SetConstantCurve(clip, path, "localScale.z", transform.localScale.z);
		}

		// Token: 0x06003D9B RID: 15771 RVA: 0x00161ED8 File Offset: 0x001600D8
		private void SetConstantCurve(AnimationClip clip, string childPath, string propertyPath, float value)
		{
			AnimationCurve animationCurve = AnimationCurve.Linear(0f, value, 100f, value);
			animationCurve.postWrapMode = WrapMode.Loop;
			clip.SetCurve(childPath, typeof(Transform), propertyPath, animationCurve);
		}

		// Token: 0x040041B7 RID: 16823
		[RequiredField]
		[CheckForComponent(typeof(Animation))]
		[Tooltip("The GameObject root of the hierarchy to capture.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040041B8 RID: 16824
		[Tooltip("Capture position keys.")]
		public FsmBool position;

		// Token: 0x040041B9 RID: 16825
		[Tooltip("Capture rotation keys.")]
		public FsmBool rotation;

		// Token: 0x040041BA RID: 16826
		[Tooltip("Capture scale keys.")]
		public FsmBool scale;

		// Token: 0x040041BB RID: 16827
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[ObjectType(typeof(AnimationClip))]
		[Tooltip("Store the result in an Object variable of type AnimationClip.")]
		public FsmObject storeAnimationClip;
	}
}
