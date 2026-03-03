using System;
using System.Collections.Generic;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x020002BE RID: 702
public class WeaverlingEnemyList : MonoBehaviour
{
	// Token: 0x06000EE3 RID: 3811 RVA: 0x00049916 File Offset: 0x00047B16
	private void OnEnable()
	{
		this.enemyList.Clear();
	}

	// Token: 0x06000EE4 RID: 3812 RVA: 0x00049923 File Offset: 0x00047B23
	private void OnTriggerEnter2D(Collider2D otherCollider)
	{
		this.enemyList.Add(otherCollider.gameObject);
	}

	// Token: 0x06000EE5 RID: 3813 RVA: 0x00049936 File Offset: 0x00047B36
	private void OnTriggerExit2D(Collider2D otherCollider)
	{
		this.enemyList.Remove(otherCollider.gameObject);
	}

	// Token: 0x06000EE6 RID: 3814 RVA: 0x0004994A File Offset: 0x00047B4A
	public GameObject GetTarget()
	{
		if (this.enemyList.Count > 0)
		{
			return this.enemyList[UnityEngine.Random.Range(0, this.enemyList.Count)];
		}
		return null;
	}

	// Token: 0x04000FA6 RID: 4006
	public List<GameObject> enemyList;

	// Token: 0x020002BF RID: 703
	[ActionCategory("Hollow Knight")]
	public class GetEnemyTarget : FsmStateAction
	{
		// Token: 0x06000EE8 RID: 3816 RVA: 0x00049978 File Offset: 0x00047B78
		public override void Reset()
		{
			this.listHolder = new FsmOwnerDefault();
			this.storeTarget = new FsmGameObject();
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x00049990 File Offset: 0x00047B90
		public override void OnEnter()
		{
			GameObject gameObject = (this.listHolder.OwnerOption == OwnerDefaultOption.UseOwner) ? base.Owner : this.listHolder.GameObject.Value;
			if (gameObject != null)
			{
				WeaverlingEnemyList component = gameObject.GetComponent<WeaverlingEnemyList>();
				if (component != null)
				{
					this.storeTarget.Value = component.GetTarget();
				}
			}
			base.Finish();
		}

		// Token: 0x04000FA7 RID: 4007
		[UIHint(UIHint.Variable)]
		public FsmOwnerDefault listHolder;

		// Token: 0x04000FA8 RID: 4008
		public FsmGameObject storeTarget;
	}
}
