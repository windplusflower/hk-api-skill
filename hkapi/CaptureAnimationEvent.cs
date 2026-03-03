using System;
using UnityEngine;

// Token: 0x020001F3 RID: 499
public class CaptureAnimationEvent : MonoBehaviour
{
	// Token: 0x06000AC6 RID: 2758 RVA: 0x00039C12 File Offset: 0x00037E12
	private void Start()
	{
		this.playerData = PlayerData.instance;
	}

	// Token: 0x06000AC7 RID: 2759 RVA: 0x00039C1F File Offset: 0x00037E1F
	public void SetPlayerDataBoolTrue(string boolName)
	{
		this.playerData.SetBool(boolName, true);
	}

	// Token: 0x06000AC8 RID: 2760 RVA: 0x00039C2E File Offset: 0x00037E2E
	public void SetPlayerDataBoolFalse(string boolName)
	{
		this.playerData.SetBool(boolName, false);
	}

	// Token: 0x06000AC9 RID: 2761 RVA: 0x00039C3D File Offset: 0x00037E3D
	public void IncrementPlayerDataInt(string intName)
	{
		this.playerData.IncrementInt(intName);
	}

	// Token: 0x06000ACA RID: 2762 RVA: 0x00039C4B File Offset: 0x00037E4B
	public void DecrementPlayerDataInt(string intName)
	{
		this.playerData.DecrementInt(intName);
	}

	// Token: 0x06000ACB RID: 2763 RVA: 0x00039C59 File Offset: 0x00037E59
	public bool GetPlayerDataBool(string boolName)
	{
		return this.playerData.GetBool(boolName);
	}

	// Token: 0x06000ACC RID: 2764 RVA: 0x00039C67 File Offset: 0x00037E67
	public int GetPlayerDataInt(string intName)
	{
		return this.playerData.GetInt(intName);
	}

	// Token: 0x06000ACD RID: 2765 RVA: 0x00039C75 File Offset: 0x00037E75
	public float GetPlayerDataFloat(string floatName)
	{
		return this.playerData.GetFloat(floatName);
	}

	// Token: 0x06000ACE RID: 2766 RVA: 0x00039C83 File Offset: 0x00037E83
	public string GetPlayerDataString(string stringName)
	{
		return this.playerData.GetString(stringName);
	}

	// Token: 0x06000ACF RID: 2767 RVA: 0x00039C91 File Offset: 0x00037E91
	public void EquipCharm(int charmNum)
	{
		this.playerData.EquipCharm(charmNum);
	}

	// Token: 0x06000AD0 RID: 2768 RVA: 0x00039C9F File Offset: 0x00037E9F
	public void UnequipCharm(int charmNum)
	{
		this.playerData.UnequipCharm(charmNum);
	}

	// Token: 0x06000AD1 RID: 2769 RVA: 0x00039CAD File Offset: 0x00037EAD
	public void UpdateBlueHealth()
	{
		this.playerData.UpdateBlueHealth();
	}

	// Token: 0x04000BE3 RID: 3043
	private PlayerData playerData;
}
