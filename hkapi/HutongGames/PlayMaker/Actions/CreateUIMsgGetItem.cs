using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009AC RID: 2476
	[ActionCategory("Hollow Knight")]
	[ActionTarget(typeof(GameObject), "gameObject", true)]
	[Tooltip("Creates a Game Object, usually using a Prefab.")]
	public class CreateUIMsgGetItem : FsmStateAction
	{
		// Token: 0x06003636 RID: 13878 RVA: 0x0013FEC5 File Offset: 0x0013E0C5
		public override void Reset()
		{
			this.gameObject = null;
			this.storeObject = null;
			this.sprite = new FsmObject
			{
				UseVariable = true
			};
		}

		// Token: 0x06003637 RID: 13879 RVA: 0x0013FEE8 File Offset: 0x0013E0E8
		public override void OnEnter()
		{
			GameObject value = this.gameObject.Value;
			if (value != null)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(value, Vector3.zero, Quaternion.identity);
				this.storeObject.Value = gameObject;
				Sprite exists = this.sprite.Value as Sprite;
				if (exists)
				{
					Transform transform = gameObject.transform.Find("Icon");
					if (transform)
					{
						SpriteRenderer component = transform.GetComponent<SpriteRenderer>();
						if (component)
						{
							component.sprite = exists;
						}
					}
				}
			}
			base.Finish();
		}

		// Token: 0x04003816 RID: 14358
		[RequiredField]
		[Tooltip("GameObject to create. Usually a Prefab.")]
		public FsmGameObject gameObject;

		// Token: 0x04003817 RID: 14359
		[UIHint(UIHint.Variable)]
		[Tooltip("Optionally store the created object.")]
		public FsmGameObject storeObject;

		// Token: 0x04003818 RID: 14360
		[ObjectType(typeof(Sprite))]
		public FsmObject sprite;
	}
}
