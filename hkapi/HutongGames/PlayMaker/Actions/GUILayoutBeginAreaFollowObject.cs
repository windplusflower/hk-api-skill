using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BA3 RID: 2979
	[ActionCategory(ActionCategory.GUILayout)]
	[Tooltip("Begin a GUILayout area that follows the specified game object. Useful for overlays (e.g., playerName). NOTE: Block must end with a corresponding GUILayoutEndArea.")]
	public class GUILayoutBeginAreaFollowObject : FsmStateAction
	{
		// Token: 0x06003F1D RID: 16157 RVA: 0x00166340 File Offset: 0x00164540
		public override void Reset()
		{
			this.gameObject = null;
			this.offsetLeft = 0f;
			this.offsetTop = 0f;
			this.width = 1f;
			this.height = 1f;
			this.normalized = true;
			this.style = "";
		}

		// Token: 0x06003F1E RID: 16158 RVA: 0x001663B0 File Offset: 0x001645B0
		public override void OnGUI()
		{
			GameObject value = this.gameObject.Value;
			if (value == null || Camera.main == null)
			{
				GUILayoutBeginAreaFollowObject.DummyBeginArea();
				return;
			}
			Vector3 position = value.transform.position;
			if (Camera.main.transform.InverseTransformPoint(position).z < 0f)
			{
				GUILayoutBeginAreaFollowObject.DummyBeginArea();
				return;
			}
			Vector2 vector = Camera.main.WorldToScreenPoint(position);
			float x = vector.x + (this.normalized.Value ? (this.offsetLeft.Value * (float)Screen.width) : this.offsetLeft.Value);
			float y = vector.y + (this.normalized.Value ? (this.offsetTop.Value * (float)Screen.width) : this.offsetTop.Value);
			Rect screenRect = new Rect(x, y, this.width.Value, this.height.Value);
			if (this.normalized.Value)
			{
				screenRect.width *= (float)Screen.width;
				screenRect.height *= (float)Screen.height;
			}
			screenRect.y = (float)Screen.height - screenRect.y;
			GUILayout.BeginArea(screenRect, this.style.Value);
		}

		// Token: 0x06003F1F RID: 16159 RVA: 0x00166508 File Offset: 0x00164708
		private static void DummyBeginArea()
		{
			GUILayout.BeginArea(default(Rect));
		}

		// Token: 0x0400433C RID: 17212
		[RequiredField]
		[Tooltip("The GameObject to follow.")]
		public FsmGameObject gameObject;

		// Token: 0x0400433D RID: 17213
		[RequiredField]
		public FsmFloat offsetLeft;

		// Token: 0x0400433E RID: 17214
		[RequiredField]
		public FsmFloat offsetTop;

		// Token: 0x0400433F RID: 17215
		[RequiredField]
		public FsmFloat width;

		// Token: 0x04004340 RID: 17216
		[RequiredField]
		public FsmFloat height;

		// Token: 0x04004341 RID: 17217
		[Tooltip("Use normalized screen coordinates (0-1).")]
		public FsmBool normalized;

		// Token: 0x04004342 RID: 17218
		[Tooltip("Optional named style in the current GUISkin")]
		public FsmString style;
	}
}
