using System;
using TMPro;
using UnityEngine;

// Token: 0x0200045E RID: 1118
public class GetTMProLeftVertex : MonoBehaviour
{
	// Token: 0x0600192F RID: 6447 RVA: 0x00078772 File Offset: 0x00076972
	private void Start()
	{
		this.textMesh = base.GetComponent<TextMeshPro>();
		this.vertices = this.textMesh.mesh.vertices;
	}

	// Token: 0x06001930 RID: 6448 RVA: 0x00078798 File Offset: 0x00076998
	public float GetLeftmostVertex()
	{
		return this.textMesh.mesh.bounds.extents.x;
	}

	// Token: 0x04001E3C RID: 7740
	public Vector3[] vertices;

	// Token: 0x04001E3D RID: 7741
	public float[] vectorX;

	// Token: 0x04001E3E RID: 7742
	private TextMeshPro textMesh;
}
