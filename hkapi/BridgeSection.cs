using System;
using System.Collections;
using UnityEngine;

// Token: 0x020000D1 RID: 209
public class BridgeSection : MonoBehaviour
{
	// Token: 0x06000444 RID: 1092 RVA: 0x00014D6A File Offset: 0x00012F6A
	private void Awake()
	{
		base.transform.SetPositionZ(0.036f);
	}

	// Token: 0x06000445 RID: 1093 RVA: 0x00014D7C File Offset: 0x00012F7C
	public void Open(BridgeLever lever, bool playAnim = true)
	{
		if (playAnim)
		{
			float num = Vector2.Distance(base.transform.position, lever.transform.position);
			base.StartCoroutine(this.Open(num * 0.1f + 0.25f));
			return;
		}
		this.sectionAnim.Play("Bridge Activated");
		this.fenceAnim.Play("Fence Activated");
		this.fenceRenderer.enabled = true;
		base.transform.SetPositionZ(0.001f);
	}

	// Token: 0x06000446 RID: 1094 RVA: 0x00014E09 File Offset: 0x00013009
	private IEnumerator Open(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		this.StartCoroutine(this.OpenFence());
		this.sectionAnim.Play("Bridge Rise");
		this.source.Play();
		this.transform.SetPositionZ(0.001f);
		yield break;
	}

	// Token: 0x06000447 RID: 1095 RVA: 0x00014E1F File Offset: 0x0001301F
	private IEnumerator OpenFence()
	{
		yield return new WaitForSeconds(2.5f);
		this.fenceRenderer.enabled = true;
		this.fenceAnim.Play("Fence Rise");
		this.fenceSource.Play();
		yield break;
	}

	// Token: 0x040003CD RID: 973
	public tk2dSpriteAnimator sectionAnim;

	// Token: 0x040003CE RID: 974
	public tk2dSpriteAnimator fenceAnim;

	// Token: 0x040003CF RID: 975
	public MeshRenderer fenceRenderer;

	// Token: 0x040003D0 RID: 976
	public AudioSource source;

	// Token: 0x040003D1 RID: 977
	public AudioSource fenceSource;
}
