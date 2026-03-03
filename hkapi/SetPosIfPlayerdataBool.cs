using System;
using UnityEngine;

// Token: 0x020004BB RID: 1211
public class SetPosIfPlayerdataBool : MonoBehaviour
{
	// Token: 0x06001AC4 RID: 6852 RVA: 0x0007FCA0 File Offset: 0x0007DEA0
	private void OnEnable()
	{
		SetPosIfPlayerdataBool[] components = base.GetComponents<SetPosIfPlayerdataBool>();
		for (int i = 0; i < components.Length; i++)
		{
			components[i].DoCheck();
		}
	}

	// Token: 0x06001AC5 RID: 6853 RVA: 0x0007FCCA File Offset: 0x0007DECA
	private void OnDisable()
	{
		this.hasChecked = false;
	}

	// Token: 0x06001AC6 RID: 6854 RVA: 0x0007FCD4 File Offset: 0x0007DED4
	private void DoCheck()
	{
		if (this.hasChecked)
		{
			return;
		}
		this.hasChecked = true;
		if ((!this.hasSet || !this.onceOnly) && PlayerData.instance.GetBool(this.playerDataBool))
		{
			if (this.setX)
			{
				base.transform.localPosition = new Vector3(this.XPos, base.transform.localPosition.y, base.transform.localPosition.z);
			}
			if (this.setY)
			{
				base.transform.localPosition = new Vector3(base.transform.localPosition.x, this.YPos, base.transform.localPosition.z);
			}
			this.hasSet = true;
		}
	}

	// Token: 0x04002014 RID: 8212
	public string playerDataBool;

	// Token: 0x04002015 RID: 8213
	public bool setX;

	// Token: 0x04002016 RID: 8214
	public float XPos;

	// Token: 0x04002017 RID: 8215
	public bool setY;

	// Token: 0x04002018 RID: 8216
	public float YPos;

	// Token: 0x04002019 RID: 8217
	public bool onceOnly;

	// Token: 0x0400201A RID: 8218
	private bool hasSet;

	// Token: 0x0400201B RID: 8219
	private bool hasChecked;
}
