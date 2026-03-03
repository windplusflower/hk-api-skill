using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B6C RID: 2924
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Destroys GameObjects in an array.")]
	public class DestroyObjects : FsmStateAction
	{
		// Token: 0x06003E41 RID: 15937 RVA: 0x00163C67 File Offset: 0x00161E67
		public override void Reset()
		{
			this.gameObjects = null;
			this.delay = 0f;
		}

		// Token: 0x06003E42 RID: 15938 RVA: 0x00163C80 File Offset: 0x00161E80
		public override void OnEnter()
		{
			if (this.gameObjects.Values != null)
			{
				foreach (GameObject gameObject in this.gameObjects.Values)
				{
					if (gameObject != null)
					{
						if (this.delay.Value <= 0f)
						{
							UnityEngine.Object.Destroy(gameObject);
						}
						else
						{
							UnityEngine.Object.Destroy(gameObject, this.delay.Value);
						}
						if (this.detachChildren.Value)
						{
							gameObject.transform.DetachChildren();
						}
					}
				}
			}
			base.Finish();
		}

		// Token: 0x04004259 RID: 16985
		[RequiredField]
		[ArrayEditor(VariableType.GameObject, "", 0, 0, 65536)]
		[Tooltip("The GameObjects to destroy.")]
		public FsmArray gameObjects;

		// Token: 0x0400425A RID: 16986
		[HasFloatSlider(0f, 5f)]
		[Tooltip("Optional delay before destroying the Game Objects.")]
		public FsmFloat delay;

		// Token: 0x0400425B RID: 16987
		[Tooltip("Detach children before destroying the Game Objects.")]
		public FsmBool detachChildren;
	}
}
