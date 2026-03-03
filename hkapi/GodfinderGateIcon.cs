using System;
using UnityEngine;

// Token: 0x02000297 RID: 663
public class GodfinderGateIcon : MonoBehaviour
{
	// Token: 0x06000DED RID: 3565 RVA: 0x00044B4B File Offset: 0x00042D4B
	private void Reset()
	{
		this.OnValidate();
	}

	// Token: 0x06000DEE RID: 3566 RVA: 0x00044B54 File Offset: 0x00042D54
	private void OnValidate()
	{
		int num = Enum.GetNames(typeof(GodfinderGateIcon.IconType)).Length;
		if (this.icons.Length != num)
		{
			GameObject[] array = this.icons;
			this.icons = new GameObject[num];
			for (int i = 0; i < array.Length; i++)
			{
				this.icons[i] = array[i];
			}
		}
	}

	// Token: 0x06000DEF RID: 3567 RVA: 0x00044BAC File Offset: 0x00042DAC
	private void SetIcon(GodfinderGateIcon.IconType type)
	{
		for (int i = 0; i < this.icons.Length; i++)
		{
			if (this.icons[i])
			{
				this.icons[i].SetActive(i == (int)type);
			}
		}
	}

	// Token: 0x06000DF0 RID: 3568 RVA: 0x00044BEC File Offset: 0x00042DEC
	public void Evaluate()
	{
		if (!string.IsNullOrEmpty(this.requiredPDBool) && !GameManager.instance.GetPlayerDataBool(this.requiredPDBool))
		{
			base.gameObject.SetActive(false);
			return;
		}
		BossSequenceDoor.Completion playerDataVariable = GameManager.instance.GetPlayerDataVariable<BossSequenceDoor.Completion>(this.completionPD);
		if (playerDataVariable.allBindings)
		{
			this.SetIcon(GodfinderGateIcon.IconType.CompleteRadiant);
		}
		else if (playerDataVariable.completed)
		{
			this.SetIcon(GodfinderGateIcon.IconType.Complete);
		}
		else if (playerDataVariable.unlocked || playerDataVariable.canUnlock || (this.unlockedSequence && this.unlockedSequence.IsUnlocked()))
		{
			this.SetIcon(GodfinderGateIcon.IconType.Unbound);
		}
		else
		{
			this.SetIcon(GodfinderGateIcon.IconType.Bound);
		}
		base.gameObject.SetActive(true);
	}

	// Token: 0x04000EC6 RID: 3782
	[ArrayForEnum(typeof(GodfinderGateIcon.IconType))]
	public GameObject[] icons;

	// Token: 0x04000EC7 RID: 3783
	public string completionPD;

	// Token: 0x04000EC8 RID: 3784
	[Tooltip("If assigned, icon will show unlocked when tier CAN be unlocked, rather than when the lock has been broken.")]
	public BossSequence unlockedSequence;

	// Token: 0x04000EC9 RID: 3785
	public string requiredPDBool;

	// Token: 0x02000298 RID: 664
	public enum IconType
	{
		// Token: 0x04000ECB RID: 3787
		Bound,
		// Token: 0x04000ECC RID: 3788
		Unbound,
		// Token: 0x04000ECD RID: 3789
		Complete,
		// Token: 0x04000ECE RID: 3790
		CompleteRadiant
	}
}
