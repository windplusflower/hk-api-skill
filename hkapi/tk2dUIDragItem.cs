using System;
using UnityEngine;

// Token: 0x0200059E RID: 1438
[AddComponentMenu("2D Toolkit/UI/tk2dUIDragItem")]
public class tk2dUIDragItem : tk2dUIBaseItemControl
{
	// Token: 0x06001FF7 RID: 8183 RVA: 0x000A1307 File Offset: 0x0009F507
	private void OnEnable()
	{
		if (this.uiItem)
		{
			this.uiItem.OnDown += this.ButtonDown;
			this.uiItem.OnRelease += this.ButtonRelease;
		}
	}

	// Token: 0x06001FF8 RID: 8184 RVA: 0x000A1344 File Offset: 0x0009F544
	private void OnDisable()
	{
		if (this.uiItem)
		{
			this.uiItem.OnDown -= this.ButtonDown;
			this.uiItem.OnRelease -= this.ButtonRelease;
		}
		if (this.isBtnActive)
		{
			if (tk2dUIManager.Instance__NoCreate != null)
			{
				tk2dUIManager.Instance.OnInputUpdate -= this.UpdateBtnPosition;
			}
			this.isBtnActive = false;
		}
	}

	// Token: 0x06001FF9 RID: 8185 RVA: 0x000A13BE File Offset: 0x0009F5BE
	private void UpdateBtnPosition()
	{
		base.transform.position = this.CalculateNewPos();
	}

	// Token: 0x06001FFA RID: 8186 RVA: 0x000A13D4 File Offset: 0x0009F5D4
	private Vector3 CalculateNewPos()
	{
		Vector2 position = this.uiItem.Touch.position;
		Camera uicameraForControl = tk2dUIManager.Instance.GetUICameraForControl(base.gameObject);
		Vector3 a = uicameraForControl.ScreenToWorldPoint(new Vector3(position.x, position.y, base.transform.position.z - uicameraForControl.transform.position.z));
		a.z = base.transform.position.z;
		return a + this.offset;
	}

	// Token: 0x06001FFB RID: 8187 RVA: 0x000A1464 File Offset: 0x0009F664
	public void ButtonDown()
	{
		if (!this.isBtnActive)
		{
			tk2dUIManager.Instance.OnInputUpdate += this.UpdateBtnPosition;
		}
		this.isBtnActive = true;
		this.offset = Vector3.zero;
		Vector3 b = this.CalculateNewPos();
		this.offset = base.transform.position - b;
	}

	// Token: 0x06001FFC RID: 8188 RVA: 0x000A14BF File Offset: 0x0009F6BF
	public void ButtonRelease()
	{
		if (this.isBtnActive)
		{
			tk2dUIManager.Instance.OnInputUpdate -= this.UpdateBtnPosition;
		}
		this.isBtnActive = false;
	}

	// Token: 0x06001FFD RID: 8189 RVA: 0x000A14E6 File Offset: 0x0009F6E6
	public tk2dUIDragItem()
	{
		this.offset = Vector3.zero;
		base..ctor();
	}

	// Token: 0x040025D4 RID: 9684
	public tk2dUIManager uiManager;

	// Token: 0x040025D5 RID: 9685
	private Vector3 offset;

	// Token: 0x040025D6 RID: 9686
	private bool isBtnActive;
}
