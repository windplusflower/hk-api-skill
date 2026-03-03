using System;
using UnityEngine;

// Token: 0x02000477 RID: 1143
public class MapMarkerButton : MonoBehaviour
{
	// Token: 0x060019A5 RID: 6565 RVA: 0x0007A32A File Offset: 0x0007852A
	private void Awake()
	{
		this.spriteRenderer = base.GetComponent<SpriteRenderer>();
	}

	// Token: 0x060019A6 RID: 6566 RVA: 0x0007A338 File Offset: 0x00078538
	private void OnEnable()
	{
		PlayerData playerData = GameManager.instance.playerData;
		if (playerData != null)
		{
			if ((playerData.GetBool("hasMarker_b") ? 1 : 0) + (playerData.GetBool("hasMarker_r") ? 1 : 0) + (playerData.GetBool("hasMarker_w") ? 1 : 0) + (playerData.GetBool("hasMarker_y") ? 1 : 0) < this.neededMarkerTypes)
			{
				this.DoDisable();
				this.shouldDisable = true;
				return;
			}
			this.shouldDisable = false;
		}
	}

	// Token: 0x060019A7 RID: 6567 RVA: 0x0007A3B7 File Offset: 0x000785B7
	private void Update()
	{
		if (this.keepDisabled && this.shouldDisable)
		{
			this.DoDisable();
		}
	}

	// Token: 0x060019A8 RID: 6568 RVA: 0x0007A3D0 File Offset: 0x000785D0
	private void DoDisable()
	{
		MapMarkerButton.DisableType disableType = this.disable;
		if (disableType != MapMarkerButton.DisableType.GameObject)
		{
			if (disableType != MapMarkerButton.DisableType.SpriteRenderer)
			{
				return;
			}
			if (this.spriteRenderer && this.spriteRenderer.enabled)
			{
				this.spriteRenderer.enabled = false;
			}
		}
		else if (base.gameObject.activeSelf)
		{
			base.gameObject.SetActive(false);
			return;
		}
	}

	// Token: 0x060019A9 RID: 6569 RVA: 0x0007A42C File Offset: 0x0007862C
	public MapMarkerButton()
	{
		this.neededMarkerTypes = 2;
		base..ctor();
	}

	// Token: 0x04001ED5 RID: 7893
	public int neededMarkerTypes;

	// Token: 0x04001ED6 RID: 7894
	public MapMarkerButton.DisableType disable;

	// Token: 0x04001ED7 RID: 7895
	public bool keepDisabled;

	// Token: 0x04001ED8 RID: 7896
	private bool shouldDisable;

	// Token: 0x04001ED9 RID: 7897
	private SpriteRenderer spriteRenderer;

	// Token: 0x02000478 RID: 1144
	public enum DisableType
	{
		// Token: 0x04001EDB RID: 7899
		GameObject,
		// Token: 0x04001EDC RID: 7900
		SpriteRenderer
	}
}
