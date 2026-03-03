using System;
using TMPro;
using UnityEngine;

// Token: 0x0200046D RID: 1133
public class InventoryArrowContainer : MonoBehaviour
{
	// Token: 0x06001961 RID: 6497 RVA: 0x000790CB File Offset: 0x000772CB
	protected void Start()
	{
		this.Setup();
		InputHandler.Instance.RefreshActiveControllerEvent += this.Setup;
	}

	// Token: 0x06001962 RID: 6498 RVA: 0x000790E9 File Offset: 0x000772E9
	private void OnDestroy()
	{
		InputHandler.Instance.RefreshActiveControllerEvent -= this.Setup;
	}

	// Token: 0x06001963 RID: 6499 RVA: 0x00079104 File Offset: 0x00077304
	private void Setup()
	{
		bool isControllerImplicit = Platform.Current.IsControllerImplicit;
		this.arrowVariant.SetActive(!isControllerImplicit);
		this.promptVariant.SetActive(isControllerImplicit);
		if (isControllerImplicit)
		{
			Vector4 margin = this.label.margin;
			margin.x += this.labelLeftInset;
			margin.z += this.labelRightInset;
			this.label.margin = margin;
		}
		base.enabled = false;
	}

	// Token: 0x04001E7F RID: 7807
	[SerializeField]
	private GameObject arrowVariant;

	// Token: 0x04001E80 RID: 7808
	[SerializeField]
	private GameObject promptVariant;

	// Token: 0x04001E81 RID: 7809
	[SerializeField]
	private TextMeshPro label;

	// Token: 0x04001E82 RID: 7810
	[SerializeField]
	private float labelLeftInset;

	// Token: 0x04001E83 RID: 7811
	[SerializeField]
	private float labelRightInset;
}
