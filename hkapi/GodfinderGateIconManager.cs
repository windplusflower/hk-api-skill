using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000299 RID: 665
public class GodfinderGateIconManager : MonoBehaviour
{
	// Token: 0x06000DF2 RID: 3570 RVA: 0x00044C9E File Offset: 0x00042E9E
	private void OnValidate()
	{
		this.DoLayout();
	}

	// Token: 0x06000DF3 RID: 3571 RVA: 0x00044CA8 File Offset: 0x00042EA8
	private void OnEnable()
	{
		GodfinderGateIcon[] array = this.gateIcons;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].Evaluate();
		}
		this.DoLayout();
	}

	// Token: 0x06000DF4 RID: 3572 RVA: 0x00044CD8 File Offset: 0x00042ED8
	private void DoLayout()
	{
		Vector3 v = base.transform.position + new Vector3(-this.offsetX / 2f, 0f);
		Vector3 v2 = base.transform.position + new Vector3(this.offsetX / 2f, 0f);
		List<GodfinderGateIcon> list = new List<GodfinderGateIcon>();
		foreach (GodfinderGateIcon godfinderGateIcon in this.gateIcons)
		{
			if (godfinderGateIcon.gameObject.activeSelf)
			{
				list.Add(godfinderGateIcon);
			}
		}
		for (int j = 0; j < list.Count; j++)
		{
			if (list[j])
			{
				list[j].transform.position = Vector2.Lerp(v, v2, (float)j / (float)(list.Count - 1));
			}
		}
	}

	// Token: 0x06000DF5 RID: 3573 RVA: 0x00044DC8 File Offset: 0x00042FC8
	public GodfinderGateIconManager()
	{
		this.offsetX = 8f;
		base..ctor();
	}

	// Token: 0x04000ECF RID: 3791
	public GodfinderGateIcon[] gateIcons;

	// Token: 0x04000ED0 RID: 3792
	public float offsetX;
}
