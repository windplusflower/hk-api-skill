using System;
using UnityEngine;

// Token: 0x02000583 RID: 1411
[Serializable]
public class tk2dSpriteDefinition
{
	// Token: 0x17000401 RID: 1025
	// (get) Token: 0x06001F32 RID: 7986 RVA: 0x0009B5A4 File Offset: 0x000997A4
	public bool Valid
	{
		get
		{
			return this.name.Length != 0;
		}
	}

	// Token: 0x06001F33 RID: 7987 RVA: 0x0009B5B4 File Offset: 0x000997B4
	public Bounds GetBounds()
	{
		return new Bounds(new Vector3(this.boundsData[0].x, this.boundsData[0].y, this.boundsData[0].z), new Vector3(this.boundsData[1].x, this.boundsData[1].y, this.boundsData[1].z));
	}

	// Token: 0x06001F34 RID: 7988 RVA: 0x0009B638 File Offset: 0x00099838
	public Bounds GetUntrimmedBounds()
	{
		return new Bounds(new Vector3(this.untrimmedBoundsData[0].x, this.untrimmedBoundsData[0].y, this.untrimmedBoundsData[0].z), new Vector3(this.untrimmedBoundsData[1].x, this.untrimmedBoundsData[1].y, this.untrimmedBoundsData[1].z));
	}

	// Token: 0x06001F35 RID: 7989 RVA: 0x0009B6BC File Offset: 0x000998BC
	public tk2dSpriteDefinition()
	{
		this.normalizedUvs = new Vector2[0];
		this.indices = new int[]
		{
			0,
			3,
			1,
			2,
			3,
			0
		};
		this.customColliders = new tk2dSpriteColliderDefinition[0];
		this.polygonCollider2D = new tk2dCollider2DData[0];
		this.edgeCollider2D = new tk2dCollider2DData[0];
		this.attachPoints = new tk2dSpriteDefinition.AttachPoint[0];
		base..ctor();
	}

	// Token: 0x04002501 RID: 9473
	public string name;

	// Token: 0x04002502 RID: 9474
	public Vector3[] boundsData;

	// Token: 0x04002503 RID: 9475
	public Vector3[] untrimmedBoundsData;

	// Token: 0x04002504 RID: 9476
	public Vector2 texelSize;

	// Token: 0x04002505 RID: 9477
	public Vector3[] positions;

	// Token: 0x04002506 RID: 9478
	public Vector3[] normals;

	// Token: 0x04002507 RID: 9479
	public Vector4[] tangents;

	// Token: 0x04002508 RID: 9480
	public Vector2[] uvs;

	// Token: 0x04002509 RID: 9481
	public Vector2[] normalizedUvs;

	// Token: 0x0400250A RID: 9482
	public int[] indices;

	// Token: 0x0400250B RID: 9483
	public Material material;

	// Token: 0x0400250C RID: 9484
	[NonSerialized]
	public Material materialInst;

	// Token: 0x0400250D RID: 9485
	public int materialId;

	// Token: 0x0400250E RID: 9486
	public string sourceTextureGUID;

	// Token: 0x0400250F RID: 9487
	public bool extractRegion;

	// Token: 0x04002510 RID: 9488
	public int regionX;

	// Token: 0x04002511 RID: 9489
	public int regionY;

	// Token: 0x04002512 RID: 9490
	public int regionW;

	// Token: 0x04002513 RID: 9491
	public int regionH;

	// Token: 0x04002514 RID: 9492
	public tk2dSpriteDefinition.FlipMode flipped;

	// Token: 0x04002515 RID: 9493
	public bool complexGeometry;

	// Token: 0x04002516 RID: 9494
	public tk2dSpriteDefinition.PhysicsEngine physicsEngine;

	// Token: 0x04002517 RID: 9495
	public tk2dSpriteDefinition.ColliderType colliderType;

	// Token: 0x04002518 RID: 9496
	public tk2dSpriteColliderDefinition[] customColliders;

	// Token: 0x04002519 RID: 9497
	public Vector3[] colliderVertices;

	// Token: 0x0400251A RID: 9498
	public int[] colliderIndicesFwd;

	// Token: 0x0400251B RID: 9499
	public int[] colliderIndicesBack;

	// Token: 0x0400251C RID: 9500
	public bool colliderConvex;

	// Token: 0x0400251D RID: 9501
	public bool colliderSmoothSphereCollisions;

	// Token: 0x0400251E RID: 9502
	public tk2dCollider2DData[] polygonCollider2D;

	// Token: 0x0400251F RID: 9503
	public tk2dCollider2DData[] edgeCollider2D;

	// Token: 0x04002520 RID: 9504
	public tk2dSpriteDefinition.AttachPoint[] attachPoints;

	// Token: 0x02000584 RID: 1412
	public enum ColliderType
	{
		// Token: 0x04002522 RID: 9506
		Unset,
		// Token: 0x04002523 RID: 9507
		None,
		// Token: 0x04002524 RID: 9508
		Box,
		// Token: 0x04002525 RID: 9509
		Mesh,
		// Token: 0x04002526 RID: 9510
		Custom
	}

	// Token: 0x02000585 RID: 1413
	public enum PhysicsEngine
	{
		// Token: 0x04002528 RID: 9512
		Physics3D,
		// Token: 0x04002529 RID: 9513
		Physics2D
	}

	// Token: 0x02000586 RID: 1414
	public enum FlipMode
	{
		// Token: 0x0400252B RID: 9515
		None,
		// Token: 0x0400252C RID: 9516
		Tk2d,
		// Token: 0x0400252D RID: 9517
		TPackerCW
	}

	// Token: 0x02000587 RID: 1415
	[Serializable]
	public class AttachPoint
	{
		// Token: 0x06001F36 RID: 7990 RVA: 0x0009B722 File Offset: 0x00099922
		public void CopyFrom(tk2dSpriteDefinition.AttachPoint src)
		{
			this.name = src.name;
			this.position = src.position;
			this.angle = src.angle;
		}

		// Token: 0x06001F37 RID: 7991 RVA: 0x0009B748 File Offset: 0x00099948
		public bool CompareTo(tk2dSpriteDefinition.AttachPoint src)
		{
			return this.name == src.name && src.position == this.position && src.angle == this.angle;
		}

		// Token: 0x06001F38 RID: 7992 RVA: 0x0009B780 File Offset: 0x00099980
		public AttachPoint()
		{
			this.name = "";
			this.position = Vector3.zero;
			base..ctor();
		}

		// Token: 0x0400252E RID: 9518
		public string name;

		// Token: 0x0400252F RID: 9519
		public Vector3 position;

		// Token: 0x04002530 RID: 9520
		public float angle;
	}
}
