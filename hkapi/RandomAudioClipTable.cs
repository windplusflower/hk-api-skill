using System;
using UnityEngine;

// Token: 0x020000BF RID: 191
[CreateAssetMenu(fileName = "RandomAudioClipTable", menuName = "Hollow Knight/Random Audio Clip Table", order = 1000)]
public class RandomAudioClipTable : ScriptableObject
{
	// Token: 0x060003FB RID: 1019 RVA: 0x00014048 File Offset: 0x00012248
	protected void Reset()
	{
		this.pitchMin = 1f;
		this.pitchMax = 1f;
	}

	// Token: 0x060003FC RID: 1020 RVA: 0x00014060 File Offset: 0x00012260
	public AudioClip SelectClip()
	{
		if (this.options.Length == 0)
		{
			return null;
		}
		if (this.options.Length == 1)
		{
			return this.options[0].Clip;
		}
		float num = 0f;
		for (int i = 0; i < this.options.Length; i++)
		{
			RandomAudioClipTable.Option option = this.options[i];
			num += option.Weight;
		}
		float num2 = UnityEngine.Random.Range(0f, num);
		float num3 = 0f;
		for (int j = 0; j < this.options.Length - 1; j++)
		{
			RandomAudioClipTable.Option option2 = this.options[j];
			num3 += option2.Weight;
			if (num2 < num3)
			{
				return option2.Clip;
			}
		}
		return this.options[this.options.Length - 1].Clip;
	}

	// Token: 0x060003FD RID: 1021 RVA: 0x00014130 File Offset: 0x00012330
	public float SelectPitch()
	{
		if (Mathf.Approximately(this.pitchMin, this.pitchMax))
		{
			return this.pitchMax;
		}
		return UnityEngine.Random.Range(this.pitchMin, this.pitchMax);
	}

	// Token: 0x060003FE RID: 1022 RVA: 0x00014160 File Offset: 0x00012360
	public void PlayOneShotUnsafe(AudioSource audioSource)
	{
		if (audioSource == null)
		{
			return;
		}
		AudioClip audioClip = this.SelectClip();
		if (audioClip == null)
		{
			return;
		}
		audioSource.pitch = this.SelectPitch();
		audioSource.PlayOneShot(audioClip);
	}

	// Token: 0x0400037F RID: 895
	[SerializeField]
	private RandomAudioClipTable.Option[] options;

	// Token: 0x04000380 RID: 896
	[SerializeField]
	private float pitchMin;

	// Token: 0x04000381 RID: 897
	[SerializeField]
	private float pitchMax;

	// Token: 0x020000C0 RID: 192
	[Serializable]
	private struct Option
	{
		// Token: 0x04000382 RID: 898
		public AudioClip Clip;

		// Token: 0x04000383 RID: 899
		[Range(1f, 10f)]
		public float Weight;
	}
}
