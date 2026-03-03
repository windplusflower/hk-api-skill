using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B6B RID: 2923
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Destroys a Game Object.")]
	public class DestroyObject : FsmStateAction
	{
		// Token: 0x06003E3D RID: 15933 RVA: 0x00163BE2 File Offset: 0x00161DE2
		public override void Reset()
		{
			this.gameObject = null;
			this.delay = 0f;
		}

		// Token: 0x06003E3E RID: 15934 RVA: 0x00163BFC File Offset: 0x00161DFC
		public override void OnEnter()
		{
			GameObject value = this.gameObject.Value;
			if (value != null)
			{
				if (this.delay.Value <= 0f)
				{
					UnityEngine.Object.Destroy(value);
				}
				else
				{
					UnityEngine.Object.Destroy(value, this.delay.Value);
				}
				if (this.detachChildren.Value)
				{
					value.transform.DetachChildren();
				}
			}
			base.Finish();
		}

		// Token: 0x06003E3F RID: 15935 RVA: 0x00003603 File Offset: 0x00001803
		public override void OnUpdate()
		{
		}

		// Token: 0x04004256 RID: 16982
		[RequiredField]
		[Tooltip("The GameObject to destroy.")]
		public FsmGameObject gameObject;

		// Token: 0x04004257 RID: 16983
		[HasFloatSlider(0f, 5f)]
		[Tooltip("Optional delay before destroying the Game Object.")]
		public FsmFloat delay;

		// Token: 0x04004258 RID: 16984
		[Tooltip("Detach children before destroying the Game Object.")]
		public FsmBool detachChildren;
	}
}
