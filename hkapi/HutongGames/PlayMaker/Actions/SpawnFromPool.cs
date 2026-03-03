using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A61 RID: 2657
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Activates a certain amount of objects held in designated Object Pool and fires them off")]
	public class SpawnFromPool : RigidBody2dActionBase
	{
		// Token: 0x06003968 RID: 14696 RVA: 0x0014E586 File Offset: 0x0014C786
		public override void Reset()
		{
			this.pool = null;
			this.adjustPosition = null;
			this.spawnMin = null;
			this.spawnMax = null;
			this.speedMin = null;
			this.speedMax = null;
			this.angleMin = null;
			this.angleMax = null;
		}

		// Token: 0x06003969 RID: 14697 RVA: 0x0014E5C0 File Offset: 0x0014C7C0
		public override void OnEnter()
		{
			GameObject value = this.pool.Value;
			if (value != null)
			{
				int num = UnityEngine.Random.Range(this.spawnMin.Value, this.spawnMax.Value + 1);
				for (int i = 1; i <= num; i++)
				{
					int childCount = value.transform.childCount;
					if (childCount <= 0)
					{
						base.Finish();
					}
					if (childCount == 0)
					{
						return;
					}
					GameObject gameObject = value.transform.GetChild(UnityEngine.Random.Range(0, childCount)).gameObject;
					gameObject.SetActive(true);
					base.CacheRigidBody2d(gameObject);
					float num2 = UnityEngine.Random.Range(this.speedMin.Value, this.speedMax.Value);
					float num3 = UnityEngine.Random.Range(this.angleMin.Value, this.angleMax.Value);
					this.vectorX = num2 * Mathf.Cos(num3 * 0.017453292f);
					this.vectorY = num2 * Mathf.Sin(num3 * 0.017453292f);
					Vector2 velocity;
					velocity.x = this.vectorX;
					velocity.y = this.vectorY;
					this.rb2d.velocity = velocity;
					if (!this.adjustPosition.IsNone)
					{
						gameObject.transform.position += this.adjustPosition.Value;
					}
					gameObject.transform.parent = null;
				}
			}
			base.Finish();
		}

		// Token: 0x04003C12 RID: 15378
		[RequiredField]
		[Tooltip("Pool object to draw from.")]
		public FsmGameObject pool;

		// Token: 0x04003C13 RID: 15379
		public FsmVector3 adjustPosition;

		// Token: 0x04003C14 RID: 15380
		[Tooltip("Minimum amount of objects to be spawned.")]
		public FsmInt spawnMin;

		// Token: 0x04003C15 RID: 15381
		[Tooltip("Maximum amount of clones to be spawned.")]
		public FsmInt spawnMax;

		// Token: 0x04003C16 RID: 15382
		[Tooltip("Minimum speed clones are fired at.")]
		public FsmFloat speedMin;

		// Token: 0x04003C17 RID: 15383
		[Tooltip("Maximum speed clones are fired at.")]
		public FsmFloat speedMax;

		// Token: 0x04003C18 RID: 15384
		[Tooltip("Minimum angle clones are fired at.")]
		public FsmFloat angleMin;

		// Token: 0x04003C19 RID: 15385
		[Tooltip("Maximum angle clones are fired at.")]
		public FsmFloat angleMax;

		// Token: 0x04003C1A RID: 15386
		private float vectorX;

		// Token: 0x04003C1B RID: 15387
		private float vectorY;

		// Token: 0x04003C1C RID: 15388
		private bool originAdjusted;
	}
}
