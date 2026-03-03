using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A62 RID: 2658
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Activates a certain amount of objects held in designated Object Pool and fires them off")]
	public class SpawnFromPoolV2 : RigidBody2dActionBase
	{
		// Token: 0x0600396B RID: 14699 RVA: 0x0014E727 File Offset: 0x0014C927
		public override void Reset()
		{
			this.pool = null;
			this.setPosition = null;
			this.spawnMin = null;
			this.spawnMax = null;
			this.speedMin = null;
			this.speedMax = null;
			this.angleMin = null;
			this.angleMax = null;
		}

		// Token: 0x0600396C RID: 14700 RVA: 0x0014E764 File Offset: 0x0014C964
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
					if (!this.FSM.IsNone)
					{
						FSMUtility.LocateFSM(gameObject, this.FSM.Value).SendEvent(this.FSMEvent.Value);
					}
					if (!this.setPosition.IsNone)
					{
						gameObject.transform.position = this.setPosition.Value;
					}
					gameObject.transform.parent = null;
				}
			}
			base.Finish();
		}

		// Token: 0x04003C1D RID: 15389
		[RequiredField]
		[Tooltip("Pool object to draw from.")]
		public FsmGameObject pool;

		// Token: 0x04003C1E RID: 15390
		public FsmVector3 setPosition;

		// Token: 0x04003C1F RID: 15391
		[Tooltip("Minimum amount of objects to be spawned.")]
		public FsmInt spawnMin;

		// Token: 0x04003C20 RID: 15392
		[Tooltip("Maximum amount of clones to be spawned.")]
		public FsmInt spawnMax;

		// Token: 0x04003C21 RID: 15393
		[Tooltip("Minimum speed clones are fired at.")]
		public FsmFloat speedMin;

		// Token: 0x04003C22 RID: 15394
		[Tooltip("Maximum speed clones are fired at.")]
		public FsmFloat speedMax;

		// Token: 0x04003C23 RID: 15395
		[Tooltip("Minimum angle clones are fired at.")]
		public FsmFloat angleMin;

		// Token: 0x04003C24 RID: 15396
		[Tooltip("Maximum angle clones are fired at.")]
		public FsmFloat angleMax;

		// Token: 0x04003C25 RID: 15397
		[Tooltip("Optional: Name of FSM on object you want to send an event to after spawn")]
		public FsmString FSM;

		// Token: 0x04003C26 RID: 15398
		[Tooltip("Optional: Event you want to send to object after spawn")]
		public FsmString FSMEvent;

		// Token: 0x04003C27 RID: 15399
		private float vectorX;

		// Token: 0x04003C28 RID: 15400
		private float vectorY;

		// Token: 0x04003C29 RID: 15401
		private bool originAdjusted;
	}
}
