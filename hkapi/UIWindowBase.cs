using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000009 RID: 9
public class UIWindowBase : MonoBehaviour, IDragHandler, IEventSystemHandler
{
	// Token: 0x0600002F RID: 47 RVA: 0x0000317D File Offset: 0x0000137D
	private void Start()
	{
		this.m_transform = base.GetComponent<RectTransform>();
	}

	// Token: 0x06000030 RID: 48 RVA: 0x0000318B File Offset: 0x0000138B
	public void OnDrag(PointerEventData eventData)
	{
		this.m_transform.position += new Vector3(eventData.delta.x, eventData.delta.y);
	}

	// Token: 0x06000031 RID: 49 RVA: 0x000031BE File Offset: 0x000013BE
	public void ChangeStrength(float value)
	{
		base.GetComponent<Image>().material.SetFloat("_Size", value);
	}

	// Token: 0x06000032 RID: 50 RVA: 0x000031D6 File Offset: 0x000013D6
	public void ChangeVibrancy(float value)
	{
		base.GetComponent<Image>().material.SetFloat("_Vibrancy", value);
	}

	// Token: 0x04000023 RID: 35
	private RectTransform m_transform;
}
