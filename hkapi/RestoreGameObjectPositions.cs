using System;
using System.Collections;
using System.Collections.Generic;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x02000028 RID: 40
[ActionCategory("Hollow Knight")]
public class RestoreGameObjectPositions : FsmStateAction
{
	// Token: 0x06000105 RID: 261 RVA: 0x00006347 File Offset: 0x00004547
	public override void Reset()
	{
		base.Reset();
		this.positions = null;
	}

	// Token: 0x06000106 RID: 262 RVA: 0x00006358 File Offset: 0x00004558
	public override void OnEnter()
	{
		base.OnEnter();
		if (this.positions == null)
		{
			this.positions = new Dictionary<GameObject, Vector3>(base.Owner.transform.childCount);
			using (IEnumerator enumerator = base.Owner.transform.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					Transform transform = (Transform)obj;
					this.positions.Add(transform.gameObject, transform.localPosition);
				}
				goto IL_C2;
			}
		}
		foreach (KeyValuePair<GameObject, Vector3> keyValuePair in this.positions)
		{
			keyValuePair.Key.transform.localPosition = keyValuePair.Value;
		}
		IL_C2:
		base.Finish();
	}

	// Token: 0x040000B9 RID: 185
	private Dictionary<GameObject, Vector3> positions;
}
