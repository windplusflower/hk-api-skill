using System;
using UnityEngine;

// Token: 0x020005BF RID: 1471
public class TextMeshSharpener : MonoBehaviour
{
	// Token: 0x06002180 RID: 8576 RVA: 0x000A8A90 File Offset: 0x000A6C90
	private void Start()
	{
		this.textMesh = base.GetComponent<TextMesh>();
		this.resize();
	}

	// Token: 0x06002181 RID: 8577 RVA: 0x000A8AA4 File Offset: 0x000A6CA4
	private void Update()
	{
		if ((float)Camera.main.pixelHeight != this.lastPixelHeight || (Application.isEditor && !Application.isPlaying))
		{
			this.resize();
		}
	}

	// Token: 0x06002182 RID: 8578 RVA: 0x000A8AD0 File Offset: 0x000A6CD0
	private void resize()
	{
		float num = (float)Camera.main.pixelHeight;
		float num2 = Camera.main.orthographicSize * 2f / num;
		float num3 = 128f;
		this.textMesh.characterSize = num2 * Camera.main.orthographicSize / Math.Max(base.transform.localScale.x, base.transform.localScale.y);
		this.textMesh.fontSize = (int)Math.Round((double)(num3 / this.textMesh.characterSize));
		this.lastPixelHeight = num;
	}

	// Token: 0x06002183 RID: 8579 RVA: 0x000A8B65 File Offset: 0x000A6D65
	public TextMeshSharpener()
	{
		this.lastPixelHeight = -1f;
		base..ctor();
	}

	// Token: 0x040026E4 RID: 9956
	private float lastPixelHeight;

	// Token: 0x040026E5 RID: 9957
	private TextMesh textMesh;
}
