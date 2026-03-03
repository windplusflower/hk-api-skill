using System;
using UnityEngine;

// Token: 0x02000565 RID: 1381
[AddComponentMenu("2D Toolkit/Backend/tk2dSpriteAnimation")]
public class tk2dSpriteAnimation : MonoBehaviour
{
	// Token: 0x06001ECB RID: 7883 RVA: 0x00099544 File Offset: 0x00097744
	public tk2dSpriteAnimationClip GetClipByName(string name)
	{
		for (int i = 0; i < this.clips.Length; i++)
		{
			if (this.clips[i].name == name)
			{
				return this.clips[i];
			}
		}
		return null;
	}

	// Token: 0x06001ECC RID: 7884 RVA: 0x00099583 File Offset: 0x00097783
	public tk2dSpriteAnimationClip GetClipById(int id)
	{
		if (id < 0 || id >= this.clips.Length || this.clips[id].Empty)
		{
			return null;
		}
		return this.clips[id];
	}

	// Token: 0x06001ECD RID: 7885 RVA: 0x000995B0 File Offset: 0x000977B0
	public int GetClipIdByName(string name)
	{
		for (int i = 0; i < this.clips.Length; i++)
		{
			if (this.clips[i].name == name)
			{
				return i;
			}
		}
		return -1;
	}

	// Token: 0x06001ECE RID: 7886 RVA: 0x000995E8 File Offset: 0x000977E8
	public int GetClipIdByName(tk2dSpriteAnimationClip clip)
	{
		for (int i = 0; i < this.clips.Length; i++)
		{
			if (this.clips[i] == clip)
			{
				return i;
			}
		}
		return -1;
	}

	// Token: 0x170003EC RID: 1004
	// (get) Token: 0x06001ECF RID: 7887 RVA: 0x00099618 File Offset: 0x00097818
	public tk2dSpriteAnimationClip FirstValidClip
	{
		get
		{
			for (int i = 0; i < this.clips.Length; i++)
			{
				if (!this.clips[i].Empty && this.clips[i].frames[0].spriteCollection != null && this.clips[i].frames[0].spriteId != -1)
				{
					return this.clips[i];
				}
			}
			return null;
		}
	}

	// Token: 0x04002409 RID: 9225
	public tk2dSpriteAnimationClip[] clips;
}
