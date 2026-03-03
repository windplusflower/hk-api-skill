using System;
using System.Reflection;
using UnityEngine;

// Token: 0x02000232 RID: 562
public class BossSequenceBindingsDisplay : MonoBehaviour
{
	// Token: 0x06000BF8 RID: 3064 RVA: 0x0003DDC8 File Offset: 0x0003BFC8
	private void Start()
	{
		int num = BossSequenceBindingsDisplay.CountCompletedBindings();
		for (int i = 0; i < this.bindingIcons.Length; i++)
		{
			this.bindingIcons[i].SetActive(i < num);
		}
	}

	// Token: 0x06000BF9 RID: 3065 RVA: 0x0003DE00 File Offset: 0x0003C000
	public static void CountBindings(out int total, out int completed)
	{
		total = 0;
		completed = 0;
		foreach (FieldInfo fieldInfo in typeof(PlayerData).GetFields())
		{
			if (fieldInfo.FieldType == typeof(BossSequenceDoor.Completion))
			{
				BossSequenceDoor.Completion completion = (BossSequenceDoor.Completion)fieldInfo.GetValue(GameManager.instance.playerData);
				if (completion.completed)
				{
					if (completion.boundNail)
					{
						completed++;
					}
					if (completion.boundShell)
					{
						completed++;
					}
					if (completion.boundCharms)
					{
						completed++;
					}
					if (completion.boundSoul)
					{
						completed++;
					}
				}
				total += 4;
			}
		}
	}

	// Token: 0x06000BFA RID: 3066 RVA: 0x0003DEB0 File Offset: 0x0003C0B0
	public static int CountCompletedBindings()
	{
		int num = 0;
		int result = 0;
		BossSequenceBindingsDisplay.CountBindings(out num, out result);
		return result;
	}

	// Token: 0x06000BFB RID: 3067 RVA: 0x0003DECC File Offset: 0x0003C0CC
	public static int CountTotalBindings()
	{
		int result = 0;
		int num = 0;
		BossSequenceBindingsDisplay.CountBindings(out result, out num);
		return result;
	}

	// Token: 0x04000CE1 RID: 3297
	public GameObject[] bindingIcons;
}
