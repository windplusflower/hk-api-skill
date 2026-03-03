using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009AB RID: 2475
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Spawns a random amount of chosen GameObject and fires them off in random directions.")]
	public class CreatePoolObjects : RigidBody2dActionBase
	{
		// Token: 0x06003633 RID: 13875 RVA: 0x0013FCF4 File Offset: 0x0013DEF4
		public override void Reset()
		{
			this.gameObject = null;
			this.position = new FsmVector3
			{
				UseVariable = true
			};
			this.amount = null;
			this.originVariationX = null;
			this.originVariationY = null;
			this.deactivate = false;
		}

		// Token: 0x06003634 RID: 13876 RVA: 0x0013FD2C File Offset: 0x0013DF2C
		public override void OnEnter()
		{
			GameObject value = this.gameObject.Value;
			if (value != null)
			{
				Vector3 b = this.pool.Value.transform.position;
				Vector3 zero = Vector3.zero;
				if (!this.position.IsNone)
				{
					b = this.position.Value + b;
				}
				int value2 = this.amount.Value;
				for (int i = 1; i <= value2; i++)
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(value, b, Quaternion.Euler(zero));
					float x = gameObject.transform.position.x;
					float y = gameObject.transform.position.y;
					float z = gameObject.transform.position.z;
					if (this.originVariationX != null)
					{
						x = gameObject.transform.position.x + UnityEngine.Random.Range(-this.originVariationX.Value, this.originVariationX.Value);
						this.originAdjusted = true;
					}
					if (this.originVariationY != null)
					{
						y = gameObject.transform.position.y + UnityEngine.Random.Range(-this.originVariationY.Value, this.originVariationY.Value);
						this.originAdjusted = true;
					}
					if (this.originAdjusted)
					{
						gameObject.transform.position = new Vector3(x, y, z);
					}
					gameObject.transform.parent = this.pool.Value.transform;
					if (this.deactivate)
					{
						gameObject.SetActive(false);
					}
				}
			}
			base.Finish();
		}

		// Token: 0x0400380C RID: 14348
		[RequiredField]
		[Tooltip("GameObject to create.")]
		public FsmGameObject gameObject;

		// Token: 0x0400380D RID: 14349
		[RequiredField]
		[Tooltip("GameObject which will be used as pool (spawned objects will be parented to this).")]
		public FsmGameObject pool;

		// Token: 0x0400380E RID: 14350
		[Tooltip("Position. If a Spawn Point is defined, this is used as a local offset from the Spawn Point position.")]
		public FsmVector3 position;

		// Token: 0x0400380F RID: 14351
		[Tooltip("Amount of clones to be spawned.")]
		public FsmInt amount;

		// Token: 0x04003810 RID: 14352
		[Tooltip("Randomises spawn points of objects within this range. Leave as 0 and all objects will spawn at same point.")]
		public FsmFloat originVariationX;

		// Token: 0x04003811 RID: 14353
		public FsmFloat originVariationY;

		// Token: 0x04003812 RID: 14354
		[Tooltip("Deactivate the pool objects after creating. Use if the objects don't deactivate themselves.")]
		public bool deactivate;

		// Token: 0x04003813 RID: 14355
		private float vectorX;

		// Token: 0x04003814 RID: 14356
		private float vectorY;

		// Token: 0x04003815 RID: 14357
		private bool originAdjusted;
	}
}
